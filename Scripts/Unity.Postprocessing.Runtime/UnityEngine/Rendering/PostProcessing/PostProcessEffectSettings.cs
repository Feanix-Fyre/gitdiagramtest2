using System;
using System.Collections.ObjectModel;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public class PostProcessEffectSettings : ScriptableObject
{
	public bool active;

	public BoolParameter enabled;

	internal ReadOnlyCollection<ParameterOverride> parameters;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void SetAllOverridesTo(bool state, bool excludeEnabled = true)
	{
	}

	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return false;
	}

	public int GetHash()
	{
		return 0;
	}
}
