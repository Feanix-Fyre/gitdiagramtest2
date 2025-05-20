using System;

namespace UnityEngine;

public class AndroidJavaProxy
{
	public readonly AndroidJavaClass javaInterface;

	internal IntPtr proxyObject;

	private static readonly GlobalJavaObjectRef s_JavaLangSystemClass;

	private static readonly IntPtr s_HashCodeMethodID;

	public AndroidJavaProxy(string javaInterface)
	{
	}

	public AndroidJavaProxy(AndroidJavaClass javaInterface)
	{
	}

	~AndroidJavaProxy()
	{
	}

	public virtual AndroidJavaObject Invoke(string methodName, object[] args)
	{
		return null;
	}

	public virtual AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs)
	{
		return null;
	}

	public virtual IntPtr Invoke(string methodName, IntPtr javaArgs)
	{
		return (IntPtr)0;
	}

	public virtual bool equals(AndroidJavaObject obj)
	{
		return false;
	}

	public virtual int hashCode()
	{
		return 0;
	}

	public virtual string toString()
	{
		return null;
	}

	internal AndroidJavaObject GetProxyObject()
	{
		return null;
	}

	internal IntPtr GetRawProxy()
	{
		return (IntPtr)0;
	}
}
