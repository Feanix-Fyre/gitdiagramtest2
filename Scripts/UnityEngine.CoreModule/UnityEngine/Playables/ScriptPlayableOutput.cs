using UnityEngine.Scripting;

namespace UnityEngine.Playables;

[RequiredByNativeCode]
public struct ScriptPlayableOutput : IPlayableOutput
{
	private PlayableOutputHandle m_Handle;

	public static ScriptPlayableOutput Null => default(ScriptPlayableOutput);

	public static ScriptPlayableOutput Create(PlayableGraph graph, string name)
	{
		return default(ScriptPlayableOutput);
	}

	internal ScriptPlayableOutput(PlayableOutputHandle handle)
	{
		m_Handle = default(PlayableOutputHandle);
	}

	public PlayableOutputHandle GetHandle()
	{
		return default(PlayableOutputHandle);
	}

	public static implicit operator PlayableOutput(ScriptPlayableOutput output)
	{
		return default(PlayableOutput);
	}
}
