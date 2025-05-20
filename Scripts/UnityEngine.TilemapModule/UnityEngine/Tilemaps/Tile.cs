using System;
using UnityEngine.Scripting;

namespace UnityEngine.Tilemaps;

[Serializable]
[HelpURL("https://docs.unity3d.com/Manual/Tilemap-TileAsset.html")]
[RequiredByNativeCode]
public class Tile : TileBase
{
	public enum ColliderType
	{
		None = 0,
		Sprite = 1,
		Grid = 2
	}

	[SerializeField]
	private Sprite m_Sprite;

	[SerializeField]
	private Color m_Color;

	[SerializeField]
	private Matrix4x4 m_Transform;

	[SerializeField]
	private GameObject m_InstancedGameObject;

	[SerializeField]
	private TileFlags m_Flags;

	[SerializeField]
	private ColliderType m_ColliderType;

	public Sprite sprite
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Color color
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public Matrix4x4 transform
	{
		get
		{
			return default(Matrix4x4);
		}
		set
		{
		}
	}

	public GameObject gameObject
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public TileFlags flags
	{
		get
		{
			return default(TileFlags);
		}
		set
		{
		}
	}

	public ColliderType colliderType
	{
		get
		{
			return default(ColliderType);
		}
		set
		{
		}
	}

	public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
	{
	}
}
