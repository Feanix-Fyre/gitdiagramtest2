namespace System.ComponentModel;

/// <summary>Provides a way to synchronously or asynchronously execute a delegate.</summary>
public interface ISynchronizeInvoke
{
	/// <summary>Gets a value indicating whether the caller must call <see cref="M:System.ComponentModel.ISynchronizeInvoke.Invoke(System.Delegate,System.Object[])" /> when calling an object that implements this interface.</summary>
	/// <returns>
	///   <see langword="true" /> if the caller must call <see cref="M:System.ComponentModel.ISynchronizeInvoke.Invoke(System.Delegate,System.Object[])" />; otherwise, <see langword="false" />.</returns>
	bool InvokeRequired { get; }

	/// <summary>Asynchronously executes the delegate on the thread that created this object.</summary>
	/// <param name="method">A <see cref="T:System.Delegate" /> to a method that takes parameters of the same number and type that are contained in <paramref name="args" />.</param>
	/// <param name="args">An array of type <see cref="T:System.Object" /> to pass as arguments to the given method. This can be <see langword="null" /> if no arguments are needed.</param>
	/// <returns>An <see cref="T:System.IAsyncResult" /> interface that represents the asynchronous operation started by calling this method.</returns>
	IAsyncResult BeginInvoke(Delegate method, object[] args);
}
