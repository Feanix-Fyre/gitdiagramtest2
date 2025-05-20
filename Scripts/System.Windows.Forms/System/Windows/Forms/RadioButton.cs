using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Enables the user to select a single option from a group of choices when paired with other <see cref="T:System.Windows.Forms.RadioButton" /> controls.</summary>
[DefaultProperty("Checked")]
[DefaultBindingProperty("Checked")]
[ToolboxItem("System.Windows.Forms.Design.AutoSizeToolboxItem,System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[Designer("System.Windows.Forms.Design.RadioButtonDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[DefaultEvent("CheckedChanged")]
[ComVisible(true)]
public class RadioButton : ButtonBase
{
	internal ContentAlignment radiobutton_alignment;

	internal CheckState check_state;

	private static object AppearanceChangedEvent;

	private static object CheckedChangedEvent;

	/// <summary>Gets or sets the location of the check box portion of the <see cref="T:System.Windows.Forms.RadioButton" />.</summary>
	/// <returns>One of the valid <see cref="T:System.Drawing.ContentAlignment" /> values. The default value is <see cref="F:System.Drawing.ContentAlignment.MiddleLeft" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The assigned value is not one of the <see cref="T:System.Drawing.ContentAlignment" /> values.</exception>
	[Localizable(true)]
	[DefaultValue(ContentAlignment.MiddleLeft)]
	public ContentAlignment CheckAlign => default(ContentAlignment);

	/// <summary>Gets or sets a value indicating whether the control is checked.</summary>
	/// <returns>
	///   <see langword="true" /> if the check box is checked; otherwise, <see langword="false" />.</returns>
	[DefaultValue(false)]
	[Bindable(true, BindingDirection.OneWay)]
	[SettingsBindable(true)]
	public bool Checked => false;
}
