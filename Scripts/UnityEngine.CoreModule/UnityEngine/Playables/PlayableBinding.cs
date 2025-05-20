using System;
using UnityEngine.Bindings;

namespace UnityEngine.Playables;

public struct PlayableBinding
{
	[VisibleToOtherModules]
	internal delegate PlayableOutput CreateOutputMethod(PlayableGraph graph, string name);

	private string m_StreamName;

	private Object m_SourceObject;

	private Type m_SourceBindingType;

	private CreateOutputMethod m_CreateOutputMethod;

	public static readonly PlayableBinding[] None;

	public static readonly double DefaultDuration;

	public Object sourceObject => null;

	internal PlayableOutput CreateOutput(PlayableGraph graph)
	{
		return default(PlayableOutput);
	}

	[VisibleToOtherModules]
	internal static PlayableBinding CreateInternal(string name, Object sourceObject, Type sourceType, CreateOutputMethod createFunction)
	{
		return default(PlayableBinding);
	}
}
