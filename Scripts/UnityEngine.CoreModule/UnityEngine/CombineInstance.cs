namespace UnityEngine;

public struct CombineInstance
{
	private int m_MeshInstanceID;

	private int m_SubMeshIndex;

	private Matrix4x4 m_Transform;

	private Vector4 m_LightmapScaleOffset;

	private Vector4 m_RealtimeLightmapScaleOffset;

	public Mesh mesh
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int subMeshIndex
	{
		get
		{
			return 0;
		}
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
}
