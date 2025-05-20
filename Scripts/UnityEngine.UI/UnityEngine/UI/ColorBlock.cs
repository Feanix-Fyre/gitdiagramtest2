using System;
using UnityEngine.Serialization;

namespace UnityEngine.UI;

[Serializable]
public struct ColorBlock : IEquatable<ColorBlock>
{
	[SerializeField]
	[FormerlySerializedAs("normalColor")]
	private Color m_NormalColor;

	[FormerlySerializedAs("highlightedColor")]
	[SerializeField]
	private Color m_HighlightedColor;

	[FormerlySerializedAs("pressedColor")]
	[SerializeField]
	private Color m_PressedColor;

	[FormerlySerializedAs("m_HighlightedColor")]
	[SerializeField]
	private Color m_SelectedColor;

	[FormerlySerializedAs("disabledColor")]
	[SerializeField]
	private Color m_DisabledColor;

	[Range(1f, 5f)]
	[SerializeField]
	private float m_ColorMultiplier;

	[FormerlySerializedAs("fadeDuration")]
	[SerializeField]
	private float m_FadeDuration;

	public static ColorBlock defaultColorBlock;

	public Color normalColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public Color highlightedColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public Color pressedColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public Color selectedColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public Color disabledColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public float colorMultiplier
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float fadeDuration
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	static ColorBlock()
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(ColorBlock other)
	{
		return false;
	}

	public static bool operator ==(ColorBlock point1, ColorBlock point2)
	{
		return false;
	}

	public static bool operator !=(ColorBlock point1, ColorBlock point2)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
