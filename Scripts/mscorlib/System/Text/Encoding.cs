using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Text;

/// <summary>Represents a character encoding.</summary>
[Serializable]
[ComVisible(true)]
public abstract class Encoding : ICloneable
{
	[Serializable]
	internal class DefaultEncoder : Encoder, ISerializable, IObjectReference
	{
		private Encoding m_encoding;

		[NonSerialized]
		private bool m_hasInitializedEncoding;

		[NonSerialized]
		internal char charLeftOver;

		public DefaultEncoder(Encoding encoding)
		{
		}

		internal DefaultEncoder(SerializationInfo info, StreamingContext context)
		{
		}

		public object GetRealObject(StreamingContext context)
		{
			return null;
		}

		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		public override int GetByteCount(char[] chars, int index, int count, bool flush)
		{
			return 0;
		}

		public unsafe override int GetByteCount(char* chars, int count, bool flush)
		{
			return 0;
		}

		public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush)
		{
			return 0;
		}

		public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush)
		{
			return 0;
		}
	}

	[Serializable]
	internal class DefaultDecoder : Decoder, ISerializable, IObjectReference
	{
		private Encoding m_encoding;

		[NonSerialized]
		private bool m_hasInitializedEncoding;

		public DefaultDecoder(Encoding encoding)
		{
		}

		internal DefaultDecoder(SerializationInfo info, StreamingContext context)
		{
		}

		public object GetRealObject(StreamingContext context)
		{
			return null;
		}

		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			return 0;
		}

		public override int GetCharCount(byte[] bytes, int index, int count, bool flush)
		{
			return 0;
		}

		public unsafe override int GetCharCount(byte* bytes, int count, bool flush)
		{
			return 0;
		}

		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			return 0;
		}

		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush)
		{
			return 0;
		}

		public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush)
		{
			return 0;
		}
	}

	internal class EncodingCharBuffer
	{
		private unsafe char* chars;

		private unsafe char* charStart;

		private unsafe char* charEnd;

		private int charCountResult;

		private Encoding enc;

		private DecoderNLS decoder;

		private unsafe byte* byteStart;

		private unsafe byte* byteEnd;

		private unsafe byte* bytes;

		private DecoderFallbackBuffer fallbackBuffer;

		internal bool MoreData => false;

		internal int BytesUsed => 0;

		internal int Count => 0;

		internal unsafe EncodingCharBuffer(Encoding enc, DecoderNLS decoder, char* charStart, int charCount, byte* byteStart, int byteCount)
		{
		}

		internal bool AddChar(char ch, int numBytes)
		{
			return false;
		}

		internal bool AddChar(char ch)
		{
			return false;
		}

		internal void AdjustBytes(int count)
		{
		}

		internal byte GetNextByte()
		{
			return 0;
		}

		internal bool Fallback(byte fallbackByte)
		{
			return false;
		}

		internal bool Fallback(byte[] byteBuffer)
		{
			return false;
		}
	}

	internal class EncodingByteBuffer
	{
		private unsafe byte* bytes;

		private unsafe byte* byteStart;

		private unsafe byte* byteEnd;

		private unsafe char* chars;

		private unsafe char* charStart;

		private unsafe char* charEnd;

		private int byteCountResult;

		private Encoding enc;

		private EncoderNLS encoder;

		internal EncoderFallbackBuffer fallbackBuffer;

		internal bool MoreData => false;

		internal int CharsUsed => 0;

		internal int Count => 0;

		internal unsafe EncodingByteBuffer(Encoding inEncoding, EncoderNLS inEncoder, byte* inByteStart, int inByteCount, char* inCharStart, int inCharCount)
		{
		}

		internal bool AddByte(byte b, int moreBytesExpected)
		{
			return false;
		}

		internal bool AddByte(byte b1)
		{
			return false;
		}

		internal bool AddByte(byte b1, byte b2)
		{
			return false;
		}

		internal bool AddByte(byte b1, byte b2, int moreBytesExpected)
		{
			return false;
		}

		internal void MovePrevious(bool bThrow)
		{
		}

		internal char GetNextChar()
		{
			return '\0';
		}
	}

	private static Encoding defaultEncoding;

	private static Encoding unicodeEncoding;

	private static Encoding bigEndianUnicode;

	private static Encoding utf7Encoding;

	private static Encoding utf8Encoding;

	private static Encoding utf32Encoding;

	private static Encoding asciiEncoding;

	private static Encoding latin1Encoding;

	private static Dictionary<int, Encoding> encodings;

	private const int MIMECONTF_MAILNEWS = 1;

	private const int MIMECONTF_BROWSER = 2;

	private const int MIMECONTF_SAVABLE_MAILNEWS = 256;

	private const int MIMECONTF_SAVABLE_BROWSER = 512;

	private const int CodePageDefault = 0;

	private const int CodePageNoOEM = 1;

	private const int CodePageNoMac = 2;

	private const int CodePageNoThread = 3;

	private const int CodePageNoSymbol = 42;

	private const int CodePageUnicode = 1200;

	private const int CodePageBigEndian = 1201;

	private const int CodePageWindows1252 = 1252;

	private const int CodePageMacGB2312 = 10008;

	private const int CodePageGB2312 = 20936;

	private const int CodePageMacKorean = 10003;

	private const int CodePageDLLKorean = 20949;

	private const int ISO2022JP = 50220;

	private const int ISO2022JPESC = 50221;

	private const int ISO2022JPSISO = 50222;

	private const int ISOKorean = 50225;

	private const int ISOSimplifiedCN = 50227;

	private const int EUCJP = 51932;

	private const int ChineseHZ = 52936;

	private const int DuplicateEUCCN = 51936;

	private const int EUCCN = 936;

	private const int EUCKR = 51949;

	internal const int CodePageASCII = 20127;

	internal const int ISO_8859_1 = 28591;

	private const int ISCIIAssemese = 57006;

	private const int ISCIIBengali = 57003;

	private const int ISCIIDevanagari = 57002;

	private const int ISCIIGujarathi = 57010;

	private const int ISCIIKannada = 57008;

	private const int ISCIIMalayalam = 57009;

	private const int ISCIIOriya = 57007;

	private const int ISCIIPanjabi = 57011;

	private const int ISCIITamil = 57004;

	private const int ISCIITelugu = 57005;

	private const int GB18030 = 54936;

	private const int ISO_8859_8I = 38598;

	private const int ISO_8859_8_Visual = 28598;

	private const int ENC50229 = 50229;

	private const int CodePageUTF7 = 65000;

	private const int CodePageUTF8 = 65001;

	private const int CodePageUTF32 = 12000;

	private const int CodePageUTF32BE = 12001;

	internal int m_codePage;

	internal CodePageDataItem dataItem;

	[NonSerialized]
	internal bool m_deserializedFromEverett;

	[OptionalField(VersionAdded = 2)]
	private bool m_isReadOnly;

	[OptionalField(VersionAdded = 2)]
	internal EncoderFallback encoderFallback;

	[OptionalField(VersionAdded = 2)]
	internal DecoderFallback decoderFallback;

	private static object s_InternalSyncObject;

	private static object InternalSyncObject => null;

	public virtual ReadOnlySpan<byte> Preamble => default(ReadOnlySpan<byte>);

	/// <summary>When overridden in a derived class, gets the human-readable description of the current encoding.</summary>
	/// <returns>The human-readable description of the current <see cref="T:System.Text.Encoding" />.</returns>
	public virtual string EncodingName => null;

	/// <summary>When overridden in a derived class, gets a name for the current encoding that can be used with mail agent header tags.</summary>
	/// <returns>A name for the current <see cref="T:System.Text.Encoding" /> to use with mail agent header tags.  
	///  -or-  
	///  An empty string (""), if the current <see cref="T:System.Text.Encoding" /> cannot be used.</returns>
	public virtual string HeaderName => null;

	/// <summary>When overridden in a derived class, gets the name registered with the Internet Assigned Numbers Authority (IANA) for the current encoding.</summary>
	/// <returns>The IANA name for the current <see cref="T:System.Text.Encoding" />.</returns>
	public virtual string WebName => null;

	/// <summary>Gets or sets the <see cref="T:System.Text.EncoderFallback" /> object for the current <see cref="T:System.Text.Encoding" /> object.</summary>
	/// <returns>The encoder fallback object for the current <see cref="T:System.Text.Encoding" /> object.</returns>
	/// <exception cref="T:System.ArgumentNullException">The value in a set operation is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">A value cannot be assigned in a set operation because the current <see cref="T:System.Text.Encoding" /> object is read-only.</exception>
	[ComVisible(false)]
	public EncoderFallback EncoderFallback
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the <see cref="T:System.Text.DecoderFallback" /> object for the current <see cref="T:System.Text.Encoding" /> object.</summary>
	/// <returns>The decoder fallback object for the current <see cref="T:System.Text.Encoding" /> object.</returns>
	/// <exception cref="T:System.ArgumentNullException">The value in a set operation is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">A value cannot be assigned in a set operation because the current <see cref="T:System.Text.Encoding" /> object is read-only.</exception>
	[ComVisible(false)]
	public DecoderFallback DecoderFallback
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>When overridden in a derived class, gets a value indicating whether the current encoding is read-only.</summary>
	/// <returns>
	///   <see langword="true" /> if the current <see cref="T:System.Text.Encoding" /> is read-only; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[ComVisible(false)]
	public bool IsReadOnly => false;

	/// <summary>Gets an encoding for the ASCII (7-bit) character set.</summary>
	/// <returns>An  encoding for the ASCII (7-bit) character set.</returns>
	public static Encoding ASCII => null;

	private static Encoding Latin1 => null;

	/// <summary>When overridden in a derived class, gets the code page identifier of the current <see cref="T:System.Text.Encoding" />.</summary>
	/// <returns>The code page identifier of the current <see cref="T:System.Text.Encoding" />.</returns>
	public virtual int CodePage => 0;

	/// <summary>Gets the default encoding for this .NET implementation.</summary>
	/// <returns>The default encoding for this .NET implementation.</returns>
	public static Encoding Default => null;

	/// <summary>Gets an encoding for the UTF-16 format using the little endian byte order.</summary>
	/// <returns>An encoding for the UTF-16 format using the little endian byte order.</returns>
	public static Encoding Unicode => null;

	/// <summary>Gets an encoding for the UTF-16 format that uses the big endian byte order.</summary>
	/// <returns>An encoding object for the UTF-16 format that uses the big endian byte order.</returns>
	public static Encoding BigEndianUnicode => null;

	/// <summary>Gets an encoding for the UTF-7 format.</summary>
	/// <returns>An encoding for the UTF-7 format.</returns>
	public static Encoding UTF7 => null;

	/// <summary>Gets an encoding for the UTF-8 format.</summary>
	/// <returns>An encoding for the UTF-8 format.</returns>
	public static Encoding UTF8 => null;

	/// <summary>Gets an encoding for the UTF-32 format using the little endian byte order.</summary>
	/// <returns>An  encoding object for the UTF-32 format using the little endian byte order.</returns>
	public static Encoding UTF32 => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Text.Encoding" /> class.</summary>
	protected Encoding()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Text.Encoding" /> class that corresponds to the specified code page.</summary>
	/// <param name="codePage">The code page identifier of the preferred encoding.  
	///  -or-  
	///  0, to use the default encoding.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="codePage" /> is less than zero.</exception>
	protected Encoding(int codePage)
	{
	}

	internal virtual void SetDefaultFallbacks()
	{
	}

	internal void OnDeserializing()
	{
	}

	internal void OnDeserialized()
	{
	}

	[OnDeserializing]
	private void OnDeserializing(StreamingContext ctx)
	{
	}

	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx)
	{
	}

	[OnSerializing]
	private void OnSerializing(StreamingContext ctx)
	{
	}

	internal void DeserializeEncoding(SerializationInfo info, StreamingContext context)
	{
	}

	internal void SerializeEncoding(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Returns the encoding associated with the specified code page identifier.</summary>
	/// <param name="codepage">The code page identifier of the preferred encoding. Possible values are listed in the Code Page column of the table that appears in the <see cref="T:System.Text.Encoding" /> class topic.  
	///  -or-  
	///  0 (zero), to use the default encoding.</param>
	/// <returns>The encoding that is associated with the specified code page.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="codepage" /> is less than zero or greater than 65535.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="codepage" /> is not supported by the underlying platform.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="codepage" /> is not supported by the underlying platform.</exception>
	public static Encoding GetEncoding(int codepage)
	{
		return null;
	}

	/// <summary>Returns the encoding associated with the specified code page identifier. Parameters specify an error handler for characters that cannot be encoded and byte sequences that cannot be decoded.</summary>
	/// <param name="codepage">The code page identifier of the preferred encoding. Possible values are listed in the Code Page column of the table that appears in the <see cref="T:System.Text.Encoding" /> class topic.  
	///  -or-  
	///  0 (zero), to use the default encoding.</param>
	/// <param name="encoderFallback">An object that provides an error-handling procedure when a character cannot be encoded with the current encoding.</param>
	/// <param name="decoderFallback">An object that provides an error-handling procedure when a byte sequence cannot be decoded with the current encoding.</param>
	/// <returns>The encoding that is associated with the specified code page.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="codepage" /> is less than zero or greater than 65535.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="codepage" /> is not supported by the underlying platform.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="codepage" /> is not supported by the underlying platform.</exception>
	public static Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
	{
		return null;
	}

	/// <summary>Returns the encoding associated with the specified code page name.</summary>
	/// <param name="name">The code page name of the preferred encoding. Any value returned by the <see cref="P:System.Text.Encoding.WebName" /> property is valid. Possible values are listed in the Name column of the table that appears in the <see cref="T:System.Text.Encoding" /> class topic.</param>
	/// <returns>The encoding  associated with the specified code page.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="name" /> is not a valid code page name.  
	/// -or-  
	/// The code page indicated by <paramref name="name" /> is not supported by the underlying platform.</exception>
	public static Encoding GetEncoding(string name)
	{
		return null;
	}

	/// <summary>When overridden in a derived class, returns a sequence of bytes that specifies the encoding used.</summary>
	/// <returns>A byte array containing a sequence of bytes that specifies the encoding used.  
	///  -or-  
	///  A byte array of length zero, if a preamble is not required.</returns>
	public virtual byte[] GetPreamble()
	{
		return null;
	}

	private void GetDataItem()
	{
	}

	/// <summary>When overridden in a derived class, creates a shallow copy of the current <see cref="T:System.Text.Encoding" /> object.</summary>
	/// <returns>A copy of the current <see cref="T:System.Text.Encoding" /> object.</returns>
	[ComVisible(false)]
	public virtual object Clone()
	{
		return null;
	}

	/// <summary>When overridden in a derived class, calculates the number of bytes produced by encoding the characters in the specified string.</summary>
	/// <param name="s">The string containing the set of characters to encode.</param>
	/// <returns>The number of bytes produced by encoding the specified characters.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="s" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in .NET for complete explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
	public virtual int GetByteCount(string s)
	{
		return 0;
	}

	/// <summary>When overridden in a derived class, calculates the number of bytes produced by encoding a set of characters from the specified character array.</summary>
	/// <param name="chars">The character array containing the set of characters to encode.</param>
	/// <param name="index">The index of the first character to encode.</param>
	/// <param name="count">The number of characters to encode.</param>
	/// <returns>The number of bytes produced by encoding the specified characters.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="chars" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> or <paramref name="count" /> is less than zero.  
	/// -or-  
	/// <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="chars" />.</exception>
	/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in .NET for complete explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
	public abstract int GetByteCount(char[] chars, int index, int count);

	/// <summary>When overridden in a derived class, calculates the number of bytes produced by encoding a set of characters starting at the specified character pointer.</summary>
	/// <param name="chars">A pointer to the first character to encode.</param>
	/// <param name="count">The number of characters to encode.</param>
	/// <returns>The number of bytes produced by encoding the specified characters.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="chars" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="count" /> is less than zero.</exception>
	/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in .NET for complete explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
	[CLSCompliant(false)]
	[ComVisible(false)]
	public unsafe virtual int GetByteCount(char* chars, int count)
	{
		return 0;
	}

	internal unsafe virtual int GetByteCount(char* chars, int count, EncoderNLS encoder)
	{
		return 0;
	}

	/// <summary>When overridden in a derived class, encodes all the characters in the specified character array into a sequence of bytes.</summary>
	/// <param name="chars">The character array containing the characters to encode.</param>
	/// <returns>A byte array containing the results of encoding the specified set of characters.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="chars" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in .NET for complete explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
	public virtual byte[] GetBytes(char[] chars)
	{
		return null;
	}

	/// <summary>When overridden in a derived class, encodes a set of characters from the specified character array into a sequence of bytes.</summary>
	/// <param name="chars">The character array containing the set of characters to encode.</param>
	/// <param name="index">The index of the first character to encode.</param>
	/// <param name="count">The number of characters to encode.</param>
	/// <returns>A byte array containing the results of encoding the specified set of characters.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="chars" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> or <paramref name="count" /> is less than zero.  
	/// -or-  
	/// <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="chars" />.</exception>
	/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in .NET for complete explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
	public virtual byte[] GetBytes(char[] chars, int index, int count)
	{
		return null;
	}

	/// <summary>When overridden in a derived class, encodes a set of characters from the specified character array into the specified byte array.</summary>
	/// <param name="chars">The character array containing the set of characters to encode.</param>
	/// <param name="charIndex">The index of the first character to encode.</param>
	/// <param name="charCount">The number of characters to encode.</param>
	/// <param name="bytes">The byte array to contain the resulting sequence of bytes.</param>
	/// <param name="byteIndex">The index at which to start writing the resulting sequence of bytes.</param>
	/// <returns>The actual number of bytes written into <paramref name="bytes" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="chars" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="bytes" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="charIndex" /> or <paramref name="charCount" /> or <paramref name="byteIndex" /> is less than zero.  
	/// -or-  
	/// <paramref name="charIndex" /> and <paramref name="charCount" /> do not denote a valid range in <paramref name="chars" />.  
	/// -or-  
	/// <paramref name="byteIndex" /> is not a valid index in <paramref name="bytes" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="bytes" /> does not have enough capacity from <paramref name="byteIndex" /> to the end of the array to accommodate the resulting bytes.</exception>
	/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in .NET for complete explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);

	/// <summary>When overridden in a derived class, encodes all the characters in the specified string into a sequence of bytes.</summary>
	/// <param name="s">The string containing the characters to encode.</param>
	/// <returns>A byte array containing the results of encoding the specified set of characters.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="s" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in .NET for complete explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
	public virtual byte[] GetBytes(string s)
	{
		return null;
	}

	/// <summary>When overridden in a derived class, encodes a set of characters from the specified string into the specified byte array.</summary>
	/// <param name="s">The string containing the set of characters to encode.</param>
	/// <param name="charIndex">The index of the first character to encode.</param>
	/// <param name="charCount">The number of characters to encode.</param>
	/// <param name="bytes">The byte array to contain the resulting sequence of bytes.</param>
	/// <param name="byteIndex">The index at which to start writing the resulting sequence of bytes.</param>
	/// <returns>The actual number of bytes written into <paramref name="bytes" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="s" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="bytes" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="charIndex" /> or <paramref name="charCount" /> or <paramref name="byteIndex" /> is less than zero.  
	/// -or-  
	/// <paramref name="charIndex" /> and <paramref name="charCount" /> do not denote a valid range in <paramref name="chars" />.  
	/// -or-  
	/// <paramref name="byteIndex" /> is not a valid index in <paramref name="bytes" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="bytes" /> does not have enough capacity from <paramref name="byteIndex" /> to the end of the array to accommodate the resulting bytes.</exception>
	/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in .NET for complete explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
	public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex)
	{
		return 0;
	}

	internal unsafe virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder)
	{
		return 0;
	}

	/// <summary>When overridden in a derived class, encodes a set of characters starting at the specified character pointer into a sequence of bytes that are stored starting at the specified byte pointer.</summary>
	/// <param name="chars">A pointer to the first character to encode.</param>
	/// <param name="charCount">The number of characters to encode.</param>
	/// <param name="bytes">A pointer to the location at which to start writing the resulting sequence of bytes.</param>
	/// <param name="byteCount">The maximum number of bytes to write.</param>
	/// <returns>The actual number of bytes written at the location indicated by the <paramref name="bytes" /> parameter.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="chars" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="bytes" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="charCount" /> or <paramref name="byteCount" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="byteCount" /> is less than the resulting number of bytes.</exception>
	/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in .NET for complete explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
	[CLSCompliant(false)]
	[ComVisible(false)]
	public unsafe virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount)
	{
		return 0;
	}

	/// <summary>When overridden in a derived class, calculates the number of characters produced by decoding a sequence of bytes from the specified byte array.</summary>
	/// <param name="bytes">The byte array containing the sequence of bytes to decode.</param>
	/// <param name="index">The index of the first byte to decode.</param>
	/// <param name="count">The number of bytes to decode.</param>
	/// <returns>The number of characters produced by decoding the specified sequence of bytes.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="bytes" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> or <paramref name="count" /> is less than zero.  
	/// -or-  
	/// <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="bytes" />.</exception>
	/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in .NET for complete explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
	public abstract int GetCharCount(byte[] bytes, int index, int count);

	/// <summary>When overridden in a derived class, calculates the number of characters produced by decoding a sequence of bytes starting at the specified byte pointer.</summary>
	/// <param name="bytes">A pointer to the first byte to decode.</param>
	/// <param name="count">The number of bytes to decode.</param>
	/// <returns>The number of characters produced by decoding the specified sequence of bytes.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="bytes" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="count" /> is less than zero.</exception>
	/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in .NET for complete explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
	[CLSCompliant(false)]
	[ComVisible(false)]
	public unsafe virtual int GetCharCount(byte* bytes, int count)
	{
		return 0;
	}

	internal unsafe virtual int GetCharCount(byte* bytes, int count, DecoderNLS decoder)
	{
		return 0;
	}

	/// <summary>When overridden in a derived class, decodes all the bytes in the specified byte array into a set of characters.</summary>
	/// <param name="bytes">The byte array containing the sequence of bytes to decode.</param>
	/// <returns>A character array containing the results of decoding the specified sequence of bytes.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="bytes" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in .NET for complete explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
	public virtual char[] GetChars(byte[] bytes)
	{
		return null;
	}

	/// <summary>When overridden in a derived class, decodes a sequence of bytes from the specified byte array into a set of characters.</summary>
	/// <param name="bytes">The byte array containing the sequence of bytes to decode.</param>
	/// <param name="index">The index of the first byte to decode.</param>
	/// <param name="count">The number of bytes to decode.</param>
	/// <returns>A character array containing the results of decoding the specified sequence of bytes.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="bytes" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> or <paramref name="count" /> is less than zero.  
	/// -or-  
	/// <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="bytes" />.</exception>
	/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in .NET for complete explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
	public virtual char[] GetChars(byte[] bytes, int index, int count)
	{
		return null;
	}

	/// <summary>When overridden in a derived class, decodes a sequence of bytes from the specified byte array into the specified character array.</summary>
	/// <param name="bytes">The byte array containing the sequence of bytes to decode.</param>
	/// <param name="byteIndex">The index of the first byte to decode.</param>
	/// <param name="byteCount">The number of bytes to decode.</param>
	/// <param name="chars">The character array to contain the resulting set of characters.</param>
	/// <param name="charIndex">The index at which to start writing the resulting set of characters.</param>
	/// <returns>The actual number of characters written into <paramref name="chars" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="bytes" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="chars" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="byteIndex" /> or <paramref name="byteCount" /> or <paramref name="charIndex" /> is less than zero.  
	/// -or-  
	/// <paramref name="byteindex" /> and <paramref name="byteCount" /> do not denote a valid range in <paramref name="bytes" />.  
	/// -or-  
	/// <paramref name="charIndex" /> is not a valid index in <paramref name="chars" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="chars" /> does not have enough capacity from <paramref name="charIndex" /> to the end of the array to accommodate the resulting characters.</exception>
	/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in .NET for complete explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	/// <summary>When overridden in a derived class, decodes a sequence of bytes starting at the specified byte pointer into a set of characters that are stored starting at the specified character pointer.</summary>
	/// <param name="bytes">A pointer to the first byte to decode.</param>
	/// <param name="byteCount">The number of bytes to decode.</param>
	/// <param name="chars">A pointer to the location at which to start writing the resulting set of characters.</param>
	/// <param name="charCount">The maximum number of characters to write.</param>
	/// <returns>The actual number of characters written at the location indicated by the <paramref name="chars" /> parameter.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="bytes" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="chars" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="byteCount" /> or <paramref name="charCount" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="charCount" /> is less than the resulting number of characters.</exception>
	/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in .NET for complete explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
	[CLSCompliant(false)]
	[ComVisible(false)]
	public unsafe virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount)
	{
		return 0;
	}

	internal unsafe virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder)
	{
		return 0;
	}

	/// <summary>When overridden in a derived class, decodes a specified number of bytes starting at a specified address into a string.</summary>
	/// <param name="bytes">A pointer to a byte array.</param>
	/// <param name="byteCount">The number of bytes to decode.</param>
	/// <returns>A string that contains the results of decoding the specified sequence of bytes.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="bytes" /> is a null pointer.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="byteCount" /> is less than zero.</exception>
	/// <exception cref="T:System.Text.DecoderFallbackException">A   fallback occurred (see Character Encoding in .NET for a complete explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
	[CLSCompliant(false)]
	[ComVisible(false)]
	public unsafe string GetString(byte* bytes, int byteCount)
	{
		return null;
	}

	public string GetString(ReadOnlySpan<byte> bytes)
	{
		return null;
	}

	/// <summary>When overridden in a derived class, obtains a decoder that converts an encoded sequence of bytes into a sequence of characters.</summary>
	/// <returns>A <see cref="T:System.Text.Decoder" /> that converts an encoded sequence of bytes into a sequence of characters.</returns>
	public virtual Decoder GetDecoder()
	{
		return null;
	}

	private static Encoding CreateDefaultEncoding()
	{
		return null;
	}

	internal void setReadOnly(bool value = true)
	{
	}

	/// <summary>When overridden in a derived class, obtains an encoder that converts a sequence of Unicode characters into an encoded sequence of bytes.</summary>
	/// <returns>A <see cref="T:System.Text.Encoder" /> that converts a sequence of Unicode characters into an encoded sequence of bytes.</returns>
	public virtual Encoder GetEncoder()
	{
		return null;
	}

	/// <summary>When overridden in a derived class, calculates the maximum number of bytes produced by encoding the specified number of characters.</summary>
	/// <param name="charCount">The number of characters to encode.</param>
	/// <returns>The maximum number of bytes produced by encoding the specified number of characters.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="charCount" /> is less than zero.</exception>
	/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in .NET for complete explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
	public abstract int GetMaxByteCount(int charCount);

	/// <summary>When overridden in a derived class, calculates the maximum number of characters produced by decoding the specified number of bytes.</summary>
	/// <param name="byteCount">The number of bytes to decode.</param>
	/// <returns>The maximum number of characters produced by decoding the specified number of bytes.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="byteCount" /> is less than zero.</exception>
	/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in .NET for complete explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
	public abstract int GetMaxCharCount(int byteCount);

	/// <summary>When overridden in a derived class, decodes all the bytes in the specified byte array into a string.</summary>
	/// <param name="bytes">The byte array containing the sequence of bytes to decode.</param>
	/// <returns>A string that contains the results of decoding the specified sequence of bytes.</returns>
	/// <exception cref="T:System.ArgumentException">The byte array contains invalid Unicode code points.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="bytes" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in .NET for complete explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
	public virtual string GetString(byte[] bytes)
	{
		return null;
	}

	/// <summary>When overridden in a derived class, decodes a sequence of bytes from the specified byte array into a string.</summary>
	/// <param name="bytes">The byte array containing the sequence of bytes to decode.</param>
	/// <param name="index">The index of the first byte to decode.</param>
	/// <param name="count">The number of bytes to decode.</param>
	/// <returns>A string that contains the results of decoding the specified sequence of bytes.</returns>
	/// <exception cref="T:System.ArgumentException">The byte array contains invalid Unicode code points.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="bytes" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> or <paramref name="count" /> is less than zero.  
	/// -or-  
	/// <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="bytes" />.</exception>
	/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in .NET for complete explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
	public virtual string GetString(byte[] bytes, int index, int count)
	{
		return null;
	}

	/// <summary>Determines whether the specified <see cref="T:System.Object" /> is equal to the current instance.</summary>
	/// <param name="value">The <see cref="T:System.Object" /> to compare with the current instance.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="value" /> is an instance of <see cref="T:System.Text.Encoding" /> and is equal to the current instance; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object value)
	{
		return false;
	}

	/// <summary>Returns the hash code for the current instance.</summary>
	/// <returns>The hash code for the current instance.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	internal virtual char[] GetBestFitUnicodeToBytesData()
	{
		return null;
	}

	internal virtual char[] GetBestFitBytesToUnicodeData()
	{
		return null;
	}

	internal void ThrowBytesOverflow()
	{
	}

	internal void ThrowBytesOverflow(EncoderNLS encoder, bool nothingEncoded)
	{
	}

	internal void ThrowCharsOverflow()
	{
	}

	internal void ThrowCharsOverflow(DecoderNLS decoder, bool nothingDecoded)
	{
	}
}
