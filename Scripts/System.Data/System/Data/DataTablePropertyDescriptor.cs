using System.ComponentModel;

namespace System.Data;

internal sealed class DataTablePropertyDescriptor : PropertyDescriptor
{
	public DataTable Table { get; }

	public override Type ComponentType => null;

	public override bool IsReadOnly => false;

	public override Type PropertyType => null;

	internal DataTablePropertyDescriptor(DataTable dataTable)
		: base((string)null, (Attribute[])null)
	{
	}

	public override bool Equals(object other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool CanResetValue(object component)
	{
		return false;
	}

	public override object GetValue(object component)
	{
		return null;
	}

	public override void ResetValue(object component)
	{
	}

	public override void SetValue(object component, object value)
	{
	}

	public override bool ShouldSerializeValue(object component)
	{
		return false;
	}
}
