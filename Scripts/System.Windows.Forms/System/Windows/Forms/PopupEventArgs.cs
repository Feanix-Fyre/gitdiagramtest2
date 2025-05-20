using System.ComponentModel;
using System.Drawing;

namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.ToolTip.Popup" /> event.</summary>
public class PopupEventArgs : CancelEventArgs
{
	private Control associated_control;

	private IWin32Window associated_window;

	private bool is_balloon;

	private Size tool_tip_size;

	/// <summary>Gets or sets the size of the ToolTip.</summary>
	/// <returns>The <see cref="T:System.Drawing.Size" /> of the <see cref="T:System.Windows.Forms.ToolTip" /> window.</returns>
	public Size ToolTipSize
	{
		get
		{
			return default(Size);
		}
		set
		{
		}
	}

	/// <summary>Initializes an instance of the <see cref="T:System.Windows.Forms.PopupEventArgs" /> class.</summary>
	/// <param name="associatedWindow">The <see cref="T:System.Windows.Forms.IWin32Window" /> that the ToolTip is bound to.</param>
	/// <param name="associatedControl">The <see cref="T:System.Windows.Forms.Control" /> that the ToolTip is being created for.</param>
	/// <param name="isBalloon">
	///   <see langword="true" /> to indicate that the associated ToolTip window has a balloon-style appearance; otherwise, <see langword="false" /> to indicate that the ToolTip window has a standard rectangular appearance.</param>
	/// <param name="size">The <see cref="T:System.Drawing.Size" /> of the ToolTip.</param>
	public PopupEventArgs(IWin32Window associatedWindow, Control associatedControl, bool isBalloon, Size size)
	{
	}
}
