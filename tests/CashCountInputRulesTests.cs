using LOGICA.Infrastructure.Compatibility;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using LOGICA.Domain;

internal static class CashCountInputRulesTests
{
    private static bool Legacy(Func<object> read)
    {
        return (Operators.CompareString(Strings.Trim(Conversions.ToString(read())), "", false) == 0) |
            !Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(read()));
    }
    private static string Outcome(Func<bool> action)
    {
        try{return action()?"reset":"keep";}catch(Exception error){return error.GetType().FullName;}
    }
    public static int Main()
    {
        var original=CultureInfo.CurrentCulture;int assertions=0;
        try
        {
            foreach(string culture in new[]{"fr-MA","fr-FR","en-US"})
            {
                CultureInfo.CurrentCulture=CultureInfo.GetCultureInfo(culture);
                foreach(object value in new object[]{null,""," ","abc","0","-1","0.5","0,5",0,1m,true,DBNull.Value,new DateTime(2026,1,1)})
                {
                    object input=value;int actualReads=0,legacyReads=0;
                    string actual=Outcome(delegate{return CashCountInputRules.ShouldReset(delegate{actualReads++;return input;}, VisualBasicCashSemantics.Instance);});
                    string expected=Outcome(delegate{return Legacy(delegate{legacyReads++;return input;});});
                    assertions+=2;
                    if(actual!=expected || actualReads!=legacyReads)throw new Exception("Normalization value/read behavior changed");
                }
                foreach(string value in new[]{null,""," ","abc"})
                {
                    assertions++;
                    if(!CashCountInputRules.ShouldReset(delegate{return value;}, VisualBasicCashSemantics.Instance))throw new Exception("Invalid input no longer resets");
                }
                foreach(string value in new[]{"0","-1",0.5m.ToString(CultureInfo.CurrentCulture)})
                {
                    assertions++;
                    if(CashCountInputRules.ShouldReset(delegate{return value;}, VisualBasicCashSemantics.Instance))throw new Exception("Numeric input unexpectedly resets");
                }
                for(int failAt=0;failAt<2;failAt++)
                {
                    Exception marker=new InvalidOperationException("text read"),caught=null;int reads=0;
                    try{CashCountInputRules.ShouldReset(delegate{if(reads++==failAt)throw marker;return "";}, VisualBasicCashSemantics.Instance);}
                    catch(Exception error){caught=error;}
                    assertions+=2;
                    if(!Object.ReferenceEquals(marker,caught) || reads!=failAt+1)throw new Exception("Eager read failure changed");
                }
                int changedReads=0;
                bool reset=CashCountInputRules.ShouldReset(delegate{return changedReads++==0?"1":"abc";}, VisualBasicCashSemantics.Instance);
                assertions+=2;
                if(!reset || changedReads!=2)throw new Exception("Second text value was cached/skipped");
            }
            Console.WriteLine("PASS cash count input rules: "+assertions+" assertions; cultures, numeric reset, eager repeated reads and exception identity");
            return 0;
        }
        catch(Exception error){Console.Error.WriteLine(error);return 1;}
        finally{CultureInfo.CurrentCulture=original;}
    }
}
