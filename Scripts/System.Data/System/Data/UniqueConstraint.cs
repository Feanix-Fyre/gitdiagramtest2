using System.ComponentModel;

namespace System.Data;

/// <summary>Represents a restriction on a set of columns in which all values must be unique.</summary>
[DefaultProperty("ConstraintName")]
public class UniqueConstraint : Constraint
{
	private DataKey _key;

	private Index _constraintIndex;

	internal bool _bPrimaryKey;

	internal string _constraintName;

	internal string[] _columnNames;

	internal string[] ColumnNames => null;

	internal Index ConstraintIndex => null;

	/// <summary>Gets the array of columns that this constraint affects.</summary>
	/// <returns>An array of <see cref="T:System.Data.DataColumn" /> objects.</returns>
	[ReadOnly(true)]
	public virtual DataColumn[] Columns => null;

	internal DataColumn[] ColumnsReference => null;

	/// <summary>Gets a value indicating whether or not the constraint is on a primary key.</summary>
	/// <returns>
	///   <see langword="true" />, if the constraint is on a primary key; otherwise, <see langword="false" />.</returns>
	public bool IsPrimaryKey => false;

	internal override bool InCollection
	{
		set
		{
		}
	}

	internal DataKey Key => default(DataKey);

	/// <summary>Gets the table to which this constraint belongs.</summary>
	/// <returns>The <see cref="T:System.Data.DataTable" /> to which the constraint belongs.</returns>
	[ReadOnly(true)]
	public override DataTable Table => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.UniqueConstraint" /> class with the specified <see cref="T:System.Data.DataColumn" />.</summary>
	/// <param name="column">The <see cref="T:System.Data.DataColumn" /> to constrain.</param>
	public UniqueConstraint(DataColumn column)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.UniqueConstraint" /> class with the specified name and array of <see cref="T:System.Data.DataColumn" /> objects.</summary>
	/// <param name="name">The name of the constraint.</param>
	/// <param name="columns">The array of <see cref="T:System.Data.DataColumn" /> objects to constrain.</param>
	public UniqueConstraint(string name, DataColumn[] columns)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.UniqueConstraint" /> class with the given array of <see cref="T:System.Data.DataColumn" /> objects.</summary>
	/// <param name="columns">The array of <see cref="T:System.Data.DataColumn" /> objects to constrain.</param>
	public UniqueConstraint(DataColumn[] columns)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.UniqueConstraint" /> class with the specified name, an array of <see cref="T:System.Data.DataColumn" /> objects to constrain, and a value specifying whether the constraint is a primary key.</summary>
	/// <param name="name">The name of the constraint.</param>
	/// <param name="columnNames">An array of <see cref="T:System.Data.DataColumn" /> objects to constrain.</param>
	/// <param name="isPrimaryKey">
	///   <see langword="true" /> to indicate that the constraint is a primary key; otherwise, <see langword="false" />.</param>
	[Browsable(false)]
	public UniqueConstraint(string name, string[] columnNames, bool isPrimaryKey)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.UniqueConstraint" /> class with the specified name, an array of <see cref="T:System.Data.DataColumn" /> objects to constrain, and a value specifying whether the constraint is a primary key.</summary>
	/// <param name="name">The name of the constraint.</param>
	/// <param name="columns">An array of <see cref="T:System.Data.DataColumn" /> objects to constrain.</param>
	/// <param name="isPrimaryKey">
	///   <see langword="true" /> to indicate that the constraint is a primary key; otherwise, <see langword="false" />.</param>
	public UniqueConstraint(string name, DataColumn[] columns, bool isPrimaryKey)
	{
	}

	internal void ConstraintIndexClear()
	{
	}

	internal void ConstraintIndexInitialize()
	{
	}

	internal override void CheckState()
	{
	}

	private void NonVirtualCheckState()
	{
	}

	internal override void CheckCanAddToCollection(ConstraintCollection constraints)
	{
	}

	internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException)
	{
		return false;
	}

	internal override bool CanEnableConstraint()
	{
		return false;
	}

	internal override bool IsConstraintViolated()
	{
		return false;
	}

	internal override void CheckConstraint(DataRow row, DataRowAction action)
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

	internal UniqueConstraint Clone(DataTable table)
	{
		return null;
	}

	private void Create(string constraintName, DataColumn[] columns)
	{
	}

	/// <summary>Compares this constraint to a second to determine if both are identical.</summary>
	/// <param name="key2">The object to which this <see cref="T:System.Data.UniqueConstraint" /> is compared.</param>
	/// <returns>
	///   <see langword="true" />, if the contraints are equal; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object key2)
	{
		return false;
	}

	/// <summary>Gets the hash code of this instance of the <see cref="T:System.Data.UniqueConstraint" /> object.</summary>
	/// <returns>A 32-bit signed integer hash code.</returns>
	public override int GetHashCode()
	{
		return 0;
	}
}
