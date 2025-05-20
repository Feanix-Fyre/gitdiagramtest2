namespace UnityEngine.UIElements;

internal abstract class AtlasBase
{
	internal TextureRegistry textureRegistry;

	public virtual bool TryGetAtlas(VisualElement ctx, Texture2D src, out TextureId atlas, out RectInt atlasRect)
	{
		atlas = default(TextureId);
		atlasRect = default(RectInt);
		return false;
	}

	public virtual void ReturnAtlas(VisualElement ctx, Texture2D src, TextureId atlas)
	{
	}

	public virtual void Reset()
	{
	}

	protected virtual void OnAssignedToPanel(IPanel panel)
	{
	}

	protected virtual void OnRemovedFromPanel(IPanel panel)
	{
	}

	protected virtual void OnUpdateDynamicTextures(IPanel panel)
	{
	}

	internal void InvokeAssignedToPanel(IPanel panel)
	{
	}

	internal void InvokeRemovedFromPanel(IPanel panel)
	{
	}

	internal void InvokeUpdateDynamicTextures(IPanel panel)
	{
	}

	protected static void RepaintTexturedElements(IPanel panel)
	{
	}

	protected void SetDynamicTexture(TextureId id, Texture texture)
	{
	}
}
