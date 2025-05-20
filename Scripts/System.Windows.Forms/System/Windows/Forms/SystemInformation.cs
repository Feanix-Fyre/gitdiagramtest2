using System.Drawing;

namespace System.Windows.Forms;

/// <summary>Provides information about the current system environment.</summary>
public class SystemInformation
{
	/// <summary>Gets the standard size, in pixels, of a button in a window's title bar.</summary>
	/// <returns>A <see cref="T:System.Drawing.Size" /> that indicates the standard dimensions, in pixels, of a button in a window's title bar.</returns>
	public static Size CaptionButtonSize => default(Size);

	/// <summary>Gets the height, in pixels, of the standard title bar area of a window.</summary>
	/// <returns>The height, in pixels, of the standard title bar area of a window.</returns>
	public static int CaptionHeight => 0;

	/// <summary>Gets the dimensions, in pixels, of the area within which the user must click twice for the operating system to consider the two clicks a double-click.</summary>
	/// <returns>A <see cref="T:System.Drawing.Size" /> that indicates the dimensions, in pixels, of the area within which the user must click twice for the operating system to consider the two clicks a double-click.</returns>
	public static Size DoubleClickSize => default(Size);

	/// <summary>Gets the maximum number of milliseconds that can elapse between a first click and a second click for the OS to consider the mouse action a double-click.</summary>
	/// <returns>The maximum amount of time, in milliseconds, that can elapse between a first click and a second click for the OS to consider the mouse action a double-click.</returns>
	public static int DoubleClickTime => 0;

	/// <summary>Gets the width and height of a rectangle centered on the point the mouse button was pressed, within which a drag operation will not begin.</summary>
	/// <returns>A <see cref="T:System.Drawing.Size" /> that specifies the area of a rectangle, in pixels, centered on the point the mouse button was pressed, within which a drag operation will not begin.</returns>
	public static Size DragSize => default(Size);

	/// <summary>Gets the thickness, in pixels, of the resizing border that is drawn around the perimeter of a window that is being drag resized.</summary>
	/// <returns>A <see cref="T:System.Drawing.Size" /> that indicates the thickness, in pixels, of the width of a vertical resizing border and the height of a horizontal resizing border.</returns>
	public static Size FrameBorderSize => default(Size);

	/// <summary>Gets the default height, in pixels, of the horizontal scroll bar.</summary>
	/// <returns>The default height, in pixels, of the horizontal scroll bar.</returns>
	public static int HorizontalScrollBarHeight => 0;

	/// <summary>Gets a value indicating whether menu access keys are always underlined.</summary>
	/// <returns>
	///   <see langword="true" /> if menu access keys are always underlined; <see langword="false" /> if they are underlined only when the menu is activated or receives focus.</returns>
	public static bool MenuAccessKeysUnderlined => false;

	/// <summary>Gets the default dimensions, in pixels, of menu-bar buttons.</summary>
	/// <returns>A <see cref="T:System.Drawing.Size" /> that indicates the default dimensions, in pixels, of menu-bar buttons.</returns>
	public static Size MenuButtonSize => default(Size);

	/// <summary>Gets the height, in pixels, of one line of a menu.</summary>
	/// <returns>The height, in pixels, of one line of a menu.</returns>
	public static int MenuHeight => 0;

	/// <summary>Gets the dimensions, in pixels, of a normal minimized window.</summary>
	/// <returns>A <see cref="T:System.Drawing.Size" /> that indicates the dimensions, in pixels, of a normal minimized window.</returns>
	public static Size MinimizedWindowSize => default(Size);

	/// <summary>Gets the minimum width and height for a window, in pixels.</summary>
	/// <returns>A <see cref="T:System.Drawing.Size" /> that specifies the minimum allowable dimensions of a window, in pixels.</returns>
	public static Size MinimumWindowSize => default(Size);

	/// <summary>Gets the default minimum dimensions, in pixels, that a window may occupy during a drag resize.</summary>
	/// <returns>A <see cref="T:System.Drawing.Size" /> that indicates the default minimum width and height of a window during resize, in pixels.</returns>
	public static Size MinWindowTrackSize => default(Size);

	/// <summary>Gets the number of lines to scroll when the mouse wheel is rotated.</summary>
	/// <returns>The number of lines to scroll on a mouse wheel rotation, or -1 if the "One screen at a time" mouse option is selected.</returns>
	public static int MouseWheelScrollLines => 0;

	/// <summary>Gets the dimensions, in pixels, of small caption buttons.</summary>
	/// <returns>A <see cref="T:System.Drawing.Size" /> that indicates the dimensions, in pixels, of small caption buttons.</returns>
	public static Size ToolWindowCaptionButtonSize => default(Size);

	/// <summary>Gets the height, in pixels, of a tool window caption.</summary>
	/// <returns>The height, in pixels, of a tool window caption in pixels.</returns>
	public static int ToolWindowCaptionHeight => 0;

	/// <summary>Gets a value indicating whether the current process is running in user-interactive mode.</summary>
	/// <returns>
	///   <see langword="true" /> if the current process is running in user-interactive mode; otherwise, <see langword="false" />.</returns>
	public static bool UserInteractive => false;

	/// <summary>Gets the default width, in pixels, of the vertical scroll bar.</summary>
	/// <returns>The default width, in pixels, of the vertical scroll bar.</returns>
	public static int VerticalScrollBarWidth => 0;

	/// <summary>Gets the bounds of the virtual screen.</summary>
	/// <returns>A <see cref="T:System.Drawing.Rectangle" /> that specifies the bounding rectangle of the entire virtual screen.</returns>
	public static Rectangle VirtualScreen => default(Rectangle);

	/// <summary>Gets the size, in pixels, of the working area of the screen.</summary>
	/// <returns>A <see cref="T:System.Drawing.Rectangle" /> that represents the size, in pixels, of the working area of the screen.</returns>
	public static Rectangle WorkingArea => default(Rectangle);
}
