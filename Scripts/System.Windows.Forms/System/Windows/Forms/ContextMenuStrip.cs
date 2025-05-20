using System.ComponentModel;
using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Represents a shortcut menu.</summary>
[ComVisible(true)]
[DefaultEvent("Opening")]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
public class ContextMenuStrip : ToolStripDropDownMenu
{
	private Control source_control;

	internal Control container;

	internal void SetSourceControl(Control source_control)
	{
	}
}
