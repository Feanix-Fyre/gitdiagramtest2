using System;
using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout((LayoutKind)2, Size = 1040)]
public struct QueryPairedUserAccountCommand : IInputDeviceCommandInfo
{
	[Flags]
	public enum Result : long
	{
		DevicePairedToUserAccount = 2L,
		UserAccountSelectionInProgress = 4L,
		UserAccountSelectionComplete = 8L,
		UserAccountSelectionCanceled = 0x10L
	}

	internal const int kMaxNameLength = 256;

	internal const int kMaxIdLength = 256;

	internal const int kSize = 1040;

	[FieldOffset(0)]
	public InputDeviceCommand baseCommand;

	[FieldOffset(8)]
	public ulong handle;

	[FieldOffset(16)]
	internal unsafe fixed byte nameBuffer[512];

	[FieldOffset(528)]
	internal unsafe fixed byte idBuffer[512];

	public static FourCC Type => default(FourCC);

	public string id
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public FourCC typeStatic => default(FourCC);

	public static QueryPairedUserAccountCommand Create()
	{
		return default(QueryPairedUserAccountCommand);
	}
}
