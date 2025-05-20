namespace System.Windows.Forms;

/// <summary>Indicates the result of a completed binding operation.</summary>
public enum BindingCompleteState
{
	/// <summary>An indication that the binding operation completed successfully.</summary>
	Success = 0,
	/// <summary>An indication that the binding operation failed with a data error.</summary>
	DataError = 1,
	/// <summary>An indication that the binding operation failed with an exception.</summary>
	Exception = 2
}
