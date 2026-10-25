using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Text;
using LOGICA.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[StandardModule]
internal sealed class Module1
{
	public static string _CHEMIN_DB;

	public static string _CHEMIN_FOLDER;

	public static string _NAME_DB;

	private static string _PORT_DB;

	private static string _USER_ID;

	private static string _PASS_ID;

	public static MySqlConnection cn_SQL;

	public static MySqlDataAdapter da1;

	public static DataTable dt1;

	public static DataTable dt_LA;

	public static MySqlDataAdapter da_LA;

	public static DataTable dt_find;

	public static MySqlDataAdapter da_find;

	public static DataTable _DT_TEMP;

	public static MySqlDataAdapter _DA_TEMP;

	public static string _USERNAME;

	public static string _USERCATEGORIE;

	public static bool _acces;

	public static bool _quittersolder;

	public static bool _QUITTER_PATIENTER;

	public static bool _quitter_pesee;

	private static ArrayList bitsCode;

	public static string Binaryz;

	public static decimal FLOUSS(decimal num)
	{
		return Conversions.ToDecimal(Math.Round(num, 2, MidpointRounding.AwayFromZero).ToString("N2"));
	}

	public static string XOR_Encrypt(string Input, string pass)
	{
		StringBuilder stringBuilder = new StringBuilder();
		checked
		{
			int num = Input.Length - 1;
			int num2 = 0;
			int num5 = default;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				string text = Conversion.Hex(Strings.Asc(Input[num2]) ^ Strings.Asc(pass[num5]));
				if (text.Length == 1)
				{
					text = "0" + text;
				}
				stringBuilder.Append(text);
				num5 = ((num5 != pass.Length - 1) ? (num5 + 1) : 0);
				num2++;
			}
			return stringBuilder.ToString();
		}
	}

	public static string XOR_Decrypt(string Input, string pass)
	{
		StringBuilder stringBuilder = new StringBuilder();
		checked
		{
			int num = Input.Length - 1;
			int num2 = 0;
			int num5 = default;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				string value = Conversions.ToString(Strings.Chr((int)(Conversions.ToLong("&H" + Input.Substring(num2, 2)) ^ Strings.Asc(pass[num5]))));
				stringBuilder.Append(value);
				num5 = ((num5 != pass.Length - 1) ? (num5 + 1) : 0);
				num2 += 2;
			}
			return stringBuilder.ToString();
		}
	}

	public static string ConvNumberLetter(double TheNo, byte Langue)
	{
		if (TheNo == 0.0)
		{
			return "Zéro";
		}
		if (TheNo < 0.0)
		{
			bool flag = true;
			TheNo = Math.Abs(TheNo);
		}
		object obj = Conversion.Int(TheNo);
		byte b = checked((byte)Conversions.ToInteger(Operators.MultiplyObject(Operators.SubtractObject(TheNo, obj), 100)));
		if (b == 0)
		{
			if (Operators.ConditionalCompareObjectGreater(obj, 999999999999999.0, TextCompare: false))
			{
				return "#TropGrand";
			}
		}
		else if (Operators.ConditionalCompareObjectGreater(obj, 9999999999999.99, TextCompare: false))
		{
			return "#TropGrand";
		}
		string text = " Dirham";
		string text2 = " Centime";
		if (b == 1)
		{
			text2 += ".";
		}
		if (b > 1)
		{
			text2 += "s.";
		}
		if (Operators.ConditionalCompareObjectGreater(obj, 1, TextCompare: false))
		{
			text += "s";
		}
		if (b != 0)
		{
			return Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(ConvNumEnt(Conversions.ToDouble(obj), Langue), text), " et "), ConvNumDizaine(b, Langue)), text2));
		}
		return Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(ConvNumEnt(Conversions.ToDouble(obj), Langue), text), "."));
	}

	private static object ConvNumEnt(double TheNo, byte Langue)
	{
		object value = TheNo - Conversion.Int(TheNo / 1000.0) * 1000.0;
		object right = ConvNumCent(Conversions.ToInteger(value), Langue);
		double num = Conversion.Int(TheNo / 1000.0);
		value = num - Conversion.Int(num / 1000.0) * 1000.0;
		string text = ConvNumCent(Conversions.ToInteger(value), Langue);
		object left = value;
		if (!Operators.ConditionalCompareObjectEqual(left, 0, TextCompare: false))
		{
			text = ((!Operators.ConditionalCompareObjectEqual(left, 1, TextCompare: false)) ? (text + " Mille ") : "Mille ");
		}
		right = Operators.ConcatenateObject(text, right);
		num = Conversion.Int(num / 1000.0);
		value = num - Conversion.Int(num / 1000.0) * 1000.0;
		text = ConvNumCent(Conversions.ToInteger(value), Langue);
		object left2 = value;
		if (!Operators.ConditionalCompareObjectEqual(left2, 0, TextCompare: false))
		{
			text = ((!Operators.ConditionalCompareObjectEqual(left2, 1, TextCompare: false)) ? (text + " Millions ") : (text + " Million "));
		}
		right = Operators.ConcatenateObject(text, right);
		num = Conversion.Int(num / 1000.0);
		value = num - Conversion.Int(num / 1000.0) * 1000.0;
		text = ConvNumCent(Conversions.ToInteger(value), Langue);
		object left3 = value;
		if (!Operators.ConditionalCompareObjectEqual(left3, 0, TextCompare: false))
		{
			text = ((!Operators.ConditionalCompareObjectEqual(left3, 1, TextCompare: false)) ? (text + " Milliards ") : (text + " Milliard "));
		}
		right = Operators.ConcatenateObject(text, right);
		num = Conversion.Int(num / 1000.0);
		value = num - Conversion.Int(num / 1000.0) * 1000.0;
		text = ConvNumCent(Conversions.ToInteger(value), Langue);
		object left4 = value;
		if (!Operators.ConditionalCompareObjectEqual(left4, 0, TextCompare: false))
		{
			text = ((!Operators.ConditionalCompareObjectEqual(left4, 1, TextCompare: false)) ? (text + " Billions ") : (text + " Billion "));
		}
		return Operators.ConcatenateObject(text, right);
	}

	private static string ConvNumDizaine(byte TheNo, byte Langue)
	{
		string[] array = new string[20]
		{
			"", "Un", "Deux", "Trois", "Quatre", "Cinq", "Six", "Sept", "Huit", "Neuf",
			"Dix", "Onze", "Douze", "Treize", "Quatorze", "Quinze", "Seize", "Dix-sept", "Dix-huit", "Dix-neuf"
		};
		string[] array2 = new string[10] { "", "", "Vingt", "Trente", "Quarante", "Cinquante", "Soixante", "Soixante", "Quatre-vingt", "Quatre-vingt" };
		object instance = array;
		object instance2 = array2;
		checked
		{
			byte b = (byte)Math.Round(Conversion.Int((double)unchecked((int)TheNo) / 10.0));
			byte b2 = (byte)(TheNo - b * 10);
			string text = "-";
			if (b2 == 1)
			{
				text = " et ";
			}
			switch (b)
			{
			case 0:
				text = "";
				break;
			case 1:
				b2 += 10;
				text = "";
				break;
			case 7:
				if (Langue == 0)
				{
					b2 += 10;
				}
				break;
			case 8:
				if (Langue != 2)
				{
					text = "-";
				}
				break;
			case 9:
				if (Langue == 0)
				{
					b2 += 10;
					text = "-";
				}
				break;
			}
			string text2 = Conversions.ToString(NewLateBinding.LateIndexGet(instance2, new object[1] { b }, null));
			if ((b == 8) & (Langue != 2) & (b2 == 0))
			{
				text2 += "s";
			}
			if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateIndexGet(instance, new object[1] { b2 }, null), "", TextCompare: false))
			{
				return Conversions.ToString(Operators.ConcatenateObject(text2 + text, NewLateBinding.LateIndexGet(instance, new object[1] { b2 }, null)));
			}
			return text2;
		}
	}

	private static string ConvNumCent(int TheNo, byte Langue)
	{
		string[] array = new string[11]
		{
			"", "Un", "Deux", "Trois", "Quatre", "Cinq", "Six", "Sept", "Huit", "Neuf",
			"Dix"
		};
		object instance = array;
		checked
		{
			byte b = (byte)Math.Round(Conversion.Int((double)TheNo / 100.0));
			byte b2 = (byte)(TheNo - b * 100);
			string text = ConvNumDizaine(b2, Langue);
			switch (b)
			{
			case 0:
				return text;
			case 1:
				if (b2 == 0)
				{
					return "Cent";
				}
				return "Cent " + text;
			default:
				if (b2 == 0)
				{
					return Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet(instance, new object[1] { b }, null), " Cent"));
				}
				return Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet(instance, new object[1] { b }, null), " Cent "), text));
			}
		}
	}

	static Module1()
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected Obj, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got Unknown
		_CHEMIN_DB = MyProject.Forms.Form_0_TEMPLATE.Label_DB.Text;
		_CHEMIN_FOLDER = MyProject.Forms.Form_0_TEMPLATE.Label_FOLDER.Text;
		_NAME_DB = "allo_SUPERETTE_TODO_MARKET";
		_PORT_DB = "3306";
		_USER_ID = "allo_superette_todo_market_user";
		_PASS_ID = "F#@1f%lx8@EI#Ff@3c@b#";
		MySqlConnectionStringBuilder connectionSettings = new MySqlConnectionStringBuilder(Environment.GetEnvironmentVariable("LOGICA_DB_CONNECTION_STRING") ?? new MySqlConnectionStringBuilder { Server = _CHEMIN_DB, Port = uint.Parse(_PORT_DB), Database = _NAME_DB, UserID = _USER_ID, Password = _PASS_ID, CharacterSet = "utf8", ConnectionTimeout = 10 }.ConnectionString);
		// Apply UTF-8 to environment overrides too, preserving accented result column names.
		connectionSettings.CharacterSet = "utf8mb4";
		cn_SQL = new MySqlConnection(connectionSettings.ConnectionString);
		da1 = new MySqlDataAdapter();
		dt1 = new DataTable();
		dt_LA = new DataTable();
		da_LA = new MySqlDataAdapter();
		dt_find = new DataTable();
		da_find = new MySqlDataAdapter();
		_DT_TEMP = new DataTable();
		_DA_TEMP = new MySqlDataAdapter();
		_acces = false;
		_quittersolder = false;
		_QUITTER_PATIENTER = false;
		_quitter_pesee = false;
		Binaryz = "";
		bitsCode = new ArrayList();
		bitsCode.Add(new string[4] { "0001101", "0100111", "1110010", "000000" });
		bitsCode.Add(new string[4] { "0011001", "0110011", "1100110", "001011" });
		bitsCode.Add(new string[4] { "0010011", "0011011", "1101100", "001101" });
		bitsCode.Add(new string[4] { "0111101", "0100001", "1000010", "001110" });
		bitsCode.Add(new string[4] { "0100011", "0011101", "1011100", "010011" });
		bitsCode.Add(new string[4] { "0110001", "0111001", "1001110", "011001" });
		bitsCode.Add(new string[4] { "0101111", "0000101", "1010000", "011100" });
		bitsCode.Add(new string[4] { "0111011", "0010001", "1000100", "010101" });
		bitsCode.Add(new string[4] { "0110111", "0001001", "1001000", "010110" });
		bitsCode.Add(new string[4] { "0001011", "0010111", "1110100", "011010" });
	}

	public static Image Generate(string Code)
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected Obj, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Obj, but got Unknown
		int num = 0;
		int num2 = 0;
		byte[] array = new byte[13];
		int num3 = 0;
		checked
		{
			int num4;
			int num5;
			do
			{
				array[num3] = (byte)Conversions.ToInteger(Code.Substring(num3, 1));
				if (unchecked(num3 % 2) == 1)
				{
					num2 += array[num3];
				}
				else
				{
					num += array[num3];
				}
				num3++;
				num4 = num3;
				num5 = 11;
			}
			while (num4 <= num5);
		}
		num3 = checked(num + num2 * 3) % 10;
		checked
		{
			if (num3 == 0)
			{
				array[12] = 0;
			}
			else
			{
				array[12] = (byte)(10 - num3);
			}
			byte[] bits = getBits(array);
			Font val = new Font("Calibri", 14f, (FontStyle)0, (GraphicsUnit)2);
			Image val2 = (Image)new Bitmap(110, 50);
			Graphics val3 = Graphics.FromImage(val2);
			val3.Clear(Color.White);
			val3.DrawString(Code.Substring(0, 1), val, Brushes.Black, 2f, 30f);
			num = (int)Math.Round(val3.MeasureString(Code.Substring(0, 1), val).Width);
			int num6 = bits.Length - 1;
			num3 = 0;
			while (true)
			{
				int num7 = num3;
				int num5 = num6;
				if (num7 > num5)
				{
					break;
				}
				switch (num3)
				{
				case 2:
					val3.DrawString(Code.Substring(1, 6), val, Brushes.Black, (float)num, 30f);
					break;
				case 48:
					val3.DrawString(Code.Substring(7, 5) + array[12], val, Brushes.Black, (float)num, 30f);
					break;
				}
				if ((num3 == 0) | (num3 == 2) | (num3 == 46) | (num3 == 48) | (num3 == 92) | (num3 == 94))
				{
					if (bits[num3] == 1)
					{
						Pen val4 = new Pen(Color.Black, 1.4f);
						val3.DrawLine(val4, num, 0, num, 40);
						num = (int)Math.Round((double)num + 1.4);
					}
				}
				else if (bits[num3] == 1)
				{
					Pen val5 = new Pen(Color.Black, 1.4f);
					val3.DrawLine(val5, num, 0, num, 30);
					num = (int)Math.Round((double)num + 1.4);
				}
				else
				{
					num = (int)Math.Round((double)num + 1.4);
				}
				num3++;
			}
			val3.Flush();
			return val2;
		}
	}

	public static byte[] getBits(byte[] bCode)
	{
		string text = "101";
		string text2 = Conversions.ToString(NewLateBinding.LateIndexGet(bitsCode[bCode[0]], new object[1] { 3 }, null));
		int num = 1;
		checked
		{
			int num2;
			int num3;
			do
			{
				text = Conversions.ToString(Operators.ConcatenateObject(text, NewLateBinding.LateIndexGet(bitsCode[bCode[num]], new object[1] { Conversions.ToInteger(text2.Substring(num - 1, 1)) }, null)));
				num++;
				num2 = num;
				num3 = 6;
			}
			while (num2 <= num3);
			text += "01010";
			num = 7;
			int num4;
			do
			{
				text = Conversions.ToString(Operators.ConcatenateObject(text, NewLateBinding.LateIndexGet(bitsCode[bCode[num]], new object[1] { 2 }, null)));
				num++;
				num4 = num;
				num3 = 12;
			}
			while (num4 <= num3);
			text += "101";
			byte[] array = new byte[text.Length - 1 + 1];
			int num5 = text.Length - 1;
			num = 0;
			while (true)
			{
				int num6 = num;
				num3 = num5;
				if (num6 > num3)
				{
					break;
				}
				array[num] = (byte)(Strings.Asc(text[num]) - 48);
				num++;
			}
			return array;
		}
	}

	public static Image Code128(string TheText, string CodeLetter)
	{
		//IL_19a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ac: Expected Obj, but got Unknown
		//IL_19d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_19dd: Expected Obj, but got Unknown
		//IL_1aa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ab1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ac5: Expected Obj, but got Unknown
		//IL_1ac5: Expected Obj, but got Unknown
		//IL_1a5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a66: Expected Obj, but got Unknown
		//IL_1a29: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a30: Expected Obj, but got Unknown
		int num = default;
		if ((Operators.CompareString(CodeLetter, "A", TextCompare: false) == 0) | (Operators.CompareString(CodeLetter, "a", TextCompare: false) == 0))
		{
			num = 103;
			Binaryz = "00101111011";
		}
		if ((Operators.CompareString(CodeLetter, "B", TextCompare: false) == 0) | (Operators.CompareString(CodeLetter, "b", TextCompare: false) == 0))
		{
			num = 104;
			Binaryz = "00101101111";
		}
		if ((Operators.CompareString(CodeLetter, "C", TextCompare: false) == 0) | (Operators.CompareString(CodeLetter, "c", TextCompare: false) == 0))
		{
			num = 105;
			Binaryz = "00101100011";
		}
		int num2 = Strings.Len(TheText);
		int num3 = 1;
		checked
		{
			while (true)
			{
				int num4 = num3;
				int num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				num += (Strings.Asc(Strings.Mid(TheText, num3, 1)) - 32) * num3;
				switch (Strings.Asc(Strings.Mid(TheText, num3, 1)))
				{
				case 32:
					Binaryz += "00100110011";
					break;
				case 33:
					Binaryz += "00110010011";
					break;
				case 34:
					Binaryz += "00110011001";
					break;
				case 35:
					Binaryz += "01101100111";
					break;
				case 36:
					Binaryz += "01101110011";
					break;
				case 37:
					Binaryz += "01110110011";
					break;
				case 38:
					Binaryz += "01100110111";
					break;
				case 39:
					Binaryz += "01100111011";
					break;
				case 40:
					Binaryz += "01110011011";
					break;
				case 41:
					Binaryz += "00110110111";
					break;
				case 42:
					Binaryz += "00110111011";
					break;
				case 43:
					Binaryz += "00111011011";
					break;
				case 44:
					Binaryz += "01001100011";
					break;
				case 45:
					Binaryz += "01100100011";
					break;
				case 46:
					Binaryz += "01100110001";
					break;
				case 47:
					Binaryz += "01000110011";
					break;
				case 48:
					Binaryz += "01100010011";
					break;
				case 49:
					Binaryz += "01100011001";
					break;
				case 50:
					Binaryz += "00110001101";
					break;
				case 51:
					Binaryz += "00110100011";
					break;
				case 52:
					Binaryz += "00110110001";
					break;
				case 53:
					Binaryz += "00100011011";
					break;
				case 54:
					Binaryz += "00110001011";
					break;
				case 55:
					Binaryz += "00010010001";
					break;
				case 56:
					Binaryz += "00010110011";
					break;
				case 57:
					Binaryz += "00011010011";
					break;
				case 58:
					Binaryz += "00011011001";
					break;
				case 59:
					Binaryz += "00010011011";
					break;
				case 60:
					Binaryz += "00011001011";
					break;
				case 61:
					Binaryz += "00011001101";
					break;
				case 62:
					Binaryz += "00100100111";
					break;
				case 63:
					Binaryz += "00100111001";
					break;
				case 64:
					Binaryz += "00111001001";
					break;
				case 65:
					Binaryz += "01011100111";
					break;
				case 66:
					Binaryz += "01110100111";
					break;
				case 67:
					Binaryz += "01110111001";
					break;
				case 68:
					Binaryz += "01001110111";
					break;
				case 69:
					Binaryz += "01110010111";
					break;
				case 70:
					Binaryz += "01110011101";
					break;
				case 71:
					Binaryz += "00101110111";
					break;
				case 72:
					Binaryz += "00111010111";
					break;
				case 73:
					Binaryz += "00111011101";
					break;
				case 74:
					Binaryz += "01001000111";
					break;
				case 75:
					Binaryz += "01001110001";
					break;
				case 76:
					Binaryz += "01110010001";
					break;
				case 77:
					Binaryz += "01000100111";
					break;
				case 78:
					Binaryz += "01000111001";
					break;
				case 79:
					Binaryz += "01110001001";
					break;
				case 80:
					Binaryz += "00010001001";
					break;
				case 81:
					Binaryz += "00101110001";
					break;
				case 82:
					Binaryz += "00111010001";
					break;
				case 83:
					Binaryz += "00100010111";
					break;
				case 84:
					Binaryz += "00100011101";
					break;
				case 85:
					Binaryz += "00100010001";
					break;
				case 86:
					Binaryz += "00010100111";
					break;
				case 87:
					Binaryz += "00010111001";
					break;
				case 88:
					Binaryz += "00011101001";
					break;
				case 89:
					Binaryz += "00010010111";
					break;
				case 90:
					Binaryz += "00010011101";
					break;
				case 91:
					Binaryz += "00011100101";
					break;
				case 92:
					Binaryz += "00010000101";
					break;
				case 93:
					Binaryz += "00110111101";
					break;
				case 94:
					Binaryz += "00001110101";
					break;
				case 95:
					Binaryz += "01011001111";
					break;
				case 96:
					Binaryz += "01011110011";
					break;
				case 97:
					Binaryz += "01101001111";
					break;
				case 98:
					Binaryz += "01101111001";
					break;
				case 99:
					Binaryz += "01111010011";
					break;
				case 100:
					Binaryz += "01111011001";
					break;
				case 101:
					Binaryz += "01001101111";
					break;
				case 102:
					Binaryz += "01001111011";
					break;
				case 103:
					Binaryz += "01100101111";
					break;
				case 104:
					Binaryz += "01100111101";
					break;
				case 105:
					Binaryz += "01111001011";
					break;
				case 106:
					Binaryz += "01111001101";
					break;
				case 107:
					Binaryz += "00111101101";
					break;
				case 108:
					Binaryz += "00110101111";
					break;
				case 109:
					Binaryz += "00001000101";
					break;
				case 110:
					Binaryz += "00111101011";
					break;
				case 111:
					Binaryz += "01110000101";
					break;
				case 112:
					Binaryz += "01011000011";
					break;
				case 113:
					Binaryz += "01101000011";
					break;
				case 114:
					Binaryz += "01101100001";
					break;
				case 115:
					Binaryz += "01000011011";
					break;
				case 116:
					Binaryz += "01100001011";
					break;
				case 117:
					Binaryz += "01100001101";
					break;
				case 118:
					Binaryz += "00001011011";
					break;
				case 119:
					Binaryz += "00001101011";
					break;
				case 120:
					Binaryz += "00001101101";
					break;
				case 121:
					Binaryz += "00100100001";
					break;
				case 122:
					Binaryz += "00100001001";
					break;
				case 123:
					Binaryz += "00001001001";
					break;
				case 124:
					Binaryz += "01010000111";
					break;
				case 125:
					Binaryz += "01011100001";
					break;
				case 126:
					Binaryz += "01110100001";
					break;
				case 127:
					Binaryz += "01000010111";
					break;
				case 128:
					Binaryz += "01000011101";
					break;
				case 129:
					Binaryz += "00001010111";
					break;
				case 130:
					Binaryz += "00001011101";
					break;
				case 131:
					Binaryz += "01000100001";
					break;
				case 132:
					Binaryz += "01000010001";
					break;
				case 133:
					Binaryz += "00010100001";
					break;
				case 134:
					Binaryz += "00001010001";
					break;
				case 135:
					Binaryz += "00101111011";
					break;
				case 136:
					Binaryz += "00101101111";
					break;
				case 137:
					Binaryz += "00101100011";
					break;
				case 138:
					Binaryz += "0011100010100";
					break;
				}
				num3++;
			}
			switch (unchecked(num % 103))
			{
			case 0:
				Binaryz += "00100110011";
				break;
			case 1:
				Binaryz += "00110010011";
				break;
			case 2:
				Binaryz += "00110011001";
				break;
			case 3:
				Binaryz += "01101100111";
				break;
			case 4:
				Binaryz += "01101110011";
				break;
			case 5:
				Binaryz += "01110110011";
				break;
			case 6:
				Binaryz += "01100110111";
				break;
			case 7:
				Binaryz += "01100111011";
				break;
			case 8:
				Binaryz += "01110011011";
				break;
			case 9:
				Binaryz += "00110110111";
				break;
			case 10:
				Binaryz += "00110111011";
				break;
			case 11:
				Binaryz += "00111011011";
				break;
			case 12:
				Binaryz += "01001100011";
				break;
			case 13:
				Binaryz += "01100100011";
				break;
			case 14:
				Binaryz += "01100110001";
				break;
			case 15:
				Binaryz += "01000110011";
				break;
			case 16:
				Binaryz += "01100010011";
				break;
			case 17:
				Binaryz += "01100011001";
				break;
			case 18:
				Binaryz += "00110001101";
				break;
			case 19:
				Binaryz += "00110100011";
				break;
			case 20:
				Binaryz += "00110110001";
				break;
			case 21:
				Binaryz += "00100011011";
				break;
			case 22:
				Binaryz += "00110001011";
				break;
			case 23:
				Binaryz += "00010010001";
				break;
			case 24:
				Binaryz += "00010110011";
				break;
			case 25:
				Binaryz += "00011010011";
				break;
			case 26:
				Binaryz += "00011011001";
				break;
			case 27:
				Binaryz += "00010011011";
				break;
			case 28:
				Binaryz += "00011001011";
				break;
			case 29:
				Binaryz += "00011001101";
				break;
			case 30:
				Binaryz += "00100100111";
				break;
			case 31:
				Binaryz += "00100111001";
				break;
			case 32:
				Binaryz += "00111001001";
				break;
			case 33:
				Binaryz += "01011100111";
				break;
			case 34:
				Binaryz += "01110100111";
				break;
			case 35:
				Binaryz += "01110111001";
				break;
			case 36:
				Binaryz += "01001110111";
				break;
			case 37:
				Binaryz += "01110010111";
				break;
			case 38:
				Binaryz += "01110011101";
				break;
			case 39:
				Binaryz += "00101110111";
				break;
			case 40:
				Binaryz += "00111010111";
				break;
			case 41:
				Binaryz += "00111011101";
				break;
			case 42:
				Binaryz += "01001000111";
				break;
			case 43:
				Binaryz += "01001110001";
				break;
			case 44:
				Binaryz += "01110010001";
				break;
			case 45:
				Binaryz += "01000100111";
				break;
			case 46:
				Binaryz += "01000111001";
				break;
			case 47:
				Binaryz += "01110001001";
				break;
			case 48:
				Binaryz += "00010001001";
				break;
			case 49:
				Binaryz += "00101110001";
				break;
			case 50:
				Binaryz += "00111010001";
				break;
			case 51:
				Binaryz += "00100010111";
				break;
			case 52:
				Binaryz += "00100011101";
				break;
			case 53:
				Binaryz += "00100010001";
				break;
			case 54:
				Binaryz += "00010100111";
				break;
			case 55:
				Binaryz += "00010111001";
				break;
			case 56:
				Binaryz += "00011101001";
				break;
			case 57:
				Binaryz += "00010010111";
				break;
			case 58:
				Binaryz += "00010011101";
				break;
			case 59:
				Binaryz += "00011100101";
				break;
			case 60:
				Binaryz += "00010000101";
				break;
			case 61:
				Binaryz += "00110111101";
				break;
			case 62:
				Binaryz += "00001110101";
				break;
			case 63:
				Binaryz += "01011001111";
				break;
			case 64:
				Binaryz += "01011110011";
				break;
			case 65:
				Binaryz += "01101001111";
				break;
			case 66:
				Binaryz += "01101111001";
				break;
			case 67:
				Binaryz += "01111010011";
				break;
			case 68:
				Binaryz += "01111011001";
				break;
			case 69:
				Binaryz += "01001101111";
				break;
			case 70:
				Binaryz += "01001111011";
				break;
			case 71:
				Binaryz += "01100101111";
				break;
			case 72:
				Binaryz += "01100111101";
				break;
			case 73:
				Binaryz += "01111001011";
				break;
			case 74:
				Binaryz += "01111001101";
				break;
			case 75:
				Binaryz += "00111101101";
				break;
			case 76:
				Binaryz += "00110101111";
				break;
			case 77:
				Binaryz += "00001000101";
				break;
			case 78:
				Binaryz += "00111101011";
				break;
			case 79:
				Binaryz += "01110000101";
				break;
			case 80:
				Binaryz += "01011000011";
				break;
			case 81:
				Binaryz += "01101000011";
				break;
			case 82:
				Binaryz += "01101100001";
				break;
			case 83:
				Binaryz += "01000011011";
				break;
			case 84:
				Binaryz += "01100001011";
				break;
			case 85:
				Binaryz += "01100001101";
				break;
			case 86:
				Binaryz += "00001011011";
				break;
			case 87:
				Binaryz += "00001101011";
				break;
			case 88:
				Binaryz += "00001101101";
				break;
			case 89:
				Binaryz += "00100100001";
				break;
			case 90:
				Binaryz += "00100001001";
				break;
			case 91:
				Binaryz += "00001001001";
				break;
			case 92:
				Binaryz += "01010000111";
				break;
			case 93:
				Binaryz += "01011100001";
				break;
			case 94:
				Binaryz += "01110100001";
				break;
			case 95:
				Binaryz += "01000010111";
				break;
			case 96:
				Binaryz += "01000011101";
				break;
			case 97:
				Binaryz += "00001010111";
				break;
			case 98:
				Binaryz += "00001011101";
				break;
			case 99:
				Binaryz += "01000100001";
				break;
			case 100:
				Binaryz += "01000010001";
				break;
			case 101:
				Binaryz += "00010100001";
				break;
			case 102:
				Binaryz += "00001010001";
				break;
			}
			Binaryz += "0011100010100";
			Bitmap val = new Bitmap(Strings.Len(Binaryz), 60, (PixelFormat)137224);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			Rectangle rectangle = new Rectangle(0, 0, ((Image)val).Width, ((Image)val).Height);
			Brush val3 = (Brush)new LinearGradientBrush(rectangle, Color.White, Color.White, (LinearGradientMode)2);
			val2.FillRectangle(val3, rectangle);
			int num6 = Strings.Len(Binaryz);
			num3 = 1;
			while (true)
			{
				int num7 = num3;
				int num5 = num6;
				if (num7 > num5)
				{
					break;
				}
				string left = Strings.Mid(Binaryz, num3, 1);
				if (Operators.CompareString(left, "0", TextCompare: false) == 0)
				{
					Pen val4 = new Pen(Color.Black, 1f);
					Point point = new Point(num3, 0);
					Point point2 = new Point(num3, 40);
					val2.DrawLine(val4, point, point2);
				}
				else
				{
					Pen val4 = new Pen(Color.White, 1f);
					Point point = new Point(num3, 0);
					Point point2 = new Point(num3, 40);
					val2.DrawLine(val4, point, point2);
				}
				num3++;
			}
			val2.DrawString(TheText, new Font("times new roman", 12f, (FontStyle)1), (Brush)new SolidBrush(Color.Black), 20f, 40f);
			return (Image)(object)val;
		}
	}

	public static string Toc(string Text2CStr)
	{
		int num = 1;
		string text = "";
		string text2 = "";
		checked
		{
			do
			{
				text2 = Strings.Mid(Text2CStr, num, 2);
				text += Conversions.ToString(Strings.Chr((int)Math.Round(Conversion.Val(text2) + 32.0)));
				num += 2;
				text2 = Strings.Mid(Text2CStr, num, 1);
			}
			while (num < Strings.Len(Text2CStr) && Operators.CompareString(text2, "", TextCompare: false) != 0);
			return text;
		}
	}
}
