namespace UnityEngine.Rendering;

public class SphericalHarmonicsL2Utils
{
	public static void GetL1(SphericalHarmonicsL2 sh, out Vector3 L1_R, out Vector3 L1_G, out Vector3 L1_B)
	{
		L1_R = default(Vector3);
		L1_G = default(Vector3);
		L1_B = default(Vector3);
	}

	public static void GetL2(SphericalHarmonicsL2 sh, out Vector3 L2_0, out Vector3 L2_1, out Vector3 L2_2, out Vector3 L2_3, out Vector3 L2_4)
	{
		L2_0 = default(Vector3);
		L2_1 = default(Vector3);
		L2_2 = default(Vector3);
		L2_3 = default(Vector3);
		L2_4 = default(Vector3);
	}

	public static void SetL0(ref SphericalHarmonicsL2 sh, Vector3 L0)
	{
	}

	public static void SetL1R(ref SphericalHarmonicsL2 sh, Vector3 L1_R)
	{
	}

	public static void SetL1G(ref SphericalHarmonicsL2 sh, Vector3 L1_G)
	{
	}

	public static void SetL1B(ref SphericalHarmonicsL2 sh, Vector3 L1_B)
	{
	}

	public static void SetL1(ref SphericalHarmonicsL2 sh, Vector3 L1_R, Vector3 L1_G, Vector3 L1_B)
	{
	}

	public static void SetCoefficient(ref SphericalHarmonicsL2 sh, int index, Vector3 coefficient)
	{
	}

	public static Vector3 GetCoefficient(SphericalHarmonicsL2 sh, int index)
	{
		return default(Vector3);
	}
}
