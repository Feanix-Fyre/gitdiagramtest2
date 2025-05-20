namespace System.Windows.Forms.VisualStyles;

/// <summary>Provides information about the current visual style of the operating system.</summary>
public static class VisualStyleInformation
{
	/// <summary>Gets the color scheme of the current visual style.</summary>
	/// <returns>A string that specifies the color scheme of the current visual style if visual styles are enabled; otherwise, an empty string ("").</returns>
	public static string ColorScheme => null;

	/// <summary>Gets a value indicating whether the user has enabled visual styles in the operating system.</summary>
	/// <returns>
	///   <see langword="true" /> if the user has enabled visual styles in an operating system that supports them; otherwise, <see langword="false" />.</returns>
	public static bool IsEnabledByUser => false;

	/// <summary>Gets a value indicating whether the operating system supports visual styles.</summary>
	/// <returns>
	///   <see langword="true" /> if the operating system supports visual styles; otherwise, <see langword="false" />.</returns>
	public static bool IsSupportedByOS => false;

	private static IVisualStyles VisualStyles => null;
}
