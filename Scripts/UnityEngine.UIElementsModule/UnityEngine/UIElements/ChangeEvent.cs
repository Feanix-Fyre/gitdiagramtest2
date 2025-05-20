namespace UnityEngine.UIElements;

[EventCategory(EventCategory.ChangeValue)]
public class ChangeEvent<T> : EventBase<ChangeEvent<T>>
{
	public T previousValue { get; protected set; }

	public T newValue { get; protected set; }

	static ChangeEvent()
	{
	}

	protected override void Init()
	{
	}

	private void LocalInit()
	{
	}

	public static ChangeEvent<T> GetPooled(T previousValue, T newValue)
	{
		return null;
	}
}
