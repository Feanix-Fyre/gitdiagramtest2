using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Video;

[NativeHeader("Modules/Video/Public/ScriptBindings/VideoClipPlayable.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[RequiredByNativeCode]
[NativeHeader("Modules/Video/Public/Director/VideoClipPlayable.h")]
[NativeHeader("Modules/Video/Public/VideoClip.h")]
[StaticAccessor("VideoClipPlayableBindings", StaticAccessorType.DoubleColon)]
public struct VideoClipPlayable : IPlayable, IEquatable<VideoClipPlayable>
{
	private PlayableHandle m_Handle;

	public PlayableHandle GetHandle()
	{
		return default(PlayableHandle);
	}

	public bool Equals(VideoClipPlayable other)
	{
		return false;
	}
}
