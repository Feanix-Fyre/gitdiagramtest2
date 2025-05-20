using System.ComponentModel;
using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Represents a splitter control that enables the user to resize docked controls. <see cref="T:System.Windows.Forms.Splitter" /> has been replaced by <see cref="T:System.Windows.Forms.SplitContainer" /> and is provided only for compatibility with previous versions.</summary>
[DefaultEvent("SplitterMoved")]
[DefaultProperty("Dock")]
[ComVisible(true)]
[Designer("System.Windows.Forms.Design.SplitterDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.IDesigner")]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
public class Splitter : Control
{
	private static Cursor splitter_ns;

	private static Cursor splitter_we;

	private static object SplitterMovedEvent;

	private static object SplitterMovingEvent;

	static Splitter()
	{
	}
}
