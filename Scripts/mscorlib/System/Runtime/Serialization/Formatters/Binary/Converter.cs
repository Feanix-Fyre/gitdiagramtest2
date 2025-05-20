using System.Reflection;

namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class Converter
{
	private static int primitiveTypeEnumLength;

	private static Type[] typeA;

	private static Type[] arrayTypeA;

	private static string[] valueA;

	private static TypeCode[] typeCodeA;

	private static InternalPrimitiveTypeE[] codeA;

	internal static Type typeofISerializable;

	internal static Type typeofString;

	internal static Type typeofConverter;

	internal static Type typeofBoolean;

	internal static Type typeofByte;

	internal static Type typeofChar;

	internal static Type typeofDecimal;

	internal static Type typeofDouble;

	internal static Type typeofInt16;

	internal static Type typeofInt32;

	internal static Type typeofInt64;

	internal static Type typeofSByte;

	internal static Type typeofSingle;

	internal static Type typeofTimeSpan;

	internal static Type typeofDateTime;

	internal static Type typeofUInt16;

	internal static Type typeofUInt32;

	internal static Type typeofUInt64;

	internal static Type typeofObject;

	internal static Type typeofSystemVoid;

	internal static Assembly urtAssembly;

	internal static string urtAssemblyString;

	internal static Type typeofTypeArray;

	internal static Type typeofObjectArray;

	internal static Type typeofStringArray;

	internal static Type typeofBooleanArray;

	internal static Type typeofByteArray;

	internal static Type typeofCharArray;

	internal static Type typeofDecimalArray;

	internal static Type typeofDoubleArray;

	internal static Type typeofInt16Array;

	internal static Type typeofInt32Array;

	internal static Type typeofInt64Array;

	internal static Type typeofSByteArray;

	internal static Type typeofSingleArray;

	internal static Type typeofTimeSpanArray;

	internal static Type typeofDateTimeArray;

	internal static Type typeofUInt16Array;

	internal static Type typeofUInt32Array;

	internal static Type typeofUInt64Array;

	internal static Type typeofMarshalByRefObject;

	internal static InternalPrimitiveTypeE ToCode(Type type)
	{
		return default(InternalPrimitiveTypeE);
	}

	internal static bool IsWriteAsByteArray(InternalPrimitiveTypeE code)
	{
		return false;
	}

	internal static int TypeLength(InternalPrimitiveTypeE code)
	{
		return 0;
	}

	internal static Type ToArrayType(InternalPrimitiveTypeE code)
	{
		return null;
	}

	private static void InitTypeA()
	{
	}

	private static void InitArrayTypeA()
	{
	}

	internal static Type ToType(InternalPrimitiveTypeE code)
	{
		return null;
	}

	internal static Array CreatePrimitiveArray(InternalPrimitiveTypeE code, int length)
	{
		return null;
	}

	internal static bool IsPrimitiveArray(Type type, out object typeInformation)
	{
		typeInformation = null;
		return false;
	}

	private static void InitValueA()
	{
	}

	internal static string ToComType(InternalPrimitiveTypeE code)
	{
		return null;
	}

	private static void InitTypeCodeA()
	{
	}

	internal static TypeCode ToTypeCode(InternalPrimitiveTypeE code)
	{
		return default(TypeCode);
	}

	private static void InitCodeA()
	{
	}

	internal static InternalPrimitiveTypeE ToPrimitiveTypeEnum(TypeCode typeCode)
	{
		return default(InternalPrimitiveTypeE);
	}

	internal static object FromString(string value, InternalPrimitiveTypeE code)
	{
		return null;
	}
}
