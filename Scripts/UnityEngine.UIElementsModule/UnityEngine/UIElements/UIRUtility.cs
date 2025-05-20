using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements;

internal static class UIRUtility
{
	public static readonly string k_DefaultShaderName;

	public static readonly string k_DefaultWorldSpaceShaderName;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool ShapeWindingIsClockwise(int maskDepth, int stencilRef)
	{
		return false;
	}

	public static bool IsRoundRect(VisualElement ve)
	{
		return false;
	}

	public static bool IsVectorImageBackground(VisualElement ve)
	{
		return false;
	}

	public static bool IsElementSelfHidden(VisualElement ve)
	{
		return false;
	}

	public static void Destroy(Object obj)
	{
	}

	public static int GetPrevPow2(int n)
	{
		return 0;
	}

	public static int GetNextPow2(int n)
	{
		return 0;
	}

	public static int GetNextPow2Exp(int n)
	{
		return 0;
	}
}
