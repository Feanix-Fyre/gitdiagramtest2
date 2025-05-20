using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Tilemaps;

[RequiredByNativeCode]
[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
public struct TileChangeData
{
	private Vector3Int m_Position;

	private Object m_TileAsset;

	private Color m_Color;

	private Matrix4x4 m_Transform;
}
