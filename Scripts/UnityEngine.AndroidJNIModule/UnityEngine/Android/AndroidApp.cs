using System;
using UnityEngine.Bindings;

namespace UnityEngine.Android;

[NativeHeader("Modules/AndroidJNI/Public/AndroidApp.bindings.h")]
[StaticAccessor("AndroidApp", StaticAccessorType.DoubleColon)]
[NativeConditional("PLATFORM_ANDROID")]
internal static class AndroidApp
{
	public static IntPtr UnityPlayerRaw
	{
		[ThreadSafe]
		get
		{
			return (IntPtr)0;
		}
	}
}
