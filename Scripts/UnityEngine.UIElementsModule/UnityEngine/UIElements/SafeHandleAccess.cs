using System;

namespace UnityEngine.UIElements;

internal struct SafeHandleAccess
{
	private IntPtr m_Handle;

	public SafeHandleAccess(IntPtr ptr)
	{
		m_Handle = (IntPtr)0;
	}

	public bool IsNull()
	{
		return false;
	}

	public static implicit operator IntPtr(SafeHandleAccess a)
	{
		return (IntPtr)0;
	}
}
