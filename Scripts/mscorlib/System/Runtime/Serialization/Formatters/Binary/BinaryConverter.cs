namespace System.Runtime.Serialization.Formatters.Binary;

internal static class BinaryConverter
{
	internal static BinaryTypeEnum GetBinaryTypeInfo(Type type, WriteObjectInfo objectInfo, string typeName, ObjectWriter objectWriter, out object typeInformation, out int assemId)
	{
		typeInformation = null;
		assemId = default(int);
		return default(BinaryTypeEnum);
	}

	internal static BinaryTypeEnum GetParserBinaryTypeInfo(Type type, out object typeInformation)
	{
		typeInformation = null;
		return default(BinaryTypeEnum);
	}

	internal static void WriteTypeInfo(BinaryTypeEnum binaryTypeEnum, object typeInformation, int assemId, __BinaryWriter sout)
	{
	}

	internal static object ReadTypeInfo(BinaryTypeEnum binaryTypeEnum, __BinaryParser input, out int assemId)
	{
		assemId = default(int);
		return null;
	}

	internal static void TypeFromInfo(BinaryTypeEnum binaryTypeEnum, object typeInformation, ObjectReader objectReader, BinaryAssemblyInfo assemblyInfo, out InternalPrimitiveTypeE primitiveTypeEnum, out string typeString, out Type type, out bool isVariant)
	{
		primitiveTypeEnum = default(InternalPrimitiveTypeE);
		typeString = null;
		type = null;
		isVariant = default(bool);
	}
}
