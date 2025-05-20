namespace UnityEngine.Timeline;

public static class TimelineClipExtensions
{
	private static readonly string k_UndoSetParentTrackText;

	public static void MoveToTrack(this TimelineClip clip, TrackAsset destinationTrack)
	{
	}

	public static bool TryMoveToTrack(this TimelineClip clip, TrackAsset destinationTrack)
	{
		return false;
	}

	private static void MoveToTrack_Impl(TimelineClip clip, TrackAsset destinationTrack, Object asset, TrackAsset parentTrack)
	{
	}
}
