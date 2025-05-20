using System.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Timeline;

public class TimeNotificationBehaviour : PlayableBehaviour
{
	private struct NotificationEntry
	{
		public double time;

		public INotification payload;

		public bool notificationFired;

		public NotificationFlags flags;

		public bool triggerInEditor => false;

		public bool prewarm => false;

		public bool triggerOnce => false;
	}

	private readonly List<NotificationEntry> m_Notifications;

	private double m_PreviousTime;

	private bool m_NeedSortNotifications;

	private Playable m_TimeSource;

	public Playable timeSource
	{
		set
		{
		}
	}

	public static ScriptPlayable<TimeNotificationBehaviour> Create(PlayableGraph graph, double duration, DirectorWrapMode loopMode)
	{
		return default(ScriptPlayable<TimeNotificationBehaviour>);
	}

	public void AddNotification(double time, INotification payload, NotificationFlags flags = NotificationFlags.Retroactive)
	{
	}

	public override void OnGraphStart(Playable playable)
	{
	}

	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	private void SortNotifications()
	{
	}

	private static bool CanRestoreNotification(NotificationEntry e, FrameData info, double currentTime, double previousTime)
	{
		return false;
	}

	private void TriggerNotificationsInRange(double start, double end, FrameData info, Playable playable, bool checkState)
	{
	}

	private void SyncDurationWithExternalSource(Playable playable)
	{
	}

	private static void Trigger_internal(Playable playable, PlayableOutput output, ref NotificationEntry e)
	{
	}

	private static void Restore_internal(ref NotificationEntry e)
	{
	}
}
