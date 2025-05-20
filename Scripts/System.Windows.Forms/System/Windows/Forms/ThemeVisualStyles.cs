using System.Drawing;
using System.Windows.Forms.VisualStyles;

namespace System.Windows.Forms;

internal class ThemeVisualStyles : ThemeWin32Classic
{
	private static bool render_client_areas;

	private static bool render_non_client_areas;

	private static bool ScrollBarHasHoverArrowButtonStyleVisualStyles;

	private static Control control;

	public static bool RenderClientAreas => false;

	public override bool ListViewHasHotHeaderStyle => false;

	public override bool ScrollBarHasHotElementStyles => false;

	public override bool ScrollBarHasPressedThumbStyle => false;

	public override bool ScrollBarHasHoverArrowButtonStyle => false;

	private static bool ScrollBarAreElementsDefined => false;

	public override bool ToolBarHasHotCheckedElementStyles => false;

	public override bool ToolTipTransparentBackground => false;

	public override void ResetDefaults()
	{
	}

	private static void Update()
	{
	}

	public override void DrawButtonBase(Graphics dc, Rectangle clip_area, ButtonBase button)
	{
	}

	private static PushButtonState GetPushButtonState(ButtonBase button)
	{
		return default(PushButtonState);
	}

	public override void DrawButtonBackground(Graphics g, Button button, Rectangle clipArea)
	{
	}

	protected override void CheckBox_DrawCheckBox(Graphics dc, CheckBox checkbox, ButtonState state, Rectangle checkbox_rectangle)
	{
	}

	private static CheckBoxState GetCheckBoxState(CheckBox checkBox)
	{
		return default(CheckBoxState);
	}

	private static VisualStyleElement ComboBoxGetVisualStyleElement(ComboBox comboBox, ButtonState state)
	{
		return null;
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

	private static bool ComboBoxShouldPaintBackground(ComboBox comboBox)
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

	public override void CPDrawButton(Graphics dc, Rectangle rectangle, ButtonState state)
	{
	}

	public override void CPDrawCaptionButton(Graphics graphics, Rectangle rectangle, CaptionButton button, ButtonState state)
	{
	}

	private static VisualStyleElement GetCaptionButtonVisualStyleElement(CaptionButton button, ButtonState state)
	{
		return null;
	}

	public override void CPDrawCheckBox(Graphics dc, Rectangle rectangle, ButtonState state)
	{
	}

	public override void CPDrawComboButton(Graphics graphics, Rectangle rectangle, ButtonState state)
	{
	}

	public override void CPDrawMixedCheckBox(Graphics dc, Rectangle rectangle, ButtonState state)
	{
	}

	public override void CPDrawScrollButton(Graphics dc, Rectangle area, ScrollButton type, ButtonState state)
	{
	}

	private static VisualStyleElement GetScrollButtonVisualStyleElement(ScrollButton type, ButtonState state)
	{
		return null;
	}

	private static bool IsDisabled(ButtonState state)
	{
		return false;
	}

	private static bool IsPressed(ButtonState state)
	{
		return false;
	}

	protected override void ListViewDrawColumnHeaderBackground(ListView listView, ColumnHeader columnHeader, Graphics g, Rectangle area, Rectangle clippingArea)
	{
	}

	protected override void ListViewDrawUnusedHeaderBackground(ListView listView, Graphics g, Rectangle area, Rectangle clippingArea)
	{
	}

	public override int ListViewGetHeaderHeight(ListView listView, Font font)
	{
		return 0;
	}

	public override void DrawGroupBox(Graphics dc, Rectangle area, GroupBox box)
	{
	}

	private Rectangle ManagedWindowGetTitleBarRectangle(InternalWindowManager wm)
	{
		return default(Rectangle);
	}

	private Region ManagedWindowGetWindowRegion(Form form)
	{
		return null;
	}

	public override void ManagedWindowOnSizeInitializedOrChanged(Form form)
	{
	}

	protected override Rectangle ManagedWindowDrawTitleBarAndBorders(Graphics dc, Rectangle clip, InternalWindowManager wm)
	{
		return default(Rectangle);
	}

	private static FormWindowState ManagedWindowGetWindowState(InternalWindowManager wm)
	{
		return default(FormWindowState);
	}

	private static bool ManagedWindowIsDisabled(InternalWindowManager wm)
	{
		return false;
	}

	private static bool ManagedWindowIsActive(InternalWindowManager wm)
	{
		return false;
	}

	private static VisualStyleElement ManagedWindowGetTitleBarVisualStyleElement(InternalWindowManager wm)
	{
		return null;
	}

	private static void ManagedWindowGetBorderVisualStyleElements(InternalWindowManager wm, out VisualStyleElement left, out VisualStyleElement right, out VisualStyleElement bottom)
	{
		left = null;
		right = null;
		bottom = null;
	}

	public override bool ManagedWindowTitleButtonHasHotElementStyle(TitleButton button, Form form)
	{
		return false;
	}

	private static bool ManagedWindowIsMaximizedMdiChild(Form form)
	{
		return false;
	}

	private static bool ManagedWindowTitleButtonIsDisabled(TitleButton button, InternalWindowManager wm)
	{
		return false;
	}

	private static bool ManagedWindowTitleButtonIsPressed(TitleButton button)
	{
		return false;
	}

	private static VisualStyleElement ManagedWindowGetTitleButtonVisualStyleElement(TitleButton button, Form form)
	{
		return null;
	}

	protected override void ManagedWindowDrawTitleButton(Graphics dc, TitleButton button, Rectangle clip, Form form)
	{
	}

	public override Size ManagedWindowButtonSize(InternalWindowManager wm)
	{
		return default(Size);
	}

	public override void ManagedWindowDrawMenuButton(Graphics dc, TitleButton button, Rectangle clip, InternalWindowManager wm)
	{
	}

	private static VisualStyleElement ManagedWindowGetMenuButtonVisualStyleElement(TitleButton button, InternalWindowManager wm)
	{
		return null;
	}

	public override void DrawScrollBar(Graphics dc, Rectangle clip, ScrollBar bar)
	{
	}

	private static bool TextBoxBaseShouldPaint(TextBoxBase textBoxBase)
	{
		return false;
	}

	private static VisualStyleElement TextBoxBaseGetVisualStyleElement(TextBoxBase textBoxBase)
	{
		return null;
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

	private static bool ToolBarIsDisabled(ToolBarItem item)
	{
		return false;
	}

	private static bool ToolBarIsPressed(ToolBarItem item)
	{
		return false;
	}

	private static bool ToolBarIsChecked(ToolBarItem item)
	{
		return false;
	}

	private static bool ToolBarIsHot(ToolBarItem item)
	{
		return false;
	}

	protected override void DrawToolBarButtonBorder(Graphics dc, ToolBarItem item, bool is_flat)
	{
	}

	private static VisualStyleElement ToolBarGetDropDownButtonVisualStyleElement(ToolBarItem item)
	{
		return null;
	}

	private static VisualStyleElement ToolBarGetButtonVisualStyleElement(ToolBarItem item)
	{
		return null;
	}

	protected override void DrawToolBarSeparator(Graphics dc, ToolBarItem item)
	{
	}

	private static VisualStyleElement ToolBarGetSeparatorVisualStyleElement(ToolBarItem toolBarItem)
	{
		return null;
	}

	protected override void DrawToolBarToggleButtonBackground(Graphics dc, ToolBarItem item)
	{
	}

	protected override void DrawToolBarDropDownArrow(Graphics dc, ToolBarItem item, bool is_flat)
	{
	}

	private static VisualStyleElement ToolBarGetDropDownArrowVisualStyleElement(ToolBarItem item)
	{
		return null;
	}

	public override bool ToolBarHasHotElementStyles(ToolBar toolBar)
	{
		return false;
	}

	protected override void ToolTipDrawBackground(Graphics dc, Rectangle clip_rectangle, ToolTip.ToolTipWindow control)
	{
	}

	[MonoInternalNote("Use the sizing information provided by the VisualStyles API.")]
	public override void TreeViewDrawNodePlusMinus(TreeView treeView, TreeNode node, Graphics dc, int x, int middle)
	{
	}

	private static IDeviceContext GetMeasurementDeviceContext()
	{
		return null;
	}

	private static void ReleaseMeasurementDeviceContext(IDeviceContext dc)
	{
	}
}
