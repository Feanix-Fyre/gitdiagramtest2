using System;

namespace UnityEngine.Rendering;

[Serializable]
public class SerializableEnum
{
	[SerializeField]
	private string m_EnumValueAsString;

	[SerializeField]
	private string m_EnumTypeAsString;

	public Enum value
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SerializableEnum(Type enumType)
	{
	}
}
