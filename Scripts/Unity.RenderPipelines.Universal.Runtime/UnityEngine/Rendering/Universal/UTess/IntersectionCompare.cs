using System.Collections.Generic;
using Unity.Collections;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal.UTess;

internal struct IntersectionCompare : IComparer<int2>
{
	public NativeArray<double2> points;

	public NativeArray<int2> edges;

	public unsafe fixed double xvasort[4];

	public unsafe fixed double xvbsort[4];

	public int Compare(int2 a, int2 b)
	{
		return 0;
	}
}
