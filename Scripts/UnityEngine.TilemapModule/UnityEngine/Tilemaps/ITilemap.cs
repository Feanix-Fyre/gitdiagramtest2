using System;
using Unity.Collections;
using UnityEngine.Scripting;

namespace UnityEngine.Tilemaps;

[RequiredByNativeCode]
public class ITilemap
{
	internal static ITilemap s_Instance;

	internal Tilemap m_Tilemap;

	internal bool m_AddToList;

	internal int m_RefreshCount;

	internal NativeArray<Vector3Int> m_RefreshPos;

	internal ITilemap()
	{
	}

	public void RefreshTile(Vector3Int position)
	{
	}

	[RequiredByNativeCode]
	private static ITilemap CreateInstance()
	{
		return null;
	}

	[RequiredByNativeCode]
	private static void FindAllRefreshPositions(ITilemap tilemap, int count, IntPtr oldTilesIntPtr, IntPtr newTilesIntPtr, IntPtr positionsIntPtr)
	{
	}

	[RequiredByNativeCode]
	private static void GetAllTileData(ITilemap tilemap, int count, IntPtr tilesIntPtr, IntPtr positionsIntPtr, IntPtr outTileDataIntPtr)
	{
	}
}
