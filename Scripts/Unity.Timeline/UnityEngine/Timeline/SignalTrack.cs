using System;

namespace UnityEngine.Timeline;

[Serializable]
[ExcludeFromPreset]
[TrackColor(0.25f, 0.25f, 0.25f)]
[TrackBindingType(typeof(SignalReceiver))]
public class SignalTrack : MarkerTrack
{
}
