using System.Collections;
using System.Drawing;
using System.Runtime.InteropServices;

namespace System.Windows.Forms.VisualStyles;

internal class GtkPlus
{
	private abstract class Painter
	{
		public virtual void AttachStyle(WidgetType widgetType, IntPtr drawable, GtkPlus gtkPlus)
		{
		}

		public abstract void Paint(IntPtr style, IntPtr window, GdkRectangle area, IntPtr widget, int x, int y, int width, int height, GtkPlus gtkPlus);
	}

	private enum TransparencyType
	{
		None = 0,
		Color = 1,
		Alpha = 2
	}

	private enum DeviceContextType
	{
		Unknown = 0,
		Graphics = 1,
		Native = 2
	}

	private class ButtonPainter : Painter
	{
		private bool @default;

		private GtkPlusState state;

		public void Configure(bool @default, GtkPlusState state)
		{
		}

		public override void Paint(IntPtr style, IntPtr window, GdkRectangle area, IntPtr widget, int x, int y, int width, int height, GtkPlus gtkPlus)
		{
		}
	}

	private abstract class ToggleButtonPainter : Painter
	{
		private GtkPlusState state;

		private GtkPlusToggleButtonValue value;

		protected abstract string Detail { get; }

		protected abstract ToggleButtonPaintFunction PaintFunction { get; }

		public void Configure(GtkPlusState state, GtkPlusToggleButtonValue value)
		{
		}

		public override void Paint(IntPtr style, IntPtr window, GdkRectangle area, IntPtr widget, int x, int y, int width, int height, GtkPlus gtkPlus)
		{
		}
	}

	private class CheckBoxPainter : ToggleButtonPainter
	{
		protected override string Detail => null;

		protected override ToggleButtonPaintFunction PaintFunction => null;
	}

	private class RadioButtonPainter : ToggleButtonPainter
	{
		protected override string Detail => null;

		protected override ToggleButtonPaintFunction PaintFunction => null;
	}

	private class ComboBoxDropDownButtonPainter : Painter
	{
		private GtkPlusState state;

		public void Configure(GtkPlusState state)
		{
		}

		public override void AttachStyle(WidgetType widgetType, IntPtr drawable, GtkPlus gtkPlus)
		{
		}

		public override void Paint(IntPtr style, IntPtr window, GdkRectangle area, IntPtr widget, int x, int y, int width, int height, GtkPlus gtkPlus)
		{
		}
	}

	private class ComboBoxBorderPainter : Painter
	{
		public override void Paint(IntPtr style, IntPtr window, GdkRectangle area, IntPtr widget, int x, int y, int width, int height, GtkPlus gtkPlus)
		{
		}
	}

	private class GroupBoxPainter : Painter
	{
		private GtkPlusState state;

		public void Configure(GtkPlusState state)
		{
		}

		public override void Paint(IntPtr style, IntPtr window, GdkRectangle area, IntPtr widget, int x, int y, int width, int height, GtkPlus gtkPlus)
		{
		}
	}

	private class HeaderPainter : Painter
	{
		private GtkPlusState state;

		public void Configure(GtkPlusState state)
		{
		}

		public override void AttachStyle(WidgetType widgetType, IntPtr drawable, GtkPlus gtkPlus)
		{
		}

		public override void Paint(IntPtr style, IntPtr window, GdkRectangle area, IntPtr widget, int x, int y, int width, int height, GtkPlus gtkPlus)
		{
		}
	}

	private class ProgressBarBarPainter : Painter
	{
		public override void Paint(IntPtr style, IntPtr window, GdkRectangle area, IntPtr widget, int x, int y, int width, int height, GtkPlus gtkPlus)
		{
		}
	}

	private class ProgressBarChunkPainter : Painter
	{
		public override void Paint(IntPtr style, IntPtr window, GdkRectangle area, IntPtr widget, int x, int y, int width, int height, GtkPlus gtkPlus)
		{
		}
	}

	private class ScrollBarArrowButtonPainter : Painter
	{
		private GtkPlusState state;

		private bool horizontal;

		private bool up_or_left;

		public void Configure(GtkPlusState state, bool horizontal, bool upOrLeft)
		{
		}

		public override void Paint(IntPtr style, IntPtr window, GdkRectangle area, IntPtr widget, int x, int y, int width, int height, GtkPlus gtkPlus)
		{
		}
	}

	private abstract class RangeThumbButtonPainter : Painter
	{
		private GtkPlusState state;

		private bool horizontal;

		protected bool Horizontal => false;

		protected abstract string Detail { get; }

		public void Configure(GtkPlusState state, bool horizontal)
		{
		}

		public override void Paint(IntPtr style, IntPtr window, GdkRectangle area, IntPtr widget, int x, int y, int width, int height, GtkPlus gtkPlus)
		{
		}
	}

	private class ScrollBarThumbButtonPainter : RangeThumbButtonPainter
	{
		protected override string Detail => null;
	}

	private class ScrollBarTrackPainter : Painter
	{
		private GtkPlusState state;

		private bool up_or_left;

		public void Configure(GtkPlusState state, bool upOrLeft)
		{
		}

		public override void Paint(IntPtr style, IntPtr window, GdkRectangle area, IntPtr widget, int x, int y, int width, int height, GtkPlus gtkPlus)
		{
		}
	}

	private class StatusBarGripperPainter : Painter
	{
		public override void Paint(IntPtr style, IntPtr window, GdkRectangle area, IntPtr widget, int x, int y, int width, int height, GtkPlus gtkPlus)
		{
		}
	}

	private class TabControlPanePainter : Painter
	{
		public override void Paint(IntPtr style, IntPtr window, GdkRectangle area, IntPtr widget, int x, int y, int width, int height, GtkPlus gtkPlus)
		{
		}
	}

	private class TabControlTabItemPainter : Painter
	{
		private GtkPlusState state;

		public void Configure(GtkPlusState state)
		{
		}

		public override void Paint(IntPtr style, IntPtr window, GdkRectangle area, IntPtr widget, int x, int y, int width, int height, GtkPlus gtkPlus)
		{
		}
	}

	private class TextBoxPainter : Painter
	{
		private GtkPlusState state;

		public void Configure(GtkPlusState state)
		{
		}

		public override void Paint(IntPtr style, IntPtr window, GdkRectangle area, IntPtr widget, int x, int y, int width, int height, GtkPlus gtkPlus)
		{
		}
	}

	private class ToolBarPainter : Painter
	{
		public override void Paint(IntPtr style, IntPtr window, GdkRectangle area, IntPtr widget, int x, int y, int width, int height, GtkPlus gtkPlus)
		{
		}
	}

	private class ToolBarButtonPainter : Painter
	{
		private GtkPlusState state;

		public void Configure(GtkPlusState state)
		{
		}

		public override void AttachStyle(WidgetType widgetType, IntPtr drawable, GtkPlus gtkPlus)
		{
		}

		public override void Paint(IntPtr style, IntPtr window, GdkRectangle area, IntPtr widget, int x, int y, int width, int height, GtkPlus gtkPlus)
		{
		}
	}

	private class ToolBarCheckedButtonPainter : Painter
	{
		public override void AttachStyle(WidgetType widgetType, IntPtr drawable, GtkPlus gtkPlus)
		{
		}

		public override void Paint(IntPtr style, IntPtr window, GdkRectangle area, IntPtr widget, int x, int y, int width, int height, GtkPlus gtkPlus)
		{
		}
	}

	private class TrackBarTrackPainter : Painter
	{
		public override void Paint(IntPtr style, IntPtr window, GdkRectangle area, IntPtr widget, int x, int y, int width, int height, GtkPlus gtkPlus)
		{
		}
	}

	private class TrackBarThumbPainter : RangeThumbButtonPainter
	{
		protected override string Detail => null;
	}

	private class TreeViewGlyphPainter : Painter
	{
		private bool closed;

		public void Configure(bool closed)
		{
		}

		public override void Paint(IntPtr style, IntPtr window, GdkRectangle area, IntPtr widget, int x, int y, int width, int height, GtkPlus gtkPlus)
		{
		}
	}

	private class UpDownPainter : Painter
	{
		private bool up;

		private GtkPlusState state;

		public void Configure(bool up, GtkPlusState state)
		{
		}

		public override void Paint(IntPtr style, IntPtr window, GdkRectangle area, IntPtr widget, int x, int y, int width, int height, GtkPlus gtkPlus)
		{
		}
	}

	private enum WidgetType
	{
		Button = 0,
		CheckBox = 1,
		ComboBox = 2,
		GroupBox = 3,
		ProgressBar = 4,
		RadioButton = 5,
		HScrollBar = 6,
		VScrollBar = 7,
		StatusBar = 8,
		TabControl = 9,
		TextBox = 10,
		ToolBar = 11,
		HorizontalTrackBar = 12,
		VerticalTrackBar = 13,
		TreeView = 14,
		UpDown = 15
	}

	private static class GetFirstChildWidgetOfType
	{
		private static IntPtr Type;

		private static IntPtr Result;

		private static ArrayList ContainersToSearch;

		public static IntPtr Get(IntPtr parent, IntPtr childType)
		{
			return (IntPtr)0;
		}

		private static void Callback(IntPtr widget, IntPtr data)
		{
		}
	}

	private struct GdkColor
	{
		public uint pixel;

		public ushort red;

		public ushort green;

		public ushort blue;

		public GdkColor(Color value)
		{
			pixel = 0u;
			red = 0;
			green = 0;
			blue = 0;
		}
	}

	internal struct GdkRectangle
	{
		public int x;

		public int y;

		public int width;

		public int height;

		public GdkRectangle(Rectangle value)
		{
			x = 0;
			y = 0;
			width = 0;
			height = 0;
		}
	}

	private enum GdkColorspace
	{
		GDK_COLORSPACE_RGB = 0
	}

	internal enum GtkShadowType
	{
		GTK_SHADOW_NONE = 0,
		GTK_SHADOW_IN = 1,
		GTK_SHADOW_OUT = 2,
		GTK_SHADOW_ETCHED_IN = 3,
		GTK_SHADOW_ETCHED_OUT = 4
	}

	private enum GtkStateType
	{
		GTK_STATE_NORMAL = 0,
		GTK_STATE_ACTIVE = 1,
		GTK_STATE_PRELIGHT = 2,
		GTK_STATE_SELECTED = 3,
		GTK_STATE_INSENSITIVE = 4
	}

	private enum GtkWindowType
	{
		GTK_WINDOW_TOPLEVEL = 0,
		GTK_WINDOW_POPUP = 1
	}

	private enum GtkArrowType
	{
		GTK_ARROW_UP = 0,
		GTK_ARROW_DOWN = 1,
		GTK_ARROW_LEFT = 2,
		GTK_ARROW_RIGHT = 3,
		GTK_ARROW_NONE = 4
	}

	private enum GtkOrientation
	{
		GTK_ORIENTATION_HORIZONTAL = 0,
		GTK_ORIENTATION_VERTICAL = 1
	}

	private enum GtkExpanderStyle
	{
		GTK_EXPANDER_COLLAPSED = 0,
		GTK_EXPANDER_SEMI_COLLAPSED = 1,
		GTK_EXPANDER_SEMI_EXPANDED = 2,
		GTK_EXPANDER_EXPANDED = 3
	}

	private enum GtkPositionType
	{
		GTK_POS_LEFT = 0,
		GTK_POS_RIGHT = 1,
		GTK_POS_TOP = 2,
		GTK_POS_BOTTOM = 3
	}

	private enum GtkWidgetFlags : uint
	{
		GTK_CAN_DEFAULT = 0x2000u
	}

	private enum GdkWindowEdge
	{
		GDK_WINDOW_EDGE_NORTH_WEST = 0,
		GDK_WINDOW_EDGE_NORTH = 1,
		GDK_WINDOW_EDGE_NORTH_EAST = 2,
		GDK_WINDOW_EDGE_WEST = 3,
		GDK_WINDOW_EDGE_EAST = 4,
		GDK_WINDOW_EDGE_SOUTH_WEST = 5,
		GDK_WINDOW_EDGE_SOUTH = 6,
		GDK_WINDOW_EDGE_SOUTH_EAST = 7
	}

	private struct GtkStyle
	{
		private GObject parent_instance;

		private GdkColor[] fg;

		private GdkColor[] bg;

		private GdkColor[] light;

		private GdkColor[] dark;

		private GdkColor[] mid;

		private GdkColor[] text;

		private GdkColor[] @base;

		private GdkColor[] text_aa;

		private GdkColor black;

		private GdkColor white;

		private IntPtr font_desc;

		public int xthickness;

		public int ythickness;
	}

	private struct GtkWidget
	{
		private GtkObject @object;

		private ushort private_flags;

		private byte state;

		private byte saved_state;

		private string name;

		private IntPtr style;

		private GtkRequisition requisition;

		public GdkRectangle allocation;

		private IntPtr window;

		private IntPtr parent;
	}

	private struct GtkObject
	{
		private GObject parent_instance;

		public uint flags;
	}

	private struct GtkRequisition
	{
		private int width;

		private int height;
	}

	private struct GtkMisc
	{
		private GtkWidget widget;

		public float xalign;

		public float yalign;

		public ushort xpad;

		public ushort ypad;
	}

	private struct GtkTreeViewColumn
	{
		private GtkObject parent;

		private IntPtr tree_view;

		public IntPtr button;
	}

	private struct GTypeInstance
	{
		private IntPtr g_class;
	}

	internal struct GObject
	{
		private GTypeInstance g_type_instance;

		private uint ref_count;

		private IntPtr qdata;
	}

	private delegate void ToggleButtonPaintFunction(IntPtr style, IntPtr window, GtkStateType state_type, GtkShadowType shadow_type, ref GdkRectangle area, IntPtr widget, string detail, int x, int y, int width, int height);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate void GtkCallback(IntPtr widget, IntPtr data);

	private static GtkPlus instance;

	private readonly int WidgetTypeCount;

	private readonly IntPtr[] widgets;

	private readonly IntPtr window;

	private readonly IntPtr @fixed;

	private readonly IntPtr[] styles;

	private readonly IntPtr combo_box_drop_down_toggle_button;

	private readonly IntPtr combo_box_drop_down_arrow;

	private IntPtr combo_box_drop_down_toggle_button_style;

	private IntPtr combo_box_drop_down_arrow_style;

	private readonly IntPtr tool_bar_button;

	private readonly IntPtr tool_bar_toggle_button;

	private IntPtr tool_bar_button_style;

	private IntPtr tool_bar_toggle_button_style;

	private readonly IntPtr tree_view_column;

	private readonly IntPtr tree_view_column_button;

	private IntPtr tree_view_column_button_style;

	private readonly ButtonPainter button_painter;

	private readonly CheckBoxPainter check_box_painter;

	private readonly RadioButtonPainter radio_button_painter;

	private readonly ComboBoxDropDownButtonPainter combo_box_drop_down_button_painter;

	private readonly ComboBoxBorderPainter combo_box_border_painter;

	private readonly GroupBoxPainter group_box_painter;

	private readonly HeaderPainter header_painter;

	private readonly ProgressBarBarPainter progress_bar_bar_painter;

	private readonly ProgressBarChunkPainter progress_bar_chunk_painter;

	private readonly ScrollBarArrowButtonPainter scroll_bar_arrow_button_painter;

	private readonly ScrollBarThumbButtonPainter scroll_bar_thumb_button_painter;

	private readonly ScrollBarTrackPainter scroll_bar_track_painter;

	private readonly StatusBarGripperPainter status_bar_gripper_painter;

	private readonly TabControlPanePainter tab_control_pane_painter;

	private readonly TabControlTabItemPainter tab_control_tab_item_painter;

	private readonly TextBoxPainter text_box_painter;

	private readonly ToolBarPainter tool_bar_painter;

	private readonly ToolBarButtonPainter tool_bar_button_painter;

	private readonly ToolBarCheckedButtonPainter tool_bar_checked_button_painter;

	private readonly TrackBarTrackPainter track_bar_track_painter;

	private readonly TrackBarThumbPainter track_bar_thumb_painter;

	private readonly TreeViewGlyphPainter tree_view_glyph_painter;

	private readonly UpDownPainter up_down_painter;

	public static GtkPlus Instance => null;

	protected GtkPlus()
	{
	}

	public static bool Initialize()
	{
		return false;
	}

	~GtkPlus()
	{
	}

	public void ButtonPaint(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea, bool @default, GtkPlusState state)
	{
	}

	public void CheckBoxPaint(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea, GtkPlusState state, GtkPlusToggleButtonValue value)
	{
	}

	private Size GetGtkCheckButtonIndicatorSize(WidgetType widgetType)
	{
		return default(Size);
	}

	public Size CheckBoxGetSize()
	{
		return default(Size);
	}

	public void ComboBoxPaintDropDownButton(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea, GtkPlusState state)
	{
	}

	public void ComboBoxPaintBorder(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea)
	{
	}

	public void GroupBoxPaint(IDeviceContext dc, Rectangle bounds, Rectangle excludedArea, GtkPlusState state)
	{
	}

	public void HeaderPaint(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea, GtkPlusState state)
	{
	}

	public void ProgressBarPaintBar(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea)
	{
	}

	public void ProgressBarPaintChunk(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea)
	{
	}

	public void RadioButtonPaint(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea, GtkPlusState state, GtkPlusToggleButtonValue value)
	{
	}

	public Size RadioButtonGetSize()
	{
		return default(Size);
	}

	public void ScrollBarPaintArrowButton(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea, GtkPlusState state, bool horizontal, bool upOrLeft)
	{
	}

	public void ScrollBarPaintThumbButton(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea, GtkPlusState state, bool horizontal)
	{
	}

	public void ScrollBarPaintTrack(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea, GtkPlusState state, bool horizontal, bool upOrLeft)
	{
	}

	public void StatusBarPaintGripper(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea)
	{
	}

	public void TabControlPaintPane(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea)
	{
	}

	public void TabControlPaintTabItem(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea, GtkPlusState state)
	{
	}

	public void TextBoxPaint(IDeviceContext dc, Rectangle bounds, Rectangle excludedArea, GtkPlusState state)
	{
	}

	public void ToolBarPaint(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea)
	{
	}

	public void ToolBarPaintButton(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea, GtkPlusState state)
	{
	}

	public void ToolBarPaintCheckedButton(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea)
	{
	}

	public void TrackBarPaintTrack(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea, bool horizontal)
	{
	}

	public void TrackBarPaintThumb(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea, GtkPlusState state, bool horizontal)
	{
	}

	public void TreeViewPaintGlyph(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea, bool closed)
	{
	}

	public void UpDownPaint(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea, bool up, GtkPlusState state)
	{
	}

	private void Paint(WidgetType widgetType, Rectangle bounds, IDeviceContext dc, Rectangle clippingArea, Painter painter)
	{
	}

	private void PaintExcludingArea(WidgetType widgetType, Rectangle bounds, IDeviceContext dc, Rectangle excludedArea, Painter painter)
	{
	}

	private void Paint(WidgetType widgetType, Rectangle bounds, IDeviceContext dc, TransparencyType transparencyType, Color background, DeviceContextType deviceContextType, Rectangle clippingArea, Painter painter, Rectangle excludedArea)
	{
	}

	private void Paint(IntPtr drawable, IntPtr gc, Rectangle rectangle, WidgetType widgetType, out IntPtr pixbuf, out IntPtr pixelData, out int rowstride, Rectangle clippingArea, Painter painter, Rectangle excludedArea)
	{
		pixbuf = default(IntPtr);
		pixelData = default(IntPtr);
		rowstride = default(int);
	}

	private static GtkShadowType GetWidgetStyleShadowType(IntPtr widget)
	{
		return default(GtkShadowType);
	}

	private static int GetWidgetStyleInteger(IntPtr widget, string propertyName)
	{
		return 0;
	}

	private static float GetWidgetStyleSingle(IntPtr widget, string propertyName)
	{
		return 0f;
	}

	private static bool GetWidgetStyleBoolean(IntPtr widget, string propertyName)
	{
		return false;
	}

	private static IntPtr GetWidgetStyle(IntPtr widget)
	{
		return (IntPtr)0;
	}

	[PreserveSig]
	private static extern void gdk_draw_rectangle(IntPtr drawable, IntPtr gc, bool filled, int x, int y, int width, int height);

	[PreserveSig]
	private static extern IntPtr gdk_gc_new(IntPtr drawable);

	[PreserveSig]
	private static extern void gdk_gc_set_rgb_fg_color(IntPtr gc, ref GdkColor color);

	[PreserveSig]
	private static extern IntPtr gdk_pixbuf_get_from_drawable(IntPtr dest, IntPtr src, IntPtr cmap, int src_x, int src_y, int dest_x, int dest_y, int width, int height);

	[PreserveSig]
	private static extern IntPtr gdk_pixmap_new(IntPtr drawable, int width, int height, int depth);

	[PreserveSig]
	private static extern IntPtr gdk_pixbuf_get_pixels(IntPtr pixbuf);

	[PreserveSig]
	private static extern int gdk_pixbuf_get_rowstride(IntPtr pixbuf);

	[PreserveSig]
	private static extern IntPtr gdk_pixbuf_new(GdkColorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height);

	[PreserveSig]
	private static extern bool gtk_init_check(ref int argc, ref string[] argv);

	[PreserveSig]
	private static extern IntPtr gtk_check_version(uint required_major, uint required_minor, uint required_micro);

	[PreserveSig]
	private static extern void gtk_container_add(IntPtr container, IntPtr widget);

	[PreserveSig]
	private static extern void gtk_container_forall(IntPtr container, GtkCallback callback, IntPtr callback_data);

	[PreserveSig]
	private static extern void gtk_object_destroy(IntPtr @object);

	[PreserveSig]
	private static extern IntPtr gtk_rc_get_style(IntPtr widget);

	[PreserveSig]
	private static extern IntPtr gtk_style_attach(IntPtr style, IntPtr window);

	[PreserveSig]
	private static extern void gtk_widget_realize(IntPtr widget);

	[PreserveSig]
	private static extern void gtk_widget_style_get(IntPtr widget, string property, out int value, IntPtr nullTerminator);

	[PreserveSig]
	private static extern void gtk_widget_style_get(IntPtr widget, string property, out float value, IntPtr nullTerminator);

	[PreserveSig]
	private static extern void gtk_widget_style_get(IntPtr widget, string property1, out int value1, string property2, out int value2, IntPtr nullTerminator);

	[PreserveSig]
	private static extern void gtk_widget_style_get(IntPtr widget, string property, out GtkShadowType value, IntPtr nullTerminator);

	[PreserveSig]
	private static extern void gtk_widget_style_get(IntPtr widget, string property, out bool value, IntPtr nullTerminator);

	[PreserveSig]
	private static extern IntPtr gtk_window_new(GtkWindowType type);

	[PreserveSig]
	private static extern void gtk_window_set_default(IntPtr window, IntPtr default_widget);

	[PreserveSig]
	private static extern IntPtr gtk_adjustment_new(double value, double lower, double upper, double step_increment, double page_increment, double page_size);

	[PreserveSig]
	private static extern IntPtr gtk_tree_view_column_new();

	[PreserveSig]
	private static extern int gtk_tree_view_insert_column(IntPtr tree_view, IntPtr column, int position);

	[PreserveSig]
	private static extern void gtk_toolbar_insert(IntPtr toolbar, IntPtr item, int pos);

	[PreserveSig]
	private static extern IntPtr gtk_bin_get_child(IntPtr bin);

	[PreserveSig]
	private static extern IntPtr gtk_arrow_get_type();

	[PreserveSig]
	private static extern IntPtr gtk_container_get_type();

	[PreserveSig]
	private static extern IntPtr gtk_toggle_button_get_type();

	[PreserveSig]
	private static extern IntPtr gtk_button_new();

	[PreserveSig]
	private static extern IntPtr gtk_check_button_new();

	[PreserveSig]
	private static extern IntPtr gtk_combo_box_entry_new();

	[PreserveSig]
	private static extern IntPtr gtk_entry_new();

	[PreserveSig]
	private static extern IntPtr gtk_fixed_new();

	[PreserveSig]
	private static extern IntPtr gtk_frame_new(string label);

	[PreserveSig]
	private static extern IntPtr gtk_hscale_new_with_range(double min, double max, double step);

	[PreserveSig]
	private static extern IntPtr gtk_hscrollbar_new(IntPtr adjustment);

	[PreserveSig]
	private static extern IntPtr gtk_notebook_new();

	[PreserveSig]
	private static extern IntPtr gtk_progress_bar_new();

	[PreserveSig]
	private static extern IntPtr gtk_radio_button_new(IntPtr group);

	[PreserveSig]
	private static extern IntPtr gtk_spin_button_new(IntPtr adjustment, double climb_rate, uint digits);

	[PreserveSig]
	private static extern IntPtr gtk_statusbar_new();

	[PreserveSig]
	private static extern IntPtr gtk_toggle_tool_button_new();

	[PreserveSig]
	private static extern IntPtr gtk_toolbar_new();

	[PreserveSig]
	private static extern IntPtr gtk_tool_button_new(IntPtr icon_widget, string label);

	[PreserveSig]
	private static extern IntPtr gtk_tree_view_new();

	[PreserveSig]
	private static extern IntPtr gtk_vscale_new_with_range(double min, double max, double step);

	[PreserveSig]
	private static extern IntPtr gtk_vscrollbar_new(IntPtr adjustment);

	[PreserveSig]
	private static extern void gtk_paint_arrow(IntPtr style, IntPtr window, GtkStateType state_type, GtkShadowType shadow_type, ref GdkRectangle area, IntPtr widget, string detail, GtkArrowType arrow_type, bool fill, int x, int y, int width, int height);

	[PreserveSig]
	private static extern void gtk_paint_box(IntPtr style, IntPtr window, GtkStateType state_type, GtkShadowType shadow_type, ref GdkRectangle area, IntPtr widget, string detail, int x, int y, int width, int height);

	[PreserveSig]
	private static extern void gtk_paint_box_gap(IntPtr style, IntPtr window, GtkStateType state_type, GtkShadowType shadow_type, ref GdkRectangle area, IntPtr widget, string detail, int x, int y, int width, int height, GtkPositionType gap_side, int gap_x, int gap_width);

	[PreserveSig]
	private static extern void gtk_paint_check(IntPtr style, IntPtr window, GtkStateType state_type, GtkShadowType shadow_type, ref GdkRectangle area, IntPtr widget, string detail, int x, int y, int width, int height);

	[PreserveSig]
	private static extern void gtk_paint_expander(IntPtr style, IntPtr window, GtkStateType state_type, ref GdkRectangle area, IntPtr widget, string detail, int x, int y, GtkExpanderStyle expander_style);

	[PreserveSig]
	private static extern void gtk_paint_extension(IntPtr style, IntPtr window, GtkStateType state_type, GtkShadowType shadow_type, ref GdkRectangle area, IntPtr widget, string detail, int x, int y, int width, int height, GtkPositionType gap_side);

	[PreserveSig]
	private static extern void gtk_paint_flat_box(IntPtr style, IntPtr window, GtkStateType state_type, GtkShadowType shadow_type, ref GdkRectangle area, IntPtr widget, string detail, int x, int y, int width, int height);

	[PreserveSig]
	private static extern void gtk_paint_option(IntPtr style, IntPtr window, GtkStateType state_type, GtkShadowType shadow_type, ref GdkRectangle area, IntPtr widget, string detail, int x, int y, int width, int height);

	[PreserveSig]
	private static extern void gtk_paint_resize_grip(IntPtr style, IntPtr window, GtkStateType state_type, ref GdkRectangle area, IntPtr widget, string detail, GdkWindowEdge edge, int x, int y, int width, int height);

	[PreserveSig]
	private static extern void gtk_paint_shadow(IntPtr style, IntPtr window, GtkStateType state_type, GtkShadowType shadow_type, ref GdkRectangle area, IntPtr widget, string detail, int x, int y, int width, int height);

	[PreserveSig]
	private static extern void gtk_paint_slider(IntPtr style, IntPtr window, GtkStateType state_type, GtkShadowType shadow_type, ref GdkRectangle area, IntPtr widget, string detail, int x, int y, int width, int height, GtkOrientation orientation);

	private static void GTK_WIDGET_SET_FLAGS(IntPtr wid, GtkWidgetFlags flag)
	{
	}

	[PreserveSig]
	private static extern IntPtr g_object_ref(IntPtr @object);

	[PreserveSig]
	private static extern void g_object_unref(IntPtr @object);

	[PreserveSig]
	private static extern bool g_type_check_instance_is_a(IntPtr type_instance, IntPtr iface_type);

	[PreserveSig]
	private static extern void g_object_get(IntPtr @object, string property_name, out bool value, IntPtr nullTerminator);
}
