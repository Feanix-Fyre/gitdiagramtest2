using System.Collections.Generic;

namespace UnityEngine.InputSystem.Utilities;

public struct NameAndParameters
{
	public string name { get; set; }

	public ReadOnlyArray<NamedValue> parameters { get; set; }

	public override string ToString()
	{
		return null;
	}

	public static IEnumerable<NameAndParameters> ParseMultiple(string text)
	{
		return null;
	}

	internal static bool ParseMultiple(string text, ref List<NameAndParameters> list)
	{
		return false;
	}

	internal static string ParseName(string text)
	{
		return null;
	}

	public static NameAndParameters Parse(string text)
	{
		return default(NameAndParameters);
	}

	private static NameAndParameters ParseNameAndParameters(string text, ref int index, bool nameOnly = false)
	{
		return default(NameAndParameters);
	}
}
