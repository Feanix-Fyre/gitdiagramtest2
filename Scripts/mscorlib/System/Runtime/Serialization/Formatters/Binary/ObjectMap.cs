namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class ObjectMap
{
	internal string objectName;

	internal Type objectType;

	internal BinaryTypeEnum[] binaryTypeEnumA;

	internal object[] typeInformationA;

	internal Type[] memberTypes;

	internal string[] memberNames;

	internal ReadObjectInfo objectInfo;

	internal bool isInitObjectInfo;

	internal ObjectReader objectReader;

	internal int objectId;

	internal BinaryAssemblyInfo assemblyInfo;

	internal ObjectMap(string objectName, Type objectType, string[] memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo)
	{
	}

	internal ObjectMap(string objectName, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable)
	{
	}

	internal ReadObjectInfo CreateObjectInfo(ref SerializationInfo si, ref object[] memberData)
	{
		return null;
	}

	internal static ObjectMap Create(string name, Type objectType, string[] memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo)
	{
		return null;
	}

	internal static ObjectMap Create(string name, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable)
	{
		return null;
	}
}
