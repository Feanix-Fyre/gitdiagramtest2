using System.Collections.Generic;

namespace System;

/// <summary>Provides members for setting and retrieving data about an application's context.</summary>
public static class AppContext
{
	[Flags]
	private enum SwitchValueState
	{
		HasFalseValue = 1,
		HasTrueValue = 2,
		HasLookedForOverride = 4,
		UnknownValue = 8
	}

	private static readonly Dictionary<string, SwitchValueState> s_switchMap;

	private static bool s_defaultsInitialized;

	private static void InitializeDefaultSwitchValues()
	{
	}

	/// <summary>Tries to get the value of a switch.</summary>
	/// <param name="switchName">The name of the switch.</param>
	/// <param name="isEnabled">When this method returns, contains the value of <paramref name="switchName" /> if <paramref name="switchName" /> was found, or <see langword="false" /> if <paramref name="switchName" /> was not found. This parameter is passed uninitialized.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="switchName" /> was set and the <paramref name="isEnabled" /> argument contains the value of the switch; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="switchName" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="switchName" /> is <see cref="F:System.String.Empty" />.</exception>
	public static bool TryGetSwitch(string switchName, out bool isEnabled)
	{
		isEnabled = default(bool);
		return false;
	}
}
