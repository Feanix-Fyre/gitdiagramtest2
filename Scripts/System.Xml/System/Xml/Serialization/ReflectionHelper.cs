using System.Collections;
using System.Reflection;

namespace System.Xml.Serialization;

internal class ReflectionHelper
{
	private Hashtable _clrTypes;

	private Hashtable _schemaTypes;

	private static readonly ParameterModifier[] empty_modifiers;

	public void RegisterSchemaType(XmlTypeMapping map, string xmlType, string ns)
	{
	}

	public XmlTypeMapping GetRegisteredSchemaType(string xmlType, string ns)
	{
		return null;
	}

	public void RegisterClrType(XmlTypeMapping map, Type type, string ns)
	{
	}

	public XmlTypeMapping GetRegisteredClrType(Type type, string ns)
	{
		return null;
	}

	public static void CheckSerializableType(Type type, bool allowPrivateConstructors)
	{
	}
}
