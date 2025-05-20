using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization;

internal static class JsonTypeReflector
{
	private static bool? _dynamicCodeGeneration;

	private static bool? _fullyTrusted;

	public const string IdPropertyName = "$id";

	public const string RefPropertyName = "$ref";

	public const string TypePropertyName = "$type";

	public const string ValuePropertyName = "$value";

	public const string ArrayValuesPropertyName = "$values";

	public const string ShouldSerializePrefix = "ShouldSerialize";

	public const string SpecifiedPostfix = "Specified";

	public const string ConcurrentDictionaryTypeName = "System.Collections.Concurrent.ConcurrentDictionary`2";

	private static readonly ThreadSafeStore<Type, Func<object[]?, object>> CreatorCache;

	private static readonly ThreadSafeStore<Type, Type?> AssociatedMetadataTypesCache;

	private static ReflectionObject? _metadataTypeAttributeReflectionObject;

	public static bool DynamicCodeGeneration => false;

	public static bool FullyTrusted => false;

	public static ReflectionDelegateFactory ReflectionDelegateFactory => null;

	public static T GetCachedAttribute<T>(object attributeProvider) where T : notnull, Attribute
	{
		return null;
	}

	public static bool CanTypeDescriptorConvertString(Type type, out TypeConverter typeConverter)
	{
		typeConverter = null;
		return false;
	}

	public static DataContractAttribute GetDataContractAttribute(Type type)
	{
		return null;
	}

	public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo)
	{
		return null;
	}

	public static MemberSerialization GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute)
	{
		return default(MemberSerialization);
	}

	public static JsonConverter GetJsonConverter(object attributeProvider)
	{
		return null;
	}

	public static JsonConverter CreateJsonConverterInstance(Type converterType, object[]? args)
	{
		return null;
	}

	public static NamingStrategy CreateNamingStrategyInstance(Type namingStrategyType, object[]? args)
	{
		return null;
	}

	public static NamingStrategy GetContainerNamingStrategy(JsonContainerAttribute containerAttribute)
	{
		return null;
	}

	private static Func<object[], object> GetCreator(Type type)
	{
		return null;
	}

	private static Type GetAssociatedMetadataType(Type type)
	{
		return null;
	}

	private static Type GetAssociateMetadataTypeFromAttribute(Type type)
	{
		return null;
	}

	private static T GetAttribute<T>(Type type) where T : notnull, Attribute
	{
		return null;
	}

	private static T GetAttribute<T>(MemberInfo memberInfo) where T : notnull, Attribute
	{
		return null;
	}

	public static bool IsNonSerializable(object provider)
	{
		return false;
	}

	public static bool IsSerializable(object provider)
	{
		return false;
	}

	public static T GetAttribute<T>(object provider) where T : notnull, Attribute
	{
		return null;
	}
}
