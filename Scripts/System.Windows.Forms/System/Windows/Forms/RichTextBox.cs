using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms.RTF;

namespace System.Windows.Forms;

/// <summary>Represents a Windows rich text box control.</summary>
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
[Docking(DockingBehavior.Ask)]
[Designer("System.Windows.Forms.Design.RichTextBoxDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.IDesigner")]
public class RichTextBox : TextBoxBase
{
	private class RtfSectionStyle : ICloneable
	{
		internal System.Drawing.Color rtf_color;

		internal System.Windows.Forms.RTF.Font rtf_rtffont;

		internal int rtf_rtffont_size;

		internal FontStyle rtf_rtfstyle;

		internal HorizontalAlignment rtf_rtfalign;

		internal int rtf_par_line_left_indent;

		internal bool rtf_visible;

		internal int rtf_skip_width;

		public object Clone()
		{
			return null;
		}
	}

	private bool reuse_line;

	private StringBuilder rtf_line;

	private RtfSectionStyle rtf_style;

	private Stack rtf_section_stack;

	private TextMap rtf_text_map;

	private int rtf_skip_count;

	private int rtf_cursor_x;

	private int rtf_cursor_y;

	private int rtf_chars;

	private static object ContentsResizedEvent;

	private static object HScrollEvent;

	private static object ImeChangeEvent;

	private static object LinkClickedEvent;

	private static object ProtectedEvent;

	private static object SelectionChangedEvent;

	private static object VScrollEvent;

	private static readonly char[] ReservedRTFChars;

	/// <summary>Gets or sets the font of the text displayed by the control.</summary>
	/// <returns>The <see cref="T:System.Drawing.Font" /> to apply to the text displayed by the control. The default is the value of the <see cref="P:System.Windows.Forms.Control.DefaultFont" /> property.</returns>
	public override System.Drawing.Font Font => null;

	/// <summary>Gets or sets the foreground color of the control.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that represents the control's foreground color.</returns>
	public override System.Drawing.Color ForeColor => default(System.Drawing.Color);

	/// <summary>Gets or sets the currently selected rich text format (RTF) formatted text in the control.</summary>
	/// <returns>The selected RTF text in the control.</returns>
	[DefaultValue(null)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public string SelectedRtf
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void HandleGroup(System.Windows.Forms.RTF.RTF rtf)
	{
	}

	[MonoInternalNote("Add QuadJust support for justified alignment")]
	private void HandleControl(System.Windows.Forms.RTF.RTF rtf)
	{
	}

	private void SpecialChar(System.Windows.Forms.RTF.RTF rtf)
	{
	}

	private void HandleText(System.Windows.Forms.RTF.RTF rtf)
	{
	}

	private void FlushText(System.Windows.Forms.RTF.RTF rtf, bool newline)
	{
	}

	private void InsertRTFFromStream(Stream data, int cursor_x, int cursor_y, out int to_x, out int to_y, out int chars)
	{
		to_x = default(int);
		to_y = default(int);
		chars = default(int);
	}

	private void EmitRTFFontProperties(StringBuilder rtf, int prev_index, int font_index, System.Drawing.Font prev_font, System.Drawing.Font font)
	{
	}

	[MonoInternalNote("Emit unicode and other special characters properly")]
	private void EmitRTFText(StringBuilder rtf, string text)
	{
	}

	private StringBuilder GenerateRTF(Line start_line, int start_pos, Line end_line, int end_pos)
	{
		return null;
	}
}
