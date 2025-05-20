using System;

namespace UnityEngine;

public class AndroidJavaClass : AndroidJavaObject
{
	public AndroidJavaClass(string className)
		: base(null, null)
	{
	}

	private void _AndroidJavaClass(string className)
	{
	}

	internal AndroidJavaClass(IntPtr jclass)
		: base(null, null)
	{
	}
}
