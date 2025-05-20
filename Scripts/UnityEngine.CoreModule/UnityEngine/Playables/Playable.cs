using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables;

[RequiredByNativeCode]
public struct Playable : IPlayable, IEquatable<Playable>
{
	private PlayableHandle m_Handle;

	private static readonly Playable m_NullPlayable;

	public static Playable Null => default(Playable);

	public static Playable Create(PlayableGraph graph, int inputCount = 0)
	{
		return default(Playable);
	}

	[VisibleToOtherModules]
	internal Playable(PlayableHandle handle)
	{
		m_Handle = default(PlayableHandle);
	}

	public PlayableHandle GetHandle()
	{
		return default(PlayableHandle);
	}

	public bool IsPlayableOfType<T>() where T : struct, IPlayable
	{
		return false;
	}

	public Type GetPlayableType()
	{
		return null;
	}

	public bool Equals(Playable other)
	{
		return false;
	}
}
