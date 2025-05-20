using System;

namespace UnityEngine.UIElements;

[Serializable]
internal struct StyleSelectorPart
{
	[SerializeField]
	private string m_Value;

	[SerializeField]
	private StyleSelectorType m_Type;

	internal object tempData;

	public string value => null;

	public StyleSelectorType type
	{
		get
		{
			return default(StyleSelectorType);
		}
		internal set
		{
		}
	}

	public override string ToString()
	{
		return null;
	}

	public static StyleSelectorPart CreateClass(string className)
	{
		return default(StyleSelectorPart);
	}

	public static StyleSelectorPart CreateId(string Id)
	{
		return default(StyleSelectorPart);
	}

	public static StyleSelectorPart CreatePredicate(object predicate)
	{
		return default(StyleSelectorPart);
	}
}
