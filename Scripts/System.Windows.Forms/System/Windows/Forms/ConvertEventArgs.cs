namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.Binding.Format" /> and <see cref="E:System.Windows.Forms.Binding.Parse" /> events.</summary>
public class ConvertEventArgs : EventArgs
{
	private object object_value;

	private Type desired_type;

	/// <summary>Gets or sets the value of the <see cref="T:System.Windows.Forms.ConvertEventArgs" />.</summary>
	/// <returns>The value of the <see cref="T:System.Windows.Forms.ConvertEventArgs" />.</returns>
	public object Value => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ConvertEventArgs" /> class.</summary>
	/// <param name="value">An <see cref="T:System.Object" /> that contains the value of the current property.</param>
	/// <param name="desiredType">The <see cref="T:System.Type" /> of the value.</param>
	public ConvertEventArgs(object value, Type desiredType)
	{
	}
}
