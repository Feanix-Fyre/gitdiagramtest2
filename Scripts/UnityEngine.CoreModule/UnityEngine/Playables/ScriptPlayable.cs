using System;

namespace UnityEngine.Playables;

public struct ScriptPlayable<T> : IPlayable, IEquatable<ScriptPlayable<T>> where T : class, IPlayableBehaviour, new()
{
	private PlayableHandle m_Handle;

	private static readonly ScriptPlayable<T> m_NullPlayable;

	public static ScriptPlayable<T> Null => default(ScriptPlayable<T>);

	public static ScriptPlayable<T> Create(PlayableGraph graph, int inputCount = 0)
	{
		return default(ScriptPlayable<T>);
	}

	public static ScriptPlayable<T> Create(PlayableGraph graph, T template, int inputCount = 0)
	{
		return default(ScriptPlayable<T>);
	}

	private static PlayableHandle CreateHandle(PlayableGraph graph, T template, int inputCount)
	{
		return default(PlayableHandle);
	}

	private static object CreateScriptInstance()
	{
		return null;
	}

	private static object CloneScriptInstance(IPlayableBehaviour source)
	{
		return null;
	}

	private static object CloneScriptInstanceFromEngineObject(Object source)
	{
		return null;
	}

	private static object CloneScriptInstanceFromIClonable(ICloneable source)
	{
		return null;
	}

	internal ScriptPlayable(PlayableHandle handle)
	{
		m_Handle = default(PlayableHandle);
	}

	public PlayableHandle GetHandle()
	{
		return default(PlayableHandle);
	}

	public T GetBehaviour()
	{
		return null;
	}

	public static implicit operator Playable(ScriptPlayable<T> playable)
	{
		return default(Playable);
	}

	public static explicit operator ScriptPlayable<T>(Playable playable)
	{
		return default(ScriptPlayable<T>);
	}

	public bool Equals(ScriptPlayable<T> other)
	{
		return false;
	}
}
