using UnityEngine.Bindings;

namespace UnityEngine;

public class ColorGamutUtility
{
	[FreeFunction(IsThreadSafe = true)]
	public static ColorPrimaries GetColorPrimaries(ColorGamut gamut)
	{
		return default(ColorPrimaries);
	}

	[FreeFunction(IsThreadSafe = true)]
	public static WhitePoint GetWhitePoint(ColorGamut gamut)
	{
		return default(WhitePoint);
	}

	[FreeFunction(IsThreadSafe = true)]
	public static TransferFunction GetTransferFunction(ColorGamut gamut)
	{
		return default(TransferFunction);
	}
}
