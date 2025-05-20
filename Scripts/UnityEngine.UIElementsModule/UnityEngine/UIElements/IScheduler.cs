namespace UnityEngine.UIElements;

internal interface IScheduler
{
	void Unschedule(ScheduledItem item);

	void Schedule(ScheduledItem item);

	void UpdateScheduledEvents();
}
