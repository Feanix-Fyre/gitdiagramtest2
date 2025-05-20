using System.Drawing;
using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Provides methods used to measure and render text. This class cannot be inherited.</summary>
public sealed class TextRenderer
{
	/// <summary>Draws the specified text at the specified location using the specified device context, font, color, and formatting instructions.</summary>
	/// <param name="dc">The device context in which to draw the text.</param>
	/// <param name="text">The text to draw.</param>
	/// <param name="font">The <see cref="T:System.Drawing.Font" /> to apply to the drawn text.</param>
	/// <param name="pt">The <see cref="T:System.Drawing.Point" /> that represents the upper-left corner of the drawn text.</param>
	/// <param name="foreColor">The <see cref="T:System.Drawing.Color" /> to apply to the drawn text.</param>
	/// <param name="flags">A bitwise combination of the <see cref="T:System.Windows.Forms.TextFormatFlags" /> values.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="dc" /> is <see langword="null" />.</exception>
	public static void DrawText(IDeviceContext dc, string text, Font font, Point pt, Color foreColor, TextFormatFlags flags)
	{
	}

	/// <summary>Draws the specified text within the specified bounds using the specified device context, font, color, and formatting instructions.</summary>
	/// <param name="dc">The device context in which to draw the text.</param>
	/// <param name="text">The text to draw.</param>
	/// <param name="font">The <see cref="T:System.Drawing.Font" /> to apply to the drawn text.</param>
	/// <param name="bounds">The <see cref="T:System.Drawing.Rectangle" /> that represents the bounds of the text.</param>
	/// <param name="foreColor">The <see cref="T:System.Drawing.Color" /> to apply to the drawn text.</param>
	/// <param name="flags">A bitwise combination of the <see cref="T:System.Windows.Forms.TextFormatFlags" /> values.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="dc" /> is <see langword="null" />.</exception>
	public static void DrawText(IDeviceContext dc, string text, Font font, Rectangle bounds, Color foreColor, TextFormatFlags flags)
	{
	}

	/// <summary>Provides the size, in pixels, of the specified text when drawn with the specified font.</summary>
	/// <param name="text">The text to measure.</param>
	/// <param name="font">The <see cref="T:System.Drawing.Font" /> to apply to the measured text.</param>
	/// <returns>The <see cref="T:System.Drawing.Size" />, in pixels, of <paramref name="text" /> drawn on a single line with the specified <paramref name="font" />. You can manipulate how the text is drawn by using one of the <see cref="M:System.Windows.Forms.TextRenderer.DrawText(System.Drawing.IDeviceContext,System.String,System.Drawing.Font,System.Drawing.Rectangle,System.Drawing.Color,System.Windows.Forms.TextFormatFlags)" /> overloads that takes a <see cref="T:System.Windows.Forms.TextFormatFlags" /> parameter. For example, the default behavior of the <see cref="T:System.Windows.Forms.TextRenderer" /> is to add padding to the bounding rectangle of the drawn text to accommodate overhanging glyphs. If you need to draw a line of text without these extra spaces you should use the versions of <see cref="M:System.Windows.Forms.TextRenderer.DrawText(System.Drawing.IDeviceContext,System.String,System.Drawing.Font,System.Drawing.Point,System.Drawing.Color)" /> and <see cref="M:System.Windows.Forms.TextRenderer.MeasureText(System.Drawing.IDeviceContext,System.String,System.Drawing.Font)" /> that take a <see cref="T:System.Drawing.Size" /> and <see cref="T:System.Windows.Forms.TextFormatFlags" /> parameter. For an example, see <see cref="M:System.Windows.Forms.TextRenderer.MeasureText(System.Drawing.IDeviceContext,System.String,System.Drawing.Font,System.Drawing.Size,System.Windows.Forms.TextFormatFlags)" />.</returns>
	public static Size MeasureText(string text, Font font)
	{
		return default(Size);
	}

	/// <summary>Provides the size, in pixels, of the specified text when drawn with the specified font and formatting instructions, using the specified size to create the initial bounding rectangle for the text.</summary>
	/// <param name="text">The text to measure.</param>
	/// <param name="font">The <see cref="T:System.Drawing.Font" /> to apply to the measured text.</param>
	/// <param name="proposedSize">The <see cref="T:System.Drawing.Size" /> of the initial bounding rectangle.</param>
	/// <param name="flags">The formatting instructions to apply to the measured text.</param>
	/// <returns>The <see cref="T:System.Drawing.Size" />, in pixels, of <paramref name="text" /> drawn with the specified <paramref name="font" /> and format.</returns>
	public static Size MeasureText(string text, Font font, Size proposedSize, TextFormatFlags flags)
	{
		return default(Size);
	}

	/// <summary>Provides the size, in pixels, of the specified text when drawn with the specified device context, font, and formatting instructions, using the specified size to create the initial bounding rectangle for the text.</summary>
	/// <param name="dc">The device context in which to measure the text.</param>
	/// <param name="text">The text to measure.</param>
	/// <param name="font">The <see cref="T:System.Drawing.Font" /> to apply to the measured text.</param>
	/// <param name="proposedSize">The <see cref="T:System.Drawing.Size" /> of the initial bounding rectangle.</param>
	/// <param name="flags">The formatting instructions to apply to the measured text.</param>
	/// <returns>The <see cref="T:System.Drawing.Size" />, in pixels, of <paramref name="text" /> drawn with the specified <paramref name="font" /> and format.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="dc" /> is <see langword="null" />.</exception>
	public static Size MeasureText(IDeviceContext dc, string text, Font font, Size proposedSize, TextFormatFlags flags)
	{
		return default(Size);
	}

	internal static void DrawTextInternal(IDeviceContext dc, string text, Font font, Rectangle bounds, Color foreColor, Color backColor, TextFormatFlags flags, bool useDrawString)
	{
	}

	internal static Size MeasureTextInternal(IDeviceContext dc, string text, Font font, Size proposedSize, TextFormatFlags flags, bool useMeasureString)
	{
		return default(Size);
	}

	internal static void DrawTextInternal(IDeviceContext dc, string text, Font font, Rectangle bounds, Color foreColor, TextFormatFlags flags, bool useDrawString)
	{
	}

	internal static Size MeasureTextInternal(string text, Font font, bool useMeasureString)
	{
		return default(Size);
	}

	internal static void DrawTextInternal(IDeviceContext dc, string text, Font font, Point pt, Color foreColor, Color backColor, TextFormatFlags flags, bool useDrawString)
	{
	}

	internal static Size MeasureTextInternal(IDeviceContext dc, string text, Font font, bool useMeasureString)
	{
		return default(Size);
	}

	internal static Size MeasureTextInternal(string text, Font font, Size proposedSize, TextFormatFlags flags, bool useMeasureString)
	{
		return default(Size);
	}

	internal static SizeF MeasureString(string text, Font font)
	{
		return default(SizeF);
	}

	internal static SizeF MeasureString(string text, Font font, int width)
	{
		return default(SizeF);
	}

	internal static SizeF MeasureString(string text, Font font, int width, StringFormat format)
	{
		return default(SizeF);
	}

	internal static SizeF MeasureString(string text, Font font, SizeF layoutArea, StringFormat stringFormat)
	{
		return default(SizeF);
	}

	internal static SizeF GetDpi()
	{
		return default(SizeF);
	}

	private static StringFormat FlagsToStringFormat(TextFormatFlags flags)
	{
		return null;
	}

	private static Rectangle PadRectangle(Rectangle r, TextFormatFlags flags)
	{
		return default(Rectangle);
	}

	private static Rectangle PadDrawStringRectangle(Rectangle r, TextFormatFlags flags)
	{
		return default(Rectangle);
	}

	[PreserveSig]
	private static extern int Win32DrawText(IntPtr hdc, string lpStr, int nCount, ref XplatUIWin32.RECT lpRect, int wFormat);

	[PreserveSig]
	private static extern int SetTextColor(IntPtr hdc, int crColor);

	[PreserveSig]
	private static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);

	[PreserveSig]
	private static extern int SetBkColor(IntPtr hdc, int crColor);

	[PreserveSig]
	private static extern int SetBkMode(IntPtr hdc, int iBkMode);

	[PreserveSig]
	private static extern bool DeleteObject(IntPtr objectHandle);

	[PreserveSig]
	private static extern bool SelectClipRgn(IntPtr hdc, IntPtr hrgn);
}
