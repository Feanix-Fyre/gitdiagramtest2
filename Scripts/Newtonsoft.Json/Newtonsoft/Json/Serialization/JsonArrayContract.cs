using System;
using System.Collections;
using System.Reflection;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization;

public class JsonArrayContract : JsonContainerContract
{
	private readonly Type? _genericCollectionDefinitionType;

	private Type? _genericWrapperType;

	private ObjectConstructor<object>? _genericWrapperCreator;

	private Func<object>? _genericTemporaryCollectionCreator;

	private readonly ConstructorInfo? _parameterizedConstructor;

	private ObjectConstructor<object>? _parameterizedCreator;

	private ObjectConstructor<object>? _overrideCreator;

	public Type? CollectionItemType { get; }

	public bool IsMultidimensionalArray { get; }

	internal bool IsArray { get; }

	internal bool ShouldCreateWrapper { get; }

	internal bool CanDeserialize { get; private set; }

	internal ObjectConstructor<object>? ParameterizedCreator => null;

	public ObjectConstructor<object>? OverrideCreator
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool HasParameterizedCreator { get; set; }

	internal bool HasParameterizedCreatorInternal => false;

	public JsonArrayContract(Type underlyingType)
		: base(null)
	{
	}

	internal IWrappedCollection CreateWrapper(object list)
	{
		return null;
	}

	internal IList CreateTemporaryCollection()
	{
		return null;
	}

	private void StoreFSharpListCreatorIfNecessary(Type underlyingType)
	{
	}
}
