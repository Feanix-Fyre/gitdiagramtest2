using UnityEngine.Bindings;

namespace UnityEngine;

[NativeClass("UI::CanvasGroup")]
[NativeHeader("Modules/UI/CanvasGroup.h")]
public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter
{
	[NativeProperty("Alpha", false, TargetType.Function)]
	public float alpha
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[NativeProperty("Interactable", false, TargetType.Function)]
	public bool interactable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[NativeProperty("BlocksRaycasts", false, TargetType.Function)]
	public bool blocksRaycasts
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[NativeProperty("IgnoreParentGroups", false, TargetType.Function)]
	public bool ignoreParentGroups
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		return false;
	}
}
