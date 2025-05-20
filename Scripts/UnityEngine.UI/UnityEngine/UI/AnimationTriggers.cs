using System;
using UnityEngine.Serialization;

namespace UnityEngine.UI;

[Serializable]
public class AnimationTriggers
{
	private const string kDefaultNormalAnimName = "Normal";

	private const string kDefaultHighlightedAnimName = "Highlighted";

	private const string kDefaultPressedAnimName = "Pressed";

	private const string kDefaultSelectedAnimName = "Selected";

	private const string kDefaultDisabledAnimName = "Disabled";

	[SerializeField]
	[FormerlySerializedAs("normalTrigger")]
	private string m_NormalTrigger;

	[SerializeField]
	[FormerlySerializedAs("highlightedTrigger")]
	private string m_HighlightedTrigger;

	[FormerlySerializedAs("pressedTrigger")]
	[SerializeField]
	private string m_PressedTrigger;

	[FormerlySerializedAs("m_HighlightedTrigger")]
	[SerializeField]
	private string m_SelectedTrigger;

	[FormerlySerializedAs("disabledTrigger")]
	[SerializeField]
	private string m_DisabledTrigger;

	public string normalTrigger
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string highlightedTrigger
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string pressedTrigger
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string selectedTrigger
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string disabledTrigger
	{
		get
		{
			return null;
		}
		set
		{
		}
	}
}
