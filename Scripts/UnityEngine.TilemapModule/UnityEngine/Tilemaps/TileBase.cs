using UnityEngine.Scripting;

namespace UnityEngine.Tilemaps;

[RequiredByNativeCode]
public abstract class TileBase : ScriptableObject
{
	[RequiredByNativeCode]
	public virtual void RefreshTile(Vector3Int position, ITilemap tilemap)
	{
	}

	[RequiredByNativeCode]
	public virtual void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
	{
	}

	private TileData GetTileDataNoRef(Vector3Int position, ITilemap tilemap)
	{
		return default(TileData);
	}

	[RequiredByNativeCode]
	public virtual bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData)
	{
		return false;
	}

	private TileAnimationData GetTileAnimationDataNoRef(Vector3Int position, ITilemap tilemap)
	{
		return default(TileAnimationData);
	}

	[RequiredByNativeCode]
	private void GetTileAnimationDataRef(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData, ref bool hasAnimation)
	{
	}

	[RequiredByNativeCode]
	public virtual bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go)
	{
		return false;
	}

	[RequiredByNativeCode]
	private void StartUpRef(Vector3Int position, ITilemap tilemap, GameObject go, ref bool startUpInvokedByUser)
	{
	}
}
