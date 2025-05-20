using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Tilemaps;

[RequiredByNativeCode]
[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
internal struct TileDataNative
{
	private int m_Sprite;

	private Color m_Color;

	private Matrix4x4 m_Transform;

	private int m_GameObject;

	private TileFlags m_Flags;

	private Tile.ColliderType m_ColliderType;
}
