namespace System.Windows.Forms.VisualStyles;

/// <summary>Specifies the size of the visual style part to retrieve.</summary>
public enum ThemeSizeType
{
	/// <summary>The minimum size of the visual style part.</summary>
	Minimum = 0,
	/// <summary>The size of the visual style part that will best fit the available space.</summary>
	True = 1,
	/// <summary>The size that the current visual style uses to draw the part.</summary>
	Draw = 2
}
