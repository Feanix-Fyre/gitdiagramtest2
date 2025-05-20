using System.ComponentModel;
using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Represents the center panel of a <see cref="T:System.Windows.Forms.ToolStripContainer" /> control.</summary>
[Designer("System.Windows.Forms.Design.ToolStripContentPanelDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.IDesigner")]
[ToolboxItem(false)]
[Docking(DockingBehavior.Never)]
[InitializationEvent("Load")]
[ComVisible(true)]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[DefaultEvent("Load")]
public class ToolStripContentPanel : Panel
{
	private static object LoadEvent;

	private static object RendererChangedEvent;
}
