using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;

namespace LOGICA;

public class SettingsManager
{
	private readonly string _filePath;

	public SettingsManager(string filePath)
	{
		_filePath = filePath;
	}

	public void SaveControls(string formName, IEnumerable<Control> controls)
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		List<ControlSettings> list = new List<ControlSettings>();
		if (File.Exists(_filePath))
		{
			string text = File.ReadAllText(_filePath);
			list = JsonConvert.DeserializeObject<List<ControlSettings>>(text);
		}
		IEnumerator<Control> enumerator = default;
		try
		{
			enumerator = controls.GetEnumerator();
			Control current;
			while (enumerator.MoveNext())
			{
				current = enumerator.Current;
				string controlValue = "";
				if (current is TextBox)
				{
					controlValue = ((TextBox)current).Text;
				}
				else if (current is ComboBox)
				{
					controlValue = ((ComboBox)current).Text;
				}
				else if (current is ListBox)
				{
					controlValue = ((ListBox)current).Text;
				}
				else if (current is CheckBox)
				{
					controlValue = ((CheckBox)current).Checked.ToString();
				}
				else if (current is RadioButton)
				{
					controlValue = ((RadioButton)current).Checked.ToString();
				}
				ControlSettings controlSettings = list.FirstOrDefault([SpecialName] (ControlSettings s) => (Operators.CompareString(s.FormName, formName, TextCompare: false) == 0 && Operators.CompareString(s.ControlName, current.Name, TextCompare: false) == 0) ? true : false);
				if (controlSettings != null)
				{
					controlSettings.ControlValue = controlValue;
					continue;
				}
				list.Add(new ControlSettings
				{
					FormName = formName,
					ControlName = current.Name,
					ControlValue = controlValue
				});
			}
		}
		finally
		{
			enumerator?.Dispose();
		}
		string contents = JsonConvert.SerializeObject((object)list, (Formatting)1);
		File.WriteAllText(_filePath, contents);
	}

	public void LoadControls(string formName, IEnumerable<Control> controls)
	{
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		if (!File.Exists(_filePath))
		{
			return;
		}
		string text = File.ReadAllText(_filePath);
		List<ControlSettings> source = JsonConvert.DeserializeObject<List<ControlSettings>>(text);
		IEnumerator<ControlSettings> enumerator = default;
		try
		{
			enumerator = source.Where([SpecialName] (ControlSettings s) => Operators.CompareString(s.FormName, formName, TextCompare: false) == 0).GetEnumerator();
			ControlSettings current;
			while (enumerator.MoveNext())
			{
				current = enumerator.Current;
				Control val = controls.FirstOrDefault([SpecialName] (Control c) => Operators.CompareString(c.Name, current.ControlName, TextCompare: false) == 0);
				if (val != null)
				{
					if (val is TextBox)
					{
						((TextBox)val).Text = current.ControlValue;
					}
					else if (val is ComboBox)
					{
						((ComboBox)val).Text = current.ControlValue;
					}
					else if (val is ListBox)
					{
						((ListBox)val).Text = current.ControlValue;
					}
					else if (val is CheckBox)
					{
						((CheckBox)val).Checked = bool.Parse(current.ControlValue);
					}
					else if (val is RadioButton)
					{
						((RadioButton)val).Checked = bool.Parse(current.ControlValue);
					}
				}
			}
		}
		finally
		{
			enumerator?.Dispose();
		}
	}
}
