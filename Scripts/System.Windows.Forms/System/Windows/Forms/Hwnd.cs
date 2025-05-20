using System.Collections;
using System.Drawing;

namespace System.Windows.Forms;

internal class Hwnd : IDisposable
{
	internal struct Borders
	{
		public int top;

		public int bottom;

		public int left;

		public int right;

		public void Inflate(Size size)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}

	private static Hashtable windows;

	private IntPtr handle;

	internal IntPtr client_window;

	internal IntPtr whole_window;

	internal IntPtr cursor;

	internal Menu menu;

	internal TitleStyle title_style;

	internal FormBorderStyle border_style;

	internal bool border_static;

	internal int x;

	internal int y;

	internal int width;

	internal int height;

	internal bool allow_drop;

	internal Hwnd parent;

	internal bool visible;

	internal bool mapped;

	internal uint opacity;

	internal bool enabled;

	internal bool zero_sized;

	internal ArrayList invalid_list;

	internal Rectangle nc_invalid;

	internal bool expose_pending;

	internal bool nc_expose_pending;

	internal bool configure_pending;

	internal bool resizing_or_moving;

	internal bool reparented;

	internal Stack drawing_stack;

	internal Rectangle client_rectangle;

	internal ArrayList marshal_free_list;

	internal int caption_height;

	internal int tool_caption_height;

	internal bool whacky_wm;

	internal bool fixed_size;

	internal bool zombie;

	internal Region user_clip;

	internal XEventQueue queue;

	internal WindowExStyles initial_ex_style;

	internal WindowStyles initial_style;

	internal FormWindowState cached_window_state;

	internal Point previous_child_startup_location;

	internal static Point previous_main_startup_location;

	internal ArrayList children;

	[ThreadStatic]
	private static Bitmap bmp;

	[ThreadStatic]
	private static Graphics bmp_g;

	internal object configure_lock;

	internal object expose_lock;

	public static Graphics GraphicsContext => null;

	public Rectangle ClientRect
	{
		get
		{
			return default(Rectangle);
		}
		set
		{
		}
	}

	public IntPtr Cursor
	{
		get
		{
			return (IntPtr)0;
		}
		set
		{
		}
	}

	public IntPtr ClientWindow
	{
		get
		{
			return (IntPtr)0;
		}
		set
		{
		}
	}

	public Region UserClip
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Rectangle DefaultClientRect => default(Rectangle);

	public IntPtr Handle => (IntPtr)0;

	public int Height
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool Reparented
	{
		set
		{
		}
	}

	public XEventQueue Queue
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

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

	public IntPtr EnabledHwnd => (IntPtr)0;

	public Point MenuOrigin => default(Point);

	public Rectangle Invalid => default(Rectangle);

	public Rectangle[] ClipRectangles => null;

	public Hwnd Parent
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool Mapped
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public IntPtr WholeWindow
	{
		get
		{
			return (IntPtr)0;
		}
		set
		{
		}
	}

	public int Width
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int X
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Y
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public void Dispose()
	{
	}

	public static Hwnd ObjectFromWindow(IntPtr window)
	{
		return null;
	}

	public static Hwnd ObjectFromHandle(IntPtr handle)
	{
		return null;
	}

	public static IntPtr HandleFromObject(Hwnd obj)
	{
		return (IntPtr)0;
	}

	public static Hwnd GetObjectFromWindow(IntPtr window)
	{
		return null;
	}

	public static IntPtr GetHandleFromWindow(IntPtr window)
	{
		return (IntPtr)0;
	}

	public static Borders GetBorderWidth(CreateParams cp)
	{
		return default(Borders);
	}

	public static Rectangle GetWindowRectangle(CreateParams cp, Menu menu, Rectangle client_rect)
	{
		return default(Rectangle);
	}

	public ArrayList GetClippingRectangles()
	{
		return null;
	}

	public static Borders GetBorders(CreateParams cp, Menu menu)
	{
		return default(Borders);
	}

	public static Rectangle GetClientRectangle(CreateParams cp, Menu menu, int width, int height)
	{
		return default(Rectangle);
	}

	public void AddInvalidArea(int x, int y, int width, int height)
	{
	}

	public void AddInvalidArea(Rectangle rect)
	{
	}

	public void ClearInvalidArea()
	{
	}

	public void AddNcInvalidArea(int x, int y, int width, int height)
	{
	}

	public void ClearNcInvalidArea()
	{
	}

	public override string ToString()
	{
		return null;
	}

	public static Point GetNextStackedFormLocation(CreateParams cp, Hwnd parent_hwnd)
	{
		return default(Point);
	}
}
