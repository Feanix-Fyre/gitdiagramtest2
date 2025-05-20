using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Specifies the border style for a control.</summary>
[ComVisible(true)]
public enum BorderStyle
{
	/// <summary>No border.</summary>
	None = 0,
	/// <summary>A single-line border.</summary>
	FixedSingle = 1,
	/// <summary>A three-dimensional border.</summary>
	Fixed3D = 2
}
