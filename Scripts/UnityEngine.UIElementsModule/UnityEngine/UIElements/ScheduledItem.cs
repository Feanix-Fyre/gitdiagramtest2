using System;

namespace UnityEngine.UIElements;

internal abstract class ScheduledItem
{
	public Func<bool> timerUpdateStopCondition;

	public static readonly Func<bool> OnceCondition;

	public static readonly Func<bool> ForeverCondition;

	public long startMs { get; set; }

	public long delayMs { get; set; }

	public long intervalMs { get; set; }

	public long endTimeMs { get; }

	public ScheduledItem()
	{
	}

	protected void ResetStartTime()
	{
	}

	public abstract void PerformTimerUpdate(TimerState state);

	internal virtual void OnItemUnscheduled()
	{
	}

	public virtual bool ShouldUnschedule()
	{
		return false;
	}
}
