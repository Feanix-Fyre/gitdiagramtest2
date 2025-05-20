namespace System.Data;

/// <summary>Indicates the action that occurs when a <see cref="T:System.Data.ForeignKeyConstraint" /> is enforced.</summary>
public enum Rule
{
	/// <summary>No action taken on related rows.</summary>
	None = 0,
	/// <summary>Delete or update related rows. This is the default.</summary>
	Cascade = 1,
	/// <summary>Set values in related rows to <see langword="DBNull" />.</summary>
	SetNull = 2,
	/// <summary>Set values in related rows to the value contained in the <see cref="P:System.Data.DataColumn.DefaultValue" /> property.</summary>
	SetDefault = 3
}
