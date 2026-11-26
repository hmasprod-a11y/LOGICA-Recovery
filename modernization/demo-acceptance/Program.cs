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
        var host=CatalogueHost.CreateDailyCashierWorkstation(settings,"01");Exception? failure=null;
        var pinGuard=new DispatcherTimer{Interval=TimeSpan.FromMilliseconds(100)};
        pinGuard.Tick+=(_,_)=>{if(app.Windows.Cast<Window>().Any(w=>w.IsVisible&&Controls<PasswordBox>(w).Any())){Console.Error.WriteLine("An ordinary authenticated operation requested another PIN.");Environment.Exit(1);}};
        void QueuePin(bool capture=false){host.Window.Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle,new Action(()=>{var prompt=app.Windows.Cast<Window>().SingleOrDefault(w=>w.Owner==host.Window&&Controls<PasswordBox>(w).Any());try{Require(prompt is not null,"PIN keypad did not open.");if(capture)Capture(prompt!,Path.Combine(evidence,"demo-pin.png"));Controls<PasswordBox>(prompt!).Single().Password="1234";Controls<Button>(prompt!).Single(b=>b.IsDefault).RaiseEvent(new RoutedEventArgs(Button.ClickEvent));}catch(Exception ex){failure=ex;prompt?.Close();}}));}
        void VisitSection(string buttonName,string expectedType,string image)
        {
            var opened=false;var stockEditorOpened=false;var articleCreated=false;var expires=DateTime.UtcNow.AddSeconds(20);
            var timer=new DispatcherTimer{Interval=TimeSpan.FromMilliseconds(100)};
            timer.Tick+=(_,_)=>{
                if(DateTime.UtcNow>expires){Console.Error.WriteLine("Section did not open: "+buttonName);Environment.Exit(1);}
                foreach(var modal in app.Windows.Cast<Window>().Where(w=>w.Owner==host.Window&&w.IsVisible).Reverse().ToArray())
                {
                    if(Controls<PasswordBox>(modal).Any())throw new InvalidOperationException("Opening a section requested a repeated PIN.");
                    if(modal is DailyStockAdjustmentDialog){return;}
                    if(modal.GetType().Name==expectedType)
                    {
                        if(modal is DailyStockDialog&&!articleCreated)
                        {
                            host.Window.Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle,new Action(()=>{
                                var editor=app.Windows.OfType<CataloguePriceDialog>().Single(w=>w.IsVisible);
                                TextBox Field(string label)=>Controls<TextBox>(editor).Single(t=>System.Windows.Automation.AutomationProperties.GetName(t)==label);
                                Field("Nom du nouvel article").Text="Article ajouté depuis le stock";
                                Field("Code-barres du nouvel article").Text="NEW-"+beforeCounter;
                                Controls<ComboBox>(editor).Single(t=>System.Windows.Automation.AutomationProperties.GetName(t)=="Famille du nouvel article").SelectedItem="Epicerie";
                                Field("Prix du nouvel article").Text="7";
                                Controls<Button>(editor).Single(b=>Equals(b.Content,"Créer l’article")).RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                                Require(Convert.ToInt32(Scalar("SELECT COUNT(*) FROM TABLE_ARTICLES WHERE Code='NEW-"+beforeCounter+"' AND PRIX_V_1=7"))==1,"Stock workspace did not create the article: "+string.Join(" | ",Controls<TextBlock>(editor).Select(t=>t.Text)));
                                Capture(editor,Path.Combine(evidence,"demo-new-article.png"));articleCreated=true;editor.Close();
                            }));
                            Controls<Button>(modal).Single(b=>Equals(b.Content,"Ajouter un article")).RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                            Require(articleCreated,"New article action was ignored.");
                        }
                        if(modal is DailyStockDialog&&!stockEditorOpened)
                        {
                            var grid=Controls<DataGrid>(modal).Single(g=>System.Windows.Automation.AutomationProperties.GetName(g)=="Articles et stocks trouvés");
                            foreach (var adjustmentMode in new[] {0,1,2})
                            {
                            stockEditorOpened=false;
                            grid.SelectedItem=grid.Items.Cast<DailyStockReader.Article>().Single(a=>a.Id=="DEMO-3");
                            var adjust=Controls<Button>(modal).Single(b=>System.Windows.Automation.AutomationProperties.GetName(b)=="Modifier le stock de l’article");
                            Require(adjust.IsEnabled,"Integrated stock adjustment action is disabled.");
                            host.Window.Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle,new Action(()=>{
                                var editor=app.Windows.OfType<DailyStockAdjustmentDialog>().SingleOrDefault(w=>w.IsVisible);
                                if(editor is null){Console.Error.WriteLine("Integrated stock adjustment editor missing.");Environment.Exit(1);return;}
                                var before = Convert.ToDecimal(Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='DEMO-3'"));
                                Controls<ComboBox>(editor).Single(c=>System.Windows.Automation.AutomationProperties.GetName(c)=="Action sur le stock").SelectedIndex=adjustmentMode;
                                Controls<TextBox>(editor).Single().Text=adjustmentMode==2?"7":"2";
                                Capture(editor,Path.Combine(evidence,"demo-stock-editor.png"));
                                Controls<Button>(editor).Single(b=>b.IsDefault).RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                                Require(!editor.IsVisible && Convert.ToDecimal(Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='DEMO-3'"))==(adjustmentMode==0?before+2:adjustmentMode==1?before-2:7),"Stock editor failed to persist the requested quantity through the actual daily host.");
                                stockEditorOpened=true;
                            }));
                            adjust.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                            Require(stockEditorOpened,"Integrated stock adjustment did not open its editor.");
                            }
                        }
                        Capture(modal,Path.Combine(evidence,image));opened=true;modal.Close();return;
                    }
                }
            };
            timer.Start();try{var button=Controls<Button>(host.Window).Single(b=>System.Windows.Automation.AutomationProperties.GetName(b)==buttonName);Require(button.IsEnabled,"Section disabled: "+buttonName);button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));}finally{timer.Stop();}
            Require(opened,"Section ignored its click: "+buttonName);
        }
        host.Window.Loaded+=(_,_)=>host.Window.Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle,new Action(()=>{
            try{
                Require(WorkstationReadiness.IsReady(settings),"Demo database is not ready.");
                Require(Convert.ToInt32(Scalar("SELECT COUNT(*) FROM TABLE_ARTICLES"))==12+beforeCounter,"Demo catalogue missing or a previous created article was lost.");
                QueuePin(true);Require(host.Window.ShowPinLogin(),"Demo PIN rejected.");if(failure is not null)throw failure;
                pinGuard.Start();
                Require(host.ViewModel.VisibleProducts.Single(p=>p.Id=="DEMO-1").DisplayUnitPriceMad==6m,"Original catalogue price not displayed.");
                host.ViewModel.SelectedFamily="Boissons";Require(host.ViewModel.VisibleProducts.Count==Convert.ToInt32(Scalar("SELECT COUNT(*) FROM TABLE_ARTICLES WHERE Famille='Boissons'")),"Family selection did not filter original catalogue.");
                host.ViewModel.SelectedFamily="Toutes les familles";host.Window.UpdateLayout();
                Require(host.Window.RefreshTrustedBasketTotal(),"Signed-in empty basket total unavailable.");
                Capture(host.Window,Path.Combine(evidence,"demo-catalogue.png"));
                var tile=Visuals<Button>((ItemsControl)host.Window.FindName("TouchProductTiles")).Single(b=>b.DataContext is Hanouty.Desktop.Wpf.Presentation.ProductSummary { Id:"DEMO-1" });
                Require(tile.IsEnabled&&tile.Command is not null&&tile.Command.CanExecute(tile.CommandParameter),"Milk touch tile is not bound to selection.");
                tile.Command!.Execute(tile.CommandParameter);Require(host.Session.PendingCount==1,"Touch tile did not add milk.");
                host.ViewModel.ScannerText="1002";host.ViewModel.ScanCommand.Execute(null);Require(host.Session.PendingCount==2,"Barcode 1002 did not add water.");
                Require(host.Window.RefreshTrustedBasketTotal()&&((TextBlock)host.Window.FindName("TrustedBasketTotal")).Text=="11.00","Touch and scanner basket did not show the trusted 11 MAD total.");
                host.Window.UpdateLayout();
                var basketButtons=Visuals<Button>((DataGrid)host.Window.FindName("CashierBasket")).Where(b=>b.Content is string glyph&&glyph is "+" or "−" or "×").ToArray();
                Require(basketButtons.Length>=6&&basketButtons.All(b=>b.ActualWidth-b.Padding.Left-b.Padding.Right>=18),"Quantity or remove glyph is clipped inside its basket button.");
                Capture(host.Window,Path.Combine(evidence,"demo-basket.png"));
                host.Window.Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle,new Action(()=>{var payment=app.Windows.OfType<CashierEntryDialog>().SingleOrDefault();try{Require(payment is not null,"Fixed pay button did not open cash calculator.");Capture(payment!,Path.Combine(evidence,"demo-cash.png"));foreach(var coin in new[]{"10 MAD","1 MAD"})Controls<Button>(payment!).Single(b=>System.Windows.Automation.AutomationProperties.GetName(b)==coin).RaiseEvent(new RoutedEventArgs(Button.ClickEvent));Controls<Button>(payment!).Single(b=>b.IsDefault).RaiseEvent(new RoutedEventArgs(Button.ClickEvent));}catch(Exception ex){failure=ex;payment?.Close();}}));
                var pay=(Button)host.Window.FindName("CompleteCheckoutButton");Require(pay.IsEnabled,"Payment action disabled before receiving cash.");pay.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));if(failure is not null)throw failure;
                Require(host.Session.PendingCount==0&&!host.ViewModel.CheckoutUncertain,"Demo sale failed.");
                Require(Convert.ToDecimal(Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='DEMO-1'"))==beforeStock-1&&Convert.ToInt32(Scalar("SELECT CL FROM TABLE_NUM WHERE ID=0"))==beforeCounter+1,"Stock and counter not posted.");
                Require(Convert.ToDecimal(Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='DEMO-2'"))==beforeStock-1&&Convert.ToInt32(Scalar("SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL"))==(beforeCounter+1)*2&&Convert.ToDecimal(Scalar("SELECT SUM(MONTANT) FROM TABLE_VENTES_REGLEMENTS"))==(beforeCounter+1)*11m,"Two-article sale lost a line or posted an incorrect cash amount.");
                Require(((TextBlock)host.Window.FindName("TrustedBasketTotal")).Text=="0.00","Next-customer total not reset.");
                Capture(host.Window,Path.Combine(evidence,"demo-sale.png"));
                VisitSection("Ouvrir les articles et le stock","DailyStockDialog","demo-stock.png");
                VisitSection("Ouvrir le journal des ventes","SalesJournalDialog","demo-journal.png");
                VisitSection("Ouvrir les statistiques des ventes","SalesJournalDialog","demo-statistics.png");
                VisitSection("Paramètres du poste","WorkstationSettingsMenu","demo-settings.png");
                File.WriteAllText(Path.Combine(evidence,"demo-ui.json"),JsonSerializer.Serialize(new{NoLogicaConfiguration=true,TwelveProducts=true,Pin1234=true,TouchSelection=true,OriginalPriceVisible=true,FamilyFilter=true,Scanner1002=true,FixedPayButton=true,CashCalculatorWithoutRepeatedPin=true,OnePinAtLogin=true,StockAndCounter=true,NextCustomerTotal=true,StockSectionOpens=true,StockEditorWrites=true,ThreeStockModesPersisted=true,CreateArticleFromStock=true,JournalSectionOpens=true,StatisticsSectionOpens=true,SettingsSectionOpens=true,PreviousCounter=beforeCounter,CurrentCounter=beforeCounter+1}));result=0;
            }catch(Exception ex){Console.Error.WriteLine(ex);}finally{pinGuard.Stop();host.Window.Close();app.Shutdown();}
        }));
        app.Run(host.Window);return result;
    }
}
