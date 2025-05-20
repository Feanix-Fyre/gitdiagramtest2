using System;

namespace UnityEngine;

internal class AndroidJavaRunnableProxy : AndroidJavaProxy
{
	private AndroidJavaRunnable mRunnable;

	public AndroidJavaRunnableProxy(AndroidJavaRunnable runnable)
		: base((string)null)
	{
	}

	public void run()
	{
	}

	public override IntPtr Invoke(string methodName, IntPtr javaArgs)
	{
		return (IntPtr)0;
	}
}
