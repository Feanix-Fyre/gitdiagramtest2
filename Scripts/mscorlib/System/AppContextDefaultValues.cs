namespace System;

internal static class AppContextDefaultValues
{
	internal static readonly string SwitchEnforceJapaneseEraYearRanges;

	internal static readonly string SwitchFormatJapaneseFirstYearAsANumber;

	internal static readonly string SwitchEnforceLegacyJapaneseDateParsing;

	public static void PopulateDefaultValues()
	{
	}

	public static bool TryGetSwitchOverride(string switchName, out bool overrideValue)
	{
		overrideValue = default(bool);
		return false;
	}
}
