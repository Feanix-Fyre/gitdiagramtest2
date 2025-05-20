using System;

namespace UnityEngine.UIElements.UIR;

internal class ShaderInfoStorageRGBA32 : ShaderInfoStorage<Color32>
{
	private static readonly Func<Color, Color32> s_Convert;

	public ShaderInfoStorageRGBA32(int initialSize = 64, int maxSize = 4096)
		: base(default(TextureFormat), (Func<Color, Color32>)null, 0, 0)
	{
	}
}
