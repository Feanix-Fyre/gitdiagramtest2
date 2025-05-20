namespace UnityEngine.Experimental.GlobalIllumination;

public static class LightmapperUtils
{
	public static LightMode Extract(LightmapBakeType baketype)
	{
		return default(LightMode);
	}

	public static LinearColor ExtractIndirect(Light l)
	{
		return default(LinearColor);
	}

	public static float ExtractInnerCone(Light l)
	{
		return 0f;
	}

	private static Color ExtractColorTemperature(Light l)
	{
		return default(Color);
	}

	private static void ApplyColorTemperature(Color cct, ref LinearColor lightColor)
	{
	}

	public static void Extract(Light l, ref DirectionalLight dir)
	{
	}

	public static void Extract(Light l, ref PointLight point)
	{
	}

	public static void Extract(Light l, ref SpotLight spot)
	{
	}

	public static void Extract(Light l, ref RectangleLight rect)
	{
	}

	public static void Extract(Light l, ref DiscLight disc)
	{
	}

	public static void Extract(Light l, out Cookie cookie)
	{
		cookie = default(Cookie);
	}
}
