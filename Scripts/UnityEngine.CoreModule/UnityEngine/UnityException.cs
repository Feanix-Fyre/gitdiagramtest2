using System;
using System.Runtime.Serialization;
using UnityEngine.Scripting;

namespace UnityEngine;

[Serializable]
[RequiredByNativeCode]
public class UnityException : Exception
{
	public UnityException()
	{
	}

	public UnityException(string message)
	{
	}

	protected UnityException(SerializationInfo info, StreamingContext context)
	{
	}
}
