using System.IO;
using System.Text;

namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class __BinaryParser
{
	internal ObjectReader objectReader;

	internal Stream input;

	internal long topId;

	internal long headerId;

	internal SizedArray objectMapIdTable;

	internal SizedArray assemIdToAssemblyTable;

	internal SerStack stack;

	internal BinaryTypeEnum expectedType;

	internal object expectedTypeInformation;

	internal ParseRecord PRS;

	private BinaryAssemblyInfo systemAssemblyInfo;

	private BinaryReader dataReader;

	private static Encoding encoding;

	private SerStack opPool;

	private BinaryObject binaryObject;

	private BinaryObjectWithMap bowm;

	private BinaryObjectWithMapTyped bowmt;

	internal BinaryObjectString objectString;

	internal BinaryCrossAppDomainString crossAppDomainString;

	internal MemberPrimitiveTyped memberPrimitiveTyped;

	private byte[] byteBuffer;

	internal MemberPrimitiveUnTyped memberPrimitiveUnTyped;

	internal MemberReference memberReference;

	internal ObjectNull objectNull;

	internal static MessageEnd messageEnd;

	internal BinaryAssemblyInfo SystemAssemblyInfo => null;

	internal SizedArray ObjectMapIdTable => null;

	internal SizedArray AssemIdToAssemblyTable => null;

	internal ParseRecord prs => null;

	internal __BinaryParser(Stream stream, ObjectReader objectReader)
	{
	}

	internal void Run()
	{
	}

	internal void ReadBegin()
	{
	}

	internal void ReadEnd()
	{
	}

	internal bool ReadBoolean()
	{
		return false;
	}

	internal byte ReadByte()
	{
		return 0;
	}

	internal byte[] ReadBytes(int length)
	{
		return null;
	}

	internal void ReadBytes(byte[] byteA, int offset, int size)
	{
	}

	internal char ReadChar()
	{
		return '\0';
	}

	internal char[] ReadChars(int length)
	{
		return null;
	}

	internal decimal ReadDecimal()
	{
		return default(decimal);
	}

	internal float ReadSingle()
	{
		return 0f;
	}

	internal double ReadDouble()
	{
		return 0.0;
	}

	internal short ReadInt16()
	{
		return 0;
	}

	internal int ReadInt32()
	{
		return 0;
	}

	internal long ReadInt64()
	{
		return 0L;
	}

	internal sbyte ReadSByte()
	{
		return 0;
	}

	internal string ReadString()
	{
		return null;
	}

	internal TimeSpan ReadTimeSpan()
	{
		return default(TimeSpan);
	}

	internal DateTime ReadDateTime()
	{
		return default(DateTime);
	}

	internal ushort ReadUInt16()
	{
		return 0;
	}

	internal uint ReadUInt32()
	{
		return 0u;
	}

	internal ulong ReadUInt64()
	{
		return 0uL;
	}

	internal void ReadSerializationHeaderRecord()
	{
	}

	internal void ReadAssembly(BinaryHeaderEnum binaryHeaderEnum)
	{
	}

	private void ReadObject()
	{
	}

	internal void ReadCrossAppDomainMap()
	{
	}

	internal void ReadObjectWithMap(BinaryHeaderEnum binaryHeaderEnum)
	{
	}

	private void ReadObjectWithMap(BinaryObjectWithMap record)
	{
	}

	internal void ReadObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum)
	{
	}

	private void ReadObjectWithMapTyped(BinaryObjectWithMapTyped record)
	{
	}

	private void ReadObjectString(BinaryHeaderEnum binaryHeaderEnum)
	{
	}

	private void ReadMemberPrimitiveTyped()
	{
	}

	private void ReadArray(BinaryHeaderEnum binaryHeaderEnum)
	{
	}

	private void ReadArrayAsBytes(ParseRecord pr)
	{
	}

	private void ReadMemberPrimitiveUnTyped()
	{
	}

	private void ReadMemberReference()
	{
	}

	private void ReadObjectNull(BinaryHeaderEnum binaryHeaderEnum)
	{
	}

	private void ReadMessageEnd()
	{
	}

	internal object ReadValue(InternalPrimitiveTypeE code)
	{
		return null;
	}

	private ObjectProgress GetOp()
	{
		return null;
	}

	private void PutOp(ObjectProgress op)
	{
	}
}
