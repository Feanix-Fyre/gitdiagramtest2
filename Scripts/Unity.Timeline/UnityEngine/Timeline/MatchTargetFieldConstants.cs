namespace UnityEngine.Timeline;

internal static class MatchTargetFieldConstants
{
	public static MatchTargetFields All;

	public static MatchTargetFields None;

	public static MatchTargetFields Position;

	public static MatchTargetFields Rotation;

	public static bool HasAny(this MatchTargetFields me, MatchTargetFields fields)
	{
		return false;
	}

	public static MatchTargetFields Toggle(this MatchTargetFields me, MatchTargetFields flag)
	{
		return default(MatchTargetFields);
	}
}
