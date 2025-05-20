namespace UnityEngine.Rendering.PostProcessing;

public sealed class PostProcessBundle
{
	private PostProcessEffectRenderer m_Renderer;

	public PostProcessAttribute attribute { get; private set; }

	public PostProcessEffectSettings settings { get; private set; }

	internal PostProcessEffectRenderer renderer => null;

	internal PostProcessBundle(PostProcessEffectSettings settings)
	{
	}

	internal void Release()
	{
	}

	internal void ResetHistory()
	{
	}

	internal T CastSettings<T>() where T : PostProcessEffectSettings
	{
		return null;
	}

	internal T CastRenderer<T>() where T : PostProcessEffectRenderer
	{
		return null;
	}
}
