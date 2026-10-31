using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;
using LOGICA.Domain;

internal static class ClientSettlementSequenceTests
{
    private static int Original(Func<object> read)
    {
        return read() == DBNull.Value ? 1 : checked((int)Math.Round(Conversions.ToDouble(read()) + 1.0));
    }

    private static string Outcome(Func<object> read, bool useNew, out int calls)
    {
        int count=0;
        Func<object> counted=delegate { count++; return read(); };
        try { int id=useNew ? ClientSettlementSequence.NextId(counted) : Original(counted); calls=count; return "ok:"+id; }
        catch(Exception e) { calls=count; return "error:"+e.GetType().FullName; }
    }

    private static void Check(string name, params object[] values)
    {
        int ai=0,bi=0,ac,bc;
        Func<object> a=delegate { return values[Math.Min(ai++,values.Length-1)]; };
        Func<object> b=delegate { return values[Math.Min(bi++,values.Length-1)]; };
        string actual=Outcome(a,true,out ac),expected=Outcome(b,false,out bc);
        if(actual!=expected||ac!=bc)
            throw new Exception(name+" mismatch: "+actual+"/"+ac+" expected "+expected+"/"+bc);
    }

    public static int Main()
    {
        Check("empty aggregate",DBNull.Value);
        Check("zero",0,0);
        Check("positive",5,5);
        Check("negative",-2,-2);
        Check("fractional midpoint",1.5,1.5);
        Check("string maximum","17","17");
        Check("changed second read",5,8);
        Check("second DBNull",4,DBNull.Value);
        Check("first null",null,5);
        Check("overflow",int.MaxValue,int.MaxValue);
        Check("invalid conversion",10,"not a number");
        Check("negative fractional",-2.5,-2.5);
        Check("fractional double",3.49,3.49);
        Console.WriteLine("PASS original settlement sequence id parity and 1-vs-2 read ordering");
        return 0;
    }
}
