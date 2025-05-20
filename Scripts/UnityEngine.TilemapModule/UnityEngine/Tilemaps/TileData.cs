using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Tilemaps;

[RequiredByNativeCode]
[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
public struct TileData
{
	private int m_Sprite;

	private Color m_Color;

	private Matrix4x4 m_Transform;

	private int m_GameObject;

	private TileFlags m_Flags;

	private Tile.ColliderType m_ColliderType;

	internal static readonly TileData Default;

	public Sprite sprite
	{
		set
		{
		}
	}

	public Color color
	{
		set
		{
		}
	}

	public Matrix4x4 transform
	{
		set
		{
		}
	}

	public GameObject gameObject
	{
		set
		{
		}
	}

	public TileFlags flags
	{
		set
		{
		}
	}

	public Tile.ColliderType colliderType
	{
		set
		{
		}
	}

	private static TileData CreateDefault()
	{
		return default(TileData);
	}
}
