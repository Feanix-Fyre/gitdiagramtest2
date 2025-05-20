using System.Collections.Generic;

namespace System.IO.Compression;

/// <summary>Represents a compressed file within a zip archive.</summary>
public class ZipArchiveEntry
{
	private sealed class DirectToArchiveWriterStream : Stream
	{
		private long _position;

		private CheckSumAndSizeWriteStream _crcSizeStream;

		private bool _everWritten;

		private bool _isDisposed;

		private ZipArchiveEntry _entry;

		private bool _usedZip64inLH;

		private bool _canWrite;

		public override long Length => 0L;

		public override long Position
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public override bool CanRead => false;

		public override bool CanSeek => false;

		public override bool CanWrite => false;

		public DirectToArchiveWriterStream(CheckSumAndSizeWriteStream crcSizeStream, ZipArchiveEntry entry)
		{
		}

		private void ThrowIfDisposed()
		{
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		public override void SetLength(long value)
		{
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		public override void Flush()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}
	}

	[Flags]
	private enum BitFlagValues : ushort
	{
		DataDescriptor = 8,
		UnicodeFileName = 0x800
	}

	internal enum CompressionMethodValues : ushort
	{
		Stored = 0,
		Deflate = 8,
		Deflate64 = 9,
		BZip2 = 12,
		LZMA = 14
	}

	private ZipArchive _archive;

	private readonly bool _originallyInArchive;

	private readonly int _diskNumberStart;

	private readonly ZipVersionMadeByPlatform _versionMadeByPlatform;

	private ZipVersionNeededValues _versionMadeBySpecification;

	private ZipVersionNeededValues _versionToExtract;

	private BitFlagValues _generalPurposeBitFlag;

	private CompressionMethodValues _storedCompressionMethod;

	private DateTimeOffset _lastModified;

	private long _compressedSize;

	private long _uncompressedSize;

	private long _offsetOfLocalHeader;

	private long? _storedOffsetOfCompressedData;

	private uint _crc32;

	private byte[][] _compressedBytes;

	private MemoryStream _storedUncompressedData;

	private bool _currentlyOpenForWrite;

	private bool _everOpenedForWrite;

	private Stream _outstandingWriteStream;

	private uint _externalFileAttr;

	private string _storedEntryName;

	private byte[] _storedEntryNameBytes;

	private List<ZipGenericExtraField> _cdUnknownExtraFields;

	private List<ZipGenericExtraField> _lhUnknownExtraFields;

	private byte[] _fileComment;

	private CompressionLevel? _compressionLevel;

	private static readonly bool s_allowLargeZipArchiveEntriesInUpdateMode;

	internal static readonly ZipVersionMadeByPlatform CurrentZipPlatform;

	/// <summary>Gets the relative path of the entry in the zip archive.</summary>
	/// <returns>The relative path of the entry in the zip archive.</returns>
	public string FullName
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	/// <summary>Gets or sets the last time the entry in the zip archive was changed.</summary>
	/// <returns>The last time the entry in the zip archive was changed.</returns>
	/// <exception cref="T:System.NotSupportedException">The attempt to set this property failed, because the zip archive for the entry is in <see cref="F:System.IO.Compression.ZipArchiveMode.Read" /> mode.</exception>
	/// <exception cref="T:System.IO.IOException">The archive mode is set to <see cref="F:System.IO.Compression.ZipArchiveMode.Create" />.- or -The archive mode is set to <see cref="F:System.IO.Compression.ZipArchiveMode.Update" /> and the entry has been opened.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">An attempt was made to set this property to a value that is either earlier than 1980 January 1 0:00:00 (midnight) or later than 2107 December 31 23:59:58 (one second before midnight).</exception>
	public DateTimeOffset LastWriteTime
	{
		get
		{
			return default(DateTimeOffset);
		}
		set
		{
		}
	}

	/// <summary>Gets the uncompressed size of the entry in the zip archive.</summary>
	/// <returns>The uncompressed size of the entry in the zip archive.</returns>
	/// <exception cref="T:System.InvalidOperationException">The value of the property is not available because the entry has been modified.</exception>
	public long Length => 0L;

	internal bool EverOpenedForWrite => false;

	private long OffsetOfCompressedData => 0L;

	private MemoryStream UncompressedData => null;

	private CompressionMethodValues CompressionMethod
	{
		get
		{
			return default(CompressionMethodValues);
		}
		set
		{
		}
	}

	internal ZipArchiveEntry(ZipArchive archive, ZipCentralDirectoryFileHeader cd)
	{
	}

	internal ZipArchiveEntry(ZipArchive archive, string entryName, CompressionLevel compressionLevel)
	{
	}

	internal ZipArchiveEntry(ZipArchive archive, string entryName)
	{
	}

	/// <summary>Deletes the entry from the zip archive.</summary>
	/// <exception cref="T:System.IO.IOException">The entry is already open for reading or writing.</exception>
	/// <exception cref="T:System.NotSupportedException">The zip archive for this entry was opened in a mode other than <see cref="F:System.IO.Compression.ZipArchiveMode.Update" />. </exception>
	/// <exception cref="T:System.ObjectDisposedException">The zip archive for this entry has been disposed.</exception>
	public void Delete()
	{
	}

	/// <summary>Opens the entry from the zip archive.</summary>
	/// <returns>The stream that represents the contents of the entry.</returns>
	/// <exception cref="T:System.IO.IOException">The entry is already currently open for writing.-or-The entry has been deleted from the archive.-or-The archive for this entry was opened with the <see cref="F:System.IO.Compression.ZipArchiveMode.Create" /> mode, and this entry has already been written to. </exception>
	/// <exception cref="T:System.IO.InvalidDataException">The entry is either missing from the archive or is corrupt and cannot be read. -or-The entry has been compressed by using a compression method that is not supported.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The zip archive for this entry has been disposed.</exception>
	public Stream Open()
	{
		return null;
	}

	/// <summary>Retrieves the relative path of the entry in the zip archive.</summary>
	/// <returns>The relative path of the entry, which is the value stored in the <see cref="P:System.IO.Compression.ZipArchiveEntry.FullName" /> property.</returns>
	public override string ToString()
	{
		return null;
	}

	private string DecodeEntryName(byte[] entryNameBytes)
	{
		return null;
	}

	private byte[] EncodeEntryName(string entryName, out bool isUTF8)
	{
		isUTF8 = default(bool);
		return null;
	}

	internal void WriteAndFinishLocalEntry()
	{
	}

	internal void WriteCentralDirectoryFileHeader()
	{
	}

	internal bool LoadLocalHeaderExtraFieldAndCompressedBytesIfNeeded()
	{
		return false;
	}

	internal void ThrowIfNotOpenable(bool needToUncompress, bool needToLoadIntoMemory)
	{
	}

	private CheckSumAndSizeWriteStream GetDataCompressor(Stream backingStream, bool leaveBackingStreamOpen, EventHandler onClose)
	{
		return null;
	}

	private Stream GetDataDecompressor(Stream compressedStreamToRead)
	{
		return null;
	}

	private Stream OpenInReadMode(bool checkOpenable)
	{
		return null;
	}

	private Stream OpenInWriteMode()
	{
		return null;
	}

	private Stream OpenInUpdateMode()
	{
		return null;
	}

	private bool IsOpenable(bool needToUncompress, bool needToLoadIntoMemory, out string message)
	{
		message = null;
		return false;
	}

	private bool SizesTooLarge()
	{
		return false;
	}

	private bool WriteLocalFileHeader(bool isEmptyFile)
	{
		return false;
	}

	private void WriteLocalFileHeaderAndDataIfNeeded()
	{
	}

	private void WriteCrcAndSizesInLocalHeader(bool zip64HeaderUsed)
	{
	}

	private void WriteDataDescriptor()
	{
	}

	private void UnloadStreams()
	{
	}

	private void CloseStreams()
	{
	}

	private void VersionToExtractAtLeast(ZipVersionNeededValues value)
	{
	}

	private void ThrowIfInvalidArchive()
	{
	}

	private static string GetFileName_Windows(string path)
	{
		return null;
	}

	private static string GetFileName_Unix(string path)
	{
		return null;
	}

	internal static string ParseFileName(string path, ZipVersionMadeByPlatform madeByPlatform)
	{
		return null;
	}
}
