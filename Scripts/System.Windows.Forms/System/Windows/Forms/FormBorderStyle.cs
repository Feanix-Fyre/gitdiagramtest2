using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Specifies the border styles for a form.</summary>
[ComVisible(true)]
public enum FormBorderStyle
{
	/// <summary>No border.</summary>
	None = 0,
	/// <summary>A fixed, single-line border.</summary>
	FixedSingle = 1,
	/// <summary>A fixed, three-dimensional border.</summary>
	Fixed3D = 2,
	/// <summary>A thick, fixed dialog-style border.</summary>
	FixedDialog = 3,
	/// <summary>A resizable border.</summary>
	Sizable = 4,
	/// <summary>A tool window border that is not resizable. A tool window does not appear in the taskbar or in the window that appears when the user presses ALT+TAB. Although forms that specify <see cref="F:System.Windows.Forms.FormBorderStyle.FixedToolWindow" /> typically are not shown in the taskbar, you must also ensure that the <see cref="P:System.Windows.Forms.Form.ShowInTaskbar" /> property is set to <see langword="false" />, since its default value is <see langword="true" />.</summary>
	FixedToolWindow = 5,
	/// <summary>A resizable tool window border. A tool window does not appear in the taskbar or in the window that appears when the user presses ALT+TAB.</summary>
	SizableToolWindow = 6
}
