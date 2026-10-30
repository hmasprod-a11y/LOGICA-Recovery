using System;
using System.Collections.Generic;
using LOGICA.ApplicationLayer.Clients;

internal static class ClientSettlementRowWriterTests
{
    private sealed class Context : IClientSettlementRowContext
    {
        internal readonly List<string> Events = new List<string>();
        internal readonly Dictionary<string, object> Row = new Dictionary<string, object>();
        internal string FailAt;
        internal readonly Exception Error = new InvalidOperationException("injected settlement input failure");
        private object Read(string name, object value) { Events.Add("read:" + name); if (FailAt == "read:" + name) throw Error; return value; }
        public object ReadId() { return Read("ID", 42); }
        public object ReadDate() { return Read("DATES", new DateTime(2026, 1, 2)); }
        public object ReadUser() { return Read("UTILISATEUR", "cashier"); }
        public object ReadDocumentId() { return Read("ID_REGLE", "DOC001"); }
        public object ReadClientId() { return Read("ID_CLIENT", "C001"); }
        public object ReadClientCode() { return Read("CODE_CLIENT", "BC001"); }
        public object ReadClientName() { return Read("CLIENT", "client"); }
        public object ReadAmount() { return Read("MONTANT", "100.50"); }
        public object ReadPaymentMode() { return Read("MODE_P", "ESPECES"); }
        public object ReadNotes() { return Read("NOTES", "note"); }
        public void Set(string col, object val) { Events.Add("set:" + col); if (FailAt == "set:" + col) throw Error; Row[col] = val; }
    }
    private static readonly string[] Columns = {"ID","DATES","UTILISATEUR","ID_REGLE","ID_CLIENT","CODE_CLIENT","CLIENT","MONTANT","MODE_P","NOTES","ETAT"};

    private static void Verify(string failAt)
    {
        var c = new Context { FailAt = failAt };
        Exception caught = null;
        try { ClientSettlementRowWriter.Populate(c); } catch (Exception e) { caught = e; }
        if (failAt == null && caught != null) throw caught;
        if (failAt != null && !Object.ReferenceEquals(caught, c.Error)) throw new Exception("Failure identity changed: " + failAt);
        var expected = new List<string>();
        foreach (var name in Columns)
        {
            if (name != "ETAT") expected.Add("read:" + name);
            expected.Add("set:" + name);
        }
        if (failAt != null) expected.RemoveRange(expected.IndexOf(failAt) + 1, expected.Count - expected.IndexOf(failAt) - 1);
        if (String.Join(",", expected.ToArray()) != String.Join(",", c.Events.ToArray()))
            throw new Exception("Read/write order changed at " + (failAt ?? "success") + ": " + String.Join(",", c.Events.ToArray()));
        if (failAt == null)
        {
            if (c.Row.Count != 11 || (string)c.Row["ETAT"] != "VALIDER" || (string)c.Row["MONTANT"] != "100.50")
                throw new Exception("Mapped settlement row differs");
        }
    }
    public static int Main()
    {
        Verify(null);
        foreach (var name in Columns)
        {
            Verify("set:" + name);
            if (name != "ETAT") Verify("read:" + name);
        }
        Console.WriteLine("PASS client settlement row assignment order, values and 21 read/write failure boundaries");
        return 0;
    }
}
