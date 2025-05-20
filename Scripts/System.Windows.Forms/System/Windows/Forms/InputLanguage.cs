using System.Globalization;

namespace System.Windows.Forms;

/// <summary>Provides methods and fields to manage the input language. This class cannot be inherited.</summary>
public sealed class InputLanguage
{
	private static InputLanguageCollection all;

	private IntPtr handle;

	private CultureInfo culture;

	private string layout_name;

	private static InputLanguage current_input;

	/// <summary>Gets or sets the input language for the current thread.</summary>
	/// <returns>An <see cref="T:System.Windows.Forms.InputLanguage" /> that represents the input language for the current thread.</returns>
	/// <exception cref="T:System.ArgumentException">The input language is not recognized by the system.</exception>
	public static InputLanguage CurrentInputLanguage => null;

	/// <summary>Gets a list of all installed input languages.</summary>
	/// <returns>An array of <see cref="T:System.Windows.Forms.InputLanguage" /> objects that represent the input languages installed on the computer.</returns>
	public static InputLanguageCollection InstalledInputLanguages => null;

	[MonoInternalNote("Pull Microsofts InputLanguages and enter them here")]
	internal InputLanguage()
	{
	}

	internal InputLanguage(IntPtr handle, CultureInfo culture, string layout_name)
	{
	}

	/// <summary>Returns the input language associated with the specified culture.</summary>
	/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> that specifies the culture to convert from.</param>
	/// <returns>An <see cref="T:System.Windows.Forms.InputLanguage" /> that represents the previously selected input language.</returns>
	public static InputLanguage FromCulture(CultureInfo culture)
	{
		return null;
	}

	/// <summary>Specifies whether two input languages are equal.</summary>
	/// <param name="value">The language to test for equality.</param>
	/// <returns>
	///   <see langword="true" /> if the two languages are equal; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object value)
	{
		return false;
	}

	/// <summary>Returns the hash code for this input language.</summary>
	/// <returns>The hash code for this input language.</returns>
	public override int GetHashCode()
	{
		return 0;
	}
}
