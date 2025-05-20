namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.ListControl.Format" /> event.</summary>
public class ListControlConvertEventArgs : ConvertEventArgs
{
	private object list_item;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ListControlConvertEventArgs" /> class with the specified object, type, and list item.</summary>
	/// <param name="value">The value displayed in the <see cref="T:System.Windows.Forms.ListControl" />.</param>
	/// <param name="desiredType">The <see cref="T:System.Type" /> for the displayed item.</param>
	/// <param name="listItem">The data source item to be displayed in the <see cref="T:System.Windows.Forms.ListControl" />.</param>
	public ListControlConvertEventArgs(object value, Type desiredType, object listItem)
		: base(null, null)
	{
	}
}
