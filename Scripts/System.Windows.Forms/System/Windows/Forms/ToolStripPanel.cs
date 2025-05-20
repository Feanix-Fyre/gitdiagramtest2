using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Creates a container within which other controls can share horizontal or vertical space.</summary>
[Designer("System.Windows.Forms.Design.ToolStripPanelDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.IDesigner")]
[ComVisible(true)]
[ToolboxBitmap(null)]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
public class ToolStripPanel : ContainerControl
{
	private static object RendererChangedEvent;
}
