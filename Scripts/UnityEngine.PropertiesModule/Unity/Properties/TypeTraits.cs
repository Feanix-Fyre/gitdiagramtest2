using System;

namespace Unity.Properties;

public static class TypeTraits
{
	public static bool IsContainer(Type type)
	{
		return false;
	}
}
public static class TypeTraits<T>
{
	public static bool IsValueType { get; }

	public static bool IsPrimitive { get; }

	public static bool IsInterface { get; }

	public static bool IsAbstract { get; }

	public static bool IsArray { get; }

	public static bool IsEnum { get; }

	public static bool IsNullable { get; }

	public static bool IsObject { get; }

	public static bool IsString { get; }

	public static bool IsContainer { get; }

	public static bool CanBeNull { get; }

	public static bool IsAbstractOrInterface { get; }

	static TypeTraits()
	{
	}
}
