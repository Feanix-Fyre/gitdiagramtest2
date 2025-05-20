using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal;

[BurstCompile(FloatMode = FloatMode.Fast, DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
internal struct ZBinningJob : IJobFor
{
	public const int batchSize = 128;

	public const int headerLength = 2;

	[NativeDisableParallelForRestriction]
	public NativeArray<uint> bins;

	[ReadOnly]
	public NativeArray<float2> minMaxZs;

	public float zBinScale;

	public float zBinOffset;

	public int binCount;

	public int wordsPerTile;

	public int lightCount;

	public int reflectionProbeCount;

	public int batchCount;

	public int viewCount;

	public bool isOrthographic;

	private static uint EncodeHeader(uint min, uint max)
	{
		return 0u;
	}

	private static (uint, uint) DecodeHeader(uint zBin)
	{
		return default((uint, uint));
	}

	public void Execute(int jobIndex)
	{
	}

	private void FillZBins(int binStart, int binEnd, int itemStart, int itemEnd, int headerIndex, int itemOffset, int binOffset)
	{
	}
}
