using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Tilemaps;

[RequireComponent(typeof(Transform))]
[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
[NativeHeader("Modules/Grid/Public/Grid.h")]
[NativeHeader("Runtime/Graphics/SpriteFrame.h")]
[NativeHeader("Modules/Tilemap/Public/TilemapTile.h")]
[NativeType(Header = "Modules/Tilemap/Public/Tilemap.h")]
[NativeHeader("Modules/Tilemap/Public/TilemapMarshalling.h")]
public sealed class Tilemap : GridLayout
{
	[RequiredByNativeCode]
	public struct SyncTile
	{
		internal Vector3Int m_Position;

		internal TileBase m_Tile;

		internal TileData m_TileData;
	}

	internal struct SyncTileCallbackSettings
	{
		internal bool hasSyncTileCallback;

		internal bool hasPositionsChangedCallback;

		internal bool isBufferSyncTile;
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static Action<Tilemap, SyncTile[]> tilemapTileChanged;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static Action<Tilemap, NativeArray<Vector3Int>> tilemapPositionsChanged;

	private bool m_BufferSyncTile;

	internal bool bufferSyncTile => false;

	internal static bool HasSyncTileCallback()
	{
		return false;
	}

	internal static bool HasPositionsChangedCallback()
	{
		return false;
	}

	private void HandleSyncTileCallback(SyncTile[] syncTiles)
	{
	}

	private void HandlePositionsChangedCallback(int count, IntPtr positionsIntPtr)
	{
	}

	private void SendTilemapTileChangedCallback(SyncTile[] syncTiles)
	{
	}

	private void SendTilemapPositionsChangedCallback(NativeArray<Vector3Int> positions)
	{
	}

	[NativeMethod(Name = "RefreshTileAsset")]
	public void RefreshTile(Vector3Int position)
	{
	}

	[FreeFunction(Name = "TilemapBindings::RefreshTileAssetsNative", HasExplicitThis = true)]
	internal unsafe void RefreshTilesNative(void* positions, int count)
	{
	}

	[RequiredByNativeCode]
	internal void GetSyncTileCallbackSettings(ref SyncTileCallbackSettings settings)
	{
	}

	[RequiredByNativeCode]
	private void DoSyncTileCallback(SyncTile[] syncTiles)
	{
	}

	[RequiredByNativeCode]
	private void DoPositionsChangedCallback(int count, IntPtr positionsIntPtr)
	{
	}

	private void RefreshTile_Injected(ref Vector3Int position)
	{
	}
}
