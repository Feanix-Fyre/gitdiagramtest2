using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Playables;

[NativeHeader("Runtime/Export/Director/MaterialEffectPlayable.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[RequiredByNativeCode]
[NativeHeader("Runtime/Shaders/Director/MaterialEffectPlayable.h")]
[StaticAccessor("MaterialEffectPlayableBindings", StaticAccessorType.DoubleColon)]
public struct MaterialEffectPlayable : IPlayable, IEquatable<MaterialEffectPlayable>
{
	private PlayableHandle m_Handle;

	public PlayableHandle GetHandle()
	{
		return default(PlayableHandle);
	}

	public bool Equals(MaterialEffectPlayable other)
	{
		return false;
	}
}
