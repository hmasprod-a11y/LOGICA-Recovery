using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA;

[Serializable]
[DesignerCategory("code")]
[XmlRoot("Report_0_DATASET")]
[ToolboxItem(true)]
[HelpKeyword("vs.data.DataSet")]
[XmlSchemaProvider("GetTypedDataSetSchema")]
public class Report_0_DATASET : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public delegate void DataTable_BRRowChangeEventHandler(object sender, DataTable_BRRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public delegate void DataTable_BSRowChangeEventHandler(object sender, DataTable_BSRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public delegate void DataTable_INVRowChangeEventHandler(object sender, DataTable_INVRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public delegate void DataTable_DEVISRowChangeEventHandler(object sender, DataTable_DEVISRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public delegate void DataTable_BLRowChangeEventHandler(object sender, DataTable_BLRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public delegate void DataTable_FACTURERowChangeEventHandler(object sender, DataTable_FACTURERowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public delegate void DataTable_ETAT_STOCKRowChangeEventHandler(object sender, DataTable_ETAT_STOCKRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public delegate void DataTable_TICKET_A4RowChangeEventHandler(object sender, DataTable_TICKET_A4RowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public delegate void DataTable_NOMENCLATURERowChangeEventHandler(object sender, DataTable_NOMENCLATURERowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public delegate void DataTable_CLIENTS_ETAT_CREDITSRowChangeEventHandler(object sender, DataTable_CLIENTS_ETAT_CREDITSRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public delegate void DataTable_CLIENTS_ETAT_HISTORIQUE_ARowChangeEventHandler(object sender, DataTable_CLIENTS_ETAT_HISTORIQUE_ARowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public delegate void DataTable_CLIENTS_ETAT_HISTORIQUE_BRowChangeEventHandler(object sender, DataTable_CLIENTS_ETAT_HISTORIQUE_BRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public delegate void DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRowChangeEventHandler(object sender, DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public delegate void DataTable_FOURNISSEURS_ETAT_CREDITSRowChangeEventHandler(object sender, DataTable_FOURNISSEURS_ETAT_CREDITSRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public delegate void DataTable_BCRowChangeEventHandler(object sender, DataTable_BCRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public delegate void DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARowChangeEventHandler(object sender, DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public delegate void DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRowChangeEventHandler(object sender, DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRowChangeEvent e);

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class DataTable_BRDataTable : TypedTableBase<DataTable_BRRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnCODE;

		private DataColumn columnArticle;

		private DataColumn columnQté;

		private DataColumn columnPRIX_A;

		private DataColumn columnPRIX_V;

		private DataColumn columnTOTAL_NET_ACHATS;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn CODEColumn => columnCODE;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ArticleColumn => columnArticle;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn QtéColumn => columnQté;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn PRIX_AColumn => columnPRIX_A;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn PRIX_VColumn => columnPRIX_V;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TOTAL_NET_ACHATSColumn => columnTOTAL_NET_ACHATS;

		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public int Count => Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_BRRow this[int index] => (DataTable_BRRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_BRRowChangeEventHandler DataTable_BRRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_BRRowChangeEventHandler DataTable_BRRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_BRRowChangeEventHandler DataTable_BRRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_BRRowChangeEventHandler DataTable_BRRowDeleted;

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			checked
			{
				lock (__ENCList)
				{
					if (__ENCList.Count == __ENCList.Capacity)
					{
						int num = 0;
						int num2 = __ENCList.Count - 1;
						int num3 = 0;
						while (true)
						{
							int num4 = num3;
							int num5 = num2;
							if (num4 > num5)
							{
								break;
							}
							WeakReference weakReference = __ENCList[num3];
							if (weakReference.IsAlive)
							{
								if (num3 != num)
								{
									__ENCList[num] = __ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						__ENCList.RemoveRange(num, __ENCList.Count - num);
						__ENCList.Capacity = __ENCList.Count;
					}
					__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_BRDataTable()
		{
			__ENCAddToList(this);
			TableName = "DataTable_BR";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal DataTable_BRDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected DataTable_BRDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void AddDataTable_BRRow(DataTable_BRRow row)
		{
			Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_BRRow AddDataTable_BRRow(string CODE, string Article, string Qté, string PRIX_A, string PRIX_V, string TOTAL_NET_ACHATS)
		{
			DataTable_BRRow dataTable_BRRow = (DataTable_BRRow)NewRow();
			object[] itemArray = new object[6] { CODE, Article, Qté, PRIX_A, PRIX_V, TOTAL_NET_ACHATS };
			dataTable_BRRow.ItemArray = itemArray;
			Rows.Add(dataTable_BRRow);
			return dataTable_BRRow;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			DataTable_BRDataTable dataTable_BRDataTable = (DataTable_BRDataTable)base.Clone();
			dataTable_BRDataTable.InitVars();
			return dataTable_BRDataTable;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new DataTable_BRDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal void InitVars()
		{
			columnCODE = Columns["Code"];
			columnArticle = Columns["Article"];
			columnQté = Columns["Qté"];
			columnPRIX_A = Columns["Prix_A"];
			columnPRIX_V = Columns["Prix_V"];
			columnTOTAL_NET_ACHATS = Columns["TOTAL_NET_ACHATS"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		private void InitClass()
		{
			columnCODE = new DataColumn("Code", typeof(string), null, MappingType.Element);
			columnCODE.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "CODE");
			columnCODE.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "CODEColumn");
			columnCODE.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "columnCODE");
			columnCODE.ExtendedProperties.Add("Generator_UserColumnName", "Code");
			Columns.Add(columnCODE);
			columnArticle = new DataColumn("Article", typeof(string), null, MappingType.Element);
			Columns.Add(columnArticle);
			columnQté = new DataColumn("Qté", typeof(string), null, MappingType.Element);
			Columns.Add(columnQté);
			columnPRIX_A = new DataColumn("Prix_A", typeof(string), null, MappingType.Element);
			columnPRIX_A.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "PRIX_A");
			columnPRIX_A.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "PRIX_AColumn");
			columnPRIX_A.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "columnPRIX_A");
			columnPRIX_A.ExtendedProperties.Add("Generator_UserColumnName", "Prix_A");
			Columns.Add(columnPRIX_A);
			columnPRIX_V = new DataColumn("Prix_V", typeof(string), null, MappingType.Element);
			columnPRIX_V.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "PRIX_V");
			columnPRIX_V.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "PRIX_VColumn");
			columnPRIX_V.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "columnPRIX_V");
			columnPRIX_V.ExtendedProperties.Add("Generator_UserColumnName", "Prix_V");
			Columns.Add(columnPRIX_V);
			columnTOTAL_NET_ACHATS = new DataColumn("TOTAL_NET_ACHATS", typeof(string), null, MappingType.Element);
			Columns.Add(columnTOTAL_NET_ACHATS);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_BRRow NewDataTable_BRRow()
		{
			return (DataTable_BRRow)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new DataTable_BRRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(DataTable_BRRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (DataTable_BRRowChanged != null)
			{
				DataTable_BRRowChanged?.Invoke(this, new DataTable_BRRowChangeEvent((DataTable_BRRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (DataTable_BRRowChanging != null)
			{
				DataTable_BRRowChanging?.Invoke(this, new DataTable_BRRowChangeEvent((DataTable_BRRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (DataTable_BRRowDeleted != null)
			{
				DataTable_BRRowDeleted?.Invoke(this, new DataTable_BRRowChangeEvent((DataTable_BRRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (DataTable_BRRowDeleting != null)
			{
				DataTable_BRRowDeleting?.Invoke(this, new DataTable_BRRowChangeEvent((DataTable_BRRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void RemoveDataTable_BRRow(DataTable_BRRow row)
		{
			Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Report_0_DATASET report_0_DATASET = new Report_0_DATASET();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal minOccurs = 0m;
			xmlSchemaAny.MinOccurs = minOccurs;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			minOccurs = 1m;
			xmlSchemaAny2.MinOccurs = minOccurs;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = report_0_DATASET.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "DataTable_BRDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = report_0_DATASET.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class DataTable_BSDataTable : TypedTableBase<DataTable_BSRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnCode;

		private DataColumn columnArticle;

		private DataColumn columnQté;

		private DataColumn columnTOTAL_NET_ACHATS;

		private DataColumn columnTOTAL_NET_VENTES;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn CodeColumn => columnCode;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ArticleColumn => columnArticle;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn QtéColumn => columnQté;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TOTAL_NET_ACHATSColumn => columnTOTAL_NET_ACHATS;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TOTAL_NET_VENTESColumn => columnTOTAL_NET_VENTES;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		[Browsable(false)]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_BSRow this[int index] => (DataTable_BSRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_BSRowChangeEventHandler DataTable_BSRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_BSRowChangeEventHandler DataTable_BSRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_BSRowChangeEventHandler DataTable_BSRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_BSRowChangeEventHandler DataTable_BSRowDeleted;

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			checked
			{
				lock (__ENCList)
				{
					if (__ENCList.Count == __ENCList.Capacity)
					{
						int num = 0;
						int num2 = __ENCList.Count - 1;
						int num3 = 0;
						while (true)
						{
							int num4 = num3;
							int num5 = num2;
							if (num4 > num5)
							{
								break;
							}
							WeakReference weakReference = __ENCList[num3];
							if (weakReference.IsAlive)
							{
								if (num3 != num)
								{
									__ENCList[num] = __ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						__ENCList.RemoveRange(num, __ENCList.Count - num);
						__ENCList.Capacity = __ENCList.Count;
					}
					__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_BSDataTable()
		{
			__ENCAddToList(this);
			TableName = "DataTable_BS";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		internal DataTable_BSDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected DataTable_BSDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void AddDataTable_BSRow(DataTable_BSRow row)
		{
			Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_BSRow AddDataTable_BSRow(string Code, string Article, string Qté, string TOTAL_NET_ACHATS, string TOTAL_NET_VENTES)
		{
			DataTable_BSRow dataTable_BSRow = (DataTable_BSRow)NewRow();
			object[] itemArray = new object[5] { Code, Article, Qté, TOTAL_NET_ACHATS, TOTAL_NET_VENTES };
			dataTable_BSRow.ItemArray = itemArray;
			Rows.Add(dataTable_BSRow);
			return dataTable_BSRow;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			DataTable_BSDataTable dataTable_BSDataTable = (DataTable_BSDataTable)base.Clone();
			dataTable_BSDataTable.InitVars();
			return dataTable_BSDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new DataTable_BSDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnCode = Columns["Code"];
			columnArticle = Columns["Article"];
			columnQté = Columns["Qté"];
			columnTOTAL_NET_ACHATS = Columns["TOTAL_NET_ACHATS"];
			columnTOTAL_NET_VENTES = Columns["TOTAL_NET_VENTES"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		private void InitClass()
		{
			columnCode = new DataColumn("Code", typeof(string), null, MappingType.Element);
			Columns.Add(columnCode);
			columnArticle = new DataColumn("Article", typeof(string), null, MappingType.Element);
			Columns.Add(columnArticle);
			columnQté = new DataColumn("Qté", typeof(string), null, MappingType.Element);
			Columns.Add(columnQté);
			columnTOTAL_NET_ACHATS = new DataColumn("TOTAL_NET_ACHATS", typeof(string), null, MappingType.Element);
			Columns.Add(columnTOTAL_NET_ACHATS);
			columnTOTAL_NET_VENTES = new DataColumn("TOTAL_NET_VENTES", typeof(string), null, MappingType.Element);
			Columns.Add(columnTOTAL_NET_VENTES);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_BSRow NewDataTable_BSRow()
		{
			return (DataTable_BSRow)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new DataTable_BSRow(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(DataTable_BSRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (DataTable_BSRowChanged != null)
			{
				DataTable_BSRowChanged?.Invoke(this, new DataTable_BSRowChangeEvent((DataTable_BSRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (DataTable_BSRowChanging != null)
			{
				DataTable_BSRowChanging?.Invoke(this, new DataTable_BSRowChangeEvent((DataTable_BSRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (DataTable_BSRowDeleted != null)
			{
				DataTable_BSRowDeleted?.Invoke(this, new DataTable_BSRowChangeEvent((DataTable_BSRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (DataTable_BSRowDeleting != null)
			{
				DataTable_BSRowDeleting?.Invoke(this, new DataTable_BSRowChangeEvent((DataTable_BSRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void RemoveDataTable_BSRow(DataTable_BSRow row)
		{
			Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Report_0_DATASET report_0_DATASET = new Report_0_DATASET();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal minOccurs = 0m;
			xmlSchemaAny.MinOccurs = minOccurs;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			minOccurs = 1m;
			xmlSchemaAny2.MinOccurs = minOccurs;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = report_0_DATASET.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "DataTable_BSDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = report_0_DATASET.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class DataTable_INVDataTable : TypedTableBase<DataTable_INVRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnCode;

		private DataColumn columnArticle;

		private DataColumn columnStock_Logique;

		private DataColumn columnStock_Physique;

		private DataColumn columnEcart;

		private DataColumn columnValeur;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn CodeColumn => columnCode;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn ArticleColumn => columnArticle;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn Stock_LogiqueColumn => columnStock_Logique;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn Stock_PhysiqueColumn => columnStock_Physique;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn EcartColumn => columnEcart;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ValeurColumn => columnValeur;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[Browsable(false)]
		[DebuggerNonUserCode]
		public int Count => Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_INVRow this[int index] => (DataTable_INVRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_INVRowChangeEventHandler DataTable_INVRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_INVRowChangeEventHandler DataTable_INVRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_INVRowChangeEventHandler DataTable_INVRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_INVRowChangeEventHandler DataTable_INVRowDeleted;

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			checked
			{
				lock (__ENCList)
				{
					if (__ENCList.Count == __ENCList.Capacity)
					{
						int num = 0;
						int num2 = __ENCList.Count - 1;
						int num3 = 0;
						while (true)
						{
							int num4 = num3;
							int num5 = num2;
							if (num4 > num5)
							{
								break;
							}
							WeakReference weakReference = __ENCList[num3];
							if (weakReference.IsAlive)
							{
								if (num3 != num)
								{
									__ENCList[num] = __ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						__ENCList.RemoveRange(num, __ENCList.Count - num);
						__ENCList.Capacity = __ENCList.Count;
					}
					__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_INVDataTable()
		{
			__ENCAddToList(this);
			TableName = "DataTable_INV";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal DataTable_INVDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected DataTable_INVDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void AddDataTable_INVRow(DataTable_INVRow row)
		{
			Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_INVRow AddDataTable_INVRow(string Code, string Article, string Stock_Logique, string Stock_Physique, string Ecart, string Valeur)
		{
			DataTable_INVRow dataTable_INVRow = (DataTable_INVRow)NewRow();
			object[] itemArray = new object[6] { Code, Article, Stock_Logique, Stock_Physique, Ecart, Valeur };
			dataTable_INVRow.ItemArray = itemArray;
			Rows.Add(dataTable_INVRow);
			return dataTable_INVRow;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			DataTable_INVDataTable dataTable_INVDataTable = (DataTable_INVDataTable)base.Clone();
			dataTable_INVDataTable.InitVars();
			return dataTable_INVDataTable;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new DataTable_INVDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnCode = Columns["Code"];
			columnArticle = Columns["Article"];
			columnStock_Logique = Columns["Stock_Logique"];
			columnStock_Physique = Columns["Stock_Physique"];
			columnEcart = Columns["Ecart"];
			columnValeur = Columns["Valeur"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		private void InitClass()
		{
			columnCode = new DataColumn("Code", typeof(string), null, MappingType.Element);
			Columns.Add(columnCode);
			columnArticle = new DataColumn("Article", typeof(string), null, MappingType.Element);
			Columns.Add(columnArticle);
			columnStock_Logique = new DataColumn("Stock_Logique", typeof(string), null, MappingType.Element);
			Columns.Add(columnStock_Logique);
			columnStock_Physique = new DataColumn("Stock_Physique", typeof(string), null, MappingType.Element);
			Columns.Add(columnStock_Physique);
			columnEcart = new DataColumn("Ecart", typeof(string), null, MappingType.Element);
			Columns.Add(columnEcart);
			columnValeur = new DataColumn("Valeur", typeof(string), null, MappingType.Element);
			Columns.Add(columnValeur);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_INVRow NewDataTable_INVRow()
		{
			return (DataTable_INVRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new DataTable_INVRow(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(DataTable_INVRow);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (DataTable_INVRowChanged != null)
			{
				DataTable_INVRowChanged?.Invoke(this, new DataTable_INVRowChangeEvent((DataTable_INVRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (DataTable_INVRowChanging != null)
			{
				DataTable_INVRowChanging?.Invoke(this, new DataTable_INVRowChangeEvent((DataTable_INVRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (DataTable_INVRowDeleted != null)
			{
				DataTable_INVRowDeleted?.Invoke(this, new DataTable_INVRowChangeEvent((DataTable_INVRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (DataTable_INVRowDeleting != null)
			{
				DataTable_INVRowDeleting?.Invoke(this, new DataTable_INVRowChangeEvent((DataTable_INVRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void RemoveDataTable_INVRow(DataTable_INVRow row)
		{
			Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Report_0_DATASET report_0_DATASET = new Report_0_DATASET();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal minOccurs = 0m;
			xmlSchemaAny.MinOccurs = minOccurs;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			minOccurs = 1m;
			xmlSchemaAny2.MinOccurs = minOccurs;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = report_0_DATASET.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "DataTable_INVDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = report_0_DATASET.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class DataTable_DEVISDataTable : TypedTableBase<DataTable_DEVISRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnCode;

		private DataColumn columnArticle;

		private DataColumn columnPU_TTC;

		private DataColumn columnTAUX_TVA;

		private DataColumn columnPU_HT;

		private DataColumn columnQté;

		private DataColumn columnTOTAL_TTC;

		private DataColumn columnTOTAL_TVA;

		private DataColumn columnTOTAL_HT;

		private DataColumn columnTOTAL_REMISE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn CodeColumn => columnCode;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn ArticleColumn => columnArticle;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn PU_TTCColumn => columnPU_TTC;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TAUX_TVAColumn => columnTAUX_TVA;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn PU_HTColumn => columnPU_HT;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn QtéColumn => columnQté;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn TOTAL_TTCColumn => columnTOTAL_TTC;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TOTAL_TVAColumn => columnTOTAL_TVA;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn TOTAL_HTColumn => columnTOTAL_HT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn TOTAL_REMISEColumn => columnTOTAL_REMISE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[Browsable(false)]
		public int Count => Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_DEVISRow this[int index] => (DataTable_DEVISRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_DEVISRowChangeEventHandler DataTable_DEVISRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_DEVISRowChangeEventHandler DataTable_DEVISRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_DEVISRowChangeEventHandler DataTable_DEVISRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_DEVISRowChangeEventHandler DataTable_DEVISRowDeleted;

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			checked
			{
				lock (__ENCList)
				{
					if (__ENCList.Count == __ENCList.Capacity)
					{
						int num = 0;
						int num2 = __ENCList.Count - 1;
						int num3 = 0;
						while (true)
						{
							int num4 = num3;
							int num5 = num2;
							if (num4 > num5)
							{
								break;
							}
							WeakReference weakReference = __ENCList[num3];
							if (weakReference.IsAlive)
							{
								if (num3 != num)
								{
									__ENCList[num] = __ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						__ENCList.RemoveRange(num, __ENCList.Count - num);
						__ENCList.Capacity = __ENCList.Count;
					}
					__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_DEVISDataTable()
		{
			__ENCAddToList(this);
			TableName = "DataTable_DEVIS";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		internal DataTable_DEVISDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected DataTable_DEVISDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void AddDataTable_DEVISRow(DataTable_DEVISRow row)
		{
			Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_DEVISRow AddDataTable_DEVISRow(string Code, string Article, string PU_TTC, string TAUX_TVA, string PU_HT, string Qté, string TOTAL_TTC, string TOTAL_TVA, string TOTAL_HT, string TOTAL_REMISE)
		{
			DataTable_DEVISRow dataTable_DEVISRow = (DataTable_DEVISRow)NewRow();
			object[] itemArray = new object[10] { Code, Article, PU_TTC, TAUX_TVA, PU_HT, Qté, TOTAL_TTC, TOTAL_TVA, TOTAL_HT, TOTAL_REMISE };
			dataTable_DEVISRow.ItemArray = itemArray;
			Rows.Add(dataTable_DEVISRow);
			return dataTable_DEVISRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public override DataTable Clone()
		{
			DataTable_DEVISDataTable dataTable_DEVISDataTable = (DataTable_DEVISDataTable)base.Clone();
			dataTable_DEVISDataTable.InitVars();
			return dataTable_DEVISDataTable;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new DataTable_DEVISDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal void InitVars()
		{
			columnCode = Columns["Code"];
			columnArticle = Columns["Article"];
			columnPU_TTC = Columns["PU_TTC"];
			columnTAUX_TVA = Columns["TAUX_TVA"];
			columnPU_HT = Columns["PU_HT"];
			columnQté = Columns["Qté"];
			columnTOTAL_TTC = Columns["TOTAL_TTC"];
			columnTOTAL_TVA = Columns["TOTAL_TVA"];
			columnTOTAL_HT = Columns["TOTAL_HT"];
			columnTOTAL_REMISE = Columns["TOTAL_REMISE"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnCode = new DataColumn("Code", typeof(string), null, MappingType.Element);
			Columns.Add(columnCode);
			columnArticle = new DataColumn("Article", typeof(string), null, MappingType.Element);
			Columns.Add(columnArticle);
			columnPU_TTC = new DataColumn("PU_TTC", typeof(string), null, MappingType.Element);
			Columns.Add(columnPU_TTC);
			columnTAUX_TVA = new DataColumn("TAUX_TVA", typeof(string), null, MappingType.Element);
			Columns.Add(columnTAUX_TVA);
			columnPU_HT = new DataColumn("PU_HT", typeof(string), null, MappingType.Element);
			Columns.Add(columnPU_HT);
			columnQté = new DataColumn("Qté", typeof(string), null, MappingType.Element);
			Columns.Add(columnQté);
			columnTOTAL_TTC = new DataColumn("TOTAL_TTC", typeof(string), null, MappingType.Element);
			Columns.Add(columnTOTAL_TTC);
			columnTOTAL_TVA = new DataColumn("TOTAL_TVA", typeof(string), null, MappingType.Element);
			Columns.Add(columnTOTAL_TVA);
			columnTOTAL_HT = new DataColumn("TOTAL_HT", typeof(string), null, MappingType.Element);
			Columns.Add(columnTOTAL_HT);
			columnTOTAL_REMISE = new DataColumn("TOTAL_REMISE", typeof(string), null, MappingType.Element);
			Columns.Add(columnTOTAL_REMISE);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_DEVISRow NewDataTable_DEVISRow()
		{
			return (DataTable_DEVISRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new DataTable_DEVISRow(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(DataTable_DEVISRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (DataTable_DEVISRowChanged != null)
			{
				DataTable_DEVISRowChanged?.Invoke(this, new DataTable_DEVISRowChangeEvent((DataTable_DEVISRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (DataTable_DEVISRowChanging != null)
			{
				DataTable_DEVISRowChanging?.Invoke(this, new DataTable_DEVISRowChangeEvent((DataTable_DEVISRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (DataTable_DEVISRowDeleted != null)
			{
				DataTable_DEVISRowDeleted?.Invoke(this, new DataTable_DEVISRowChangeEvent((DataTable_DEVISRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (DataTable_DEVISRowDeleting != null)
			{
				DataTable_DEVISRowDeleting?.Invoke(this, new DataTable_DEVISRowChangeEvent((DataTable_DEVISRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void RemoveDataTable_DEVISRow(DataTable_DEVISRow row)
		{
			Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Report_0_DATASET report_0_DATASET = new Report_0_DATASET();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal minOccurs = 0m;
			xmlSchemaAny.MinOccurs = minOccurs;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			minOccurs = 1m;
			xmlSchemaAny2.MinOccurs = minOccurs;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = report_0_DATASET.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "DataTable_DEVISDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = report_0_DATASET.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class DataTable_BLDataTable : TypedTableBase<DataTable_BLRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnCode;

		private DataColumn columnArticle;

		private DataColumn columnPU_TTC;

		private DataColumn columnTAUX_TVA;

		private DataColumn columnPU_HT;

		private DataColumn columnQté;

		private DataColumn columnTOTAL_TTC;

		private DataColumn columnTOTAL_TVA;

		private DataColumn columnTOTAL_HT;

		private DataColumn columnTOTAL_REMISE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn CodeColumn => columnCode;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn ArticleColumn => columnArticle;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn PU_TTCColumn => columnPU_TTC;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn TAUX_TVAColumn => columnTAUX_TVA;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn PU_HTColumn => columnPU_HT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn QtéColumn => columnQté;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TOTAL_TTCColumn => columnTOTAL_TTC;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn TOTAL_TVAColumn => columnTOTAL_TVA;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TOTAL_HTColumn => columnTOTAL_HT;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TOTAL_REMISEColumn => columnTOTAL_REMISE;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[Browsable(false)]
		[DebuggerNonUserCode]
		public int Count => Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_BLRow this[int index] => (DataTable_BLRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_BLRowChangeEventHandler DataTable_BLRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_BLRowChangeEventHandler DataTable_BLRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_BLRowChangeEventHandler DataTable_BLRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_BLRowChangeEventHandler DataTable_BLRowDeleted;

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			checked
			{
				lock (__ENCList)
				{
					if (__ENCList.Count == __ENCList.Capacity)
					{
						int num = 0;
						int num2 = __ENCList.Count - 1;
						int num3 = 0;
						while (true)
						{
							int num4 = num3;
							int num5 = num2;
							if (num4 > num5)
							{
								break;
							}
							WeakReference weakReference = __ENCList[num3];
							if (weakReference.IsAlive)
							{
								if (num3 != num)
								{
									__ENCList[num] = __ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						__ENCList.RemoveRange(num, __ENCList.Count - num);
						__ENCList.Capacity = __ENCList.Count;
					}
					__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_BLDataTable()
		{
			__ENCAddToList(this);
			TableName = "DataTable_BL";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		internal DataTable_BLDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected DataTable_BLDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void AddDataTable_BLRow(DataTable_BLRow row)
		{
			Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_BLRow AddDataTable_BLRow(string Code, string Article, string PU_TTC, string TAUX_TVA, string PU_HT, string Qté, string TOTAL_TTC, string TOTAL_TVA, string TOTAL_HT, string TOTAL_REMISE)
		{
			DataTable_BLRow dataTable_BLRow = (DataTable_BLRow)NewRow();
			object[] itemArray = new object[10] { Code, Article, PU_TTC, TAUX_TVA, PU_HT, Qté, TOTAL_TTC, TOTAL_TVA, TOTAL_HT, TOTAL_REMISE };
			dataTable_BLRow.ItemArray = itemArray;
			Rows.Add(dataTable_BLRow);
			return dataTable_BLRow;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			DataTable_BLDataTable dataTable_BLDataTable = (DataTable_BLDataTable)base.Clone();
			dataTable_BLDataTable.InitVars();
			return dataTable_BLDataTable;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new DataTable_BLDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnCode = Columns["Code"];
			columnArticle = Columns["Article"];
			columnPU_TTC = Columns["PU_TTC"];
			columnTAUX_TVA = Columns["TAUX_TVA"];
			columnPU_HT = Columns["PU_HT"];
			columnQté = Columns["Qté"];
			columnTOTAL_TTC = Columns["TOTAL_TTC"];
			columnTOTAL_TVA = Columns["TOTAL_TVA"];
			columnTOTAL_HT = Columns["TOTAL_HT"];
			columnTOTAL_REMISE = Columns["TOTAL_REMISE"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnCode = new DataColumn("Code", typeof(string), null, MappingType.Element);
			Columns.Add(columnCode);
			columnArticle = new DataColumn("Article", typeof(string), null, MappingType.Element);
			Columns.Add(columnArticle);
			columnPU_TTC = new DataColumn("PU_TTC", typeof(string), null, MappingType.Element);
			Columns.Add(columnPU_TTC);
			columnTAUX_TVA = new DataColumn("TAUX_TVA", typeof(string), null, MappingType.Element);
			Columns.Add(columnTAUX_TVA);
			columnPU_HT = new DataColumn("PU_HT", typeof(string), null, MappingType.Element);
			Columns.Add(columnPU_HT);
			columnQté = new DataColumn("Qté", typeof(string), null, MappingType.Element);
			Columns.Add(columnQté);
			columnTOTAL_TTC = new DataColumn("TOTAL_TTC", typeof(string), null, MappingType.Element);
			Columns.Add(columnTOTAL_TTC);
			columnTOTAL_TVA = new DataColumn("TOTAL_TVA", typeof(string), null, MappingType.Element);
			Columns.Add(columnTOTAL_TVA);
			columnTOTAL_HT = new DataColumn("TOTAL_HT", typeof(string), null, MappingType.Element);
			Columns.Add(columnTOTAL_HT);
			columnTOTAL_REMISE = new DataColumn("TOTAL_REMISE", typeof(string), null, MappingType.Element);
			Columns.Add(columnTOTAL_REMISE);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_BLRow NewDataTable_BLRow()
		{
			return (DataTable_BLRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new DataTable_BLRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(DataTable_BLRow);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (DataTable_BLRowChanged != null)
			{
				DataTable_BLRowChanged?.Invoke(this, new DataTable_BLRowChangeEvent((DataTable_BLRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (DataTable_BLRowChanging != null)
			{
				DataTable_BLRowChanging?.Invoke(this, new DataTable_BLRowChangeEvent((DataTable_BLRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (DataTable_BLRowDeleted != null)
			{
				DataTable_BLRowDeleted?.Invoke(this, new DataTable_BLRowChangeEvent((DataTable_BLRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (DataTable_BLRowDeleting != null)
			{
				DataTable_BLRowDeleting?.Invoke(this, new DataTable_BLRowChangeEvent((DataTable_BLRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void RemoveDataTable_BLRow(DataTable_BLRow row)
		{
			Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Report_0_DATASET report_0_DATASET = new Report_0_DATASET();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal minOccurs = 0m;
			xmlSchemaAny.MinOccurs = minOccurs;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			minOccurs = 1m;
			xmlSchemaAny2.MinOccurs = minOccurs;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = report_0_DATASET.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "DataTable_BLDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = report_0_DATASET.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class DataTable_FACTUREDataTable : TypedTableBase<DataTable_FACTURERow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnCode;

		private DataColumn columnArticle;

		private DataColumn columnPU_TTC;

		private DataColumn columnTAUX_TVA;

		private DataColumn columnPU_HT;

		private DataColumn columnQté;

		private DataColumn columnTOTAL_TTC;

		private DataColumn columnTOTAL_TVA;

		private DataColumn columnTOTAL_HT;

		private DataColumn columnTOTAL_REMISE;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn CodeColumn => columnCode;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ArticleColumn => columnArticle;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn PU_TTCColumn => columnPU_TTC;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn TAUX_TVAColumn => columnTAUX_TVA;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn PU_HTColumn => columnPU_HT;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn QtéColumn => columnQté;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TOTAL_TTCColumn => columnTOTAL_TTC;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TOTAL_TVAColumn => columnTOTAL_TVA;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TOTAL_HTColumn => columnTOTAL_HT;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TOTAL_REMISEColumn => columnTOTAL_REMISE;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[Browsable(false)]
		[DebuggerNonUserCode]
		public int Count => Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_FACTURERow this[int index] => (DataTable_FACTURERow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_FACTURERowChangeEventHandler DataTable_FACTURERowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_FACTURERowChangeEventHandler DataTable_FACTURERowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_FACTURERowChangeEventHandler DataTable_FACTURERowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_FACTURERowChangeEventHandler DataTable_FACTURERowDeleted;

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			checked
			{
				lock (__ENCList)
				{
					if (__ENCList.Count == __ENCList.Capacity)
					{
						int num = 0;
						int num2 = __ENCList.Count - 1;
						int num3 = 0;
						while (true)
						{
							int num4 = num3;
							int num5 = num2;
							if (num4 > num5)
							{
								break;
							}
							WeakReference weakReference = __ENCList[num3];
							if (weakReference.IsAlive)
							{
								if (num3 != num)
								{
									__ENCList[num] = __ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						__ENCList.RemoveRange(num, __ENCList.Count - num);
						__ENCList.Capacity = __ENCList.Count;
					}
					__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_FACTUREDataTable()
		{
			__ENCAddToList(this);
			TableName = "DataTable_FACTURE";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal DataTable_FACTUREDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected DataTable_FACTUREDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void AddDataTable_FACTURERow(DataTable_FACTURERow row)
		{
			Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_FACTURERow AddDataTable_FACTURERow(string Code, string Article, string PU_TTC, string TAUX_TVA, string PU_HT, string Qté, string TOTAL_TTC, string TOTAL_TVA, string TOTAL_HT, string TOTAL_REMISE)
		{
			DataTable_FACTURERow dataTable_FACTURERow = (DataTable_FACTURERow)NewRow();
			object[] itemArray = new object[10] { Code, Article, PU_TTC, TAUX_TVA, PU_HT, Qté, TOTAL_TTC, TOTAL_TVA, TOTAL_HT, TOTAL_REMISE };
			dataTable_FACTURERow.ItemArray = itemArray;
			Rows.Add(dataTable_FACTURERow);
			return dataTable_FACTURERow;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			DataTable_FACTUREDataTable dataTable_FACTUREDataTable = (DataTable_FACTUREDataTable)base.Clone();
			dataTable_FACTUREDataTable.InitVars();
			return dataTable_FACTUREDataTable;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new DataTable_FACTUREDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnCode = Columns["Code"];
			columnArticle = Columns["Article"];
			columnPU_TTC = Columns["PU_TTC"];
			columnTAUX_TVA = Columns["TAUX_TVA"];
			columnPU_HT = Columns["PU_HT"];
			columnQté = Columns["Qté"];
			columnTOTAL_TTC = Columns["TOTAL_TTC"];
			columnTOTAL_TVA = Columns["TOTAL_TVA"];
			columnTOTAL_HT = Columns["TOTAL_HT"];
			columnTOTAL_REMISE = Columns["TOTAL_REMISE"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnCode = new DataColumn("Code", typeof(string), null, MappingType.Element);
			Columns.Add(columnCode);
			columnArticle = new DataColumn("Article", typeof(string), null, MappingType.Element);
			Columns.Add(columnArticle);
			columnPU_TTC = new DataColumn("PU_TTC", typeof(string), null, MappingType.Element);
			Columns.Add(columnPU_TTC);
			columnTAUX_TVA = new DataColumn("TAUX_TVA", typeof(string), null, MappingType.Element);
			Columns.Add(columnTAUX_TVA);
			columnPU_HT = new DataColumn("PU_HT", typeof(string), null, MappingType.Element);
			Columns.Add(columnPU_HT);
			columnQté = new DataColumn("Qté", typeof(string), null, MappingType.Element);
			Columns.Add(columnQté);
			columnTOTAL_TTC = new DataColumn("TOTAL_TTC", typeof(string), null, MappingType.Element);
			Columns.Add(columnTOTAL_TTC);
			columnTOTAL_TVA = new DataColumn("TOTAL_TVA", typeof(string), null, MappingType.Element);
			Columns.Add(columnTOTAL_TVA);
			columnTOTAL_HT = new DataColumn("TOTAL_HT", typeof(string), null, MappingType.Element);
			Columns.Add(columnTOTAL_HT);
			columnTOTAL_REMISE = new DataColumn("TOTAL_REMISE", typeof(string), null, MappingType.Element);
			Columns.Add(columnTOTAL_REMISE);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_FACTURERow NewDataTable_FACTURERow()
		{
			return (DataTable_FACTURERow)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new DataTable_FACTURERow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(DataTable_FACTURERow);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (DataTable_FACTURERowChanged != null)
			{
				DataTable_FACTURERowChanged?.Invoke(this, new DataTable_FACTURERowChangeEvent((DataTable_FACTURERow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (DataTable_FACTURERowChanging != null)
			{
				DataTable_FACTURERowChanging?.Invoke(this, new DataTable_FACTURERowChangeEvent((DataTable_FACTURERow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (DataTable_FACTURERowDeleted != null)
			{
				DataTable_FACTURERowDeleted?.Invoke(this, new DataTable_FACTURERowChangeEvent((DataTable_FACTURERow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (DataTable_FACTURERowDeleting != null)
			{
				DataTable_FACTURERowDeleting?.Invoke(this, new DataTable_FACTURERowChangeEvent((DataTable_FACTURERow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void RemoveDataTable_FACTURERow(DataTable_FACTURERow row)
		{
			Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Report_0_DATASET report_0_DATASET = new Report_0_DATASET();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal minOccurs = 0m;
			xmlSchemaAny.MinOccurs = minOccurs;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			minOccurs = 1m;
			xmlSchemaAny2.MinOccurs = minOccurs;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = report_0_DATASET.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "DataTable_FACTUREDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = report_0_DATASET.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class DataTable_ETAT_STOCKDataTable : TypedTableBase<DataTable_ETAT_STOCKRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnID_ARTICLE;

		private DataColumn columnCode;

		private DataColumn columnArticle;

		private DataColumn columnFamille;

		private DataColumn columnDate_Inventaire;

		private DataColumn columnStock_Initial;

		private DataColumn columnStock_Recept;

		private DataColumn columnStock_Sortie;

		private DataColumn columnStock_Vendu;

		private DataColumn columnStock_Prevu;

		private DataColumn columnStock_Actuel;

		private DataColumn columnUnite;

		private DataColumn columnAlert;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn ID_ARTICLEColumn => columnID_ARTICLE;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn CodeColumn => columnCode;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn ArticleColumn => columnArticle;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn FamilleColumn => columnFamille;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn Date_InventaireColumn => columnDate_Inventaire;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn Stock_InitialColumn => columnStock_Initial;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn Stock_ReceptColumn => columnStock_Recept;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn Stock_SortieColumn => columnStock_Sortie;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn Stock_VenduColumn => columnStock_Vendu;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn Stock_PrevuColumn => columnStock_Prevu;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn Stock_ActuelColumn => columnStock_Actuel;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn UniteColumn => columnUnite;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn AlertColumn => columnAlert;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		[Browsable(false)]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_ETAT_STOCKRow this[int index] => (DataTable_ETAT_STOCKRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_ETAT_STOCKRowChangeEventHandler DataTable_ETAT_STOCKRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_ETAT_STOCKRowChangeEventHandler DataTable_ETAT_STOCKRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_ETAT_STOCKRowChangeEventHandler DataTable_ETAT_STOCKRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_ETAT_STOCKRowChangeEventHandler DataTable_ETAT_STOCKRowDeleted;

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			checked
			{
				lock (__ENCList)
				{
					if (__ENCList.Count == __ENCList.Capacity)
					{
						int num = 0;
						int num2 = __ENCList.Count - 1;
						int num3 = 0;
						while (true)
						{
							int num4 = num3;
							int num5 = num2;
							if (num4 > num5)
							{
								break;
							}
							WeakReference weakReference = __ENCList[num3];
							if (weakReference.IsAlive)
							{
								if (num3 != num)
								{
									__ENCList[num] = __ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						__ENCList.RemoveRange(num, __ENCList.Count - num);
						__ENCList.Capacity = __ENCList.Count;
					}
					__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_ETAT_STOCKDataTable()
		{
			__ENCAddToList(this);
			TableName = "DataTable_ETAT_STOCK";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		internal DataTable_ETAT_STOCKDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected DataTable_ETAT_STOCKDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void AddDataTable_ETAT_STOCKRow(DataTable_ETAT_STOCKRow row)
		{
			Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_ETAT_STOCKRow AddDataTable_ETAT_STOCKRow(string ID_ARTICLE, string Code, string Article, string Famille, string Date_Inventaire, string Stock_Initial, string Stock_Recept, string Stock_Sortie, string Stock_Vendu, string Stock_Prevu, string Stock_Actuel, string Unite, string Alert)
		{
			DataTable_ETAT_STOCKRow dataTable_ETAT_STOCKRow = (DataTable_ETAT_STOCKRow)NewRow();
			object[] itemArray = new object[13]
			{
				ID_ARTICLE, Code, Article, Famille, Date_Inventaire, Stock_Initial, Stock_Recept, Stock_Sortie, Stock_Vendu, Stock_Prevu,
				Stock_Actuel, Unite, Alert
			};
			dataTable_ETAT_STOCKRow.ItemArray = itemArray;
			Rows.Add(dataTable_ETAT_STOCKRow);
			return dataTable_ETAT_STOCKRow;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			DataTable_ETAT_STOCKDataTable dataTable_ETAT_STOCKDataTable = (DataTable_ETAT_STOCKDataTable)base.Clone();
			dataTable_ETAT_STOCKDataTable.InitVars();
			return dataTable_ETAT_STOCKDataTable;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new DataTable_ETAT_STOCKDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal void InitVars()
		{
			columnID_ARTICLE = Columns["ID_ARTICLE"];
			columnCode = Columns["Code"];
			columnArticle = Columns["Article"];
			columnFamille = Columns["Famille"];
			columnDate_Inventaire = Columns["Date_Inventaire"];
			columnStock_Initial = Columns["Stock_Initial"];
			columnStock_Recept = Columns["Stock_Recept"];
			columnStock_Sortie = Columns["Stock_Sortie"];
			columnStock_Vendu = Columns["Stock_Vendu"];
			columnStock_Prevu = Columns["Stock_Prevu"];
			columnStock_Actuel = Columns["Stock_Actuel"];
			columnUnite = Columns["Unite"];
			columnAlert = Columns["Alert"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnID_ARTICLE = new DataColumn("ID_ARTICLE", typeof(string), null, MappingType.Element);
			Columns.Add(columnID_ARTICLE);
			columnCode = new DataColumn("Code", typeof(string), null, MappingType.Element);
			Columns.Add(columnCode);
			columnArticle = new DataColumn("Article", typeof(string), null, MappingType.Element);
			Columns.Add(columnArticle);
			columnFamille = new DataColumn("Famille", typeof(string), null, MappingType.Element);
			Columns.Add(columnFamille);
			columnDate_Inventaire = new DataColumn("Date_Inventaire", typeof(string), null, MappingType.Element);
			Columns.Add(columnDate_Inventaire);
			columnStock_Initial = new DataColumn("Stock_Initial", typeof(string), null, MappingType.Element);
			Columns.Add(columnStock_Initial);
			columnStock_Recept = new DataColumn("Stock_Recept", typeof(string), null, MappingType.Element);
			Columns.Add(columnStock_Recept);
			columnStock_Sortie = new DataColumn("Stock_Sortie", typeof(string), null, MappingType.Element);
			Columns.Add(columnStock_Sortie);
			columnStock_Vendu = new DataColumn("Stock_Vendu", typeof(string), null, MappingType.Element);
			Columns.Add(columnStock_Vendu);
			columnStock_Prevu = new DataColumn("Stock_Prevu", typeof(string), null, MappingType.Element);
			Columns.Add(columnStock_Prevu);
			columnStock_Actuel = new DataColumn("Stock_Actuel", typeof(string), null, MappingType.Element);
			Columns.Add(columnStock_Actuel);
			columnUnite = new DataColumn("Unite", typeof(string), null, MappingType.Element);
			Columns.Add(columnUnite);
			columnAlert = new DataColumn("Alert", typeof(string), null, MappingType.Element);
			Columns.Add(columnAlert);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_ETAT_STOCKRow NewDataTable_ETAT_STOCKRow()
		{
			return (DataTable_ETAT_STOCKRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new DataTable_ETAT_STOCKRow(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(DataTable_ETAT_STOCKRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (DataTable_ETAT_STOCKRowChanged != null)
			{
				DataTable_ETAT_STOCKRowChanged?.Invoke(this, new DataTable_ETAT_STOCKRowChangeEvent((DataTable_ETAT_STOCKRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (DataTable_ETAT_STOCKRowChanging != null)
			{
				DataTable_ETAT_STOCKRowChanging?.Invoke(this, new DataTable_ETAT_STOCKRowChangeEvent((DataTable_ETAT_STOCKRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (DataTable_ETAT_STOCKRowDeleted != null)
			{
				DataTable_ETAT_STOCKRowDeleted?.Invoke(this, new DataTable_ETAT_STOCKRowChangeEvent((DataTable_ETAT_STOCKRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (DataTable_ETAT_STOCKRowDeleting != null)
			{
				DataTable_ETAT_STOCKRowDeleting?.Invoke(this, new DataTable_ETAT_STOCKRowChangeEvent((DataTable_ETAT_STOCKRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void RemoveDataTable_ETAT_STOCKRow(DataTable_ETAT_STOCKRow row)
		{
			Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Report_0_DATASET report_0_DATASET = new Report_0_DATASET();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal minOccurs = 0m;
			xmlSchemaAny.MinOccurs = minOccurs;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			minOccurs = 1m;
			xmlSchemaAny2.MinOccurs = minOccurs;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = report_0_DATASET.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "DataTable_ETAT_STOCKDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = report_0_DATASET.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class DataTable_TICKET_A4DataTable : TypedTableBase<DataTable_TICKET_A4Row>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnCode;

		private DataColumn columnArticle;

		private DataColumn columnQté;

		private DataColumn columnPrix_V;

		private DataColumn columnTOTAL_NET;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn CodeColumn => columnCode;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ArticleColumn => columnArticle;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn QtéColumn => columnQté;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn Prix_VColumn => columnPrix_V;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TOTAL_NETColumn => columnTOTAL_NET;

		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_TICKET_A4Row this[int index] => (DataTable_TICKET_A4Row)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_TICKET_A4RowChangeEventHandler DataTable_TICKET_A4RowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_TICKET_A4RowChangeEventHandler DataTable_TICKET_A4RowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_TICKET_A4RowChangeEventHandler DataTable_TICKET_A4RowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_TICKET_A4RowChangeEventHandler DataTable_TICKET_A4RowDeleted;

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			checked
			{
				lock (__ENCList)
				{
					if (__ENCList.Count == __ENCList.Capacity)
					{
						int num = 0;
						int num2 = __ENCList.Count - 1;
						int num3 = 0;
						while (true)
						{
							int num4 = num3;
							int num5 = num2;
							if (num4 > num5)
							{
								break;
							}
							WeakReference weakReference = __ENCList[num3];
							if (weakReference.IsAlive)
							{
								if (num3 != num)
								{
									__ENCList[num] = __ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						__ENCList.RemoveRange(num, __ENCList.Count - num);
						__ENCList.Capacity = __ENCList.Count;
					}
					__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_TICKET_A4DataTable()
		{
			__ENCAddToList(this);
			TableName = "DataTable_TICKET_A4";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal DataTable_TICKET_A4DataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected DataTable_TICKET_A4DataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void AddDataTable_TICKET_A4Row(DataTable_TICKET_A4Row row)
		{
			Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_TICKET_A4Row AddDataTable_TICKET_A4Row(string Code, string Article, string Qté, string Prix_V, string TOTAL_NET)
		{
			DataTable_TICKET_A4Row dataTable_TICKET_A4Row = (DataTable_TICKET_A4Row)NewRow();
			object[] itemArray = new object[5] { Code, Article, Qté, Prix_V, TOTAL_NET };
			dataTable_TICKET_A4Row.ItemArray = itemArray;
			Rows.Add(dataTable_TICKET_A4Row);
			return dataTable_TICKET_A4Row;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public override DataTable Clone()
		{
			DataTable_TICKET_A4DataTable dataTable_TICKET_A4DataTable = (DataTable_TICKET_A4DataTable)base.Clone();
			dataTable_TICKET_A4DataTable.InitVars();
			return dataTable_TICKET_A4DataTable;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new DataTable_TICKET_A4DataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnCode = Columns["Code"];
			columnArticle = Columns["Article"];
			columnQté = Columns["Qté"];
			columnPrix_V = Columns["Prix_V"];
			columnTOTAL_NET = Columns["TOTAL_NET"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		private void InitClass()
		{
			columnCode = new DataColumn("Code", typeof(string), null, MappingType.Element);
			Columns.Add(columnCode);
			columnArticle = new DataColumn("Article", typeof(string), null, MappingType.Element);
			Columns.Add(columnArticle);
			columnQté = new DataColumn("Qté", typeof(string), null, MappingType.Element);
			Columns.Add(columnQté);
			columnPrix_V = new DataColumn("Prix_V", typeof(string), null, MappingType.Element);
			Columns.Add(columnPrix_V);
			columnTOTAL_NET = new DataColumn("TOTAL_NET", typeof(string), null, MappingType.Element);
			Columns.Add(columnTOTAL_NET);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_TICKET_A4Row NewDataTable_TICKET_A4Row()
		{
			return (DataTable_TICKET_A4Row)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new DataTable_TICKET_A4Row(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(DataTable_TICKET_A4Row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (DataTable_TICKET_A4RowChanged != null)
			{
				DataTable_TICKET_A4RowChanged?.Invoke(this, new DataTable_TICKET_A4RowChangeEvent((DataTable_TICKET_A4Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (DataTable_TICKET_A4RowChanging != null)
			{
				DataTable_TICKET_A4RowChanging?.Invoke(this, new DataTable_TICKET_A4RowChangeEvent((DataTable_TICKET_A4Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (DataTable_TICKET_A4RowDeleted != null)
			{
				DataTable_TICKET_A4RowDeleted?.Invoke(this, new DataTable_TICKET_A4RowChangeEvent((DataTable_TICKET_A4Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (DataTable_TICKET_A4RowDeleting != null)
			{
				DataTable_TICKET_A4RowDeleting?.Invoke(this, new DataTable_TICKET_A4RowChangeEvent((DataTable_TICKET_A4Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void RemoveDataTable_TICKET_A4Row(DataTable_TICKET_A4Row row)
		{
			Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Report_0_DATASET report_0_DATASET = new Report_0_DATASET();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal minOccurs = 0m;
			xmlSchemaAny.MinOccurs = minOccurs;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			minOccurs = 1m;
			xmlSchemaAny2.MinOccurs = minOccurs;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = report_0_DATASET.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "DataTable_TICKET_A4DataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = report_0_DATASET.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class DataTable_NOMENCLATUREDataTable : TypedTableBase<DataTable_NOMENCLATURERow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnCODE_ARTICLE;

		private DataColumn columnARTICLE;

		private DataColumn columnCODE_MP;

		private DataColumn columnMP;

		private DataColumn columnQTE;

		private DataColumn columnUNITE;

		private DataColumn columnPRIX_A;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn CODE_ARTICLEColumn => columnCODE_ARTICLE;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ARTICLEColumn => columnARTICLE;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn CODE_MPColumn => columnCODE_MP;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn MPColumn => columnMP;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn QTEColumn => columnQTE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn UNITEColumn => columnUNITE;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn PRIX_AColumn => columnPRIX_A;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[Browsable(false)]
		[DebuggerNonUserCode]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_NOMENCLATURERow this[int index] => (DataTable_NOMENCLATURERow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_NOMENCLATURERowChangeEventHandler DataTable_NOMENCLATURERowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_NOMENCLATURERowChangeEventHandler DataTable_NOMENCLATURERowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_NOMENCLATURERowChangeEventHandler DataTable_NOMENCLATURERowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_NOMENCLATURERowChangeEventHandler DataTable_NOMENCLATURERowDeleted;

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			checked
			{
				lock (__ENCList)
				{
					if (__ENCList.Count == __ENCList.Capacity)
					{
						int num = 0;
						int num2 = __ENCList.Count - 1;
						int num3 = 0;
						while (true)
						{
							int num4 = num3;
							int num5 = num2;
							if (num4 > num5)
							{
								break;
							}
							WeakReference weakReference = __ENCList[num3];
							if (weakReference.IsAlive)
							{
								if (num3 != num)
								{
									__ENCList[num] = __ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						__ENCList.RemoveRange(num, __ENCList.Count - num);
						__ENCList.Capacity = __ENCList.Count;
					}
					__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_NOMENCLATUREDataTable()
		{
			__ENCAddToList(this);
			TableName = "DataTable_NOMENCLATURE";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		internal DataTable_NOMENCLATUREDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected DataTable_NOMENCLATUREDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void AddDataTable_NOMENCLATURERow(DataTable_NOMENCLATURERow row)
		{
			Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_NOMENCLATURERow AddDataTable_NOMENCLATURERow(string CODE_ARTICLE, string ARTICLE, string CODE_MP, string MP, decimal QTE, string UNITE, decimal PRIX_A)
		{
			DataTable_NOMENCLATURERow dataTable_NOMENCLATURERow = (DataTable_NOMENCLATURERow)NewRow();
			object[] itemArray = new object[7] { CODE_ARTICLE, ARTICLE, CODE_MP, MP, QTE, UNITE, PRIX_A };
			dataTable_NOMENCLATURERow.ItemArray = itemArray;
			Rows.Add(dataTable_NOMENCLATURERow);
			return dataTable_NOMENCLATURERow;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			DataTable_NOMENCLATUREDataTable dataTable_NOMENCLATUREDataTable = (DataTable_NOMENCLATUREDataTable)base.Clone();
			dataTable_NOMENCLATUREDataTable.InitVars();
			return dataTable_NOMENCLATUREDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new DataTable_NOMENCLATUREDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnCODE_ARTICLE = Columns["CODE_ARTICLE"];
			columnARTICLE = Columns["ARTICLE"];
			columnCODE_MP = Columns["CODE_MP"];
			columnMP = Columns["MP"];
			columnQTE = Columns["QTE"];
			columnUNITE = Columns["UNITE"];
			columnPRIX_A = Columns["PRIX_A"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		private void InitClass()
		{
			columnCODE_ARTICLE = new DataColumn("CODE_ARTICLE", typeof(string), null, MappingType.Element);
			Columns.Add(columnCODE_ARTICLE);
			columnARTICLE = new DataColumn("ARTICLE", typeof(string), null, MappingType.Element);
			Columns.Add(columnARTICLE);
			columnCODE_MP = new DataColumn("CODE_MP", typeof(string), null, MappingType.Element);
			Columns.Add(columnCODE_MP);
			columnMP = new DataColumn("MP", typeof(string), null, MappingType.Element);
			Columns.Add(columnMP);
			columnQTE = new DataColumn("QTE", typeof(decimal), null, MappingType.Element);
			Columns.Add(columnQTE);
			columnUNITE = new DataColumn("UNITE", typeof(string), null, MappingType.Element);
			Columns.Add(columnUNITE);
			columnPRIX_A = new DataColumn("PRIX_A", typeof(decimal), null, MappingType.Element);
			Columns.Add(columnPRIX_A);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_NOMENCLATURERow NewDataTable_NOMENCLATURERow()
		{
			return (DataTable_NOMENCLATURERow)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new DataTable_NOMENCLATURERow(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(DataTable_NOMENCLATURERow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (DataTable_NOMENCLATURERowChanged != null)
			{
				DataTable_NOMENCLATURERowChanged?.Invoke(this, new DataTable_NOMENCLATURERowChangeEvent((DataTable_NOMENCLATURERow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (DataTable_NOMENCLATURERowChanging != null)
			{
				DataTable_NOMENCLATURERowChanging?.Invoke(this, new DataTable_NOMENCLATURERowChangeEvent((DataTable_NOMENCLATURERow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (DataTable_NOMENCLATURERowDeleted != null)
			{
				DataTable_NOMENCLATURERowDeleted?.Invoke(this, new DataTable_NOMENCLATURERowChangeEvent((DataTable_NOMENCLATURERow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (DataTable_NOMENCLATURERowDeleting != null)
			{
				DataTable_NOMENCLATURERowDeleting?.Invoke(this, new DataTable_NOMENCLATURERowChangeEvent((DataTable_NOMENCLATURERow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void RemoveDataTable_NOMENCLATURERow(DataTable_NOMENCLATURERow row)
		{
			Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Report_0_DATASET report_0_DATASET = new Report_0_DATASET();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal minOccurs = 0m;
			xmlSchemaAny.MinOccurs = minOccurs;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			minOccurs = 1m;
			xmlSchemaAny2.MinOccurs = minOccurs;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = report_0_DATASET.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "DataTable_NOMENCLATUREDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = report_0_DATASET.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class DataTable_CLIENTS_ETAT_CREDITSDataTable : TypedTableBase<DataTable_CLIENTS_ETAT_CREDITSRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnID_CLIENT;

		private DataColumn columnCLIENT;

		private DataColumn columnCREDIT_INITIAL;

		private DataColumn columnTOTAL_CREDIT;

		private DataColumn columnTOTAL_RETOUR;

		private DataColumn columnTOTAL_REGLE;

		private DataColumn columnRELIQUAT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn ID_CLIENTColumn => columnID_CLIENT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn CLIENTColumn => columnCLIENT;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn CREDIT_INITIALColumn => columnCREDIT_INITIAL;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TOTAL_CREDITColumn => columnTOTAL_CREDIT;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TOTAL_RETOURColumn => columnTOTAL_RETOUR;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TOTAL_REGLEColumn => columnTOTAL_REGLE;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn RELIQUATColumn => columnRELIQUAT;

		[DebuggerNonUserCode]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public int Count => Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_CLIENTS_ETAT_CREDITSRow this[int index] => (DataTable_CLIENTS_ETAT_CREDITSRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_CLIENTS_ETAT_CREDITSRowChangeEventHandler DataTable_CLIENTS_ETAT_CREDITSRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_CLIENTS_ETAT_CREDITSRowChangeEventHandler DataTable_CLIENTS_ETAT_CREDITSRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_CLIENTS_ETAT_CREDITSRowChangeEventHandler DataTable_CLIENTS_ETAT_CREDITSRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_CLIENTS_ETAT_CREDITSRowChangeEventHandler DataTable_CLIENTS_ETAT_CREDITSRowDeleted;

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			checked
			{
				lock (__ENCList)
				{
					if (__ENCList.Count == __ENCList.Capacity)
					{
						int num = 0;
						int num2 = __ENCList.Count - 1;
						int num3 = 0;
						while (true)
						{
							int num4 = num3;
							int num5 = num2;
							if (num4 > num5)
							{
								break;
							}
							WeakReference weakReference = __ENCList[num3];
							if (weakReference.IsAlive)
							{
								if (num3 != num)
								{
									__ENCList[num] = __ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						__ENCList.RemoveRange(num, __ENCList.Count - num);
						__ENCList.Capacity = __ENCList.Count;
					}
					__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_CLIENTS_ETAT_CREDITSDataTable()
		{
			__ENCAddToList(this);
			TableName = "DataTable_CLIENTS_ETAT_CREDITS";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		internal DataTable_CLIENTS_ETAT_CREDITSDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected DataTable_CLIENTS_ETAT_CREDITSDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void AddDataTable_CLIENTS_ETAT_CREDITSRow(DataTable_CLIENTS_ETAT_CREDITSRow row)
		{
			Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_CLIENTS_ETAT_CREDITSRow AddDataTable_CLIENTS_ETAT_CREDITSRow(string ID_CLIENT, string CLIENT, string CREDIT_INITIAL, string TOTAL_CREDIT, string TOTAL_RETOUR, string TOTAL_REGLE, string RELIQUAT)
		{
			DataTable_CLIENTS_ETAT_CREDITSRow dataTable_CLIENTS_ETAT_CREDITSRow = (DataTable_CLIENTS_ETAT_CREDITSRow)NewRow();
			object[] itemArray = new object[7] { ID_CLIENT, CLIENT, CREDIT_INITIAL, TOTAL_CREDIT, TOTAL_RETOUR, TOTAL_REGLE, RELIQUAT };
			dataTable_CLIENTS_ETAT_CREDITSRow.ItemArray = itemArray;
			Rows.Add(dataTable_CLIENTS_ETAT_CREDITSRow);
			return dataTable_CLIENTS_ETAT_CREDITSRow;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			DataTable_CLIENTS_ETAT_CREDITSDataTable dataTable_CLIENTS_ETAT_CREDITSDataTable = (DataTable_CLIENTS_ETAT_CREDITSDataTable)base.Clone();
			dataTable_CLIENTS_ETAT_CREDITSDataTable.InitVars();
			return dataTable_CLIENTS_ETAT_CREDITSDataTable;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new DataTable_CLIENTS_ETAT_CREDITSDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnID_CLIENT = Columns["ID_CLIENT"];
			columnCLIENT = Columns["CLIENT"];
			columnCREDIT_INITIAL = Columns["CREDIT_INITIAL"];
			columnTOTAL_CREDIT = Columns["TOTAL_CREDIT"];
			columnTOTAL_RETOUR = Columns["TOTAL_RETOUR"];
			columnTOTAL_REGLE = Columns["TOTAL_REGLE"];
			columnRELIQUAT = Columns["RELIQUAT"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		private void InitClass()
		{
			columnID_CLIENT = new DataColumn("ID_CLIENT", typeof(string), null, MappingType.Element);
			Columns.Add(columnID_CLIENT);
			columnCLIENT = new DataColumn("CLIENT", typeof(string), null, MappingType.Element);
			Columns.Add(columnCLIENT);
			columnCREDIT_INITIAL = new DataColumn("CREDIT_INITIAL", typeof(string), null, MappingType.Element);
			Columns.Add(columnCREDIT_INITIAL);
			columnTOTAL_CREDIT = new DataColumn("TOTAL_CREDIT", typeof(string), null, MappingType.Element);
			Columns.Add(columnTOTAL_CREDIT);
			columnTOTAL_RETOUR = new DataColumn("TOTAL_RETOUR", typeof(string), null, MappingType.Element);
			Columns.Add(columnTOTAL_RETOUR);
			columnTOTAL_REGLE = new DataColumn("TOTAL_REGLE", typeof(string), null, MappingType.Element);
			Columns.Add(columnTOTAL_REGLE);
			columnRELIQUAT = new DataColumn("RELIQUAT", typeof(string), null, MappingType.Element);
			Columns.Add(columnRELIQUAT);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_CLIENTS_ETAT_CREDITSRow NewDataTable_CLIENTS_ETAT_CREDITSRow()
		{
			return (DataTable_CLIENTS_ETAT_CREDITSRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new DataTable_CLIENTS_ETAT_CREDITSRow(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(DataTable_CLIENTS_ETAT_CREDITSRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (DataTable_CLIENTS_ETAT_CREDITSRowChanged != null)
			{
				DataTable_CLIENTS_ETAT_CREDITSRowChanged?.Invoke(this, new DataTable_CLIENTS_ETAT_CREDITSRowChangeEvent((DataTable_CLIENTS_ETAT_CREDITSRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (DataTable_CLIENTS_ETAT_CREDITSRowChanging != null)
			{
				DataTable_CLIENTS_ETAT_CREDITSRowChanging?.Invoke(this, new DataTable_CLIENTS_ETAT_CREDITSRowChangeEvent((DataTable_CLIENTS_ETAT_CREDITSRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (DataTable_CLIENTS_ETAT_CREDITSRowDeleted != null)
			{
				DataTable_CLIENTS_ETAT_CREDITSRowDeleted?.Invoke(this, new DataTable_CLIENTS_ETAT_CREDITSRowChangeEvent((DataTable_CLIENTS_ETAT_CREDITSRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (DataTable_CLIENTS_ETAT_CREDITSRowDeleting != null)
			{
				DataTable_CLIENTS_ETAT_CREDITSRowDeleting?.Invoke(this, new DataTable_CLIENTS_ETAT_CREDITSRowChangeEvent((DataTable_CLIENTS_ETAT_CREDITSRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void RemoveDataTable_CLIENTS_ETAT_CREDITSRow(DataTable_CLIENTS_ETAT_CREDITSRow row)
		{
			Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Report_0_DATASET report_0_DATASET = new Report_0_DATASET();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal minOccurs = 0m;
			xmlSchemaAny.MinOccurs = minOccurs;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			minOccurs = 1m;
			xmlSchemaAny2.MinOccurs = minOccurs;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = report_0_DATASET.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "DataTable_CLIENTS_ETAT_CREDITSDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = report_0_DATASET.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class DataTable_CLIENTS_ETAT_HISTORIQUE_ADataTable : TypedTableBase<DataTable_CLIENTS_ETAT_HISTORIQUE_ARow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnDATES_CREDIT;

		private DataColumn columnTOTAL_NET;

		private DataColumn columnOPERATION;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn DATES_CREDITColumn => columnDATES_CREDIT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn TOTAL_NETColumn => columnTOTAL_NET;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn OPERATIONColumn => columnOPERATION;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		[Browsable(false)]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_CLIENTS_ETAT_HISTORIQUE_ARow this[int index] => (DataTable_CLIENTS_ETAT_HISTORIQUE_ARow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_CLIENTS_ETAT_HISTORIQUE_ARowChangeEventHandler DataTable_CLIENTS_ETAT_HISTORIQUE_ARowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_CLIENTS_ETAT_HISTORIQUE_ARowChangeEventHandler DataTable_CLIENTS_ETAT_HISTORIQUE_ARowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_CLIENTS_ETAT_HISTORIQUE_ARowChangeEventHandler DataTable_CLIENTS_ETAT_HISTORIQUE_ARowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_CLIENTS_ETAT_HISTORIQUE_ARowChangeEventHandler DataTable_CLIENTS_ETAT_HISTORIQUE_ARowDeleted;

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			checked
			{
				lock (__ENCList)
				{
					if (__ENCList.Count == __ENCList.Capacity)
					{
						int num = 0;
						int num2 = __ENCList.Count - 1;
						int num3 = 0;
						while (true)
						{
							int num4 = num3;
							int num5 = num2;
							if (num4 > num5)
							{
								break;
							}
							WeakReference weakReference = __ENCList[num3];
							if (weakReference.IsAlive)
							{
								if (num3 != num)
								{
									__ENCList[num] = __ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						__ENCList.RemoveRange(num, __ENCList.Count - num);
						__ENCList.Capacity = __ENCList.Count;
					}
					__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_CLIENTS_ETAT_HISTORIQUE_ADataTable()
		{
			__ENCAddToList(this);
			TableName = "DataTable_CLIENTS_ETAT_HISTORIQUE_A";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		internal DataTable_CLIENTS_ETAT_HISTORIQUE_ADataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected DataTable_CLIENTS_ETAT_HISTORIQUE_ADataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void AddDataTable_CLIENTS_ETAT_HISTORIQUE_ARow(DataTable_CLIENTS_ETAT_HISTORIQUE_ARow row)
		{
			Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_CLIENTS_ETAT_HISTORIQUE_ARow AddDataTable_CLIENTS_ETAT_HISTORIQUE_ARow(string DATES_CREDIT, string TOTAL_NET, string OPERATION)
		{
			DataTable_CLIENTS_ETAT_HISTORIQUE_ARow dataTable_CLIENTS_ETAT_HISTORIQUE_ARow = (DataTable_CLIENTS_ETAT_HISTORIQUE_ARow)NewRow();
			object[] itemArray = new object[3] { DATES_CREDIT, TOTAL_NET, OPERATION };
			dataTable_CLIENTS_ETAT_HISTORIQUE_ARow.ItemArray = itemArray;
			Rows.Add(dataTable_CLIENTS_ETAT_HISTORIQUE_ARow);
			return dataTable_CLIENTS_ETAT_HISTORIQUE_ARow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public override DataTable Clone()
		{
			DataTable_CLIENTS_ETAT_HISTORIQUE_ADataTable dataTable_CLIENTS_ETAT_HISTORIQUE_ADataTable = (DataTable_CLIENTS_ETAT_HISTORIQUE_ADataTable)base.Clone();
			dataTable_CLIENTS_ETAT_HISTORIQUE_ADataTable.InitVars();
			return dataTable_CLIENTS_ETAT_HISTORIQUE_ADataTable;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new DataTable_CLIENTS_ETAT_HISTORIQUE_ADataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal void InitVars()
		{
			columnDATES_CREDIT = Columns["DATES_CREDIT"];
			columnTOTAL_NET = Columns["TOTAL_NET"];
			columnOPERATION = Columns["OPERATION"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		private void InitClass()
		{
			columnDATES_CREDIT = new DataColumn("DATES_CREDIT", typeof(string), null, MappingType.Element);
			Columns.Add(columnDATES_CREDIT);
			columnTOTAL_NET = new DataColumn("TOTAL_NET", typeof(string), null, MappingType.Element);
			Columns.Add(columnTOTAL_NET);
			columnOPERATION = new DataColumn("OPERATION", typeof(string), null, MappingType.Element);
			Columns.Add(columnOPERATION);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_CLIENTS_ETAT_HISTORIQUE_ARow NewDataTable_CLIENTS_ETAT_HISTORIQUE_ARow()
		{
			return (DataTable_CLIENTS_ETAT_HISTORIQUE_ARow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new DataTable_CLIENTS_ETAT_HISTORIQUE_ARow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(DataTable_CLIENTS_ETAT_HISTORIQUE_ARow);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (DataTable_CLIENTS_ETAT_HISTORIQUE_ARowChanged != null)
			{
				DataTable_CLIENTS_ETAT_HISTORIQUE_ARowChanged?.Invoke(this, new DataTable_CLIENTS_ETAT_HISTORIQUE_ARowChangeEvent((DataTable_CLIENTS_ETAT_HISTORIQUE_ARow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (DataTable_CLIENTS_ETAT_HISTORIQUE_ARowChanging != null)
			{
				DataTable_CLIENTS_ETAT_HISTORIQUE_ARowChanging?.Invoke(this, new DataTable_CLIENTS_ETAT_HISTORIQUE_ARowChangeEvent((DataTable_CLIENTS_ETAT_HISTORIQUE_ARow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (DataTable_CLIENTS_ETAT_HISTORIQUE_ARowDeleted != null)
			{
				DataTable_CLIENTS_ETAT_HISTORIQUE_ARowDeleted?.Invoke(this, new DataTable_CLIENTS_ETAT_HISTORIQUE_ARowChangeEvent((DataTable_CLIENTS_ETAT_HISTORIQUE_ARow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (DataTable_CLIENTS_ETAT_HISTORIQUE_ARowDeleting != null)
			{
				DataTable_CLIENTS_ETAT_HISTORIQUE_ARowDeleting?.Invoke(this, new DataTable_CLIENTS_ETAT_HISTORIQUE_ARowChangeEvent((DataTable_CLIENTS_ETAT_HISTORIQUE_ARow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void RemoveDataTable_CLIENTS_ETAT_HISTORIQUE_ARow(DataTable_CLIENTS_ETAT_HISTORIQUE_ARow row)
		{
			Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Report_0_DATASET report_0_DATASET = new Report_0_DATASET();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal minOccurs = 0m;
			xmlSchemaAny.MinOccurs = minOccurs;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			minOccurs = 1m;
			xmlSchemaAny2.MinOccurs = minOccurs;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = report_0_DATASET.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "DataTable_CLIENTS_ETAT_HISTORIQUE_ADataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = report_0_DATASET.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class DataTable_CLIENTS_ETAT_HISTORIQUE_BDataTable : TypedTableBase<DataTable_CLIENTS_ETAT_HISTORIQUE_BRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnDATES_REGLEMENT;

		private DataColumn columnMONTANT;

		private DataColumn columnNOTES;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DATES_REGLEMENTColumn => columnDATES_REGLEMENT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn MONTANTColumn => columnMONTANT;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NOTESColumn => columnNOTES;

		[DebuggerNonUserCode]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_CLIENTS_ETAT_HISTORIQUE_BRow this[int index] => (DataTable_CLIENTS_ETAT_HISTORIQUE_BRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_CLIENTS_ETAT_HISTORIQUE_BRowChangeEventHandler DataTable_CLIENTS_ETAT_HISTORIQUE_BRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_CLIENTS_ETAT_HISTORIQUE_BRowChangeEventHandler DataTable_CLIENTS_ETAT_HISTORIQUE_BRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_CLIENTS_ETAT_HISTORIQUE_BRowChangeEventHandler DataTable_CLIENTS_ETAT_HISTORIQUE_BRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_CLIENTS_ETAT_HISTORIQUE_BRowChangeEventHandler DataTable_CLIENTS_ETAT_HISTORIQUE_BRowDeleted;

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			checked
			{
				lock (__ENCList)
				{
					if (__ENCList.Count == __ENCList.Capacity)
					{
						int num = 0;
						int num2 = __ENCList.Count - 1;
						int num3 = 0;
						while (true)
						{
							int num4 = num3;
							int num5 = num2;
							if (num4 > num5)
							{
								break;
							}
							WeakReference weakReference = __ENCList[num3];
							if (weakReference.IsAlive)
							{
								if (num3 != num)
								{
									__ENCList[num] = __ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						__ENCList.RemoveRange(num, __ENCList.Count - num);
						__ENCList.Capacity = __ENCList.Count;
					}
					__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_CLIENTS_ETAT_HISTORIQUE_BDataTable()
		{
			__ENCAddToList(this);
			TableName = "DataTable_CLIENTS_ETAT_HISTORIQUE_B";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal DataTable_CLIENTS_ETAT_HISTORIQUE_BDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected DataTable_CLIENTS_ETAT_HISTORIQUE_BDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void AddDataTable_CLIENTS_ETAT_HISTORIQUE_BRow(DataTable_CLIENTS_ETAT_HISTORIQUE_BRow row)
		{
			Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_CLIENTS_ETAT_HISTORIQUE_BRow AddDataTable_CLIENTS_ETAT_HISTORIQUE_BRow(string DATES_REGLEMENT, string MONTANT, string NOTES)
		{
			DataTable_CLIENTS_ETAT_HISTORIQUE_BRow dataTable_CLIENTS_ETAT_HISTORIQUE_BRow = (DataTable_CLIENTS_ETAT_HISTORIQUE_BRow)NewRow();
			object[] itemArray = new object[3] { DATES_REGLEMENT, MONTANT, NOTES };
			dataTable_CLIENTS_ETAT_HISTORIQUE_BRow.ItemArray = itemArray;
			Rows.Add(dataTable_CLIENTS_ETAT_HISTORIQUE_BRow);
			return dataTable_CLIENTS_ETAT_HISTORIQUE_BRow;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			DataTable_CLIENTS_ETAT_HISTORIQUE_BDataTable dataTable_CLIENTS_ETAT_HISTORIQUE_BDataTable = (DataTable_CLIENTS_ETAT_HISTORIQUE_BDataTable)base.Clone();
			dataTable_CLIENTS_ETAT_HISTORIQUE_BDataTable.InitVars();
			return dataTable_CLIENTS_ETAT_HISTORIQUE_BDataTable;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new DataTable_CLIENTS_ETAT_HISTORIQUE_BDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal void InitVars()
		{
			columnDATES_REGLEMENT = Columns["DATES_REGLEMENT"];
			columnMONTANT = Columns["MONTANT"];
			columnNOTES = Columns["NOTES"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		private void InitClass()
		{
			columnDATES_REGLEMENT = new DataColumn("DATES_REGLEMENT", typeof(string), null, MappingType.Element);
			Columns.Add(columnDATES_REGLEMENT);
			columnMONTANT = new DataColumn("MONTANT", typeof(string), null, MappingType.Element);
			Columns.Add(columnMONTANT);
			columnNOTES = new DataColumn("NOTES", typeof(string), null, MappingType.Element);
			Columns.Add(columnNOTES);
			columnDATES_REGLEMENT.Caption = "DATES";
			columnMONTANT.Caption = "TOTAL_NET";
			columnNOTES.Caption = "OPERATION";
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_CLIENTS_ETAT_HISTORIQUE_BRow NewDataTable_CLIENTS_ETAT_HISTORIQUE_BRow()
		{
			return (DataTable_CLIENTS_ETAT_HISTORIQUE_BRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new DataTable_CLIENTS_ETAT_HISTORIQUE_BRow(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(DataTable_CLIENTS_ETAT_HISTORIQUE_BRow);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (DataTable_CLIENTS_ETAT_HISTORIQUE_BRowChanged != null)
			{
				DataTable_CLIENTS_ETAT_HISTORIQUE_BRowChanged?.Invoke(this, new DataTable_CLIENTS_ETAT_HISTORIQUE_BRowChangeEvent((DataTable_CLIENTS_ETAT_HISTORIQUE_BRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (DataTable_CLIENTS_ETAT_HISTORIQUE_BRowChanging != null)
			{
				DataTable_CLIENTS_ETAT_HISTORIQUE_BRowChanging?.Invoke(this, new DataTable_CLIENTS_ETAT_HISTORIQUE_BRowChangeEvent((DataTable_CLIENTS_ETAT_HISTORIQUE_BRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (DataTable_CLIENTS_ETAT_HISTORIQUE_BRowDeleted != null)
			{
				DataTable_CLIENTS_ETAT_HISTORIQUE_BRowDeleted?.Invoke(this, new DataTable_CLIENTS_ETAT_HISTORIQUE_BRowChangeEvent((DataTable_CLIENTS_ETAT_HISTORIQUE_BRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (DataTable_CLIENTS_ETAT_HISTORIQUE_BRowDeleting != null)
			{
				DataTable_CLIENTS_ETAT_HISTORIQUE_BRowDeleting?.Invoke(this, new DataTable_CLIENTS_ETAT_HISTORIQUE_BRowChangeEvent((DataTable_CLIENTS_ETAT_HISTORIQUE_BRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void RemoveDataTable_CLIENTS_ETAT_HISTORIQUE_BRow(DataTable_CLIENTS_ETAT_HISTORIQUE_BRow row)
		{
			Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Report_0_DATASET report_0_DATASET = new Report_0_DATASET();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal minOccurs = 0m;
			xmlSchemaAny.MinOccurs = minOccurs;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			minOccurs = 1m;
			xmlSchemaAny2.MinOccurs = minOccurs;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = report_0_DATASET.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "DataTable_CLIENTS_ETAT_HISTORIQUE_BDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = report_0_DATASET.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSDataTable : TypedTableBase<DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnTICKET;

		private DataColumn columnDATES;

		private DataColumn columnHEURE;

		private DataColumn columnARTICLE;

		private DataColumn columnPRIX_V;

		private DataColumn columnQté;

		private DataColumn columnREMISE;

		private DataColumn columnTOTAL_NET;

		private DataColumn columnCAISSIER;

		private DataColumn columnOPERATION;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn TICKETColumn => columnTICKET;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn DATESColumn => columnDATES;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn HEUREColumn => columnHEURE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn ARTICLEColumn => columnARTICLE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn PRIX_VColumn => columnPRIX_V;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn QtéColumn => columnQté;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn REMISEColumn => columnREMISE;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TOTAL_NETColumn => columnTOTAL_NET;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn CAISSIERColumn => columnCAISSIER;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn OPERATIONColumn => columnOPERATION;

		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRow this[int index] => (DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRowChangeEventHandler DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRowChangeEventHandler DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRowChangeEventHandler DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRowChangeEventHandler DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRowDeleted;

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			checked
			{
				lock (__ENCList)
				{
					if (__ENCList.Count == __ENCList.Capacity)
					{
						int num = 0;
						int num2 = __ENCList.Count - 1;
						int num3 = 0;
						while (true)
						{
							int num4 = num3;
							int num5 = num2;
							if (num4 > num5)
							{
								break;
							}
							WeakReference weakReference = __ENCList[num3];
							if (weakReference.IsAlive)
							{
								if (num3 != num)
								{
									__ENCList[num] = __ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						__ENCList.RemoveRange(num, __ENCList.Count - num);
						__ENCList.Capacity = __ENCList.Count;
					}
					__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSDataTable()
		{
			__ENCAddToList(this);
			TableName = "DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		internal DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void AddDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRow(DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRow row)
		{
			Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRow AddDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRow(string TICKET, string DATES, string HEURE, string ARTICLE, string PRIX_V, string Qté, string REMISE, string TOTAL_NET, string CAISSIER, string OPERATION)
		{
			DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRow dataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRow = (DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRow)NewRow();
			object[] itemArray = new object[10] { TICKET, DATES, HEURE, ARTICLE, PRIX_V, Qté, REMISE, TOTAL_NET, CAISSIER, OPERATION };
			dataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRow.ItemArray = itemArray;
			Rows.Add(dataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRow);
			return dataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRow;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSDataTable dataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSDataTable = (DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSDataTable)base.Clone();
			dataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSDataTable.InitVars();
			return dataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnTICKET = Columns["TICKET"];
			columnDATES = Columns["DATES"];
			columnHEURE = Columns["HEURE"];
			columnARTICLE = Columns["ARTICLE"];
			columnPRIX_V = Columns["PRIX_V"];
			columnQté = Columns["Qté"];
			columnREMISE = Columns["REMISE"];
			columnTOTAL_NET = Columns["TOTAL_NET"];
			columnCAISSIER = Columns["CAISSIER"];
			columnOPERATION = Columns["OPERATION"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnTICKET = new DataColumn("TICKET", typeof(string), null, MappingType.Element);
			Columns.Add(columnTICKET);
			columnDATES = new DataColumn("DATES", typeof(string), null, MappingType.Element);
			Columns.Add(columnDATES);
			columnHEURE = new DataColumn("HEURE", typeof(string), null, MappingType.Element);
			Columns.Add(columnHEURE);
			columnARTICLE = new DataColumn("ARTICLE", typeof(string), null, MappingType.Element);
			Columns.Add(columnARTICLE);
			columnPRIX_V = new DataColumn("PRIX_V", typeof(string), null, MappingType.Element);
			Columns.Add(columnPRIX_V);
			columnQté = new DataColumn("Qté", typeof(string), null, MappingType.Element);
			Columns.Add(columnQté);
			columnREMISE = new DataColumn("REMISE", typeof(string), null, MappingType.Element);
			Columns.Add(columnREMISE);
			columnTOTAL_NET = new DataColumn("TOTAL_NET", typeof(string), null, MappingType.Element);
			Columns.Add(columnTOTAL_NET);
			columnCAISSIER = new DataColumn("CAISSIER", typeof(string), null, MappingType.Element);
			Columns.Add(columnCAISSIER);
			columnOPERATION = new DataColumn("OPERATION", typeof(string), null, MappingType.Element);
			Columns.Add(columnOPERATION);
			columnTICKET.Caption = "DATES";
			columnDATES.Caption = "TOTAL_NET";
			columnHEURE.Caption = "OPERATION";
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRow NewDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRow()
		{
			return (DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRow)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRow);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRowChanged != null)
			{
				DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRowChanged?.Invoke(this, new DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRowChangeEvent((DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRowChanging != null)
			{
				DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRowChanging?.Invoke(this, new DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRowChangeEvent((DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRowDeleted != null)
			{
				DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRowDeleted?.Invoke(this, new DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRowChangeEvent((DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRowDeleting != null)
			{
				DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRowDeleting?.Invoke(this, new DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRowChangeEvent((DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void RemoveDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRow(DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRow row)
		{
			Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Report_0_DATASET report_0_DATASET = new Report_0_DATASET();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal minOccurs = 0m;
			xmlSchemaAny.MinOccurs = minOccurs;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			minOccurs = 1m;
			xmlSchemaAny2.MinOccurs = minOccurs;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = report_0_DATASET.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = report_0_DATASET.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class DataTable_FOURNISSEURS_ETAT_CREDITSDataTable : TypedTableBase<DataTable_FOURNISSEURS_ETAT_CREDITSRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnID_FOURNISSEUR;

		private DataColumn columnFOURNISSEUR;

		private DataColumn columnCREDIT_INITIAL;

		private DataColumn columnTOTAL_RECEPTIONS;

		private DataColumn columnTOTAL_SORTIES;

		private DataColumn columnTOTAL_REGLE;

		private DataColumn columnRELIQUAT;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ID_FOURNISSEURColumn => columnID_FOURNISSEUR;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn FOURNISSEURColumn => columnFOURNISSEUR;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn CREDIT_INITIALColumn => columnCREDIT_INITIAL;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TOTAL_RECEPTIONSColumn => columnTOTAL_RECEPTIONS;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TOTAL_SORTIESColumn => columnTOTAL_SORTIES;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TOTAL_REGLEColumn => columnTOTAL_REGLE;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn RELIQUATColumn => columnRELIQUAT;

		[DebuggerNonUserCode]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public int Count => Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_FOURNISSEURS_ETAT_CREDITSRow this[int index] => (DataTable_FOURNISSEURS_ETAT_CREDITSRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_FOURNISSEURS_ETAT_CREDITSRowChangeEventHandler DataTable_FOURNISSEURS_ETAT_CREDITSRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_FOURNISSEURS_ETAT_CREDITSRowChangeEventHandler DataTable_FOURNISSEURS_ETAT_CREDITSRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_FOURNISSEURS_ETAT_CREDITSRowChangeEventHandler DataTable_FOURNISSEURS_ETAT_CREDITSRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_FOURNISSEURS_ETAT_CREDITSRowChangeEventHandler DataTable_FOURNISSEURS_ETAT_CREDITSRowDeleted;

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			checked
			{
				lock (__ENCList)
				{
					if (__ENCList.Count == __ENCList.Capacity)
					{
						int num = 0;
						int num2 = __ENCList.Count - 1;
						int num3 = 0;
						while (true)
						{
							int num4 = num3;
							int num5 = num2;
							if (num4 > num5)
							{
								break;
							}
							WeakReference weakReference = __ENCList[num3];
							if (weakReference.IsAlive)
							{
								if (num3 != num)
								{
									__ENCList[num] = __ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						__ENCList.RemoveRange(num, __ENCList.Count - num);
						__ENCList.Capacity = __ENCList.Count;
					}
					__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_FOURNISSEURS_ETAT_CREDITSDataTable()
		{
			__ENCAddToList(this);
			TableName = "DataTable_FOURNISSEURS_ETAT_CREDITS";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal DataTable_FOURNISSEURS_ETAT_CREDITSDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected DataTable_FOURNISSEURS_ETAT_CREDITSDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void AddDataTable_FOURNISSEURS_ETAT_CREDITSRow(DataTable_FOURNISSEURS_ETAT_CREDITSRow row)
		{
			Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_FOURNISSEURS_ETAT_CREDITSRow AddDataTable_FOURNISSEURS_ETAT_CREDITSRow(string ID_FOURNISSEUR, string FOURNISSEUR, string CREDIT_INITIAL, string TOTAL_RECEPTIONS, string TOTAL_SORTIES, string TOTAL_REGLE, string RELIQUAT)
		{
			DataTable_FOURNISSEURS_ETAT_CREDITSRow dataTable_FOURNISSEURS_ETAT_CREDITSRow = (DataTable_FOURNISSEURS_ETAT_CREDITSRow)NewRow();
			object[] itemArray = new object[7] { ID_FOURNISSEUR, FOURNISSEUR, CREDIT_INITIAL, TOTAL_RECEPTIONS, TOTAL_SORTIES, TOTAL_REGLE, RELIQUAT };
			dataTable_FOURNISSEURS_ETAT_CREDITSRow.ItemArray = itemArray;
			Rows.Add(dataTable_FOURNISSEURS_ETAT_CREDITSRow);
			return dataTable_FOURNISSEURS_ETAT_CREDITSRow;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			DataTable_FOURNISSEURS_ETAT_CREDITSDataTable dataTable_FOURNISSEURS_ETAT_CREDITSDataTable = (DataTable_FOURNISSEURS_ETAT_CREDITSDataTable)base.Clone();
			dataTable_FOURNISSEURS_ETAT_CREDITSDataTable.InitVars();
			return dataTable_FOURNISSEURS_ETAT_CREDITSDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new DataTable_FOURNISSEURS_ETAT_CREDITSDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnID_FOURNISSEUR = Columns["ID_FOURNISSEUR"];
			columnFOURNISSEUR = Columns["FOURNISSEUR"];
			columnCREDIT_INITIAL = Columns["CREDIT_INITIAL"];
			columnTOTAL_RECEPTIONS = Columns["TOTAL_RECEPTIONS"];
			columnTOTAL_SORTIES = Columns["TOTAL_SORTIES"];
			columnTOTAL_REGLE = Columns["TOTAL_REGLE"];
			columnRELIQUAT = Columns["RELIQUAT"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		private void InitClass()
		{
			columnID_FOURNISSEUR = new DataColumn("ID_FOURNISSEUR", typeof(string), null, MappingType.Element);
			Columns.Add(columnID_FOURNISSEUR);
			columnFOURNISSEUR = new DataColumn("FOURNISSEUR", typeof(string), null, MappingType.Element);
			Columns.Add(columnFOURNISSEUR);
			columnCREDIT_INITIAL = new DataColumn("CREDIT_INITIAL", typeof(string), null, MappingType.Element);
			Columns.Add(columnCREDIT_INITIAL);
			columnTOTAL_RECEPTIONS = new DataColumn("TOTAL_RECEPTIONS", typeof(string), null, MappingType.Element);
			Columns.Add(columnTOTAL_RECEPTIONS);
			columnTOTAL_SORTIES = new DataColumn("TOTAL_SORTIES", typeof(string), null, MappingType.Element);
			Columns.Add(columnTOTAL_SORTIES);
			columnTOTAL_REGLE = new DataColumn("TOTAL_REGLE", typeof(string), null, MappingType.Element);
			Columns.Add(columnTOTAL_REGLE);
			columnRELIQUAT = new DataColumn("RELIQUAT", typeof(string), null, MappingType.Element);
			Columns.Add(columnRELIQUAT);
			columnID_FOURNISSEUR.Caption = "ID_CLIENT";
			columnFOURNISSEUR.Caption = "CLIENT";
			columnTOTAL_RECEPTIONS.Caption = "TOTAL_CREDIT";
			columnTOTAL_SORTIES.Caption = "TOTAL_RETOUR";
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_FOURNISSEURS_ETAT_CREDITSRow NewDataTable_FOURNISSEURS_ETAT_CREDITSRow()
		{
			return (DataTable_FOURNISSEURS_ETAT_CREDITSRow)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new DataTable_FOURNISSEURS_ETAT_CREDITSRow(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(DataTable_FOURNISSEURS_ETAT_CREDITSRow);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (DataTable_FOURNISSEURS_ETAT_CREDITSRowChanged != null)
			{
				DataTable_FOURNISSEURS_ETAT_CREDITSRowChanged?.Invoke(this, new DataTable_FOURNISSEURS_ETAT_CREDITSRowChangeEvent((DataTable_FOURNISSEURS_ETAT_CREDITSRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (DataTable_FOURNISSEURS_ETAT_CREDITSRowChanging != null)
			{
				DataTable_FOURNISSEURS_ETAT_CREDITSRowChanging?.Invoke(this, new DataTable_FOURNISSEURS_ETAT_CREDITSRowChangeEvent((DataTable_FOURNISSEURS_ETAT_CREDITSRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (DataTable_FOURNISSEURS_ETAT_CREDITSRowDeleted != null)
			{
				DataTable_FOURNISSEURS_ETAT_CREDITSRowDeleted?.Invoke(this, new DataTable_FOURNISSEURS_ETAT_CREDITSRowChangeEvent((DataTable_FOURNISSEURS_ETAT_CREDITSRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (DataTable_FOURNISSEURS_ETAT_CREDITSRowDeleting != null)
			{
				DataTable_FOURNISSEURS_ETAT_CREDITSRowDeleting?.Invoke(this, new DataTable_FOURNISSEURS_ETAT_CREDITSRowChangeEvent((DataTable_FOURNISSEURS_ETAT_CREDITSRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void RemoveDataTable_FOURNISSEURS_ETAT_CREDITSRow(DataTable_FOURNISSEURS_ETAT_CREDITSRow row)
		{
			Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Report_0_DATASET report_0_DATASET = new Report_0_DATASET();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal minOccurs = 0m;
			xmlSchemaAny.MinOccurs = minOccurs;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			minOccurs = 1m;
			xmlSchemaAny2.MinOccurs = minOccurs;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = report_0_DATASET.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "DataTable_FOURNISSEURS_ETAT_CREDITSDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = report_0_DATASET.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class DataTable_BCDataTable : TypedTableBase<DataTable_BCRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnCode;

		private DataColumn columnArticle;

		private DataColumn columnQté;

		private DataColumn columnPrix_A;

		private DataColumn columnPrix_V;

		private DataColumn columnTOTAL_NET_ACHATS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn CodeColumn => columnCode;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn ArticleColumn => columnArticle;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn QtéColumn => columnQté;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn Prix_AColumn => columnPrix_A;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn Prix_VColumn => columnPrix_V;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TOTAL_NET_ACHATSColumn => columnTOTAL_NET_ACHATS;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		[Browsable(false)]
		public int Count => Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_BCRow this[int index] => (DataTable_BCRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_BCRowChangeEventHandler DataTable_BCRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_BCRowChangeEventHandler DataTable_BCRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_BCRowChangeEventHandler DataTable_BCRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_BCRowChangeEventHandler DataTable_BCRowDeleted;

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			checked
			{
				lock (__ENCList)
				{
					if (__ENCList.Count == __ENCList.Capacity)
					{
						int num = 0;
						int num2 = __ENCList.Count - 1;
						int num3 = 0;
						while (true)
						{
							int num4 = num3;
							int num5 = num2;
							if (num4 > num5)
							{
								break;
							}
							WeakReference weakReference = __ENCList[num3];
							if (weakReference.IsAlive)
							{
								if (num3 != num)
								{
									__ENCList[num] = __ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						__ENCList.RemoveRange(num, __ENCList.Count - num);
						__ENCList.Capacity = __ENCList.Count;
					}
					__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_BCDataTable()
		{
			__ENCAddToList(this);
			TableName = "DataTable_BC";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal DataTable_BCDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected DataTable_BCDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void AddDataTable_BCRow(DataTable_BCRow row)
		{
			Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_BCRow AddDataTable_BCRow(string Code, string Article, string Qté, string Prix_A, string Prix_V, string TOTAL_NET_ACHATS)
		{
			DataTable_BCRow dataTable_BCRow = (DataTable_BCRow)NewRow();
			object[] itemArray = new object[6] { Code, Article, Qté, Prix_A, Prix_V, TOTAL_NET_ACHATS };
			dataTable_BCRow.ItemArray = itemArray;
			Rows.Add(dataTable_BCRow);
			return dataTable_BCRow;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			DataTable_BCDataTable dataTable_BCDataTable = (DataTable_BCDataTable)base.Clone();
			dataTable_BCDataTable.InitVars();
			return dataTable_BCDataTable;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new DataTable_BCDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal void InitVars()
		{
			columnCode = Columns["Code"];
			columnArticle = Columns["Article"];
			columnQté = Columns["Qté"];
			columnPrix_A = Columns["Prix_A"];
			columnPrix_V = Columns["Prix_V"];
			columnTOTAL_NET_ACHATS = Columns["TOTAL_NET_ACHATS"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		private void InitClass()
		{
			columnCode = new DataColumn("Code", typeof(string), null, MappingType.Element);
			Columns.Add(columnCode);
			columnArticle = new DataColumn("Article", typeof(string), null, MappingType.Element);
			Columns.Add(columnArticle);
			columnQté = new DataColumn("Qté", typeof(string), null, MappingType.Element);
			Columns.Add(columnQté);
			columnPrix_A = new DataColumn("Prix_A", typeof(string), null, MappingType.Element);
			Columns.Add(columnPrix_A);
			columnPrix_V = new DataColumn("Prix_V", typeof(string), null, MappingType.Element);
			Columns.Add(columnPrix_V);
			columnTOTAL_NET_ACHATS = new DataColumn("TOTAL_NET_ACHATS", typeof(string), null, MappingType.Element);
			Columns.Add(columnTOTAL_NET_ACHATS);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_BCRow NewDataTable_BCRow()
		{
			return (DataTable_BCRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new DataTable_BCRow(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(DataTable_BCRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (DataTable_BCRowChanged != null)
			{
				DataTable_BCRowChanged?.Invoke(this, new DataTable_BCRowChangeEvent((DataTable_BCRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (DataTable_BCRowChanging != null)
			{
				DataTable_BCRowChanging?.Invoke(this, new DataTable_BCRowChangeEvent((DataTable_BCRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (DataTable_BCRowDeleted != null)
			{
				DataTable_BCRowDeleted?.Invoke(this, new DataTable_BCRowChangeEvent((DataTable_BCRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (DataTable_BCRowDeleting != null)
			{
				DataTable_BCRowDeleting?.Invoke(this, new DataTable_BCRowChangeEvent((DataTable_BCRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void RemoveDataTable_BCRow(DataTable_BCRow row)
		{
			Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Report_0_DATASET report_0_DATASET = new Report_0_DATASET();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal minOccurs = 0m;
			xmlSchemaAny.MinOccurs = minOccurs;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			minOccurs = 1m;
			xmlSchemaAny2.MinOccurs = minOccurs;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = report_0_DATASET.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "DataTable_BCDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = report_0_DATASET.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ADataTable : TypedTableBase<DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnDATES_RECE_SORT;

		private DataColumn columnTOTAL_NET_ACHATS;

		private DataColumn columnTYPE;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DATES_RECE_SORTColumn => columnDATES_RECE_SORT;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TOTAL_NET_ACHATSColumn => columnTOTAL_NET_ACHATS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn TYPEColumn => columnTYPE;

		[DebuggerNonUserCode]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public int Count => Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARow this[int index] => (DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARowChangeEventHandler DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARowChangeEventHandler DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARowChangeEventHandler DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARowChangeEventHandler DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARowDeleted;

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			checked
			{
				lock (__ENCList)
				{
					if (__ENCList.Count == __ENCList.Capacity)
					{
						int num = 0;
						int num2 = __ENCList.Count - 1;
						int num3 = 0;
						while (true)
						{
							int num4 = num3;
							int num5 = num2;
							if (num4 > num5)
							{
								break;
							}
							WeakReference weakReference = __ENCList[num3];
							if (weakReference.IsAlive)
							{
								if (num3 != num)
								{
									__ENCList[num] = __ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						__ENCList.RemoveRange(num, __ENCList.Count - num);
						__ENCList.Capacity = __ENCList.Count;
					}
					__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ADataTable()
		{
			__ENCAddToList(this);
			TableName = "DataTable_FOURNISSEURS_ETAT_HISTORIQUE_A";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		internal DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ADataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ADataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void AddDataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARow(DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARow row)
		{
			Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARow AddDataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARow(string DATES_RECE_SORT, string TOTAL_NET_ACHATS, string TYPE)
		{
			DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARow dataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARow = (DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARow)NewRow();
			object[] itemArray = new object[3] { DATES_RECE_SORT, TOTAL_NET_ACHATS, TYPE };
			dataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARow.ItemArray = itemArray;
			Rows.Add(dataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARow);
			return dataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public override DataTable Clone()
		{
			DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ADataTable dataTable_FOURNISSEURS_ETAT_HISTORIQUE_ADataTable = (DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ADataTable)base.Clone();
			dataTable_FOURNISSEURS_ETAT_HISTORIQUE_ADataTable.InitVars();
			return dataTable_FOURNISSEURS_ETAT_HISTORIQUE_ADataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ADataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal void InitVars()
		{
			columnDATES_RECE_SORT = Columns["DATES_RECE_SORT"];
			columnTOTAL_NET_ACHATS = Columns["TOTAL_NET_ACHATS"];
			columnTYPE = Columns["TYPE"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnDATES_RECE_SORT = new DataColumn("DATES_RECE_SORT", typeof(string), null, MappingType.Element);
			Columns.Add(columnDATES_RECE_SORT);
			columnTOTAL_NET_ACHATS = new DataColumn("TOTAL_NET_ACHATS", typeof(string), null, MappingType.Element);
			Columns.Add(columnTOTAL_NET_ACHATS);
			columnTYPE = new DataColumn("TYPE", typeof(string), null, MappingType.Element);
			Columns.Add(columnTYPE);
			columnTYPE.Caption = "OPERATION";
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARow NewDataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARow()
		{
			return (DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARowChanged != null)
			{
				DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARowChanged?.Invoke(this, new DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARowChangeEvent((DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARowChanging != null)
			{
				DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARowChanging?.Invoke(this, new DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARowChangeEvent((DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARowDeleted != null)
			{
				DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARowDeleted?.Invoke(this, new DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARowChangeEvent((DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARowDeleting != null)
			{
				DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARowDeleting?.Invoke(this, new DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARowChangeEvent((DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void RemoveDataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARow(DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARow row)
		{
			Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Report_0_DATASET report_0_DATASET = new Report_0_DATASET();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal minOccurs = 0m;
			xmlSchemaAny.MinOccurs = minOccurs;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			minOccurs = 1m;
			xmlSchemaAny2.MinOccurs = minOccurs;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = report_0_DATASET.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ADataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = report_0_DATASET.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BDataTable : TypedTableBase<DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnDATES_REGLEMENT;

		private DataColumn columnMONTANT;

		private DataColumn columnNOTES;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DATES_REGLEMENTColumn => columnDATES_REGLEMENT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn MONTANTColumn => columnMONTANT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NOTESColumn => columnNOTES;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[Browsable(false)]
		[DebuggerNonUserCode]
		public int Count => Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRow this[int index] => (DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRowChangeEventHandler DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRowChangeEventHandler DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRowChangeEventHandler DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[method: DebuggerNonUserCode]
		public event DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRowChangeEventHandler DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRowDeleted;

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			checked
			{
				lock (__ENCList)
				{
					if (__ENCList.Count == __ENCList.Capacity)
					{
						int num = 0;
						int num2 = __ENCList.Count - 1;
						int num3 = 0;
						while (true)
						{
							int num4 = num3;
							int num5 = num2;
							if (num4 > num5)
							{
								break;
							}
							WeakReference weakReference = __ENCList[num3];
							if (weakReference.IsAlive)
							{
								if (num3 != num)
								{
									__ENCList[num] = __ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						__ENCList.RemoveRange(num, __ENCList.Count - num);
						__ENCList.Capacity = __ENCList.Count;
					}
					__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BDataTable()
		{
			__ENCAddToList(this);
			TableName = "DataTable_FOURNISSEURS_ETAT_HISTORIQUE_B";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		internal DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void AddDataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRow(DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRow row)
		{
			Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRow AddDataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRow(string DATES_REGLEMENT, string MONTANT, string NOTES)
		{
			DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRow dataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRow = (DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRow)NewRow();
			object[] itemArray = new object[3] { DATES_REGLEMENT, MONTANT, NOTES };
			dataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRow.ItemArray = itemArray;
			Rows.Add(dataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRow);
			return dataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRow;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BDataTable dataTable_FOURNISSEURS_ETAT_HISTORIQUE_BDataTable = (DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BDataTable)base.Clone();
			dataTable_FOURNISSEURS_ETAT_HISTORIQUE_BDataTable.InitVars();
			return dataTable_FOURNISSEURS_ETAT_HISTORIQUE_BDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnDATES_REGLEMENT = Columns["DATES_REGLEMENT"];
			columnMONTANT = Columns["MONTANT"];
			columnNOTES = Columns["NOTES"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnDATES_REGLEMENT = new DataColumn("DATES_REGLEMENT", typeof(string), null, MappingType.Element);
			Columns.Add(columnDATES_REGLEMENT);
			columnMONTANT = new DataColumn("MONTANT", typeof(string), null, MappingType.Element);
			Columns.Add(columnMONTANT);
			columnNOTES = new DataColumn("NOTES", typeof(string), null, MappingType.Element);
			Columns.Add(columnNOTES);
			columnDATES_REGLEMENT.Caption = "DATES";
			columnMONTANT.Caption = "TOTAL_NET";
			columnNOTES.Caption = "OPERATION";
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRow NewDataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRow()
		{
			return (DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRow);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRowChanged != null)
			{
				DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRowChanged?.Invoke(this, new DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRowChangeEvent((DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRowChanging != null)
			{
				DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRowChanging?.Invoke(this, new DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRowChangeEvent((DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRowDeleted != null)
			{
				DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRowDeleted?.Invoke(this, new DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRowChangeEvent((DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRowDeleting != null)
			{
				DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRowDeleting?.Invoke(this, new DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRowChangeEvent((DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void RemoveDataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRow(DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRow row)
		{
			Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Report_0_DATASET report_0_DATASET = new Report_0_DATASET();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal minOccurs = 0m;
			xmlSchemaAny.MinOccurs = minOccurs;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			minOccurs = 1m;
			xmlSchemaAny2.MinOccurs = minOccurs;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = report_0_DATASET.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = report_0_DATASET.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	public class DataTable_BRRow : DataRow
	{
		private DataTable_BRDataTable tableDataTable_BR;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string CODE
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_BR.CODEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Code' dans la table 'DataTable_BR' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_BR.CODEColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string Article
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_BR.ArticleColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Article' dans la table 'DataTable_BR' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_BR.ArticleColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string Qté
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_BR.QtéColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Qté' dans la table 'DataTable_BR' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_BR.QtéColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string PRIX_A
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_BR.PRIX_AColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Prix_A' dans la table 'DataTable_BR' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_BR.PRIX_AColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string PRIX_V
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_BR.PRIX_VColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Prix_V' dans la table 'DataTable_BR' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_BR.PRIX_VColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string TOTAL_NET_ACHATS
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_BR.TOTAL_NET_ACHATSColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'TOTAL_NET_ACHATS' dans la table 'DataTable_BR' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_BR.TOTAL_NET_ACHATSColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		internal DataTable_BRRow(DataRowBuilder rb)
			: base(rb)
		{
			tableDataTable_BR = (DataTable_BRDataTable)Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsCODENull()
		{
			return IsNull(tableDataTable_BR.CODEColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetCODENull()
		{
			this[tableDataTable_BR.CODEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsArticleNull()
		{
			return IsNull(tableDataTable_BR.ArticleColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetArticleNull()
		{
			this[tableDataTable_BR.ArticleColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsQtéNull()
		{
			return IsNull(tableDataTable_BR.QtéColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetQtéNull()
		{
			this[tableDataTable_BR.QtéColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsPRIX_ANull()
		{
			return IsNull(tableDataTable_BR.PRIX_AColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetPRIX_ANull()
		{
			this[tableDataTable_BR.PRIX_AColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsPRIX_VNull()
		{
			return IsNull(tableDataTable_BR.PRIX_VColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetPRIX_VNull()
		{
			this[tableDataTable_BR.PRIX_VColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTOTAL_NET_ACHATSNull()
		{
			return IsNull(tableDataTable_BR.TOTAL_NET_ACHATSColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetTOTAL_NET_ACHATSNull()
		{
			this[tableDataTable_BR.TOTAL_NET_ACHATSColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class DataTable_BSRow : DataRow
	{
		private DataTable_BSDataTable tableDataTable_BS;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string Code
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_BS.CodeColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Code' dans la table 'DataTable_BS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_BS.CodeColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string Article
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_BS.ArticleColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Article' dans la table 'DataTable_BS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_BS.ArticleColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string Qté
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_BS.QtéColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Qté' dans la table 'DataTable_BS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_BS.QtéColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string TOTAL_NET_ACHATS
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_BS.TOTAL_NET_ACHATSColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'TOTAL_NET_ACHATS' dans la table 'DataTable_BS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_BS.TOTAL_NET_ACHATSColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string TOTAL_NET_VENTES
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_BS.TOTAL_NET_VENTESColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'TOTAL_NET_VENTES' dans la table 'DataTable_BS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_BS.TOTAL_NET_VENTESColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal DataTable_BSRow(DataRowBuilder rb)
			: base(rb)
		{
			tableDataTable_BS = (DataTable_BSDataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsCodeNull()
		{
			return IsNull(tableDataTable_BS.CodeColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetCodeNull()
		{
			this[tableDataTable_BS.CodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsArticleNull()
		{
			return IsNull(tableDataTable_BS.ArticleColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetArticleNull()
		{
			this[tableDataTable_BS.ArticleColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsQtéNull()
		{
			return IsNull(tableDataTable_BS.QtéColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetQtéNull()
		{
			this[tableDataTable_BS.QtéColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTOTAL_NET_ACHATSNull()
		{
			return IsNull(tableDataTable_BS.TOTAL_NET_ACHATSColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetTOTAL_NET_ACHATSNull()
		{
			this[tableDataTable_BS.TOTAL_NET_ACHATSColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTOTAL_NET_VENTESNull()
		{
			return IsNull(tableDataTable_BS.TOTAL_NET_VENTESColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetTOTAL_NET_VENTESNull()
		{
			this[tableDataTable_BS.TOTAL_NET_VENTESColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class DataTable_INVRow : DataRow
	{
		private DataTable_INVDataTable tableDataTable_INV;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string Code
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_INV.CodeColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Code' dans la table 'DataTable_INV' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_INV.CodeColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string Article
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_INV.ArticleColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Article' dans la table 'DataTable_INV' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_INV.ArticleColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string Stock_Logique
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_INV.Stock_LogiqueColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Stock_Logique' dans la table 'DataTable_INV' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_INV.Stock_LogiqueColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string Stock_Physique
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_INV.Stock_PhysiqueColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Stock_Physique' dans la table 'DataTable_INV' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_INV.Stock_PhysiqueColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string Ecart
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_INV.EcartColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Ecart' dans la table 'DataTable_INV' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_INV.EcartColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string Valeur
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_INV.ValeurColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Valeur' dans la table 'DataTable_INV' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_INV.ValeurColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		internal DataTable_INVRow(DataRowBuilder rb)
			: base(rb)
		{
			tableDataTable_INV = (DataTable_INVDataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsCodeNull()
		{
			return IsNull(tableDataTable_INV.CodeColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetCodeNull()
		{
			this[tableDataTable_INV.CodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsArticleNull()
		{
			return IsNull(tableDataTable_INV.ArticleColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetArticleNull()
		{
			this[tableDataTable_INV.ArticleColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsStock_LogiqueNull()
		{
			return IsNull(tableDataTable_INV.Stock_LogiqueColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetStock_LogiqueNull()
		{
			this[tableDataTable_INV.Stock_LogiqueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsStock_PhysiqueNull()
		{
			return IsNull(tableDataTable_INV.Stock_PhysiqueColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetStock_PhysiqueNull()
		{
			this[tableDataTable_INV.Stock_PhysiqueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsEcartNull()
		{
			return IsNull(tableDataTable_INV.EcartColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetEcartNull()
		{
			this[tableDataTable_INV.EcartColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsValeurNull()
		{
			return IsNull(tableDataTable_INV.ValeurColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetValeurNull()
		{
			this[tableDataTable_INV.ValeurColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class DataTable_DEVISRow : DataRow
	{
		private DataTable_DEVISDataTable tableDataTable_DEVIS;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string Code
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_DEVIS.CodeColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Code' dans la table 'DataTable_DEVIS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_DEVIS.CodeColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string Article
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_DEVIS.ArticleColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Article' dans la table 'DataTable_DEVIS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_DEVIS.ArticleColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string PU_TTC
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_DEVIS.PU_TTCColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'PU_TTC' dans la table 'DataTable_DEVIS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_DEVIS.PU_TTCColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string TAUX_TVA
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_DEVIS.TAUX_TVAColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'TAUX_TVA' dans la table 'DataTable_DEVIS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_DEVIS.TAUX_TVAColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string PU_HT
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_DEVIS.PU_HTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'PU_HT' dans la table 'DataTable_DEVIS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_DEVIS.PU_HTColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string Qté
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_DEVIS.QtéColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Qté' dans la table 'DataTable_DEVIS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_DEVIS.QtéColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string TOTAL_TTC
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_DEVIS.TOTAL_TTCColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'TOTAL_TTC' dans la table 'DataTable_DEVIS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_DEVIS.TOTAL_TTCColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string TOTAL_TVA
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_DEVIS.TOTAL_TVAColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'TOTAL_TVA' dans la table 'DataTable_DEVIS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_DEVIS.TOTAL_TVAColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string TOTAL_HT
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_DEVIS.TOTAL_HTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'TOTAL_HT' dans la table 'DataTable_DEVIS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_DEVIS.TOTAL_HTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string TOTAL_REMISE
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_DEVIS.TOTAL_REMISEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'TOTAL_REMISE' dans la table 'DataTable_DEVIS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_DEVIS.TOTAL_REMISEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal DataTable_DEVISRow(DataRowBuilder rb)
			: base(rb)
		{
			tableDataTable_DEVIS = (DataTable_DEVISDataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsCodeNull()
		{
			return IsNull(tableDataTable_DEVIS.CodeColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetCodeNull()
		{
			this[tableDataTable_DEVIS.CodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsArticleNull()
		{
			return IsNull(tableDataTable_DEVIS.ArticleColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetArticleNull()
		{
			this[tableDataTable_DEVIS.ArticleColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsPU_TTCNull()
		{
			return IsNull(tableDataTable_DEVIS.PU_TTCColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetPU_TTCNull()
		{
			this[tableDataTable_DEVIS.PU_TTCColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTAUX_TVANull()
		{
			return IsNull(tableDataTable_DEVIS.TAUX_TVAColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetTAUX_TVANull()
		{
			this[tableDataTable_DEVIS.TAUX_TVAColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsPU_HTNull()
		{
			return IsNull(tableDataTable_DEVIS.PU_HTColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetPU_HTNull()
		{
			this[tableDataTable_DEVIS.PU_HTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsQtéNull()
		{
			return IsNull(tableDataTable_DEVIS.QtéColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetQtéNull()
		{
			this[tableDataTable_DEVIS.QtéColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTOTAL_TTCNull()
		{
			return IsNull(tableDataTable_DEVIS.TOTAL_TTCColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetTOTAL_TTCNull()
		{
			this[tableDataTable_DEVIS.TOTAL_TTCColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsTOTAL_TVANull()
		{
			return IsNull(tableDataTable_DEVIS.TOTAL_TVAColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetTOTAL_TVANull()
		{
			this[tableDataTable_DEVIS.TOTAL_TVAColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTOTAL_HTNull()
		{
			return IsNull(tableDataTable_DEVIS.TOTAL_HTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetTOTAL_HTNull()
		{
			this[tableDataTable_DEVIS.TOTAL_HTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsTOTAL_REMISENull()
		{
			return IsNull(tableDataTable_DEVIS.TOTAL_REMISEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetTOTAL_REMISENull()
		{
			this[tableDataTable_DEVIS.TOTAL_REMISEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class DataTable_BLRow : DataRow
	{
		private DataTable_BLDataTable tableDataTable_BL;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string Code
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_BL.CodeColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Code' dans la table 'DataTable_BL' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_BL.CodeColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string Article
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_BL.ArticleColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Article' dans la table 'DataTable_BL' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_BL.ArticleColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string PU_TTC
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_BL.PU_TTCColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'PU_TTC' dans la table 'DataTable_BL' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_BL.PU_TTCColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string TAUX_TVA
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_BL.TAUX_TVAColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'TAUX_TVA' dans la table 'DataTable_BL' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_BL.TAUX_TVAColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string PU_HT
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_BL.PU_HTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'PU_HT' dans la table 'DataTable_BL' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_BL.PU_HTColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string Qté
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_BL.QtéColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Qté' dans la table 'DataTable_BL' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_BL.QtéColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string TOTAL_TTC
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_BL.TOTAL_TTCColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'TOTAL_TTC' dans la table 'DataTable_BL' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_BL.TOTAL_TTCColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string TOTAL_TVA
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_BL.TOTAL_TVAColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'TOTAL_TVA' dans la table 'DataTable_BL' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_BL.TOTAL_TVAColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string TOTAL_HT
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_BL.TOTAL_HTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'TOTAL_HT' dans la table 'DataTable_BL' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_BL.TOTAL_HTColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string TOTAL_REMISE
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_BL.TOTAL_REMISEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'TOTAL_REMISE' dans la table 'DataTable_BL' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_BL.TOTAL_REMISEColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		internal DataTable_BLRow(DataRowBuilder rb)
			: base(rb)
		{
			tableDataTable_BL = (DataTable_BLDataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsCodeNull()
		{
			return IsNull(tableDataTable_BL.CodeColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetCodeNull()
		{
			this[tableDataTable_BL.CodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsArticleNull()
		{
			return IsNull(tableDataTable_BL.ArticleColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetArticleNull()
		{
			this[tableDataTable_BL.ArticleColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsPU_TTCNull()
		{
			return IsNull(tableDataTable_BL.PU_TTCColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetPU_TTCNull()
		{
			this[tableDataTable_BL.PU_TTCColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTAUX_TVANull()
		{
			return IsNull(tableDataTable_BL.TAUX_TVAColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetTAUX_TVANull()
		{
			this[tableDataTable_BL.TAUX_TVAColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsPU_HTNull()
		{
			return IsNull(tableDataTable_BL.PU_HTColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetPU_HTNull()
		{
			this[tableDataTable_BL.PU_HTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsQtéNull()
		{
			return IsNull(tableDataTable_BL.QtéColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetQtéNull()
		{
			this[tableDataTable_BL.QtéColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTOTAL_TTCNull()
		{
			return IsNull(tableDataTable_BL.TOTAL_TTCColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetTOTAL_TTCNull()
		{
			this[tableDataTable_BL.TOTAL_TTCColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTOTAL_TVANull()
		{
			return IsNull(tableDataTable_BL.TOTAL_TVAColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetTOTAL_TVANull()
		{
			this[tableDataTable_BL.TOTAL_TVAColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTOTAL_HTNull()
		{
			return IsNull(tableDataTable_BL.TOTAL_HTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetTOTAL_HTNull()
		{
			this[tableDataTable_BL.TOTAL_HTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTOTAL_REMISENull()
		{
			return IsNull(tableDataTable_BL.TOTAL_REMISEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetTOTAL_REMISENull()
		{
			this[tableDataTable_BL.TOTAL_REMISEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class DataTable_FACTURERow : DataRow
	{
		private DataTable_FACTUREDataTable tableDataTable_FACTURE;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string Code
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_FACTURE.CodeColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Code' dans la table 'DataTable_FACTURE' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_FACTURE.CodeColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string Article
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_FACTURE.ArticleColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Article' dans la table 'DataTable_FACTURE' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_FACTURE.ArticleColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string PU_TTC
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_FACTURE.PU_TTCColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'PU_TTC' dans la table 'DataTable_FACTURE' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_FACTURE.PU_TTCColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string TAUX_TVA
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_FACTURE.TAUX_TVAColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'TAUX_TVA' dans la table 'DataTable_FACTURE' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_FACTURE.TAUX_TVAColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string PU_HT
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_FACTURE.PU_HTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'PU_HT' dans la table 'DataTable_FACTURE' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_FACTURE.PU_HTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string Qté
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_FACTURE.QtéColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Qté' dans la table 'DataTable_FACTURE' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_FACTURE.QtéColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string TOTAL_TTC
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_FACTURE.TOTAL_TTCColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'TOTAL_TTC' dans la table 'DataTable_FACTURE' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_FACTURE.TOTAL_TTCColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string TOTAL_TVA
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_FACTURE.TOTAL_TVAColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'TOTAL_TVA' dans la table 'DataTable_FACTURE' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_FACTURE.TOTAL_TVAColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string TOTAL_HT
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_FACTURE.TOTAL_HTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'TOTAL_HT' dans la table 'DataTable_FACTURE' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_FACTURE.TOTAL_HTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string TOTAL_REMISE
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_FACTURE.TOTAL_REMISEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'TOTAL_REMISE' dans la table 'DataTable_FACTURE' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_FACTURE.TOTAL_REMISEColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		internal DataTable_FACTURERow(DataRowBuilder rb)
			: base(rb)
		{
			tableDataTable_FACTURE = (DataTable_FACTUREDataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsCodeNull()
		{
			return IsNull(tableDataTable_FACTURE.CodeColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetCodeNull()
		{
			this[tableDataTable_FACTURE.CodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsArticleNull()
		{
			return IsNull(tableDataTable_FACTURE.ArticleColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetArticleNull()
		{
			this[tableDataTable_FACTURE.ArticleColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsPU_TTCNull()
		{
			return IsNull(tableDataTable_FACTURE.PU_TTCColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetPU_TTCNull()
		{
			this[tableDataTable_FACTURE.PU_TTCColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTAUX_TVANull()
		{
			return IsNull(tableDataTable_FACTURE.TAUX_TVAColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetTAUX_TVANull()
		{
			this[tableDataTable_FACTURE.TAUX_TVAColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsPU_HTNull()
		{
			return IsNull(tableDataTable_FACTURE.PU_HTColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetPU_HTNull()
		{
			this[tableDataTable_FACTURE.PU_HTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsQtéNull()
		{
			return IsNull(tableDataTable_FACTURE.QtéColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetQtéNull()
		{
			this[tableDataTable_FACTURE.QtéColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTOTAL_TTCNull()
		{
			return IsNull(tableDataTable_FACTURE.TOTAL_TTCColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetTOTAL_TTCNull()
		{
			this[tableDataTable_FACTURE.TOTAL_TTCColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTOTAL_TVANull()
		{
			return IsNull(tableDataTable_FACTURE.TOTAL_TVAColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetTOTAL_TVANull()
		{
			this[tableDataTable_FACTURE.TOTAL_TVAColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTOTAL_HTNull()
		{
			return IsNull(tableDataTable_FACTURE.TOTAL_HTColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetTOTAL_HTNull()
		{
			this[tableDataTable_FACTURE.TOTAL_HTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsTOTAL_REMISENull()
		{
			return IsNull(tableDataTable_FACTURE.TOTAL_REMISEColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetTOTAL_REMISENull()
		{
			this[tableDataTable_FACTURE.TOTAL_REMISEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class DataTable_ETAT_STOCKRow : DataRow
	{
		private DataTable_ETAT_STOCKDataTable tableDataTable_ETAT_STOCK;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string ID_ARTICLE
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_ETAT_STOCK.ID_ARTICLEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'ID_ARTICLE' dans la table 'DataTable_ETAT_STOCK' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_ETAT_STOCK.ID_ARTICLEColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string Code
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_ETAT_STOCK.CodeColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Code' dans la table 'DataTable_ETAT_STOCK' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_ETAT_STOCK.CodeColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string Article
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_ETAT_STOCK.ArticleColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Article' dans la table 'DataTable_ETAT_STOCK' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_ETAT_STOCK.ArticleColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string Famille
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_ETAT_STOCK.FamilleColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Famille' dans la table 'DataTable_ETAT_STOCK' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_ETAT_STOCK.FamilleColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string Date_Inventaire
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_ETAT_STOCK.Date_InventaireColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Date_Inventaire' dans la table 'DataTable_ETAT_STOCK' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_ETAT_STOCK.Date_InventaireColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string Stock_Initial
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_ETAT_STOCK.Stock_InitialColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Stock_Initial' dans la table 'DataTable_ETAT_STOCK' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_ETAT_STOCK.Stock_InitialColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string Stock_Recept
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_ETAT_STOCK.Stock_ReceptColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Stock_Recept' dans la table 'DataTable_ETAT_STOCK' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_ETAT_STOCK.Stock_ReceptColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string Stock_Sortie
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_ETAT_STOCK.Stock_SortieColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Stock_Sortie' dans la table 'DataTable_ETAT_STOCK' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_ETAT_STOCK.Stock_SortieColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string Stock_Vendu
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_ETAT_STOCK.Stock_VenduColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Stock_Vendu' dans la table 'DataTable_ETAT_STOCK' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_ETAT_STOCK.Stock_VenduColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string Stock_Prevu
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_ETAT_STOCK.Stock_PrevuColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Stock_Prevu' dans la table 'DataTable_ETAT_STOCK' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_ETAT_STOCK.Stock_PrevuColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string Stock_Actuel
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_ETAT_STOCK.Stock_ActuelColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Stock_Actuel' dans la table 'DataTable_ETAT_STOCK' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_ETAT_STOCK.Stock_ActuelColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string Unite
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_ETAT_STOCK.UniteColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Unite' dans la table 'DataTable_ETAT_STOCK' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_ETAT_STOCK.UniteColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string Alert
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_ETAT_STOCK.AlertColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Alert' dans la table 'DataTable_ETAT_STOCK' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_ETAT_STOCK.AlertColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal DataTable_ETAT_STOCKRow(DataRowBuilder rb)
			: base(rb)
		{
			tableDataTable_ETAT_STOCK = (DataTable_ETAT_STOCKDataTable)Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsID_ARTICLENull()
		{
			return IsNull(tableDataTable_ETAT_STOCK.ID_ARTICLEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetID_ARTICLENull()
		{
			this[tableDataTable_ETAT_STOCK.ID_ARTICLEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsCodeNull()
		{
			return IsNull(tableDataTable_ETAT_STOCK.CodeColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetCodeNull()
		{
			this[tableDataTable_ETAT_STOCK.CodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsArticleNull()
		{
			return IsNull(tableDataTable_ETAT_STOCK.ArticleColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetArticleNull()
		{
			this[tableDataTable_ETAT_STOCK.ArticleColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsFamilleNull()
		{
			return IsNull(tableDataTable_ETAT_STOCK.FamilleColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetFamilleNull()
		{
			this[tableDataTable_ETAT_STOCK.FamilleColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsDate_InventaireNull()
		{
			return IsNull(tableDataTable_ETAT_STOCK.Date_InventaireColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDate_InventaireNull()
		{
			this[tableDataTable_ETAT_STOCK.Date_InventaireColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsStock_InitialNull()
		{
			return IsNull(tableDataTable_ETAT_STOCK.Stock_InitialColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetStock_InitialNull()
		{
			this[tableDataTable_ETAT_STOCK.Stock_InitialColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsStock_ReceptNull()
		{
			return IsNull(tableDataTable_ETAT_STOCK.Stock_ReceptColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetStock_ReceptNull()
		{
			this[tableDataTable_ETAT_STOCK.Stock_ReceptColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsStock_SortieNull()
		{
			return IsNull(tableDataTable_ETAT_STOCK.Stock_SortieColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetStock_SortieNull()
		{
			this[tableDataTable_ETAT_STOCK.Stock_SortieColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsStock_VenduNull()
		{
			return IsNull(tableDataTable_ETAT_STOCK.Stock_VenduColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetStock_VenduNull()
		{
			this[tableDataTable_ETAT_STOCK.Stock_VenduColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsStock_PrevuNull()
		{
			return IsNull(tableDataTable_ETAT_STOCK.Stock_PrevuColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetStock_PrevuNull()
		{
			this[tableDataTable_ETAT_STOCK.Stock_PrevuColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsStock_ActuelNull()
		{
			return IsNull(tableDataTable_ETAT_STOCK.Stock_ActuelColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetStock_ActuelNull()
		{
			this[tableDataTable_ETAT_STOCK.Stock_ActuelColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsUniteNull()
		{
			return IsNull(tableDataTable_ETAT_STOCK.UniteColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetUniteNull()
		{
			this[tableDataTable_ETAT_STOCK.UniteColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsAlertNull()
		{
			return IsNull(tableDataTable_ETAT_STOCK.AlertColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetAlertNull()
		{
			this[tableDataTable_ETAT_STOCK.AlertColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class DataTable_TICKET_A4Row : DataRow
	{
		private DataTable_TICKET_A4DataTable tableDataTable_TICKET_A4;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string Code
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_TICKET_A4.CodeColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Code' dans la table 'DataTable_TICKET_A4' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_TICKET_A4.CodeColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string Article
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_TICKET_A4.ArticleColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Article' dans la table 'DataTable_TICKET_A4' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_TICKET_A4.ArticleColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string Qté
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_TICKET_A4.QtéColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Qté' dans la table 'DataTable_TICKET_A4' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_TICKET_A4.QtéColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string Prix_V
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_TICKET_A4.Prix_VColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Prix_V' dans la table 'DataTable_TICKET_A4' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_TICKET_A4.Prix_VColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string TOTAL_NET
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_TICKET_A4.TOTAL_NETColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'TOTAL_NET' dans la table 'DataTable_TICKET_A4' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_TICKET_A4.TOTAL_NETColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal DataTable_TICKET_A4Row(DataRowBuilder rb)
			: base(rb)
		{
			tableDataTable_TICKET_A4 = (DataTable_TICKET_A4DataTable)Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsCodeNull()
		{
			return IsNull(tableDataTable_TICKET_A4.CodeColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetCodeNull()
		{
			this[tableDataTable_TICKET_A4.CodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsArticleNull()
		{
			return IsNull(tableDataTable_TICKET_A4.ArticleColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetArticleNull()
		{
			this[tableDataTable_TICKET_A4.ArticleColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsQtéNull()
		{
			return IsNull(tableDataTable_TICKET_A4.QtéColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetQtéNull()
		{
			this[tableDataTable_TICKET_A4.QtéColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsPrix_VNull()
		{
			return IsNull(tableDataTable_TICKET_A4.Prix_VColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetPrix_VNull()
		{
			this[tableDataTable_TICKET_A4.Prix_VColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsTOTAL_NETNull()
		{
			return IsNull(tableDataTable_TICKET_A4.TOTAL_NETColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetTOTAL_NETNull()
		{
			this[tableDataTable_TICKET_A4.TOTAL_NETColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class DataTable_NOMENCLATURERow : DataRow
	{
		private DataTable_NOMENCLATUREDataTable tableDataTable_NOMENCLATURE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string CODE_ARTICLE
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_NOMENCLATURE.CODE_ARTICLEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'CODE_ARTICLE' dans la table 'DataTable_NOMENCLATURE' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_NOMENCLATURE.CODE_ARTICLEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string ARTICLE
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_NOMENCLATURE.ARTICLEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'ARTICLE' dans la table 'DataTable_NOMENCLATURE' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_NOMENCLATURE.ARTICLEColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string CODE_MP
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_NOMENCLATURE.CODE_MPColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'CODE_MP' dans la table 'DataTable_NOMENCLATURE' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_NOMENCLATURE.CODE_MPColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string MP
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_NOMENCLATURE.MPColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'MP' dans la table 'DataTable_NOMENCLATURE' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_NOMENCLATURE.MPColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public decimal QTE
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tableDataTable_NOMENCLATURE.QTEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'QTE' dans la table 'DataTable_NOMENCLATURE' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_NOMENCLATURE.QTEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string UNITE
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_NOMENCLATURE.UNITEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'UNITE' dans la table 'DataTable_NOMENCLATURE' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_NOMENCLATURE.UNITEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public decimal PRIX_A
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tableDataTable_NOMENCLATURE.PRIX_AColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'PRIX_A' dans la table 'DataTable_NOMENCLATURE' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_NOMENCLATURE.PRIX_AColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal DataTable_NOMENCLATURERow(DataRowBuilder rb)
			: base(rb)
		{
			tableDataTable_NOMENCLATURE = (DataTable_NOMENCLATUREDataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsCODE_ARTICLENull()
		{
			return IsNull(tableDataTable_NOMENCLATURE.CODE_ARTICLEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetCODE_ARTICLENull()
		{
			this[tableDataTable_NOMENCLATURE.CODE_ARTICLEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsARTICLENull()
		{
			return IsNull(tableDataTable_NOMENCLATURE.ARTICLEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetARTICLENull()
		{
			this[tableDataTable_NOMENCLATURE.ARTICLEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsCODE_MPNull()
		{
			return IsNull(tableDataTable_NOMENCLATURE.CODE_MPColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetCODE_MPNull()
		{
			this[tableDataTable_NOMENCLATURE.CODE_MPColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsMPNull()
		{
			return IsNull(tableDataTable_NOMENCLATURE.MPColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetMPNull()
		{
			this[tableDataTable_NOMENCLATURE.MPColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsQTENull()
		{
			return IsNull(tableDataTable_NOMENCLATURE.QTEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetQTENull()
		{
			this[tableDataTable_NOMENCLATURE.QTEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsUNITENull()
		{
			return IsNull(tableDataTable_NOMENCLATURE.UNITEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetUNITENull()
		{
			this[tableDataTable_NOMENCLATURE.UNITEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsPRIX_ANull()
		{
			return IsNull(tableDataTable_NOMENCLATURE.PRIX_AColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetPRIX_ANull()
		{
			this[tableDataTable_NOMENCLATURE.PRIX_AColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class DataTable_CLIENTS_ETAT_CREDITSRow : DataRow
	{
		private DataTable_CLIENTS_ETAT_CREDITSDataTable tableDataTable_CLIENTS_ETAT_CREDITS;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string ID_CLIENT
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_CLIENTS_ETAT_CREDITS.ID_CLIENTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'ID_CLIENT' dans la table 'DataTable_CLIENTS_ETAT_CREDITS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_CLIENTS_ETAT_CREDITS.ID_CLIENTColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string CLIENT
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_CLIENTS_ETAT_CREDITS.CLIENTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'CLIENT' dans la table 'DataTable_CLIENTS_ETAT_CREDITS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_CLIENTS_ETAT_CREDITS.CLIENTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string CREDIT_INITIAL
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_CLIENTS_ETAT_CREDITS.CREDIT_INITIALColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'CREDIT_INITIAL' dans la table 'DataTable_CLIENTS_ETAT_CREDITS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_CLIENTS_ETAT_CREDITS.CREDIT_INITIALColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string TOTAL_CREDIT
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_CLIENTS_ETAT_CREDITS.TOTAL_CREDITColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'TOTAL_CREDIT' dans la table 'DataTable_CLIENTS_ETAT_CREDITS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_CLIENTS_ETAT_CREDITS.TOTAL_CREDITColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string TOTAL_RETOUR
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_CLIENTS_ETAT_CREDITS.TOTAL_RETOURColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'TOTAL_RETOUR' dans la table 'DataTable_CLIENTS_ETAT_CREDITS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_CLIENTS_ETAT_CREDITS.TOTAL_RETOURColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string TOTAL_REGLE
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_CLIENTS_ETAT_CREDITS.TOTAL_REGLEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'TOTAL_REGLE' dans la table 'DataTable_CLIENTS_ETAT_CREDITS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_CLIENTS_ETAT_CREDITS.TOTAL_REGLEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string RELIQUAT
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_CLIENTS_ETAT_CREDITS.RELIQUATColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'RELIQUAT' dans la table 'DataTable_CLIENTS_ETAT_CREDITS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_CLIENTS_ETAT_CREDITS.RELIQUATColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		internal DataTable_CLIENTS_ETAT_CREDITSRow(DataRowBuilder rb)
			: base(rb)
		{
			tableDataTable_CLIENTS_ETAT_CREDITS = (DataTable_CLIENTS_ETAT_CREDITSDataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsID_CLIENTNull()
		{
			return IsNull(tableDataTable_CLIENTS_ETAT_CREDITS.ID_CLIENTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetID_CLIENTNull()
		{
			this[tableDataTable_CLIENTS_ETAT_CREDITS.ID_CLIENTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsCLIENTNull()
		{
			return IsNull(tableDataTable_CLIENTS_ETAT_CREDITS.CLIENTColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetCLIENTNull()
		{
			this[tableDataTable_CLIENTS_ETAT_CREDITS.CLIENTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsCREDIT_INITIALNull()
		{
			return IsNull(tableDataTable_CLIENTS_ETAT_CREDITS.CREDIT_INITIALColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetCREDIT_INITIALNull()
		{
			this[tableDataTable_CLIENTS_ETAT_CREDITS.CREDIT_INITIALColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsTOTAL_CREDITNull()
		{
			return IsNull(tableDataTable_CLIENTS_ETAT_CREDITS.TOTAL_CREDITColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetTOTAL_CREDITNull()
		{
			this[tableDataTable_CLIENTS_ETAT_CREDITS.TOTAL_CREDITColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsTOTAL_RETOURNull()
		{
			return IsNull(tableDataTable_CLIENTS_ETAT_CREDITS.TOTAL_RETOURColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetTOTAL_RETOURNull()
		{
			this[tableDataTable_CLIENTS_ETAT_CREDITS.TOTAL_RETOURColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsTOTAL_REGLENull()
		{
			return IsNull(tableDataTable_CLIENTS_ETAT_CREDITS.TOTAL_REGLEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetTOTAL_REGLENull()
		{
			this[tableDataTable_CLIENTS_ETAT_CREDITS.TOTAL_REGLEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsRELIQUATNull()
		{
			return IsNull(tableDataTable_CLIENTS_ETAT_CREDITS.RELIQUATColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetRELIQUATNull()
		{
			this[tableDataTable_CLIENTS_ETAT_CREDITS.RELIQUATColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class DataTable_CLIENTS_ETAT_HISTORIQUE_ARow : DataRow
	{
		private DataTable_CLIENTS_ETAT_HISTORIQUE_ADataTable tableDataTable_CLIENTS_ETAT_HISTORIQUE_A;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string DATES_CREDIT
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_A.DATES_CREDITColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'DATES_CREDIT' dans la table 'DataTable_CLIENTS_ETAT_HISTORIQUE_A' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_A.DATES_CREDITColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string TOTAL_NET
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_A.TOTAL_NETColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'TOTAL_NET' dans la table 'DataTable_CLIENTS_ETAT_HISTORIQUE_A' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_A.TOTAL_NETColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string OPERATION
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_A.OPERATIONColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'OPERATION' dans la table 'DataTable_CLIENTS_ETAT_HISTORIQUE_A' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_A.OPERATIONColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal DataTable_CLIENTS_ETAT_HISTORIQUE_ARow(DataRowBuilder rb)
			: base(rb)
		{
			tableDataTable_CLIENTS_ETAT_HISTORIQUE_A = (DataTable_CLIENTS_ETAT_HISTORIQUE_ADataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDATES_CREDITNull()
		{
			return IsNull(tableDataTable_CLIENTS_ETAT_HISTORIQUE_A.DATES_CREDITColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetDATES_CREDITNull()
		{
			this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_A.DATES_CREDITColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTOTAL_NETNull()
		{
			return IsNull(tableDataTable_CLIENTS_ETAT_HISTORIQUE_A.TOTAL_NETColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetTOTAL_NETNull()
		{
			this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_A.TOTAL_NETColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsOPERATIONNull()
		{
			return IsNull(tableDataTable_CLIENTS_ETAT_HISTORIQUE_A.OPERATIONColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetOPERATIONNull()
		{
			this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_A.OPERATIONColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class DataTable_CLIENTS_ETAT_HISTORIQUE_BRow : DataRow
	{
		private DataTable_CLIENTS_ETAT_HISTORIQUE_BDataTable tableDataTable_CLIENTS_ETAT_HISTORIQUE_B;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string DATES_REGLEMENT
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_B.DATES_REGLEMENTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'DATES_REGLEMENT' dans la table 'DataTable_CLIENTS_ETAT_HISTORIQUE_B' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_B.DATES_REGLEMENTColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string MONTANT
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_B.MONTANTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'MONTANT' dans la table 'DataTable_CLIENTS_ETAT_HISTORIQUE_B' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_B.MONTANTColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string NOTES
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_B.NOTESColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'NOTES' dans la table 'DataTable_CLIENTS_ETAT_HISTORIQUE_B' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_B.NOTESColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		internal DataTable_CLIENTS_ETAT_HISTORIQUE_BRow(DataRowBuilder rb)
			: base(rb)
		{
			tableDataTable_CLIENTS_ETAT_HISTORIQUE_B = (DataTable_CLIENTS_ETAT_HISTORIQUE_BDataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDATES_REGLEMENTNull()
		{
			return IsNull(tableDataTable_CLIENTS_ETAT_HISTORIQUE_B.DATES_REGLEMENTColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDATES_REGLEMENTNull()
		{
			this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_B.DATES_REGLEMENTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsMONTANTNull()
		{
			return IsNull(tableDataTable_CLIENTS_ETAT_HISTORIQUE_B.MONTANTColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetMONTANTNull()
		{
			this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_B.MONTANTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNOTESNull()
		{
			return IsNull(tableDataTable_CLIENTS_ETAT_HISTORIQUE_B.NOTESColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNOTESNull()
		{
			this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_B.NOTESColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRow : DataRow
	{
		private DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSDataTable tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string TICKET
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.TICKETColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'TICKET' dans la table 'DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.TICKETColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string DATES
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.DATESColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'DATES' dans la table 'DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.DATESColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string HEURE
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.HEUREColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'HEURE' dans la table 'DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.HEUREColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string ARTICLE
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.ARTICLEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'ARTICLE' dans la table 'DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.ARTICLEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string PRIX_V
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.PRIX_VColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'PRIX_V' dans la table 'DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.PRIX_VColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string Qté
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.QtéColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Qté' dans la table 'DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.QtéColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string REMISE
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.REMISEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'REMISE' dans la table 'DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.REMISEColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string TOTAL_NET
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.TOTAL_NETColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'TOTAL_NET' dans la table 'DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.TOTAL_NETColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string CAISSIER
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.CAISSIERColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'CAISSIER' dans la table 'DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.CAISSIERColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string OPERATION
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.OPERATIONColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'OPERATION' dans la table 'DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.OPERATIONColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		internal DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRow(DataRowBuilder rb)
			: base(rb)
		{
			tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS = (DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSDataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTICKETNull()
		{
			return IsNull(tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.TICKETColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetTICKETNull()
		{
			this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.TICKETColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDATESNull()
		{
			return IsNull(tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.DATESColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetDATESNull()
		{
			this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.DATESColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsHEURENull()
		{
			return IsNull(tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.HEUREColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetHEURENull()
		{
			this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.HEUREColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsARTICLENull()
		{
			return IsNull(tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.ARTICLEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetARTICLENull()
		{
			this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.ARTICLEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsPRIX_VNull()
		{
			return IsNull(tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.PRIX_VColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetPRIX_VNull()
		{
			this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.PRIX_VColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsQtéNull()
		{
			return IsNull(tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.QtéColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetQtéNull()
		{
			this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.QtéColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsREMISENull()
		{
			return IsNull(tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.REMISEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetREMISENull()
		{
			this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.REMISEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTOTAL_NETNull()
		{
			return IsNull(tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.TOTAL_NETColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetTOTAL_NETNull()
		{
			this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.TOTAL_NETColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsCAISSIERNull()
		{
			return IsNull(tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.CAISSIERColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetCAISSIERNull()
		{
			this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.CAISSIERColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsOPERATIONNull()
		{
			return IsNull(tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.OPERATIONColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetOPERATIONNull()
		{
			this[tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.OPERATIONColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class DataTable_FOURNISSEURS_ETAT_CREDITSRow : DataRow
	{
		private DataTable_FOURNISSEURS_ETAT_CREDITSDataTable tableDataTable_FOURNISSEURS_ETAT_CREDITS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string ID_FOURNISSEUR
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_FOURNISSEURS_ETAT_CREDITS.ID_FOURNISSEURColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'ID_FOURNISSEUR' dans la table 'DataTable_FOURNISSEURS_ETAT_CREDITS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_FOURNISSEURS_ETAT_CREDITS.ID_FOURNISSEURColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string FOURNISSEUR
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_FOURNISSEURS_ETAT_CREDITS.FOURNISSEURColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'FOURNISSEUR' dans la table 'DataTable_FOURNISSEURS_ETAT_CREDITS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_FOURNISSEURS_ETAT_CREDITS.FOURNISSEURColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string CREDIT_INITIAL
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_FOURNISSEURS_ETAT_CREDITS.CREDIT_INITIALColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'CREDIT_INITIAL' dans la table 'DataTable_FOURNISSEURS_ETAT_CREDITS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_FOURNISSEURS_ETAT_CREDITS.CREDIT_INITIALColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string TOTAL_RECEPTIONS
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_FOURNISSEURS_ETAT_CREDITS.TOTAL_RECEPTIONSColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'TOTAL_RECEPTIONS' dans la table 'DataTable_FOURNISSEURS_ETAT_CREDITS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_FOURNISSEURS_ETAT_CREDITS.TOTAL_RECEPTIONSColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string TOTAL_SORTIES
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_FOURNISSEURS_ETAT_CREDITS.TOTAL_SORTIESColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'TOTAL_SORTIES' dans la table 'DataTable_FOURNISSEURS_ETAT_CREDITS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_FOURNISSEURS_ETAT_CREDITS.TOTAL_SORTIESColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string TOTAL_REGLE
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_FOURNISSEURS_ETAT_CREDITS.TOTAL_REGLEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'TOTAL_REGLE' dans la table 'DataTable_FOURNISSEURS_ETAT_CREDITS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_FOURNISSEURS_ETAT_CREDITS.TOTAL_REGLEColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string RELIQUAT
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_FOURNISSEURS_ETAT_CREDITS.RELIQUATColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'RELIQUAT' dans la table 'DataTable_FOURNISSEURS_ETAT_CREDITS' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_FOURNISSEURS_ETAT_CREDITS.RELIQUATColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		internal DataTable_FOURNISSEURS_ETAT_CREDITSRow(DataRowBuilder rb)
			: base(rb)
		{
			tableDataTable_FOURNISSEURS_ETAT_CREDITS = (DataTable_FOURNISSEURS_ETAT_CREDITSDataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsID_FOURNISSEURNull()
		{
			return IsNull(tableDataTable_FOURNISSEURS_ETAT_CREDITS.ID_FOURNISSEURColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetID_FOURNISSEURNull()
		{
			this[tableDataTable_FOURNISSEURS_ETAT_CREDITS.ID_FOURNISSEURColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsFOURNISSEURNull()
		{
			return IsNull(tableDataTable_FOURNISSEURS_ETAT_CREDITS.FOURNISSEURColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetFOURNISSEURNull()
		{
			this[tableDataTable_FOURNISSEURS_ETAT_CREDITS.FOURNISSEURColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsCREDIT_INITIALNull()
		{
			return IsNull(tableDataTable_FOURNISSEURS_ETAT_CREDITS.CREDIT_INITIALColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetCREDIT_INITIALNull()
		{
			this[tableDataTable_FOURNISSEURS_ETAT_CREDITS.CREDIT_INITIALColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsTOTAL_RECEPTIONSNull()
		{
			return IsNull(tableDataTable_FOURNISSEURS_ETAT_CREDITS.TOTAL_RECEPTIONSColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetTOTAL_RECEPTIONSNull()
		{
			this[tableDataTable_FOURNISSEURS_ETAT_CREDITS.TOTAL_RECEPTIONSColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsTOTAL_SORTIESNull()
		{
			return IsNull(tableDataTable_FOURNISSEURS_ETAT_CREDITS.TOTAL_SORTIESColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetTOTAL_SORTIESNull()
		{
			this[tableDataTable_FOURNISSEURS_ETAT_CREDITS.TOTAL_SORTIESColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsTOTAL_REGLENull()
		{
			return IsNull(tableDataTable_FOURNISSEURS_ETAT_CREDITS.TOTAL_REGLEColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetTOTAL_REGLENull()
		{
			this[tableDataTable_FOURNISSEURS_ETAT_CREDITS.TOTAL_REGLEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsRELIQUATNull()
		{
			return IsNull(tableDataTable_FOURNISSEURS_ETAT_CREDITS.RELIQUATColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetRELIQUATNull()
		{
			this[tableDataTable_FOURNISSEURS_ETAT_CREDITS.RELIQUATColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class DataTable_BCRow : DataRow
	{
		private DataTable_BCDataTable tableDataTable_BC;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string Code
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_BC.CodeColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Code' dans la table 'DataTable_BC' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_BC.CodeColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string Article
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_BC.ArticleColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Article' dans la table 'DataTable_BC' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_BC.ArticleColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string Qté
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_BC.QtéColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Qté' dans la table 'DataTable_BC' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_BC.QtéColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string Prix_A
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_BC.Prix_AColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Prix_A' dans la table 'DataTable_BC' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_BC.Prix_AColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string Prix_V
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_BC.Prix_VColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'Prix_V' dans la table 'DataTable_BC' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_BC.Prix_VColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string TOTAL_NET_ACHATS
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_BC.TOTAL_NET_ACHATSColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'TOTAL_NET_ACHATS' dans la table 'DataTable_BC' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_BC.TOTAL_NET_ACHATSColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		internal DataTable_BCRow(DataRowBuilder rb)
			: base(rb)
		{
			tableDataTable_BC = (DataTable_BCDataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsCodeNull()
		{
			return IsNull(tableDataTable_BC.CodeColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetCodeNull()
		{
			this[tableDataTable_BC.CodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsArticleNull()
		{
			return IsNull(tableDataTable_BC.ArticleColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetArticleNull()
		{
			this[tableDataTable_BC.ArticleColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsQtéNull()
		{
			return IsNull(tableDataTable_BC.QtéColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetQtéNull()
		{
			this[tableDataTable_BC.QtéColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsPrix_ANull()
		{
			return IsNull(tableDataTable_BC.Prix_AColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetPrix_ANull()
		{
			this[tableDataTable_BC.Prix_AColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsPrix_VNull()
		{
			return IsNull(tableDataTable_BC.Prix_VColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetPrix_VNull()
		{
			this[tableDataTable_BC.Prix_VColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsTOTAL_NET_ACHATSNull()
		{
			return IsNull(tableDataTable_BC.TOTAL_NET_ACHATSColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetTOTAL_NET_ACHATSNull()
		{
			this[tableDataTable_BC.TOTAL_NET_ACHATSColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARow : DataRow
	{
		private DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ADataTable tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_A;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string DATES_RECE_SORT
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_A.DATES_RECE_SORTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'DATES_RECE_SORT' dans la table 'DataTable_FOURNISSEURS_ETAT_HISTORIQUE_A' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_A.DATES_RECE_SORTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string TOTAL_NET_ACHATS
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_A.TOTAL_NET_ACHATSColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'TOTAL_NET_ACHATS' dans la table 'DataTable_FOURNISSEURS_ETAT_HISTORIQUE_A' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_A.TOTAL_NET_ACHATSColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string TYPE
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_A.TYPEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'TYPE' dans la table 'DataTable_FOURNISSEURS_ETAT_HISTORIQUE_A' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_A.TYPEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARow(DataRowBuilder rb)
			: base(rb)
		{
			tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_A = (DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ADataTable)Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsDATES_RECE_SORTNull()
		{
			return IsNull(tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_A.DATES_RECE_SORTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetDATES_RECE_SORTNull()
		{
			this[tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_A.DATES_RECE_SORTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTOTAL_NET_ACHATSNull()
		{
			return IsNull(tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_A.TOTAL_NET_ACHATSColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetTOTAL_NET_ACHATSNull()
		{
			this[tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_A.TOTAL_NET_ACHATSColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTYPENull()
		{
			return IsNull(tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_A.TYPEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetTYPENull()
		{
			this[tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_A.TYPEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRow : DataRow
	{
		private DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BDataTable tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_B;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public string DATES_REGLEMENT
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_B.DATES_REGLEMENTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'DATES_REGLEMENT' dans la table 'DataTable_FOURNISSEURS_ETAT_HISTORIQUE_B' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_B.DATES_REGLEMENTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string MONTANT
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_B.MONTANTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'MONTANT' dans la table 'DataTable_FOURNISSEURS_ETAT_HISTORIQUE_B' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_B.MONTANTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string NOTES
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_B.NOTESColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("La valeur pour la colonne 'NOTES' dans la table 'DataTable_FOURNISSEURS_ETAT_HISTORIQUE_B' est DBNull.", innerException);
				}
			}
			set
			{
				this[tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_B.NOTESColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		internal DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRow(DataRowBuilder rb)
			: base(rb)
		{
			tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_B = (DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BDataTable)Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsDATES_REGLEMENTNull()
		{
			return IsNull(tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_B.DATES_REGLEMENTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetDATES_REGLEMENTNull()
		{
			this[tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_B.DATES_REGLEMENTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsMONTANTNull()
		{
			return IsNull(tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_B.MONTANTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetMONTANTNull()
		{
			this[tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_B.MONTANTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNOTESNull()
		{
			return IsNull(tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_B.NOTESColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public void SetNOTESNull()
		{
			this[tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_B.NOTESColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public class DataTable_BRRowChangeEvent : EventArgs
	{
		private DataTable_BRRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_BRRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_BRRowChangeEvent(DataTable_BRRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public class DataTable_BSRowChangeEvent : EventArgs
	{
		private DataTable_BSRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_BSRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_BSRowChangeEvent(DataTable_BSRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public class DataTable_INVRowChangeEvent : EventArgs
	{
		private DataTable_INVRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_INVRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_INVRowChangeEvent(DataTable_INVRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public class DataTable_DEVISRowChangeEvent : EventArgs
	{
		private DataTable_DEVISRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_DEVISRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_DEVISRowChangeEvent(DataTable_DEVISRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public class DataTable_BLRowChangeEvent : EventArgs
	{
		private DataTable_BLRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_BLRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_BLRowChangeEvent(DataTable_BLRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public class DataTable_FACTURERowChangeEvent : EventArgs
	{
		private DataTable_FACTURERow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_FACTURERow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_FACTURERowChangeEvent(DataTable_FACTURERow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public class DataTable_ETAT_STOCKRowChangeEvent : EventArgs
	{
		private DataTable_ETAT_STOCKRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_ETAT_STOCKRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_ETAT_STOCKRowChangeEvent(DataTable_ETAT_STOCKRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public class DataTable_TICKET_A4RowChangeEvent : EventArgs
	{
		private DataTable_TICKET_A4Row eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_TICKET_A4Row Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_TICKET_A4RowChangeEvent(DataTable_TICKET_A4Row row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public class DataTable_NOMENCLATURERowChangeEvent : EventArgs
	{
		private DataTable_NOMENCLATURERow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_NOMENCLATURERow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_NOMENCLATURERowChangeEvent(DataTable_NOMENCLATURERow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public class DataTable_CLIENTS_ETAT_CREDITSRowChangeEvent : EventArgs
	{
		private DataTable_CLIENTS_ETAT_CREDITSRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_CLIENTS_ETAT_CREDITSRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_CLIENTS_ETAT_CREDITSRowChangeEvent(DataTable_CLIENTS_ETAT_CREDITSRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public class DataTable_CLIENTS_ETAT_HISTORIQUE_ARowChangeEvent : EventArgs
	{
		private DataTable_CLIENTS_ETAT_HISTORIQUE_ARow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_CLIENTS_ETAT_HISTORIQUE_ARow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_CLIENTS_ETAT_HISTORIQUE_ARowChangeEvent(DataTable_CLIENTS_ETAT_HISTORIQUE_ARow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public class DataTable_CLIENTS_ETAT_HISTORIQUE_BRowChangeEvent : EventArgs
	{
		private DataTable_CLIENTS_ETAT_HISTORIQUE_BRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_CLIENTS_ETAT_HISTORIQUE_BRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_CLIENTS_ETAT_HISTORIQUE_BRowChangeEvent(DataTable_CLIENTS_ETAT_HISTORIQUE_BRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public class DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRowChangeEvent : EventArgs
	{
		private DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRowChangeEvent(DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public class DataTable_FOURNISSEURS_ETAT_CREDITSRowChangeEvent : EventArgs
	{
		private DataTable_FOURNISSEURS_ETAT_CREDITSRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_FOURNISSEURS_ETAT_CREDITSRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_FOURNISSEURS_ETAT_CREDITSRowChangeEvent(DataTable_FOURNISSEURS_ETAT_CREDITSRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public class DataTable_BCRowChangeEvent : EventArgs
	{
		private DataTable_BCRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_BCRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_BCRowChangeEvent(DataTable_BCRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public class DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARowChangeEvent : EventArgs
	{
		private DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARowChangeEvent(DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ARow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public class DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRowChangeEvent : EventArgs
	{
		private DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRowChangeEvent(DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private DataTable_BRDataTable tableDataTable_BR;

	private DataTable_BSDataTable tableDataTable_BS;

	private DataTable_INVDataTable tableDataTable_INV;

	private DataTable_DEVISDataTable tableDataTable_DEVIS;

	private DataTable_BLDataTable tableDataTable_BL;

	private DataTable_FACTUREDataTable tableDataTable_FACTURE;

	private DataTable_ETAT_STOCKDataTable tableDataTable_ETAT_STOCK;

	private DataTable_TICKET_A4DataTable tableDataTable_TICKET_A4;

	private DataTable_NOMENCLATUREDataTable tableDataTable_NOMENCLATURE;

	private DataTable_CLIENTS_ETAT_CREDITSDataTable tableDataTable_CLIENTS_ETAT_CREDITS;

	private DataTable_CLIENTS_ETAT_HISTORIQUE_ADataTable tableDataTable_CLIENTS_ETAT_HISTORIQUE_A;

	private DataTable_CLIENTS_ETAT_HISTORIQUE_BDataTable tableDataTable_CLIENTS_ETAT_HISTORIQUE_B;

	private DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSDataTable tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS;

	private DataTable_FOURNISSEURS_ETAT_CREDITSDataTable tableDataTable_FOURNISSEURS_ETAT_CREDITS;

	private DataTable_BCDataTable tableDataTable_BC;

	private DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ADataTable tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_A;

	private DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BDataTable tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_B;

	private SchemaSerializationMode _schemaSerializationMode;

	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public DataTable_BRDataTable DataTable_BR => tableDataTable_BR;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[DebuggerNonUserCode]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public DataTable_BSDataTable DataTable_BS => tableDataTable_BS;

	[Browsable(false)]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public DataTable_INVDataTable DataTable_INV => tableDataTable_INV;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[Browsable(false)]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public DataTable_DEVISDataTable DataTable_DEVIS => tableDataTable_DEVIS;

	[DebuggerNonUserCode]
	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public DataTable_BLDataTable DataTable_BL => tableDataTable_BL;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[Browsable(false)]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public DataTable_FACTUREDataTable DataTable_FACTURE => tableDataTable_FACTURE;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[Browsable(false)]
	public DataTable_ETAT_STOCKDataTable DataTable_ETAT_STOCK => tableDataTable_ETAT_STOCK;

	[Browsable(false)]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public DataTable_TICKET_A4DataTable DataTable_TICKET_A4 => tableDataTable_TICKET_A4;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[DebuggerNonUserCode]
	[Browsable(false)]
	public DataTable_NOMENCLATUREDataTable DataTable_NOMENCLATURE => tableDataTable_NOMENCLATURE;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[Browsable(false)]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public DataTable_CLIENTS_ETAT_CREDITSDataTable DataTable_CLIENTS_ETAT_CREDITS => tableDataTable_CLIENTS_ETAT_CREDITS;

	[Browsable(false)]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public DataTable_CLIENTS_ETAT_HISTORIQUE_ADataTable DataTable_CLIENTS_ETAT_HISTORIQUE_A => tableDataTable_CLIENTS_ETAT_HISTORIQUE_A;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[DebuggerNonUserCode]
	[Browsable(false)]
	public DataTable_CLIENTS_ETAT_HISTORIQUE_BDataTable DataTable_CLIENTS_ETAT_HISTORIQUE_B => tableDataTable_CLIENTS_ETAT_HISTORIQUE_B;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[DebuggerNonUserCode]
	[Browsable(false)]
	public DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSDataTable DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS => tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	public DataTable_FOURNISSEURS_ETAT_CREDITSDataTable DataTable_FOURNISSEURS_ETAT_CREDITS => tableDataTable_FOURNISSEURS_ETAT_CREDITS;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[DebuggerNonUserCode]
	[Browsable(false)]
	public DataTable_BCDataTable DataTable_BC => tableDataTable_BC;

	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ADataTable DataTable_FOURNISSEURS_ETAT_HISTORIQUE_A => tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_A;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[DebuggerNonUserCode]
	public DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BDataTable DataTable_FOURNISSEURS_ETAT_HISTORIQUE_B => tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_B;

	[Browsable(true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	public override SchemaSerializationMode SchemaSerializationMode
	{
		get
		{
			return _schemaSerializationMode;
		}
		set
		{
			_schemaSerializationMode = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[DebuggerNonUserCode]
	public new DataTableCollection Tables => base.Tables;

	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public new DataRelationCollection Relations => base.Relations;

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[DebuggerNonUserCode]
	public Report_0_DATASET()
	{
		__ENCAddToList(this);
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		BeginInit();
		InitClass();
		CollectionChangeEventHandler value = SchemaChanged;
		base.Tables.CollectionChanged += value;
		base.Relations.CollectionChanged += value;
		EndInit();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	protected Report_0_DATASET(SerializationInfo info, StreamingContext context)
		: base(info, context, ConstructSchema: false)
	{
		__ENCAddToList(this);
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		if (IsBinarySerialized(info, context))
		{
			InitVars(initTable: false);
			CollectionChangeEventHandler value = SchemaChanged;
			Tables.CollectionChanged += value;
			Relations.CollectionChanged += value;
			return;
		}
		string s = Conversions.ToString(info.GetValue("XmlSchema", typeof(string)));
		if (DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
		{
			DataSet dataSet = new DataSet();
			dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
			if (dataSet.Tables["DataTable_BR"] != null)
			{
				base.Tables.Add(new DataTable_BRDataTable(dataSet.Tables["DataTable_BR"]));
			}
			if (dataSet.Tables["DataTable_BS"] != null)
			{
				base.Tables.Add(new DataTable_BSDataTable(dataSet.Tables["DataTable_BS"]));
			}
			if (dataSet.Tables["DataTable_INV"] != null)
			{
				base.Tables.Add(new DataTable_INVDataTable(dataSet.Tables["DataTable_INV"]));
			}
			if (dataSet.Tables["DataTable_DEVIS"] != null)
			{
				base.Tables.Add(new DataTable_DEVISDataTable(dataSet.Tables["DataTable_DEVIS"]));
			}
			if (dataSet.Tables["DataTable_BL"] != null)
			{
				base.Tables.Add(new DataTable_BLDataTable(dataSet.Tables["DataTable_BL"]));
			}
			if (dataSet.Tables["DataTable_FACTURE"] != null)
			{
				base.Tables.Add(new DataTable_FACTUREDataTable(dataSet.Tables["DataTable_FACTURE"]));
			}
			if (dataSet.Tables["DataTable_ETAT_STOCK"] != null)
			{
				base.Tables.Add(new DataTable_ETAT_STOCKDataTable(dataSet.Tables["DataTable_ETAT_STOCK"]));
			}
			if (dataSet.Tables["DataTable_TICKET_A4"] != null)
			{
				base.Tables.Add(new DataTable_TICKET_A4DataTable(dataSet.Tables["DataTable_TICKET_A4"]));
			}
			if (dataSet.Tables["DataTable_NOMENCLATURE"] != null)
			{
				base.Tables.Add(new DataTable_NOMENCLATUREDataTable(dataSet.Tables["DataTable_NOMENCLATURE"]));
			}
			if (dataSet.Tables["DataTable_CLIENTS_ETAT_CREDITS"] != null)
			{
				base.Tables.Add(new DataTable_CLIENTS_ETAT_CREDITSDataTable(dataSet.Tables["DataTable_CLIENTS_ETAT_CREDITS"]));
			}
			if (dataSet.Tables["DataTable_CLIENTS_ETAT_HISTORIQUE_A"] != null)
			{
				base.Tables.Add(new DataTable_CLIENTS_ETAT_HISTORIQUE_ADataTable(dataSet.Tables["DataTable_CLIENTS_ETAT_HISTORIQUE_A"]));
			}
			if (dataSet.Tables["DataTable_CLIENTS_ETAT_HISTORIQUE_B"] != null)
			{
				base.Tables.Add(new DataTable_CLIENTS_ETAT_HISTORIQUE_BDataTable(dataSet.Tables["DataTable_CLIENTS_ETAT_HISTORIQUE_B"]));
			}
			if (dataSet.Tables["DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS"] != null)
			{
				base.Tables.Add(new DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSDataTable(dataSet.Tables["DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS"]));
			}
			if (dataSet.Tables["DataTable_FOURNISSEURS_ETAT_CREDITS"] != null)
			{
				base.Tables.Add(new DataTable_FOURNISSEURS_ETAT_CREDITSDataTable(dataSet.Tables["DataTable_FOURNISSEURS_ETAT_CREDITS"]));
			}
			if (dataSet.Tables["DataTable_BC"] != null)
			{
				base.Tables.Add(new DataTable_BCDataTable(dataSet.Tables["DataTable_BC"]));
			}
			if (dataSet.Tables["DataTable_FOURNISSEURS_ETAT_HISTORIQUE_A"] != null)
			{
				base.Tables.Add(new DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ADataTable(dataSet.Tables["DataTable_FOURNISSEURS_ETAT_HISTORIQUE_A"]));
			}
			if (dataSet.Tables["DataTable_FOURNISSEURS_ETAT_HISTORIQUE_B"] != null)
			{
				base.Tables.Add(new DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BDataTable(dataSet.Tables["DataTable_FOURNISSEURS_ETAT_HISTORIQUE_B"]));
			}
			DataSetName = dataSet.DataSetName;
			Prefix = dataSet.Prefix;
			Namespace = dataSet.Namespace;
			Locale = dataSet.Locale;
			CaseSensitive = dataSet.CaseSensitive;
			EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			InitVars();
		}
		else
		{
			ReadXmlSchema(new XmlTextReader(new StringReader(s)));
		}
		GetSerializationData(info, context);
		CollectionChangeEventHandler value2 = SchemaChanged;
		base.Tables.CollectionChanged += value2;
		Relations.CollectionChanged += value2;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[DebuggerNonUserCode]
	protected override void InitializeDerivedDataSet()
	{
		BeginInit();
		InitClass();
		EndInit();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[DebuggerNonUserCode]
	public override DataSet Clone()
	{
		Report_0_DATASET report_0_DATASET = (Report_0_DATASET)base.Clone();
		report_0_DATASET.InitVars();
		report_0_DATASET.SchemaSerializationMode = SchemaSerializationMode;
		return report_0_DATASET;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[DebuggerNonUserCode]
	protected override bool ShouldSerializeTables()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[DebuggerNonUserCode]
	protected override bool ShouldSerializeRelations()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	protected override void ReadXmlSerializable(XmlReader reader)
	{
		if (DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
		{
			Reset();
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(reader);
			if (dataSet.Tables["DataTable_BR"] != null)
			{
				base.Tables.Add(new DataTable_BRDataTable(dataSet.Tables["DataTable_BR"]));
			}
			if (dataSet.Tables["DataTable_BS"] != null)
			{
				base.Tables.Add(new DataTable_BSDataTable(dataSet.Tables["DataTable_BS"]));
			}
			if (dataSet.Tables["DataTable_INV"] != null)
			{
				base.Tables.Add(new DataTable_INVDataTable(dataSet.Tables["DataTable_INV"]));
			}
			if (dataSet.Tables["DataTable_DEVIS"] != null)
			{
				base.Tables.Add(new DataTable_DEVISDataTable(dataSet.Tables["DataTable_DEVIS"]));
			}
			if (dataSet.Tables["DataTable_BL"] != null)
			{
				base.Tables.Add(new DataTable_BLDataTable(dataSet.Tables["DataTable_BL"]));
			}
			if (dataSet.Tables["DataTable_FACTURE"] != null)
			{
				base.Tables.Add(new DataTable_FACTUREDataTable(dataSet.Tables["DataTable_FACTURE"]));
			}
			if (dataSet.Tables["DataTable_ETAT_STOCK"] != null)
			{
				base.Tables.Add(new DataTable_ETAT_STOCKDataTable(dataSet.Tables["DataTable_ETAT_STOCK"]));
			}
			if (dataSet.Tables["DataTable_TICKET_A4"] != null)
			{
				base.Tables.Add(new DataTable_TICKET_A4DataTable(dataSet.Tables["DataTable_TICKET_A4"]));
			}
			if (dataSet.Tables["DataTable_NOMENCLATURE"] != null)
			{
				base.Tables.Add(new DataTable_NOMENCLATUREDataTable(dataSet.Tables["DataTable_NOMENCLATURE"]));
			}
			if (dataSet.Tables["DataTable_CLIENTS_ETAT_CREDITS"] != null)
			{
				base.Tables.Add(new DataTable_CLIENTS_ETAT_CREDITSDataTable(dataSet.Tables["DataTable_CLIENTS_ETAT_CREDITS"]));
			}
			if (dataSet.Tables["DataTable_CLIENTS_ETAT_HISTORIQUE_A"] != null)
			{
				base.Tables.Add(new DataTable_CLIENTS_ETAT_HISTORIQUE_ADataTable(dataSet.Tables["DataTable_CLIENTS_ETAT_HISTORIQUE_A"]));
			}
			if (dataSet.Tables["DataTable_CLIENTS_ETAT_HISTORIQUE_B"] != null)
			{
				base.Tables.Add(new DataTable_CLIENTS_ETAT_HISTORIQUE_BDataTable(dataSet.Tables["DataTable_CLIENTS_ETAT_HISTORIQUE_B"]));
			}
			if (dataSet.Tables["DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS"] != null)
			{
				base.Tables.Add(new DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSDataTable(dataSet.Tables["DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS"]));
			}
			if (dataSet.Tables["DataTable_FOURNISSEURS_ETAT_CREDITS"] != null)
			{
				base.Tables.Add(new DataTable_FOURNISSEURS_ETAT_CREDITSDataTable(dataSet.Tables["DataTable_FOURNISSEURS_ETAT_CREDITS"]));
			}
			if (dataSet.Tables["DataTable_BC"] != null)
			{
				base.Tables.Add(new DataTable_BCDataTable(dataSet.Tables["DataTable_BC"]));
			}
			if (dataSet.Tables["DataTable_FOURNISSEURS_ETAT_HISTORIQUE_A"] != null)
			{
				base.Tables.Add(new DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ADataTable(dataSet.Tables["DataTable_FOURNISSEURS_ETAT_HISTORIQUE_A"]));
			}
			if (dataSet.Tables["DataTable_FOURNISSEURS_ETAT_HISTORIQUE_B"] != null)
			{
				base.Tables.Add(new DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BDataTable(dataSet.Tables["DataTable_FOURNISSEURS_ETAT_HISTORIQUE_B"]));
			}
			DataSetName = dataSet.DataSetName;
			Prefix = dataSet.Prefix;
			Namespace = dataSet.Namespace;
			Locale = dataSet.Locale;
			CaseSensitive = dataSet.CaseSensitive;
			EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			InitVars();
		}
		else
		{
			ReadXml(reader);
			InitVars();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	protected override XmlSchema GetSchemaSerializable()
	{
		MemoryStream memoryStream = new MemoryStream();
		WriteXmlSchema(new XmlTextWriter(memoryStream, null));
		memoryStream.Position = 0L;
		return XmlSchema.Read(new XmlTextReader(memoryStream), null);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	internal void InitVars()
	{
		InitVars(initTable: true);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[DebuggerNonUserCode]
	internal void InitVars(bool initTable)
	{
		tableDataTable_BR = (DataTable_BRDataTable)base.Tables["DataTable_BR"];
		if (initTable && tableDataTable_BR != null)
		{
			tableDataTable_BR.InitVars();
		}
		tableDataTable_BS = (DataTable_BSDataTable)base.Tables["DataTable_BS"];
		if (initTable && tableDataTable_BS != null)
		{
			tableDataTable_BS.InitVars();
		}
		tableDataTable_INV = (DataTable_INVDataTable)base.Tables["DataTable_INV"];
		if (initTable && tableDataTable_INV != null)
		{
			tableDataTable_INV.InitVars();
		}
		tableDataTable_DEVIS = (DataTable_DEVISDataTable)base.Tables["DataTable_DEVIS"];
		if (initTable && tableDataTable_DEVIS != null)
		{
			tableDataTable_DEVIS.InitVars();
		}
		tableDataTable_BL = (DataTable_BLDataTable)base.Tables["DataTable_BL"];
		if (initTable && tableDataTable_BL != null)
		{
			tableDataTable_BL.InitVars();
		}
		tableDataTable_FACTURE = (DataTable_FACTUREDataTable)base.Tables["DataTable_FACTURE"];
		if (initTable && tableDataTable_FACTURE != null)
		{
			tableDataTable_FACTURE.InitVars();
		}
		tableDataTable_ETAT_STOCK = (DataTable_ETAT_STOCKDataTable)base.Tables["DataTable_ETAT_STOCK"];
		if (initTable && tableDataTable_ETAT_STOCK != null)
		{
			tableDataTable_ETAT_STOCK.InitVars();
		}
		tableDataTable_TICKET_A4 = (DataTable_TICKET_A4DataTable)base.Tables["DataTable_TICKET_A4"];
		if (initTable && tableDataTable_TICKET_A4 != null)
		{
			tableDataTable_TICKET_A4.InitVars();
		}
		tableDataTable_NOMENCLATURE = (DataTable_NOMENCLATUREDataTable)base.Tables["DataTable_NOMENCLATURE"];
		if (initTable && tableDataTable_NOMENCLATURE != null)
		{
			tableDataTable_NOMENCLATURE.InitVars();
		}
		tableDataTable_CLIENTS_ETAT_CREDITS = (DataTable_CLIENTS_ETAT_CREDITSDataTable)base.Tables["DataTable_CLIENTS_ETAT_CREDITS"];
		if (initTable && tableDataTable_CLIENTS_ETAT_CREDITS != null)
		{
			tableDataTable_CLIENTS_ETAT_CREDITS.InitVars();
		}
		tableDataTable_CLIENTS_ETAT_HISTORIQUE_A = (DataTable_CLIENTS_ETAT_HISTORIQUE_ADataTable)base.Tables["DataTable_CLIENTS_ETAT_HISTORIQUE_A"];
		if (initTable && tableDataTable_CLIENTS_ETAT_HISTORIQUE_A != null)
		{
			tableDataTable_CLIENTS_ETAT_HISTORIQUE_A.InitVars();
		}
		tableDataTable_CLIENTS_ETAT_HISTORIQUE_B = (DataTable_CLIENTS_ETAT_HISTORIQUE_BDataTable)base.Tables["DataTable_CLIENTS_ETAT_HISTORIQUE_B"];
		if (initTable && tableDataTable_CLIENTS_ETAT_HISTORIQUE_B != null)
		{
			tableDataTable_CLIENTS_ETAT_HISTORIQUE_B.InitVars();
		}
		tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS = (DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSDataTable)base.Tables["DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS"];
		if (initTable && tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS != null)
		{
			tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS.InitVars();
		}
		tableDataTable_FOURNISSEURS_ETAT_CREDITS = (DataTable_FOURNISSEURS_ETAT_CREDITSDataTable)base.Tables["DataTable_FOURNISSEURS_ETAT_CREDITS"];
		if (initTable && tableDataTable_FOURNISSEURS_ETAT_CREDITS != null)
		{
			tableDataTable_FOURNISSEURS_ETAT_CREDITS.InitVars();
		}
		tableDataTable_BC = (DataTable_BCDataTable)base.Tables["DataTable_BC"];
		if (initTable && tableDataTable_BC != null)
		{
			tableDataTable_BC.InitVars();
		}
		tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_A = (DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ADataTable)base.Tables["DataTable_FOURNISSEURS_ETAT_HISTORIQUE_A"];
		if (initTable && tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_A != null)
		{
			tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_A.InitVars();
		}
		tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_B = (DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BDataTable)base.Tables["DataTable_FOURNISSEURS_ETAT_HISTORIQUE_B"];
		if (initTable && tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_B != null)
		{
			tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_B.InitVars();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[DebuggerNonUserCode]
	private void InitClass()
	{
		DataSetName = "Report_0_DATASET";
		Prefix = "";
		Namespace = "http://tempuri.org/Report_BR_DATASET.xsd";
		EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tableDataTable_BR = new DataTable_BRDataTable();
		base.Tables.Add(tableDataTable_BR);
		tableDataTable_BS = new DataTable_BSDataTable();
		base.Tables.Add(tableDataTable_BS);
		tableDataTable_INV = new DataTable_INVDataTable();
		base.Tables.Add(tableDataTable_INV);
		tableDataTable_DEVIS = new DataTable_DEVISDataTable();
		base.Tables.Add(tableDataTable_DEVIS);
		tableDataTable_BL = new DataTable_BLDataTable();
		base.Tables.Add(tableDataTable_BL);
		tableDataTable_FACTURE = new DataTable_FACTUREDataTable();
		base.Tables.Add(tableDataTable_FACTURE);
		tableDataTable_ETAT_STOCK = new DataTable_ETAT_STOCKDataTable();
		base.Tables.Add(tableDataTable_ETAT_STOCK);
		tableDataTable_TICKET_A4 = new DataTable_TICKET_A4DataTable();
		base.Tables.Add(tableDataTable_TICKET_A4);
		tableDataTable_NOMENCLATURE = new DataTable_NOMENCLATUREDataTable();
		base.Tables.Add(tableDataTable_NOMENCLATURE);
		tableDataTable_CLIENTS_ETAT_CREDITS = new DataTable_CLIENTS_ETAT_CREDITSDataTable();
		base.Tables.Add(tableDataTable_CLIENTS_ETAT_CREDITS);
		tableDataTable_CLIENTS_ETAT_HISTORIQUE_A = new DataTable_CLIENTS_ETAT_HISTORIQUE_ADataTable();
		base.Tables.Add(tableDataTable_CLIENTS_ETAT_HISTORIQUE_A);
		tableDataTable_CLIENTS_ETAT_HISTORIQUE_B = new DataTable_CLIENTS_ETAT_HISTORIQUE_BDataTable();
		base.Tables.Add(tableDataTable_CLIENTS_ETAT_HISTORIQUE_B);
		tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS = new DataTable_CLIENTS_ETAT_HISTORIQUE_DETAILSDataTable();
		base.Tables.Add(tableDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS);
		tableDataTable_FOURNISSEURS_ETAT_CREDITS = new DataTable_FOURNISSEURS_ETAT_CREDITSDataTable();
		base.Tables.Add(tableDataTable_FOURNISSEURS_ETAT_CREDITS);
		tableDataTable_BC = new DataTable_BCDataTable();
		base.Tables.Add(tableDataTable_BC);
		tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_A = new DataTable_FOURNISSEURS_ETAT_HISTORIQUE_ADataTable();
		base.Tables.Add(tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_A);
		tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_B = new DataTable_FOURNISSEURS_ETAT_HISTORIQUE_BDataTable();
		base.Tables.Add(tableDataTable_FOURNISSEURS_ETAT_HISTORIQUE_B);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializeDataTable_BR()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	private bool ShouldSerializeDataTable_BS()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	private bool ShouldSerializeDataTable_INV()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializeDataTable_DEVIS()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	private bool ShouldSerializeDataTable_BL()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializeDataTable_FACTURE()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	private bool ShouldSerializeDataTable_ETAT_STOCK()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	private bool ShouldSerializeDataTable_TICKET_A4()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializeDataTable_NOMENCLATURE()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	private bool ShouldSerializeDataTable_CLIENTS_ETAT_CREDITS()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	private bool ShouldSerializeDataTable_CLIENTS_ETAT_HISTORIQUE_A()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializeDataTable_CLIENTS_ETAT_HISTORIQUE_B()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializeDataTable_CLIENTS_ETAT_HISTORIQUE_DETAILS()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	private bool ShouldSerializeDataTable_FOURNISSEURS_ETAT_CREDITS()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializeDataTable_BC()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	private bool ShouldSerializeDataTable_FOURNISSEURS_ETAT_HISTORIQUE_A()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	private bool ShouldSerializeDataTable_FOURNISSEURS_ETAT_HISTORIQUE_B()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	private void SchemaChanged(object sender, CollectionChangeEventArgs e)
	{
		if (e.Action == CollectionChangeAction.Remove)
		{
			InitVars();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[DebuggerNonUserCode]
	public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
	{
		Report_0_DATASET report_0_DATASET = new Report_0_DATASET();
		XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
		XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
		XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
		xmlSchemaAny.Namespace = report_0_DATASET.Namespace;
		xmlSchemaSequence.Items.Add(xmlSchemaAny);
		xmlSchemaComplexType.Particle = xmlSchemaSequence;
		XmlSchema schemaSerializable = report_0_DATASET.GetSchemaSerializable();
		if (xs.Contains(schemaSerializable.TargetNamespace))
		{
			MemoryStream memoryStream = new MemoryStream();
			MemoryStream memoryStream2 = new MemoryStream();
			try
			{
				XmlSchema xmlSchema = null;
				schemaSerializable.Write(memoryStream);
				IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
				while (enumerator.MoveNext())
				{
					xmlSchema = (XmlSchema)enumerator.Current;
					memoryStream2.SetLength(0L);
					xmlSchema.Write(memoryStream2);
					if (memoryStream.Length == memoryStream2.Length)
					{
						memoryStream.Position = 0L;
						memoryStream2.Position = 0L;
						while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
						{
						}
						if (memoryStream.Position == memoryStream.Length)
						{
							return xmlSchemaComplexType;
						}
					}
				}
			}
			finally
			{
				memoryStream?.Close();
				memoryStream2?.Close();
			}
		}
		xs.Add(schemaSerializable);
		return xmlSchemaComplexType;
	}
}
