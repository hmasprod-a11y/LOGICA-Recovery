using System;
using System.Globalization;
using Microsoft.VisualBasic.CompilerServices;
using LOGICA.Domain;

internal static class CashDenominationTotalTests
{
    private static decimal Legacy(Func<int,string> readCount) { return new decimal(Convert.ToDouble(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(0m, decimal.Multiply(Conversions.ToDecimal(readCount(0)), 200m)), decimal.Multiply(Conversions.ToDecimal(readCount(1)), 100m)), decimal.Multiply(Conversions.ToDecimal(readCount(2)), 50m)), decimal.Multiply(Conversions.ToDecimal(readCount(3)), 20m)), decimal.Multiply(Conversions.ToDecimal(readCount(4)), 10m)), decimal.Multiply(Conversions.ToDecimal(readCount(5)), 5m)), decimal.Multiply(Conversions.ToDecimal(readCount(6)), 2m)), decimal.Multiply(Conversions.ToDecimal(readCount(7)), 1m))) + Convert.ToDouble(Conversions.ToDecimal(readCount(8))) * 0.5 + Convert.ToDouble(Conversions.ToDecimal(readCount(9))) * 0.2 + Convert.ToDouble(Conversions.ToDecimal(readCount(10))) * 0.1); }
    private static string Outcome(Func<decimal> action)
    {
        try { return "value:"+action().ToString(CultureInfo.InvariantCulture); }
        catch(Exception error) { return "error:"+error.GetType().FullName; }
    }
    public static int Main()
    {
        var original=CultureInfo.CurrentCulture;int assertions=0;
        try
        {
            foreach(string culture in new[]{"fr-MA","fr-FR","en-US"})
            {
                CultureInfo.CurrentCulture=CultureInfo.GetCultureInfo(culture);
                assertions+=2;
                if(CashDenominationTotal.Calculate(delegate(int index){return "0";})!=0m ||
                   CashDenominationTotal.Calculate(delegate(int index){return "1";})!=388.8m)
                    throw new Exception("Known counted-cash total changed");
                var random=new Random(423);
                for(int sample=0;sample<100;sample++)
                {
                    string[] inputs=new string[11];
                    for(int index=0;index<inputs.Length;index++)inputs[index]=(random.Next(-500,2000)/10m).ToString(CultureInfo.CurrentCulture);
                    int next=0;
                    string actual=Outcome(delegate{return CashDenominationTotal.Calculate(delegate(int index){if(index!=next++)throw new Exception("read order");return inputs[index];});});
                    string expected=Outcome(delegate{return Legacy(delegate(int index){return inputs[index];});});
                    assertions+=2;
                    if(actual!=expected || next!=11)throw new Exception("Mixed arithmetic or denomination read order changed");
                }
                for(int failedIndex=0;failedIndex<11;failedIndex++)
                {
                    int reads=0;Exception marker=new InvalidOperationException("denomination read"),caught=null;
                    try {CashDenominationTotal.Calculate(delegate(int index){reads++;if(index==failedIndex)throw marker;return "1";});}
                    catch(Exception error){caught=error;}
                    assertions+=2;
                    if(!Object.ReferenceEquals(marker,caught) || reads!=failedIndex+1)throw new Exception("Read failure continued or was wrapped");
                    reads=0;
                    string bad=Outcome(delegate{return CashDenominationTotal.Calculate(delegate(int index){reads++;return index==failedIndex?"CI_INVALID":"1";});});
                    assertions+=2;
                    if(!bad.StartsWith("error:") || reads!=failedIndex+1)throw new Exception("Conversion failure timing changed");
                }
                foreach(string edge in new[]{null,""," ","-1","0.5","0,5","79228162514264337593543950335"})
                {
                    string value=edge;
                    assertions++;
                    if(Outcome(delegate{return CashDenominationTotal.Calculate(delegate(int index){return index==0?value:"0";});})!=
                       Outcome(delegate{return Legacy(delegate(int index){return index==0?value:"0";});}))
                        throw new Exception("Boundary conversion/overflow changed");
                }
            }
            Console.WriteLine("PASS cash denomination total: "+assertions+" assertions; mixed arithmetic, cultures, lazy order and failure boundaries");
            return 0;
        }
        catch(Exception error){Console.Error.WriteLine(error);return 1;}
        finally{CultureInfo.CurrentCulture=original;}
    }
}
