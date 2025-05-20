using System;

namespace Newtonsoft.Json;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Parameter, AllowMultiple = false)]
public sealed class JsonConverterAttribute : Attribute
{
	private readonly Type _converterType;

	public Type ConverterType => null;

	public object[]? ConverterParameters { get; }

	public JsonConverterAttribute(Type converterType)
	{
	}

	public JsonConverterAttribute(Type converterType, params object[] converterParameters)
	{
	}
}
