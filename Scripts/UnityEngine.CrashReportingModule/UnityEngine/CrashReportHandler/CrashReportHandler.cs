using UnityEngine.Bindings;

namespace UnityEngine.CrashReportHandler;

[NativeHeader("Modules/CrashReporting/Public/CrashReporter.h")]
[StaticAccessor("CrashReporting::CrashReporter::Get()", StaticAccessorType.Dot)]
public class CrashReportHandler
{
	[NativeThrows]
	public static uint logBufferSize
	{
		set
		{
		}
	}
}
