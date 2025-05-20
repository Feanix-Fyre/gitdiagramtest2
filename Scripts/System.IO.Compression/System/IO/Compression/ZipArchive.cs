using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace System.IO.Compression;

/// <summary>Represents a package of compressed files in the zip archive format.</summary>
public class ZipArchive : IDisposable
{
	private Stream _archiveStream;

	private ZipArchiveEntry _archiveStreamOwner;

	private BinaryReader _archiveReader;

	private ZipArchiveMode _mode;

	private List<ZipArchiveEntry> _entries;

	private ReadOnlyCollection<ZipArchiveEntry> _entriesCollection;

	private Dictionary<string, ZipArchiveEntry> _entriesDictionary;

	private bool _readEntries;

	private bool _leaveOpen;

	private long _centralDirectoryStart;

	private bool _isDisposed;

	private uint _numberOfThisDisk;

	private long _expectedNumberOfEntries;

	private Stream _backingStream;

	private byte[] _archiveComment;

	private Encoding _entryNameEncoding;

	/// <summary>Gets the collection of entries that are currently in the zip archive.</summary>
	/// <returns>The collection of entries that are currently in the zip archive.</returns>
	/// <exception cref="T:System.NotSupportedException">The zip archive does not support reading.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The zip archive has been disposed.</exception>
	/// <exception cref="T:System.IO.InvalidDataException">The zip archive is corrupt, and its entries cannot be retrieved.</exception>
	public ReadOnlyCollection<ZipArchiveEntry> Entries => null;

	/// <summary>Gets a value that describes the type of action the zip archive can perform on entries.</summary>
	/// <returns>One of the enumeration values that describes the type of action (read, create, or update) the zip archive can perform on entries.</returns>
	public ZipArchiveMode Mode => default(ZipArchiveMode);

	internal BinaryReader ArchiveReader => null;

	internal Stream ArchiveStream => null;

	internal uint NumberOfThisDisk => 0u;

	internal Encoding EntryNameEncoding
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.Compression.ZipArchive" /> class on the specified stream for the specified mode, uses the specified encoding for entry names, and optionally leaves the stream open.</summary>
	/// <param name="stream">The input or output stream.</param>
	/// <param name="mode">One of the enumeration values that indicates whether the zip archive is used to read, create, or update entries.</param>
	/// <param name="leaveOpen">
	///       <see langword="true" /> to leave the stream open after the <see cref="T:System.IO.Compression.ZipArchive" /> object is disposed; otherwise, <see langword="false" />.</param>
	/// <param name="entryNameEncoding">The encoding to use when reading or writing entry names in this archive. Specify a value for this parameter only when an encoding is required for interoperability with zip archive tools and libraries that do not support UTF-8 encoding for entry names.</param>
	/// <exception cref="T:System.ArgumentException">The stream is already closed, or the capabilities of the stream do not match the mode.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="stream" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///         <paramref name="mode" /> is an invalid value.</exception>
	/// <exception cref="T:System.IO.InvalidDataException">The contents of the stream could not be interpreted as a zip archive.-or-
	///         <paramref name="mode" /> is <see cref="F:System.IO.Compression.ZipArchiveMode.Update" /> and an entry is missing from the archive or is corrupt and cannot be read.-or-
	///         <paramref name="mode" /> is <see cref="F:System.IO.Compression.ZipArchiveMode.Update" /> and an entry is too large to fit into memory.</exception>
	public ZipArchive(Stream stream, ZipArchiveMode mode, bool leaveOpen, Encoding entryNameEncoding)
	{
	}

	/// <summary>Creates an empty entry that has the specified path and entry name in the zip archive.</summary>
	/// <param name="entryName">A path, relative to the root of the archive, that specifies the name of the entry to be created.</param>
	/// <returns>An empty entry in the zip archive.</returns>
	/// <exception cref="T:System.ArgumentException">
	///         <paramref name="entryName" /> is <see cref="F:System.String.Empty" />.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="entryName" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">The zip archive does not support writing.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The zip archive has been disposed.</exception>
	public ZipArchiveEntry CreateEntry(string entryName)
	{
		return null;
	}

	/// <summary>Creates an empty entry that has the specified entry name and compression level in the zip archive.</summary>
	/// <param name="entryName">A path, relative to the root of the archive, that specifies the name of the entry to be created.</param>
	/// <param name="compressionLevel">One of the enumeration values that indicates whether to emphasize speed or compression effectiveness when creating the entry.</param>
	/// <returns>An empty entry in the zip archive.</returns>
	/// <exception cref="T:System.ArgumentException">
	///         <paramref name="entryName" /> is <see cref="F:System.String.Empty" />.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="entryName" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">The zip archive does not support writing.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The zip archive has been disposed.</exception>
	public ZipArchiveEntry CreateEntry(string entryName, CompressionLevel compressionLevel)
	{
		return null;
	}

	/// <summary>Called by the <see cref="M:System.IO.Compression.ZipArchive.Dispose" /> and <see cref="M:System.Object.Finalize" /> methods to release the unmanaged resources used by the current instance of the <see cref="T:System.IO.Compression.ZipArchive" /> class, and optionally finishes writing the archive and releases the managed resources.</summary>
	/// <param name="disposing">
	///       <see langword="true" /> to finish writing the archive and release unmanaged and managed resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected virtual void Dispose(bool disposing)
	{
	}

	/// <summary>Releases the resources used by the current instance of the <see cref="T:System.IO.Compression.ZipArchive" /> class.</summary>
	public void Dispose()
	{
	}

	private ZipArchiveEntry DoCreateEntry(string entryName, CompressionLevel? compressionLevel)
	{
		return null;
	}

	internal void AcquireArchiveStream(ZipArchiveEntry entry)
	{
	}

	private void AddEntry(ZipArchiveEntry entry)
	{
	}

	internal void ReleaseArchiveStream(ZipArchiveEntry entry)
	{
	}

	internal void RemoveEntry(ZipArchiveEntry entry)
	{
	}

	internal void ThrowIfDisposed()
	{
	}

	private void CloseStreams()
	{
	}

	private void EnsureCentralDirectoryRead()
	{
	}

	private void Init(Stream stream, ZipArchiveMode mode, bool leaveOpen)
	{
	}

	private void ReadCentralDirectory()
	{
	}

	private void ReadEndOfCentralDirectory()
	{
	}

	private void WriteFile()
	{
	}

	private void WriteArchiveEpilogue(long startOfCentralDirectory, long sizeOfCentralDirectory)
	{
	}
}
