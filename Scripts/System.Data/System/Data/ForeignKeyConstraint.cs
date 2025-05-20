using System.ComponentModel;

namespace System.Data;

/// <summary>Represents an action restriction enforced on a set of columns in a primary key/foreign key relationship when a value or row is either deleted or updated.</summary>
[DefaultProperty("ConstraintName")]
public class ForeignKeyConstraint : Constraint
{
	internal Rule _deleteRule;

	internal Rule _updateRule;

	internal AcceptRejectRule _acceptRejectRule;

	private DataKey _childKey;

	private DataKey _parentKey;

	internal string _constraintName;

	internal string[] _parentColumnNames;

	internal string[] _childColumnNames;

	internal string _parentTableName;

	internal DataKey ChildKey => default(DataKey);

	/// <summary>Gets the child columns of this constraint.</summary>
	/// <returns>An array of <see cref="T:System.Data.DataColumn" /> objects that are the child columns of the constraint.</returns>
	[ReadOnly(true)]
	public virtual DataColumn[] Columns => null;

	/// <summary>Gets the child table of this constraint.</summary>
	/// <returns>A <see cref="T:System.Data.DataTable" /> that is the child table in the constraint.</returns>
	[ReadOnly(true)]
	public override DataTable Table => null;

	internal string[] ParentColumnNames => null;

	internal string[] ChildColumnNames => null;

	/// <summary>Indicates the action that should take place across this constraint when <see cref="M:System.Data.DataTable.AcceptChanges" /> is invoked.</summary>
	/// <returns>One of the <see cref="T:System.Data.AcceptRejectRule" /> values. Possible values include <see langword="None" />, and <see langword="Cascade" />. The default is <see langword="None" />.</returns>
	[DefaultValue(AcceptRejectRule.None)]
	public virtual AcceptRejectRule AcceptRejectRule
	{
		get
		{
			return default(AcceptRejectRule);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the action that occurs across this constraint when a row is deleted.</summary>
	/// <returns>One of the <see cref="T:System.Data.Rule" /> values. The default is <see langword="Cascade" />.</returns>
	[DefaultValue(Rule.Cascade)]
	public virtual Rule DeleteRule
	{
		get
		{
			return default(Rule);
		}
		set
		{
		}
	}

	/// <summary>The parent columns of this constraint.</summary>
	/// <returns>An array of <see cref="T:System.Data.DataColumn" /> objects that are the parent columns of the constraint.</returns>
	[ReadOnly(true)]
	public virtual DataColumn[] RelatedColumns => null;

	internal DataColumn[] RelatedColumnsReference => null;

	internal DataKey ParentKey => default(DataKey);

	/// <summary>Gets the parent table of this constraint.</summary>
	/// <returns>The parent <see cref="T:System.Data.DataTable" /> of this constraint.</returns>
	[ReadOnly(true)]
	public virtual DataTable RelatedTable => null;

	/// <summary>Gets or sets the action that occurs across this constraint on when a row is updated.</summary>
	/// <returns>One of the <see cref="T:System.Data.Rule" /> values. The default is <see langword="Cascade" />.</returns>
	[DefaultValue(Rule.Cascade)]
	public virtual Rule UpdateRule
	{
		get
		{
			return default(Rule);
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.ForeignKeyConstraint" /> class with the specified arrays of parent and child <see cref="T:System.Data.DataColumn" /> objects.</summary>
	/// <param name="parentColumns">An array of parent <see cref="T:System.Data.DataColumn" /> in the constraint.</param>
	/// <param name="childColumns">An array of child <see cref="T:System.Data.DataColumn" /> in the constraint.</param>
	/// <exception cref="T:System.ArgumentNullException">One or both of the columns is <see langword="null" />.</exception>
	/// <exception cref="T:System.Data.InvalidConstraintException">The columns have different data types.  
	///  -Or -  
	///  The tables don't belong to the same <see cref="T:System.Data.DataSet" />.</exception>
	public ForeignKeyConstraint(DataColumn[] parentColumns, DataColumn[] childColumns)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.ForeignKeyConstraint" /> class with the specified name, and arrays of parent and child <see cref="T:System.Data.DataColumn" /> objects.</summary>
	/// <param name="constraintName">The name of the <see cref="T:System.Data.ForeignKeyConstraint" />. If <see langword="null" /> or empty string, a default name will be given when added to the constraints collection.</param>
	/// <param name="parentColumns">An array of parent <see cref="T:System.Data.DataColumn" /> in the constraint.</param>
	/// <param name="childColumns">An array of child <see cref="T:System.Data.DataColumn" /> in the constraint.</param>
	/// <exception cref="T:System.ArgumentNullException">One or both of the columns is <see langword="null" />.</exception>
	/// <exception cref="T:System.Data.InvalidConstraintException">The columns have different data types.  
	///  -Or -  
	///  The tables don't belong to the same <see cref="T:System.Data.DataSet" />.</exception>
	public ForeignKeyConstraint(string constraintName, DataColumn[] parentColumns, DataColumn[] childColumns)
	{
	}

	/// <summary>This constructor is provided for design time support in the Visual Studio  environment. <see cref="T:System.Data.ForeignKeyConstraint" /> objects created by using this constructor must then be added to the collection via <see cref="M:System.Data.ConstraintCollection.AddRange(System.Data.Constraint[])" />. Tables and columns with the specified names must exist at the time the method is called, or if <see cref="M:System.Data.DataTable.BeginInit" /> has been called prior to calling this constructor, the tables and columns with the specified names must exist at the time that <see cref="M:System.Data.DataTable.EndInit" /> is called.</summary>
	/// <param name="constraintName">The name of the constraint.</param>
	/// <param name="parentTableName">The name of the parent <see cref="T:System.Data.DataTable" /> that contains parent <see cref="T:System.Data.DataColumn" /> objects in the constraint.</param>
	/// <param name="parentColumnNames">An array of the names of parent <see cref="T:System.Data.DataColumn" /> objects in the constraint.</param>
	/// <param name="childColumnNames">An array of the names of child <see cref="T:System.Data.DataColumn" /> objects in the constraint.</param>
	/// <param name="acceptRejectRule">One of the <see cref="T:System.Data.AcceptRejectRule" /> values. Possible values include <see langword="None" />, <see langword="Cascade" />, and <see langword="Default" />.</param>
	/// <param name="deleteRule">One of the <see cref="T:System.Data.Rule" /> values to use when a row is deleted. The default is <see langword="Cascade" />. Possible values include: <see langword="None" />, <see langword="Cascade" />, <see langword="SetNull" />, <see langword="SetDefault" />, and <see langword="Default" />.</param>
	/// <param name="updateRule">One of the <see cref="T:System.Data.Rule" /> values to use when a row is updated. The default is <see langword="Cascade" />. Possible values include: <see langword="None" />, <see langword="Cascade" />, <see langword="SetNull" />, <see langword="SetDefault" />, and <see langword="Default" />.</param>
	/// <exception cref="T:System.ArgumentNullException">One or both of the columns is <see langword="null" />.</exception>
	/// <exception cref="T:System.Data.InvalidConstraintException">The columns have different data types.  
	///  -Or -  
	///  The tables don't belong to the same <see cref="T:System.Data.DataSet" />.</exception>
	[Browsable(false)]
	public ForeignKeyConstraint(string constraintName, string parentTableName, string[] parentColumnNames, string[] childColumnNames, AcceptRejectRule acceptRejectRule, Rule deleteRule, Rule updateRule)
	{
	}

	internal override void CheckCanAddToCollection(ConstraintCollection constraints)
	{
	}

	internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException)
	{
		return false;
	}

	internal bool IsKeyNull(object[] values)
	{
		return false;
	}

	internal override bool IsConstraintViolated()
	{
		return false;
	}

	internal override bool CanEnableConstraint()
	{
		return false;
	}

	internal void CascadeCommit(DataRow row)
	{
	}

	internal void CascadeDelete(DataRow row)
	{
	}

	internal void CascadeRollback(DataRow row)
	{
	}

	internal void CascadeUpdate(DataRow row)
	{
	}

	internal void CheckCanClearParentTable(DataTable table)
	{
	}

	internal void CheckCanRemoveParentRow(DataRow row)
	{
	}

	internal void CheckCascade(DataRow row, DataRowAction action)
	{
	}

	internal override void CheckConstraint(DataRow childRow, DataRowAction action)
	{
	}

	private void NonVirtualCheckState()
	{
	}

	internal override void CheckState()
	{
	}

	internal override bool ContainsColumn(DataColumn column)
	{
		return false;
	}

	internal override Constraint Clone(DataSet destination)
	{
		return null;
	}

	internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup)
	{
		return null;
	}

	internal ForeignKeyConstraint Clone(DataTable destination)
	{
		return null;
	}

	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns)
	{
	}

	/// <summary>Gets a value indicating whether the current <see cref="T:System.Data.ForeignKeyConstraint" /> is identical to the specified object.</summary>
	/// <param name="key">The object to which this <see cref="T:System.Data.ForeignKeyConstraint" /> is compared. Two <see cref="T:System.Data.ForeignKeyConstraint" /> are equal if they constrain the same columns.</param>
	/// <returns>
	///   <see langword="true" />, if the objects are identical; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object key)
	{
		return false;
	}

	/// <summary>Gets the hash code of this instance of the <see cref="T:System.Data.ForeignKeyConstraint" /> object.</summary>
	/// <returns>A 32-bit signed integer hash code.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	internal DataRelation FindParentRelation()
	{
		return null;
	}
}
