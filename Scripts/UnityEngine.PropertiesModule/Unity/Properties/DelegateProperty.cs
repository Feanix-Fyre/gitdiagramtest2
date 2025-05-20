namespace Unity.Properties;

public class DelegateProperty<TContainer, TValue> : Property<TContainer, TValue>
{
	private readonly PropertyGetter<TContainer, TValue> m_Getter;

	private readonly PropertySetter<TContainer, TValue> m_Setter;

	public override string Name { get; }

	public DelegateProperty(string name, PropertyGetter<TContainer, TValue> getter, PropertySetter<TContainer, TValue> setter = null)
	{
	}
}
