using System.Collections.Generic;

namespace UnityEngine.InputSystem.HID;

internal static class HIDParser
{
	private struct HIDReportData
	{
		public int reportId;

		public HID.HIDReportType reportType;

		public int currentBitOffset;

		public static int FindOrAddReport(int? reportId, HID.HIDReportType reportType, List<HIDReportData> reports)
		{
			return 0;
		}
	}

	private enum HIDItemTypeAndTag
	{
		Input = 128,
		Output = 144,
		Feature = 176,
		Collection = 160,
		EndCollection = 192,
		UsagePage = 4,
		LogicalMinimum = 20,
		LogicalMaximum = 36,
		PhysicalMinimum = 52,
		PhysicalMaximum = 68,
		UnitExponent = 84,
		Unit = 100,
		ReportSize = 116,
		ReportID = 132,
		ReportCount = 148,
		Push = 164,
		Pop = 180,
		Usage = 8,
		UsageMinimum = 24,
		UsageMaximum = 40,
		DesignatorIndex = 56,
		DesignatorMinimum = 72,
		DesignatorMaximum = 88,
		StringIndex = 120,
		StringMinimum = 136,
		StringMaximum = 152,
		Delimiter = 168
	}

	private struct HIDItemStateLocal
	{
		public int? usage;

		public int? usageMinimum;

		public int? usageMaximum;

		public int? designatorIndex;

		public int? designatorMinimum;

		public int? designatorMaximum;

		public int? stringIndex;

		public int? stringMinimum;

		public int? stringMaximum;

		public List<int> usageList;

		public static void Reset(ref HIDItemStateLocal state)
		{
		}

		public void SetUsage(int value)
		{
		}

		public int GetUsage(int index)
		{
			return 0;
		}
	}

	private struct HIDItemStateGlobal
	{
		public int? usagePage;

		public int? logicalMinimum;

		public int? logicalMaximum;

		public int? physicalMinimum;

		public int? physicalMaximum;

		public int? unitExponent;

		public int? unit;

		public int? reportSize;

		public int? reportCount;

		public int? reportId;

		public HID.UsagePage GetUsagePage(int index, ref HIDItemStateLocal localItemState)
		{
			return default(HID.UsagePage);
		}

		public int GetPhysicalMin()
		{
			return 0;
		}

		public int GetPhysicalMax()
		{
			return 0;
		}
	}

	public static bool ParseReportDescriptor(byte[] buffer, ref HID.HIDDeviceDescriptor deviceDescriptor)
	{
		return false;
	}

	public unsafe static bool ParseReportDescriptor(byte* bufferPtr, int bufferLength, ref HID.HIDDeviceDescriptor deviceDescriptor)
	{
		return false;
	}

	private unsafe static int ReadData(int itemSize, byte* currentPtr, byte* endPtr)
	{
		return 0;
	}
}
