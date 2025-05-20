using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering;

[NativeClass("BatchMaterialID")]
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
public struct BatchMaterialID : IEquatable<BatchMaterialID>
{
	public static readonly BatchMaterialID Null;

	public uint value;

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(BatchMaterialID other)
	{
		return false;
	}
}
