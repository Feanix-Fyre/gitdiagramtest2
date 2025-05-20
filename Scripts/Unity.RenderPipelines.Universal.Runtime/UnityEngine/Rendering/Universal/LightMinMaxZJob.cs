using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal;

[BurstCompile]
internal struct LightMinMaxZJob : IJobFor
{
	public Fixed2<float4x4> worldToViews;

	[ReadOnly]
	public NativeArray<VisibleLight> lights;

	public NativeArray<float2> minMaxZs;

	public void Execute(int index)
	{
	}
}
