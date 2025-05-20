using System;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine;

[StructLayout((LayoutKind)0)]
[UsedByNativeCode]
public class TrackedReference
{
	internal IntPtr m_Ptr;

	protected TrackedReference()
	{
	}

	public static bool operator ==(TrackedReference x, TrackedReference y)
	{
		return false;
	}

	public static bool operator !=(TrackedReference x, TrackedReference y)
	{
		return false;
	}

	public override bool Equals(object o)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static implicit operator bool(TrackedReference exists)
	{
		return false;
	}
}
