using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Reflection;

namespace System.ComponentModel;

internal sealed class ReflectPropertyDescriptor : PropertyDescriptor
{
	private static readonly Type[] argsNone;

	private static readonly object noValue;

	private static TraceSwitch PropDescCreateSwitch;

	private static TraceSwitch PropDescUsageSwitch;

	private static readonly int BitDefaultValueQueried;

	private static readonly int BitGetQueried;

	private static readonly int BitSetQueried;

	private static readonly int BitShouldSerializeQueried;

	private static readonly int BitResetQueried;

	private static readonly int BitChangedQueried;

	private static readonly int BitIPropChangedQueried;

	private static readonly int BitReadOnlyChecked;

	private static readonly int BitAmbientValueQueried;

	private static readonly int BitSetOnDemand;

	private BitVector32 state;

	private Type componentClass;

	private Type type;

	private object defaultValue;

	private object ambientValue;

	private PropertyInfo propInfo;

	private MethodInfo getMethod;

	private MethodInfo setMethod;

	private MethodInfo shouldSerializeMethod;

	private MethodInfo resetMethod;

	private EventDescriptor realChangedEvent;

	private Type receiverType;

	private object AmbientValue => null;

	public override Type ComponentType => null;

	private object DefaultValue => null;

	private MethodInfo GetMethodValue => null;

	private bool IsExtender => false;

	public override bool IsReadOnly => false;

	public override Type PropertyType => null;

	private MethodInfo ResetMethodValue => null;

	private MethodInfo SetMethodValue => null;

	private MethodInfo ShouldSerializeMethodValue => null;

	public ReflectPropertyDescriptor(Type componentClass, string name, Type type, Attribute[] attributes)
		: base((string)null, (Attribute[])null)
	{
	}

	public ReflectPropertyDescriptor(Type componentClass, string name, Type type, PropertyInfo propInfo, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs)
		: base((string)null, (Attribute[])null)
	{
	}

	public ReflectPropertyDescriptor(Type componentClass, string name, Type type, Type receiverType, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs)
		: base((string)null, (Attribute[])null)
	{
	}

	public ReflectPropertyDescriptor(Type componentClass, PropertyDescriptor oldReflectPropertyDescriptor, Attribute[] attributes)
		: base((string)null, (Attribute[])null)
	{
	}

	internal bool ExtenderCanResetValue(IExtenderProvider provider, object component)
	{
		return false;
	}

	internal Type ExtenderGetReceiverType()
	{
		return null;
	}

	internal Type ExtenderGetType(IExtenderProvider provider)
	{
		return null;
	}

	internal object ExtenderGetValue(IExtenderProvider provider, object component)
	{
		return null;
	}

	internal void ExtenderResetValue(IExtenderProvider provider, object component, PropertyDescriptor notifyDesc)
	{
	}

	internal void ExtenderSetValue(IExtenderProvider provider, object component, object value, PropertyDescriptor notifyDesc)
	{
	}

	internal bool ExtenderShouldSerializeValue(IExtenderProvider provider, object component)
	{
		return false;
	}

	public override bool CanResetValue(object component)
	{
		return false;
	}

	protected override void FillAttributes(IList attributes)
	{
	}

	public override object GetValue(object component)
	{
		return null;
	}

	protected override void OnValueChanged(object component, EventArgs e)
	{
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
