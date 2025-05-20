using System;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem.XInput;

[InputControlLayout(displayName = "Xbox Controller")]
public class XInputController : Gamepad
{
	internal enum DeviceType
	{
		Gamepad = 0
	}

	public enum DeviceSubType
	{
		Unknown = 0,
		Gamepad = 1,
		Wheel = 2,
		ArcadeStick = 3,
		FlightStick = 4,
		DancePad = 5,
		Guitar = 6,
		GuitarAlternate = 7,
		DrumKit = 8,
		GuitarBass = 11,
		ArcadePad = 19
	}

	[Flags]
	public new enum DeviceFlags
	{
		ForceFeedbackSupported = 1,
		Wireless = 2,
		VoiceSupported = 4,
		PluginModulesSupported = 8,
		NoNavigation = 0x10
	}

	[Serializable]
	internal struct Capabilities
	{
		public DeviceType type;

		public DeviceSubType subType;

		public DeviceFlags flags;
	}

	private bool m_HaveParsedCapabilities;

	private DeviceSubType m_SubType;

	private DeviceFlags m_Flags;

	[InputControl(name = "start", displayName = "Menu", alias = "menu")]
	[InputControl(name = "buttonEast", displayName = "B")]
	[InputControl(name = "buttonWest", displayName = "X")]
	[InputControl(name = "leftTrigger", shortDisplayName = "LT")]
	[InputControl(name = "leftShoulder", displayName = "Left Bumper", shortDisplayName = "LB")]
	[InputControl(name = "buttonNorth", displayName = "Y")]
	[InputControl(name = "rightTrigger", shortDisplayName = "RT")]
	[InputControl(name = "buttonSouth", displayName = "A")]
	[InputControl(name = "rightShoulder", displayName = "Right Bumper", shortDisplayName = "RB")]
	[InputControl(name = "select", displayName = "View", alias = "view")]
	public ButtonControl menu { get; protected set; }

	public ButtonControl view { get; protected set; }

	public DeviceSubType subType => default(DeviceSubType);

	public DeviceFlags flags => default(DeviceFlags);

	protected override void FinishSetup()
	{
	}

	private void ParseCapabilities()
	{
	}
}
