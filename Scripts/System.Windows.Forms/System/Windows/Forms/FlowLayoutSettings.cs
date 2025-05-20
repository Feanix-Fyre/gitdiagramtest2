using System.Collections.Generic;
using System.ComponentModel;

namespace System.Windows.Forms;

/// <summary>Collects the characteristics associated with flow layouts.</summary>
[DefaultProperty("FlowDirection")]
public class FlowLayoutSettings : LayoutSettings
{
	private FlowDirection flow_direction;

	private bool wrap_contents;

	private Dictionary<object, bool> flow_breaks;

	private Control owner;

	/// <summary>Gets or sets a value indicating the flow direction of consecutive controls.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.FlowDirection" /> indicating the flow direction of consecutive controls in the container. The default is <see cref="F:System.Windows.Forms.FlowDirection.LeftToRight" />.</returns>
	[DefaultValue(FlowDirection.LeftToRight)]
	public FlowDirection FlowDirection => default(FlowDirection);

	/// <summary>Gets or sets a value indicating whether the contents should be wrapped or clipped when they exceed the original boundaries of their container.</summary>
	/// <returns>
	///   <see langword="true" /> if the contents should be wrapped; otherwise, <see langword="false" /> if the contents should be clipped. The default is <see langword="true" />.</returns>
	[DefaultValue(true)]
	public bool WrapContents => false;

	internal FlowLayoutSettings()
	{
	}

	internal FlowLayoutSettings(Control owner)
	{
	}

	/// <summary>Returns a value that represents the flow break setting of the control.</summary>
	/// <param name="child">The child control.</param>
	/// <returns>
	///   <see langword="true" /> if the flow break is set; otherwise, <see langword="false" />.</returns>
	public bool GetFlowBreak(object child)
	{
		return false;
	}
}
