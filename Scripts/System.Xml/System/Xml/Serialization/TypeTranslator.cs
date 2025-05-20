using System.Collections;

namespace System.Xml.Serialization;

internal class TypeTranslator
{
	private static Hashtable nameCache;

	private static Hashtable primitiveTypes;

	private static Hashtable primitiveArrayTypes;

	private static Hashtable nullableTypes;

	static TypeTranslator()
	{
	}

	public static TypeData GetTypeData(Type type)
	{
		return null;
	}

	public static TypeData GetTypeData(Type runtimeType, string xmlDataType, bool underlyingEnumType = false)
	{
		return null;
	}

	public static TypeData GetPrimitiveTypeData(string typeName)
	{
		return null;
	}

	public static TypeData GetPrimitiveTypeData(string typeName, bool nullable)
	{
		return null;
	}

	public static TypeData FindPrimitiveTypeData(string typeName)
	{
		return null;
	}

	public static string GetArrayName(string elemName)
	{
		return null;
	}

	public static void ParseArrayType(string arrayType, out string type, out string ns, out string dimensions)
	{
		type = null;
		ns = null;
		dimensions = null;
	}
}
