using System.Reflection;

namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class ValueFixup
{
	internal ValueFixupEnum valueFixupEnum;

	internal Array arrayObj;

	internal int[] indexMap;

	internal object header;

	internal object memberObject;

	internal static MemberInfo valueInfo;

	internal ReadObjectInfo objectInfo;

	internal string memberName;

	internal ValueFixup(Array arrayObj, int[] indexMap)
	{
	}

	internal ValueFixup(object memberObject, string memberName, ReadObjectInfo objectInfo)
	{
	}

	internal void Fixup(ParseRecord record, ParseRecord parent)
	{
	}
}
