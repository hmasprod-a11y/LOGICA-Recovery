using LOGICA.Infrastructure.Compatibility;
using System;
using System.Collections.Generic;
using LOGICA.ApplicationLayer.Cash;

internal static class CashRecountServiceTests
{
    private sealed class Context : ICashRecountContext
    {
        public readonly List<string> Calls=new List<string>();
        public readonly Dictionary<int,decimal> Rows=new Dictionary<int,decimal>();
        public readonly Exception Failure=new InvalidOperationException("recount failure");
        public string FailAt, SenderText="1";
        public string[] Counts={"1","1","1","1","1","1","1","1","1","1","1"};
        public object[] Modes={"ESPECES","CARTE","ESPECES","especes"};
        public decimal? Total;
        private void Step(string name){Calls.Add(name);if(name==FailAt)throw Failure;}
        public void ResetBackground(){Step("background");}
        public object ReadSenderText(){Step("sender");return SenderText;}
        public void ResetSender(){Step("reset");SenderText="0";Counts[0]="0";}
        public string ReadDenomination(int index){Step("count"+index);return Counts[index];}
        public void DisplayTotal(decimal total){Step("total");Total=total;}
        public int LastPaymentIndex{get{Step("last");return Modes.Length-1;}}
        public object ReadPaymentMode(int index){Step("mode"+index);return Modes[index];}
        public void DisplayCashRow(int index,decimal total){Step("row"+index);Rows[index]=total;}
    }
    public static int Main()
    {
        int assertions=0;
        try
        {
            var full=new Context();CashRecountService.Recount(full, VisualBasicCashSemantics.Instance);
            var expected=new List<string>{"background","sender","sender"};
            for(int index=0;index<11;index++)expected.Add("count"+index);
            expected.AddRange(new[]{"total","last","mode0","row0","mode1","mode2","row2","mode3"});
            assertions+=4;
            if(String.Join(",",full.Calls.ToArray())!=String.Join(",",expected.ToArray()) ||
               full.Total!=388.8m || full.Rows.Count!=2 || full.Rows[0]!=388.8m || full.Rows[2]!=388.8m)
                throw new Exception("Recount ordering or cash-row matching changed");
            var invalid=new Context{SenderText=""};CashRecountService.Recount(invalid, VisualBasicCashSemantics.Instance);
            assertions+=3;
            if(invalid.Total!=188.8m || invalid.Calls[3]!="reset" || invalid.SenderText!="0")
                throw new Exception("Reset happened after denomination reads");
            var empty=new Context{Modes=new object[0]};CashRecountService.Recount(empty, VisualBasicCashSemantics.Instance);
            assertions+=2;
            if(empty.Rows.Count!=0 || empty.Calls[empty.Calls.Count-1]!="last")throw new Exception("Empty payment grid read rows");
            foreach(string stage in new[]{"background","sender","count0","count10","total","last","mode0","row0","mode1","mode2","row2","mode3"})
            {
                var context=new Context{FailAt=stage};Exception caught=null;
                try{CashRecountService.Recount(context, VisualBasicCashSemantics.Instance);}catch(Exception error){caught=error;}
                int count=expected.IndexOf(stage)+1;
                assertions+=2;
                if(!Object.ReferenceEquals(caught,context.Failure) || context.Calls.Count!=count)
                    throw new Exception("Failure was wrapped or later work continued");
                for(int index=0;index<count;index++){assertions++;if(context.Calls[index]!=expected[index])throw new Exception("Failure ordering changed");}
                assertions++;
                int expectedRows=stage=="mode1" || stage=="mode2" || stage=="row2"?1:stage=="mode3"?2:0;
                if(context.Rows.Count!=expectedRows)throw new Exception("Partial payment-row updates changed");
            }
            Console.WriteLine("PASS cash recount service: "+assertions+" assertions; normalization/calculation/display order, exact cash rows and partial failures");
            return 0;
        }
        catch(Exception error){Console.Error.WriteLine(error);return 1;}
    }
}
