using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout((LayoutKind)2, Size = 616)]
internal struct TouchscreenState : IInputStateTypeInfo
{
	public const int MaxTouches = 10;

	[FieldOffset(0)]
	[InputControl(name = "pressure", useStateFrom = "primaryTouch/pressure")]
	[InputControl(name = "primaryTouch", displayName = "Primary Touch", layout = "Touch", synthetic = true)]
	[InputControl(name = "primaryTouch/tap", usage = "PrimaryAction")]
	[InputControl(name = "position", useStateFrom = "primaryTouch/position")]
	[InputControl(name = "delta", useStateFrom = "primaryTouch/delta", layout = "Delta")]
	[InputControl(name = "radius", useStateFrom = "primaryTouch/radius")]
	[InputControl(name = "press", useStateFrom = "primaryTouch/phase", layout = "TouchPress", synthetic = true, usages = new string[] { })]
	public unsafe fixed byte primaryTouchData[56];

	internal const int kTouchDataOffset = 56;

	[FieldOffset(56)]
	[InputControl(layout = "Touch", name = "touch", displayName = "Touch", arraySize = 10)]
	public unsafe fixed byte touchData[560];

	public static FourCC Format => default(FourCC);

	public unsafe TouchState* primaryTouch => null;

	public unsafe TouchState* touches => null;

	public FourCC format => default(FourCC);
}
