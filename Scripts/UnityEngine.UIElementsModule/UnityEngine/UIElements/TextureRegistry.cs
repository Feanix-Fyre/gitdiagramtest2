using System.Collections.Generic;

namespace UnityEngine.UIElements;

internal class TextureRegistry
{
	private struct TextureInfo
	{
		public Texture texture;

		public bool dynamic;

		public int refCount;
	}

	private List<TextureInfo> m_Textures;

	private Dictionary<Texture, TextureId> m_TextureToId;

	private Stack<TextureId> m_FreeIds;

	internal const int maxTextures = 2048;

	public static TextureRegistry instance { get; }

	public Texture GetTexture(TextureId id)
	{
		return null;
	}

	public TextureId AllocAndAcquireDynamic()
	{
		return default(TextureId);
	}

	public void UpdateDynamic(TextureId id, Texture texture)
	{
	}

	private TextureId AllocAndAcquire(Texture texture, bool dynamic)
	{
		return default(TextureId);
	}

	public TextureId Acquire(Texture tex)
	{
		return default(TextureId);
	}

	public void Release(TextureId id)
	{
	}
}
