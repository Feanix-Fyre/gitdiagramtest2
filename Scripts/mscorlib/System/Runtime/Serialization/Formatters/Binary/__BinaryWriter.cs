using System.Collections;
using System.IO;

namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class __BinaryWriter
{
	internal Stream sout;

	internal FormatterTypeStyle formatterTypeStyle;

	internal Hashtable objectMapTable;

	internal ObjectWriter objectWriter;

	internal BinaryWriter dataWriter;

	internal int m_nestedObjectCount;

	private int nullCount;

	internal BinaryMethodCall binaryMethodCall;

	internal BinaryMethodReturn binaryMethodReturn;

	internal BinaryObject binaryObject;

	internal BinaryObjectWithMap binaryObjectWithMap;

	internal BinaryObjectWithMapTyped binaryObjectWithMapTyped;

	internal BinaryObjectString binaryObjectString;

	internal BinaryArray binaryArray;

	private byte[] byteBuffer;

	private int chunkSize;

	internal MemberPrimitiveUnTyped memberPrimitiveUnTyped;

	internal MemberPrimitiveTyped memberPrimitiveTyped;

	internal ObjectNull objectNull;

	internal MemberReference memberReference;

	internal BinaryAssembly binaryAssembly;

	internal __BinaryWriter(Stream sout, ObjectWriter objectWriter, FormatterTypeStyle formatterTypeStyle)
	{
	}

	internal void WriteBegin()
	{
	}

	internal void WriteEnd()
	{
	}

	internal void WriteBoolean(bool value)
	{
	}

	internal void WriteByte(byte value)
	{
	}

	private void WriteBytes(byte[] value)
	{
	}

	private void WriteBytes(byte[] byteA, int offset, int size)
	{
	}

	internal void WriteChar(char value)
	{
	}

	internal void WriteChars(char[] value)
	{
	}

	internal void WriteDecimal(decimal value)
	{
	}

	internal void WriteSingle(float value)
	{
	}

	internal void WriteDouble(double value)
	{
	}

	internal void WriteInt16(short value)
	{
	}

	internal void WriteInt32(int value)
	{
	}

	internal void WriteInt64(long value)
	{
	}

	internal void WriteSByte(sbyte value)
	{
	}

	internal void WriteString(string value)
	{
	}

	internal void WriteTimeSpan(TimeSpan value)
	{
	}

	internal void WriteDateTime(DateTime value)
	{
	}

	internal void WriteUInt16(ushort value)
	{
	}

	internal void WriteUInt32(uint value)
	{
	}

	internal void WriteUInt64(ulong value)
	{
	}

	internal void WriteObjectEnd(NameInfo memberNameInfo, NameInfo typeNameInfo)
	{
	}

	internal void WriteSerializationHeaderEnd()
	{
	}

	internal void WriteSerializationHeader(int topId, int headerId, int minorVersion, int majorVersion)
	{
	}

	internal void WriteMethodCall()
	{
	}

	internal void WriteMethodReturn()
	{
	}

	internal void WriteObject(NameInfo nameInfo, NameInfo typeNameInfo, int numMembers, string[] memberNames, Type[] memberTypes, WriteObjectInfo[] memberObjectInfos)
	{
	}

	internal void WriteObjectString(int objectId, string value)
	{
	}

	internal void WriteSingleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, Array array)
	{
	}

	private void WriteArrayAsBytes(Array array, int typeLength)
	{
	}

	internal void WriteJaggedArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound)
	{
	}

	internal void WriteRectangleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int rank, int[] lengthA, int[] lowerBoundA)
	{
	}

	internal void WriteObjectByteArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, byte[] byteA)
	{
	}

	internal void WriteMember(NameInfo memberNameInfo, NameInfo typeNameInfo, object value)
	{
	}

	internal void WriteNullMember(NameInfo memberNameInfo, NameInfo typeNameInfo)
	{
	}

	internal void WriteMemberObjectRef(NameInfo memberNameInfo, int idRef)
	{
	}

	internal void WriteMemberNested(NameInfo memberNameInfo)
	{
	}

	internal void WriteMemberString(NameInfo memberNameInfo, NameInfo typeNameInfo, string value)
	{
	}

	internal void WriteItem(NameInfo itemNameInfo, NameInfo typeNameInfo, object value)
	{
	}

	internal void WriteNullItem(NameInfo itemNameInfo, NameInfo typeNameInfo)
	{
	}

	internal void WriteDelayedNullItem()
	{
	}

	internal void WriteItemEnd()
	{
	}

	private void InternalWriteItemNull()
	{
	}

	internal void WriteItemObjectRef(NameInfo nameInfo, int idRef)
	{
	}

	internal void WriteAssembly(Type type, string assemblyString, int assemId, bool isNew)
	{
	}

	internal void WriteValue(InternalPrimitiveTypeE code, object value)
	{
	}
}
