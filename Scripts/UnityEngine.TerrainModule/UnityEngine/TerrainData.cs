using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Modules/Terrain/Public/TerrainDataScriptingInterface.h")]
[NativeHeader("TerrainScriptingClasses.h")]
[UsedByNativeCode]
public sealed class TerrainData : Object
{
	private enum BoundaryValueType
	{
		MaxHeightmapRes = 0,
		MinDetailResPerPatch = 1,
		MaxDetailResPerPatch = 2,
		MaxDetailPatchCount = 3,
		MaxCoveragePerRes = 4,
		MinAlphamapRes = 5,
		MaxAlphamapRes = 6,
		MinBaseMapRes = 7,
		MaxBaseMapRes = 8
	}

	internal static readonly int k_MaximumResolution;

	internal static readonly int k_MinimumDetailResolutionPerPatch;

	internal static readonly int k_MaximumDetailResolutionPerPatch;

	internal static readonly int k_MaximumDetailPatchCount;

	internal static readonly int k_MinimumAlphamapResolution;

	internal static readonly int k_MaximumAlphamapResolution;

	internal static readonly int k_MinimumBaseMapResolution;

	internal static readonly int k_MaximumBaseMapResolution;

	public int heightmapResolution => 0;

	private int internalHeightmapResolution
	{
		[NativeName("GetHeightmap().GetResolution")]
		get
		{
			return 0;
		}
	}

	public Vector3 heightmapScale
	{
		[NativeName("GetHeightmap().GetScale")]
		get
		{
			return default(Vector3);
		}
	}

	public Vector3 size
	{
		[NativeName("GetHeightmap().GetSize")]
		get
		{
			return default(Vector3);
		}
	}

	public TreeInstance[] treeInstances => null;

	public TreePrototype[] treePrototypes
	{
		[FreeFunction("TerrainDataScriptingInterface::GetTreePrototypes", HasExplicitThis = true)]
		get
		{
			return null;
		}
	}

	internal Terrain[] users => null;

	[StaticAccessor("TerrainDataScriptingInterface", StaticAccessorType.DoubleColon)]
	[ThreadSafe]
	private static int GetBoundaryValue(BoundaryValueType type)
	{
		return 0;
	}

	[FreeFunction("TerrainDataScriptingInterface::Create")]
	private static void Internal_Create([Writable] TerrainData terrainData)
	{
	}

	public float[,] GetHeights(int xBase, int yBase, int width, int height)
	{
		return null;
	}

	[FreeFunction("TerrainDataScriptingInterface::GetHeights", HasExplicitThis = true)]
	private float[,] Internal_GetHeights(int xBase, int yBase, int width, int height)
	{
		return null;
	}

	[NativeName("GetTreeDatabase().GetInstances")]
	private TreeInstance[] Internal_GetTreeInstances()
	{
		return null;
	}

	[RequiredByNativeCode]
	[NativeName("GetSplatDatabase().GetAlphamapResolution")]
	internal float GetAlphamapResolutionInternal()
	{
		return 0f;
	}

	[SpecialName]
	private void get_heightmapScale_Injected(out Vector3 ret)
	{
		ret = default(Vector3);
	}

	[SpecialName]
	private void get_size_Injected(out Vector3 ret)
	{
		ret = default(Vector3);
	}
}
