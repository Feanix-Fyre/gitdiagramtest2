using System;

namespace UnityEngine.Rendering;

[Serializable]
public struct SphericalHarmonicsL1
{
	public Vector4 shAr;

	public Vector4 shAg;

	public Vector4 shAb;

	public static readonly SphericalHarmonicsL1 zero;

	public static SphericalHarmonicsL1 operator +(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs)
	{
		return default(SphericalHarmonicsL1);
	}

	public static SphericalHarmonicsL1 operator -(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs)
	{
		return default(SphericalHarmonicsL1);
	}

	public static SphericalHarmonicsL1 operator *(SphericalHarmonicsL1 lhs, float rhs)
	{
		return default(SphericalHarmonicsL1);
	}

	public static SphericalHarmonicsL1 operator /(SphericalHarmonicsL1 lhs, float rhs)
	{
		return default(SphericalHarmonicsL1);
	}

	public static bool operator ==(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs)
	{
		return false;
	}

	public static bool operator !=(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs)
	{
		return false;
	}

	public override bool Equals(object other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
