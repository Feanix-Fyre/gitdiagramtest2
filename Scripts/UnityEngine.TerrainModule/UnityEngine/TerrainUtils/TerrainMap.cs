using System;
using System.Collections.Generic;

namespace UnityEngine.TerrainUtils;

public class TerrainMap
{
	private Vector3 m_patchSize;

	private TerrainMapStatusCode m_errorCode;

	private Dictionary<TerrainTileCoord, Terrain> m_terrainTiles;

	public Dictionary<TerrainTileCoord, Terrain> terrainTiles => null;

	public Terrain GetTerrain(int tileX, int tileZ)
	{
		return null;
	}

	public static TerrainMap CreateFromPlacement(Terrain originTerrain, Predicate<Terrain> filter = null, bool fullValidation = true)
	{
		return null;
	}

	public static TerrainMap CreateFromPlacement(Vector2 gridOrigin, Vector2 gridSize, Predicate<Terrain> filter = null, bool fullValidation = true)
	{
		return null;
	}

	private void AddTerrainInternal(int x, int z, Terrain terrain)
	{
	}

	private bool TryToAddTerrain(int tileX, int tileZ, Terrain terrain)
	{
		return false;
	}

	private void ValidateTerrain(int tileX, int tileZ)
	{
	}

	private TerrainMapStatusCode Validate()
	{
		return default(TerrainMapStatusCode);
	}
}
