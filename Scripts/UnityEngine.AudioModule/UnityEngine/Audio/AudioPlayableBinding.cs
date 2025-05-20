using UnityEngine.Playables;

namespace UnityEngine.Audio;

public static class AudioPlayableBinding
{
	public static PlayableBinding Create(string name, Object key)
	{
		return default(PlayableBinding);
	}

	private static PlayableOutput CreateAudioOutput(PlayableGraph graph, string name)
	{
		return default(PlayableOutput);
	}
}
