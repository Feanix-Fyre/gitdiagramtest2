using System.Drawing;
using System.Reflection;

namespace System.Windows.Forms;

internal abstract class Theme
{
	protected Array syscolors;

	private readonly Font default_font;

	protected Font window_border_font;

	protected Color defaultWindowBackColor;

	protected Color defaultWindowForeColor;

	internal SystemResPool ResPool;

	private MethodInfo update;

	public virtual Color ColorScrollBar => default(Color);

	public virtual Color ColorMenu
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public virtual Color ColorWindow => default(Color);

	public virtual Color ColorMenuText
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public virtual Color ColorWindowText => default(Color);

	public virtual Color ColorHighlight
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public virtual Color ColorHighlightText
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public virtual Color ColorControl
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public virtual Color ColorControlDark
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public virtual Color ColorGrayText => default(Color);

	public virtual Color ColorControlText
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public virtual Color ColorInactiveCaptionText => default(Color);

	public virtual Color ColorControlLight
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public virtual Color ColorControlDarkDark
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public virtual Color ColorControlLightLight
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public virtual Color ColorInfoText => default(Color);

	public virtual Color ColorInfo => default(Color);

	public virtual Color DefaultControlBackColor => default(Color);

	public virtual Color DefaultControlForeColor => default(Color);

	public virtual Font DefaultFont => null;

	public virtual Size BorderSizableSize => default(Size);

	public virtual Size Border3DSize => default(Size);

	public virtual Size BorderStaticSize => default(Size);

	public virtual Size BorderSize => default(Size);

	public virtual Size CaptionButtonSize => default(Size);

	public virtual int CaptionHeight => 0;

	public virtual Size DoubleClickSize => default(Size);

	public virtual int DoubleClickTime => 0;

	public virtual Size FrameBorderSize => default(Size);

	public virtual int HorizontalScrollBarHeight => 0;

	public virtual bool MenuAccessKeysUnderlined => false;

	public virtual Size MenuButtonSize => default(Size);

	public virtual Size MenuCheckSize => default(Size);

	public virtual Font MenuFont => null;

	public virtual int MenuHeight => 0;

	public virtual int MouseWheelScrollLines => 0;

	public virtual Size ToolWindowCaptionButtonSize => default(Size);

	public virtual int ToolWindowCaptionHeight => 0;

	public virtual int VerticalScrollBarWidth => 0;

	public virtual Font WindowBorderFont => null;

	public abstract bool DoubleBufferingSupported { get; }

	public abstract Size ButtonBaseDefaultSize { get; }

	public abstract Size GroupBoxDefaultSize { get; }

	public abstract Size HScrollBarDefaultSize { get; }

	public abstract bool ListViewHasHotHeaderStyle { get; }

	public abstract Size ListViewCheckBoxSize { get; }

	public abstract int ListViewDefaultColumnWidth { get; }

	public abstract int ListViewVerticalSpacing { get; }

	public abstract int ListViewEmptyColumnWidth { get; }

	public abstract int ListViewHorizontalSpacing { get; }

	public abstract Size ListViewDefaultSize { get; }

	public abstract int ListViewItemPaddingWidth { get; }

	public abstract int ListViewTileWidthFactor { get; }

	public abstract int ListViewTileHeightFactor { get; }

	public abstract Size PanelDefaultSize { get; }

	public abstract Size PictureBoxDefaultSize { get; }

	public abstract int ScrollBarButtonSize { get; }

	public abstract bool ScrollBarHasHotElementStyles { get; }

	public abstract bool ScrollBarHasPressedThumbStyle { get; }

	public abstract bool ScrollBarHasHoverArrowButtonStyle { get; }

	public abstract int ToolBarGripWidth { get; }

	public abstract int ToolBarImageGripWidth { get; }

	public abstract int ToolBarSeparatorWidth { get; }

	public abstract int ToolBarDropDownWidth { get; }

	public abstract int ToolBarDropDownArrowWidth { get; }

	public abstract int ToolBarDropDownArrowHeight { get; }

	public abstract Size ToolBarDefaultSize { get; }

	public abstract bool ToolBarHasHotCheckedElementStyles { get; }

	public abstract bool ToolTipTransparentBackground { get; }

	public abstract Size VScrollBarDefaultSize { get; }

	private void SetSystemColors(KnownColor kc, Color value)
	{
	}

	public int Clamp(int value, int lower, int upper)
	{
		return 0;
	}

	[MonoInternalNote("Figure out where to point for My Network Places")]
	public virtual string Places(UIIcon index)
	{
		return null;
	}

	private Image GetSizedResourceImage(string name, int width)
	{
		return null;
	}

	public virtual Image Images(UIIcon index, int size)
	{
		return null;
	}

	public abstract void ResetDefaults();

	public abstract Size CalculateButtonAutoSize(Button button);

	public abstract void CalculateButtonTextAndImageLayout(ButtonBase b, out Rectangle textRectangle, out Rectangle imageRectangle);

	public abstract void DrawButton(Graphics g, Button b, Rectangle textBounds, Rectangle imageBounds, Rectangle clipRectangle);

	public abstract void DrawFlatButton(Graphics g, ButtonBase b, Rectangle textBounds, Rectangle imageBounds, Rectangle clipRectangle);

	public abstract void DrawPopupButton(Graphics g, Button b, Rectangle textBounds, Rectangle imageBounds, Rectangle clipRectangle);

	public abstract void DrawButtonBase(Graphics dc, Rectangle clip_area, ButtonBase button);

	public abstract Size CalculateCheckBoxAutoSize(CheckBox checkBox);

	public abstract void CalculateCheckBoxTextAndImageLayout(ButtonBase b, Point offset, out Rectangle glyphArea, out Rectangle textRectangle, out Rectangle imageRectangle);

	public abstract void DrawCheckBox(Graphics g, CheckBox cb, Rectangle glyphArea, Rectangle textBounds, Rectangle imageBounds, Rectangle clipRectangle);

	public abstract void DrawCheckBox(Graphics dc, Rectangle clip_area, CheckBox checkbox);

	public abstract void DrawComboBoxItem(ComboBox ctrl, DrawItemEventArgs e);

	public abstract void DrawFlatStyleComboButton(Graphics graphics, Rectangle rectangle, ButtonState state);

	public abstract void ComboBoxDrawNormalDropDownButton(ComboBox comboBox, Graphics g, Rectangle clippingArea, Rectangle area, ButtonState state);

	public abstract bool ComboBoxNormalDropDownButtonHasTransparentBackground(ComboBox comboBox, ButtonState state);

	public abstract bool ComboBoxDropDownButtonHasHotElementStyle(ComboBox comboBox);

	public abstract void ComboBoxDrawBackground(ComboBox comboBox, Graphics g, Rectangle clippingArea, FlatStyle style);

	public abstract bool CombBoxBackgroundHasHotElementStyle(ComboBox comboBox);

	public abstract void DrawGroupBox(Graphics dc, Rectangle clip_area, GroupBox box);

	public abstract void DrawListViewItems(Graphics dc, Rectangle clip_rectangle, ListView control);

	public abstract void DrawListViewHeader(Graphics dc, Rectangle clip_rectangle, ListView control);

	public abstract void DrawListViewHeaderDragDetails(Graphics dc, ListView control, ColumnHeader drag_column, int target_x);

	public abstract int ListViewGetHeaderHeight(ListView listView, Font font);

	public abstract void CalcItemSize(Graphics dc, MenuItem item, int y, int x, bool menuBar);

	public abstract void CalcPopupMenuSize(Graphics dc, Menu menu);

	public abstract int CalcMenuBarSize(Graphics dc, Menu menu, int width);

	public abstract void DrawMenuBar(Graphics dc, Menu menu, Rectangle rect);

	public abstract void DrawMenuItem(MenuItem item, DrawItemEventArgs e);

	public abstract void DrawPopupMenu(Graphics dc, Menu menu, Rectangle cliparea, Rectangle rect);

	public abstract void DrawPictureBox(Graphics dc, Rectangle clip, PictureBox pb);

	public abstract void DrawScrollBar(Graphics dc, Rectangle clip_rectangle, ScrollBar bar);

	public abstract void TextBoxBaseFillBackground(TextBoxBase textBoxBase, Graphics g, Rectangle clippingArea);

	public abstract bool TextBoxBaseHandleWmNcPaint(TextBoxBase textBoxBase, ref Message m);

	public abstract bool TextBoxBaseShouldPaintBackground(TextBoxBase textBoxBase);

	public abstract void DrawToolBar(Graphics dc, Rectangle clip_rectangle, ToolBar control);

	public abstract bool ToolBarHasHotElementStyles(ToolBar toolBar);

	public abstract void DrawToolTip(Graphics dc, Rectangle clip_rectangle, ToolTip.ToolTipWindow control);

	public abstract Size ToolTipSize(ToolTip.ToolTipWindow tt, string text);

	public abstract void TreeViewDrawNodePlusMinus(TreeView treeView, TreeNode node, Graphics dc, int x, int middle);

	public abstract void DrawManagedWindowDecorations(Graphics dc, Rectangle clip, InternalWindowManager wm);

	public abstract int ManagedWindowTitleBarHeight(InternalWindowManager wm);

	public abstract int ManagedWindowBorderWidth(InternalWindowManager wm);

	public abstract Size ManagedWindowButtonSize(InternalWindowManager wm);

	public abstract void ManagedWindowSetButtonLocations(InternalWindowManager wm);

	public abstract Rectangle ManagedWindowGetTitleBarIconArea(InternalWindowManager wm);

	public abstract Size ManagedWindowGetMenuButtonSize(InternalWindowManager wm);

	public abstract bool ManagedWindowTitleButtonHasHotElementStyle(TitleButton button, Form form);

	public abstract void ManagedWindowDrawMenuButton(Graphics dc, TitleButton button, Rectangle clip, InternalWindowManager wm);

	public abstract void ManagedWindowOnSizeInitializedOrChanged(Form form);

	public abstract void CPDrawBorder(Graphics graphics, Rectangle bounds, Color leftColor, int leftWidth, ButtonBorderStyle leftStyle, Color topColor, int topWidth, ButtonBorderStyle topStyle, Color rightColor, int rightWidth, ButtonBorderStyle rightStyle, Color bottomColor, int bottomWidth, ButtonBorderStyle bottomStyle);

	public abstract void CPDrawBorder3D(Graphics graphics, Rectangle rectangle, Border3DStyle style, Border3DSide sides);

	public abstract void CPDrawBorder3D(Graphics graphics, Rectangle rectangle, Border3DStyle style, Border3DSide sides, Color control_color);

	public abstract void CPDrawButton(Graphics graphics, Rectangle rectangle, ButtonState state);

	public abstract void CPDrawCaptionButton(Graphics graphics, Rectangle rectangle, CaptionButton button, ButtonState state);

	public abstract void CPDrawCheckBox(Graphics graphics, Rectangle rectangle, ButtonState state);

	public abstract void CPDrawComboButton(Graphics graphics, Rectangle rectangle, ButtonState state);

	public abstract void CPDrawFocusRectangle(Graphics graphics, Rectangle rectangle, Color foreColor, Color backColor);

	public abstract void CPDrawImageDisabled(Graphics graphics, Image image, int x, int y, Color background);

	public abstract void CPDrawMenuGlyph(Graphics graphics, Rectangle rectangle, MenuGlyph glyph, Color color, Color backColor);

	public abstract void CPDrawMixedCheckBox(Graphics graphics, Rectangle rectangle, ButtonState state);

	public abstract void CPDrawScrollButton(Graphics graphics, Rectangle rectangle, ScrollButton button, ButtonState state);

	public abstract void CPDrawSizeGrip(Graphics graphics, Color backColor, Rectangle bounds);

	public abstract void CPDrawStringDisabled(Graphics graphics, string s, Font font, Color color, RectangleF layoutRectangle, StringFormat format);
}
