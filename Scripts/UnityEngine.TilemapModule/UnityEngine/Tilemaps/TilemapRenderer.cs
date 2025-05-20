using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.U2D;

namespace UnityEngine.Tilemaps;

[NativeHeader("Modules/Tilemap/Public/TilemapMarshalling.h")]
[NativeType(Header = "Modules/Tilemap/Public/TilemapRenderer.h")]
[RequireComponent(typeof(Tilemap))]
[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
[NativeHeader("Modules/Tilemap/TilemapRendererJobs.h")]
public sealed class TilemapRenderer : Renderer
{
	[RequiredByNativeCode]
	internal void RegisterSpriteAtlasRegistered()
	{
	}

	[RequiredByNativeCode]
	internal void UnregisterSpriteAtlasRegistered()
	{
	}

	internal void OnSpriteAtlasRegistered(SpriteAtlas atlas)
	{
	}
}
