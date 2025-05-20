using System;

namespace UnityEngine.Rendering;

[Serializable]
public struct SHCoefficients : IEquatable<SHCoefficients>
{
	public Vector4 SHAr;

	public Vector4 SHAg;

	public Vector4 SHAb;

	public Vector4 SHBr;

	public Vector4 SHBg;

	public Vector4 SHBb;

	public Vector4 SHC;

	public Vector4 ProbesOcclusion;

	public SHCoefficients(SphericalHarmonicsL2 sh)
	{
		SHAr = default(Vector4);
		SHAg = default(Vector4);
		SHAb = default(Vector4);
		SHBr = default(Vector4);
		SHBg = default(Vector4);
		SHBb = default(Vector4);
		SHC = default(Vector4);
		ProbesOcclusion = default(Vector4);
	}

	public SHCoefficients(SphericalHarmonicsL2 sh, Vector4 probesOcclusion)
	{
		SHAr = default(Vector4);
		SHAg = default(Vector4);
		SHAb = default(Vector4);
		SHBr = default(Vector4);
		SHBg = default(Vector4);
		SHBb = default(Vector4);
		SHC = default(Vector4);
		ProbesOcclusion = default(Vector4);
	}

	private static Vector4 GetSHA(SphericalHarmonicsL2 sh, int i)
	{
		return default(Vector4);
	}

	private static Vector4 GetSHB(SphericalHarmonicsL2 sh, int i)
	{
		return default(Vector4);
	}

	private static Vector4 GetSHC(SphericalHarmonicsL2 sh)
	{
		return default(Vector4);
	}

	public bool Equals(SHCoefficients other)
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

	public static bool operator ==(SHCoefficients left, SHCoefficients right)
	{
		return false;
	}

	public static bool operator !=(SHCoefficients left, SHCoefficients right)
	{
		return false;
	}
}
