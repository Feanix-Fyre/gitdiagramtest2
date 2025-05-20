using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data;

/// <summary>Represents an in-memory cache of data.</summary>
[Serializable]
[DefaultProperty("DataSetName")]
[XmlSchemaProvider("GetDataSetSchema")]
[ToolboxItem("Microsoft.VSDesigner.Data.VS.DataSetToolboxItem, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[XmlRoot("DataSet")]
public class DataSet : MarshalByValueComponent, IListSource, IXmlSerializable, ISerializable
{
	private DataViewManager _defaultViewManager;

	private readonly DataTableCollection _tableCollection;

	private readonly DataRelationCollection _relationCollection;

	internal PropertyCollection _extendedProperties;

	private string _dataSetName;

	private string _datasetPrefix;

	internal string _namespaceURI;

	private bool _enforceConstraints;

	private bool _caseSensitive;

	private CultureInfo _culture;

	private bool _cultureUserSet;

	internal bool _fInReadXml;

	internal bool _fInLoadDiffgram;

	internal bool _fTopLevelTable;

	internal bool _fInitInProgress;

	internal bool _fEnableCascading;

	internal bool _fIsSchemaLoading;

	internal string _mainTableName;

	private SerializationFormat _remotingFormat;

	private object _defaultViewManagerLock;

	private static int s_objectTypeCount;

	private readonly int _objectID;

	private static XmlSchemaComplexType s_schemaTypeForWSDL;

	internal bool _useDataSetSchemaOnly;

	internal bool _udtIsWrapped;

	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanging;

	[CompilerGenerated]
	private MergeFailedEventHandler MergeFailed;

	[CompilerGenerated]
	private DataRowCreatedEventHandler DataRowCreated;

	[CompilerGenerated]
	private DataSetClearEventhandler ClearFunctionCalled;

	/// <summary>Gets or sets a <see cref="T:System.Data.SerializationFormat" /> for the <see cref="T:System.Data.DataSet" /> used during remoting.</summary>
	/// <returns>A <see cref="T:System.Data.SerializationFormat" /> object.</returns>
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

	/// <summary>Gets or sets a <see cref="T:System.Data.SchemaSerializationMode" /> for a <see cref="T:System.Data.DataSet" />.</summary>
	/// <returns>A <see cref="T:System.Data.SchemaSerializationMode" /> for a <see cref="T:System.Data.DataSet" />.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual SchemaSerializationMode SchemaSerializationMode => default(SchemaSerializationMode);

	/// <summary>Gets or sets a value indicating whether string comparisons within <see cref="T:System.Data.DataTable" /> objects are case-sensitive.</summary>
	/// <returns>
	///   <see langword="true" /> if string comparisons are case-sensitive; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[DefaultValue(false)]
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

	/// <summary>Gets a custom view of the data contained in the <see cref="T:System.Data.DataSet" /> to allow filtering, searching, and navigating using a custom <see cref="T:System.Data.DataViewManager" />.</summary>
	/// <returns>A <see cref="T:System.Data.DataViewManager" /> object.</returns>
	[Browsable(false)]
	public DataViewManager DefaultViewManager => null;

	/// <summary>Gets or sets a value indicating whether constraint rules are followed when attempting any update operation.</summary>
	/// <returns>
	///   <see langword="true" /> if rules are enforced; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	/// <exception cref="T:System.Data.ConstraintException">One or more constraints cannot be enforced.</exception>
	[DefaultValue(true)]
	public bool EnforceConstraints
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the name of the current <see cref="T:System.Data.DataSet" />.</summary>
	/// <returns>The name of the <see cref="T:System.Data.DataSet" />.</returns>
	[DefaultValue(null)]
	public string DataSetName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the namespace of the <see cref="T:System.Data.DataSet" />.</summary>
	/// <returns>The namespace of the <see cref="T:System.Data.DataSet" />.</returns>
	/// <exception cref="T:System.ArgumentException">The namespace already has data.</exception>
	[DefaultValue(null)]
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

	/// <summary>Gets or sets an XML prefix that aliases the namespace of the <see cref="T:System.Data.DataSet" />.</summary>
	/// <returns>The XML prefix for the <see cref="T:System.Data.DataSet" /> namespace.</returns>
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

	/// <summary>Gets the collection of customized user information associated with the <see langword="DataSet" />.</summary>
	/// <returns>A <see cref="T:System.Data.PropertyCollection" /> with all custom user information.</returns>
	[Browsable(false)]
	public PropertyCollection ExtendedProperties => null;

	/// <summary>Gets or sets the locale information used to compare strings within the table.</summary>
	/// <returns>A <see cref="T:System.Globalization.CultureInfo" /> that contains data about the user's machine locale. The default is <see langword="null" />.</returns>
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

	/// <summary>Gets or sets an <see cref="T:System.ComponentModel.ISite" /> for the <see cref="T:System.Data.DataSet" />.</summary>
	/// <returns>An <see cref="T:System.ComponentModel.ISite" /> for the <see cref="T:System.Data.DataSet" />.</returns>
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

	/// <summary>Gets the collection of relations that link tables and allow navigation from parent tables to child tables.</summary>
	/// <returns>A <see cref="T:System.Data.DataRelationCollection" /> that contains a collection of <see cref="T:System.Data.DataRelation" /> objects. An empty collection is returned if no <see cref="T:System.Data.DataRelation" /> objects exist.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public DataRelationCollection Relations => null;

	/// <summary>Gets the collection of tables contained in the <see cref="T:System.Data.DataSet" />.</summary>
	/// <returns>The <see cref="T:System.Data.DataTableCollection" /> contained by this <see cref="T:System.Data.DataSet" />. An empty collection is returned if no <see cref="T:System.Data.DataTable" /> objects exist.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public DataTableCollection Tables => null;

	internal string MainTableName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal int ObjectID => 0;

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataSet" /> class.</summary>
	public DataSet()
	{
	}

	/// <summary>Initializes a new instance of a <see cref="T:System.Data.DataSet" /> class with the given name.</summary>
	/// <param name="dataSetName">The name of the <see cref="T:System.Data.DataSet" />.</param>
	public DataSet(string dataSetName)
	{
	}

	/// <summary>Initializes a new instance of a <see cref="T:System.Data.DataSet" /> class that has the given serialization information and context.</summary>
	/// <param name="info">The data needed to serialize or deserialize an object.</param>
	/// <param name="context">The source and destination of a given serialized stream.</param>
	protected DataSet(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataSet" /> class.</summary>
	/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object.</param>
	/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> object.</param>
	/// <param name="ConstructSchema">The boolean value.</param>
	protected DataSet(SerializationInfo info, StreamingContext context, bool ConstructSchema)
	{
	}

	/// <summary>Populates a serialization information object with the data needed to serialize the <see cref="T:System.Data.DataSet" />.</summary>
	/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized data associated with the <see cref="T:System.Data.DataSet" />.</param>
	/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains the source and destination of the serialized stream associated with the <see cref="T:System.Data.DataSet" />.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is <see langword="null" />.</exception>
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Deserialize all of the tables data of the DataSet from the binary or XML stream.</summary>
	protected virtual void InitializeDerivedDataSet()
	{
	}

	private void SerializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat)
	{
	}

	internal void DeserializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode)
	{
	}

	private void DeserializeDataSetSchema(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode)
	{
	}

	private void DeserializeDataSetData(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat)
	{
	}

	private void SerializeDataSetProperties(SerializationInfo info, StreamingContext context)
	{
	}

	private void DeserializeDataSetProperties(SerializationInfo info, StreamingContext context)
	{
	}

	private void SerializeRelations(SerializationInfo info, StreamingContext context)
	{
	}

	private void DeserializeRelations(SerializationInfo info, StreamingContext context)
	{
	}

	internal void FailedEnableConstraints()
	{
	}

	internal void RestoreEnforceConstraints(bool value)
	{
	}

	internal void EnableConstraints()
	{
	}

	internal void SetLocaleValue(CultureInfo value, bool userSet)
	{
	}

	internal bool ShouldSerializeLocale()
	{
		return false;
	}

	/// <summary>Clears the <see cref="T:System.Data.DataSet" /> of any data by removing all rows in all tables.</summary>
	public void Clear()
	{
	}

	/// <summary>Copies the structure of the <see cref="T:System.Data.DataSet" />, including all <see cref="T:System.Data.DataTable" /> schemas, relations, and constraints. Does not copy any data.</summary>
	/// <returns>A new <see cref="T:System.Data.DataSet" /> with the same schema as the current <see cref="T:System.Data.DataSet" />, but none of the data.</returns>
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual DataSet Clone()
	{
		return null;
	}

	internal int EstimatedXmlStringSize()
	{
		return 0;
	}

	/// <summary>For a description of this member, see <see cref="M:System.ComponentModel.IListSource.GetList" />.</summary>
	/// <returns>For a description of this member, see <see cref="M:System.ComponentModel.IListSource.GetList" />.</returns>
	IList IListSource.GetList()
	{
		return null;
	}

	internal string GetRemotingDiffGram(DataTable table)
	{
		return null;
	}

	internal string GetXmlSchemaForRemoting(DataTable table)
	{
		return null;
	}

	/// <summary>Reads the XML schema from the specified <see cref="T:System.Xml.XmlReader" /> into the <see cref="T:System.Data.DataSet" />.</summary>
	/// <param name="reader">The <see cref="T:System.Xml.XmlReader" /> from which to read.</param>
	public void ReadXmlSchema(XmlReader reader)
	{
	}

	internal void ReadXmlSchema(XmlReader reader, bool denyResolving)
	{
	}

	internal bool MoveToElement(XmlReader reader, int depth)
	{
		return false;
	}

	private static void MoveToElement(XmlReader reader)
	{
	}

	internal void ReadEndElement(XmlReader reader)
	{
	}

	internal void ReadXSDSchema(XmlReader reader, bool denyResolving)
	{
	}

	internal void ReadXDRSchema(XmlReader reader)
	{
	}

	private void WriteXmlSchema(XmlWriter writer, SchemaFormat schemaFormat, Converter<Type, string> multipleTargetConverter)
	{
	}

	/// <summary>Reads XML schema and data into the <see cref="T:System.Data.DataSet" /> using the specified <see cref="T:System.Xml.XmlReader" />.</summary>
	/// <param name="reader">The <see cref="T:System.Xml.XmlReader" /> from which to read.</param>
	/// <returns>The <see langword="XmlReadMode" /> used to read the data.</returns>
	public XmlReadMode ReadXml(XmlReader reader)
	{
		return default(XmlReadMode);
	}

	internal XmlReadMode ReadXml(XmlReader reader, bool denyResolving)
	{
		return default(XmlReadMode);
	}

	internal void InferSchema(XmlDocument xdoc, string[] excludedNamespaces, XmlReadMode mode)
	{
	}

	private bool IsEmpty()
	{
		return false;
	}

	private void ReadXmlDiffgram(XmlReader reader)
	{
	}

	/// <summary>Reads XML schema and data into the <see cref="T:System.Data.DataSet" /> using the specified <see cref="T:System.Xml.XmlReader" /> and <see cref="T:System.Data.XmlReadMode" />.</summary>
	/// <param name="reader">The <see cref="T:System.Xml.XmlReader" /> from which to read.</param>
	/// <param name="mode">One of the <see cref="T:System.Data.XmlReadMode" /> values.</param>
	/// <returns>The <see langword="XmlReadMode" /> used to read the data.</returns>
	public XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode)
	{
		return default(XmlReadMode);
	}

	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving)
	{
		return default(XmlReadMode);
	}

	/// <summary>Writes the current data, and optionally the schema, for the <see cref="T:System.Data.DataSet" /> using the specified <see cref="T:System.Xml.XmlWriter" /> and <see cref="T:System.Data.XmlWriteMode" />. To write the schema, set the value for the <paramref name="mode" /> parameter to <see langword="WriteSchema" />.</summary>
	/// <param name="writer">The <see cref="T:System.Xml.XmlWriter" /> with which to write.</param>
	/// <param name="mode">One of the <see cref="T:System.Data.XmlWriteMode" /> values.</param>
	public void WriteXml(XmlWriter writer, XmlWriteMode mode)
	{
	}

	/// <summary>Merges a specified <see cref="T:System.Data.DataSet" /> and its schema into the current <see langword="DataSet" />.</summary>
	/// <param name="dataSet">The <see langword="DataSet" /> whose data and schema will be merged.</param>
	/// <exception cref="T:System.Data.ConstraintException">One or more constraints cannot be enabled.</exception>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="dataSet" /> is <see langword="null" />.</exception>
	public void Merge(DataSet dataSet)
	{
	}

	/// <summary>Merges a specified <see cref="T:System.Data.DataSet" /> and its schema with the current <see langword="DataSet" />, preserving or discarding changes in the current <see langword="DataSet" /> and handling an incompatible schema according to the given arguments.</summary>
	/// <param name="dataSet">The <see langword="DataSet" /> whose data and schema will be merged.</param>
	/// <param name="preserveChanges">
	///   <see langword="true" /> to preserve changes in the current <see langword="DataSet" />; otherwise, <see langword="false" />.</param>
	/// <param name="missingSchemaAction">One of the <see cref="T:System.Data.MissingSchemaAction" /> values.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="dataSet" /> is <see langword="null" />.</exception>
	public void Merge(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction)
	{
	}

	/// <summary>Raises the <see cref="M:System.Data.DataSet.OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs)" /> event.</summary>
	/// <param name="pcevent">A <see cref="T:System.ComponentModel.PropertyChangedEventArgs" /> that contains the event data.</param>
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent)
	{
	}

	internal void OnMergeFailed(MergeFailedEventArgs mfevent)
	{
	}

	internal void RaiseMergeFailed(DataTable table, string conflict, MissingSchemaAction missingSchemaAction)
	{
	}

	internal void OnDataRowCreated(DataRow row)
	{
	}

	internal void OnClearFunctionCalled(DataTable table)
	{
	}

	/// <summary>Occurs when a <see cref="T:System.Data.DataTable" /> is removed from a <see cref="T:System.Data.DataSet" />.</summary>
	/// <param name="table">The <see cref="T:System.Data.DataTable" /> being removed.</param>
	protected internal virtual void OnRemoveTable(DataTable table)
	{
	}

	internal void OnRemovedTable(DataTable table)
	{
	}

	/// <summary>Occurs when a <see cref="T:System.Data.DataRelation" /> object is removed from a <see cref="T:System.Data.DataTable" />.</summary>
	/// <param name="relation">The <see cref="T:System.Data.DataRelation" /> being removed.</param>
	protected virtual void OnRemoveRelation(DataRelation relation)
	{
	}

	internal void OnRemoveRelationHack(DataRelation relation)
	{
	}

	/// <summary>Sends a notification that the specified <see cref="T:System.Data.DataSet" /> property is about to change.</summary>
	/// <param name="name">The name of the property that is about to change.</param>
	protected internal void RaisePropertyChanging(string name)
	{
	}

	internal DataTable[] TopLevelTables()
	{
		return null;
	}

	internal DataTable[] TopLevelTables(bool forSchema)
	{
		return null;
	}

	/// <summary>Clears all tables and removes all relations, foreign constraints, and tables from the <see cref="T:System.Data.DataSet" />. Subclasses should override <see cref="M:System.Data.DataSet.Reset" /> to restore a <see cref="T:System.Data.DataSet" /> to its original state.</summary>
	public virtual void Reset()
	{
	}

	internal bool ValidateCaseConstraint()
	{
		return false;
	}

	internal bool ValidateLocaleConstraint()
	{
		return false;
	}

	internal DataTable FindTable(DataTable baseTable, PropertyDescriptor[] props, int propStart)
	{
		return null;
	}

	/// <summary>Ignores attributes and returns an empty DataSet.</summary>
	/// <param name="reader">The specified XML reader.</param>
	protected virtual void ReadXmlSerializable(XmlReader reader)
	{
	}

	/// <summary>Gets a copy of <see cref="T:System.Xml.Schema.XmlSchemaSet" /> for the DataSet.</summary>
	/// <param name="schemaSet">The specified schema set.</param>
	/// <returns>A copy of <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</returns>
	public static XmlSchemaComplexType GetDataSetSchema(XmlSchemaSet schemaSet)
	{
		return null;
	}

	/// <summary>For a description of this member, see <see cref="M:System.Xml.Serialization.IXmlSerializable.GetSchema" />.</summary>
	/// <returns>For a description of this member, see <see cref="M:System.Xml.Serialization.IXmlSerializable.GetSchema" />.</returns>
	XmlSchema IXmlSerializable.GetSchema()
	{
		return null;
	}

	/// <summary>For a description of this member, see <see cref="M:System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader)" />.</summary>
	/// <param name="reader">A <see cref="T:System.Xml.XmlReader" />.</param>
	void IXmlSerializable.ReadXml(XmlReader reader)
	{
	}

	/// <summary>For a description of this member, see <see cref="M:System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter)" />.</summary>
	/// <param name="writer">A <see cref="T:System.Xml.XmlWriter" />.</param>
	void IXmlSerializable.WriteXml(XmlWriter writer)
	{
	}
}
