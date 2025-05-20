namespace System.Windows.Forms.VisualStyles;

/// <summary>Specifies how visual styles are applied to the current application.</summary>
public enum VisualStyleState
{
	/// <summary>Visual styles are not applied to the application.</summary>
	NoneEnabled = 0,
	/// <summary>Visual styles are applied only to the nonclient area.</summary>
	NonClientAreaEnabled = 1,
	/// <summary>Visual styles are applied only to the client area.</summary>
	ClientAreaEnabled = 2,
	/// <summary>Visual styles are applied to client and nonclient areas.</summary>
	ClientAndNonClientAreasEnabled = 3
}
