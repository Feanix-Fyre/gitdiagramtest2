namespace System.ComponentModel;

/// <summary>Specifies which event is raised on initialization. This class cannot be inherited.</summary>
[AttributeUsage(AttributeTargets.Class)]
public sealed class InitializationEventAttribute : Attribute
{
	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.InitializationEventAttribute" /> class.</summary>
	/// <param name="eventName">The name of the initialization event.</param>
	public InitializationEventAttribute(string eventName)
	{
	}
}
