using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Represents a window or dialog box that makes up an application's user interface.</summary>
[InitializationEvent("Load")]
[DefaultEvent("Load")]
[ComVisible(true)]
[ToolboxItemFilter("System.Windows.Forms.Control.TopLevel")]
[ToolboxItem(false)]
[DesignerCategory("Form")]
[DesignTimeVisible(false)]
[Designer("System.Windows.Forms.Design.FormDocumentDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(IRootDesigner))]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
public class Form : ContainerControl
{
	/// <summary>Represents a collection of controls on the form.</summary>
	[ComVisible(false)]
	public new class ControlCollection : Control.ControlCollection
	{
		private Form form_owner;

		/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.Form.ControlCollection" /> class.</summary>
		/// <param name="owner">The <see cref="T:System.Windows.Forms.Form" /> to contain the controls added to the control collection.</param>
		public ControlCollection(Form owner)
			: base(null)
		{
		}

		/// <summary>Adds a control to the form.</summary>
		/// <param name="value">The <see cref="T:System.Windows.Forms.Control" /> to add to the form.</param>
		/// <exception cref="T:System.Exception">A multiple document interface (MDI) parent form cannot have controls added to it.</exception>
		public override void Add(Control value)
		{
		}

		/// <summary>Removes a control from the form.</summary>
		/// <param name="value">A <see cref="T:System.Windows.Forms.Control" /> to remove from the form.</param>
		public override void Remove(Control value)
		{
		}
	}

	internal bool closing;

	private bool closed;

	private FormBorderStyle form_border_style;

	private bool is_active;

	private bool autoscale;

	private Size clientsize_set;

	private Size autoscale_base_size;

	private bool allow_transparency;

	private static Icon default_icon;

	internal bool is_modal;

	internal FormWindowState window_state;

	private bool control_box;

	private bool minimize_box;

	private bool maximize_box;

	private bool help_button;

	private bool show_in_taskbar;

	private bool topmost;

	private IButtonControl accept_button;

	private IButtonControl cancel_button;

	private DialogResult dialog_result;

	private FormStartPosition start_position;

	private Form owner;

	private ControlCollection owned_forms;

	private MdiClient mdi_container;

	internal InternalWindowManager window_manager;

	private Form mdi_parent;

	private bool key_preview;

	private MainMenu menu;

	private Icon icon;

	private Size maximum_size;

	private Size minimum_size;

	private SizeGripStyle size_grip_style;

	private SizeGrip size_grip;

	private Rectangle maximized_bounds;

	private Rectangle default_maximized_bounds;

	private double opacity;

	internal ApplicationContext context;

	private Color transparency_key;

	private bool is_loaded;

	internal int is_changing_visible_state;

	internal bool has_been_visible;

	private bool shown_raised;

	private bool close_raised;

	private bool is_clientsize_set;

	internal bool suppress_closing_events;

	internal bool waiting_showwindow;

	private bool is_minimizing;

	private bool show_icon;

	private MenuStrip main_menu_strip;

	private Rectangle restore_bounds;

	private bool autoscale_base_size_set;

	private static object ActivatedEvent;

	private static object ClosingEvent;

	private static object InputLanguageChangedEvent;

	private static object InputLanguageChangingEvent;

	private static object MaximizedBoundsChangedEvent;

	private static object MaximumSizeChangedEvent;

	private static object MdiChildActivateEvent;

	private static object MenuCompleteEvent;

	private static object MenuStartEvent;

	private static object MinimumSizeChangedEvent;

	private static object FormClosingEvent;

	private static object HelpButtonClickedEvent;

	private static object ResizeEndEvent;

	private static object ResizeBeginEvent;

	private static object RightToLeftLayoutChangedEvent;

	private static object ShownEvent;

	private static object UIAMenuChangedEvent;

	private static object UIATopMostChangedEvent;

	private static object UIAWindowStateChangedEvent;

	internal bool IsLoaded => false;

	internal bool IsActive
	{
		set
		{
		}
	}

	/// <summary>Gets the currently active form for this application.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.Form" /> that represents the currently active form, or <see langword="null" /> if there is no active form.</returns>
	public static Form ActiveForm => null;

	/// <summary>Gets or sets the button on the form that is clicked when the user presses the ENTER key.</summary>
	/// <returns>An <see cref="T:System.Windows.Forms.IButtonControl" /> that represents the button to use as the accept button for the form.</returns>
	[DefaultValue(null)]
	public IButtonControl AcceptButton
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the form adjusts its size to fit the height of the font used on the form and scales its controls.</summary>
	/// <returns>
	///   <see langword="true" /> if the form will automatically scale itself and its controls based on the current font assigned to the form; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[MWFCategory("Layout")]
	[Obsolete("This property has been deprecated in favor of AutoScaleMode.")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool AutoScale
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the base size used for autoscaling of the form.</summary>
	/// <returns>A <see cref="T:System.Drawing.Size" /> that represents the base size that this form uses for autoscaling.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	[Localizable(true)]
	public virtual Size AutoScaleBaseSize
	{
		get
		{
			return default(Size);
		}
		[System.MonoTODO("Setting this is probably unintentional and can cause Forms to be improperly sized.  See http://www.mono-project.com/FAQ:_Winforms#My_forms_are_sized_improperly for details.")]
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the form enables autoscrolling.</summary>
	/// <returns>
	///   <see langword="true" /> to enable autoscrolling on the form; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[Localizable(true)]
	public override bool AutoScroll => false;

	/// <summary>Resize the form according to the setting of <see cref="P:System.Windows.Forms.Form.AutoSizeMode" />.</summary>
	/// <returns>
	///   <see langword="true" /> if the form will automatically resize; <see langword="false" /> if it must be manually resized.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[Browsable(true)]
	[EditorBrowsable(EditorBrowsableState.Always)]
	public override bool AutoSize
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the mode by which the form automatically resizes itself.</summary>
	/// <returns>An <see cref="T:System.Windows.Forms.AutoSizeMode" /> enumerated value. The default is <see cref="F:System.Windows.Forms.AutoSizeMode.GrowOnly" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value is not a valid <see cref="T:System.Windows.Forms.AutoSizeMode" /> value.</exception>
	[DefaultValue(AutoSizeMode.GrowOnly)]
	[Browsable(true)]
	[Localizable(true)]
	public AutoSizeMode AutoSizeMode => default(AutoSizeMode);

	/// <summary>Gets or sets the background color for the control.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that represents the background color of the control. The default is the value of the <see cref="P:System.Windows.Forms.Control.DefaultBackColor" /> property.</returns>
	public override Color BackColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the button control that is clicked when the user presses the ESC key.</summary>
	/// <returns>An <see cref="T:System.Windows.Forms.IButtonControl" /> that represents the cancel button for the form.</returns>
	[DefaultValue(null)]
	public IButtonControl CancelButton
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the size of the client area of the form.</summary>
	/// <returns>A <see cref="T:System.Drawing.Size" /> that represents the size of the form's client area.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[Localizable(true)]
	public new Size ClientSize
	{
		get
		{
			return default(Size);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether a control box is displayed in the caption bar of the form.</summary>
	/// <returns>
	///   <see langword="true" /> if the form displays a control box in the upper-right corner of the form; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[DefaultValue(true)]
	[MWFCategory("Window Style")]
	public bool ControlBox
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the dialog result for the form.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.DialogResult" /> that represents the result of the form when used as a dialog box.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public DialogResult DialogResult
	{
		get
		{
			return default(DialogResult);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the border style of the form.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.FormBorderStyle" /> that represents the style of border to display for the form. The default is <see langword="FormBorderStyle.Sizable" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
	[DispId(-504)]
	[MWFCategory("Appearance")]
	[DefaultValue(FormBorderStyle.Sizable)]
	public FormBorderStyle FormBorderStyle
	{
		get
		{
			return default(FormBorderStyle);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether a Help button should be displayed in the caption box of the form.</summary>
	/// <returns>
	///   <see langword="true" /> to display a Help button in the form's caption bar; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[MWFCategory("Window Style")]
	[DefaultValue(false)]
	public bool HelpButton => false;

	/// <summary>Gets or sets the icon for the form.</summary>
	/// <returns>An <see cref="T:System.Drawing.Icon" /> that represents the icon for the form.</returns>
	[AmbientValue(null)]
	[Localizable(true)]
	[MWFCategory("Window Style")]
	public Icon Icon => null;

	/// <summary>Gets a value indicating whether the form is a multiple-document interface (MDI) child form.</summary>
	/// <returns>
	///   <see langword="true" /> if the form is an MDI child form; otherwise, <see langword="false" />.</returns>
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool IsMdiChild => false;

	/// <summary>Gets or sets a value indicating whether the form is a container for multiple-document interface (MDI) child forms.</summary>
	/// <returns>
	///   <see langword="true" /> if the form is a container for MDI child forms; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[DefaultValue(false)]
	[MWFCategory("Window Style")]
	public bool IsMdiContainer => false;

	/// <summary>Gets the currently active multiple-document interface (MDI) child window.</summary>
	/// <returns>Returns a <see cref="T:System.Windows.Forms.Form" /> that represents the currently active MDI child window, or <see langword="null" /> if there are currently no child windows present.</returns>
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Form ActiveMdiChild => null;

	/// <summary>Gets or sets the primary menu container for the form.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.MenuStrip" /> that represents the container for the menu structure of the form. The default is <see langword="null" />.</returns>
	[TypeConverter(typeof(ReferenceConverter))]
	[DefaultValue(null)]
	public MenuStrip MainMenuStrip => null;

	/// <summary>Gets or sets a value indicating whether the Maximize button is displayed in the caption bar of the form.</summary>
	/// <returns>
	///   <see langword="true" /> to display a Maximize button for the form; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[DefaultValue(true)]
	[MWFCategory("Window Style")]
	public bool MaximizeBox
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets the maximum size the form can be resized to.</summary>
	/// <returns>A <see cref="T:System.Drawing.Size" /> that represents the maximum size for the form.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The values of the height or width within the <see cref="T:System.Drawing.Size" /> object are less than zero.</exception>
	[MWFCategory("Layout")]
	[Localizable(true)]
	[RefreshProperties(RefreshProperties.Repaint)]
	[DefaultValue(typeof(Size), "0, 0")]
	public override Size MaximumSize => default(Size);

	/// <summary>Gets an array of forms that represent the multiple-document interface (MDI) child forms that are parented to this form.</summary>
	/// <returns>An array of <see cref="T:System.Windows.Forms.Form" /> objects, each of which identifies one of this form's MDI child forms.</returns>
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Form[] MdiChildren => null;

	/// <summary>Gets or sets the current multiple-document interface (MDI) parent form of this form.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.Form" /> that represents the MDI parent form.</returns>
	/// <exception cref="T:System.Exception">The <see cref="T:System.Windows.Forms.Form" /> assigned to this property is not marked as an MDI container.  
	///  -or-  
	///  The <see cref="T:System.Windows.Forms.Form" /> assigned to this property is both a child and an MDI container form.  
	///  -or-  
	///  The <see cref="T:System.Windows.Forms.Form" /> assigned to this property is located on a different thread.</exception>
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Form MdiParent => null;

	internal MdiClient MdiContainer => null;

	internal InternalWindowManager WindowManager => null;

	/// <summary>Gets or sets the <see cref="T:System.Windows.Forms.MainMenu" /> that is displayed in the form.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.MainMenu" /> that represents the menu to display in the form.</returns>
	[MWFCategory("Window Style")]
	[DefaultValue(null)]
	[TypeConverter(typeof(ReferenceConverter))]
	[Browsable(false)]
	public MainMenu Menu => null;

	/// <summary>Gets the merged menu for the form.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.MainMenu" /> that represents the merged menu of the form.</returns>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public MainMenu MergedMenu => null;

	internal MainMenu ActiveMenu => null;

	internal MdiWindowManager ActiveMaximizedMdiChild => null;

	/// <summary>Gets or sets a value indicating whether the Minimize button is displayed in the caption bar of the form.</summary>
	/// <returns>
	///   <see langword="true" /> to display a Minimize button for the form; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[MWFCategory("Window Style")]
	[DefaultValue(true)]
	public bool MinimizeBox
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the minimum size the form can be resized to.</summary>
	/// <returns>A <see cref="T:System.Drawing.Size" /> that represents the minimum size for the form.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The values of the height or width within the <see cref="T:System.Drawing.Size" /> object are less than zero.</exception>
	[MWFCategory("Layout")]
	[Localizable(true)]
	[RefreshProperties(RefreshProperties.Repaint)]
	public override Size MinimumSize
	{
		get
		{
			return default(Size);
		}
		set
		{
		}
	}

	/// <summary>Gets a value indicating whether this form is displayed modally.</summary>
	/// <returns>
	///   <see langword="true" /> if the form is displayed modally; otherwise, <see langword="false" />.</returns>
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool Modal => false;

	/// <summary>Gets or sets the form that owns this form.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.Form" /> that represents the form that is the owner of this form.</returns>
	/// <exception cref="T:System.Exception">A top-level window cannot have an owner.</exception>
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Form Owner
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether an icon is displayed in the caption bar of the form.</summary>
	/// <returns>
	///   <see langword="true" /> if the form displays an icon in the caption bar; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[DefaultValue(true)]
	public bool ShowIcon => false;

	/// <summary>Gets or sets a value indicating whether the form is displayed in the Windows taskbar.</summary>
	/// <returns>
	///   <see langword="true" /> to display the form in the Windows taskbar at run time; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[DefaultValue(true)]
	[MWFCategory("Window Style")]
	public bool ShowInTaskbar
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the size of the form.</summary>
	/// <returns>A <see cref="T:System.Drawing.Size" /> that represents the size of the form.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Localizable(false)]
	public new Size Size
	{
		get
		{
			return default(Size);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the style of the size grip to display in the lower-right corner of the form.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.SizeGripStyle" /> that represents the style of the size grip to display. The default is <see cref="F:System.Windows.Forms.SizeGripStyle.Auto" /></returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
	[DefaultValue(SizeGripStyle.Auto)]
	[MWFCategory("Window Style")]
	public SizeGripStyle SizeGripStyle
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the starting position of the form at run time.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.FormStartPosition" /> that represents the starting position of the form.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
	[DefaultValue(FormStartPosition.WindowsDefaultLocation)]
	[MWFCategory("Layout")]
	[Localizable(true)]
	public FormStartPosition StartPosition
	{
		get
		{
			return default(FormStartPosition);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether to display the form as a top-level window.</summary>
	/// <returns>
	///   <see langword="true" /> to display the form as a top-level window; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	/// <exception cref="T:System.Exception">A Multiple-document interface (MDI) parent form must be a top-level window.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool TopLevel => false;

	/// <summary>Gets or sets a value indicating whether the form should be displayed as a topmost form.</summary>
	/// <returns>
	///   <see langword="true" /> to display the form as a topmost form; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[DefaultValue(false)]
	[MWFCategory("Window Style")]
	public bool TopMost
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the color that will represent transparent areas of the form.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that represents the color to display transparently on the form.</returns>
	[MWFCategory("Window Style")]
	public Color TransparencyKey => default(Color);

	/// <summary>Gets or sets a value that indicates whether form is minimized, maximized, or normal.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.FormWindowState" /> that represents whether form is minimized, maximized, or normal. The default is <see langword="FormWindowState.Normal" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
	[DefaultValue(FormWindowState.Normal)]
	[MWFCategory("Layout")]
	public FormWindowState WindowState
	{
		get
		{
			return default(FormWindowState);
		}
		set
		{
		}
	}

	/// <summary>Gets the required creation parameters when the control handle is created.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.CreateParams" /> that contains the required creation parameters when the handle to the control is created.</returns>
	protected override CreateParams CreateParams => null;

	/// <summary>Gets the default size of the control.</summary>
	/// <returns>The default <see cref="T:System.Drawing.Size" /> of the control.</returns>
	protected override Size DefaultSize => default(Size);

	/// <summary>Gets a value indicating whether the window will be activated when it is shown.</summary>
	/// <returns>
	///   <see langword="true" /> if the window will not be activated when it is shown; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[Browsable(false)]
	[System.MonoTODO("Implemented for Win32, needs X11 implementation")]
	protected virtual bool ShowWithoutActivation => false;

	internal override bool ActivateOnShow => false;

	/// <summary>Gets or sets the text associated with this control.</summary>
	/// <returns>The text associated with this control.</returns>
	[SettingsBindable(true)]
	public override string Text
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the <see cref="T:System.Drawing.Point" /> that represents the upper-left corner of the <see cref="T:System.Windows.Forms.Form" /> in screen coordinates.</summary>
	/// <returns>The <see cref="T:System.Drawing.Point" /> that represents the upper-left corner of the <see cref="T:System.Windows.Forms.Form" /> in screen coordinates.</returns>
	[SettingsBindable(true)]
	public new Point Location
	{
		get
		{
			return default(Point);
		}
		set
		{
		}
	}

	/// <summary>Occurs when the form is closed.</summary>
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public event EventHandler Closed
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when the form loses focus and is no longer the active form.</summary>
	public event EventHandler Deactivate
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs before a form is displayed for the first time.</summary>
	public event EventHandler Load
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs after the form is closed.</summary>
	public event FormClosedEventHandler FormClosed
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.Form" /> class.</summary>
	public Form()
	{
	}

	static Form()
	{
	}

	internal bool FireClosingEvents(CloseReason reason, bool cancel)
	{
		return false;
	}

	private void FireClosedEvents(CloseReason reason)
	{
	}

	internal override Size GetPreferredSizeCore(Size proposedSize)
	{
		return default(Size);
	}

	/// <summary>Retrieves the bounds within which the control is scaled.</summary>
	/// <param name="bounds">A <see cref="T:System.Drawing.Rectangle" /> that specifies the area for which to retrieve the display bounds.</param>
	/// <param name="factor">The height and width of the control's bounds.</param>
	/// <param name="specified">One of the values of <see cref="T:System.Windows.Forms.BoundsSpecified" /> that specifies the bounds of the control to use when defining its size and position.</param>
	/// <returns>A <see cref="T:System.Drawing.Rectangle" /> representing the bounds within which the control is scaled.</returns>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override Rectangle GetScaledBounds(Rectangle bounds, SizeF factor, BoundsSpecified specified)
	{
		return default(Rectangle);
	}

	/// <summary>Processes a mnemonic character.</summary>
	/// <param name="charCode">The character to process.</param>
	/// <returns>
	///   <see langword="true" /> if the character was processed as a mnemonic by the control; otherwise, <see langword="false" />.</returns>
	protected override bool ProcessMnemonic(char charCode)
	{
		return false;
	}

	/// <summary>Scales the location, size, padding, and margin of a control.</summary>
	/// <param name="factor">The factor by which the height and width of the control are scaled.</param>
	/// <param name="specified">A <see cref="T:System.Windows.Forms.BoundsSpecified" /> value that specifies the bounds of the control to use when defining its size and position.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override void ScaleControl(SizeF factor, BoundsSpecified specified)
	{
	}

	internal void OnActivatedInternal()
	{
	}

	internal void OnDeactivateInternal()
	{
	}

	internal override void UpdateWindowText()
	{
	}

	internal void SelectActiveControl()
	{
	}

	private new void UpdateSizeGripVisible()
	{
	}

	internal void ChangingParent(Control new_parent)
	{
	}

	internal override bool FocusInternal(bool skip_check)
	{
		return false;
	}

	/// <summary>Gets the size when autoscaling the form based on a specified font.</summary>
	/// <param name="font">A <see cref="T:System.Drawing.Font" /> representing the font to determine the autoscaled base size of the form.</param>
	/// <returns>A <see cref="T:System.Drawing.SizeF" /> representing the autoscaled size of the form.</returns>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("This method has been deprecated.  Use AutoScaleDimensions instead")]
	public static SizeF GetAutoScaleSize(Font font)
	{
		return default(SizeF);
	}

	/// <summary>Activates the form and gives it focus.</summary>
	public void Activate()
	{
	}

	/// <summary>Adds an owned form to this form.</summary>
	/// <param name="ownedForm">The <see cref="T:System.Windows.Forms.Form" /> that this form will own.</param>
	public void AddOwnedForm(Form ownedForm)
	{
	}

	/// <summary>Closes the form.</summary>
	/// <exception cref="T:System.InvalidOperationException">The form was closed while a handle was being created.</exception>
	/// <exception cref="T:System.ObjectDisposedException">You cannot call this method from the <see cref="E:System.Windows.Forms.Form.Activated" /> event when <see cref="P:System.Windows.Forms.Form.WindowState" /> is set to <see cref="F:System.Windows.Forms.FormWindowState.Maximized" />.</exception>
	public void Close()
	{
	}

	/// <summary>Removes an owned form from this form.</summary>
	/// <param name="ownedForm">A <see cref="T:System.Windows.Forms.Form" /> representing the form to remove from the list of owned forms for this form.</param>
	public void RemoveOwnedForm(Form ownedForm)
	{
	}

	/// <summary>Shows the form as a modal dialog box.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.DialogResult" /> values.</returns>
	/// <exception cref="T:System.InvalidOperationException">The form being shown is already visible.  
	///  -or-  
	///  The form being shown is disabled.  
	///  -or-  
	///  The form being shown is not a top-level window.  
	///  -or-  
	///  The form being shown as a dialog box is already a modal form.  
	///  -or-  
	///  The current process is not running in user interactive mode (for more information, see <see cref="P:System.Windows.Forms.SystemInformation.UserInteractive" />).</exception>
	public DialogResult ShowDialog()
	{
		return default(DialogResult);
	}

	/// <summary>Shows the form as a modal dialog box with the specified owner.</summary>
	/// <param name="owner">Any object that implements <see cref="T:System.Windows.Forms.IWin32Window" /> that represents the top-level window that will own the modal dialog box.</param>
	/// <returns>One of the <see cref="T:System.Windows.Forms.DialogResult" /> values.</returns>
	/// <exception cref="T:System.ArgumentException">The form specified in the <paramref name="owner" /> parameter is the same as the form being shown.</exception>
	/// <exception cref="T:System.InvalidOperationException">The form being shown is already visible.  
	///  -or-  
	///  The form being shown is disabled.  
	///  -or-  
	///  The form being shown is not a top-level window.  
	///  -or-  
	///  The form being shown as a dialog box is already a modal form.  
	///  -or-  
	///  The current process is not running in user interactive mode (for more information, see <see cref="P:System.Windows.Forms.SystemInformation.UserInteractive" />).</exception>
	public DialogResult ShowDialog(IWin32Window owner)
	{
		return default(DialogResult);
	}

	/// <summary>Gets a string representing the current instance of the form.</summary>
	/// <returns>A string consisting of the fully qualified name of the form object's class, with the <see cref="P:System.Windows.Forms.Form.Text" /> property of the form appended to the end. For example, if the form is derived from the class <c>MyForm</c> in the <c>MyNamespace</c> namespace, and the <see cref="P:System.Windows.Forms.Form.Text" /> property is set to <c>Hello, World</c>, this method will return <c>MyNamespace.MyForm, Text: Hello, World</c>.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Causes all of the child controls within a control that support validation to validate their data.</summary>
	/// <returns>
	///   <see langword="true" /> if all of the children validated successfully; otherwise, <see langword="false" />. If called from the <see cref="E:System.Windows.Forms.Control.Validating" /> or <see cref="E:System.Windows.Forms.Control.Validated" /> event handlers, this method will always return <see langword="false" />.</returns>
	[Browsable(true)]
	[EditorBrowsable(EditorBrowsableState.Always)]
	public override bool ValidateChildren()
	{
		return false;
	}

	/// <summary>Causes all of the child controls within a control that support validation to validate their data.</summary>
	/// <param name="validationConstraints">Places restrictions on which controls have their <see cref="E:System.Windows.Forms.Control.Validating" /> event raised.</param>
	/// <returns>
	///   <see langword="true" /> if all of the children validated successfully; otherwise, <see langword="false" />. If called from the <see cref="E:System.Windows.Forms.Control.Validating" /> or <see cref="E:System.Windows.Forms.Control.Validated" /> event handlers, this method will always return <see langword="false" />.</returns>
	[Browsable(true)]
	[EditorBrowsable(EditorBrowsableState.Always)]
	public override bool ValidateChildren(ValidationConstraints validationConstraints)
	{
		return false;
	}

	/// <summary>Activates the MDI child of a form.</summary>
	/// <param name="form">The child form to activate.</param>
	protected void ActivateMdiChild(Form form)
	{
	}

	/// <summary>Adjusts the scroll bars on the container based on the current control positions and the control currently selected.</summary>
	/// <param name="displayScrollbars">
	///   <see langword="true" /> to show the scroll bars; otherwise, <see langword="false" />.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override void AdjustFormScrollbars(bool displayScrollbars)
	{
	}

	/// <summary>Resizes the form according to the current value of the <see cref="P:System.Windows.Forms.Form.AutoScaleBaseSize" /> property and the size of the current font.</summary>
	[Obsolete("This method has been deprecated")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected void ApplyAutoScaling()
	{
	}

	/// <summary>Centers the position of the form within the bounds of the parent form.</summary>
	protected void CenterToParent()
	{
	}

	/// <summary>Centers the form on the current screen.</summary>
	protected void CenterToScreen()
	{
	}

	/// <summary>Creates a new instance of the control collection for the control.</summary>
	/// <returns>A new instance of <see cref="T:System.Windows.Forms.Control.ControlCollection" /> assigned to the control.</returns>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override Control.ControlCollection CreateControlsInstance()
	{
		return null;
	}

	/// <summary>Creates the handle for the form. If a derived class overrides this function, it must call the base implementation.</summary>
	/// <exception cref="T:System.InvalidOperationException">A handle for this <see cref="T:System.Windows.Forms.Form" /> has already been created.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override void CreateHandle()
	{
	}

	/// <summary>Sends the specified message to the default window procedure.</summary>
	/// <param name="m">The Windows <see cref="T:System.Windows.Forms.Message" /> to process.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override void DefWndProc(ref Message m)
	{
	}

	/// <summary>Disposes of the resources (other than memory) used by the <see cref="T:System.Windows.Forms.Form" />.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Form.Activated" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnActivated(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Form.Closed" /> event.</summary>
	/// <param name="e">The <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnClosed(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Form.Closing" /> event.</summary>
	/// <param name="e">A <see cref="T:System.ComponentModel.CancelEventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnClosing(CancelEventArgs e)
	{
	}

	/// <summary>Raises the <see langword="CreateControl" /> event.</summary>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override void OnCreateControl()
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Form.Deactivate" /> event.</summary>
	/// <param name="e">The <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnDeactivate(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.FontChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override void OnFontChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.HandleCreated" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override void OnHandleCreated(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.HandleDestroyed" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override void OnHandleDestroyed(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Form.Load" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnLoad(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Form.MdiChildActivate" /> event.</summary>
	/// <param name="e">The <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnMdiChildActivate(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Form.MenuComplete" /> event.</summary>
	/// <param name="e">The <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal virtual void OnMenuComplete(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Form.MinimumSizeChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnMinimumSizeChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Paint" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override void OnPaint(PaintEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Resize" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override void OnResize(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.StyleChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override void OnStyleChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.TextChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override void OnTextChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.VisibleChanged" /> event.</summary>
	/// <param name="e">The <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override void OnVisibleChanged(EventArgs e)
	{
	}

	/// <summary>Processes a command key.</summary>
	/// <param name="msg">A <see cref="T:System.Windows.Forms.Message" />, passed by reference, that represents the Win32 message to process.</param>
	/// <param name="keyData">One of the <see cref="T:System.Windows.Forms.Keys" /> values that represents the key to process.</param>
	/// <returns>
	///   <see langword="true" /> if the keystroke was processed and consumed by the control; otherwise, <see langword="false" /> to allow further processing.</returns>
	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		return false;
	}

	/// <summary>Processes a dialog character.</summary>
	/// <param name="charCode">The character to process.</param>
	/// <returns>
	///   <see langword="true" /> if the character was processed by the control; otherwise, <see langword="false" />.</returns>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override bool ProcessDialogChar(char charCode)
	{
		return false;
	}

	/// <summary>Processes a dialog box key.</summary>
	/// <param name="keyData">One of the <see cref="T:System.Windows.Forms.Keys" /> values that represents the key to process.</param>
	/// <returns>
	///   <see langword="true" /> if the keystroke was processed and consumed by the control; otherwise, <see langword="false" /> to allow further processing.</returns>
	protected override bool ProcessDialogKey(Keys keyData)
	{
		return false;
	}

	/// <summary>Previews a keyboard message.</summary>
	/// <param name="m">A <see cref="T:System.Windows.Forms.Message" />, passed by reference, that represents the window message to process.</param>
	/// <returns>
	///   <see langword="true" /> if the message was processed by the control; otherwise, <see langword="false" />.</returns>
	protected override bool ProcessKeyPreview(ref Message m)
	{
		return false;
	}

	/// <summary>Selects the next available control and makes it the active control.</summary>
	/// <param name="forward">
	///   <see langword="true" /> to cycle forward through the controls in the ContainerControl; otherwise, <see langword="false" />.</param>
	/// <returns>
	///   <see langword="true" /> if a control is selected; otherwise, <see langword="false" />.</returns>
	protected override bool ProcessTabKey(bool forward)
	{
		return false;
	}

	/// <summary>Performs scaling of the form.</summary>
	/// <param name="x">Percentage to scale the form horizontally</param>
	/// <param name="y">Percentage to scale the form vertically</param>
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override void ScaleCore(float x, float y)
	{
	}

	/// <summary>Selects this form, and optionally selects the next or previous control.</summary>
	/// <param name="directed">If set to true that the active control is changed</param>
	/// <param name="forward">If directed is true, then this controls the direction in which focus is moved. If this is <see langword="true" />, then the next control is selected; otherwise, the previous control is selected.</param>
	protected override void Select(bool directed, bool forward)
	{
	}

	/// <summary>Performs the work of setting the specified bounds of this control.</summary>
	/// <param name="x">The new <see cref="P:System.Windows.Forms.Control.Left" /> property value of the control.</param>
	/// <param name="y">The new <see cref="P:System.Windows.Forms.Control.Top" /> property value of the control.</param>
	/// <param name="width">The new <see cref="P:System.Windows.Forms.Control.Width" /> property value of the control.</param>
	/// <param name="height">The new <see cref="P:System.Windows.Forms.Control.Height" /> property value of the control.</param>
	/// <param name="specified">A bitwise combination of the <see cref="T:System.Windows.Forms.BoundsSpecified" /> values.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
	{
	}

	/// <summary>Sets the client size of the form. This will adjust the bounds of the form to make the client size the requested size.</summary>
	/// <param name="x">Requested width of the client region.</param>
	/// <param name="y">Requested height of the client region.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override void SetClientSizeCore(int x, int y)
	{
	}

	/// <summary>Sets the control to the specified visible state.</summary>
	/// <param name="value">
	///   <see langword="true" /> to make the control visible; otherwise, <see langword="false" />.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override void SetVisibleCore(bool value)
	{
	}

	/// <summary>Processes Windows messages.</summary>
	/// <param name="m">The Windows <see cref="T:System.Windows.Forms.Message" /> to process.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override void WndProc(ref Message m)
	{
	}

	private void WmDestroy(ref Message m)
	{
	}

	internal bool RaiseCloseEvents(bool last_check, bool cancel)
	{
		return false;
	}

	private void WmClose(ref Message m)
	{
	}

	private void WmWindowPosChanged(ref Message m)
	{
	}

	private void WmSysCommand(ref Message m)
	{
	}

	private void WmActivate(ref Message m)
	{
	}

	private void WmKillFocus(ref Message m)
	{
	}

	private void WmSetFocus(ref Message m)
	{
	}

	private void WmNcHitTest(ref Message m)
	{
	}

	private void WmNcLButtonDown(ref Message m)
	{
	}

	private void WmNcLButtonUp(ref Message m)
	{
	}

	private void WmNcMouseLeave(ref Message m)
	{
	}

	private void WmNcMouseMove(ref Message m)
	{
	}

	private void WmNcPaint(ref Message m)
	{
	}

	private void WmNcCalcSize(ref Message m)
	{
	}

	private void WmGetMinMaxInfo(ref Message m)
	{
	}

	internal override void FireEnter()
	{
	}

	internal override void FireLeave()
	{
	}

	internal void RemoveWindowManager()
	{
	}

	internal override void CheckAcceptButton()
	{
	}

	private void OnLoadInternal(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.BackgroundImageLayoutChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnBackgroundImageLayoutChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.EnabledChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override void OnEnabledChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Enter" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override void OnEnter(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Form.FormClosed" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.FormClosedEventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnFormClosed(FormClosedEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Form.FormClosing" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.FormClosingEventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnFormClosing(FormClosingEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Layout" /> event.</summary>
	/// <param name="levent">The event data.</param>
	protected override void OnLayout(LayoutEventArgs levent)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Form.ResizeBegin" /> event.</summary>
	/// <param name="e">A <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnResizeBegin(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Form.ResizeEnd" /> event.</summary>
	/// <param name="e">A <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnResizeEnd(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Form.Shown" /> event.</summary>
	/// <param name="e">A <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnShown(EventArgs e)
	{
	}

	internal void OnUIATopMostChanged()
	{
	}

	internal void OnUIAWindowStateChanged()
	{
	}
}
