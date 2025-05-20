namespace UnityEngine.Timeline;

internal static class TimelineClipCapsExtensions
{
	public static bool SupportsLooping(this TimelineClip clip)
	{
		return false;
	}

	public static bool SupportsExtrapolation(this TimelineClip clip)
	{
		return false;
	}

	public static bool SupportsClipIn(this TimelineClip clip)
	{
		return false;
	}

	public static bool SupportsSpeedMultiplier(this TimelineClip clip)
	{
		return false;
	}

	public static bool SupportsBlending(this TimelineClip clip)
	{
		return false;
	}

	public static bool HasAll(this ClipCaps caps, ClipCaps flags)
	{
		return false;
	}

	public static bool HasAny(this ClipCaps caps, ClipCaps flags)
	{
		return false;
	}
}
