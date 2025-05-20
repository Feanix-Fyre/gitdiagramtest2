using System.Runtime.InteropServices;

namespace System.Diagnostics;

/// <summary>Provides the <see langword="abstract" /> base class for the listeners who monitor trace and debug output.</summary>
public abstract class TraceListener : MarshalByRefObject, IDisposable
{
	private int indentLevel;

	private int indentSize;

	private TraceOptions traceOptions;

	private bool needIndent;

	private string listenerName;

	private TraceFilter filter;

	/// <summary>Gets a value indicating whether the trace listener is thread safe.</summary>
	/// <returns>
	///   <see langword="true" /> if the trace listener is thread safe; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	public virtual bool IsThreadSafe => false;

	/// <summary>Gets or sets the indent level.</summary>
	/// <returns>The indent level. The default is zero.</returns>
	public int IndentLevel
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the number of spaces in an indent.</summary>
	/// <returns>The number of spaces in an indent. The default is four spaces.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">Set operation failed because the value is less than zero.</exception>
	public int IndentSize
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the trace filter for the trace listener.</summary>
	/// <returns>An object derived from the <see cref="T:System.Diagnostics.TraceFilter" /> base class.</returns>
	[ComVisible(false)]
	public TraceFilter Filter => null;

	/// <summary>Gets or sets a value indicating whether to indent the output.</summary>
	/// <returns>
	///   <see langword="true" /> if the output should be indented; otherwise, <see langword="false" />.</returns>
	protected bool NeedIndent
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the trace output options.</summary>
	/// <returns>A bitwise combination of the enumeration values. The default is <see cref="F:System.Diagnostics.TraceOptions.None" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">Set operation failed because the value is invalid.</exception>
	[ComVisible(false)]
	public TraceOptions TraceOutputOptions => default(TraceOptions);

	/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.TraceListener" /> class using the specified name as the listener.</summary>
	/// <param name="name">The name of the <see cref="T:System.Diagnostics.TraceListener" />.</param>
	protected TraceListener(string name)
	{
	}

	/// <summary>Releases all resources used by the <see cref="T:System.Diagnostics.TraceListener" />.</summary>
	public void Dispose()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Diagnostics.TraceListener" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected virtual void Dispose(bool disposing)
	{
	}

	/// <summary>When overridden in a derived class, flushes the output buffer.</summary>
	public virtual void Flush()
	{
	}

	/// <summary>When overridden in a derived class, writes the specified message to the listener you create in the derived class.</summary>
	/// <param name="message">A message to write.</param>
	public abstract void Write(string message);

	/// <summary>Writes the indent to the listener you create when you implement this class, and resets the <see cref="P:System.Diagnostics.TraceListener.NeedIndent" /> property to <see langword="false" />.</summary>
	protected virtual void WriteIndent()
	{
	}

	/// <summary>When overridden in a derived class, writes a message to the listener you create in the derived class, followed by a line terminator.</summary>
	/// <param name="message">A message to write.</param>
	public abstract void WriteLine(string message);

	/// <summary>Writes trace information, a message, and event information to the listener specific output.</summary>
	/// <param name="eventCache">A <see cref="T:System.Diagnostics.TraceEventCache" /> object that contains the current process ID, thread ID, and stack trace information.</param>
	/// <param name="source">A name used to identify the output, typically the name of the application that generated the trace event.</param>
	/// <param name="eventType">One of the <see cref="T:System.Diagnostics.TraceEventType" /> values specifying the type of event that has caused the trace.</param>
	/// <param name="id">A numeric identifier for the event.</param>
	/// <param name="message">A message to write.</param>
	[ComVisible(false)]
	public virtual void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message)
	{
	}

	private void WriteHeader(string source, TraceEventType eventType, int id)
	{
	}

	private void WriteFooter(TraceEventCache eventCache)
	{
	}

	internal bool IsEnabled(TraceOptions opts)
	{
		return false;
	}
}
