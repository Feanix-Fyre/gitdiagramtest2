using System.Collections;
using System.Reflection;

namespace System.ComponentModel;

internal sealed class ReflectEventDescriptor : EventDescriptor
{
	private Type _type;

	private readonly Type _componentClass;

	private MethodInfo _addMethod;

	private MethodInfo _removeMethod;

	private EventInfo _realEvent;

	private bool _filledMethods;

	public override Type EventType => null;

	public ReflectEventDescriptor(Type componentClass, string name, Type type, Attribute[] attributes)
		: base((string)null, (Attribute[])null)
	{
	}

	public ReflectEventDescriptor(Type componentClass, EventInfo eventInfo)
		: base((string)null, (Attribute[])null)
	{
	}

	public ReflectEventDescriptor(Type componentType, EventDescriptor oldReflectEventDescriptor, Attribute[] attributes)
		: base((string)null, (Attribute[])null)
	{
	}

	public override void AddEventHandler(object component, Delegate value)
	{
	}

	protected override void FillAttributes(IList attributes)
	{
	}

	private void FillEventInfoAttribute(EventInfo realEventInfo, IList attributes)
	{
	}

	private void FillMethods()
	{
	}

	private void FillSingleMethodAttribute(MethodInfo realMethodInfo, IList attributes)
	{
	}

	public override void RemoveEventHandler(object component, Delegate value)
	{
	}
}
