using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.XInput.LowLevel;

[StructLayout((LayoutKind)2, Size = 12)]
internal struct XInputControllerWindowsState : IInputStateTypeInfo
{
	public enum Button
	{
		DPadUp = 0,
		DPadDown = 1,
		DPadLeft = 2,
		DPadRight = 3,
		Start = 4,
		Select = 5,
		LeftThumbstickPress = 6,
		RightThumbstickPress = 7,
		LeftShoulder = 8,
		RightShoulder = 9,
		A = 12,
		B = 13,
		X = 14,
		Y = 15
	}

	[FieldOffset(0)]
	[InputControl(name = "dpad/up", bit = 0u)]
	[InputControl(name = "dpad", layout = "Dpad", sizeInBits = 4u, bit = 0u)]
	[InputControl(name = "buttonSouth", bit = 12u, displayName = "A")]
	[InputControl(name = "rightStickPress", bit = 7u)]
	[InputControl(name = "leftStickPress", bit = 6u)]
	[InputControl(name = "select", bit = 5u, displayName = "Select")]
	[InputControl(name = "start", bit = 4u, displayName = "Start")]
	[InputControl(name = "dpad/right", bit = 3u)]
	[InputControl(name = "dpad/left", bit = 2u)]
	[InputControl(name = "dpad/down", bit = 1u)]
	[InputControl(name = "rightShoulder", bit = 9u)]
	[InputControl(name = "buttonNorth", bit = 15u, displayName = "Y")]
	[InputControl(name = "buttonEast", bit = 13u, displayName = "B")]
	[InputControl(name = "leftShoulder", bit = 8u)]
	[InputControl(name = "buttonWest", bit = 14u, displayName = "X")]
	public ushort buttons;

	[FieldOffset(2)]
	[InputControl(name = "leftTrigger", format = "BYTE")]
	public byte leftTrigger;

	[FieldOffset(3)]
	[InputControl(name = "rightTrigger", format = "BYTE")]
	public byte rightTrigger;

	[FieldOffset(4)]
	[InputControl(name = "leftStick/x", offset = 0u, format = "SHRT", parameters = "clamp=false,invert=false,normalize=false")]
	[InputControl(name = "leftStick", layout = "Stick", format = "VC2S")]
	[InputControl(name = "leftStick/left", offset = 0u, format = "SHRT")]
	[InputControl(name = "leftStick/right", offset = 0u, format = "SHRT")]
	[InputControl(name = "leftStick/y", offset = 2u, format = "SHRT", parameters = "clamp=false,invert=false,normalize=false")]
	[InputControl(name = "leftStick/up", offset = 2u, format = "SHRT")]
	[InputControl(name = "leftStick/down", offset = 2u, format = "SHRT")]
	public short leftStickX;

	[FieldOffset(6)]
	public short leftStickY;

	[FieldOffset(8)]
	[InputControl(name = "rightStick/up", offset = 2u, format = "SHRT")]
	[InputControl(name = "rightStick", layout = "Stick", format = "VC2S")]
	[InputControl(name = "rightStick/left", offset = 0u, format = "SHRT")]
	[InputControl(name = "rightStick/right", offset = 0u, format = "SHRT")]
	[InputControl(name = "rightStick/x", offset = 0u, format = "SHRT", parameters = "clamp=false,invert=false,normalize=false")]
	[InputControl(name = "rightStick/down", offset = 2u, format = "SHRT")]
	[InputControl(name = "rightStick/y", offset = 2u, format = "SHRT", parameters = "clamp=false,invert=false,normalize=false")]
	public short rightStickX;

	[FieldOffset(10)]
	public short rightStickY;

	public FourCC format => default(FourCC);

	public XInputControllerWindowsState WithButton(Button button)
	{
		return default(XInputControllerWindowsState);
	}
}
