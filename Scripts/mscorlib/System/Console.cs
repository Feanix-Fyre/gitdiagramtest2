using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace System;

/// <summary>Represents the standard input, output, and error streams for console applications. This class cannot be inherited.</summary>
public static class Console
{
	private class WindowsConsole
	{
		private delegate bool WindowsCancelHandler(int keyCode);

		public static bool ctrlHandlerAdded;

		private static WindowsCancelHandler cancelHandler;

		[PreserveSig]
		private static extern int GetConsoleCP();

		[PreserveSig]
		private static extern int GetConsoleOutputCP();

		private static bool DoWindowsConsoleCancelEvent(int keyCode)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int GetInputCodePage()
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int GetOutputCodePage()
		{
			return 0;
		}
	}

	internal static TextWriter stdout;

	private static TextWriter stderr;

	private static TextReader stdin;

	internal static bool IsRunningOnAndroid;

	private static Encoding inputEncoding;

	private static Encoding outputEncoding;

	private static ConsoleCancelEventHandler cancel_event;

	/// <summary>Gets the standard error output stream.</summary>
	/// <returns>A <see cref="T:System.IO.TextWriter" /> that represents the standard error output stream.</returns>
	public static TextWriter Error => null;

	/// <summary>Gets the standard output stream.</summary>
	/// <returns>A <see cref="T:System.IO.TextWriter" /> that represents the standard output stream.</returns>
	public static TextWriter Out => null;

	/// <summary>Gets or sets the encoding the console uses to read input.</summary>
	/// <returns>The encoding used to read console input.</returns>
	/// <exception cref="T:System.ArgumentNullException">The property value in a set operation is <see langword="null" />.</exception>
	/// <exception cref="T:System.IO.IOException">An error occurred during the execution of this operation.</exception>
	/// <exception cref="T:System.Security.SecurityException">Your application does not have permission to perform this operation.</exception>
	public static Encoding InputEncoding => null;

	/// <summary>Gets or sets the encoding the console uses to write output.</summary>
	/// <returns>The encoding used to write console output.</returns>
	/// <exception cref="T:System.ArgumentNullException">The property value in a set operation is <see langword="null" />.</exception>
	/// <exception cref="T:System.IO.IOException">An error occurred during the execution of this operation.</exception>
	/// <exception cref="T:System.Security.SecurityException">Your application does not have permission to perform this operation.</exception>
	public static Encoding OutputEncoding => null;

	static Console()
	{
	}

	private static void SetupStreams(Encoding inputEncoding, Encoding outputEncoding)
	{
	}

	private static Stream Open(IntPtr handle, FileAccess access, int bufferSize)
	{
		return null;
	}

	/// <summary>Acquires the standard error stream, which is set to a specified buffer size.</summary>
	/// <param name="bufferSize">The internal stream buffer size.</param>
	/// <returns>The standard error stream.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="bufferSize" /> is less than or equal to zero.</exception>
	public static Stream OpenStandardError(int bufferSize)
	{
		return null;
	}

	/// <summary>Acquires the standard input stream, which is set to a specified buffer size.</summary>
	/// <param name="bufferSize">The internal stream buffer size.</param>
	/// <returns>The standard input stream.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="bufferSize" /> is less than or equal to zero.</exception>
	public static Stream OpenStandardInput(int bufferSize)
	{
		return null;
	}

	/// <summary>Acquires the standard output stream, which is set to a specified buffer size.</summary>
	/// <param name="bufferSize">The internal stream buffer size.</param>
	/// <returns>The standard output stream.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="bufferSize" /> is less than or equal to zero.</exception>
	public static Stream OpenStandardOutput(int bufferSize)
	{
		return null;
	}

	/// <summary>Sets the <see cref="P:System.Console.Error" /> property to the specified <see cref="T:System.IO.TextWriter" /> object.</summary>
	/// <param name="newError">A stream that is the new standard error output.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="newError" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	public static void SetError(TextWriter newError)
	{
	}

	/// <summary>Sets the <see cref="P:System.Console.Out" /> property to the specified <see cref="T:System.IO.TextWriter" /> object.</summary>
	/// <param name="newOut">A stream that is the new standard output.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="newOut" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	public static void SetOut(TextWriter newOut)
	{
	}

	/// <summary>Writes the specified string value to the standard output stream.</summary>
	/// <param name="value">The value to write.</param>
	/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
	public static void Write(string value)
	{
	}

	/// <summary>Writes the text representation of the specified object to the standard output stream using the specified format information.</summary>
	/// <param name="format">A composite format string.</param>
	/// <param name="arg0">An object to write using <paramref name="format" />.</param>
	/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="format" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">The format specification in <paramref name="format" /> is invalid.</exception>
	public static void Write(string format, object arg0)
	{
	}

	/// <summary>Writes the text representation of the specified object, followed by the current line terminator, to the standard output stream.</summary>
	/// <param name="value">The value to write.</param>
	/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
	public static void WriteLine(object value)
	{
	}

	/// <summary>Writes the specified string value, followed by the current line terminator, to the standard output stream.</summary>
	/// <param name="value">The value to write.</param>
	/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
	public static void WriteLine(string value)
	{
	}

	/// <summary>Writes the text representation of the specified object, followed by the current line terminator, to the standard output stream using the specified format information.</summary>
	/// <param name="format">A composite format string.</param>
	/// <param name="arg0">An object to write using <paramref name="format" />.</param>
	/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="format" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">The format specification in <paramref name="format" /> is invalid.</exception>
	public static void WriteLine(string format, object arg0)
	{
	}

	/// <summary>Writes the text representation of the specified array of objects, followed by the current line terminator, to the standard output stream using the specified format information.</summary>
	/// <param name="format">A composite format string.</param>
	/// <param name="arg">An array of objects to write using <paramref name="format" />.</param>
	/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="format" /> or <paramref name="arg" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">The format specification in <paramref name="format" /> is invalid.</exception>
	public static void WriteLine(string format, params object[] arg)
	{
	}

	/// <summary>Writes the text representation of the specified objects, followed by the current line terminator, to the standard output stream using the specified format information.</summary>
	/// <param name="format">A composite format string.</param>
	/// <param name="arg0">The first object to write using <paramref name="format" />.</param>
	/// <param name="arg1">The second object to write using <paramref name="format" />.</param>
	/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="format" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">The format specification in <paramref name="format" /> is invalid.</exception>
	public static void WriteLine(string format, object arg0, object arg1)
	{
	}

	/// <summary>Writes the text representation of the specified objects, followed by the current line terminator, to the standard output stream using the specified format information.</summary>
	/// <param name="format">A composite format string.</param>
	/// <param name="arg0">The first object to write using <paramref name="format" />.</param>
	/// <param name="arg1">The second object to write using <paramref name="format" />.</param>
	/// <param name="arg2">The third object to write using <paramref name="format" />.</param>
	/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="format" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">The format specification in <paramref name="format" /> is invalid.</exception>
	public static void WriteLine(string format, object arg0, object arg1, object arg2)
	{
	}

	/// <summary>Obtains the next character or function key pressed by the user. The pressed key is displayed in the console window.</summary>
	/// <returns>An object that describes the <see cref="T:System.ConsoleKey" /> constant and Unicode character, if any, that correspond to the pressed console key. The <see cref="T:System.ConsoleKeyInfo" /> object also describes, in a bitwise combination of <see cref="T:System.ConsoleModifiers" /> values, whether one or more Shift, Alt, or Ctrl modifier keys was pressed simultaneously with the console key.</returns>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Console.In" /> property is redirected from some stream other than the console.</exception>
	public static ConsoleKeyInfo ReadKey()
	{
		return default(ConsoleKeyInfo);
	}

	/// <summary>Obtains the next character or function key pressed by the user. The pressed key is optionally displayed in the console window.</summary>
	/// <param name="intercept">Determines whether to display the pressed key in the console window. <see langword="true" /> to not display the pressed key; otherwise, <see langword="false" />.</param>
	/// <returns>An object that describes the <see cref="T:System.ConsoleKey" /> constant and Unicode character, if any, that correspond to the pressed console key. The <see cref="T:System.ConsoleKeyInfo" /> object also describes, in a bitwise combination of <see cref="T:System.ConsoleModifiers" /> values, whether one or more Shift, Alt, or Ctrl modifier keys was pressed simultaneously with the console key.</returns>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Console.In" /> property is redirected from some stream other than the console.</exception>
	public static ConsoleKeyInfo ReadKey(bool intercept)
	{
		return default(ConsoleKeyInfo);
	}

	private static void DoConsoleCancelEvent()
	{
	}
}
