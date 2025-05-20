using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.TextCore;

namespace TMPro;

[Serializable]
public abstract class TMP_Asset : ScriptableObject
{
	[SerializeField]
	internal string m_Version;

	internal int m_InstanceID;

	internal int m_HashCode;

	[SerializeField]
	internal FaceInfo m_FaceInfo;

	[SerializeField]
	[FormerlySerializedAs("material")]
	internal Material m_Material;

	internal int m_MaterialHashCode;

	public string version
	{
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	public int instanceID => 0;

	public int hashCode
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public FaceInfo faceInfo
	{
		get
		{
			return default(FaceInfo);
		}
		set
		{
		}
	}

	public Material material
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int materialHashCode
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}
}
