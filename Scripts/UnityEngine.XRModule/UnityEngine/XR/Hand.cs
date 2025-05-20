using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
[NativeHeader("XRScriptingClasses.h")]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[RequiredByNativeCode]
[NativeHeader("Modules/XR/XRPrefix.h")]
[StaticAccessor("XRInputDevices::Get()", StaticAccessorType.Dot)]
public struct Hand : IEquatable<Hand>
{
	private ulong m_DeviceId;

	private uint m_FeatureIndex;

	internal ulong deviceId => 0uL;

	internal uint featureIndex => 0u;

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(Hand other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
