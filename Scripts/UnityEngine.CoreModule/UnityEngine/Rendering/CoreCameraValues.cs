using System;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering;

[UsedByNativeCode]
internal struct CoreCameraValues : IEquatable<CoreCameraValues>
{
	private int filterMode;

	private uint cullingMask;

	private int instanceID;

	public bool Equals(CoreCameraValues other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
