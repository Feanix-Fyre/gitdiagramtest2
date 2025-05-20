using System;

namespace UnityEngine;

internal class GlobalJavaObjectRef
{
	private bool m_disposed;

	protected IntPtr m_jobject;

	public GlobalJavaObjectRef(IntPtr jobject)
	{
	}

	~GlobalJavaObjectRef()
	{
	}

	public static implicit operator IntPtr(GlobalJavaObjectRef obj)
	{
		return (IntPtr)0;
	}

	public void Dispose()
	{
	}
}
