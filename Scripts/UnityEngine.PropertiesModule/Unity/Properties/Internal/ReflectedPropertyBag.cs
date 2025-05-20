namespace Unity.Properties.Internal;

[ReflectedPropertyBag]
internal class ReflectedPropertyBag<TContainer> : ContainerPropertyBag<TContainer>
{
	internal new void AddProperty<TValue>(Property<TContainer, TValue> property)
	{
	}
}
