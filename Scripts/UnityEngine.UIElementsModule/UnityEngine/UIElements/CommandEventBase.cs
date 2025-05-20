namespace UnityEngine.UIElements;

[EventCategory(EventCategory.Command)]
public abstract class CommandEventBase<T> : EventBase<T>, ICommandEvent where T : CommandEventBase<T>, new()
{
	private string m_CommandName;

	public string commandName
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	protected override void Init()
	{
	}

	private void LocalInit()
	{
	}

	public static T GetPooled(Event systemEvent)
	{
		return null;
	}

	public static T GetPooled(string commandName)
	{
		return null;
	}
}
