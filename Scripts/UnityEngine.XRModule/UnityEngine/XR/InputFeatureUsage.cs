using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR;

[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[RequiredByNativeCode]
[NativeConditional("ENABLE_VR")]
public struct InputFeatureUsage : IEquatable<InputFeatureUsage>
{
	internal string m_Name;

	[NativeName("m_FeatureType")]
	internal InputFeatureType m_InternalType;

	public string name => null;

	internal InputFeatureType internalType => default(InputFeatureType);

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(InputFeatureUsage other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
