using System;
using UnityEngine.Serialization;

namespace UnityEngine.Events;

[Serializable]
internal class ArgumentCache : ISerializationCallbackReceiver
{
	[FormerlySerializedAs("objectArgument")]
	[SerializeField]
	private Object m_ObjectArgument;

	[FormerlySerializedAs("objectArgumentAssemblyTypeName")]
	[SerializeField]
	private string m_ObjectArgumentAssemblyTypeName;

	[SerializeField]
	[FormerlySerializedAs("intArgument")]
	private int m_IntArgument;

	[SerializeField]
	[FormerlySerializedAs("floatArgument")]
	private float m_FloatArgument;

	[SerializeField]
	[FormerlySerializedAs("stringArgument")]
	private string m_StringArgument;

	[SerializeField]
	private bool m_BoolArgument;

	public Object unityObjectArgument
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string unityObjectArgumentAssemblyTypeName => null;

	public int intArgument
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public float floatArgument
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public string stringArgument
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool boolArgument
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void OnBeforeSerialize()
	{
	}

	public void OnAfterDeserialize()
	{
	}
}
