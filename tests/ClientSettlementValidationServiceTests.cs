using System;
using System.Collections.Generic;
using LOGICA.ApplicationLayer.Clients;

internal static class ClientSettlementValidationServiceTests
{
    private sealed class Context : IClientSettlementValidationContext
    {
        public readonly List<string> Calls = new List<string>();
        public string Id="C1", Name="Client", AmountText="15", Mode="ESPECES";
        public string FailAt;
        public readonly Exception Failure = new InvalidOperationException("input");
        public int AmountReads;
        private string Read(string key, string value) { Calls.Add(key); if (FailAt==key) throw Failure; return value; }
        public string ClientId { get { return Read("id",Id); } }
        public string ClientName { get { return Read("name",Name); } }
        public string Amount { get { AmountReads++; return Read("amount",AmountText); } }
        public string PaymentMode { get { return Read("mode",Mode); } }
    }
    static void Check(Context c, string expected, string calls)
    {
        string warning=ClientSettlementValidationService.FirstWarning(c);
        if(warning!=expected)throw new Exception("warning mismatch: "+warning+" vs "+expected);
        if(String.Join(",",c.Calls.ToArray())!=calls)
            throw new Exception("read order mismatch: "+String.Join(",",c.Calls.ToArray())+" vs "+calls);
    }
    public static int Main()
    {
        Check(new Context{Id=""},"Veuillez remplir le champ -ID_CLIENT- ","id");
        Check(new Context{Name=""},"Veuillez remplir le champ -CLIENT- ","id,name");
        Check(new Context{AmountText=""},"Veuillez remplir le champ -MONTANT- ","id,name,amount");
        Check(new Context{AmountText="-3"},"Veuillez remplir le champ -MONTANT- ","id,name,amount,amount");
        Check(new Context{AmountText="nonsense"},"Veuillez remplir le champ -MONTANT- ","id,name,amount,amount");
        Check(new Context{Mode=""},"Veuillez remplir le champ -MODE_P- ","id,name,amount,amount,mode");
        Check(new Context(),null,"id,name,amount,amount,mode");
        foreach(string step in new[]{"id","name","amount","mode"})
        {
            var c=new Context{FailAt=step};
            Exception e=null;
            try { ClientSettlementValidationService.FirstWarning(c); } catch(Exception x) {e=x;}
            if(!Object.ReferenceEquals(e,c.Failure))throw new Exception("exception identity changed: "+step);
        }
        Console.WriteLine("PASS original client settlement warning precedence, read order and failure propagation");
        return 0;
    }
}
