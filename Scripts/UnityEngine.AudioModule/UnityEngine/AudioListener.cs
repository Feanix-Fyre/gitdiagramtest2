using UnityEngine.Bindings;

namespace UnityEngine;

[RequireComponent(typeof(Transform))]
[StaticAccessor("AudioListenerBindings", StaticAccessorType.DoubleColon)]
public sealed class AudioListener : AudioBehaviour
{
}
