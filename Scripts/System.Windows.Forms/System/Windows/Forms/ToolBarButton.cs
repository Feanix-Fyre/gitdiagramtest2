using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;

namespace System.Windows.Forms;

/// <summary>Represents a Windows toolbar button. Although <see cref="T:System.Windows.Forms.ToolStripButton" /> replaces and extends the <see cref="T:System.Windows.Forms.ToolBarButton" /> control of previous versions, <see cref="T:System.Windows.Forms.ToolBarButton" /> is retained for both backward compatibility and future use if you choose.</summary>
[DefaultProperty("Text")]
[DesignTimeVisible(false)]
[Designer("System.Windows.Forms.Design.ToolBarButtonDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.IDesigner")]
[ToolboxItem(false)]
public class ToolBarButton : Component
{
	private bool enabled;

	private int image_index;

	private ContextMenu menu;

	private ToolBar parent;

	private bool partial_push;

	private bool pushed;

	private ToolBarButtonStyle style;

	private string text;

	private string tooltip;

	private bool visible;

	private string image_key;

	private bool uiaHasFocus;

	private static object UIAGotFocusEvent;

	private static object UIALostFocusEvent;

	private static object UIATextChangedEvent;

	private static object UIAEnabledChangedEvent;

	private static object UIADropDownMenuChangedEvent;

	private static object UIAStyleChangedEvent;

	internal Image Image => null;

	/// <summary>Gets or sets the menu to be displayed in the drop-down toolbar button.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.ContextMenu" /> to be displayed in the drop-down toolbar button. The default is <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentException">The assigned object is not a <see cref="T:System.Windows.Forms.ContextMenu" />.</exception>
	[DefaultValue(null)]
	[TypeConverter(typeof(ReferenceConverter))]
	public Menu DropDownMenu
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the button is enabled.</summary>
	/// <returns>
	///   <see langword="true" /> if the button is enabled; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[DefaultValue(true)]
	[Localizable(true)]
	public bool Enabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the index value of the image assigned to the button.</summary>
	/// <returns>The index value of the <see cref="T:System.Drawing.Image" /> assigned to the toolbar button. The default is -1.</returns>
	/// <exception cref="T:System.ArgumentException">The assigned value is less than -1.</exception>
	[RefreshProperties(RefreshProperties.Repaint)]
	[DefaultValue(-1)]
	[Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	[Localizable(true)]
	[TypeConverter(typeof(ImageIndexConverter))]
	public int ImageIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets the toolbar control that the toolbar button is assigned to.</summary>
	/// <returns>The <see cref="T:System.Windows.Forms.ToolBar" /> control that the <see cref="T:System.Windows.Forms.ToolBarButton" /> is assigned to.</returns>
	[Browsable(false)]
	public ToolBar Parent => null;

	/// <summary>Gets or sets a value indicating whether a toggle-style toolbar button is partially pushed.</summary>
	/// <returns>
	///   <see langword="true" /> if a toggle-style toolbar button is partially pushed; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[DefaultValue(false)]
	public bool PartialPush => false;

	/// <summary>Gets or sets a value indicating whether a toggle-style toolbar button is currently in the pushed state.</summary>
	/// <returns>
	///   <see langword="true" /> if a toggle-style toolbar button is currently in the pushed state; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[DefaultValue(false)]
	public bool Pushed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets the bounding rectangle for a toolbar button.</summary>
	/// <returns>The bounding <see cref="T:System.Drawing.Rectangle" /> for a toolbar button.</returns>
	public Rectangle Rectangle => default(Rectangle);

	/// <summary>Gets or sets the style of the toolbar button.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.ToolBarButtonStyle" /> values. The default is <see langword="ToolBarButtonStyle.PushButton" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The assigned value is not one of the <see cref="T:System.Windows.Forms.ToolBarButtonStyle" /> values.</exception>
	[RefreshProperties(RefreshProperties.Repaint)]
	[DefaultValue(ToolBarButtonStyle.PushButton)]
	public ToolBarButtonStyle Style
	{
		get
		{
			return default(ToolBarButtonStyle);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the text displayed on the toolbar button.</summary>
	/// <returns>The text displayed on the toolbar button. The default is an empty string ("").</returns>
	[DefaultValue(null)]
	[Localizable(true)]
	public string Text => null;

	/// <summary>Gets or sets the text that appears as a ToolTip for the button.</summary>
	/// <returns>The text that is displayed when the mouse pointer moves over the toolbar button. The default is an empty string ("").</returns>
	[Localizable(true)]
	[DefaultValue(null)]
	public string ToolTipText => null;

	/// <summary>Gets or sets a value indicating whether the toolbar button is visible.</summary>
	/// <returns>
	///   <see langword="true" /> if the toolbar button is visible; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[DefaultValue(true)]
	[Localizable(true)]
	public bool Visible => false;

	internal bool UIAHasFocus
	{
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ToolBarButton" /> class.</summary>
	public ToolBarButton()
	{
	}

	internal void SetParent(ToolBar parent)
	{
	}

	internal void Invalidate()
	{
	}

	private void OnUIAEnabledChanged(EventArgs e)
	{
	}

	private void OnUIADropDownMenuChanged(EventArgs e)
	{
	}

	private void OnUIAStyleChanged(EventArgs e)
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Windows.Forms.ToolBarButton" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	/// <summary>Returns a string that represents the <see cref="T:System.Windows.Forms.ToolBarButton" /> control.</summary>
	/// <returns>A string that represents the current <see cref="T:System.Windows.Forms.ToolBarButton" />.</returns>
	public override string ToString()
	{
		return null;
	}
}
