using Microsoft.CSharp;

namespace System.Xml.Serialization;

/// <summary>Provides static methods to convert input text into names for code entities.</summary>
public class CodeIdentifier
{
	internal static CodeDomProvider csharp;

	/// <summary>Produces a Pascal-case string from an input string. </summary>
	/// <param name="identifier">The name of a code entity, such as a method parameter, typically taken from an XML element or attribute name.</param>
	/// <returns>A Pascal-case version of the parameter string.</returns>
	public static string MakePascal(string identifier)
	{
		return null;
	}

	/// <summary>Produces a valid code entity name from an input string. </summary>
	/// <param name="identifier">The name of a code entity, such as a method parameter, typically taken from an XML element or attribute name.</param>
	/// <returns>A string that can be used as a code identifier, such as the name of a method parameter.</returns>
	public static string MakeValid(string identifier)
	{
		return null;
	}

	private static bool IsValidStart(char c)
	{
		return false;
	}

	private static bool IsValid(char c)
	{
		return false;
	}
}
