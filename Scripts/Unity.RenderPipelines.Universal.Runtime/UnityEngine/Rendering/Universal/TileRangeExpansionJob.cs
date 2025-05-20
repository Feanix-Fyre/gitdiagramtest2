using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal;

[BurstCompile(FloatMode = FloatMode.Fast, DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
internal struct TileRangeExpansionJob : IJobFor
{
	[ReadOnly]
	public NativeArray<InclusiveRange> tileRanges;

	[NativeDisableParallelForRestriction]
	public NativeArray<uint> tileMasks;

	public int rangesPerItem;

	public int itemsPerTile;

	public int wordsPerTile;

	public int2 tileResolution;

	public void Execute(int jobIndex)
	{
	}
}
