using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements;

[EventCategory(EventCategory.StyleTransition)]
public abstract class TransitionEventBase<T> : EventBase<T> where T : TransitionEventBase<T>, new()
{
	public StylePropertyNameCollection stylePropertyNames { get; }

	protected double elapsedTime
	{
		[CompilerGenerated]
		set
		{
			_003CelapsedTime_003Ek__BackingField = value;
		}
	}

	protected override void Init()
	{
	}

	private void LocalInit()
	{
	}

	public static T GetPooled(StylePropertyName stylePropertyName, double elapsedTime)
	{
		return null;
	}
}
