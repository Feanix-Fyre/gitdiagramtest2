namespace System.Windows.Forms;

/// <summary>Specifies the direction of the binding operation.</summary>
public enum BindingCompleteContext
{
	/// <summary>An indication that the control property value is being updated from the data source.</summary>
	ControlUpdate = 0,
	/// <summary>An indication that the data source value is being updated from the control property.</summary>
	DataSourceUpdate = 1
}
