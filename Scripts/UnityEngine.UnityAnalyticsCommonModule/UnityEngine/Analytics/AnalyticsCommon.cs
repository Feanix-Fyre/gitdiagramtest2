using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine.Analytics;

[StructLayout((LayoutKind)0)]
[NativeHeader("Modules/UnityAnalyticsCommon/Public/UnityAnalyticsCommon.h")]
public static class AnalyticsCommon
{
	[StaticAccessor("GetUnityAnalyticsCommon()", StaticAccessorType.Dot)]
	private static bool ugsAnalyticsEnabledInternal
	{
		[NativeMethod("SetUGSAnalyticsUserOptStatus")]
		set
		{
		}
	}

	public static bool ugsAnalyticsEnabled
	{
		set
		{
		}
	}
}
