namespace System.ComponentModel;

/// <summary>Provides data for the MethodName<see langword="Completed" /> event.</summary>
public class RunWorkerCompletedEventArgs : AsyncCompletedEventArgs
{
	private object result;

	/// <summary>Gets a value that represents the result of an asynchronous operation.</summary>
	/// <returns>An <see cref="T:System.Object" /> representing the result of an asynchronous operation.</returns>
	/// <exception cref="T:System.Reflection.TargetInvocationException">
	///   <see cref="P:System.ComponentModel.AsyncCompletedEventArgs.Error" /> is not <see langword="null" />. The <see cref="P:System.Exception.InnerException" /> property holds a reference to <see cref="P:System.ComponentModel.AsyncCompletedEventArgs.Error" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <see cref="P:System.ComponentModel.AsyncCompletedEventArgs.Cancelled" /> is <see langword="true" />.</exception>
	public object Result => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.RunWorkerCompletedEventArgs" /> class.</summary>
	/// <param name="result">The result of an asynchronous operation.</param>
	/// <param name="error">Any error that occurred during the asynchronous operation.</param>
	/// <param name="cancelled">A value indicating whether the asynchronous operation was canceled.</param>
	public RunWorkerCompletedEventArgs(object result, Exception error, bool cancelled)
		: base(null, cancelled: false, null)
	{
	}
}
