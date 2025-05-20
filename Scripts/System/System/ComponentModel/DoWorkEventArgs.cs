namespace System.ComponentModel;

/// <summary>Provides data for the <see cref="E:System.ComponentModel.BackgroundWorker.DoWork" /> event handler.</summary>
public class DoWorkEventArgs : CancelEventArgs
{
	private object result;

	private object argument;

	/// <summary>Gets or sets a value that represents the result of an asynchronous operation.</summary>
	/// <returns>An <see cref="T:System.Object" /> representing the result of an asynchronous operation.</returns>
	[SRDescription("Result from the worker function.")]
	public object Result => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DoWorkEventArgs" /> class.</summary>
	/// <param name="argument">Specifies an argument for an asynchronous operation.</param>
	public DoWorkEventArgs(object argument)
	{
	}
}
