using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
[NativeHeader("Modules/XR/XRPrefix.h")]
[NativeHeader("XRScriptingClasses.h")]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[StaticAccessor("XRInputDevices::Get()", StaticAccessorType.Dot)]
[RequiredByNativeCode]
public struct Eyes : IEquatable<Eyes>
{
	private ulong m_DeviceId;

	private uint m_FeatureIndex;

	internal ulong deviceId => 0uL;

	internal uint featureIndex => 0u;

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(Eyes other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
