using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Playables;

[NativeHeader("Runtime/Graphics/Director/TextureMixerPlayable.h")]
[RequiredByNativeCode]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Runtime/Export/Director/TextureMixerPlayable.bindings.h")]
[StaticAccessor("TextureMixerPlayableBindings", StaticAccessorType.DoubleColon)]
public struct TextureMixerPlayable : IPlayable, IEquatable<TextureMixerPlayable>
{
	private PlayableHandle m_Handle;

	public PlayableHandle GetHandle()
	{
		return default(PlayableHandle);
	}

	public bool Equals(TextureMixerPlayable other)
	{
		return false;
	}
}
