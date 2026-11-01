using System;
using LOGICA.Domain;
using LOGICA.ApplicationLayer.Clients;

internal static class ClientSettlementCompatibilityPortTests
{
    private sealed class Spy : ILegacySettlementSemantics
    {
        internal int EmptyCalls, AmountCalls, NumberCalls;
        internal double AmountValue = 15;
        internal Exception NumberFailure;
        public bool IsEmpty(string value) { EmptyCalls++; return value == null || value == ""; }
        public double ParseAmount(string value) { AmountCalls++; return AmountValue; }
        public double ToDouble(object value)
        {
            NumberCalls++;
            if (NumberFailure != null) throw NumberFailure;
            return Convert.ToDouble(value);
        }
    }

    private sealed class Fields : IClientSettlementValidationContext
    {
        internal int AmountReads;
        public string ClientId { get { return "C1"; } }
        public string ClientName { get { return "Client"; } }
        public string Amount { get { AmountReads++; return "15"; } }
        public string PaymentMode { get { return "ESPECES"; } }
    }

    private static void Require(bool condition, string message)
    {
        if (!condition) throw new Exception(message);
    }

    public static int Main()
    {
        var spy = new Spy();
        Require(!ClientSettlementAmountRule.IsRejected("any", spy), "Domain must use the injected amount parser");
        Require(spy.AmountCalls == 1, "Amount parser not called exactly once");
        spy.AmountValue = -1;
        Require(ClientSettlementAmountRule.IsRejected("any", spy), "Domain must use injected rejection semantics");

        spy = new Spy();
        var fields = new Fields();
        Require(ClientSettlementValidationService.FirstWarning(fields, spy) == null, "Unexpected warning");
        Require(fields.AmountReads == 2, "Legacy validation must read amount twice");
        Require(spy.EmptyCalls == 4 && spy.AmountCalls == 1, "Validation did not use injected port");

        spy = new Spy();
        int reads = 0;
        int id = ClientSettlementSequence.NextId(delegate { reads++; return reads == 1 ? (object)5 : 8; }, spy);
        Require(id == 9 && reads == 2 && spy.NumberCalls == 1, "Sequence must preserve two reads and injected conversion");

        spy = new Spy();
        reads = 0;
        id = ClientSettlementSequence.NextId(delegate { reads++; return DBNull.Value; }, spy);
        Require(id == 1 && reads == 1 && spy.NumberCalls == 0, "DBNull must bypass conversion and second read");

        spy = new Spy();
        var failure = new InvalidOperationException("converter");
        spy.NumberFailure = failure;
        Exception observed = null;
        try { ClientSettlementSequence.NextId(delegate { return 5; }, spy); }
        catch (Exception e) { observed = e; }
        Require(Object.ReferenceEquals(failure, observed), "Injected conversion failure identity must survive");

        Console.WriteLine("PASS Domain/Application settlement ports: injected semantics, read counts and exception propagation");
        return 0;
    }
}
