using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[UsedByNativeCode]
[StaticAccessor("GetITerrainManager()", StaticAccessorType.Arrow)]
[NativeHeader("TerrainScriptingClasses.h")]
[NativeHeader("Runtime/Interfaces/ITerrainManager.h")]
[NativeHeader("Modules/Terrain/Public/Terrain.h")]
public sealed class Terrain : Behaviour
{
	public TerrainData terrainData => null;

	public bool allowAutoConnect => false;

	public int groupingID => 0;

	public static Terrain activeTerrain => null;

	[NativeProperty("ActiveTerrainsScriptingArray")]
	public static Terrain[] activeTerrains => null;

	public void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom)
	{
	}

	public Vector3 GetPosition()
	{
		return default(Vector3);
	}

	private void GetPosition_Injected(out Vector3 ret)
	{
		ret = default(Vector3);
	}
}
