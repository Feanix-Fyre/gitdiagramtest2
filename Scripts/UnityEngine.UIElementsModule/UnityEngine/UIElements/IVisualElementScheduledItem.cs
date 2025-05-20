namespace UnityEngine.UIElements;

public interface IVisualElementScheduledItem
{
	void Resume();

	void Pause();

	void ExecuteLater(long delayMs);

	IVisualElementScheduledItem StartingIn(long delayMs);

	IVisualElementScheduledItem Every(long intervalMs);
}
