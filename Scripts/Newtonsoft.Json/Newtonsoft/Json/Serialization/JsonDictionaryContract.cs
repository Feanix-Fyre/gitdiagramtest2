using System;
using System.Collections;
using System.Reflection;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization;

public class JsonDictionaryContract : JsonContainerContract
{
	private readonly Type? _genericCollectionDefinitionType;

	private Type? _genericWrapperType;

	private ObjectConstructor<object>? _genericWrapperCreator;

	private Func<object>? _genericTemporaryDictionaryCreator;

	private readonly ConstructorInfo? _parameterizedConstructor;

	private ObjectConstructor<object>? _overrideCreator;

	private ObjectConstructor<object>? _parameterizedCreator;

	public Func<string, string>? DictionaryKeyResolver { get; set; }

	public Type? DictionaryKeyType { get; }

	public Type? DictionaryValueType { get; }

	internal JsonContract? KeyContract { get; set; }

	internal bool ShouldCreateWrapper { get; }

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

	public JsonDictionaryContract(Type underlyingType)
		: base(null)
	{
	}

	internal IWrappedDictionary CreateWrapper(object dictionary)
	{
		return null;
	}

	internal IDictionary CreateTemporaryDictionary()
	{
		return null;
	}
}
