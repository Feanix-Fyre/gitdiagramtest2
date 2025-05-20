using System;
using System.Collections.Generic;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.HID;

public class HID : InputDevice
{
	[Serializable]
	private class HIDLayoutBuilder
	{
		public string displayName;

		public HIDDeviceDescriptor hidDescriptor;

		public string parentLayout;

		public Type deviceType;

		public InputControlLayout Build()
		{
			return null;
		}
	}

	public enum HIDReportType
	{
		Unknown = 0,
		Input = 1,
		Output = 2,
		Feature = 3
	}

	public enum HIDCollectionType
	{
		Physical = 0,
		Application = 1,
		Logical = 2,
		Report = 3,
		NamedArray = 4,
		UsageSwitch = 5,
		UsageModifier = 6
	}

	[Flags]
	public enum HIDElementFlags
	{
		Constant = 1,
		Variable = 2,
		Relative = 4,
		Wrap = 8,
		NonLinear = 0x10,
		NoPreferred = 0x20,
		NullState = 0x40,
		Volatile = 0x80,
		BufferedBytes = 0x100
	}

	[Serializable]
	public struct HIDElementDescriptor
	{
		public int usage;

		public UsagePage usagePage;

		public int unit;

		public int unitExponent;

		public int logicalMin;

		public int logicalMax;

		public int physicalMin;

		public int physicalMax;

		public HIDReportType reportType;

		public int collectionIndex;

		public int reportId;

		public int reportSizeInBits;

		public int reportOffsetInBits;

		public HIDElementFlags flags;

		public int? usageMin;

		public int? usageMax;

		public bool hasNullState => false;

		public bool hasPreferredState => false;

		public bool isArray => false;

		public bool isNonLinear => false;

		public bool isRelative => false;

		public bool isConstant => false;

		public bool isWrapping => false;

		internal bool isSigned => false;

		internal float minFloatValue => 0f;

		internal float maxFloatValue => 0f;

		public bool Is(UsagePage usagePage, int usage)
		{
			return false;
		}

		internal string DetermineName()
		{
			return null;
		}

		internal string DetermineDisplayName()
		{
			return null;
		}

		internal bool IsUsableElement()
		{
			return false;
		}

		internal string DetermineLayout()
		{
			return null;
		}

		internal FourCC DetermineFormat()
		{
			return default(FourCC);
		}

		internal InternedString[] DetermineUsages()
		{
			return null;
		}

		internal string DetermineParameters()
		{
			return null;
		}

		private string DetermineAxisNormalizationParameters()
		{
			return null;
		}

		internal string DetermineProcessors()
		{
			return null;
		}

		internal PrimitiveValue DetermineDefaultState()
		{
			return default(PrimitiveValue);
		}

		internal void AddChildControls(ref HIDElementDescriptor element, string controlName, ref InputControlLayout.Builder builder)
		{
		}
	}

	[Serializable]
	public struct HIDCollectionDescriptor
	{
		public HIDCollectionType type;

		public int usage;

		public UsagePage usagePage;

		public int parent;

		public int childCount;

		public int firstChild;
	}

	[Serializable]
	public struct HIDDeviceDescriptor
	{
		public int vendorId;

		public int productId;

		public int usage;

		public UsagePage usagePage;

		public int inputReportSize;

		public int outputReportSize;

		public int featureReportSize;

		public HIDElementDescriptor[] elements;

		public HIDCollectionDescriptor[] collections;

		public string ToJson()
		{
			return null;
		}

		public static HIDDeviceDescriptor FromJson(string json)
		{
			return default(HIDDeviceDescriptor);
		}
	}

	public struct HIDDeviceDescriptorBuilder
	{
		public UsagePage usagePage;

		public int usage;

		private int m_CurrentReportId;

		private HIDReportType m_CurrentReportType;

		private int m_CurrentReportOffsetInBits;

		private List<HIDElementDescriptor> m_Elements;

		private List<HIDCollectionDescriptor> m_Collections;

		private int m_InputReportSize;

		private int m_OutputReportSize;

		private int m_FeatureReportSize;

		public HIDDeviceDescriptorBuilder(UsagePage usagePage, int usage)
		{
			this.usagePage = default(UsagePage);
			this.usage = 0;
			m_CurrentReportId = 0;
			m_CurrentReportType = default(HIDReportType);
			m_CurrentReportOffsetInBits = 0;
			m_Elements = null;
			m_Collections = null;
			m_InputReportSize = 0;
			m_OutputReportSize = 0;
			m_FeatureReportSize = 0;
		}

		public HIDDeviceDescriptorBuilder(GenericDesktop usage)
		{
			usagePage = default(UsagePage);
			this.usage = 0;
			m_CurrentReportId = 0;
			m_CurrentReportType = default(HIDReportType);
			m_CurrentReportOffsetInBits = 0;
			m_Elements = null;
			m_Collections = null;
			m_InputReportSize = 0;
			m_OutputReportSize = 0;
			m_FeatureReportSize = 0;
		}

		public HIDDeviceDescriptorBuilder StartReport(HIDReportType reportType, int reportId = 1)
		{
			return default(HIDDeviceDescriptorBuilder);
		}

		public HIDDeviceDescriptorBuilder AddElement(UsagePage usagePage, int usage, int sizeInBits)
		{
			return default(HIDDeviceDescriptorBuilder);
		}

		public HIDDeviceDescriptorBuilder AddElement(GenericDesktop usage, int sizeInBits)
		{
			return default(HIDDeviceDescriptorBuilder);
		}

		public HIDDeviceDescriptorBuilder WithPhysicalMinMax(int min, int max)
		{
			return default(HIDDeviceDescriptorBuilder);
		}

		public HIDDeviceDescriptorBuilder WithLogicalMinMax(int min, int max)
		{
			return default(HIDDeviceDescriptorBuilder);
		}

		public HIDDeviceDescriptor Finish()
		{
			return default(HIDDeviceDescriptor);
		}
	}

	public enum UsagePage
	{
		Undefined = 0,
		GenericDesktop = 1,
		Simulation = 2,
		VRControls = 3,
		SportControls = 4,
		GameControls = 5,
		GenericDeviceControls = 6,
		Keyboard = 7,
		LEDs = 8,
		Button = 9,
		Ordinal = 10,
		Telephony = 11,
		Consumer = 12,
		Digitizer = 13,
		PID = 15,
		Unicode = 16,
		AlphanumericDisplay = 20,
		MedicalInstruments = 64,
		Monitor = 128,
		Power = 132,
		BarCodeScanner = 140,
		MagneticStripeReader = 142,
		Camera = 144,
		Arcade = 145,
		VendorDefined = 65280
	}

	public enum GenericDesktop
	{
		Undefined = 0,
		Pointer = 1,
		Mouse = 2,
		Joystick = 4,
		Gamepad = 5,
		Keyboard = 6,
		Keypad = 7,
		MultiAxisController = 8,
		TabletPCControls = 9,
		AssistiveControl = 10,
		X = 48,
		Y = 49,
		Z = 50,
		Rx = 51,
		Ry = 52,
		Rz = 53,
		Slider = 54,
		Dial = 55,
		Wheel = 56,
		HatSwitch = 57,
		CountedBuffer = 58,
		ByteCount = 59,
		MotionWakeup = 60,
		Start = 61,
		Select = 62,
		Vx = 64,
		Vy = 65,
		Vz = 66,
		Vbrx = 67,
		Vbry = 68,
		Vbrz = 69,
		Vno = 70,
		FeatureNotification = 71,
		ResolutionMultiplier = 72,
		SystemControl = 128,
		SystemPowerDown = 129,
		SystemSleep = 130,
		SystemWakeUp = 131,
		SystemContextMenu = 132,
		SystemMainMenu = 133,
		SystemAppMenu = 134,
		SystemMenuHelp = 135,
		SystemMenuExit = 136,
		SystemMenuSelect = 137,
		SystemMenuRight = 138,
		SystemMenuLeft = 139,
		SystemMenuUp = 140,
		SystemMenuDown = 141,
		SystemColdRestart = 142,
		SystemWarmRestart = 143,
		DpadUp = 144,
		DpadDown = 145,
		DpadRight = 146,
		DpadLeft = 147,
		SystemDock = 160,
		SystemUndock = 161,
		SystemSetup = 162,
		SystemBreak = 163,
		SystemDebuggerBreak = 164,
		ApplicationBreak = 165,
		ApplicationDebuggerBreak = 166,
		SystemSpeakerMute = 167,
		SystemHibernate = 168,
		SystemDisplayInvert = 176,
		SystemDisplayInternal = 177,
		SystemDisplayExternal = 178,
		SystemDisplayBoth = 179,
		SystemDisplayDual = 180,
		SystemDisplayToggleIntExt = 181,
		SystemDisplaySwapPrimarySecondary = 182,
		SystemDisplayLCDAutoScale = 183
	}

	public enum Simulation
	{
		Undefined = 0,
		FlightSimulationDevice = 1,
		AutomobileSimulationDevice = 2,
		TankSimulationDevice = 3,
		SpaceshipSimulationDevice = 4,
		SubmarineSimulationDevice = 5,
		SailingSimulationDevice = 6,
		MotorcycleSimulationDevice = 7,
		SportsSimulationDevice = 8,
		AirplaneSimulationDevice = 9,
		HelicopterSimulationDevice = 10,
		MagicCarpetSimulationDevice = 11,
		BicylcleSimulationDevice = 12,
		FlightControlStick = 32,
		FlightStick = 33,
		CyclicControl = 34,
		CyclicTrim = 35,
		FlightYoke = 36,
		TrackControl = 37,
		Aileron = 176,
		AileronTrim = 177,
		AntiTorqueControl = 178,
		AutopilotEnable = 179,
		ChaffRelease = 180,
		CollectiveControl = 181,
		DiveBreak = 182,
		ElectronicCountermeasures = 183,
		Elevator = 184,
		ElevatorTrim = 185,
		Rudder = 186,
		Throttle = 187,
		FlightCommunications = 188,
		FlareRelease = 189,
		LandingGear = 190,
		ToeBreak = 191,
		Trigger = 192,
		WeaponsArm = 193,
		WeaponsSelect = 194,
		WingFlaps = 195,
		Accelerator = 196,
		Brake = 197,
		Clutch = 198,
		Shifter = 199,
		Steering = 200,
		TurretDirection = 201,
		BarrelElevation = 202,
		DivePlane = 203,
		Ballast = 204,
		BicycleCrank = 205,
		HandleBars = 206,
		FrontBrake = 207,
		RearBrake = 208
	}

	public enum Button
	{
		Undefined = 0,
		Primary = 1,
		Secondary = 2,
		Tertiary = 3
	}

	internal const string kHIDInterface = "HID";

	internal const string kHIDNamespace = "HID";

	private bool m_HaveParsedHIDDescriptor;

	private HIDDeviceDescriptor m_HIDDescriptor;

	public static FourCC QueryHIDReportDescriptorDeviceCommandType => default(FourCC);

	public static FourCC QueryHIDReportDescriptorSizeDeviceCommandType => default(FourCC);

	public static FourCC QueryHIDParsedReportDescriptorDeviceCommandType => default(FourCC);

	public HIDDeviceDescriptor hidDescriptor => default(HIDDeviceDescriptor);

	internal static string OnFindLayoutForDevice(ref InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeDeviceCommand)
	{
		return null;
	}

	internal static HIDDeviceDescriptor ReadHIDDeviceDescriptor(ref InputDeviceDescription deviceDescription, InputDeviceExecuteCommandDelegate executeCommandDelegate)
	{
		return default(HIDDeviceDescriptor);
	}

	public static string UsagePageToString(UsagePage usagePage)
	{
		return null;
	}

	public static string UsageToString(UsagePage usagePage, int usage)
	{
		return null;
	}
}
