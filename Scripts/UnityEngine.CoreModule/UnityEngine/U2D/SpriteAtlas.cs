using UnityEngine.Bindings;

namespace UnityEngine.U2D;

[NativeHeader("Runtime/Graphics/SpriteFrame.h")]
[NativeType(Header = "Runtime/2D/SpriteAtlas/SpriteAtlas.h")]
public class SpriteAtlas : Object
{
	public bool CanBindTo([NotNull("ArgumentNullException")] Sprite sprite)
	{
		return false;
	}
}
