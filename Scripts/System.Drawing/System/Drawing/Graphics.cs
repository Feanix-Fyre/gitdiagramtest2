using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace System.Drawing;

/// <summary>Encapsulates a GDI+ drawing surface. This class cannot be inherited.</summary>
public sealed class Graphics : MarshalByRefObject, IDisposable, IDeviceContext
{
	/// <summary>Provides a callback method for deciding when the <see cref="Overload:System.Drawing.Graphics.DrawImage" /> method should prematurely cancel execution and stop drawing an image.</summary>
	/// <param name="callbackdata">Internal pointer that specifies data for the callback method. This parameter is not passed by all <see cref="Overload:System.Drawing.Graphics.DrawImage" /> overloads. You can test for its absence by checking for the value <see cref="F:System.IntPtr.Zero" />.</param>
	/// <returns>This method returns <see langword="true" /> if it decides that the <see cref="Overload:System.Drawing.Graphics.DrawImage" /> method should prematurely stop execution. Otherwise it returns <see langword="false" /> to indicate that the <see cref="Overload:System.Drawing.Graphics.DrawImage" /> method should continue execution.</returns>
	public delegate bool DrawImageAbort(IntPtr callbackdata);

	internal IntPtr nativeObject;

	internal IMacContext maccontext;

	private bool disposed;

	private static float defDpiX;

	private static float defDpiY;

	private IntPtr deviceContextHdc;

	private Metafile.MetafileHolder _metafileHolder;

	internal static float systemDpiX => 0f;

	internal static float systemDpiY => 0f;

	internal IntPtr NativeObject => (IntPtr)0;

	/// <summary>Gets or sets a <see cref="T:System.Drawing.Region" /> that limits the drawing region of this <see cref="T:System.Drawing.Graphics" />.</summary>
	/// <returns>A <see cref="T:System.Drawing.Region" /> that limits the portion of this <see cref="T:System.Drawing.Graphics" /> that is currently available for drawing.</returns>
	public Region Clip
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the horizontal resolution of this <see cref="T:System.Drawing.Graphics" />.</summary>
	/// <returns>The value, in dots per inch, for the horizontal resolution supported by this <see cref="T:System.Drawing.Graphics" />.</returns>
	public float DpiX => 0f;

	/// <summary>Gets the vertical resolution of this <see cref="T:System.Drawing.Graphics" />.</summary>
	/// <returns>The value, in dots per inch, for the vertical resolution supported by this <see cref="T:System.Drawing.Graphics" />.</returns>
	public float DpiY => 0f;

	/// <summary>Gets or sets a copy of the geometric world transformation for this <see cref="T:System.Drawing.Graphics" />.</summary>
	/// <returns>A copy of the <see cref="T:System.Drawing.Drawing2D.Matrix" /> that represents the geometric world transformation for this <see cref="T:System.Drawing.Graphics" />.</returns>
	public Matrix Transform => null;

	internal Graphics(IntPtr nativeGraphics)
	{
	}

	internal Graphics(IntPtr nativeGraphics, Image image)
	{
	}

	/// <summary>Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.</summary>
	~Graphics()
	{
	}

	/// <summary>Clears the entire drawing surface and fills it with the specified background color.</summary>
	/// <param name="color">
	///   <see cref="T:System.Drawing.Color" /> structure that represents the background color of the drawing surface.</param>
	public void Clear(Color color)
	{
	}

	/// <summary>Releases all resources used by this <see cref="T:System.Drawing.Graphics" />.</summary>
	public void Dispose()
	{
	}

	/// <summary>Draws the image represented by the specified <see cref="T:System.Drawing.Icon" /> within the area specified by a <see cref="T:System.Drawing.Rectangle" /> structure.</summary>
	/// <param name="icon">
	///   <see cref="T:System.Drawing.Icon" /> to draw.</param>
	/// <param name="targetRect">
	///   <see cref="T:System.Drawing.Rectangle" /> structure that specifies the location and size of the resulting image on the display surface. The image contained in the <paramref name="icon" /> parameter is scaled to the dimensions of this rectangular area.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="icon" /> is <see langword="null" />.</exception>
	public void DrawIcon(Icon icon, Rectangle targetRect)
	{
	}

	/// <summary>Draws the image represented by the specified <see cref="T:System.Drawing.Icon" /> at the specified coordinates.</summary>
	/// <param name="icon">
	///   <see cref="T:System.Drawing.Icon" /> to draw.</param>
	/// <param name="x">The x-coordinate of the upper-left corner of the drawn image.</param>
	/// <param name="y">The y-coordinate of the upper-left corner of the drawn image.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="icon" /> is <see langword="null" />.</exception>
	public void DrawIcon(Icon icon, int x, int y)
	{
	}

	/// <summary>Draws the specified <see cref="T:System.Drawing.Image" />, using its original physical size, at the specified location.</summary>
	/// <param name="image">
	///   <see cref="T:System.Drawing.Image" /> to draw.</param>
	/// <param name="point">
	///   <see cref="T:System.Drawing.Point" /> structure that represents the location of the upper-left corner of the drawn image.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="image" /> is <see langword="null" />.</exception>
	public void DrawImage(Image image, Point point)
	{
	}

	/// <summary>Draws the specified <see cref="T:System.Drawing.Image" /> at the specified location and with the specified size.</summary>
	/// <param name="image">
	///   <see cref="T:System.Drawing.Image" /> to draw.</param>
	/// <param name="rect">
	///   <see cref="T:System.Drawing.Rectangle" /> structure that specifies the location and size of the drawn image.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="image" /> is <see langword="null" />.</exception>
	public void DrawImage(Image image, Rectangle rect)
	{
	}

	/// <summary>Draws the specified image, using its original physical size, at the location specified by a coordinate pair.</summary>
	/// <param name="image">
	///   <see cref="T:System.Drawing.Image" /> to draw.</param>
	/// <param name="x">The x-coordinate of the upper-left corner of the drawn image.</param>
	/// <param name="y">The y-coordinate of the upper-left corner of the drawn image.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="image" /> is <see langword="null" />.</exception>
	public void DrawImage(Image image, int x, int y)
	{
	}

	/// <summary>Draws the specified portion of the specified <see cref="T:System.Drawing.Image" /> at the specified location and with the specified size.</summary>
	/// <param name="image">
	///   <see cref="T:System.Drawing.Image" /> to draw.</param>
	/// <param name="destRect">
	///   <see cref="T:System.Drawing.Rectangle" /> structure that specifies the location and size of the drawn image. The image is scaled to fit the rectangle.</param>
	/// <param name="srcRect">
	///   <see cref="T:System.Drawing.Rectangle" /> structure that specifies the portion of the <paramref name="image" /> object to draw.</param>
	/// <param name="srcUnit">Member of the <see cref="T:System.Drawing.GraphicsUnit" /> enumeration that specifies the units of measure used by the <paramref name="srcRect" /> parameter.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="image" /> is <see langword="null" />.</exception>
	public void DrawImage(Image image, Rectangle destRect, Rectangle srcRect, GraphicsUnit srcUnit)
	{
	}

	/// <summary>Draws the specified <see cref="T:System.Drawing.Image" /> at the specified location and with the specified size.</summary>
	/// <param name="image">
	///   <see cref="T:System.Drawing.Image" /> to draw.</param>
	/// <param name="x">The x-coordinate of the upper-left corner of the drawn image.</param>
	/// <param name="y">The y-coordinate of the upper-left corner of the drawn image.</param>
	/// <param name="width">Width of the drawn image.</param>
	/// <param name="height">Height of the drawn image.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="image" /> is <see langword="null" />.</exception>
	public void DrawImage(Image image, int x, int y, int width, int height)
	{
	}

	/// <summary>Draws the specified portion of the specified <see cref="T:System.Drawing.Image" /> at the specified location and with the specified size.</summary>
	/// <param name="image">
	///   <see cref="T:System.Drawing.Image" /> to draw.</param>
	/// <param name="destRect">
	///   <see cref="T:System.Drawing.Rectangle" /> structure that specifies the location and size of the drawn image. The image is scaled to fit the rectangle.</param>
	/// <param name="srcX">The x-coordinate of the upper-left corner of the portion of the source image to draw.</param>
	/// <param name="srcY">The y-coordinate of the upper-left corner of the portion of the source image to draw.</param>
	/// <param name="srcWidth">Width of the portion of the source image to draw.</param>
	/// <param name="srcHeight">Height of the portion of the source image to draw.</param>
	/// <param name="srcUnit">Member of the <see cref="T:System.Drawing.GraphicsUnit" /> enumeration that specifies the units of measure used to determine the source rectangle.</param>
	/// <param name="imageAttr">
	///   <see cref="T:System.Drawing.Imaging.ImageAttributes" /> that specifies recoloring and gamma information for the <paramref name="image" /> object.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="image" /> is <see langword="null" />.</exception>
	public void DrawImage(Image image, Rectangle destRect, int srcX, int srcY, int srcWidth, int srcHeight, GraphicsUnit srcUnit, ImageAttributes imageAttr)
	{
	}

	/// <summary>Draws a specified image using its original physical size at a specified location.</summary>
	/// <param name="image">
	///   <see cref="T:System.Drawing.Image" /> to draw.</param>
	/// <param name="x">The x-coordinate of the upper-left corner of the drawn image.</param>
	/// <param name="y">The y-coordinate of the upper-left corner of the drawn image.</param>
	/// <param name="width">Not used.</param>
	/// <param name="height">Not used.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="image" /> is <see langword="null" />.</exception>
	public void DrawImageUnscaled(Image image, int x, int y, int width, int height)
	{
	}

	/// <summary>Draws the specified image without scaling and clips it, if necessary, to fit in the specified rectangle.</summary>
	/// <param name="image">The <see cref="T:System.Drawing.Image" /> to draw.</param>
	/// <param name="rect">The <see cref="T:System.Drawing.Rectangle" /> in which to draw the image.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="image" /> is <see langword="null" />.</exception>
	public void DrawImageUnscaledAndClipped(Image image, Rectangle rect)
	{
	}

	/// <summary>Draws a line connecting two <see cref="T:System.Drawing.Point" /> structures.</summary>
	/// <param name="pen">
	///   <see cref="T:System.Drawing.Pen" /> that determines the color, width, and style of the line.</param>
	/// <param name="pt1">
	///   <see cref="T:System.Drawing.Point" /> structure that represents the first point to connect.</param>
	/// <param name="pt2">
	///   <see cref="T:System.Drawing.Point" /> structure that represents the second point to connect.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="pen" /> is <see langword="null" />.</exception>
	public void DrawLine(Pen pen, Point pt1, Point pt2)
	{
	}

	/// <summary>Draws a line connecting the two points specified by the coordinate pairs.</summary>
	/// <param name="pen">
	///   <see cref="T:System.Drawing.Pen" /> that determines the color, width, and style of the line.</param>
	/// <param name="x1">The x-coordinate of the first point.</param>
	/// <param name="y1">The y-coordinate of the first point.</param>
	/// <param name="x2">The x-coordinate of the second point.</param>
	/// <param name="y2">The y-coordinate of the second point.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="pen" /> is <see langword="null" />.</exception>
	public void DrawLine(Pen pen, int x1, int y1, int x2, int y2)
	{
	}

	/// <summary>Draws a line connecting the two points specified by the coordinate pairs.</summary>
	/// <param name="pen">
	///   <see cref="T:System.Drawing.Pen" /> that determines the color, width, and style of the line.</param>
	/// <param name="x1">The x-coordinate of the first point.</param>
	/// <param name="y1">The y-coordinate of the first point.</param>
	/// <param name="x2">The x-coordinate of the second point.</param>
	/// <param name="y2">The y-coordinate of the second point.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="pen" /> is <see langword="null" />.</exception>
	public void DrawLine(Pen pen, float x1, float y1, float x2, float y2)
	{
	}

	/// <summary>Draws a series of line segments that connect an array of <see cref="T:System.Drawing.Point" /> structures.</summary>
	/// <param name="pen">
	///   <see cref="T:System.Drawing.Pen" /> that determines the color, width, and style of the line segments.</param>
	/// <param name="points">Array of <see cref="T:System.Drawing.Point" /> structures that represent the points to connect.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="pen" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="points" /> is <see langword="null" />.</exception>
	public void DrawLines(Pen pen, Point[] points)
	{
	}

	/// <summary>Draws a polygon defined by an array of <see cref="T:System.Drawing.Point" /> structures.</summary>
	/// <param name="pen">
	///   <see cref="T:System.Drawing.Pen" /> that determines the color, width, and style of the polygon.</param>
	/// <param name="points">Array of <see cref="T:System.Drawing.Point" /> structures that represent the vertices of the polygon.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="pen" /> is <see langword="null" />.</exception>
	public void DrawPolygon(Pen pen, Point[] points)
	{
	}

	/// <summary>Draws a rectangle specified by a <see cref="T:System.Drawing.Rectangle" /> structure.</summary>
	/// <param name="pen">A <see cref="T:System.Drawing.Pen" /> that determines the color, width, and style of the rectangle.</param>
	/// <param name="rect">A <see cref="T:System.Drawing.Rectangle" /> structure that represents the rectangle to draw.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="pen" /> is <see langword="null" />.</exception>
	public void DrawRectangle(Pen pen, Rectangle rect)
	{
	}

	/// <summary>Draws a rectangle specified by a coordinate pair, a width, and a height.</summary>
	/// <param name="pen">
	///   <see cref="T:System.Drawing.Pen" /> that determines the color, width, and style of the rectangle.</param>
	/// <param name="x">The x-coordinate of the upper-left corner of the rectangle to draw.</param>
	/// <param name="y">The y-coordinate of the upper-left corner of the rectangle to draw.</param>
	/// <param name="width">Width of the rectangle to draw.</param>
	/// <param name="height">Height of the rectangle to draw.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="pen" /> is <see langword="null" />.</exception>
	public void DrawRectangle(Pen pen, int x, int y, int width, int height)
	{
	}

	/// <summary>Draws the specified text string in the specified rectangle with the specified <see cref="T:System.Drawing.Brush" /> and <see cref="T:System.Drawing.Font" /> objects.</summary>
	/// <param name="s">String to draw.</param>
	/// <param name="font">
	///   <see cref="T:System.Drawing.Font" /> that defines the text format of the string.</param>
	/// <param name="brush">
	///   <see cref="T:System.Drawing.Brush" /> that determines the color and texture of the drawn text.</param>
	/// <param name="layoutRectangle">
	///   <see cref="T:System.Drawing.RectangleF" /> structure that specifies the location of the drawn text.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="brush" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="s" /> is <see langword="null" />.</exception>
	public void DrawString(string s, Font font, Brush brush, RectangleF layoutRectangle)
	{
	}

	/// <summary>Draws the specified text string at the specified location with the specified <see cref="T:System.Drawing.Brush" /> and <see cref="T:System.Drawing.Font" /> objects.</summary>
	/// <param name="s">String to draw.</param>
	/// <param name="font">
	///   <see cref="T:System.Drawing.Font" /> that defines the text format of the string.</param>
	/// <param name="brush">
	///   <see cref="T:System.Drawing.Brush" /> that determines the color and texture of the drawn text.</param>
	/// <param name="point">
	///   <see cref="T:System.Drawing.PointF" /> structure that specifies the upper-left corner of the drawn text.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="brush" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="s" /> is <see langword="null" />.</exception>
	public void DrawString(string s, Font font, Brush brush, PointF point)
	{
	}

	/// <summary>Draws the specified text string at the specified location with the specified <see cref="T:System.Drawing.Brush" /> and <see cref="T:System.Drawing.Font" /> objects using the formatting attributes of the specified <see cref="T:System.Drawing.StringFormat" />.</summary>
	/// <param name="s">String to draw.</param>
	/// <param name="font">
	///   <see cref="T:System.Drawing.Font" /> that defines the text format of the string.</param>
	/// <param name="brush">
	///   <see cref="T:System.Drawing.Brush" /> that determines the color and texture of the drawn text.</param>
	/// <param name="x">The x-coordinate of the upper-left corner of the drawn text.</param>
	/// <param name="y">The y-coordinate of the upper-left corner of the drawn text.</param>
	/// <param name="format">
	///   <see cref="T:System.Drawing.StringFormat" /> that specifies formatting attributes, such as line spacing and alignment, that are applied to the drawn text.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="brush" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="s" /> is <see langword="null" />.</exception>
	public void DrawString(string s, Font font, Brush brush, float x, float y, StringFormat format)
	{
	}

	/// <summary>Draws the specified text string in the specified rectangle with the specified <see cref="T:System.Drawing.Brush" /> and <see cref="T:System.Drawing.Font" /> objects using the formatting attributes of the specified <see cref="T:System.Drawing.StringFormat" />.</summary>
	/// <param name="s">String to draw.</param>
	/// <param name="font">
	///   <see cref="T:System.Drawing.Font" /> that defines the text format of the string.</param>
	/// <param name="brush">
	///   <see cref="T:System.Drawing.Brush" /> that determines the color and texture of the drawn text.</param>
	/// <param name="layoutRectangle">
	///   <see cref="T:System.Drawing.RectangleF" /> structure that specifies the location of the drawn text.</param>
	/// <param name="format">
	///   <see cref="T:System.Drawing.StringFormat" /> that specifies formatting attributes, such as line spacing and alignment, that are applied to the drawn text.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="brush" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="s" /> is <see langword="null" />.</exception>
	public void DrawString(string s, Font font, Brush brush, RectangleF layoutRectangle, StringFormat format)
	{
	}

	/// <summary>Fills the interior of an ellipse defined by a bounding rectangle specified by a <see cref="T:System.Drawing.Rectangle" /> structure.</summary>
	/// <param name="brush">
	///   <see cref="T:System.Drawing.Brush" /> that determines the characteristics of the fill.</param>
	/// <param name="rect">
	///   <see cref="T:System.Drawing.Rectangle" /> structure that represents the bounding rectangle that defines the ellipse.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="brush" /> is <see langword="null" />.</exception>
	public void FillEllipse(Brush brush, Rectangle rect)
	{
	}

	/// <summary>Fills the interior of an ellipse defined by a bounding rectangle specified by a pair of coordinates, a width, and a height.</summary>
	/// <param name="brush">
	///   <see cref="T:System.Drawing.Brush" /> that determines the characteristics of the fill.</param>
	/// <param name="x">The x-coordinate of the upper-left corner of the bounding rectangle that defines the ellipse.</param>
	/// <param name="y">The y-coordinate of the upper-left corner of the bounding rectangle that defines the ellipse.</param>
	/// <param name="width">Width of the bounding rectangle that defines the ellipse.</param>
	/// <param name="height">Height of the bounding rectangle that defines the ellipse.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="brush" /> is <see langword="null" />.</exception>
	public void FillEllipse(Brush brush, int x, int y, int width, int height)
	{
	}

	/// <summary>Fills the interior of a polygon defined by an array of points specified by <see cref="T:System.Drawing.PointF" /> structures.</summary>
	/// <param name="brush">
	///   <see cref="T:System.Drawing.Brush" /> that determines the characteristics of the fill.</param>
	/// <param name="points">Array of <see cref="T:System.Drawing.PointF" /> structures that represent the vertices of the polygon to fill.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="brush" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="points" /> is <see langword="null" />.</exception>
	public void FillPolygon(Brush brush, PointF[] points)
	{
	}

	/// <summary>Fills the interior of a polygon defined by an array of points specified by <see cref="T:System.Drawing.Point" /> structures using the specified fill mode.</summary>
	/// <param name="brush">
	///   <see cref="T:System.Drawing.Brush" /> that determines the characteristics of the fill.</param>
	/// <param name="points">Array of <see cref="T:System.Drawing.Point" /> structures that represent the vertices of the polygon to fill.</param>
	/// <param name="fillMode">Member of the <see cref="T:System.Drawing.Drawing2D.FillMode" /> enumeration that determines the style of the fill.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="brush" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="points" /> is <see langword="null" />.</exception>
	public void FillPolygon(Brush brush, Point[] points, FillMode fillMode)
	{
	}

	/// <summary>Fills the interior of a rectangle specified by a <see cref="T:System.Drawing.Rectangle" /> structure.</summary>
	/// <param name="brush">
	///   <see cref="T:System.Drawing.Brush" /> that determines the characteristics of the fill.</param>
	/// <param name="rect">
	///   <see cref="T:System.Drawing.Rectangle" /> structure that represents the rectangle to fill.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="brush" /> is <see langword="null" />.</exception>
	public void FillRectangle(Brush brush, Rectangle rect)
	{
	}

	/// <summary>Fills the interior of a rectangle specified by a pair of coordinates, a width, and a height.</summary>
	/// <param name="brush">
	///   <see cref="T:System.Drawing.Brush" /> that determines the characteristics of the fill.</param>
	/// <param name="x">The x-coordinate of the upper-left corner of the rectangle to fill.</param>
	/// <param name="y">The y-coordinate of the upper-left corner of the rectangle to fill.</param>
	/// <param name="width">Width of the rectangle to fill.</param>
	/// <param name="height">Height of the rectangle to fill.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="brush" /> is <see langword="null" />.</exception>
	public void FillRectangle(Brush brush, int x, int y, int width, int height)
	{
	}

	/// <summary>Fills the interior of a rectangle specified by a pair of coordinates, a width, and a height.</summary>
	/// <param name="brush">
	///   <see cref="T:System.Drawing.Brush" /> that determines the characteristics of the fill.</param>
	/// <param name="x">The x-coordinate of the upper-left corner of the rectangle to fill.</param>
	/// <param name="y">The y-coordinate of the upper-left corner of the rectangle to fill.</param>
	/// <param name="width">Width of the rectangle to fill.</param>
	/// <param name="height">Height of the rectangle to fill.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="brush" /> is <see langword="null" />.</exception>
	public void FillRectangle(Brush brush, float x, float y, float width, float height)
	{
	}

	/// <summary>Forces execution of all pending graphics operations and returns immediately without waiting for the operations to finish.</summary>
	public void Flush()
	{
	}

	/// <summary>Forces execution of all pending graphics operations with the method waiting or not waiting, as specified, to return before the operations finish.</summary>
	/// <param name="intention">Member of the <see cref="T:System.Drawing.Drawing2D.FlushIntention" /> enumeration that specifies whether the method returns immediately or waits for any existing operations to finish.</param>
	public void Flush(FlushIntention intention)
	{
	}

	/// <summary>Creates a new <see cref="T:System.Drawing.Graphics" /> from the specified handle to a device context.</summary>
	/// <param name="hdc">Handle to a device context.</param>
	/// <returns>This method returns a new <see cref="T:System.Drawing.Graphics" /> for the specified device context.</returns>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static Graphics FromHdc(IntPtr hdc)
	{
		return null;
	}

	/// <summary>Returns a <see cref="T:System.Drawing.Graphics" /> for the specified device context.</summary>
	/// <param name="hdc">Handle to a device context.</param>
	/// <returns>A <see cref="T:System.Drawing.Graphics" /> for the specified device context.</returns>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static Graphics FromHdcInternal(IntPtr hdc)
	{
		return null;
	}

	/// <summary>Creates a new <see cref="T:System.Drawing.Graphics" /> from the specified handle to a window.</summary>
	/// <param name="hwnd">Handle to a window.</param>
	/// <returns>This method returns a new <see cref="T:System.Drawing.Graphics" /> for the specified window handle.</returns>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static Graphics FromHwnd(IntPtr hwnd)
	{
		return null;
	}

	/// <summary>Creates a new <see cref="T:System.Drawing.Graphics" /> from the specified <see cref="T:System.Drawing.Image" />.</summary>
	/// <param name="image">
	///   <see cref="T:System.Drawing.Image" /> from which to create the new <see cref="T:System.Drawing.Graphics" />.</param>
	/// <returns>This method returns a new <see cref="T:System.Drawing.Graphics" /> for the specified <see cref="T:System.Drawing.Image" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="image" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Exception">
	///   <paramref name="image" /> has an indexed pixel format or its format is undefined.</exception>
	public static Graphics FromImage(Image image)
	{
		return null;
	}

	internal static Graphics FromXDrawable(IntPtr drawable, IntPtr display)
	{
		return null;
	}

	/// <summary>Gets the handle to the device context associated with this <see cref="T:System.Drawing.Graphics" />.</summary>
	/// <returns>Handle to the device context associated with this <see cref="T:System.Drawing.Graphics" />.</returns>
	public IntPtr GetHdc()
	{
		return (IntPtr)0;
	}

	private SizeF GdipMeasureString(IntPtr graphics, string text, Font font, ref RectangleF layoutRect, IntPtr stringFormat)
	{
		return default(SizeF);
	}

	/// <summary>Measures the specified string when drawn with the specified <see cref="T:System.Drawing.Font" />.</summary>
	/// <param name="text">String to measure.</param>
	/// <param name="font">
	///   <see cref="T:System.Drawing.Font" /> that defines the text format of the string.</param>
	/// <returns>This method returns a <see cref="T:System.Drawing.SizeF" /> structure that represents the size, in the units specified by the <see cref="P:System.Drawing.Graphics.PageUnit" /> property, of the string specified by the <paramref name="text" /> parameter as drawn with the <paramref name="font" /> parameter.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="font" /> is <see langword="null" />.</exception>
	public SizeF MeasureString(string text, Font font)
	{
		return default(SizeF);
	}

	/// <summary>Measures the specified string when drawn with the specified <see cref="T:System.Drawing.Font" /> within the specified layout area.</summary>
	/// <param name="text">String to measure.</param>
	/// <param name="font">
	///   <see cref="T:System.Drawing.Font" /> defines the text format of the string.</param>
	/// <param name="layoutArea">
	///   <see cref="T:System.Drawing.SizeF" /> structure that specifies the maximum layout area for the text.</param>
	/// <returns>This method returns a <see cref="T:System.Drawing.SizeF" /> structure that represents the size, in the units specified by the <see cref="P:System.Drawing.Graphics.PageUnit" /> property, of the string specified by the <paramref name="text" /> parameter as drawn with the <paramref name="font" /> parameter.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="font" /> is <see langword="null" />.</exception>
	public SizeF MeasureString(string text, Font font, SizeF layoutArea)
	{
		return default(SizeF);
	}

	/// <summary>Measures the specified string when drawn with the specified <see cref="T:System.Drawing.Font" />.</summary>
	/// <param name="text">String to measure.</param>
	/// <param name="font">
	///   <see cref="T:System.Drawing.Font" /> that defines the format of the string.</param>
	/// <param name="width">Maximum width of the string in pixels.</param>
	/// <returns>This method returns a <see cref="T:System.Drawing.SizeF" /> structure that represents the size, in the units specified by the <see cref="P:System.Drawing.Graphics.PageUnit" /> property, of the string specified in the <paramref name="text" /> parameter as drawn with the <paramref name="font" /> parameter.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="font" /> is <see langword="null" />.</exception>
	public SizeF MeasureString(string text, Font font, int width)
	{
		return default(SizeF);
	}

	/// <summary>Measures the specified string when drawn with the specified <see cref="T:System.Drawing.Font" /> and formatted with the specified <see cref="T:System.Drawing.StringFormat" />.</summary>
	/// <param name="text">String to measure.</param>
	/// <param name="font">
	///   <see cref="T:System.Drawing.Font" /> defines the text format of the string.</param>
	/// <param name="layoutArea">
	///   <see cref="T:System.Drawing.SizeF" /> structure that specifies the maximum layout area for the text.</param>
	/// <param name="stringFormat">
	///   <see cref="T:System.Drawing.StringFormat" /> that represents formatting information, such as line spacing, for the string.</param>
	/// <returns>This method returns a <see cref="T:System.Drawing.SizeF" /> structure that represents the size, in the units specified by the <see cref="P:System.Drawing.Graphics.PageUnit" /> property, of the string specified in the <paramref name="text" /> parameter as drawn with the <paramref name="font" /> parameter and the <paramref name="stringFormat" /> parameter.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="font" /> is <see langword="null" />.</exception>
	public SizeF MeasureString(string text, Font font, SizeF layoutArea, StringFormat stringFormat)
	{
		return default(SizeF);
	}

	/// <summary>Measures the specified string when drawn with the specified <see cref="T:System.Drawing.Font" /> and formatted with the specified <see cref="T:System.Drawing.StringFormat" />.</summary>
	/// <param name="text">String to measure.</param>
	/// <param name="font">
	///   <see cref="T:System.Drawing.Font" /> that defines the text format of the string.</param>
	/// <param name="width">Maximum width of the string.</param>
	/// <param name="format">
	///   <see cref="T:System.Drawing.StringFormat" /> that represents formatting information, such as line spacing, for the string.</param>
	/// <returns>This method returns a <see cref="T:System.Drawing.SizeF" /> structure that represents the size, in the units specified by the <see cref="P:System.Drawing.Graphics.PageUnit" /> property, of the string specified in the <paramref name="text" /> parameter as drawn with the <paramref name="font" /> parameter and the <paramref name="stringFormat" /> parameter.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="font" /> is <see langword="null" />.</exception>
	public SizeF MeasureString(string text, Font font, int width, StringFormat format)
	{
		return default(SizeF);
	}

	/// <summary>Releases a device context handle obtained by a previous call to the <see cref="M:System.Drawing.Graphics.GetHdc" /> method of this <see cref="T:System.Drawing.Graphics" />.</summary>
	/// <param name="hdc">Handle to a device context obtained by a previous call to the <see cref="M:System.Drawing.Graphics.GetHdc" /> method of this <see cref="T:System.Drawing.Graphics" />.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void ReleaseHdc(IntPtr hdc)
	{
	}

	/// <summary>Releases a device context handle obtained by a previous call to the <see cref="M:System.Drawing.Graphics.GetHdc" /> method of this <see cref="T:System.Drawing.Graphics" />.</summary>
	public void ReleaseHdc()
	{
	}

	/// <summary>Releases a handle to a device context.</summary>
	/// <param name="hdc">Handle to a device context.</param>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[System.MonoLimitation("Can only be used when hdc was provided by Graphics.GetHdc() method")]
	public void ReleaseHdcInternal(IntPtr hdc)
	{
	}

	/// <summary>Resets the clip region of this <see cref="T:System.Drawing.Graphics" /> to an infinite region.</summary>
	public void ResetClip()
	{
	}

	/// <summary>Resets the world transformation matrix of this <see cref="T:System.Drawing.Graphics" /> to the identity matrix.</summary>
	public void ResetTransform()
	{
	}

	/// <summary>Restores the state of this <see cref="T:System.Drawing.Graphics" /> to the state represented by a <see cref="T:System.Drawing.Drawing2D.GraphicsState" />.</summary>
	/// <param name="gstate">
	///   <see cref="T:System.Drawing.Drawing2D.GraphicsState" /> that represents the state to which to restore this <see cref="T:System.Drawing.Graphics" />.</param>
	public void Restore(GraphicsState gstate)
	{
	}

	/// <summary>Applies the specified rotation to the transformation matrix of this <see cref="T:System.Drawing.Graphics" />.</summary>
	/// <param name="angle">Angle of rotation in degrees.</param>
	public void RotateTransform(float angle)
	{
	}

	/// <summary>Applies the specified rotation to the transformation matrix of this <see cref="T:System.Drawing.Graphics" /> in the specified order.</summary>
	/// <param name="angle">Angle of rotation in degrees.</param>
	/// <param name="order">Member of the <see cref="T:System.Drawing.Drawing2D.MatrixOrder" /> enumeration that specifies whether the rotation is appended or prepended to the matrix transformation.</param>
	public void RotateTransform(float angle, MatrixOrder order)
	{
	}

	/// <summary>Saves the current state of this <see cref="T:System.Drawing.Graphics" /> and identifies the saved state with a <see cref="T:System.Drawing.Drawing2D.GraphicsState" />.</summary>
	/// <returns>This method returns a <see cref="T:System.Drawing.Drawing2D.GraphicsState" /> that represents the saved state of this <see cref="T:System.Drawing.Graphics" />.</returns>
	public GraphicsState Save()
	{
		return null;
	}

	/// <summary>Sets the clipping region of this <see cref="T:System.Drawing.Graphics" /> to the rectangle specified by a <see cref="T:System.Drawing.Rectangle" /> structure.</summary>
	/// <param name="rect">
	///   <see cref="T:System.Drawing.Rectangle" /> structure that represents the new clip region.</param>
	public void SetClip(Rectangle rect)
	{
	}

	/// <summary>Sets the clipping region of this <see cref="T:System.Drawing.Graphics" /> to the result of the specified operation combining the current clip region and the rectangle specified by a <see cref="T:System.Drawing.Rectangle" /> structure.</summary>
	/// <param name="rect">
	///   <see cref="T:System.Drawing.Rectangle" /> structure to combine.</param>
	/// <param name="combineMode">Member of the <see cref="T:System.Drawing.Drawing2D.CombineMode" /> enumeration that specifies the combining operation to use.</param>
	public void SetClip(Rectangle rect, CombineMode combineMode)
	{
	}

	/// <summary>Sets the clipping region of this <see cref="T:System.Drawing.Graphics" /> to the result of the specified operation combining the current clip region and the specified <see cref="T:System.Drawing.Region" />.</summary>
	/// <param name="region">
	///   <see cref="T:System.Drawing.Region" /> to combine.</param>
	/// <param name="combineMode">Member from the <see cref="T:System.Drawing.Drawing2D.CombineMode" /> enumeration that specifies the combining operation to use.</param>
	public void SetClip(Region region, CombineMode combineMode)
	{
	}

	/// <summary>Changes the origin of the coordinate system by prepending the specified translation to the transformation matrix of this <see cref="T:System.Drawing.Graphics" />.</summary>
	/// <param name="dx">The x-coordinate of the translation.</param>
	/// <param name="dy">The y-coordinate of the translation.</param>
	public void TranslateTransform(float dx, float dy)
	{
	}

	/// <summary>Changes the origin of the coordinate system by applying the specified translation to the transformation matrix of this <see cref="T:System.Drawing.Graphics" /> in the specified order.</summary>
	/// <param name="dx">The x-coordinate of the translation.</param>
	/// <param name="dy">The y-coordinate of the translation.</param>
	/// <param name="order">Member of the <see cref="T:System.Drawing.Drawing2D.MatrixOrder" /> enumeration that specifies whether the translation is prepended or appended to the transformation matrix.</param>
	public void TranslateTransform(float dx, float dy, MatrixOrder order)
	{
	}
}
