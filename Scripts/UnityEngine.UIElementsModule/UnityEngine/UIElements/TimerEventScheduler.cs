using System.Collections.Generic;

namespace UnityEngine.UIElements;

internal class TimerEventScheduler : IScheduler
{
	private readonly List<ScheduledItem> m_ScheduledItems;

	private bool m_TransactionMode;

	private readonly List<ScheduledItem> m_ScheduleTransactions;

	private readonly HashSet<ScheduledItem> m_UnscheduleTransactions;

	internal bool disableThrottling;

	private int m_LastUpdatedIndex;

	public void Schedule(ScheduledItem item)
	{
	}

	private bool RemovedScheduledItemAt(int index)
	{
		return false;
	}

	public void Unschedule(ScheduledItem item)
	{
	}

	private bool PrivateUnSchedule(ScheduledItem sItem)
	{
		return false;
	}

	public void UpdateScheduledEvents()
	{
	}
}
