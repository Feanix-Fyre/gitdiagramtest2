using System;
using System.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Timeline;

internal static class NotificationUtilities
{
	public static ScriptPlayable<TimeNotificationBehaviour> CreateNotificationsPlayable(PlayableGraph graph, IEnumerable<IMarker> markers, PlayableDirector director)
	{
		return default(ScriptPlayable<TimeNotificationBehaviour>);
	}

	public static ScriptPlayable<TimeNotificationBehaviour> CreateNotificationsPlayable(PlayableGraph graph, IEnumerable<IMarker> markers, TimelineAsset timelineAsset)
	{
		return default(ScriptPlayable<TimeNotificationBehaviour>);
	}

	private static ScriptPlayable<TimeNotificationBehaviour> CreateNotificationsPlayable(PlayableGraph graph, IEnumerable<IMarker> markers, IPlayableAsset asset, PlayableDirector director)
	{
		return default(ScriptPlayable<TimeNotificationBehaviour>);
	}

	public static bool TrackTypeSupportsNotifications(Type type)
	{
		return false;
	}
}
