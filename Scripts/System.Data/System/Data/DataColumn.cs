using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Serialization;

namespace System.Data;

/// <summary>Represents the schema of a column in a <see cref="T:System.Data.DataTable" />.</summary>
[DefaultProperty("ColumnName")]
[ToolboxItem(false)]
[DesignTimeVisible(false)]
public class DataColumn : MarshalByValueComponent
{
	private bool _allowNull;

	private string _caption;

	private string _columnName;

	private Type _dataType;

	private StorageType _storageType;

	internal object _defaultValue;

	private DataSetDateTime _dateTimeMode;

	private DataExpression _expression;

	private int _maxLength;

	private int _ordinal;

	private bool _readOnly;

	internal Index _sortIndex;

	internal DataTable _table;

	private bool _unique;

	internal MappingType _columnMapping;

	internal int _hashCode;

	internal int _errors;

	private bool _isSqlType;

	private bool _implementsINullable;

	private bool _implementsIChangeTracking;

	private bool _implementsIRevertibleChangeTracking;

	private bool _implementsIXMLSerializable;

	private bool _defaultValueIsNull;

	internal List<DataColumn> _dependentColumns;

	internal PropertyCollection _extendedProperties;

	private DataStorage _storage;

	private AutoIncrementValue _autoInc;

	internal string _columnUri;

	private string _columnPrefix;

	internal string _encodedColumnName;

	internal SimpleType _simpleType;

	private static int s_objectTypeCount;

	private readonly int _objectID;

	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanging;

	/// <summary>Gets or sets a value that indicates whether null values are allowed in this column for rows that belong to the table.</summary>
	/// <returns>
	///   <see langword="true" /> if null values values are allowed; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[DefaultValue(true)]
	public bool AllowDBNull
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value that indicates whether the column automatically increments the value of the column for new rows added to the table.</summary>
	/// <returns>
	///   <see langword="true" /> if the value of the column increments automatically; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentException">The column is a computed column.</exception>
	[RefreshProperties(RefreshProperties.All)]
	[DefaultValue(false)]
	public bool AutoIncrement
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal object AutoIncrementCurrent
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal AutoIncrementValue AutoInc => null;

	/// <summary>Gets or sets the starting value for a column that has its <see cref="P:System.Data.DataColumn.AutoIncrement" /> property set to <see langword="true" />. The default is 0.</summary>
	/// <returns>The starting value for the <see cref="P:System.Data.DataColumn.AutoIncrement" /> feature.</returns>
	[DefaultValue(0L)]
	public long AutoIncrementSeed
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the increment used by a column with its <see cref="P:System.Data.DataColumn.AutoIncrement" /> property set to <see langword="true" />.</summary>
	/// <returns>The number by which the value of the column is automatically incremented. The default is 1.</returns>
	/// <exception cref="T:System.ArgumentException">The value set is zero.</exception>
	[DefaultValue(1L)]
	public long AutoIncrementStep
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the caption for the column.</summary>
	/// <returns>The caption of the column. If not set, returns the <see cref="P:System.Data.DataColumn.ColumnName" /> value.</returns>
	public string Caption
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the name of the column in the <see cref="T:System.Data.DataColumnCollection" />.</summary>
	/// <returns>The name of the column.</returns>
	/// <exception cref="T:System.ArgumentException">The property is set to <see langword="null" /> or an empty string and the column belongs to a collection.</exception>
	/// <exception cref="T:System.Data.DuplicateNameException">A column with the same name already exists in the collection. The name comparison is not case sensitive.</exception>
	[RefreshProperties(RefreshProperties.All)]
	[DefaultValue(null)]
	public string ColumnName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal string EncodedColumnName => null;

	internal IFormatProvider FormatProvider => null;

	internal CultureInfo Locale => null;

	internal int ObjectID => 0;

	/// <summary>Gets or sets an XML prefix that aliases the namespace of the <see cref="T:System.Data.DataTable" />.</summary>
	/// <returns>The XML prefix for the <see cref="T:System.Data.DataTable" /> namespace.</returns>
	[DefaultValue(null)]
	public string Prefix
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal bool Computed => false;

	internal DataExpression DataExpression => null;

	/// <summary>Gets or sets the type of data stored in the column.</summary>
	/// <returns>A <see cref="T:System.Type" /> object that represents the column data type.</returns>
	/// <exception cref="T:System.ArgumentException">The column already has data stored.</exception>
	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[RefreshProperties(RefreshProperties.All)]
	[TypeConverter(typeof(ColumnTypeConverter))]
	public Type DataType
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the <see langword="DateTimeMode" /> for the column.</summary>
	/// <returns>The <see cref="T:System.Data.DataSetDateTime" /> for the specified column.</returns>
	[RefreshProperties(RefreshProperties.All)]
	[DefaultValue(DataSetDateTime.UnspecifiedLocal)]
	public DataSetDateTime DateTimeMode
	{
		get
		{
			return default(DataSetDateTime);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the default value for the column when you are creating new rows.</summary>
	/// <returns>A value appropriate to the column's <see cref="P:System.Data.DataColumn.DataType" />.</returns>
	/// <exception cref="T:System.InvalidCastException">When you are adding a row, the default value is not an instance of the column's data type.</exception>
	[TypeConverter(typeof(DefaultValueTypeConverter))]
	public object DefaultValue
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal bool DefaultValueIsNull => false;

	/// <summary>Gets or sets the expression used to filter rows, calculate the values in a column, or create an aggregate column.</summary>
	/// <returns>An expression to calculate the value of a column, or create an aggregate column. The return type of an expression is determined by the <see cref="P:System.Data.DataColumn.DataType" /> of the column.</returns>
	/// <exception cref="T:System.ArgumentException">The <see cref="P:System.Data.DataColumn.AutoIncrement" /> or <see cref="P:System.Data.DataColumn.Unique" /> property is set to <see langword="true" />.</exception>
	/// <exception cref="T:System.FormatException">When you are using the CONVERT function, the expression evaluates to a string, but the string does not contain a representation that can be converted to the type parameter.</exception>
	/// <exception cref="T:System.InvalidCastException">When you are using the CONVERT function, the requested cast is not possible. See the Conversion function in the following section for detailed information about possible casts.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">When you use the SUBSTRING function, the start argument is out of range.  
	///  -Or-  
	///  When you use the SUBSTRING function, the length argument is out of range.</exception>
	/// <exception cref="T:System.Exception">When you use the LEN function or the TRIM function, the expression does not evaluate to a string. This includes expressions that evaluate to <see cref="T:System.Char" />.</exception>
	[DefaultValue(null)]
	[RefreshProperties(RefreshProperties.All)]
	public string Expression
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the collection of custom user information associated with a <see cref="T:System.Data.DataColumn" />.</summary>
	/// <returns>A <see cref="T:System.Data.PropertyCollection" /> of custom information.</returns>
	[Browsable(false)]
	public PropertyCollection ExtendedProperties => null;

	internal bool HasData => false;

	internal bool ImplementsINullable => false;

	internal bool ImplementsIChangeTracking => false;

	internal bool ImplementsIRevertibleChangeTracking => false;

	internal bool IsValueType => false;

	internal bool IsSqlType => false;

	/// <summary>Gets or sets the maximum length of a text column.</summary>
	/// <returns>The maximum length of the column in characters. If the column has no maximum length, the value is -1 (default).</returns>
	[DefaultValue(-1)]
	public int MaxLength
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the namespace of the <see cref="T:System.Data.DataColumn" />.</summary>
	/// <returns>The namespace of the <see cref="T:System.Data.DataColumn" />.</returns>
	/// <exception cref="T:System.ArgumentException">The namespace already has data.</exception>
	public string Namespace
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the (zero-based) position of the column in the <see cref="T:System.Data.DataColumnCollection" /> collection.</summary>
	/// <returns>The position of the column. Gets -1 if the column is not a member of a collection.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public int Ordinal => 0;

	/// <summary>Gets or sets a value that indicates whether the column allows for changes as soon as a row has been added to the table.</summary>
	/// <returns>
	///   <see langword="true" /> if the column is read only; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentException">The property is set to <see langword="false" /> on a computed column.</exception>
	[DefaultValue(false)]
	public bool ReadOnly
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Index SortIndex => null;

	/// <summary>Gets the <see cref="T:System.Data.DataTable" /> to which the column belongs to.</summary>
	/// <returns>The <see cref="T:System.Data.DataTable" /> that the <see cref="T:System.Data.DataColumn" /> belongs to.</returns>
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public DataTable Table => null;

	internal object this[int record]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value that indicates whether the values in each row of the column must be unique.</summary>
	/// <returns>
	///   <see langword="true" /> if the value must be unique; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentException">The column is a calculated column.</exception>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DefaultValue(false)]
	public bool Unique
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal string XmlDataType { get; set; }

	internal SimpleType SimpleType
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the <see cref="T:System.Data.MappingType" /> of the column.</summary>
	/// <returns>One of the <see cref="T:System.Data.MappingType" /> values.</returns>
	[DefaultValue(MappingType.Element)]
	public virtual MappingType ColumnMapping
	{
		get
		{
			return default(MappingType);
		}
		set
		{
		}
	}

	internal bool IsCustomType => false;

	internal bool ImplementsIXMLSerializable => false;

	/// <summary>Initializes a new instance of a <see cref="T:System.Data.DataColumn" /> class as type string.</summary>
	public DataColumn()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataColumn" /> class using the specified column name and data type.</summary>
	/// <param name="columnName">A string that represents the name of the column to be created. If set to <see langword="null" /> or an empty string (""), a default name will be specified when added to the columns collection.</param>
	/// <param name="dataType">A supported <see cref="P:System.Data.DataColumn.DataType" />.</param>
	/// <exception cref="T:System.ArgumentNullException">No <paramref name="dataType" /> was specified.</exception>
	public DataColumn(string columnName, Type dataType)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataColumn" /> class using the specified name, data type, expression, and value that determines whether the column is an attribute.</summary>
	/// <param name="columnName">A string that represents the name of the column to be created. If set to <see langword="null" /> or an empty string (""), a default name will be specified when added to the columns collection.</param>
	/// <param name="dataType">A supported <see cref="P:System.Data.DataColumn.DataType" />.</param>
	/// <param name="expr">The expression used to create this column. For more information, see the <see cref="P:System.Data.DataColumn.Expression" /> property.</param>
	/// <param name="type">One of the <see cref="T:System.Data.MappingType" /> values.</param>
	/// <exception cref="T:System.ArgumentNullException">No <paramref name="dataType" /> was specified.</exception>
	public DataColumn(string columnName, Type dataType, string expr, MappingType type)
	{
	}

	private void UpdateColumnType(Type type, StorageType typeCode)
	{
	}

	internal string GetColumnValueAsString(DataRow row, DataRowVersion version)
	{
		return null;
	}

	private void SetMaxLengthSimpleType()
	{
	}

	internal void SetOrdinalInternal(int ordinal)
	{
	}

	internal void SetTable(DataTable table)
	{
	}

	private DataRow GetDataRow(int index)
	{
		return null;
	}

	internal void InitializeRecord(int record)
	{
	}

	internal void SetValue(int record, object value)
	{
	}

	internal void FreeRecord(int record)
	{
	}

	internal void InternalUnique(bool value)
	{
	}

	internal void CheckColumnConstraint(DataRow row, DataRowAction action)
	{
	}

	internal bool CheckMaxLength()
	{
		return false;
	}

	internal void CheckMaxLength(DataRow dr)
	{
	}

	/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
	protected internal void CheckNotAllowNull()
	{
	}

	internal void CheckNullable(DataRow row)
	{
	}

	/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
	protected void CheckUnique()
	{
	}

	internal int Compare(int record1, int record2)
	{
		return 0;
	}

	internal bool CompareValueTo(int record1, object value, bool checkType)
	{
		return false;
	}

	internal int CompareValueTo(int record1, object value)
	{
		return 0;
	}

	internal object ConvertValue(object value)
	{
		return null;
	}

	internal void Copy(int srcRecordNo, int dstRecordNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal DataColumn Clone()
	{
		return null;
	}

	internal object GetAggregateValue(int[] records, AggregateType kind)
	{
		return null;
	}

	private int GetStringLength(int record)
	{
		return 0;
	}

	internal void Init(int record)
	{
	}

	internal static bool IsAutoIncrementType(Type dataType)
	{
		return false;
	}

	internal bool IsValueCustomTypeInstance(object value)
	{
		return false;
	}

	internal bool IsInRelation()
	{
		return false;
	}

	internal bool IsMaxLengthViolated()
	{
		return false;
	}

	internal bool IsNotAllowDBNullViolated()
	{
		return false;
	}

	/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
	/// <param name="pcevent">Parameter reference.</param>
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent)
	{
	}

	/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
	/// <param name="name">Parameter reference.</param>
	protected internal void RaisePropertyChanging(string name)
	{
	}

	private void InsureStorage()
	{
	}

	internal void SetCapacity(int capacity)
	{
	}

	internal void OnSetDataSet()
	{
	}

	/// <summary>Gets the <see cref="P:System.Data.DataColumn.Expression" /> of the column, if one exists.</summary>
	/// <returns>The <see cref="P:System.Data.DataColumn.Expression" /> value, if the property is set; otherwise, the <see cref="P:System.Data.DataColumn.ColumnName" /> property.</returns>
	public override string ToString()
	{
		return null;
	}

	internal object ConvertXmlToObject(string s)
	{
		return null;
	}

	internal object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib)
	{
		return null;
	}

	internal string ConvertObjectToXml(object value)
	{
		return null;
	}

	internal void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib)
	{
	}

	internal object GetEmptyColumnStore(int recordCount)
	{
		return null;
	}

	internal void CopyValueIntoStore(int record, object store, BitArray nullbits, int storeIndex)
	{
	}

	internal void SetStorage(object store, BitArray nullbits)
	{
	}

	internal void AddDependentColumn(DataColumn expressionColumn)
	{
	}

	internal void RemoveDependentColumn(DataColumn expressionColumn)
	{
	}

	internal void HandleDependentColumnList(DataExpression oldExpression, DataExpression newExpression)
	{
	}
}
