using System.Runtime.InteropServices;
using Unity.IL2CPP.CompilerServices;

namespace UnityEngineInternal;

[StructLayout((LayoutKind)0, Size = 1)]
[Il2CppEagerStaticClassConstruction]
public struct MathfInternal
{
	public static float FloatMinNormal;

	public static float FloatMinDenormal;

	public static bool IsFlushToZeroEnabled;
}
