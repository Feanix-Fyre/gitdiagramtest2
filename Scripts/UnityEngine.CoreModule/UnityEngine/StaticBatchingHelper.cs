using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine;

[StructLayout((LayoutKind)0, Size = 1)]
[NativeHeader("Runtime/Graphics/Mesh/StaticBatching.h")]
internal struct StaticBatchingHelper
{
	[FreeFunction("StaticBatching::CombineMeshesForStaticBatching")]
	internal static void CombineMeshes(GameObject[] gos, GameObject staticBatchRoot)
	{
	}
}
