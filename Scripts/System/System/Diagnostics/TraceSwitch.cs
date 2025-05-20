namespace System.Diagnostics;

/// <summary>Provides a multilevel switch to control tracing and debug output without recompiling your code.</summary>
[SwitchLevel(typeof(TraceLevel))]
public class TraceSwitch : Switch
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.TraceSwitch" /> class, using the specified display name and description.</summary>
	/// <param name="displayName">The name to display on a user interface.</param>
	/// <param name="description">The description of the switch.</param>
	public TraceSwitch(string displayName, string description)
		: base(null, null)
	{
	}
}
