using System;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

public struct InputStateBlock
{
	public const uint InvalidOffset = uint.MaxValue;

	public const uint AutomaticOffset = 4294967294u;

	public static readonly FourCC FormatInvalid;

	internal const int kFormatInvalid = 0;

	public static readonly FourCC FormatBit;

	internal const int kFormatBit = 1112101920;

	public static readonly FourCC FormatSBit;

	internal const int kFormatSBit = 1396853076;

	public static readonly FourCC FormatInt;

	internal const int kFormatInt = 1229870112;

	public static readonly FourCC FormatUInt;

	internal const int kFormatUInt = 1430867540;

	public static readonly FourCC FormatShort;

	internal const int kFormatShort = 1397248596;

	public static readonly FourCC FormatUShort;

	internal const int kFormatUShort = 1431521364;

	public static readonly FourCC FormatByte;

	internal const int kFormatByte = 1113150533;

	public static readonly FourCC FormatSByte;

	internal const int kFormatSByte = 1396857172;

	public static readonly FourCC FormatLong;

	internal const int kFormatLong = 1280198432;

	public static readonly FourCC FormatULong;

	internal const int kFormatULong = 1431064135;

	public static readonly FourCC FormatFloat;

	internal const int kFormatFloat = 1179407392;

	public static readonly FourCC FormatDouble;

	internal const int kFormatDouble = 1145195552;

	public static readonly FourCC FormatVector2;

	internal const int kFormatVector2 = 1447379762;

	public static readonly FourCC FormatVector3;

	internal const int kFormatVector3 = 1447379763;

	public static readonly FourCC FormatQuaternion;

	internal const int kFormatQuaternion = 1364541780;

	public static readonly FourCC FormatVector2Short;

	public static readonly FourCC FormatVector3Short;

	public static readonly FourCC FormatVector2Byte;

	public static readonly FourCC FormatVector3Byte;

	public static readonly FourCC FormatPose;

	internal const int kFormatPose = 1349481317;

	internal uint m_ByteOffset;

	public FourCC format { get; set; }

	public uint byteOffset
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint bitOffset { get; set; }

	public uint sizeInBits { get; set; }

	internal uint alignedSizeInBytes => 0u;

	internal uint effectiveByteOffset => 0u;

	internal uint effectiveBitOffset => 0u;

	public static int GetSizeOfPrimitiveFormatInBits(FourCC type)
	{
		return 0;
	}

	public static FourCC GetPrimitiveFormatFromType(Type type)
	{
		return default(FourCC);
	}

	public unsafe int ReadInt(void* statePtr)
	{
		return 0;
	}

	public unsafe void WriteInt(void* statePtr, int value)
	{
	}

	public unsafe float ReadFloat(void* statePtr)
	{
		return 0f;
	}

	public unsafe void WriteFloat(void* statePtr, float value)
	{
	}

	internal PrimitiveValue FloatToPrimitiveValue(float value)
	{
		return default(PrimitiveValue);
	}

	public unsafe double ReadDouble(void* statePtr)
	{
		return 0.0;
	}

	public unsafe void WriteDouble(void* statePtr, double value)
	{
	}

	public unsafe void Write(void* statePtr, PrimitiveValue value)
	{
	}

	public unsafe void CopyToFrom(void* toStatePtr, void* fromStatePtr)
	{
	}
}
