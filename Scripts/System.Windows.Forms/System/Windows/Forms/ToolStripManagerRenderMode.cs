using System.ComponentModel;

namespace System.Windows.Forms;

/// <summary>Specifies the painting style applied to multiple <see cref="T:System.Windows.Forms.ToolStrip" /> objects contained in a form.</summary>
public enum ToolStripManagerRenderMode
{
	/// <summary>Indicates the use of a <see cref="T:System.Windows.Forms.ToolStripRenderer" /> other than <see cref="T:System.Windows.Forms.ToolStripProfessionalRenderer" /> or <see cref="T:System.Windows.Forms.ToolStripSystemRenderer" />.</summary>
	[Browsable(false)]
	Custom = 0,
	/// <summary>Indicates the use of a <see cref="T:System.Windows.Forms.ToolStripSystemRenderer" /> to paint.</summary>
	System = 1,
	/// <summary>Indicates the use of a <see cref="T:System.Windows.Forms.ToolStripProfessionalRenderer" /> to paint.</summary>
	Professional = 2
}
