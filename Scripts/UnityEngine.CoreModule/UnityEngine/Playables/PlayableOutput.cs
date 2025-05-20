using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables;

[RequiredByNativeCode]
public struct PlayableOutput : IPlayableOutput, IEquatable<PlayableOutput>
{
	private PlayableOutputHandle m_Handle;

	private static readonly PlayableOutput m_NullPlayableOutput;

	public static PlayableOutput Null => default(PlayableOutput);

	[VisibleToOtherModules]
	internal PlayableOutput(PlayableOutputHandle handle)
	{
		m_Handle = default(PlayableOutputHandle);
	}

	public PlayableOutputHandle GetHandle()
	{
		return default(PlayableOutputHandle);
	}

	public bool IsPlayableOutputOfType<T>() where T : struct, IPlayableOutput
	{
		return false;
	}

	public bool Equals(PlayableOutput other)
	{
		return false;
	}
}
