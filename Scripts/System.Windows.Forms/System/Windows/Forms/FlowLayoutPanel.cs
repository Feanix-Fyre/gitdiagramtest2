using System.ComponentModel;
using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Represents a panel that dynamically lays out its contents horizontally or vertically.</summary>
[Docking(DockingBehavior.Ask)]
[DefaultProperty("FlowDirection")]
[Designer("System.Windows.Forms.Design.FlowLayoutPanelDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.IDesigner")]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ProvideProperty("FlowBreak", typeof(Control))]
[ComVisible(true)]
public class FlowLayoutPanel : Panel
{
	private FlowLayoutSettings settings;

	internal FlowLayoutSettings LayoutSettings => null;
}
