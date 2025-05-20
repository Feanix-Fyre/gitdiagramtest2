using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering.PostProcessing;

public sealed class PostProcessProfile : ScriptableObject
{
	[Tooltip("A list of all settings currently stored in this profile.")]
	public List<PostProcessEffectSettings> settings;

	[NonSerialized]
	public bool isDirty;

	private void OnEnable()
	{
	}

	public T AddSettings<T>() where T : PostProcessEffectSettings
	{
		return null;
	}

	public PostProcessEffectSettings AddSettings(Type type)
	{
		return null;
	}

	public PostProcessEffectSettings AddSettings(PostProcessEffectSettings effect)
	{
		return null;
	}

	public void RemoveSettings<T>() where T : PostProcessEffectSettings
	{
	}

	public void RemoveSettings(Type type)
	{
	}

	public bool HasSettings<T>() where T : PostProcessEffectSettings
	{
		return false;
	}

	public bool HasSettings(Type type)
	{
		return false;
	}

	public T GetSetting<T>() where T : PostProcessEffectSettings
	{
		return null;
	}

	public bool TryGetSettings<T>(out T outSetting) where T : PostProcessEffectSettings
	{
		outSetting = null;
		return false;
	}
}
