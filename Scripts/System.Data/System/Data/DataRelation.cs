using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Data;

/// <summary>Represents a parent/child relationship between two <see cref="T:System.Data.DataTable" /> objects.</summary>
[DefaultProperty("RelationName")]
[TypeConverter(typeof(RelationshipConverter))]
public class DataRelation
{
	private DataSet _dataSet;

	internal PropertyCollection _extendedProperties;

	internal string _relationName;

	private DataKey _childKey;

	private DataKey _parentKey;

	private UniqueConstraint _parentKeyConstraint;

	private ForeignKeyConstraint _childKeyConstraint;

	internal string[] _parentColumnNames;

	internal string[] _childColumnNames;

	internal string _parentTableName;

	internal string _childTableName;

	internal string _parentTableNamespace;

	internal string _childTableNamespace;

	internal bool _nested;

	internal bool _createConstraints;

	private bool _checkMultipleNested;

	private static int s_objectTypeCount;

	private readonly int _objectID;

	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanging;

	/// <summary>Gets the child <see cref="T:System.Data.DataColumn" /> objects of this relation.</summary>
	/// <returns>An array of <see cref="T:System.Data.DataColumn" /> objects.</returns>
	public virtual DataColumn[] ChildColumns => null;

	internal DataColumn[] ChildColumnsReference => null;

	internal DataKey ChildKey => default(DataKey);

	/// <summary>Gets the child table of this relation.</summary>
	/// <returns>A <see cref="T:System.Data.DataTable" /> that is the child table of the relation.</returns>
	public virtual DataTable ChildTable => null;

	/// <summary>Gets the <see cref="T:System.Data.DataSet" /> to which the <see cref="T:System.Data.DataRelation" /> belongs.</summary>
	/// <returns>A <see cref="T:System.Data.DataSet" /> to which the <see cref="T:System.Data.DataRelation" /> belongs.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual DataSet DataSet => null;

	internal string[] ParentColumnNames => null;

	internal string[] ChildColumnNames => null;

	/// <summary>Gets an array of <see cref="T:System.Data.DataColumn" /> objects that are the parent columns of this <see cref="T:System.Data.DataRelation" />.</summary>
	/// <returns>An array of <see cref="T:System.Data.DataColumn" /> objects that are the parent columns of this <see cref="T:System.Data.DataRelation" />.</returns>
	public virtual DataColumn[] ParentColumns => null;

	internal DataColumn[] ParentColumnsReference => null;

	internal DataKey ParentKey => default(DataKey);

	/// <summary>Gets the parent <see cref="T:System.Data.DataTable" /> of this <see cref="T:System.Data.DataRelation" />.</summary>
	/// <returns>A <see cref="T:System.Data.DataTable" /> that is the parent table of this relation.</returns>
	public virtual DataTable ParentTable => null;

	/// <summary>Gets or sets the name used to retrieve a <see cref="T:System.Data.DataRelation" /> from the <see cref="T:System.Data.DataRelationCollection" />.</summary>
	/// <returns>The name of the a <see cref="T:System.Data.DataRelation" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <see langword="null" /> or empty string ("") was passed into a <see cref="T:System.Data.DataColumn" /> that is a <see cref="T:System.Data.DataRelation" />.</exception>
	/// <exception cref="T:System.Data.DuplicateNameException">The <see cref="T:System.Data.DataRelation" /> belongs to a collection that already contains a <see cref="T:System.Data.DataRelation" /> with the same name.</exception>
	[DefaultValue(null)]
	public virtual string RelationName => null;

	/// <summary>Gets or sets a value that indicates whether <see cref="T:System.Data.DataRelation" /> objects are nested.</summary>
	/// <returns>
	///   <see langword="true" />, if <see cref="T:System.Data.DataRelation" /> objects are nested; otherwise, <see langword="false" />.</returns>
	[DefaultValue(false)]
	public virtual bool Nested
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets the <see cref="T:System.Data.UniqueConstraint" /> that guarantees that values in the parent column of a <see cref="T:System.Data.DataRelation" /> are unique.</summary>
	/// <returns>A <see cref="T:System.Data.UniqueConstraint" /> that makes sure that values in a parent column are unique.</returns>
	public virtual UniqueConstraint ParentKeyConstraint => null;

	/// <summary>Gets the <see cref="T:System.Data.ForeignKeyConstraint" /> for the relation.</summary>
	/// <returns>A <see langword="ForeignKeyConstraint" />.</returns>
	public virtual ForeignKeyConstraint ChildKeyConstraint => null;

	/// <summary>Gets the collection that stores customized properties.</summary>
	/// <returns>A <see cref="T:System.Data.PropertyCollection" /> that contains customized properties.</returns>
	[Browsable(false)]
	public PropertyCollection ExtendedProperties => null;

	internal bool CheckMultipleNested
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal int ObjectID => 0;

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataRelation" /> class using the specified name, parent and child <see cref="T:System.Data.DataColumn" /> objects, and a value that indicates whether to create constraints.</summary>
	/// <param name="relationName">The name of the relation. If <see langword="null" /> or an empty string (""), a default name will be given when the created object is added to the <see cref="T:System.Data.DataRelationCollection" />.</param>
	/// <param name="parentColumn">The parent <see cref="T:System.Data.DataColumn" /> in the relation.</param>
	/// <param name="childColumn">The child <see cref="T:System.Data.DataColumn" /> in the relation.</param>
	/// <param name="createConstraints">A value that indicates whether constraints are created. <see langword="true" />, if constraints are created. Otherwise, <see langword="false" />.</param>
	/// <exception cref="T:System.ArgumentNullException">One or both of the <see cref="T:System.Data.DataColumn" /> objects contains <see langword="null" />.</exception>
	/// <exception cref="T:System.Data.InvalidConstraintException">The columns have different data types  
	///  -Or-  
	///  The tables do not belong to the same <see cref="T:System.Data.DataSet" />.</exception>
	public DataRelation(string relationName, DataColumn parentColumn, DataColumn childColumn, bool createConstraints)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataRelation" /> class using the specified <see cref="T:System.Data.DataRelation" /> name and matched arrays of parent and child <see cref="T:System.Data.DataColumn" /> objects.</summary>
	/// <param name="relationName">The name of the relation. If <see langword="null" /> or an empty string (""), a default name will be given when the created object is added to the <see cref="T:System.Data.DataRelationCollection" />.</param>
	/// <param name="parentColumns">An array of parent <see cref="T:System.Data.DataColumn" /> objects.</param>
	/// <param name="childColumns">An array of child <see cref="T:System.Data.DataColumn" /> objects.</param>
	/// <exception cref="T:System.ArgumentNullException">One or both of the <see cref="T:System.Data.DataColumn" /> objects contains <see langword="null" />.</exception>
	/// <exception cref="T:System.Data.InvalidConstraintException">The <see cref="T:System.Data.DataColumn" /> objects have different data types  
	///  -Or-  
	///  One or both of the arrays are not composed of distinct columns from the same table.  
	///  -Or-  
	///  The tables do not belong to the same <see cref="T:System.Data.DataSet" />.</exception>
	public DataRelation(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataRelation" /> class using the specified name, matched arrays of parent and child <see cref="T:System.Data.DataColumn" /> objects, and value that indicates whether to create constraints.</summary>
	/// <param name="relationName">The name of the relation. If <see langword="null" /> or an empty string (""), a default name will be given when the created object is added to the <see cref="T:System.Data.DataRelationCollection" />.</param>
	/// <param name="parentColumns">An array of parent <see cref="T:System.Data.DataColumn" /> objects.</param>
	/// <param name="childColumns">An array of child <see cref="T:System.Data.DataColumn" /> objects.</param>
	/// <param name="createConstraints">A value that indicates whether to create constraints. <see langword="true" />, if constraints are created. Otherwise, <see langword="false" />.</param>
	/// <exception cref="T:System.ArgumentNullException">One or both of the <see cref="T:System.Data.DataColumn" /> objects is <see langword="null" />.</exception>
	/// <exception cref="T:System.Data.InvalidConstraintException">The columns have different data types  
	///  -Or-  
	///  The tables do not belong to the same <see cref="T:System.Data.DataSet" />.</exception>
	public DataRelation(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints)
	{
	}

	/// <summary>This constructor is provided for design time support in the Visual Studio environment.</summary>
	/// <param name="relationName">The name of the relation. If <see langword="null" /> or an empty string (""), a default name will be given when the created object is added to the <see cref="T:System.Data.DataRelationCollection" />.</param>
	/// <param name="parentTableName">The name of the <see cref="T:System.Data.DataTable" /> that is the parent table of the relation.</param>
	/// <param name="childTableName">The name of the <see cref="T:System.Data.DataTable" /> that is the child table of the relation.</param>
	/// <param name="parentColumnNames">An array of <see cref="T:System.Data.DataColumn" /> object names in the parent <see cref="T:System.Data.DataTable" /> of the relation.</param>
	/// <param name="childColumnNames">An array of <see cref="T:System.Data.DataColumn" /> object names in the child <see cref="T:System.Data.DataTable" /> of the relation.</param>
	/// <param name="nested">A value that indicates whether relationships are nested.</param>
	[Browsable(false)]
	public DataRelation(string relationName, string parentTableName, string childTableName, string[] parentColumnNames, string[] childColumnNames, bool nested)
	{
	}

	/// <summary>This constructor is provided for design time support in the Visual Studio environment.</summary>
	/// <param name="relationName">The name of the <see cref="T:System.Data.DataRelation" />. If <see langword="null" /> or an empty string (""), a default name will be given when the created object is added to the <see cref="T:System.Data.DataRelationCollection" />.</param>
	/// <param name="parentTableName">The name of the <see cref="T:System.Data.DataTable" /> that is the parent table of the relation.</param>
	/// <param name="parentTableNamespace">The name of the parent table namespace.</param>
	/// <param name="childTableName">The name of the <see cref="T:System.Data.DataTable" /> that is the child table of the relation.</param>
	/// <param name="childTableNamespace">The name of the child table namespace.</param>
	/// <param name="parentColumnNames">An array of <see cref="T:System.Data.DataColumn" /> object names in the parent <see cref="T:System.Data.DataTable" /> of the relation.</param>
	/// <param name="childColumnNames">An array of <see cref="T:System.Data.DataColumn" /> object names in the child <see cref="T:System.Data.DataTable" /> of the relation.</param>
	/// <param name="nested">A value that indicates whether relationships are nested.</param>
	[Browsable(false)]
	public DataRelation(string relationName, string parentTableName, string parentTableNamespace, string childTableName, string childTableNamespace, string[] parentColumnNames, string[] childColumnNames, bool nested)
	{
	}

	private static bool IsKeyNull(object[] values)
	{
		return false;
	}

	internal static DataRow[] GetChildRows(DataKey parentKey, DataKey childKey, DataRow parentRow, DataRowVersion version)
	{
		return null;
	}

	internal static DataRow[] GetParentRows(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version)
	{
		return null;
	}

	internal static DataRow GetParentRow(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version)
	{
		return null;
	}

	internal void SetDataSet(DataSet dataSet)
	{
	}

	internal void CheckNamespaceValidityForNestedRelations(string ns)
	{
	}

	internal void CheckNestedRelations()
	{
	}

	internal void SetParentKeyConstraint(UniqueConstraint value)
	{
	}

	internal void SetChildKeyConstraint(ForeignKeyConstraint value)
	{
	}

	internal void CheckState()
	{
	}

	/// <summary>This method supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
	/// <exception cref="T:System.Data.DataException">The parent and child tables belong to different <see cref="T:System.Data.DataSet" /> objects.  
	///  -Or-  
	///  One or more pairs of parent and child <see cref="T:System.Data.DataColumn" /> objects have mismatched data types.  
	///  -Or-  
	///  The parent and child <see cref="T:System.Data.DataColumn" /> objects are identical.</exception>
	protected void CheckStateForProperty()
	{
	}

	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints)
	{
	}

	internal DataRelation Clone(DataSet destination)
	{
		return null;
	}

	/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
	/// <param name="pcevent">Parameter reference.</param>
	protected internal void OnPropertyChanging(PropertyChangedEventArgs pcevent)
	{
	}

	/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
	/// <param name="name">Parameter reference.</param>
	protected internal void RaisePropertyChanging(string name)
	{
	}

	/// <summary>Gets the <see cref="P:System.Data.DataRelation.RelationName" />, if one exists.</summary>
	/// <returns>The value of the <see cref="P:System.Data.DataRelation.RelationName" /> property.</returns>
	public override string ToString()
	{
		return null;
	}

	internal void ValidateMultipleNestedRelations()
	{
	}

	private bool IsAutoGenerated(DataColumn col)
	{
		return false;
	}
}
