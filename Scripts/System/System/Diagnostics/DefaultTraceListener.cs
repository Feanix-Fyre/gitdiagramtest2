namespace System.Diagnostics;

/// <summary>Provides the default output methods and behavior for tracing.</summary>
public class DefaultTraceListener : TraceListener
{
	private static readonly bool OnWin32;

	private static readonly string MonoTracePrefix;

	private static readonly string MonoTraceFile;

	private string logFileName;

	/// <summary>Gets or sets the name of a log file to write trace or debug messages to.</summary>
	/// <returns>The name of a log file to write trace or debug messages to.</returns>
	[System.MonoTODO]
	public string LogFileName => null;

	static DefaultTraceListener()
	{
	}

	private static string GetPrefix(string var, string target)
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DefaultTraceListener" /> class with "Default" as its <see cref="P:System.Diagnostics.TraceListener.Name" /> property value.</summary>
	public DefaultTraceListener()
		: base(null)
	{
	}

	private unsafe static void WriteWindowsDebugString(char* message)
	{
	}

	private void WriteDebugString(string message)
	{
	}

	private void WriteMonoTrace(string message)
	{
	}

	private void WritePrefix()
	{
	}

	private void WriteImpl(string message)
	{
	}

	private void WriteLogFile(string message, string logFile)
	{
	}

	/// <summary>Writes the output to the <see langword="OutputDebugString" /> function and to the <see cref="M:System.Diagnostics.Debugger.Log(System.Int32,System.String,System.String)" /> method.</summary>
	/// <param name="message">The message to write to <see langword="OutputDebugString" /> and <see cref="M:System.Diagnostics.Debugger.Log(System.Int32,System.String,System.String)" />.</param>
	public override void Write(string message)
	{
	}

	/// <summary>Writes the output to the <see langword="OutputDebugString" /> function and to the <see cref="M:System.Diagnostics.Debugger.Log(System.Int32,System.String,System.String)" /> method, followed by a carriage return and line feed (\r\n).</summary>
	/// <param name="message">The message to write to <see langword="OutputDebugString" /> and <see cref="M:System.Diagnostics.Debugger.Log(System.Int32,System.String,System.String)" />.</param>
	public override void WriteLine(string message)
	{
	}
}
