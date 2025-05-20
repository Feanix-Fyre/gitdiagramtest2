using System;

namespace Newtonsoft.Json.Serialization;

public class JsonObjectContract : JsonContainerContract
{
	internal bool ExtensionDataIsJToken;

	private bool? _hasRequiredOrDefaultValueProperties;

	private ObjectConstructor<object>? _overrideCreator;

	private ObjectConstructor<object>? _parameterizedCreator;

	private JsonPropertyCollection? _creatorParameters;

	private Type? _extensionDataValueType;

	public MemberSerialization MemberSerialization { get; set; }

	public MissingMemberHandling? MissingMemberHandling { get; set; }

	public Required? ItemRequired { get; set; }

	public NullValueHandling? ItemNullValueHandling { get; set; }

	public JsonPropertyCollection Properties { get; }

	public JsonPropertyCollection CreatorParameters => null;

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

	internal ObjectConstructor<object>? ParameterizedCreator
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ExtensionDataSetter? ExtensionDataSetter { get; set; }

	public ExtensionDataGetter? ExtensionDataGetter { get; set; }

	public Type? ExtensionDataValueType
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Func<string, string>? ExtensionDataNameResolver { get; set; }

	internal bool HasRequiredOrDefaultValueProperties => false;

	public JsonObjectContract(Type underlyingType)
		: base(null)
	{
	}

	internal object GetUninitializedObject()
	{
		return null;
	}
}
