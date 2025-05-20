using System.ComponentModel;

namespace System.Data;

/// <summary>Represents a constraint that can be enforced on one or more <see cref="T:System.Data.DataColumn" /> objects.</summary>
[DefaultProperty("ConstraintName")]
[TypeConverter(typeof(ConstraintConverter))]
public abstract class Constraint
{
	private string _schemaName;

	private bool _inCollection;

	private DataSet _dataSet;

	internal string _name;

	internal PropertyCollection _extendedProperties;

	/// <summary>The name of a constraint in the <see cref="T:System.Data.ConstraintCollection" />.</summary>
	/// <returns>The name of the <see cref="T:System.Data.Constraint" />.</returns>
	/// <exception cref="T:System.ArgumentException">The <see cref="T:System.Data.Constraint" /> name is a null value or empty string.</exception>
	/// <exception cref="T:System.Data.DuplicateNameException">The <see cref="T:System.Data.ConstraintCollection" /> already contains a <see cref="T:System.Data.Constraint" /> with the same name (The comparison is not case-sensitive.).</exception>
	[DefaultValue(null)]
	public virtual string ConstraintName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal string SchemaName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal virtual bool InCollection
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets the <see cref="T:System.Data.DataTable" /> to which the constraint applies.</summary>
	/// <returns>A <see cref="T:System.Data.DataTable" /> to which the constraint applies.</returns>
	public abstract DataTable Table { get; }

	/// <summary>Gets the collection of user-defined constraint properties.</summary>
	/// <returns>A <see cref="T:System.Data.PropertyCollection" /> of custom information.</returns>
	[Browsable(false)]
	public PropertyCollection ExtendedProperties => null;

	/// <summary>Gets the <see cref="T:System.Data.DataSet" /> to which this constraint belongs.</summary>
	/// <returns>The <see cref="T:System.Data.DataSet" /> to which the constraint belongs.</returns>
	[CLSCompliant(false)]
	protected virtual DataSet _DataSet => null;

	internal abstract bool ContainsColumn(DataColumn column);

	internal abstract bool CanEnableConstraint();

	internal abstract Constraint Clone(DataSet destination);

	internal abstract Constraint Clone(DataSet destination, bool ignoreNSforTableLookup);

	internal void CheckConstraint()
	{
	}

	internal abstract void CheckCanAddToCollection(ConstraintCollection constraint);

	internal abstract bool CanBeRemovedFromCollection(ConstraintCollection constraint, bool fThrowException);

	internal abstract void CheckConstraint(DataRow row, DataRowAction action);

	internal abstract void CheckState();

	/// <summary>Gets the <see cref="T:System.Data.DataSet" /> to which this constraint belongs.</summary>
	protected void CheckStateForProperty()
	{
	}

	internal abstract bool IsConstraintViolated();

	/// <summary>Gets the <see cref="P:System.Data.Constraint.ConstraintName" />, if there is one, as a string.</summary>
	/// <returns>The string value of the <see cref="P:System.Data.Constraint.ConstraintName" />.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.Constraint" /> class.</summary>
	protected Constraint()
	{
	}
}
