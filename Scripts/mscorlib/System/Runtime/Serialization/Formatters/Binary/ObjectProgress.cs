namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class ObjectProgress
{
	internal static int opRecordIdCount;

	internal bool isInitial;

	internal int count;

	internal BinaryTypeEnum expectedType;

	internal object expectedTypeInformation;

	internal string name;

	internal InternalObjectTypeE objectTypeEnum;

	internal InternalMemberTypeE memberTypeEnum;

	internal InternalMemberValueE memberValueEnum;

	internal Type dtType;

	internal int numItems;

	internal BinaryTypeEnum binaryTypeEnum;

	internal object typeInformation;

	internal int nullCount;

	internal int memberLength;

	internal BinaryTypeEnum[] binaryTypeEnumA;

	internal object[] typeInformationA;

	internal string[] memberNames;

	internal Type[] memberTypes;

	internal ParseRecord pr;

	internal ObjectProgress()
	{
	}

	internal void Init()
	{
	}

	internal void ArrayCountIncrement(int value)
	{
	}

	internal bool GetNext(out BinaryTypeEnum outBinaryTypeEnum, out object outTypeInformation)
	{
		outBinaryTypeEnum = default(BinaryTypeEnum);
		outTypeInformation = null;
		return false;
	}
}
