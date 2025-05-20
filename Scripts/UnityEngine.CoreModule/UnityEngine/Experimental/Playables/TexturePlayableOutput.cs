using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Playables;

[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[StaticAccessor("TexturePlayableOutputBindings", StaticAccessorType.DoubleColon)]
[NativeHeader("Runtime/Graphics/Director/TexturePlayableOutput.h")]
[NativeHeader("Runtime/Export/Director/TexturePlayableOutput.bindings.h")]
[RequiredByNativeCode]
public struct TexturePlayableOutput : IPlayableOutput
{
	private PlayableOutputHandle m_Handle;

	public PlayableOutputHandle GetHandle()
	{
		return default(PlayableOutputHandle);
	}
}
