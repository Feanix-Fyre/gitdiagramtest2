using System;
using UnityEngine.Serialization;

namespace UnityEngine.TextCore.Text;

[Serializable]
[ExcludeFromObjectFactory]
public abstract class TextAsset : ScriptableObject
{
	[SerializeField]
	internal string m_Version;

	internal int m_InstanceID;

	internal int m_HashCode;

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
