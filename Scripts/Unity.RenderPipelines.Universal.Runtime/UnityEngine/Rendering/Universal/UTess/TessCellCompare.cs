using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal.UTess;

[StructLayout((LayoutKind)0, Size = 1)]
internal struct TessCellCompare : IComparer<int3>
{
	public int Compare(int3 a, int3 b)
	{
		return 0;
	}
}
