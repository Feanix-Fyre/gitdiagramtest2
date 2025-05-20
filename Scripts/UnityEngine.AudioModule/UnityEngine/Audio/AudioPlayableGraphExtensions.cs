using UnityEngine.Bindings;
using UnityEngine.Playables;

namespace UnityEngine.Audio;

[StaticAccessor("AudioPlayableGraphExtensionsBindings", StaticAccessorType.DoubleColon)]
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioPlayableGraphExtensions.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
internal static class AudioPlayableGraphExtensions
{
	[NativeThrows]
	internal static bool InternalCreateAudioOutput(ref PlayableGraph graph, string name, out PlayableOutputHandle handle)
	{
		handle = default(PlayableOutputHandle);
		return false;
	}
}
