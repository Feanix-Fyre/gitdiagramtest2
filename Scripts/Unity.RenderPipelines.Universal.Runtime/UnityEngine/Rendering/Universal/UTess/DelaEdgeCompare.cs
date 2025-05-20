using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal.UTess;

[StructLayout((LayoutKind)0, Size = 1)]
internal struct DelaEdgeCompare : IComparer<int4>
{
	public int Compare(int4 a, int4 b)
	{
		return 0;
	}
}
