namespace System.Diagnostics;

/// <summary>Identifies the level type for a switch.</summary>
[AttributeUsage(AttributeTargets.Class)]
public sealed class SwitchLevelAttribute : Attribute
{
	private Type type;

	/// <summary>Gets or sets the type that determines whether a trace should be written.</summary>
	/// <returns>The <see cref="T:System.Type" /> that determines whether a trace should be written.</returns>
	/// <exception cref="T:System.ArgumentNullException">The set operation failed because the value is <see langword="null" />.</exception>
	public Type SwitchLevelType
	{
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.SwitchLevelAttribute" /> class, specifying the type that determines whether a trace should be written.</summary>
	/// <param name="switchLevelType">The <see cref="T:System.Type" /> that determines whether a trace should be written.</param>
	public SwitchLevelAttribute(Type switchLevelType)
	{
	}
}
