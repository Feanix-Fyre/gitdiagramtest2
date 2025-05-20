using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Represents a standard Windows vertical scroll bar.</summary>
[ComVisible(true)]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
public class VScrollBar : ScrollBar
{
	/// <summary>Gets a value indicating whether control's elements are aligned to support locales using right-to-left fonts.</summary>
	/// <returns>The <see cref="F:System.Windows.Forms.RightToLeft.No" /> value.</returns>
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override RightToLeft RightToLeft => default(RightToLeft);

	/// <summary>Gets the default size of the control.</summary>
	/// <returns>The default <see cref="T:System.Drawing.Size" /> of the control.</returns>
	protected override Size DefaultSize => default(Size);

	/// <summary>Gets the required creation parameters when the control handle is created.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.CreateParams" /> that contains the required creation parameters when the handle to the control is created.</returns>
	protected override CreateParams CreateParams => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.VScrollBar" /> class.</summary>
	public VScrollBar()
	{
	}
}
