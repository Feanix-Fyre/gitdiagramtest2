using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace System.IO;

/// <summary>Implements a <see cref="T:System.IO.TextWriter" /> for writing information to a string. The information is stored in an underlying <see cref="T:System.Text.StringBuilder" />.</summary>
[Serializable]
[ComVisible(true)]
public class StringWriter : TextWriter
{
	private static UnicodeEncoding m_encoding;

	private StringBuilder _sb;

	private bool _isOpen;

	/// <summary>Gets the <see cref="T:System.Text.Encoding" /> in which the output is written.</summary>
	/// <returns>The <see langword="Encoding" /> in which the output is written.</returns>
	public override Encoding Encoding => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.StringWriter" /> class.</summary>
	public StringWriter()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.StringWriter" /> class with the specified format control.</summary>
	/// <param name="formatProvider">An <see cref="T:System.IFormatProvider" /> object that controls formatting.</param>
	public StringWriter(IFormatProvider formatProvider)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.StringWriter" /> class that writes to the specified <see cref="T:System.Text.StringBuilder" />.</summary>
	/// <param name="sb">The <see cref="T:System.Text.StringBuilder" /> object to write to.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="sb" /> is <see langword="null" />.</exception>
	public StringWriter(StringBuilder sb)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.StringWriter" /> class that writes to the specified <see cref="T:System.Text.StringBuilder" /> and has the specified format provider.</summary>
	/// <param name="sb">The <see cref="T:System.Text.StringBuilder" /> object to write to.</param>
	/// <param name="formatProvider">An <see cref="T:System.IFormatProvider" /> object that controls formatting.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="sb" /> is <see langword="null" />.</exception>
	public StringWriter(StringBuilder sb, IFormatProvider formatProvider)
	{
	}

	/// <summary>Closes the current <see cref="T:System.IO.StringWriter" /> and the underlying stream.</summary>
	public override void Close()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.IO.StringWriter" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	/// <summary>Writes a character to the string.</summary>
	/// <param name="value">The character to write.</param>
	/// <exception cref="T:System.ObjectDisposedException">The writer is closed.</exception>
	public override void Write(char value)
	{
	}

	/// <summary>Writes a subarray of characters to the string.</summary>
	/// <param name="buffer">The character array to write data from.</param>
	/// <param name="index">The position in the buffer at which to start reading data.</param>
	/// <param name="count">The maximum number of characters to write.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> or <paramref name="count" /> is negative.</exception>
	/// <exception cref="T:System.ArgumentException">(<paramref name="index" /> + <paramref name="count" />)&gt; <paramref name="buffer" />. <see langword="Length" />.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The writer is closed.</exception>
	public override void Write(char[] buffer, int index, int count)
	{
	}

	/// <summary>Writes a string to the current string.</summary>
	/// <param name="value">The string to write.</param>
	/// <exception cref="T:System.ObjectDisposedException">The writer is closed.</exception>
	public override void Write(string value)
	{
	}

	/// <summary>Writes a character to the string asynchronously.</summary>
	/// <param name="value">The character to write to the string.</param>
	/// <returns>A task that represents the asynchronous write operation.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The string writer is disposed.</exception>
	/// <exception cref="T:System.InvalidOperationException">The string writer is currently in use by a previous write operation.</exception>
	[ComVisible(false)]
	public override Task WriteAsync(char value)
	{
		return null;
	}

	/// <summary>Writes a string to the current string asynchronously.</summary>
	/// <param name="value">The string to write. If <paramref name="value" /> is <see langword="null" />, nothing is written to the text stream.</param>
	/// <returns>A task that represents the asynchronous write operation.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The string writer is disposed.</exception>
	/// <exception cref="T:System.InvalidOperationException">The string writer is currently in use by a previous write operation.</exception>
	[ComVisible(false)]
	public override Task WriteAsync(string value)
	{
		return null;
	}

	/// <summary>Writes a subarray of characters to the string asynchronously.</summary>
	/// <param name="buffer">The character array to write data from.</param>
	/// <param name="index">The position in the buffer at which to start reading data.</param>
	/// <param name="count">The maximum number of characters to write.</param>
	/// <returns>A task that represents the asynchronous write operation.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="index" /> plus <paramref name="count" /> is greater than the buffer length.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> or <paramref name="count" /> is negative.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The string writer is disposed.</exception>
	/// <exception cref="T:System.InvalidOperationException">The string writer is currently in use by a previous write operation.</exception>
	[ComVisible(false)]
	public override Task WriteAsync(char[] buffer, int index, int count)
	{
		return null;
	}

	/// <summary>Asynchronously clears all buffers for the current writer and causes any buffered data to be written to the underlying device.</summary>
	/// <returns>A task that represents the asynchronous flush operation.</returns>
	[ComVisible(false)]
	public override Task FlushAsync()
	{
		return null;
	}

	/// <summary>Returns a string containing the characters written to the current <see langword="StringWriter" /> so far.</summary>
	/// <returns>The string containing the characters written to the current <see langword="StringWriter" />.</returns>
	public override string ToString()
	{
		return null;
	}
}
