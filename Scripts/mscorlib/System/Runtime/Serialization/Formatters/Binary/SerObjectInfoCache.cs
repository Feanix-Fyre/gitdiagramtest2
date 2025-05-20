using System.Reflection;

namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class SerObjectInfoCache
{
	internal string fullTypeName;

	internal string assemblyString;

	internal bool hasTypeForwardedFrom;

	internal MemberInfo[] memberInfos;

	internal string[] memberNames;

	internal Type[] memberTypes;

	internal SerObjectInfoCache(string typeName, string assemblyName, bool hasTypeForwardedFrom)
	{
	}

	internal SerObjectInfoCache(Type type)
	{
	}
}
