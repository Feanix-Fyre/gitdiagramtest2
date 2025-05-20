namespace System.Diagnostics;

/// <summary>Provides a set of methods and properties that help you trace the execution of your code. This class cannot be inherited.</summary>
public sealed class Trace
{
	private static CorrelationManager correlationManager;

	/// <summary>Gets the collection of listeners that is monitoring the trace output.</summary>
	/// <returns>A <see cref="T:System.Diagnostics.TraceListenerCollection" /> that represents a collection of type <see cref="T:System.Diagnostics.TraceListener" /> monitoring the trace output.</returns>
	public static TraceListenerCollection Listeners => null;

	/// <summary>Gets or sets whether <see cref="M:System.Diagnostics.Trace.Flush" /> should be called on the <see cref="P:System.Diagnostics.Trace.Listeners" /> after every write.</summary>
	/// <returns>
	///   <see langword="true" /> if <see cref="M:System.Diagnostics.Trace.Flush" /> is called on the <see cref="P:System.Diagnostics.Trace.Listeners" /> after every write; otherwise, <see langword="false" />.</returns>
	public static bool AutoFlush => false;

	/// <summary>Gets the correlation manager for the thread for this trace.</summary>
	/// <returns>The <see cref="T:System.Diagnostics.CorrelationManager" /> object associated with the thread for this trace.</returns>
	public static CorrelationManager CorrelationManager => null;
}
