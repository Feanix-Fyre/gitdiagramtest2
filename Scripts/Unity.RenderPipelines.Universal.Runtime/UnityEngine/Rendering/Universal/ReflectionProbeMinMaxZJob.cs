using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal;

[BurstCompile]
internal struct ReflectionProbeMinMaxZJob : IJobFor
{
	public Fixed2<float4x4> worldToViews;

	[ReadOnly]
	public NativeArray<VisibleReflectionProbe> reflectionProbes;

	public NativeArray<float2> minMaxZs;

	public void Execute(int index)
	{
	}
}
