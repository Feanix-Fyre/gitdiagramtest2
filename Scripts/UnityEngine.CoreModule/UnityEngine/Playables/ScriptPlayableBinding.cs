using System;

namespace UnityEngine.Playables;

public static class ScriptPlayableBinding
{
	public static PlayableBinding Create(string name, Object key, Type type)
	{
		return default(PlayableBinding);
	}

	private static PlayableOutput CreateScriptOutput(PlayableGraph graph, string name)
	{
		return default(PlayableOutput);
	}
}
