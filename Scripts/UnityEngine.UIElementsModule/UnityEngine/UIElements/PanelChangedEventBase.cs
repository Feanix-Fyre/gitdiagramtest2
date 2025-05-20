namespace UnityEngine.UIElements;

[EventCategory(EventCategory.ChangePanel)]
public abstract class PanelChangedEventBase<T> : EventBase<T> where T : PanelChangedEventBase<T>, new()
{
	public IPanel originPanel { get; private set; }

	public IPanel destinationPanel { get; private set; }

	protected override void Init()
	{
	}

	private void LocalInit()
	{
	}

	public static T GetPooled(IPanel originPanel, IPanel destinationPanel)
	{
		return null;
	}
}
