using System.Collections.Generic;
using System.Reflection;

namespace System;

internal static class MonoCustomAttrs
{
	private class AttributeInfo
	{
		private AttributeUsageAttribute _usage;

		private int _inheritanceLevel;

		public AttributeUsageAttribute Usage => null;

		public int InheritanceLevel => 0;

		public AttributeInfo(AttributeUsageAttribute usage, int inheritanceLevel)
		{
		}
	}

	private static Assembly corlib;

	[ThreadStatic]
	private static Dictionary<Type, AttributeUsageAttribute> usage_cache;

	private static readonly AttributeUsageAttribute DefaultAttributeUsage;

	private static bool IsUserCattrProvider(object obj)
	{
		return false;
	}

	internal static Attribute[] GetCustomAttributesInternal(ICustomAttributeProvider obj, Type attributeType, bool pseudoAttrs)
	{
		return null;
	}

	internal static object[] GetPseudoCustomAttributes(ICustomAttributeProvider obj, Type attributeType)
	{
		return null;
	}

	private static object[] GetPseudoCustomAttributes(Type type)
	{
		return null;
	}

	internal static object[] GetCustomAttributesBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly)
	{
		return null;
	}

	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, Type attributeType, bool inherit)
	{
		return null;
	}

	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, bool inherit)
	{
		return null;
	}

	private static CustomAttributeData[] GetCustomAttributesDataInternal(ICustomAttributeProvider obj)
	{
		return null;
	}

	internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj, bool inherit = false)
	{
		return null;
	}

	internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj, Type attributeType, bool inherit)
	{
		return null;
	}

	internal static IList<CustomAttributeData> GetCustomAttributesDataBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly)
	{
		return null;
	}

	internal static CustomAttributeData[] GetPseudoCustomAttributesData(ICustomAttributeProvider obj, Type attributeType)
	{
		return null;
	}

	private static CustomAttributeData[] GetPseudoCustomAttributesData(Type type)
	{
		return null;
	}

	internal static bool IsDefined(ICustomAttributeProvider obj, Type attributeType, bool inherit)
	{
		return false;
	}

	internal static bool IsDefinedInternal(ICustomAttributeProvider obj, Type AttributeType)
	{
		return false;
	}

	private static PropertyInfo GetBasePropertyDefinition(RuntimePropertyInfo property)
	{
		return null;
	}

	private static EventInfo GetBaseEventDefinition(RuntimeEventInfo evt)
	{
		return null;
	}

	private static ICustomAttributeProvider GetBase(ICustomAttributeProvider obj)
	{
		return null;
	}

	private static AttributeUsageAttribute RetrieveAttributeUsageNoCache(Type attributeType)
	{
		return null;
	}

	private static AttributeUsageAttribute RetrieveAttributeUsage(Type attributeType)
	{
		return null;
	}
}
