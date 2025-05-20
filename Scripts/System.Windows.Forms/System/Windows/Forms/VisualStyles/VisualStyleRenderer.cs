using System.Drawing;

namespace System.Windows.Forms.VisualStyles;

/// <summary>Provides methods for drawing and getting information about a <see cref="T:System.Windows.Forms.VisualStyles.VisualStyleElement" />. This class cannot be inherited.</summary>
public sealed class VisualStyleRenderer
{
	private class ThemeHandleManager
	{
		public VisualStyleRenderer VisualStyleRenderer;

		~ThemeHandleManager()
		{
		}
	}

	private string class_name;

	private int part;

	private int state;

	private IntPtr theme;

	private int last_hresult;

	private ThemeHandleManager theme_handle_manager;

	/// <summary>Gets a unique identifier for the current class of visual style elements.</summary>
	/// <returns>An <see cref="T:System.IntPtr" /> that identifies a set of data that defines the class of elements specified by <see cref="P:System.Windows.Forms.VisualStyles.VisualStyleRenderer.Class" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">The operating system does not support visual styles.  
	///  -or-  
	///  Visual styles are disabled by the user in the operating system.  
	///  -or-  
	///  Visual styles are not applied to the client area of application windows.</exception>
	public IntPtr Handle => (IntPtr)0;

	/// <summary>Gets a value specifying whether the operating system is using visual styles to draw controls.</summary>
	/// <returns>
	///   <see langword="true" /> if the operating system supports visual styles, the user has enabled visual styles in the operating system, and visual styles are applied to the client area of application windows; otherwise, <see langword="false" />.</returns>
	public static bool IsSupported => false;

	internal static IVisualStyles VisualStyles => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.VisualStyles.VisualStyleRenderer" /> class using the given class, part, and state values.</summary>
	/// <param name="className">The class name of the element that this <see cref="T:System.Windows.Forms.VisualStyles.VisualStyleRenderer" /> will represent.</param>
	/// <param name="part">The part of the element that this <see cref="T:System.Windows.Forms.VisualStyles.VisualStyleRenderer" /> will represent.</param>
	/// <param name="state">The state of the element that this <see cref="T:System.Windows.Forms.VisualStyles.VisualStyleRenderer" /> will represent.</param>
	/// <exception cref="T:System.InvalidOperationException">The operating system does not support visual styles.  
	///  -or-  
	///  Visual styles are disabled by the user in the operating system.  
	///  -or-  
	///  Visual styles are not applied to the client area of application windows.</exception>
	/// <exception cref="T:System.ArgumentException">The combination of <paramref name="className" />, <paramref name="part" />, and <paramref name="state" /> is not defined by the current visual style.</exception>
	public VisualStyleRenderer(string className, int part, int state)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.VisualStyles.VisualStyleRenderer" /> class using the given <see cref="T:System.Windows.Forms.VisualStyles.VisualStyleElement" />.</summary>
	/// <param name="element">A <see cref="T:System.Windows.Forms.VisualStyles.VisualStyleElement" /> that this <see cref="T:System.Windows.Forms.VisualStyles.VisualStyleRenderer" /> will represent.</param>
	/// <exception cref="T:System.InvalidOperationException">The operating system does not support visual styles.  
	///  -or-  
	///  Visual styles are disabled by the user in the operating system.  
	///  -or-  
	///  Visual styles are not applied to the client area of application windows.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="element" /> is not defined by the current visual style.</exception>
	public VisualStyleRenderer(VisualStyleElement element)
	{
	}

	/// <summary>Determines whether the specified visual style element is defined by the current visual style.</summary>
	/// <param name="element">A <see cref="T:System.Windows.Forms.VisualStyles.VisualStyleElement" /> whose class and part combination will be verified.</param>
	/// <returns>
	///   <see langword="true" /> if the combination of the <see cref="P:System.Windows.Forms.VisualStyles.VisualStyleElement.ClassName" /> and <see cref="P:System.Windows.Forms.VisualStyles.VisualStyleElement.Part" /> properties of <paramref name="element" /> are defined; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">The operating system does not support visual styles.  
	///  -or-  
	///  Visual styles are disabled by the user in the operating system.  
	///  -or-  
	///  Visual styles are not applied to the client area of application windows.</exception>
	public static bool IsElementDefined(VisualStyleElement element)
	{
		return false;
	}

	/// <summary>Draws the background image of the current visual style element within the specified bounding rectangle.</summary>
	/// <param name="dc">The <see cref="T:System.Drawing.IDeviceContext" /> used to draw the background image.</param>
	/// <param name="bounds">A <see cref="T:System.Drawing.Rectangle" /> in which the background image is drawn.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="dc" /> is <see langword="null" />.</exception>
	public void DrawBackground(IDeviceContext dc, Rectangle bounds)
	{
	}

	/// <summary>Draws the background image of the current visual style element within the specified bounding rectangle and clipped to the specified clipping rectangle.</summary>
	/// <param name="dc">The <see cref="T:System.Drawing.IDeviceContext" /> used to draw the background image.</param>
	/// <param name="bounds">A <see cref="T:System.Drawing.Rectangle" /> in which the background image is drawn.</param>
	/// <param name="clipRectangle">A <see cref="T:System.Drawing.Rectangle" /> that defines a clipping rectangle for the drawing operation.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="dc" /> is <see langword="null" />.</exception>
	public void DrawBackground(IDeviceContext dc, Rectangle bounds, Rectangle clipRectangle)
	{
	}

	/// <summary>Draws the specified image within the specified bounds.</summary>
	/// <param name="g">The <see cref="T:System.Drawing.Graphics" /> used to draw the image.</param>
	/// <param name="bounds">A <see cref="T:System.Drawing.Rectangle" /> in which the image is drawn.</param>
	/// <param name="image">The <see cref="T:System.Drawing.Image" /> to draw.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="g" /> or <paramref name="image" /> is <see langword="null" />.</exception>
	public void DrawImage(Graphics g, Rectangle bounds, Image image)
	{
	}

	/// <summary>Draws text in the specified bounding rectangle with the option of displaying disabled text and applying other text formatting.</summary>
	/// <param name="dc">The <see cref="T:System.Drawing.IDeviceContext" /> used to draw the text.</param>
	/// <param name="bounds">A <see cref="T:System.Drawing.Rectangle" /> in which to draw the text.</param>
	/// <param name="textToDraw">The text to draw.</param>
	/// <param name="drawDisabled">
	///   <see langword="true" /> to draw grayed-out text; otherwise, <see langword="false" />.</param>
	/// <param name="flags">A bitwise combination of the <see cref="T:System.Windows.Forms.TextFormatFlags" /> values.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="dc" /> is <see langword="null" />.</exception>
	public void DrawText(IDeviceContext dc, Rectangle bounds, string textToDraw, bool drawDisabled, TextFormatFlags flags)
	{
	}

	/// <summary>Returns the region for the background of the current visual style element.</summary>
	/// <param name="dc">The <see cref="T:System.Drawing.IDeviceContext" /> this operation will use.</param>
	/// <param name="bounds">A <see cref="T:System.Drawing.Rectangle" /> that contains the entire background area of the current visual style element.</param>
	/// <returns>The <see cref="T:System.Drawing.Region" /> that contains the background of the current visual style element.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="dc" /> is <see langword="null" />.</exception>
	public Region GetBackgroundRegion(IDeviceContext dc, Rectangle bounds)
	{
		return null;
	}

	/// <summary>Returns the value of the specified color property for the current visual style element.</summary>
	/// <param name="prop">One of the <see cref="T:System.Windows.Forms.VisualStyles.ColorProperty" /> values that specifies which property value to retrieve for the current visual style element.</param>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that contains the value of the property specified by the <paramref name="prop" /> parameter for the current visual style element.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
	///   <paramref name="prop" /> is not one of the <see cref="T:System.Windows.Forms.VisualStyles.ColorProperty" /> values.</exception>
	public Color GetColor(ColorProperty prop)
	{
		return default(Color);
	}

	/// <summary>Returns the value of the specified size property of the current visual style part.</summary>
	/// <param name="dc">The <see cref="T:System.Drawing.IDeviceContext" /> this operation will use.</param>
	/// <param name="type">One of the <see cref="T:System.Windows.Forms.VisualStyles.ThemeSizeType" /> values that specifies which size value to retrieve for the part.</param>
	/// <returns>A <see cref="T:System.Drawing.Size" /> that contains the size specified by the <paramref name="type" /> parameter for the current visual style part.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="dc" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
	///   <paramref name="prop" /> is not one of the <see cref="T:System.Windows.Forms.VisualStyles.ThemeSizeType" /> values.</exception>
	public Size GetPartSize(IDeviceContext dc, ThemeSizeType type)
	{
		return default(Size);
	}

	/// <summary>Returns the size and location of the specified string when drawn with the font of the current visual style element within the specified initial bounding rectangle.</summary>
	/// <param name="dc">The <see cref="T:System.Drawing.IDeviceContext" /> this operation will use.</param>
	/// <param name="bounds">A <see cref="T:System.Drawing.Rectangle" /> used to control the flow and wrapping of the text.</param>
	/// <param name="textToDraw">The string to measure.</param>
	/// <param name="flags">A bitwise combination of the <see cref="T:System.Windows.Forms.TextFormatFlags" /> values.</param>
	/// <returns>A <see cref="T:System.Drawing.Rectangle" /> that contains the area required to fit the rendered text.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="dc" /> is <see langword="null" />.</exception>
	public Rectangle GetTextExtent(IDeviceContext dc, Rectangle bounds, string textToDraw, TextFormatFlags flags)
	{
		return default(Rectangle);
	}

	/// <summary>Indicates whether the background of the current visual style element has any semitransparent or alpha-blended pieces.</summary>
	/// <returns>
	///   <see langword="true" /> if the background of the current visual style element has any semitransparent or alpha-blended pieces; otherwise, <see langword="false" />.</returns>
	public bool IsBackgroundPartiallyTransparent()
	{
		return false;
	}

	/// <summary>Sets this <see cref="T:System.Windows.Forms.VisualStyles.VisualStyleRenderer" /> to the visual style element represented by the specified class, part, and state values.</summary>
	/// <param name="className">The new value of the <see cref="P:System.Windows.Forms.VisualStyles.VisualStyleRenderer.Class" /> property.</param>
	/// <param name="part">The new value of the <see cref="P:System.Windows.Forms.VisualStyles.VisualStyleRenderer.Part" /> property.</param>
	/// <param name="state">The new value of the <see cref="P:System.Windows.Forms.VisualStyles.VisualStyleRenderer.State" /> property.</param>
	/// <exception cref="T:System.ArgumentException">The combination of <paramref name="className" />, <paramref name="part" />, and <paramref name="state" /> is not defined by the current visual style.</exception>
	/// <exception cref="T:System.InvalidOperationException">The operating system does not support visual styles.  
	///  -or-  
	///  Visual styles are disabled by the user in the operating system.  
	///  -or-  
	///  Visual styles are not applied to the client area of application windows.</exception>
	public void SetParameters(string className, int part, int state)
	{
	}

	/// <summary>Sets this <see cref="T:System.Windows.Forms.VisualStyles.VisualStyleRenderer" /> to the visual style element represented by the specified <see cref="T:System.Windows.Forms.VisualStyles.VisualStyleElement" />.</summary>
	/// <param name="element">A <see cref="T:System.Windows.Forms.VisualStyles.VisualStyleElement" /> that specifies the new values of the <see cref="P:System.Windows.Forms.VisualStyles.VisualStyleRenderer.Class" />, <see cref="P:System.Windows.Forms.VisualStyles.VisualStyleRenderer.Part" />, and <see cref="P:System.Windows.Forms.VisualStyles.VisualStyleRenderer.State" /> properties.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="element" /> is not defined by the current visual style.</exception>
	/// <exception cref="T:System.InvalidOperationException">The operating system does not support visual styles.  
	///  -or-  
	///  Visual styles are disabled by the user in the operating system.  
	///  -or-  
	///  Visual styles are not applied to the client area of application windows.</exception>
	public void SetParameters(VisualStyleElement element)
	{
	}

	internal void DrawBackgroundExcludingArea(IDeviceContext dc, Rectangle bounds, Rectangle excludedArea)
	{
	}

	private static bool IsElementKnownToBeSupported(string className, int part, int state)
	{
		return false;
	}
}
