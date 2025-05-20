using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace System.Windows.Forms;

/// <summary>Represents an individual item that is displayed within a <see cref="T:System.Windows.Forms.MainMenu" /> or <see cref="T:System.Windows.Forms.ContextMenu" />. Although <see cref="T:System.Windows.Forms.ToolStripMenuItem" /> replaces and adds functionality to the <see cref="T:System.Windows.Forms.MenuItem" /> control of previous versions, <see cref="T:System.Windows.Forms.MenuItem" /> is retained for both backward compatibility and future use if you choose.</summary>
[DefaultEvent("Click")]
[DesignTimeVisible(false)]
[DefaultProperty("Text")]
[ToolboxItem(false)]
public class MenuItem : Menu
{
	internal bool separator;

	internal bool break_;

	internal bool bar_break;

	private Shortcut shortcut;

	private string text;

	private bool checked_;

	private bool radiocheck;

	private bool enabled;

	private char mnemonic;

	private bool showshortcut;

	private int index;

	private bool mdilist;

	private Hashtable mdilist_items;

	private Hashtable mdilist_forms;

	private MdiClient mdicontainer;

	private bool is_window_menu_item;

	private bool defaut_item;

	private bool visible;

	private bool ownerdraw;

	private int menuid;

	private int mergeorder;

	private int xtab;

	private int menuheight;

	private bool menubar;

	private MenuMerge mergetype;

	internal Rectangle bounds;

	private static object PopupEvent;

	private static object SelectEvent;

	private static object UIACheckedChangedEvent;

	private static object UIARadioCheckChangedEvent;

	private static object UIAEnabledChangedEvent;

	private static object UIATextChangedEvent;

	private bool selected;

	/// <summary>Gets or sets a value indicating whether the <see cref="T:System.Windows.Forms.MenuItem" /> is placed on a new line (for a menu item added to a <see cref="T:System.Windows.Forms.MainMenu" /> object) or in a new column (for a submenu item or menu item displayed in a <see cref="T:System.Windows.Forms.ContextMenu" />).</summary>
	/// <returns>
	///   <see langword="true" /> if the menu item is placed on a new line or in a new column; <see langword="false" /> if the menu item is left in its default placement. The default is <see langword="false" />.</returns>
	[DefaultValue(false)]
	[Browsable(false)]
	public bool BarBreak
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the item is placed on a new line (for a menu item added to a <see cref="T:System.Windows.Forms.MainMenu" /> object) or in a new column (for a menu item or submenu item displayed in a <see cref="T:System.Windows.Forms.ContextMenu" />).</summary>
	/// <returns>
	///   <see langword="true" /> if the menu item is placed on a new line or in a new column; <see langword="false" /> if the menu item is left in its default placement. The default is <see langword="false" />.</returns>
	[DefaultValue(false)]
	[Browsable(false)]
	public bool Break
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether a check mark appears next to the text of the menu item.</summary>
	/// <returns>
	///   <see langword="true" /> if there is a check mark next to the menu item; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentException">The <see cref="T:System.Windows.Forms.MenuItem" /> is a top-level menu or has children.</exception>
	[DefaultValue(false)]
	public bool Checked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the menu item is the default menu item.</summary>
	/// <returns>
	///   <see langword="true" /> if the menu item is the default item in a menu; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[DefaultValue(false)]
	public bool DefaultItem
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the menu item is enabled.</summary>
	/// <returns>
	///   <see langword="true" /> if the menu item is enabled; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[Localizable(true)]
	[DefaultValue(true)]
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

	/// <summary>Gets or sets a value indicating the position of the menu item in its parent menu.</summary>
	/// <returns>The zero-based index representing the position of the menu item in its parent menu.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The assigned value is less than zero or greater than the item count.</exception>
	[Browsable(false)]
	public int Index
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the menu item will be populated with a list of the Multiple Document Interface (MDI) child windows that are displayed within the associated form.</summary>
	/// <returns>
	///   <see langword="true" /> if a list of the MDI child windows is displayed in this menu item; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[DefaultValue(false)]
	public bool MdiList
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating the relative position of the menu item when it is merged with another.</summary>
	/// <returns>A zero-based index representing the merge order position for this menu item. The default is 0.</returns>
	[DefaultValue(0)]
	public int MergeOrder
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating the behavior of this menu item when its menu is merged with another.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.MenuMerge" /> value that represents the menu item's merge type.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The assigned value is not one of the <see cref="T:System.Windows.Forms.MenuMerge" /> values.</exception>
	[DefaultValue(MenuMerge.Add)]
	public MenuMerge MergeType
	{
		get
		{
			return default(MenuMerge);
		}
		set
		{
		}
	}

	/// <summary>Gets a value indicating the mnemonic character that is associated with this menu item.</summary>
	/// <returns>A character that represents the mnemonic character associated with this menu item. Returns the NUL character (ASCII value 0) if no mnemonic character is specified in the text of the <see cref="T:System.Windows.Forms.MenuItem" />.</returns>
	[Browsable(false)]
	public char Mnemonic => '\0';

	/// <summary>Gets or sets a value indicating whether the code that you provide draws the menu item or Windows draws the menu item.</summary>
	/// <returns>
	///   <see langword="true" /> if the menu item is to be drawn using code; <see langword="false" /> if the menu item is to be drawn by Windows. The default is <see langword="false" />.</returns>
	[DefaultValue(false)]
	public bool OwnerDraw
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets a value indicating the menu that contains this menu item.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.Menu" /> that represents the menu that contains this menu item.</returns>
	[Browsable(false)]
	public Menu Parent => null;

	/// <summary>Gets or sets a value indicating whether the <see cref="T:System.Windows.Forms.MenuItem" />, if checked, displays a radio-button instead of a check mark.</summary>
	/// <returns>
	///   <see langword="true" /> if a radio-button is to be used instead of a check mark; <see langword="false" /> if the standard check mark is to be displayed when the menu item is checked. The default is <see langword="false" />.</returns>
	[DefaultValue(false)]
	public bool RadioCheck
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating the shortcut key associated with the menu item.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.Shortcut" /> values. The default is <see langword="Shortcut.None" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The assigned value is not one of the <see cref="T:System.Windows.Forms.Shortcut" /> values.</exception>
	[DefaultValue(Shortcut.None)]
	[Localizable(true)]
	public Shortcut Shortcut
	{
		get
		{
			return default(Shortcut);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the shortcut key that is associated with the menu item is displayed next to the menu item caption.</summary>
	/// <returns>
	///   <see langword="true" /> if the shortcut key combination is displayed next to the menu item caption; <see langword="false" /> if the shortcut key combination is not to be displayed. The default is <see langword="true" />.</returns>
	[Localizable(true)]
	[DefaultValue(true)]
	public bool ShowShortcut
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating the caption of the menu item.</summary>
	/// <returns>The text caption of the menu item.</returns>
	[Localizable(true)]
	public string Text
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the menu item is visible.</summary>
	/// <returns>
	///   <see langword="true" /> if the menu item will be made visible on the menu; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[Localizable(true)]
	[DefaultValue(true)]
	public bool Visible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal new int Height
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal bool IsPopup => false;

	internal bool MeasureEventDefined => false;

	internal bool MenuBar
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal int MenuHeight
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal bool Selected
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool Separator => false;

	internal DrawItemState Status => default(DrawItemState);

	internal bool VisibleItems => false;

	internal new int Width
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal new int X
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal int XTab
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal new int Y
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Occurs when the menu item is clicked or selected using a shortcut key or access key defined for the menu item.</summary>
	public event EventHandler Click
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when the <see cref="P:System.Windows.Forms.MenuItem.OwnerDraw" /> property of a menu item is set to <see langword="true" /> and a request is made to draw the menu item.</summary>
	public event DrawItemEventHandler DrawItem
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when the menu needs to know the size of a menu item before drawing it.</summary>
	public event MeasureItemEventHandler MeasureItem
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Initializes a <see cref="T:System.Windows.Forms.MenuItem" /> with a blank caption.</summary>
	public MenuItem()
		: base(null)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.MenuItem" /> class with a specified caption for the menu item.</summary>
	/// <param name="text">The caption for the menu item.</param>
	public MenuItem(string text)
		: base(null)
	{
	}

	/// <summary>Initializes a new instance of the class with a specified caption and event handler for the <see cref="E:System.Windows.Forms.MenuItem.Click" /> event of the menu item.</summary>
	/// <param name="text">The caption for the menu item.</param>
	/// <param name="onClick">The <see cref="T:System.EventHandler" /> that handles the <see cref="E:System.Windows.Forms.MenuItem.Click" /> event for this menu item.</param>
	public MenuItem(string text, EventHandler onClick)
		: base(null)
	{
	}

	private void CommonConstructor(string text)
	{
	}

	internal void OnUIACheckedChanged(EventArgs e)
	{
	}

	internal void OnUIARadioCheckChanged(EventArgs e)
	{
	}

	internal void OnUIAEnabledChanged(EventArgs e)
	{
	}

	internal void OnUIATextChanged(EventArgs e)
	{
	}

	/// <summary>Creates a copy of the current <see cref="T:System.Windows.Forms.MenuItem" />.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.MenuItem" /> that represents the duplicated menu item.</returns>
	public virtual MenuItem CloneMenu()
	{
		return null;
	}

	/// <summary>Creates a copy of the specified <see cref="T:System.Windows.Forms.MenuItem" />.</summary>
	/// <param name="itemSrc">The <see cref="T:System.Windows.Forms.MenuItem" /> that represents the menu item to copy.</param>
	protected void CloneMenu(MenuItem itemSrc)
	{
	}

	/// <summary>Disposes of the resources (other than memory) used by the <see cref="T:System.Windows.Forms.MenuItem" />.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	/// <summary>Merges another menu item with this menu item.</summary>
	/// <param name="itemSrc">A <see cref="T:System.Windows.Forms.MenuItem" /> that specifies the menu item to merge with this one.</param>
	public void MergeMenu(MenuItem itemSrc)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.MenuItem.Click" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnClick(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.MenuItem.DrawItem" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.DrawItemEventArgs" /> that contains the event data.</param>
	protected virtual void OnDrawItem(DrawItemEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.MenuItem.MeasureItem" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.MeasureItemEventArgs" /> that contains the event data.</param>
	protected virtual void OnMeasureItem(MeasureItemEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.MenuItem.Popup" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnPopup(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.MenuItem.Select" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnSelect(EventArgs e)
	{
	}

	/// <summary>Generates a <see cref="E:System.Windows.Forms.Control.Click" /> event for the <see cref="T:System.Windows.Forms.MenuItem" />, simulating a click by a user.</summary>
	public void PerformClick()
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.MenuItem.Select" /> event for this menu item.</summary>
	public virtual void PerformSelect()
	{
	}

	/// <summary>Returns a string that represents the <see cref="T:System.Windows.Forms.MenuItem" />.</summary>
	/// <returns>A string that represents the current <see cref="T:System.Windows.Forms.MenuItem" />. The string includes the type and the <see cref="P:System.Windows.Forms.MenuItem.Text" /> property of the control.</returns>
	public override string ToString()
	{
		return null;
	}

	internal virtual void Invalidate()
	{
	}

	internal void PerformPopup()
	{
	}

	internal void PerformDrawItem(DrawItemEventArgs e)
	{
	}

	private void PopulateWindowMenu()
	{
	}

	internal void PerformMeasureItem(MeasureItemEventArgs e)
	{
	}

	private void ProcessMnemonic()
	{
	}

	private string GetShortCutTextCtrl()
	{
		return null;
	}

	private string GetShortCutTextAlt()
	{
		return null;
	}

	private string GetShortCutTextShift()
	{
		return null;
	}

	internal string GetShortCutText()
	{
		return null;
	}

	private void MdiWindowClickHandler(object sender, EventArgs e)
	{
	}

	private void UpdateMenuItem()
	{
	}
}
