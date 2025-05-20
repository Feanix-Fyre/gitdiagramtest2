using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;

namespace System.Windows.Forms;

/// <summary>Handles the painting functionality for <see cref="T:System.Windows.Forms.ToolStrip" /> objects.</summary>
public abstract class ToolStripRenderer
{
	private static ColorMatrix grayscale_matrix;

	private EventHandlerList events;

	private static object RenderArrowEvent;

	private static object RenderButtonBackgroundEvent;

	private static object RenderDropDownButtonBackgroundEvent;

	private static object RenderGripEvent;

	private static object RenderImageMarginEvent;

	private static object RenderItemBackgroundEvent;

	private static object RenderItemCheckEvent;

	private static object RenderItemImageEvent;

	private static object RenderItemTextEvent;

	private static object RenderLabelBackgroundEvent;

	private static object RenderMenuItemBackgroundEvent;

	private static object RenderOverflowButtonBackgroundEvent;

	private static object RenderSeparatorEvent;

	private static object RenderSplitButtonBackgroundEvent;

	private static object RenderStatusStripSizingGripEvent;

	private static object RenderToolStripBackgroundEvent;

	private static object RenderToolStripBorderEvent;

	private static object RenderToolStripContentPanelBackgroundEvent;

	private static object RenderToolStripPanelBackgroundEvent;

	private static object RenderToolStripStatusLabelBackgroundEvent;

	private EventHandlerList Events => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ToolStripRenderer" /> class.</summary>
	protected ToolStripRenderer()
	{
	}

	/// <summary>Creates a gray-scale copy of a given image.</summary>
	/// <param name="normalImage">The image to be copied.</param>
	/// <returns>An <see cref="T:System.Drawing.Image" /> that is a copy of the given image, but with a gray-scale color matrix.</returns>
	public static Image CreateDisabledImage(Image normalImage)
	{
		return null;
	}

	/// <summary>Draws an arrow on a <see cref="T:System.Windows.Forms.ToolStripItem" />.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripArrowRenderEventArgs" /> that contains data to draw the arrow.</param>
	public void DrawArrow(ToolStripArrowRenderEventArgs e)
	{
	}

	/// <summary>Draws the background for a <see cref="T:System.Windows.Forms.ToolStripButton" />.</summary>
	/// <param name="e">The <see cref="T:System.Windows.Forms.ToolStripItemRenderEventArgs" /> that contains data to draw the button's background.</param>
	public void DrawButtonBackground(ToolStripItemRenderEventArgs e)
	{
	}

	/// <summary>Draws the background for a <see cref="T:System.Windows.Forms.ToolStripDropDownButton" />.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripItemRenderEventArgs" /> that contains the data to draw the drop-down button's background.</param>
	public void DrawDropDownButtonBackground(ToolStripItemRenderEventArgs e)
	{
	}

	/// <summary>Draws a move handle on a <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripGripRenderEventArgs" /> that contains the data to draw the move handle.</param>
	public void DrawGrip(ToolStripGripRenderEventArgs e)
	{
	}

	/// <summary>Draws the space around an image on a <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripRenderEventArgs" /> that contains the data to draw the space around the image.</param>
	public void DrawImageMargin(ToolStripRenderEventArgs e)
	{
	}

	/// <summary>Draws the background for a <see cref="T:System.Windows.Forms.ToolStripItem" />.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripItemRenderEventArgs" /> that contains the data to draw the background of the item.</param>
	public void DrawItemBackground(ToolStripItemRenderEventArgs e)
	{
	}

	/// <summary>Draws an image on a <see cref="T:System.Windows.Forms.ToolStripItem" /> that indicates the item is in a selected state.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripItemImageRenderEventArgs" /> that contains the data to draw the selected image.</param>
	public void DrawItemCheck(ToolStripItemImageRenderEventArgs e)
	{
	}

	/// <summary>Draws an image on a <see cref="T:System.Windows.Forms.ToolStripItem" />.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripItemImageRenderEventArgs" /> that contains the data to draw the image.</param>
	public void DrawItemImage(ToolStripItemImageRenderEventArgs e)
	{
	}

	/// <summary>Draws text on a <see cref="T:System.Windows.Forms.ToolStripItem" />.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripItemTextRenderEventArgs" /> that contains the data to draw the text.</param>
	public void DrawItemText(ToolStripItemTextRenderEventArgs e)
	{
	}

	/// <summary>Draws the background for a <see cref="T:System.Windows.Forms.ToolStripMenuItem" />.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripItemRenderEventArgs" /> that contains the data to draw the background for the menu item.</param>
	public void DrawMenuItemBackground(ToolStripItemRenderEventArgs e)
	{
	}

	/// <summary>Draws the background for an overflow button.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripItemRenderEventArgs" /> that contains the event data.</param>
	public void DrawOverflowButtonBackground(ToolStripItemRenderEventArgs e)
	{
	}

	/// <summary>Draws a <see cref="T:System.Windows.Forms.ToolStripSeparator" />.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripSeparatorRenderEventArgs" /> that contains the data to draw the <see cref="T:System.Windows.Forms.ToolStripSeparator" />.</param>
	public void DrawSeparator(ToolStripSeparatorRenderEventArgs e)
	{
	}

	/// <summary>Draws the background for a <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripRenderEventArgs" /> that contains the data to draw the background for the <see cref="T:System.Windows.Forms.ToolStrip" />.</param>
	public void DrawToolStripBackground(ToolStripRenderEventArgs e)
	{
	}

	/// <summary>Draws the border for a <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripRenderEventArgs" /> that contains the data to draw the border for the <see cref="T:System.Windows.Forms.ToolStrip" />.</param>
	public void DrawToolStripBorder(ToolStripRenderEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripRenderer.RenderArrow" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripArrowRenderEventArgs" /> that contains the event data.</param>
	protected virtual void OnRenderArrow(ToolStripArrowRenderEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripRenderer.RenderButtonBackground" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripRenderEventArgs" /> that contains the event data.</param>
	protected virtual void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripRenderer.RenderDropDownButtonBackground" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripItemRenderEventArgs" /> that contains the event data.</param>
	protected virtual void OnRenderDropDownButtonBackground(ToolStripItemRenderEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripRenderer.RenderGrip" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripGripRenderEventArgs" /> that contains the event data.</param>
	protected virtual void OnRenderGrip(ToolStripGripRenderEventArgs e)
	{
	}

	/// <summary>Draws the item background.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripRenderEventArgs" /> that contains the event data.</param>
	protected virtual void OnRenderImageMargin(ToolStripRenderEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="M:System.Windows.Forms.ToolStripSystemRenderer.OnRenderItemBackground(System.Windows.Forms.ToolStripItemRenderEventArgs)" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripItemRenderEventArgs" /> that contains the event data.</param>
	protected virtual void OnRenderItemBackground(ToolStripItemRenderEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripRenderer.RenderItemCheck" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripItemImageRenderEventArgs" /> that contains the event data.</param>
	protected virtual void OnRenderItemCheck(ToolStripItemImageRenderEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripRenderer.RenderItemImage" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripItemImageRenderEventArgs" /> that contains the event data.</param>
	protected virtual void OnRenderItemImage(ToolStripItemImageRenderEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripRenderer.RenderItemText" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripItemTextRenderEventArgs" /> that contains the event data.</param>
	protected virtual void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripRenderer.RenderMenuItemBackground" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripItemRenderEventArgs" /> that contains the event data.</param>
	protected virtual void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripRenderer.RenderOverflowButtonBackground" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripItemRenderEventArgs" /> that contains the event data.</param>
	protected virtual void OnRenderOverflowButtonBackground(ToolStripItemRenderEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripRenderer.RenderSeparator" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripSeparatorRenderEventArgs" /> that contains the event data.</param>
	protected virtual void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripRenderer.RenderToolStripBackground" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripRenderEventArgs" /> that contains the event data.</param>
	protected virtual void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripRenderer.RenderToolStripBorder" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripRenderEventArgs" /> that contains the event data.</param>
	protected virtual void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
	{
	}

	internal static Image CreateMirrorImage(Image normalImage)
	{
		return null;
	}

	private void DrawBackground(Graphics g, Rectangle bounds, Image image, ImageLayout layout)
	{
	}

	internal static void DrawRightArrow(Graphics g, Pen p, int x, int y)
	{
	}

	internal static void DrawDownArrow(Graphics g, Pen p, int x, int y)
	{
	}
}
