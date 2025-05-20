using System;

namespace UnityEngine;

public class AndroidJavaObject : IDisposable
{
	private static bool enableDebugPrints;

	internal GlobalJavaObjectRef m_jobject;

	internal GlobalJavaObjectRef m_jclass;

	public AndroidJavaObject(string className, params object[] args)
	{
	}

	public AndroidJavaObject(IntPtr jobject)
	{
	}

	public void Dispose()
	{
	}

	public IntPtr GetRawObject()
	{
		return (IntPtr)0;
	}

	public IntPtr GetRawClass()
	{
		return (IntPtr)0;
	}

	public ReturnType Call<ReturnType>(string methodName, params object[] args)
	{
		return default(ReturnType);
	}

	public ReturnType CallStatic<ReturnType>(string methodName, params object[] args)
	{
		return default(ReturnType);
	}

	protected void DebugPrint(string msg)
	{
	}

	private void _AndroidJavaObject(string className, params object[] args)
	{
	}

	private void _AndroidJavaObject(IntPtr constructorID, params object[] args)
	{
	}

	internal AndroidJavaObject()
	{
	}

	~AndroidJavaObject()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	protected ReturnType _Call<ReturnType>(string methodName, params object[] args)
	{
		return default(ReturnType);
	}

	protected ReturnType _Call<ReturnType>(IntPtr methodID, params object[] args)
	{
		return default(ReturnType);
	}

	protected ReturnType _CallStatic<ReturnType>(string methodName, params object[] args)
	{
		return default(ReturnType);
	}

	protected ReturnType _CallStatic<ReturnType>(IntPtr methodID, params object[] args)
	{
		return default(ReturnType);
	}

	internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject)
	{
		return null;
	}

	internal static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass)
	{
		return null;
	}

	internal static ReturnType FromJavaArrayDeleteLocalRef<ReturnType>(IntPtr jobject)
	{
		return default(ReturnType);
	}

	protected IntPtr _GetRawObject()
	{
		return (IntPtr)0;
	}

	protected IntPtr _GetRawClass()
	{
		return (IntPtr)0;
	}
}
