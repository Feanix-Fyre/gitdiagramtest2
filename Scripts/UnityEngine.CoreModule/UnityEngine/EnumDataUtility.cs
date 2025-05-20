using System;
using System.Collections.Generic;
using System.Reflection;

namespace UnityEngine;

internal static class EnumDataUtility
{
	public enum CachedType
	{
		ExcludeObsolete = 0,
		IncludeObsoleteExceptErrors = 1,
		IncludeAllObsolete = 2
	}

	private static readonly Dictionary<(CachedType, Type), EnumData> s_EnumData;

	public static EnumData GetCachedEnumData(Type enumType, CachedType cachedType = CachedType.IncludeObsoleteExceptErrors, Func<string, string> nicifyName = null)
	{
		return default(EnumData);
	}

	internal static void HandleInspectorOrderAttribute(Type enumType, ref EnumData enumData)
	{
	}

	private static bool CheckObsoleteAddition(FieldInfo field, CachedType cachedType)
	{
		return false;
	}

	private static string EnumTooltipFromEnumField(FieldInfo field)
	{
		return null;
	}

	private static string EnumNameFromEnumField(FieldInfo field, Func<string, string> nicifyName)
	{
		return null;
	}
}
