using System;

namespace UnityEngine;

public sealed class AndroidJavaException : Exception
{
	private string mJavaStackTrace;

	public override string StackTrace => null;

	internal AndroidJavaException(string message, string javaStackTrace)
	{
	}
}
