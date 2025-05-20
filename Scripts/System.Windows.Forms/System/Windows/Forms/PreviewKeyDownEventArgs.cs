namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.Control.PreviewKeyDown" /> event.</summary>
public class PreviewKeyDownEventArgs : EventArgs
{
	private Keys key_data;

	private bool is_input_key;

	/// <summary>Gets or sets a value indicating whether a key is a regular input key.</summary>
	/// <returns>
	///   <see langword="true" /> if the key is a regular input key; otherwise, <see langword="false" />.</returns>
	public bool IsInputKey => false;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.PreviewKeyDownEventArgs" /> class with the specified key.</summary>
	/// <param name="keyData">One of the <see cref="T:System.Windows.Forms.Keys" /> values.</param>
	public PreviewKeyDownEventArgs(Keys keyData)
	{
	}
}
