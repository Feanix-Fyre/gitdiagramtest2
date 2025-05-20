using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout((LayoutKind)2, Size = 9)]
public struct EnableIMECompositionCommand : IInputDeviceCommandInfo
{
	internal const int kSize = 12;

	[FieldOffset(0)]
	public InputDeviceCommand baseCommand;

	[FieldOffset(8)]
	private byte m_ImeEnabled;

	public static FourCC Type => default(FourCC);

	public bool imeEnabled => false;

	public FourCC typeStatic => default(FourCC);

	public static EnableIMECompositionCommand Create(bool enabled)
	{
		return default(EnableIMECompositionCommand);
	}
}
