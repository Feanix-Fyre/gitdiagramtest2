namespace UnityEngine.Rendering.Universal;

internal static class LayerUtility
{
	private static LayerBatch[] s_LayerBatches;

	public static uint maxTextureCount { get; private set; }

	public static void InitializeBudget(uint maxTextureCount)
	{
	}

	private static bool CanBatchLightsInLayer(int layerIndex1, int layerIndex2, SortingLayer[] sortingLayers, ILight2DCullResult lightCullResult)
	{
		return false;
	}

	private static int FindUpperBoundInBatch(int startLayerIndex, SortingLayer[] sortingLayers, ILight2DCullResult lightCullResult)
	{
		return 0;
	}

	private static void InitializeBatchInfos(SortingLayer[] cachedSortingLayers)
	{
	}

	public static LayerBatch[] CalculateBatches(ILight2DCullResult lightCullResult, out int batchCount)
	{
		batchCount = default(int);
		return null;
	}
}
