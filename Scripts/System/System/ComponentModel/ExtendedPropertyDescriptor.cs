namespace System.ComponentModel;

internal sealed class ExtendedPropertyDescriptor : PropertyDescriptor
{
	private readonly ReflectPropertyDescriptor _extenderInfo;

	private readonly IExtenderProvider _provider;

	public override Type ComponentType => null;

	public override bool IsReadOnly => false;

	public override Type PropertyType => null;

	public override string DisplayName => null;

	public ExtendedPropertyDescriptor(ReflectPropertyDescriptor extenderInfo, Type receiverType, IExtenderProvider provider, Attribute[] attributes)
		: base((string)null, (Attribute[])null)
	{
	}

	public ExtendedPropertyDescriptor(PropertyDescriptor extender, Attribute[] attributes)
		: base((string)null, (Attribute[])null)
	{
	}

	public override bool CanResetValue(object comp)
	{
		return false;
	}

	public override object GetValue(object comp)
	{
		return null;
	}

	public override void ResetValue(object comp)
	{
	}

	public override void SetValue(object component, object value)
	{
	}

	public override bool ShouldSerializeValue(object comp)
	{
		return false;
	}
}
