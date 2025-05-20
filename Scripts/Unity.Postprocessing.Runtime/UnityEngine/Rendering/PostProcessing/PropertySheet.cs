namespace UnityEngine.Rendering.PostProcessing;

public sealed class PropertySheet
{
	public MaterialPropertyBlock properties { get; private set; }

	internal Material material { get; private set; }

	internal PropertySheet(Material material)
	{
	}

	public void ClearKeywords()
	{
	}

	public void EnableKeyword(string keyword)
	{
	}

	public void DisableKeyword(string keyword)
	{
	}

	internal void Release()
	{
	}
}
