using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using Hanouty.Desktop.Bootstrap;
using Hanouty.Desktop.Wpf;
using MySql.Data.MySqlClient;

internal static class Program
{
    static void Require(bool value,string message){if(!value)throw new InvalidOperationException(message);}
    static IEnumerable<T> Controls<T>(DependencyObject parent) where T:DependencyObject
    {foreach(var child in LogicalTreeHelper.GetChildren(parent).OfType<DependencyObject>()){if(child is T match)yield return match;foreach(var nested in Controls<T>(child))yield return nested;}}
    static IEnumerable<T> Visuals<T>(DependencyObject parent) where T:DependencyObject
    {for(var i=0;i<VisualTreeHelper.GetChildrenCount(parent);i++){var child=VisualTreeHelper.GetChild(parent,i);if(child is T match)yield return match;foreach(var nested in Visuals<T>(child))yield return nested;}}
    static void Capture(Window window,string path){window.UpdateLayout();var bitmap=new RenderTargetBitmap((int)Math.Ceiling(window.ActualWidth),(int)Math.Ceiling(window.ActualHeight),96,96,PixelFormats.Pbgra32);bitmap.Render(window);var encoder=new PngBitmapEncoder();encoder.Frames.Add(BitmapFrame.Create(bitmap));using var file=File.Create(path);encoder.Save(file);}
    [STAThread] static int Main(string[] args)
    {
        var result=1;var app=new Application{ShutdownMode=ShutdownMode.OnExplicitShutdown};
        var settings=CatalogueSettings.FromEnvironment();
        Require(new MySqlConnectionStringBuilder(settings.ConnectionString).Database=="hanouty_demo","Only dedicated demonstration data allowed.");
        var evidence=Path.GetFullPath(args[0]);Directory.CreateDirectory(evidence);
        using var db=new MySqlConnection(settings.ConnectionString);db.Open();
        object? Scalar(string sql){using var command=new MySqlCommand(sql,db);return command.ExecuteScalar();}
        var beforeStock=Convert.ToDecimal(Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='DEMO-1'"));
        var beforeCounter=Convert.ToInt32(Scalar("SELECT CL FROM TABLE_NUM WHERE ID=0"));
        var host=CatalogueHost.CreateCashierWorkstation(settings,"01");Exception? failure=null;
        void QueuePin(bool capture=false){host.Window.Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle,new Action(()=>{var prompt=app.Windows.Cast<Window>().SingleOrDefault(w=>w.Owner==host.Window&&Controls<PasswordBox>(w).Any());try{Require(prompt is not null,"PIN keypad did not open.");if(capture)Capture(prompt!,Path.Combine(evidence,"demo-pin.png"));Controls<PasswordBox>(prompt!).Single().Password="1234";Controls<Button>(prompt!).Single(b=>b.IsDefault).RaiseEvent(new RoutedEventArgs(Button.ClickEvent));}catch(Exception ex){failure=ex;prompt?.Close();}}));}
        host.Window.Loaded+=(_,_)=>host.Window.Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle,new Action(()=>{
            try{
                Require(WorkstationReadiness.IsReady(settings),"Demo database is not ready.");
                Require(Convert.ToInt32(Scalar("SELECT COUNT(*) FROM TABLE_ARTICLES"))==12,"Demo catalogue missing.");
                QueuePin(true);Require(host.Window.ShowPinLogin(),"Demo PIN rejected.");if(failure is not null)throw failure;
                Require(host.ViewModel.VisibleProducts.Single(p=>p.Id=="DEMO-1").DisplayUnitPriceMad==6m,"Original catalogue price not displayed.");
                host.ViewModel.SelectedFamily="Boissons";Require(host.ViewModel.VisibleProducts.Count==2,"Family selection did not filter original catalogue.");
                host.ViewModel.SelectedFamily="Toutes les familles";host.Window.UpdateLayout();
                Require(host.Window.RefreshTrustedBasketTotal(),"Signed-in empty basket total unavailable.");
                Capture(host.Window,Path.Combine(evidence,"demo-catalogue.png"));
                var tile=Visuals<Button>((ItemsControl)host.Window.FindName("TouchProductTiles")).Single(b=>b.DataContext is Hanouty.Desktop.Wpf.Presentation.ProductSummary { Id:"DEMO-1" });
                Require(tile.IsEnabled&&tile.Command is not null&&tile.Command.CanExecute(tile.CommandParameter),"Milk touch tile is not bound to selection.");
                tile.Command!.Execute(tile.CommandParameter);Require(host.Session.PendingCount==1,"Touch tile did not add milk.");
                host.ViewModel.ScannerText="1002";host.ViewModel.ScanCommand.Execute(null);Require(host.Session.PendingCount==2,"Barcode 1002 did not add water.");
                Require(host.Window.RefreshTrustedBasketTotal()&&((TextBlock)host.Window.FindName("TrustedBasketTotal")).Text=="11.00","Touch and scanner basket did not show the trusted 11 MAD total.");
                Capture(host.Window,Path.Combine(evidence,"demo-basket.png"));
                host.Window.Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle,new Action(()=>{var payment=app.Windows.OfType<CashierEntryDialog>().SingleOrDefault();try{Require(payment is not null,"Fixed pay button did not open cash calculator.");Capture(payment!,Path.Combine(evidence,"demo-cash.png"));foreach(var coin in new[]{"10 MAD","1 MAD"})Controls<Button>(payment!).Single(b=>System.Windows.Automation.AutomationProperties.GetName(b)==coin).RaiseEvent(new RoutedEventArgs(Button.ClickEvent));QueuePin();Controls<Button>(payment!).Single(b=>b.IsDefault).RaiseEvent(new RoutedEventArgs(Button.ClickEvent));}catch(Exception ex){failure=ex;payment?.Close();}}));
                var pay=(Button)host.Window.FindName("CompleteCheckoutButton");Require(pay.IsEnabled,"Payment action disabled before receiving cash.");pay.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));if(failure is not null)throw failure;
                Require(host.Session.PendingCount==0&&!host.ViewModel.CheckoutUncertain,"Demo sale failed.");
                Require(Convert.ToDecimal(Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='DEMO-1'"))==beforeStock-1&&Convert.ToInt32(Scalar("SELECT CL FROM TABLE_NUM WHERE ID=0"))==beforeCounter+1,"Stock and counter not posted.");
                Require(Convert.ToDecimal(Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='DEMO-2'"))==beforeStock-1&&Convert.ToInt32(Scalar("SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL"))==(beforeCounter+1)*2&&Convert.ToDecimal(Scalar("SELECT SUM(MONTANT) FROM TABLE_VENTES_REGLEMENTS"))==(beforeCounter+1)*11m,"Two-article sale lost a line or posted an incorrect cash amount.");
                Require(((TextBlock)host.Window.FindName("TrustedBasketTotal")).Text=="0.00","Next-customer total not reset.");
                Capture(host.Window,Path.Combine(evidence,"demo-sale.png"));
                File.WriteAllText(Path.Combine(evidence,"demo-ui.json"),JsonSerializer.Serialize(new{NoLogicaConfiguration=true,TwelveProducts=true,Pin1234=true,TouchSelection=true,OriginalPriceVisible=true,FamilyFilter=true,Scanner1002=true,FixedPayButton=true,CoinsAndFreshPin=true,StockAndCounter=true,NextCustomerTotal=true,PreviousCounter=beforeCounter,CurrentCounter=beforeCounter+1}));result=0;
            }catch(Exception ex){Console.Error.WriteLine(ex);}finally{host.Window.Close();app.Shutdown();}
        }));
        app.Run(host.Window);return result;
    }
}
