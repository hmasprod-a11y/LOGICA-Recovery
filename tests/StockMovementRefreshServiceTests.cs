using System;
using System.Collections.Generic;
using LOGICA.ApplicationLayer.Inventory;

internal static class StockMovementRefreshServiceTests
{
    private sealed class Context : IStockMovementRefreshContext
    {
        public readonly List<string> Calls=new List<string>();
        public readonly Exception Failure=new InvalidOperationException("refresh failure");
        public string FailAt, State="previous";
        public bool Reentrant;
        private void Step(string name) { Calls.Add(name); if(name==FailAt)throw Failure; }
        public void FocusSender(){Step("sender");}
        public void ClearSearch()
        {
            Step("clear");
            if(Reentrant){Step("searchFromClear");State="dateResults";}
        }
        public void FocusSearch(){Step("focusSearch");}
        public void ReloadAll(){Step("reload");State="allResults";}
        public void BindResults(){Step("bind");}
    }
    public static int Main()
    {
        int assertions=0;
        try
        {
            string[] normal={"sender","clear","focusSearch","reload","bind"};
            var complete=new Context();
            StockMovementRefreshService.Refresh(complete);
            assertions+=2;
            if(String.Join(",",complete.Calls.ToArray())!=String.Join(",",normal) || complete.State!="allResults")
                throw new Exception("Refresh action order changed");
            var reentrant=new Context{Reentrant=true};
            StockMovementRefreshService.Refresh(reentrant);
            assertions+=2;
            if(String.Join(",",reentrant.Calls.ToArray())!="sender,clear,searchFromClear,focusSearch,reload,bind" ||
                reentrant.State!="allResults")
                throw new Exception("Reentrant search was moved or overrode final refresh");
            for(int fail=0;fail<normal.Length;fail++)
            {
                var context=new Context{FailAt=normal[fail]};Exception caught=null;
                try{StockMovementRefreshService.Refresh(context);}catch(Exception error){caught=error;}
                assertions+=2;
                if(!Object.ReferenceEquals(caught,context.Failure) || context.Calls.Count!=fail+1)
                    throw new Exception("Refresh failure identity or later actions changed");
                for(int index=0;index<=fail;index++){assertions++;if(context.Calls[index]!=normal[index])throw new Exception("Refresh prefix order changed");}
                assertions++;
                if(context.State!=(fail==4?"allResults":"previous"))throw new Exception("Partial refresh state changed");
            }
            var nestedFailure=new Context{Reentrant=true,FailAt="searchFromClear"};Exception nestedCaught=null;
            try{StockMovementRefreshService.Refresh(nestedFailure);}catch(Exception error){nestedCaught=error;}
            assertions+=2;
            if(!Object.ReferenceEquals(nestedCaught,nestedFailure.Failure) || nestedFailure.Calls.Count!=3)
                throw new Exception("Clear-search callback failure continued refresh");
            Console.WriteLine("PASS stock movement refresh service: "+assertions+" assertions; focus/clear/reload/bind order, reentrant search and first failure");
            return 0;
        }
        catch(Exception error){Console.Error.WriteLine(error);return 1;}
    }
}
