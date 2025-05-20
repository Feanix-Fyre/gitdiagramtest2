using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine.AI;

[StaticAccessor("NavMeshBuilderBindings", StaticAccessorType.DoubleColon)]
[NativeHeader("Modules/AI/Builder/NavMeshBuilder.bindings.h")]
public static class NavMeshBuilder
{
	public static void CollectSources(Bounds includedWorldBounds, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, bool generateLinksByDefault, List<NavMeshBuildMarkup> markups, bool includeOnlyMarkedObjects, List<NavMeshBuildSource> results)
	{
	}

	public static void CollectSources(Transform root, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, bool generateLinksByDefault, List<NavMeshBuildMarkup> markups, bool includeOnlyMarkedObjects, List<NavMeshBuildSource> results)
	{
	}

	private static NavMeshBuildSource[] CollectSourcesInternal(int includedLayerMask, Bounds includedWorldBounds, Transform root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, bool generateLinksByDefault, NavMeshBuildMarkup[] markups, bool includeOnlyMarkedObjects)
	{
		return null;
	}

	public static NavMeshData BuildNavMeshData(NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds, Vector3 position, Quaternion rotation)
	{
		return null;
	}

	private static bool UpdateNavMeshDataListInternal(NavMeshData data, NavMeshBuildSettings buildSettings, object sources, Bounds localBounds)
	{
		return false;
	}

	public static AsyncOperation UpdateNavMeshDataAsync(NavMeshData data, NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds)
	{
		return null;
	}

	private static AsyncOperation UpdateNavMeshDataAsyncListInternal(NavMeshData data, NavMeshBuildSettings buildSettings, object sources, Bounds localBounds)
	{
		return null;
	}

	private static NavMeshBuildSource[] CollectSourcesInternal_Injected(int includedLayerMask, ref Bounds includedWorldBounds, Transform root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, bool generateLinksByDefault, NavMeshBuildMarkup[] markups, bool includeOnlyMarkedObjects)
	{
		return null;
	}

	private static bool UpdateNavMeshDataListInternal_Injected(NavMeshData data, ref NavMeshBuildSettings buildSettings, object sources, ref Bounds localBounds)
	{
		return false;
	}

	private static AsyncOperation UpdateNavMeshDataAsyncListInternal_Injected(NavMeshData data, ref NavMeshBuildSettings buildSettings, object sources, ref Bounds localBounds)
	{
		return null;
	}
}
