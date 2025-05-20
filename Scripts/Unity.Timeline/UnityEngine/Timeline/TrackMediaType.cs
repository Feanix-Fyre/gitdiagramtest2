using System;

namespace UnityEngine.Timeline;

[Obsolete("TrackMediaType has been deprecated. It is no longer required, and will be removed in a future release.", false)]
[AttributeUsage(AttributeTargets.Class)]
public class TrackMediaType : Attribute
{
	public readonly TimelineAsset.MediaType m_MediaType;

	public TrackMediaType(TimelineAsset.MediaType mt)
	{
	}
}
