using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
[NativeClass("BatchID")]
public struct BatchID : IEquatable<BatchID>
{
	public static readonly BatchID Null;

	public uint value;

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(BatchID other)
	{
		return false;
	}
}
