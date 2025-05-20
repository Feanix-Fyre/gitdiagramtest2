using System;

namespace UnityEngine.Rendering;

[Serializable]
[Obsolete("BatchRendererGroupGlobals and associated cbuffer are now set automatically by Unity. Setting it manually is no longer necessary or supported.")]
public struct BatchRendererGroupGlobals : IEquatable<BatchRendererGroupGlobals>
{
	public const string kGlobalsPropertyName = "unity_DOTSInstanceGlobalValues";

	public static readonly int kGlobalsPropertyId;

	public Vector4 ProbesOcclusion;

	public Vector4 SpecCube0_HDR;

	public Vector4 SpecCube1_HDR;

	public SHCoefficients SHCoefficients;

	public static BatchRendererGroupGlobals Default => default(BatchRendererGroupGlobals);

	public bool Equals(BatchRendererGroupGlobals other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(BatchRendererGroupGlobals left, BatchRendererGroupGlobals right)
	{
		return false;
	}

	public static bool operator !=(BatchRendererGroupGlobals left, BatchRendererGroupGlobals right)
	{
		return false;
	}
}
