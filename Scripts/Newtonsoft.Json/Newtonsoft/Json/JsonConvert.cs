using System;
using System.Diagnostics;
using System.Numerics;
using System.Xml;
using System.Xml.Linq;

namespace Newtonsoft.Json;

public static class JsonConvert
{
	public static readonly string True;

	public static readonly string False;

	public static readonly string Null;

	public static readonly string Undefined;

	public static readonly string PositiveInfinity;

	public static readonly string NegativeInfinity;

	public static readonly string NaN;

	public static Func<JsonSerializerSettings>? DefaultSettings { get; set; }

	public static string ToString(DateTime value)
	{
		return null;
	}

	public static string ToString(DateTime value, DateFormatHandling format, DateTimeZoneHandling timeZoneHandling)
	{
		return null;
	}

	public static string ToString(DateTimeOffset value)
	{
		return null;
	}

	public static string ToString(DateTimeOffset value, DateFormatHandling format)
	{
		return null;
	}

	public static string ToString(bool value)
	{
		return null;
	}

	public static string ToString(char value)
	{
		return null;
	}

	public static string ToString(Enum value)
	{
		return null;
	}

	public static string ToString(int value)
	{
		return null;
	}

	public static string ToString(short value)
	{
		return null;
	}

	[CLSCompliant(false)]
	public static string ToString(ushort value)
	{
		return null;
	}

	[CLSCompliant(false)]
	public static string ToString(uint value)
	{
		return null;
	}

	public static string ToString(long value)
	{
		return null;
	}

	private static string ToStringInternal(BigInteger value)
	{
		return null;
	}

	[CLSCompliant(false)]
	public static string ToString(ulong value)
	{
		return null;
	}

	public static string ToString(float value)
	{
		return null;
	}

	internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
	{
		return null;
	}

	private static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
	{
		return null;
	}

	public static string ToString(double value)
	{
		return null;
	}

	internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
	{
		return null;
	}

	private static string EnsureDecimalPlace(double value, string text)
	{
		return null;
	}

	private static string EnsureDecimalPlace(string text)
	{
		return null;
	}

	public static string ToString(byte value)
	{
		return null;
	}

	[CLSCompliant(false)]
	public static string ToString(sbyte value)
	{
		return null;
	}

	public static string ToString(decimal value)
	{
		return null;
	}

	public static string ToString(Guid value)
	{
		return null;
	}

	internal static string ToString(Guid value, char quoteChar)
	{
		return null;
	}

	public static string ToString(TimeSpan value)
	{
		return null;
	}

	internal static string ToString(TimeSpan value, char quoteChar)
	{
		return null;
	}

	public static string ToString(Uri? value)
	{
		return null;
	}

	internal static string ToString(Uri value, char quoteChar)
	{
		return null;
	}

	public static string ToString(string? value)
	{
		return null;
	}

	public static string ToString(string? value, char delimiter)
	{
		return null;
	}

	public static string ToString(string? value, char delimiter, StringEscapeHandling stringEscapeHandling)
	{
		return null;
	}

	public static string ToString(object? value)
	{
		return null;
	}

	[DebuggerStepThrough]
	public static string SerializeObject(object? value)
	{
		return null;
	}

	[DebuggerStepThrough]
	public static string SerializeObject(object? value, Formatting formatting)
	{
		return null;
	}

	[DebuggerStepThrough]
	public static string SerializeObject(object? value, params JsonConverter[] converters)
	{
		return null;
	}

	[DebuggerStepThrough]
	public static string SerializeObject(object? value, Formatting formatting, params JsonConverter[] converters)
	{
		return null;
	}

	[DebuggerStepThrough]
	public static string? SerializeObject(object? value, JsonSerializerSettings? settings)
	{
		return null;
	}

	[DebuggerStepThrough]
	public static string? SerializeObject(object? value, Type? type, JsonSerializerSettings? settings)
	{
		return null;
	}

	[DebuggerStepThrough]
	public static string? SerializeObject(object? value, Formatting formatting, JsonSerializerSettings? settings)
	{
		return null;
	}

	[DebuggerStepThrough]
	public static string? SerializeObject(object? value, Type? type, Formatting formatting, JsonSerializerSettings? settings)
	{
		return null;
	}

	private static string SerializeObjectInternal(object? value, Type? type, JsonSerializer jsonSerializer)
	{
		return null;
	}

	[DebuggerStepThrough]
	public static object DeserializeObject(string value)
	{
		return null;
	}

	[DebuggerStepThrough]
	public static object DeserializeObject(string value, JsonSerializerSettings settings)
	{
		return null;
	}

	[DebuggerStepThrough]
	public static object DeserializeObject(string value, Type type)
	{
		return null;
	}

	[DebuggerStepThrough]
	public static T? DeserializeObject<T>(string value)
	{
		return default(T);
	}

	[DebuggerStepThrough]
	public static T DeserializeAnonymousType<T>(string value, T anonymousTypeObject) where T : notnull
	{
		return default(T);
	}

	[DebuggerStepThrough]
	public static T DeserializeAnonymousType<T>(string value, T anonymousTypeObject, JsonSerializerSettings settings) where T : notnull
	{
		return default(T);
	}

	[DebuggerStepThrough]
	public static T DeserializeObject<T>(string value, params JsonConverter[] converters) where T : notnull
	{
		return default(T);
	}

	[DebuggerStepThrough]
	public static T? DeserializeObject<T>(string value, JsonSerializerSettings? settings)
	{
		return default(T);
	}

	[DebuggerStepThrough]
	public static object DeserializeObject(string value, Type type, params JsonConverter[] converters)
	{
		return null;
	}

	public static object? DeserializeObject(string value, Type? type, JsonSerializerSettings? settings)
	{
		return null;
	}

	[DebuggerStepThrough]
	public static void PopulateObject(string value, object target)
	{
	}

	public static void PopulateObject(string value, object target, JsonSerializerSettings? settings)
	{
	}

	public static string SerializeXmlNode(XmlNode? node)
	{
		return null;
	}

	public static string SerializeXmlNode(XmlNode? node, Formatting formatting)
	{
		return null;
	}

	public static string SerializeXmlNode(XmlNode? node, Formatting formatting, bool omitRootObject)
	{
		return null;
	}

	public static XmlDocument DeserializeXmlNode(string value)
	{
		return null;
	}

	public static XmlDocument? DeserializeXmlNode(string value, string? deserializeRootElementName)
	{
		return null;
	}

	public static XmlDocument? DeserializeXmlNode(string value, string? deserializeRootElementName, bool writeArrayAttribute)
	{
		return null;
	}

	public static XmlDocument? DeserializeXmlNode(string value, string? deserializeRootElementName, bool writeArrayAttribute, bool encodeSpecialCharacters)
	{
		return null;
	}

	public static string SerializeXNode(XObject? node)
	{
		return null;
	}

	public static string SerializeXNode(XObject? node, Formatting formatting)
	{
		return null;
	}

	public static string SerializeXNode(XObject? node, Formatting formatting, bool omitRootObject)
	{
		return null;
	}

	public static XDocument DeserializeXNode(string value)
	{
		return null;
	}

	public static XDocument? DeserializeXNode(string value, string? deserializeRootElementName)
	{
		return null;
	}

	public static XDocument? DeserializeXNode(string value, string? deserializeRootElementName, bool writeArrayAttribute)
	{
		return null;
	}

	public static XDocument? DeserializeXNode(string value, string? deserializeRootElementName, bool writeArrayAttribute, bool encodeSpecialCharacters)
	{
		return null;
	}
}
