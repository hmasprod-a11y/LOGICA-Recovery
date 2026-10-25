using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA.My.Resources;

[CompilerGenerated]
[HideModuleName]
[StandardModule]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[DebuggerNonUserCode]
internal sealed class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(resourceMan, null))
			{
				ResourceManager resourceManager = new ResourceManager("LOGICA.Resources", typeof(Resources).Assembly);
				resourceMan = resourceManager;
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static Bitmap dot_13
	{
		get
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected Obj, but got Unknown
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("dot_13", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap Picture_CONS_Image
	{
		get
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected Obj, but got Unknown
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Picture_CONS.Image", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap Picture_MODIF_Image
	{
		get
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected Obj, but got Unknown
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Picture_MODIF.Image", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap Picture_PRINT_Image
	{
		get
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected Obj, but got Unknown
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Picture_PRINT.Image", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap Picture_SUPP_Image
	{
		get
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected Obj, but got Unknown
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Picture_SUPP.Image", resourceCulture));
			return (Bitmap)objectValue;
		}
	}
}
