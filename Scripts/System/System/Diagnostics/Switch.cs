using System.Collections.Generic;

namespace System.Diagnostics;

/// <summary>Provides an abstract base class to create new debugging and tracing switches.</summary>
public abstract class Switch
{
	private readonly string description;

	private readonly string displayName;

	private string switchValueString;

	private string defaultValue;

	private static List<WeakReference> switches;

	private static int s_LastCollectionCount;

	/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.Switch" /> class.</summary>
	/// <param name="displayName">The name of the switch.</param>
	/// <param name="description">The description for the switch.</param>
	protected Switch(string displayName, string description)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.Switch" /> class, specifying the display name, description, and default value for the switch.</summary>
	/// <param name="displayName">The name of the switch.</param>
	/// <param name="description">The description of the switch.</param>
	/// <param name="defaultSwitchValue">The default value for the switch.</param>
	protected Switch(string displayName, string description, string defaultSwitchValue)
	{
	}

	private static void _pruneCachedSwitches()
	{
	}
}
