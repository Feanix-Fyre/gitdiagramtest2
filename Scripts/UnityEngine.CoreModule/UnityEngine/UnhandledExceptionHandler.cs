using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("PlatformDependent/iPhonePlayer/IOSScriptBindings.h")]
internal sealed class UnhandledExceptionHandler
{
	[RequiredByNativeCode]
	private static void RegisterUECatcher()
	{
	}
}
