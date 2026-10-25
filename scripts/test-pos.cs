using System;
using System.IO;
using System.Reflection;
using System.Globalization;
using System.Windows.Forms;
using System.Drawing;
class PosSmoke {
 [STAThread] static int Main(string[] args) {
  try {
   Application.EnableVisualStyles();
   var assembly=Assembly.LoadFrom(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"LOGICA.exe"));
   if(args[0]=="rounding") {
    var method=assembly.GetType("LOGICA.Module1",true).GetMethod("FLOUSS");
    foreach(var culture in new[]{"fr-MA","fr-FR","en-US"}) {
     CultureInfo.CurrentCulture=CultureInfo.GetCultureInfo(culture);
     decimal[] values={0m,1.005m,12.345m,-1.005m,9999.995m};
     decimal[] expected={0m,1.01m,12.35m,-1.01m,10000m};
     for(int i=0;i<values.Length;i++) {
      var result=(decimal)method.Invoke(null,new object[]{values[i]});
      if(result!=expected[i])throw new Exception("FLOUSS incorrect: "+values[i]+" -> "+result);
      Console.WriteLine("PASS monetary rounding "+culture+" "+values[i]+" = "+result);
     }
    }
   } else {
    string name=args[0];
    using(var form=(Form)Activator.CreateInstance(assembly.GetType("LOGICA."+name,true))) {
     if(form.Controls.Count==0)throw new Exception("No controls initialized");
     Console.WriteLine("PASS original form constructor "+name+" controls="+form.Controls.Count);
     // Handle creation exercises native controls, Bunifu initialization and .sni loading.
     var handle=form.Handle;
     Console.WriteLine("PASS native window handle "+name+" "+handle);
     using(var bitmap=new Bitmap(Math.Max(1,form.Width),Math.Max(1,form.Height))) {
      form.DrawToBitmap(bitmap,new Rectangle(0,0,bitmap.Width,bitmap.Height));
      bitmap.Save(Path.Combine("..","results",name+".png"));
     }
     Console.WriteLine("PASS render original form "+name);
    }
   }
   return 0;
  } catch(Exception e) {Console.WriteLine("FAIL "+e); return 1;}
 }
}
