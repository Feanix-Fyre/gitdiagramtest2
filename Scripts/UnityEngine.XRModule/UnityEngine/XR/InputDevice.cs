using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
[UsedByNativeCode]
public struct InputDevice : IEquatable<InputDevice>
{
	private ulong m_DeviceId;

	private bool m_Initialized;

	private ulong deviceId => 0uL;

	internal InputDevice(ulong deviceId)
	{
		m_DeviceId = 0uL;
		m_Initialized = false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(InputDevice other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
