using System.Collections;

namespace System.ComponentModel;

internal sealed class DelegatingTypeDescriptionProvider : TypeDescriptionProvider
{
	private readonly Type _type;

	internal TypeDescriptionProvider Provider => null;

	internal DelegatingTypeDescriptionProvider(Type type)
	{
	}

	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
	{
		return null;
	}

	public override IDictionary GetCache(object instance)
	{
		return null;
	}

	public override string GetFullComponentName(object component)
	{
		return null;
	}

	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance)
	{
		return null;
	}

	protected internal override IExtenderProvider[] GetExtenderProviders(object instance)
	{
		return null;
	}

	public override Type GetReflectionType(Type objectType, object instance)
	{
		return null;
	}

	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
	{
		return null;
	}
}
