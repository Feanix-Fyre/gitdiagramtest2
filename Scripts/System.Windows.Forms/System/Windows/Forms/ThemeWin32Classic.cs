using System.Drawing;
using System.Drawing.Imaging;

namespace System.Windows.Forms;

internal class ThemeWin32Classic : Theme
{
	private enum VerticalAlignment
	{
		Top = 0,
		Center = 1,
		Bottom = 2
	}

	protected static readonly Color arrow_color;

	protected static readonly Color pen_ticks_color;

	protected static StringFormat string_format_menu_text;

	protected static StringFormat string_format_menu_shortcut;

	protected static StringFormat string_format_menu_menubar_text;

	private static ImageAttributes imagedisabled_attributes;

	public override bool DoubleBufferingSupported => false;

	public override int HorizontalScrollBarHeight => 0;

	public override int VerticalScrollBarWidth => 0;

	public override Size ButtonBaseDefaultSize => default(Size);

	public override Size GroupBoxDefaultSize => default(Size);

	public override Size HScrollBarDefaultSize => default(Size);

	public override bool ListViewHasHotHeaderStyle => false;

	public override Size ListViewCheckBoxSize => default(Size);

	public override int ListViewDefaultColumnWidth => 0;

	public override int ListViewVerticalSpacing => 0;

	public override int ListViewEmptyColumnWidth => 0;

	public override int ListViewHorizontalSpacing => 0;

	public override int ListViewItemPaddingWidth => 0;

	public override Size ListViewDefaultSize => default(Size);

	public int ListViewGroupLineWidth => 0;

	public override int ListViewTileWidthFactor => 0;

	public override int ListViewTileHeightFactor => 0;

	public override Size PanelDefaultSize => default(Size);

	public override Size PictureBoxDefaultSize => default(Size);

	public override int ScrollBarButtonSize => 0;

	public override bool ScrollBarHasHotElementStyles => false;

	public override bool ScrollBarHasPressedThumbStyle => false;

	public override bool ScrollBarHasHoverArrowButtonStyle => false;

	public override int ToolBarGripWidth => 0;

	public override int ToolBarImageGripWidth => 0;

	public override int ToolBarSeparatorWidth => 0;

	public override int ToolBarDropDownWidth => 0;

	public override int ToolBarDropDownArrowWidth => 0;

	public override int ToolBarDropDownArrowHeight => 0;

	public override Size ToolBarDefaultSize => default(Size);

	public override bool ToolBarHasHotCheckedElementStyles => false;

	public override bool ToolTipTransparentBackground => false;

	public override Size VScrollBarDefaultSize => default(Size);

	public override void ResetDefaults()
	{
	}

	protected Brush GetControlBackBrush(Color c)
	{
		return null;
	}

	protected Brush GetControlForeBrush(Color c)
	{
		return null;
	}

	public override void DrawButton(Graphics g, Button b, Rectangle textBounds, Rectangle imageBounds, Rectangle clipRectangle)
	{
	}

	public virtual void DrawButtonBackground(Graphics g, Button button, Rectangle clipArea)
	{
	}

	public virtual void DrawButtonFocus(Graphics g, Button button)
	{
	}

	public virtual void DrawButtonImage(Graphics g, ButtonBase button, Rectangle imageBounds)
	{
	}

	public virtual void DrawButtonText(Graphics g, ButtonBase button, Rectangle textBounds)
	{
	}

	public override void DrawFlatButton(Graphics g, ButtonBase b, Rectangle textBounds, Rectangle imageBounds, Rectangle clipRectangle)
	{
	}

	public virtual void DrawFlatButtonBackground(Graphics g, ButtonBase button, Rectangle clipArea)
	{
	}

	public virtual void DrawFlatButtonFocus(Graphics g, ButtonBase button)
	{
	}

	public virtual void DrawFlatButtonImage(Graphics g, ButtonBase button, Rectangle imageBounds)
	{
	}

	public virtual void DrawFlatButtonText(Graphics g, ButtonBase button, Rectangle textBounds)
	{
	}

	public override void DrawPopupButton(Graphics g, Button b, Rectangle textBounds, Rectangle imageBounds, Rectangle clipRectangle)
	{
	}

	public virtual void DrawPopupButtonBackground(Graphics g, Button button, Rectangle clipArea)
	{
	}

	public virtual void DrawPopupButtonFocus(Graphics g, Button button)
	{
	}

	public virtual void DrawPopupButtonImage(Graphics g, Button button, Rectangle imageBounds)
	{
	}

	public virtual void DrawPopupButtonText(Graphics g, Button button, Rectangle textBounds)
	{
	}

	public override Size CalculateButtonAutoSize(Button button)
	{
		return default(Size);
	}

	public override void CalculateButtonTextAndImageLayout(ButtonBase button, out Rectangle textRectangle, out Rectangle imageRectangle)
	{
		textRectangle = default(Rectangle);
		imageRectangle = default(Rectangle);
	}

	private void LayoutTextBeforeOrAfterImage(Rectangle totalArea, bool textFirst, Size textSize, Size imageSize, ContentAlignment textAlign, ContentAlignment imageAlign, out Rectangle textRect, out Rectangle imageRect)
	{
		textRect = default(Rectangle);
		imageRect = default(Rectangle);
	}

	private void LayoutTextAboveOrBelowImage(Rectangle totalArea, bool textFirst, Size textSize, Size imageSize, ContentAlignment textAlign, ContentAlignment imageAlign, out Rectangle textRect, out Rectangle imageRect)
	{
		textRect = default(Rectangle);
		imageRect = default(Rectangle);
	}

	private HorizontalAlignment GetHorizontalAlignment(ContentAlignment align)
	{
		return default(HorizontalAlignment);
	}

	private VerticalAlignment GetVerticalAlignment(ContentAlignment align)
	{
		return default(VerticalAlignment);
	}

	internal Rectangle AlignInRectangle(Rectangle outer, Size inner, ContentAlignment align)
	{
		return default(Rectangle);
	}

	public override void DrawButtonBase(Graphics dc, Rectangle clip_area, ButtonBase button)
	{
	}

	protected static bool ShouldPaintFocusRectagle(ButtonBase button)
	{
		return false;
	}

	protected virtual void ButtonBase_DrawButton(ButtonBase button, Graphics dc)
	{
	}

	private void Internal_DrawButton(Graphics dc, Rectangle rect, int state, CPColor cpcolor, bool is_ColorControl, Color backcolor)
	{
	}

	protected virtual void ButtonBase_DrawImage(ButtonBase button, Graphics dc)
	{
	}

	protected virtual void ButtonBase_DrawFocus(ButtonBase button, Graphics dc)
	{
	}

	protected virtual void ButtonBase_DrawText(ButtonBase button, Graphics dc)
	{
	}

	public override void DrawCheckBox(Graphics g, CheckBox cb, Rectangle glyphArea, Rectangle textBounds, Rectangle imageBounds, Rectangle clipRectangle)
	{
	}

	public virtual void DrawCheckBoxGlyph(Graphics g, CheckBox cb, Rectangle glyphArea)
	{
	}

	public virtual void DrawCheckBoxFocus(Graphics g, CheckBox cb, Rectangle focusArea)
	{
	}

	public virtual void DrawCheckBoxImage(Graphics g, CheckBox cb, Rectangle imageBounds)
	{
	}

	public virtual void DrawCheckBoxText(Graphics g, CheckBox cb, Rectangle textBounds)
	{
	}

	public override void CalculateCheckBoxTextAndImageLayout(ButtonBase button, Point p, out Rectangle glyphArea, out Rectangle textRectangle, out Rectangle imageRectangle)
	{
		glyphArea = default(Rectangle);
		textRectangle = default(Rectangle);
		imageRectangle = default(Rectangle);
	}

	public override Size CalculateCheckBoxAutoSize(CheckBox checkBox)
	{
		return default(Size);
	}

	public override void DrawCheckBox(Graphics dc, Rectangle clip_area, CheckBox checkbox)
	{
	}

	protected virtual void CheckBox_DrawCheckBox(Graphics dc, CheckBox checkbox, ButtonState state, Rectangle checkbox_rectangle)
	{
	}

	protected virtual void CheckBox_DrawText(CheckBox checkbox, Rectangle text_rectangle, Graphics dc, StringFormat text_format)
	{
	}

	protected virtual void CheckBox_DrawFocus(CheckBox checkbox, Graphics dc, Rectangle text_rectangle)
	{
	}

	protected virtual void DrawFlatStyleCheckBox(Graphics graphics, Rectangle rectangle, CheckBox checkbox)
	{
	}

	private void DrawCheckBox_and_RadioButtonText(ButtonBase button_base, Rectangle text_rectangle, Graphics dc, StringFormat text_format, Appearance appearance, bool ischecked)
	{
	}

	public override void DrawComboBoxItem(ComboBox ctrl, DrawItemEventArgs e)
	{
	}

	public override void DrawFlatStyleComboButton(Graphics graphics, Rectangle rectangle, ButtonState state)
	{
	}

	public override void ComboBoxDrawNormalDropDownButton(ComboBox comboBox, Graphics g, Rectangle clippingArea, Rectangle area, ButtonState state)
	{
	}

	public override bool ComboBoxNormalDropDownButtonHasTransparentBackground(ComboBox comboBox, ButtonState state)
	{
		return false;
	}

	public override bool ComboBoxDropDownButtonHasHotElementStyle(ComboBox comboBox)
	{
		return false;
	}

	public override void ComboBoxDrawBackground(ComboBox comboBox, Graphics g, Rectangle clippingArea, FlatStyle style)
	{
	}

	public override bool CombBoxBackgroundHasHotElementStyle(ComboBox comboBox)
	{
		return false;
	}

	public override void DrawGroupBox(Graphics dc, Rectangle area, GroupBox box)
	{
	}

	public override void DrawListViewItems(Graphics dc, Rectangle clip, ListView control)
	{
	}

	public override void DrawListViewHeader(Graphics dc, Rectangle clip, ListView control)
	{
	}

	protected virtual void ListViewDrawColumnHeaderBackground(ListView listView, ColumnHeader columnHeader, Graphics g, Rectangle area, Rectangle clippingArea)
	{
	}

	protected virtual void ListViewDrawUnusedHeaderBackground(ListView listView, Graphics g, Rectangle area, Rectangle clippingArea)
	{
	}

	public override void DrawListViewHeaderDragDetails(Graphics dc, ListView view, ColumnHeader col, int target_x)
	{
	}

	protected virtual bool DrawListViewColumnHeaderOwnerDraw(Graphics dc, ListView control, ColumnHeader column, Rectangle bounds)
	{
		return false;
	}

	protected virtual bool DrawListViewItemOwnerDraw(Graphics dc, ListViewItem item, int index)
	{
		return false;
	}

	protected virtual void DrawListViewItem(Graphics dc, ListView control, ListViewItem item)
	{
	}

	protected virtual void DrawListViewSubItems(Graphics dc, ListView control, ListViewItem item)
	{
	}

	protected virtual void DrawListViewSubItem(Graphics dc, ListView control, ListViewItem item, int index)
	{
	}

	protected virtual bool DrawListViewSubItemOwnerDraw(Graphics dc, ListViewItem item, ListViewItemStates state, int index)
	{
		return false;
	}

	protected virtual void DrawListViewGroupHeader(Graphics dc, ListView control, ListViewGroup group)
	{
	}

	public override int ListViewGetHeaderHeight(ListView listView, Font font)
	{
		return 0;
	}

	private static int ListViewGetHeaderHeight(Font font)
	{
		return 0;
	}

	public static int ListViewGetHeaderHeight()
	{
		return 0;
	}

	public override void CalcItemSize(Graphics dc, MenuItem item, int y, int x, bool menuBar)
	{
	}

	public override int CalcMenuBarSize(Graphics dc, Menu menu, int width)
	{
		return 0;
	}

	public override void CalcPopupMenuSize(Graphics dc, Menu menu)
	{
	}

	public override void DrawMenuBar(Graphics dc, Menu menu, Rectangle rect)
	{
	}

	protected Bitmap CreateGlyphBitmap(Size size, MenuGlyph glyph, Color color)
	{
		return null;
	}

	public override void DrawMenuItem(MenuItem item, DrawItemEventArgs e)
	{
	}

	public override void DrawPopupMenu(Graphics dc, Menu menu, Rectangle cliparea, Rectangle rect)
	{
	}

	public override void DrawPictureBox(Graphics dc, Rectangle clip, PictureBox pb)
	{
	}

	public override void DrawScrollBar(Graphics dc, Rectangle clip, ScrollBar bar)
	{
	}

	protected virtual void ScrollBar_DrawThumb(ScrollBar bar, Rectangle thumb_pos, Rectangle clip, Graphics dc)
	{
	}

	public override void TextBoxBaseFillBackground(TextBoxBase textBoxBase, Graphics g, Rectangle clippingArea)
	{
	}

	public override bool TextBoxBaseHandleWmNcPaint(TextBoxBase textBoxBase, ref Message m)
	{
		return false;
	}

	public override bool TextBoxBaseShouldPaintBackground(TextBoxBase textBoxBase)
	{
		return false;
	}

	public override void DrawToolBar(Graphics dc, Rectangle clip_rectangle, ToolBar control)
	{
	}

	protected virtual void DrawToolBarButton(Graphics dc, ToolBar control, ToolBarItem item, StringFormat format)
	{
	}

	protected virtual void DrawToolBarButtonBorder(Graphics dc, ToolBarItem item, bool is_flat)
	{
	}

	protected virtual void DrawToolBarSeparator(Graphics dc, ToolBarItem item)
	{
	}

	protected virtual void DrawToolBarToggleButtonBackground(Graphics dc, ToolBarItem item)
	{
	}

	protected virtual void DrawToolBarDropDownArrow(Graphics dc, ToolBarItem item, bool is_flat)
	{
	}

	protected virtual void DrawToolBarButtonContents(Graphics dc, ToolBar control, ToolBarItem item, StringFormat format)
	{
	}

	public override bool ToolBarHasHotElementStyles(ToolBar toolBar)
	{
		return false;
	}

	public override void DrawToolTip(Graphics dc, Rectangle clip_rectangle, ToolTip.ToolTipWindow control)
	{
	}

	protected virtual void ToolTipDrawBackground(Graphics dc, Rectangle clip_rectangle, ToolTip.ToolTipWindow control)
	{
	}

	public override Size ToolTipSize(ToolTip.ToolTipWindow tt, string text)
	{
		return default(Size);
	}

	public static Size TrackBarGetThumbSize()
	{
		return default(Size);
	}

	public override void TreeViewDrawNodePlusMinus(TreeView treeView, TreeNode node, Graphics dc, int x, int middle)
	{
	}

	public override int ManagedWindowTitleBarHeight(InternalWindowManager wm)
	{
		return 0;
	}

	public override int ManagedWindowBorderWidth(InternalWindowManager wm)
	{
		return 0;
	}

	public override void ManagedWindowSetButtonLocations(InternalWindowManager wm)
	{
	}

	protected virtual Rectangle ManagedWindowDrawTitleBarAndBorders(Graphics dc, Rectangle clip, InternalWindowManager wm)
	{
		return default(Rectangle);
	}

	public override void DrawManagedWindowDecorations(Graphics dc, Rectangle clip, InternalWindowManager wm)
	{
	}

	public override Size ManagedWindowButtonSize(InternalWindowManager wm)
	{
		return default(Size);
	}

	private int DrawTitleButton(Graphics dc, TitleButton button, Rectangle clip, Form form)
	{
		return 0;
	}

	protected virtual void ManagedWindowDrawTitleButton(Graphics dc, TitleButton button, Rectangle clip, Form form)
	{
	}

	public override Rectangle ManagedWindowGetTitleBarIconArea(InternalWindowManager wm)
	{
		return default(Rectangle);
	}

	public override Size ManagedWindowGetMenuButtonSize(InternalWindowManager wm)
	{
		return default(Size);
	}

	public override bool ManagedWindowTitleButtonHasHotElementStyle(TitleButton button, Form form)
	{
		return false;
	}

	public override void ManagedWindowDrawMenuButton(Graphics dc, TitleButton button, Rectangle clip, InternalWindowManager wm)
	{
	}

	public override void ManagedWindowOnSizeInitializedOrChanged(Form form)
	{
	}

	public override void CPDrawBorder(Graphics graphics, Rectangle bounds, Color leftColor, int leftWidth, ButtonBorderStyle leftStyle, Color topColor, int topWidth, ButtonBorderStyle topStyle, Color rightColor, int rightWidth, ButtonBorderStyle rightStyle, Color bottomColor, int bottomWidth, ButtonBorderStyle bottomStyle)
	{
	}

	public override void CPDrawBorder3D(Graphics graphics, Rectangle rectangle, Border3DStyle style, Border3DSide sides)
	{
	}

	public override void CPDrawBorder3D(Graphics graphics, Rectangle rectangle, Border3DStyle style, Border3DSide sides, Color control_color)
	{
	}

	public override void CPDrawButton(Graphics dc, Rectangle rectangle, ButtonState state)
	{
	}

	private void CPDrawButtonInternal(Graphics dc, Rectangle rectangle, ButtonState state, Pen DarkPen, Pen NormalPen, Pen LightPen)
	{
	}

	public override void CPDrawCaptionButton(Graphics graphics, Rectangle rectangle, CaptionButton button, ButtonState state)
	{
	}

	public override void CPDrawCheckBox(Graphics dc, Rectangle rectangle, ButtonState state)
	{
	}

	public override void CPDrawComboButton(Graphics graphics, Rectangle rectangle, ButtonState state)
	{
	}

	public virtual void DrawInnerFocusRectangle(Graphics graphics, Rectangle rectangle, Color backColor)
	{
	}

	public override void CPDrawFocusRectangle(Graphics graphics, Rectangle rectangle, Color foreColor, Color backColor)
	{
	}

	public override void CPDrawImageDisabled(Graphics graphics, Image image, int x, int y, Color background)
	{
	}

	public override void CPDrawMenuGlyph(Graphics graphics, Rectangle rectangle, MenuGlyph glyph, Color color, Color backColor)
	{
	}

	[MonoInternalNote("Does not respect Mixed")]
	public override void CPDrawMixedCheckBox(Graphics graphics, Rectangle rectangle, ButtonState state)
	{
	}

	public override void CPDrawScrollButton(Graphics dc, Rectangle area, ScrollButton type, ButtonState state)
	{
	}

	public override void CPDrawSizeGrip(Graphics dc, Color backColor, Rectangle bounds)
	{
	}

	private void DrawStringDisabled20(Graphics g, string s, Font font, Rectangle layoutRectangle, Color color, TextFormatFlags flags, bool useDrawString)
	{
	}

	public override void CPDrawStringDisabled(Graphics dc, string s, Font font, Color color, RectangleF layoutRectangle, StringFormat format)
	{
	}

	private static void DrawBorderInternal(Graphics graphics, int startX, int startY, int endX, int endY, int width, Color color, ButtonBorderStyle style, Border3DSide side)
	{
	}

	private static void DrawBorderInternal(Graphics graphics, float startX, float startY, float endX, float endY, int width, Color color, ButtonBorderStyle style, Border3DSide side)
	{
	}

	private void DrawCaptionHelper(Graphics graphics, Color color, Pen pen, int lineWidth, int shift, Rectangle captionRect, CaptionButton button)
	{
	}

	public void DrawScrollButtonPrimitive(Graphics dc, Rectangle area, ButtonState state)
	{
	}
}
