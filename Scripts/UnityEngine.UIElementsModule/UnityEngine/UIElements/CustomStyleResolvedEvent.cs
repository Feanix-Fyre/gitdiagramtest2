namespace UnityEngine.UIElements;

[EventCategory(EventCategory.Style)]
public class CustomStyleResolvedEvent : EventBase<CustomStyleResolvedEvent>
{
	public ICustomStyle customStyle => null;

	static CustomStyleResolvedEvent()
	{
	}
}
