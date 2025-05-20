using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data;

/// <summary>Represents one table of in-memory data.</summary>
[Serializable]
[DesignTimeVisible(false)]
[DefaultProperty("TableName")]
[DefaultEvent("RowChanging")]
[XmlSchemaProvider("GetDataTableSchema")]
[ToolboxItem(false)]
public class DataTable : MarshalByValueComponent, IListSource, ISerializable, IXmlSerializable
{
	internal struct RowDiffIdUsageSection
	{
		private DataTable _targetTable;

		internal void Prepare(DataTable table)
		{
		}
	}

	internal struct DSRowDiffIdUsageSection
	{
		private DataSet _targetDS;

		internal void Prepare(DataSet ds)
		{
		}
	}

	private DataSet _dataSet;

	private DataView _defaultView;

	internal long _nextRowID;

	internal readonly DataRowCollection _rowCollection;

	internal readonly DataColumnCollection _columnCollection;

	private readonly ConstraintCollection _constraintCollection;

	private int _elementColumnCount;

	internal DataRelationCollection _parentRelationsCollection;

	internal DataRelationCollection _childRelationsCollection;

	internal readonly RecordManager _recordManager;

	internal readonly List<Index> _indexes;

	private List<Index> _shadowIndexes;

	private int _shadowCount;

	internal PropertyCollection _extendedProperties;

	private string _tableName;

	internal string _tableNamespace;

	private string _tablePrefix;

	internal DataExpression _displayExpression;

	internal bool _fNestedInDataset;

	private CultureInfo _culture;

	private bool _cultureUserSet;

	private CompareInfo _compareInfo;

	private CompareOptions _compareFlags;

	private IFormatProvider _formatProvider;

	private StringComparer _hashCodeProvider;

	private bool _caseSensitive;

	private bool _caseSensitiveUserSet;

	internal string _encodedTableName;

	internal DataColumn _xmlText;

	internal DataColumn _colUnique;

	internal decimal _minOccurs;

	internal decimal _maxOccurs;

	internal bool _repeatableElement;

	private object _typeName;

	internal UniqueConstraint _primaryKey;

	internal IndexField[] _primaryIndex;

	private DataColumn[] _delayedSetPrimaryKey;

	private Index _loadIndex;

	private Index _loadIndexwithOriginalAdded;

	private Index _loadIndexwithCurrentDeleted;

	private int _suspendIndexEvents;

	private bool _inDataLoad;

	private bool _schemaLoading;

	private bool _enforceConstraints;

	internal bool _suspendEnforceConstraints;

	/// <summary>Checks whether initialization is in progress. The initialization occurs at run time.</summary>
	protected internal bool fInitInProgress;

	private bool _inLoad;

	internal bool _fInLoadDiffgram;

	private byte _isTypedDataTable;

	private DataRow[] _emptyDataRowArray;

	private PropertyDescriptorCollection _propertyDescriptorCollectionCache;

	private DataRelation[] _nestedParentRelations;

	internal List<DataColumn> _dependentColumns;

	private bool _mergingData;

	private DataRowChangeEventHandler _onRowChangedDelegate;

	private DataRowChangeEventHandler _onRowChangingDelegate;

	private DataRowChangeEventHandler _onRowDeletingDelegate;

	private DataRowChangeEventHandler _onRowDeletedDelegate;

	private DataColumnChangeEventHandler _onColumnChangedDelegate;

	private DataColumnChangeEventHandler _onColumnChangingDelegate;

	private DataTableClearEventHandler _onTableClearingDelegate;

	private DataTableClearEventHandler _onTableClearedDelegate;

	private DataTableNewRowEventHandler _onTableNewRowDelegate;

	private PropertyChangedEventHandler _onPropertyChangingDelegate;

	private readonly DataRowBuilder _rowBuilder;

	internal readonly List<DataView> _delayedViews;

	private readonly List<DataViewListener> _dataViewListeners;

	internal Hashtable _rowDiffId;

	internal readonly ReaderWriterLockSlim _indexesLock;

	internal int _ukColumnPositionForInference;

	private SerializationFormat _remotingFormat;

	private static int s_objectTypeCount;

	private readonly int _objectID;

	/// <summary>Indicates whether string comparisons within the table are case-sensitive.</summary>
	/// <returns>
	///   <see langword="true" /> if the comparison is case-sensitive; otherwise <see langword="false" />. The default is set to the parent <see cref="T:System.Data.DataSet" /> object's <see cref="P:System.Data.DataSet.CaseSensitive" /> property, or <see langword="false" /> if the <see cref="T:System.Data.DataTable" /> was created independently of a <see cref="T:System.Data.DataSet" />.</returns>
	public bool CaseSensitive
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool AreIndexEventsSuspended => false;

	private bool IsTypedDataTable => false;

	internal bool SelfNested => false;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal List<Index> LiveIndexes => null;

	/// <summary>Gets or sets the serialization format.</summary>
	/// <returns>A <see cref="T:System.Data.SerializationFormat" /> enumeration specifying either <see langword="Binary" /> or <see langword="Xml" /> serialization.</returns>
	[DefaultValue(SerializationFormat.Xml)]
	public SerializationFormat RemotingFormat
	{
		get
		{
			return default(SerializationFormat);
		}
		set
		{
		}
	}

	internal int UKColumnPositionForInference
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets the collection of child relations for this <see cref="T:System.Data.DataTable" />.</summary>
	/// <returns>A <see cref="T:System.Data.DataRelationCollection" /> that contains the child relations for the table. An empty collection is returned if no <see cref="T:System.Data.DataRelation" /> objects exist.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public DataRelationCollection ChildRelations => null;

	/// <summary>Gets the collection of columns that belong to this table.</summary>
	/// <returns>A <see cref="T:System.Data.DataColumnCollection" /> that contains the collection of <see cref="T:System.Data.DataColumn" /> objects for the table. An empty collection is returned if no <see cref="T:System.Data.DataColumn" /> objects exist.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public DataColumnCollection Columns => null;

	private CompareInfo CompareInfo => null;

	/// <summary>Gets the collection of constraints maintained by this table.</summary>
	/// <returns>A <see cref="T:System.Data.ConstraintCollection" /> that contains the collection of <see cref="T:System.Data.Constraint" /> objects for the table. An empty collection is returned if no <see cref="T:System.Data.Constraint" /> objects exist.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public ConstraintCollection Constraints => null;

	/// <summary>Gets the <see cref="T:System.Data.DataSet" /> to which this table belongs.</summary>
	/// <returns>The <see cref="T:System.Data.DataSet" /> to which this table belongs.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public DataSet DataSet => null;

	/// <summary>Gets a customized view of the table that may include a filtered view, or a cursor position.</summary>
	/// <returns>The <see cref="T:System.Data.DataView" /> associated with the <see cref="T:System.Data.DataTable" />.</returns>
	[Browsable(false)]
	public DataView DefaultView => null;

	internal string DisplayExpressionInternal => null;

	internal bool EnforceConstraints
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool SuspendEnforceConstraints
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets the collection of customized user information.</summary>
	/// <returns>A <see cref="T:System.Data.PropertyCollection" /> that contains custom user information.</returns>
	[Browsable(false)]
	public PropertyCollection ExtendedProperties => null;

	internal IFormatProvider FormatProvider => null;

	/// <summary>Gets or sets the locale information used to compare strings within the table.</summary>
	/// <returns>A <see cref="T:System.Globalization.CultureInfo" /> that contains data about the user's machine locale. The default is the <see cref="T:System.Data.DataSet" /> object's <see cref="T:System.Globalization.CultureInfo" /> (returned by the <see cref="P:System.Data.DataSet.Locale" /> property) to which the <see cref="T:System.Data.DataTable" /> belongs; if the table doesn't belong to a <see cref="T:System.Data.DataSet" />, the default is the current system <see cref="T:System.Globalization.CultureInfo" />.</returns>
	public CultureInfo Locale
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the initial starting size for this table.</summary>
	/// <returns>The initial starting size in rows of this table. The default is 50.</returns>
	[DefaultValue(50)]
	public int MinimumCapacity
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal int RecordCapacity => 0;

	internal int ElementColumnCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets the collection of parent relations for this <see cref="T:System.Data.DataTable" />.</summary>
	/// <returns>A <see cref="T:System.Data.DataRelationCollection" /> that contains the parent relations for the table. An empty collection is returned if no <see cref="T:System.Data.DataRelation" /> objects exist.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public DataRelationCollection ParentRelations => null;

	internal bool MergingData
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal DataRelation[] NestedParentRelations => null;

	internal bool SchemaLoading => false;

	internal int NestedParentsCount => 0;

	/// <summary>Gets or sets an array of columns that function as primary keys for the data table.</summary>
	/// <returns>An array of <see cref="T:System.Data.DataColumn" /> objects.</returns>
	/// <exception cref="T:System.Data.DataException">The key is a foreign key.</exception>
	[TypeConverter(typeof(PrimaryKeyTypeConverter))]
	public DataColumn[] PrimaryKey
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the collection of rows that belong to this table.</summary>
	/// <returns>A <see cref="T:System.Data.DataRowCollection" /> that contains <see cref="T:System.Data.DataRow" /> objects; otherwise a null value if no <see cref="T:System.Data.DataRow" /> objects exist.</returns>
	[Browsable(false)]
	public DataRowCollection Rows => null;

	/// <summary>Gets or sets the name of the <see cref="T:System.Data.DataTable" />.</summary>
	/// <returns>The name of the <see cref="T:System.Data.DataTable" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <see langword="null" /> or empty string ("") is passed in and this table belongs to a collection.</exception>
	/// <exception cref="T:System.Data.DuplicateNameException">The table belongs to a collection that already has a table with the same name. (Comparison is case-sensitive).</exception>
	[RefreshProperties(RefreshProperties.All)]
	[DefaultValue(null)]
	public string TableName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal string EncodedTableName => null;

	/// <summary>Gets or sets the namespace for the XML representation of the data stored in the <see cref="T:System.Data.DataTable" />.</summary>
	/// <returns>The namespace of the <see cref="T:System.Data.DataTable" />.</returns>
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

	/// <summary>Gets or sets the namespace for the XML representation of the data stored in the <see cref="T:System.Data.DataTable" />.</summary>
	/// <returns>The prefix of the <see cref="T:System.Data.DataTable" />.</returns>
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

	internal DataColumn XmlText
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal decimal MaxOccurs
	{
		get
		{
			return default(decimal);
		}
		set
		{
		}
	}

	internal decimal MinOccurs
	{
		get
		{
			return default(decimal);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets an <see cref="T:System.ComponentModel.ISite" /> for the <see cref="T:System.Data.DataTable" />.</summary>
	/// <returns>An <see cref="T:System.ComponentModel.ISite" /> for the <see cref="T:System.Data.DataTable" />.</returns>
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public override ISite Site
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal bool NeedColumnChangeEvents => false;

	internal XmlQualifiedName TypeName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal Hashtable RowDiffId => null;

	internal int ObjectID => 0;

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataTable" /> class with no arguments.</summary>
	public DataTable()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataTable" /> class with the specified table name.</summary>
	/// <param name="tableName">The name to give the table. If <paramref name="tableName" /> is <see langword="null" /> or an empty string, a default name is given when added to the <see cref="T:System.Data.DataTableCollection" />.</param>
	public DataTable(string tableName)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataTable" /> class with the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and the <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
	/// <param name="info">The data needed to serialize or deserialize an object.</param>
	/// <param name="context">The source and destination of a given serialized stream.</param>
	protected DataTable(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Populates a serialization information object with the data needed to serialize the <see cref="T:System.Data.DataTable" />.</summary>
	/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that holds the serialized data associated with the <see cref="T:System.Data.DataTable" />.</param>
	/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object that contains the source and destination of the serialized stream associated with the <see cref="T:System.Data.DataTable" />.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is a null reference (<see langword="Nothing" /> in Visual Basic).</exception>
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	private void SerializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat)
	{
	}

	internal void DeserializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat)
	{
	}

	internal void SerializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable)
	{
	}

	internal void DeserializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable)
	{
	}

	internal void SerializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints)
	{
	}

	internal void DeserializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints)
	{
	}

	internal void SerializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex)
	{
	}

	internal void DeserializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex)
	{
	}

	internal void SerializeTableData(SerializationInfo info, StreamingContext context, int serIndex)
	{
	}

	internal void DeserializeTableData(SerializationInfo info, StreamingContext context, int serIndex)
	{
	}

	private DataRowState ConvertToRowState(BitArray bitStates, int bitIndex)
	{
		return default(DataRowState);
	}

	internal void GetRowAndColumnErrors(int rowIndex, Hashtable rowErrors, Hashtable colErrors)
	{
	}

	private void ConvertToRowError(int rowIndex, Hashtable rowErrors, Hashtable colErrors)
	{
	}

	internal void RestoreIndexEvents(bool forceReset)
	{
	}

	internal void SuspendIndexEvents()
	{
	}

	internal bool SetCaseSensitiveValue(bool isCaseSensitive, bool userSet, bool resetIndexes)
	{
		return false;
	}

	internal bool ShouldSerializeCaseSensitive()
	{
		return false;
	}

	private void ResetConstraints()
	{
	}

	internal void SetDataSet(DataSet dataSet)
	{
	}

	internal void EnableConstraints()
	{
	}

	internal bool SetLocaleValue(CultureInfo culture, bool userSet, bool resetIndexes)
	{
		return false;
	}

	internal bool ShouldSerializeLocale()
	{
		return false;
	}

	internal void CacheNestedParent()
	{
	}

	private DataRelation[] FindNestedParentRelations()
	{
		return null;
	}

	private string GetInheritedNamespace(List<DataTable> visitedTables)
	{
		return null;
	}

	internal bool IsNamespaceInherited()
	{
		return false;
	}

	internal void CheckCascadingNamespaceConflict(string realNamespace)
	{
	}

	internal void CheckNamespaceValidityForNestedRelations(string realNamespace)
	{
	}

	internal void CheckNamespaceValidityForNestedParentRelations(string ns, DataTable parentTable)
	{
	}

	internal void DoRaiseNamespaceChange()
	{
	}

	internal void SetKeyValues(DataKey key, object[] keyValues, int record)
	{
	}

	internal DataRow FindByIndex(Index ndx, object[] key)
	{
		return null;
	}

	internal DataRow FindMergeTarget(DataRow row, DataKey key, Index ndx)
	{
		return null;
	}

	private void SetMergeRecords(DataRow row, int newRecord, int oldRecord, DataRowAction action)
	{
	}

	internal DataRow MergeRow(DataRow row, DataRow targetRow, bool preserveChanges, Index idxSearch)
	{
		return null;
	}

	/// <summary>Creates a new instance of <see cref="T:System.Data.DataTable" />.</summary>
	/// <returns>The new expression.</returns>
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual DataTable CreateInstance()
	{
		return null;
	}

	/// <summary>Clones the structure of the <see cref="T:System.Data.DataTable" />, including all <see cref="T:System.Data.DataTable" /> schemas and constraints.</summary>
	/// <returns>A new <see cref="T:System.Data.DataTable" /> with the same schema as the current <see cref="T:System.Data.DataTable" />.</returns>
	public virtual DataTable Clone()
	{
		return null;
	}

	internal DataTable Clone(DataSet cloneDS)
	{
		return null;
	}

	private DataTable IncrementalCloneTo(DataTable sourceTable, DataTable targetTable)
	{
		return null;
	}

	private DataTable CloneHierarchy(DataTable sourceTable, DataSet ds, Hashtable visitedMap)
	{
		return null;
	}

	private DataTable CloneTo(DataTable clone, DataSet cloneDS, bool skipExpressionColumns)
	{
		return null;
	}

	internal void AddRow(DataRow row, int proposedID)
	{
	}

	internal void InsertRow(DataRow row, int proposedID, int pos)
	{
	}

	internal void InsertRow(DataRow row, long proposedID, int pos, bool fireEvent)
	{
	}

	internal void CheckNotModifying(DataRow row)
	{
	}

	/// <summary>Clears the <see cref="T:System.Data.DataTable" /> of all data.</summary>
	public void Clear()
	{
	}

	internal void Clear(bool clearAll)
	{
	}

	internal void CascadeAll(DataRow row, DataRowAction action)
	{
	}

	internal void CommitRow(DataRow row)
	{
	}

	internal int Compare(string s1, string s2)
	{
		return 0;
	}

	internal int Compare(string s1, string s2, CompareInfo comparer)
	{
		return 0;
	}

	internal int IndexOf(string s1, string s2)
	{
		return 0;
	}

	internal bool IsSuffix(string s1, string s2)
	{
		return false;
	}

	internal void DeleteRow(DataRow row)
	{
	}

	internal string FormatSortString(IndexField[] indexDesc)
	{
		return null;
	}

	internal void FreeRecord(ref int record)
	{
	}

	internal Index GetIndex(string sort, DataViewRowState recordStates, IFilter rowFilter)
	{
		return null;
	}

	internal Index GetIndex(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter)
	{
		return null;
	}

	/// <summary>For a description of this member, see <see cref="M:System.ComponentModel.IListSource.GetList" />.</summary>
	/// <returns>An <see cref="T:System.Collections.IList" /> that can be bound to a data source from the object.</returns>
	IList IListSource.GetList()
	{
		return null;
	}

	internal List<DataViewListener> GetListeners()
	{
		return null;
	}

	internal int GetSpecialHashCode(string name)
	{
		return 0;
	}

	internal void InsertRow(DataRow row, long proposedID)
	{
	}

	internal int NewRecord()
	{
		return 0;
	}

	internal int NewUninitializedRecord()
	{
		return 0;
	}

	internal int NewRecord(int sourceRecord)
	{
		return 0;
	}

	internal DataRow NewEmptyRow()
	{
		return null;
	}

	private DataRow NewUninitializedRow()
	{
		return null;
	}

	/// <summary>Creates a new <see cref="T:System.Data.DataRow" /> with the same schema as the table.</summary>
	/// <returns>A <see cref="T:System.Data.DataRow" /> with the same schema as the <see cref="T:System.Data.DataTable" />.</returns>
	public DataRow NewRow()
	{
		return null;
	}

	internal DataRow CreateEmptyRow()
	{
		return null;
	}

	private void NewRowCreated(DataRow row)
	{
	}

	internal DataRow NewRow(int record)
	{
		return null;
	}

	/// <summary>Creates a new row from an existing row.</summary>
	/// <param name="builder">A <see cref="T:System.Data.DataRowBuilder" /> object.</param>
	/// <returns>A <see cref="T:System.Data.DataRow" /> derived class.</returns>
	protected virtual DataRow NewRowFromBuilder(DataRowBuilder builder)
	{
		return null;
	}

	/// <summary>Gets the row type.</summary>
	/// <returns>The type of the <see cref="T:System.Data.DataRow" />.</returns>
	protected virtual Type GetRowType()
	{
		return null;
	}

	/// <summary>Returns an array of <see cref="T:System.Data.DataRow" />.</summary>
	/// <param name="size">A <see cref="T:System.Int32" /> value that describes the size of the array.</param>
	/// <returns>The new array.</returns>
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected internal DataRow[] NewRowArray(int size)
	{
		return null;
	}

	/// <summary>Raises the <see cref="E:System.Data.DataTable.ColumnChanging" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Data.DataColumnChangeEventArgs" /> that contains the event data.</param>
	protected internal virtual void OnColumnChanging(DataColumnChangeEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Data.DataTable.ColumnChanged" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Data.DataColumnChangeEventArgs" /> that contains the event data.</param>
	protected internal virtual void OnColumnChanged(DataColumnChangeEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.ComponentModel.INotifyPropertyChanged.PropertyChanged" /> event.</summary>
	/// <param name="pcevent">A <see cref="T:System.ComponentModel.PropertyChangedEventArgs" /> that contains the event data.</param>
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent)
	{
	}

	internal void OnRemoveColumnInternal(DataColumn column)
	{
	}

	/// <summary>Notifies the <see cref="T:System.Data.DataTable" /> that a <see cref="T:System.Data.DataColumn" /> is being removed.</summary>
	/// <param name="column">The <see cref="T:System.Data.DataColumn" /> being removed.</param>
	protected virtual void OnRemoveColumn(DataColumn column)
	{
	}

	private DataRowChangeEventArgs OnRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction)
	{
		return null;
	}

	private DataRowChangeEventArgs OnRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction)
	{
		return null;
	}

	/// <summary>Raises the <see cref="E:System.Data.DataTable.RowChanged" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Data.DataRowChangeEventArgs" /> that contains the event data.</param>
	protected virtual void OnRowChanged(DataRowChangeEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Data.DataTable.RowChanging" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Data.DataRowChangeEventArgs" /> that contains the event data.</param>
	protected virtual void OnRowChanging(DataRowChangeEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Data.DataTable.RowDeleting" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Data.DataRowChangeEventArgs" /> that contains the event data.</param>
	protected virtual void OnRowDeleting(DataRowChangeEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Data.DataTable.RowDeleted" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Data.DataRowChangeEventArgs" /> that contains the event data.</param>
	protected virtual void OnRowDeleted(DataRowChangeEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Data.DataTable.TableCleared" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Data.DataTableClearEventArgs" /> that contains the event data.</param>
	protected virtual void OnTableCleared(DataTableClearEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Data.DataTable.TableClearing" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Data.DataTableClearEventArgs" /> that contains the event data.</param>
	protected virtual void OnTableClearing(DataTableClearEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Data.DataTable.TableNewRow" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Data.DataTableNewRowEventArgs" /> that contains the event data.</param>
	protected virtual void OnTableNewRow(DataTableNewRowEventArgs e)
	{
	}

	internal IndexField[] ParseSortString(string sortString)
	{
		return null;
	}

	internal void RaisePropertyChanging(string name)
	{
	}

	internal void RecordChanged(int record)
	{
	}

	internal void RecordChanged(int[] oldIndex, int[] newIndex)
	{
	}

	internal void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState)
	{
	}

	internal void RecordStateChanged(int record1, DataViewRowState oldState1, DataViewRowState newState1, int record2, DataViewRowState oldState2, DataViewRowState newState2)
	{
	}

	internal int[] RemoveRecordFromIndexes(DataRow row, DataRowVersion version)
	{
		return null;
	}

	internal int[] InsertRecordToIndexes(DataRow row, DataRowVersion version)
	{
		return null;
	}

	internal void SilentlySetValue(DataRow dr, DataColumn dc, DataRowVersion version, object newValue)
	{
	}

	internal void RemoveRow(DataRow row, bool check)
	{
	}

	/// <summary>Resets the <see cref="T:System.Data.DataTable" /> to its original state. Reset removes all data, indexes, relations, and columns of the table. If a DataSet includes a DataTable, the table will still be part of the DataSet after the table is reset.</summary>
	public virtual void Reset()
	{
	}

	internal void ResetIndexes()
	{
	}

	internal void ResetInternalIndexes(DataColumn column)
	{
	}

	internal void RollbackRow(DataRow row)
	{
	}

	private DataRowChangeEventArgs RaiseRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction)
	{
		return null;
	}

	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction)
	{
		return null;
	}

	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction, bool fireEvent)
	{
		return null;
	}

	internal void SetNewRecord(DataRow row, int proposedRecord, DataRowAction action = DataRowAction.Change, bool isInMerge = false, bool fireEvent = true, bool suppressEnsurePropertyChanged = false)
	{
	}

	private void SetNewRecordWorker(DataRow row, int proposedRecord, DataRowAction action, bool isInMerge, bool suppressEnsurePropertyChanged, int position, bool fireEvent, out Exception deferredException)
	{
		deferredException = null;
	}

	internal void SetOldRecord(DataRow row, int proposedRecord)
	{
	}

	private void RestoreShadowIndexes()
	{
	}

	private void SetShadowIndexes()
	{
	}

	internal void ShadowIndexCopy()
	{
	}

	/// <summary>Gets the <see cref="P:System.Data.DataTable.TableName" /> and <see cref="P:System.Data.DataTable.DisplayExpression" />, if there is one as a concatenated string.</summary>
	/// <returns>A string consisting of the <see cref="P:System.Data.DataTable.TableName" /> and the <see cref="P:System.Data.DataTable.DisplayExpression" /> values.</returns>
	public override string ToString()
	{
		return null;
	}

	internal bool UpdatingCurrent(DataRow row, DataRowAction action)
	{
		return false;
	}

	internal DataColumn AddUniqueKey(int position)
	{
		return null;
	}

	internal DataColumn AddUniqueKey()
	{
		return null;
	}

	internal DataColumn AddForeignKey(DataColumn parentKey)
	{
		return null;
	}

	internal void UpdatePropertyDescriptorCollectionCache()
	{
	}

	internal PropertyDescriptorCollection GetPropertyDescriptorCollection(Attribute[] attributes)
	{
		return null;
	}

	/// <summary>Merge the specified <see cref="T:System.Data.DataTable" /> with the current <see cref="T:System.Data.DataTable" />.</summary>
	/// <param name="table">The <see cref="T:System.Data.DataTable" /> to be merged with the current <see cref="T:System.Data.DataTable" />.</param>
	public void Merge(DataTable table)
	{
	}

	/// <summary>Merge the specified <see cref="T:System.Data.DataTable" /> with the current <see langword="DataTable" />, indicating whether to preserve changes and how to handle missing schema in the current <see langword="DataTable" />.</summary>
	/// <param name="table">The <see cref="T:System.Data.DataTable" /> to be merged with the current <see cref="T:System.Data.DataTable" />.</param>
	/// <param name="preserveChanges">
	///   <see langword="true" />, to preserve changes in the current <see cref="T:System.Data.DataTable" />; otherwise <see langword="false" />.</param>
	/// <param name="missingSchemaAction">One of the <see cref="T:System.Data.MissingSchemaAction" /> values.</param>
	public void Merge(DataTable table, bool preserveChanges, MissingSchemaAction missingSchemaAction)
	{
	}

	/// <summary>Writes the current data, and optionally the schema, for the <see cref="T:System.Data.DataTable" /> using the specified <see cref="T:System.Xml.XmlWriter" /> and <see cref="T:System.Data.XmlWriteMode" />. To write the schema, set the value for the <paramref name="mode" /> parameter to <see langword="WriteSchema" />. To save the data for the table and all its descendants, set the <paramref name="writeHierarchy" /> parameter to <see langword="true" />.</summary>
	/// <param name="writer">The <see cref="T:System.Xml.XmlWriter" /> used to write the document.</param>
	/// <param name="mode">One of the <see cref="T:System.Data.XmlWriteMode" /> values.</param>
	/// <param name="writeHierarchy">If <see langword="true" />, write the contents of the current table and all its descendants. If <see langword="false" /> (the default value), write the data for the current table only.</param>
	public void WriteXml(XmlWriter writer, XmlWriteMode mode, bool writeHierarchy)
	{
	}

	private bool CheckForClosureOnExpressions(DataTable dt, bool writeHierarchy)
	{
		return false;
	}

	private bool CheckForClosureOnExpressionTables(List<DataTable> tableList)
	{
		return false;
	}

	/// <summary>Writes the current data structure of the <see cref="T:System.Data.DataTable" /> as an XML schema using the specified <see cref="T:System.Xml.XmlWriter" />. To save the schema for the table and all its descendants, set the <paramref name="writeHierarchy" /> parameter to <see langword="true" />.</summary>
	/// <param name="writer">The <see cref="T:System.Xml.XmlWriter" /> used to write the document.</param>
	/// <param name="writeHierarchy">If <see langword="true" />, write the schema of the current table and all its descendants. If <see langword="false" /> (the default value), write the schema for the current table only.</param>
	public void WriteXmlSchema(XmlWriter writer, bool writeHierarchy)
	{
	}

	private void RestoreConstraint(bool originalEnforceConstraint)
	{
	}

	private bool IsEmptyXml(XmlReader reader)
	{
		return false;
	}

	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving)
	{
		return default(XmlReadMode);
	}

	internal void ReadEndElement(XmlReader reader)
	{
	}

	internal void ReadXDRSchema(XmlReader reader)
	{
	}

	internal bool MoveToElement(XmlReader reader, int depth)
	{
		return false;
	}

	private void ReadXmlDiffgram(XmlReader reader)
	{
	}

	internal void ReadXSDSchema(XmlReader reader, bool denyResolving)
	{
	}

	internal void ReadXmlSchema(XmlReader reader, bool denyResolving)
	{
	}

	private void CreateTableList(DataTable currentTable, List<DataTable> tableList)
	{
	}

	private void CreateRelationList(List<DataTable> tableList, List<DataRelation> relationList)
	{
	}

	/// <summary>This method returns an <see cref="T:System.Xml.Schema.XmlSchemaSet" /> instance containing the Web Services Description Language (WSDL) that describes the <see cref="T:System.Data.DataTable" /> for Web Services.</summary>
	/// <param name="schemaSet">An <see cref="T:System.Xml.Schema.XmlSchemaSet" /> instance.</param>
	/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaSet" /> instance.</returns>
	public static XmlSchemaComplexType GetDataTableSchema(XmlSchemaSet schemaSet)
	{
		return null;
	}

	/// <summary>For a description of this member, see <see cref="M:System.Xml.Serialization.IXmlSerializable.GetSchema" />.</summary>
	/// <returns>An <see cref="T:System.Xml.Schema.XmlSchema" /> that describes the XML representation of the object that is produced by the <see cref="M:System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter)" /> method and consumed by the <see cref="M:System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader)" /> method.</returns>
	XmlSchema IXmlSerializable.GetSchema()
	{
		return null;
	}

	/// <summary>For a description of this member, see <see cref="M:System.Xml.Serialization.IXmlSerializable.GetSchema" />.</summary>
	/// <returns>An <see cref="T:System.Xml.Schema.XmlSchema" /> that describes the XML representation of the object that is produced by the <see cref="M:System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter)" /> method and consumed by the <see cref="M:System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader)" /> method.</returns>
	protected virtual XmlSchema GetSchema()
	{
		return null;
	}

	/// <summary>For a description of this member, see <see cref="M:System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader)" />.</summary>
	/// <param name="reader">An XmlReader.</param>
	void IXmlSerializable.ReadXml(XmlReader reader)
	{
	}

	/// <summary>For a description of this member, see <see cref="M:System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter)" />.</summary>
	/// <param name="writer">An XmlWriter.</param>
	void IXmlSerializable.WriteXml(XmlWriter writer)
	{
	}

	/// <summary>Reads from an XML stream.</summary>
	/// <param name="reader">A <see cref="T:System.Xml.XmlReader" /> object.</param>
	protected virtual void ReadXmlSerializable(XmlReader reader)
	{
	}

	internal void AddDependentColumn(DataColumn expressionColumn)
	{
	}

	internal void RemoveDependentColumn(DataColumn expressionColumn)
	{
	}

	internal void EvaluateExpressions()
	{
	}

	internal void EvaluateExpressions(DataRow row, DataRowAction action, List<DataRow> cachedRows)
	{
	}

	internal void EvaluateExpressions(DataColumn column)
	{
	}

	internal void EvaluateDependentExpressions(DataColumn column)
	{
	}

	internal void EvaluateDependentExpressions(List<DataColumn> columns, DataRow row, DataRowVersion version, List<DataRow> cachedRows)
	{
	}
}
