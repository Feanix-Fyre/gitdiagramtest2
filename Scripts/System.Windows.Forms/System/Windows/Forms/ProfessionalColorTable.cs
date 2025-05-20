using System.Drawing;

namespace System.Windows.Forms;

/// <summary>Provides colors used for Microsoft Office display elements.</summary>
public class ProfessionalColorTable
{
	private enum ColorSchemes
	{
		Classic = 0,
		NormalColor = 1,
		HomeStead = 2,
		Metallic = 3,
		MediaCenter = 4,
		Aero = 5
	}

	private bool use_system_colors;

	private Color button_checked_gradient_begin;

	private Color button_checked_gradient_end;

	private Color button_checked_gradient_middle;

	private Color button_checked_highlight;

	private Color button_checked_highlight_border;

	private Color button_pressed_border;

	private Color button_pressed_gradient_begin;

	private Color button_pressed_gradient_end;

	private Color button_pressed_gradient_middle;

	private Color button_pressed_highlight;

	private Color button_pressed_highlight_border;

	private Color button_selected_border;

	private Color button_selected_gradient_begin;

	private Color button_selected_gradient_end;

	private Color button_selected_gradient_middle;

	private Color button_selected_highlight;

	private Color button_selected_highlight_border;

	private Color check_background;

	private Color check_pressed_background;

	private Color check_selected_background;

	private Color grip_dark;

	private Color grip_light;

	private Color image_margin_gradient_begin;

	private Color image_margin_gradient_end;

	private Color image_margin_gradient_middle;

	private Color image_margin_revealed_gradient_begin;

	private Color image_margin_revealed_gradient_end;

	private Color image_margin_revealed_gradient_middle;

	private Color menu_border;

	private Color menu_item_border;

	private Color menu_item_pressed_gradient_begin;

	private Color menu_item_pressed_gradient_end;

	private Color menu_item_pressed_gradient_middle;

	private Color menu_item_selected;

	private Color menu_item_selected_gradient_begin;

	private Color menu_item_selected_gradient_end;

	private Color menu_strip_gradient_begin;

	private Color menu_strip_gradient_end;

	private Color overflow_button_gradient_begin;

	private Color overflow_button_gradient_end;

	private Color overflow_button_gradient_middle;

	private Color rafting_container_gradient_begin;

	private Color rafting_container_gradient_end;

	private Color separator_dark;

	private Color separator_light;

	private Color status_strip_gradient_begin;

	private Color status_strip_gradient_end;

	private Color tool_strip_border;

	private Color tool_strip_content_panel_gradient_begin;

	private Color tool_strip_content_panel_gradient_end;

	private Color tool_strip_drop_down_background;

	private Color tool_strip_gradient_begin;

	private Color tool_strip_gradient_end;

	private Color tool_strip_gradient_middle;

	private Color tool_strip_panel_gradient_begin;

	private Color tool_strip_panel_gradient_end;

	/// <summary>Gets the starting color of the gradient used when the button is checked.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that is the starting color of the gradient used when the button is checked.</returns>
	public virtual Color ButtonCheckedGradientBegin => default(Color);

	/// <summary>Gets the end color of the gradient used when the button is checked.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that is the end color of the gradient used when the button is checked.</returns>
	public virtual Color ButtonCheckedGradientEnd => default(Color);

	/// <summary>Gets the solid color used when the button is checked.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that is the solid color used when the button is checked.</returns>
	public virtual Color ButtonCheckedHighlight => default(Color);

	/// <summary>Gets the border color to use with the <see cref="P:System.Windows.Forms.ProfessionalColorTable.ButtonPressedGradientBegin" />, <see cref="P:System.Windows.Forms.ProfessionalColorTable.ButtonPressedGradientMiddle" />, and <see cref="P:System.Windows.Forms.ProfessionalColorTable.ButtonPressedGradientEnd" /> colors.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that is the border color to use with the <see cref="P:System.Windows.Forms.ProfessionalColorTable.ButtonPressedGradientBegin" />, <see cref="P:System.Windows.Forms.ProfessionalColorTable.ButtonPressedGradientMiddle" />, and <see cref="P:System.Windows.Forms.ProfessionalColorTable.ButtonPressedGradientEnd" /> colors.</returns>
	public virtual Color ButtonPressedBorder => default(Color);

	/// <summary>Gets the starting color of the gradient used when the button is pressed.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that is the starting color of the gradient used when the button is pressed.</returns>
	public virtual Color ButtonPressedGradientBegin => default(Color);

	/// <summary>Gets the end color of the gradient used when the button is pressed.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that is the end color of the gradient used when the button is pressed.</returns>
	public virtual Color ButtonPressedGradientEnd => default(Color);

	/// <summary>Gets the border color to use with the <see cref="P:System.Windows.Forms.ProfessionalColorTable.ButtonSelectedGradientBegin" />, <see cref="P:System.Windows.Forms.ProfessionalColorTable.ButtonSelectedGradientMiddle" />, and <see cref="P:System.Windows.Forms.ProfessionalColorTable.ButtonSelectedGradientEnd" /> colors.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that is the border color to use with the <see cref="P:System.Windows.Forms.ProfessionalColorTable.ButtonSelectedGradientBegin" />, <see cref="P:System.Windows.Forms.ProfessionalColorTable.ButtonSelectedGradientMiddle" />, and <see cref="P:System.Windows.Forms.ProfessionalColorTable.ButtonSelectedGradientEnd" /> colors.</returns>
	public virtual Color ButtonSelectedBorder => default(Color);

	/// <summary>Gets the starting color of the gradient used when the button is selected.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that is the starting color of the gradient used when the button is selected.</returns>
	public virtual Color ButtonSelectedGradientBegin => default(Color);

	/// <summary>Gets the end color of the gradient used when the button is selected.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that is the end color of the gradient used when the button is selected.</returns>
	public virtual Color ButtonSelectedGradientEnd => default(Color);

	/// <summary>Gets the solid color to use when the button is checked and selected and gradients are being used.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that is the solid color to use when the button is checked and selected and gradients are being used.</returns>
	public virtual Color CheckPressedBackground => default(Color);

	/// <summary>Gets the solid color to use when the button is checked and selected and gradients are being used.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that is the solid color to use when the button is checked and selected and gradients are being used.</returns>
	public virtual Color CheckSelectedBackground => default(Color);

	/// <summary>Gets the color to use for shadow effects on the grip (move handle).</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that is the color to use for shadow effects on the grip (move handle).</returns>
	public virtual Color GripDark => default(Color);

	/// <summary>Gets the color to use for highlight effects on the grip (move handle).</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that is the color to use for highlight effects on the grip (move handle).</returns>
	public virtual Color GripLight => default(Color);

	/// <summary>Gets the end color of the gradient used in the image margin of a <see cref="T:System.Windows.Forms.ToolStripDropDownMenu" />.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that is the end color of the gradient used in the image margin of a <see cref="T:System.Windows.Forms.ToolStripDropDownMenu" />.</returns>
	public virtual Color ImageMarginGradientEnd => default(Color);

	/// <summary>Gets the middle color of the gradient used in the image margin of a <see cref="T:System.Windows.Forms.ToolStripDropDownMenu" />.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that is the middle color of the gradient used in the image margin of a <see cref="T:System.Windows.Forms.ToolStripDropDownMenu" />.</returns>
	public virtual Color ImageMarginGradientMiddle => default(Color);

	/// <summary>Gets the color that is the border color to use on a <see cref="T:System.Windows.Forms.MenuStrip" />.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that is the border color to use on a <see cref="T:System.Windows.Forms.MenuStrip" />.</returns>
	public virtual Color MenuBorder => default(Color);

	/// <summary>Gets the border color to use with a <see cref="T:System.Windows.Forms.ToolStripMenuItem" />.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that is the border color to use with a <see cref="T:System.Windows.Forms.ToolStripMenuItem" />.</returns>
	public virtual Color MenuItemBorder => default(Color);

	/// <summary>Gets the end color of the gradient used when the <see cref="T:System.Windows.Forms.ToolStripMenuItem" /> is selected.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that is the end color of the gradient used when the <see cref="T:System.Windows.Forms.ToolStripMenuItem" /> is selected.</returns>
	public virtual Color MenuItemSelectedGradientEnd => default(Color);

	/// <summary>Gets the starting color of the gradient used in the <see cref="T:System.Windows.Forms.MenuStrip" />.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that is the starting color of the gradient used in the <see cref="T:System.Windows.Forms.MenuStrip" />.</returns>
	public virtual Color MenuStripGradientBegin => default(Color);

	/// <summary>Gets the end color of the gradient used in the <see cref="T:System.Windows.Forms.MenuStrip" />.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that is the end color of the gradient used in the <see cref="T:System.Windows.Forms.MenuStrip" />.</returns>
	public virtual Color MenuStripGradientEnd => default(Color);

	/// <summary>Gets the starting color of the gradient used in the <see cref="T:System.Windows.Forms.ToolStripOverflowButton" />.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that is the starting color of the gradient used in the <see cref="T:System.Windows.Forms.ToolStripOverflowButton" />.</returns>
	public virtual Color OverflowButtonGradientBegin => default(Color);

	/// <summary>Gets the end color of the gradient used in the <see cref="T:System.Windows.Forms.ToolStripOverflowButton" />.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that is the end color of the gradient used in the <see cref="T:System.Windows.Forms.ToolStripOverflowButton" />.</returns>
	public virtual Color OverflowButtonGradientEnd => default(Color);

	/// <summary>Gets the color to use to for shadow effects on the <see cref="T:System.Windows.Forms.ToolStripSeparator" />.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that is the color to use to for shadow effects on the <see cref="T:System.Windows.Forms.ToolStripSeparator" />.</returns>
	public virtual Color SeparatorDark => default(Color);

	/// <summary>Gets the color to use to for highlight effects on the <see cref="T:System.Windows.Forms.ToolStripSeparator" />.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that is the color to use to for highlight effects on the <see cref="T:System.Windows.Forms.ToolStripSeparator" />.</returns>
	public virtual Color SeparatorLight => default(Color);

	/// <summary>Gets the border color to use on the bottom edge of the <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that is the border color to use on the bottom edge of the <see cref="T:System.Windows.Forms.ToolStrip" />.</returns>
	public virtual Color ToolStripBorder => default(Color);

	/// <summary>Gets the solid background color of the <see cref="T:System.Windows.Forms.ToolStripDropDown" />.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that is the solid background color of the <see cref="T:System.Windows.Forms.ToolStripDropDown" />.</returns>
	public virtual Color ToolStripDropDownBackground => default(Color);

	/// <summary>Gets the starting color of the gradient used in the <see cref="T:System.Windows.Forms.ToolStrip" /> background.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that is the starting color of the gradient used in the <see cref="T:System.Windows.Forms.ToolStrip" /> background.</returns>
	public virtual Color ToolStripGradientBegin => default(Color);

	/// <summary>Gets the end color of the gradient used in the <see cref="T:System.Windows.Forms.ToolStrip" /> background.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that is the end color of the gradient used in the <see cref="T:System.Windows.Forms.ToolStrip" /> background.</returns>
	public virtual Color ToolStripGradientEnd => default(Color);

	/// <summary>Gets or sets a value indicating whether to use <see cref="T:System.Drawing.SystemColors" /> rather than colors that match the current visual style.</summary>
	/// <returns>
	///   <see langword="true" /> to use <see cref="T:System.Drawing.SystemColors" />; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	public bool UseSystemColors => false;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ProfessionalColorTable" /> class.</summary>
	public ProfessionalColorTable()
	{
	}

	private void CalculateColors()
	{
	}

	private ColorSchemes GetCurrentStyle()
	{
		return default(ColorSchemes);
	}
}
