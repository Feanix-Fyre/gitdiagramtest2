namespace System.Diagnostics;

/// <summary>Provides a simple on/off switch that controls debugging and tracing output.</summary>
[SwitchLevel(typeof(bool))]
public class BooleanSwitch : Switch
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.BooleanSwitch" /> class with the specified display name and description.</summary>
	/// <param name="displayName">The name to display on a user interface.</param>
	/// <param name="description">The description of the switch.</param>
	public BooleanSwitch(string displayName, string description)
		: base(null, null)
	{
	}
}
