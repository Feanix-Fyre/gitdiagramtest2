using System;

namespace UnityEngine.UIElements;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class EventInterestAttribute : Attribute
{
	internal Type[] eventTypes;

	internal EventCategoryFlags categoryFlags;

	public EventInterestAttribute(params Type[] eventTypes)
	{
	}

	public EventInterestAttribute(EventInterestOptions interests)
	{
	}
}
