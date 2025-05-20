using System.Collections;
using System.Collections.Specialized;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Net;

/// <summary>Contains protocol headers associated with a request or response.</summary>
[Serializable]
[DefaultMember("Item")]
[ComVisible(true)]
public class WebHeaderCollection : NameValueCollection, ISerializable
{
	private enum RfcChar : byte
	{
		High = 0,
		Reg = 1,
		Ctl = 2,
		CR = 3,
		LF = 4,
		WS = 5,
		Colon = 6,
		Delim = 7
	}

	private static readonly HeaderInfoTable HInfo;

	private string[] m_CommonHeaders;

	private int m_NumCommonHeaders;

	private static readonly string[] s_CommonHeaderNames;

	private static readonly sbyte[] s_CommonHeaderHints;

	private NameValueCollection m_InnerCollection;

	private WebHeaderCollectionType m_Type;

	private static readonly char[] HttpTrimCharacters;

	private static RfcChar[] RfcCharMap;

	private NameValueCollection InnerCollection => null;

	private bool AllowHttpRequestHeader => false;

	/// <summary>Gets the number of headers in the collection.</summary>
	/// <returns>An <see cref="T:System.Int32" /> indicating the number of headers in a request.</returns>
	public override int Count => 0;

	/// <summary>Gets all header names (keys) in the collection.</summary>
	/// <returns>An array of type <see cref="T:System.String" /> containing all header names in a Web request.</returns>
	public override string[] AllKeys => null;

	private void NormalizeCommonHeaders()
	{
	}

	internal static bool AllowMultiValues(string name)
	{
		return false;
	}

	/// <summary>Removes the specified header from the collection.</summary>
	/// <param name="header">The <see cref="T:System.Net.HttpRequestHeader" /> instance to remove from the collection.</param>
	/// <exception cref="T:System.InvalidOperationException">This <see cref="T:System.Net.WebHeaderCollection" /> instance does not allow instances of <see cref="T:System.Net.HttpRequestHeader" />.</exception>
	public void Remove(HttpRequestHeader header)
	{
	}

	internal void AddInternal(string name, string value)
	{
	}

	internal void ChangeInternal(string name, string value)
	{
	}

	internal void RemoveInternal(string name)
	{
	}

	internal static string CheckBadChars(string name, bool isHeaderValue)
	{
		return null;
	}

	internal static bool ContainsNonAsciiChars(string token)
	{
		return false;
	}

	internal void ThrowOnRestrictedHeader(string headerName)
	{
	}

	/// <summary>Inserts a header with the specified name and value into the collection.</summary>
	/// <param name="name">The header to add to the collection.</param>
	/// <param name="value">The content of the header.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="name" /> is <see langword="null" />, <see cref="F:System.String.Empty" />, or contains invalid characters.  
	/// -or-  
	/// <paramref name="name" /> is a restricted header that must be set with a property setting.  
	/// -or-  
	/// <paramref name="value" /> contains invalid characters.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The length of <paramref name="value" /> is greater than 65535.</exception>
	public override void Add(string name, string value)
	{
	}

	/// <summary>Inserts the specified header into the collection.</summary>
	/// <param name="header">The header to add, with the name and value separated by a colon.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="header" /> is <see langword="null" /> or <see cref="F:System.String.Empty" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="header" /> does not contain a colon (:) character.  
	/// The length of <paramref name="value" /> is greater than 65535.  
	/// -or-  
	/// The name part of <paramref name="header" /> is <see cref="F:System.String.Empty" /> or contains invalid characters.  
	/// -or-  
	/// <paramref name="header" /> is a restricted header that should be set with a property.  
	/// -or-  
	/// The value part of <paramref name="header" /> contains invalid characters.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The length the string after the colon (:) is greater than 65535.</exception>
	public void Add(string header)
	{
	}

	/// <summary>Sets the specified header to the specified value.</summary>
	/// <param name="name">The header to set.</param>
	/// <param name="value">The content of the header to set.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" /> or <see cref="F:System.String.Empty" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The length of <paramref name="value" /> is greater than 65535.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="name" /> is a restricted header.  
	/// -or-  
	/// <paramref name="name" /> or <paramref name="value" /> contain invalid characters.</exception>
	public override void Set(string name, string value)
	{
	}

	internal void SetInternal(string name, string value)
	{
	}

	/// <summary>Removes the specified header from the collection.</summary>
	/// <param name="name">The name of the header to remove from the collection.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" /><see cref="F:System.String.Empty" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="name" /> is a restricted header.  
	/// -or-  
	/// <paramref name="name" /> contains invalid characters.</exception>
	public override void Remove(string name)
	{
	}

	/// <summary>Gets an array of header values stored in a header.</summary>
	/// <param name="header">The header to return.</param>
	/// <returns>An array of header strings.</returns>
	public override string[] GetValues(string header)
	{
		return null;
	}

	/// <summary>This method is obsolete.</summary>
	/// <returns>The <see cref="T:System.String" /> representation of the collection.</returns>
	public override string ToString()
	{
		return null;
	}

	internal static string GetAsString(NameValueCollection cc, bool winInetCompat, bool forTrace)
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebHeaderCollection" /> class.</summary>
	public WebHeaderCollection()
	{
	}

	internal WebHeaderCollection(WebHeaderCollectionType type)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebHeaderCollection" /> class from the specified instances of the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> classes.</summary>
	/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> containing the information required to serialize the <see cref="T:System.Net.WebHeaderCollection" />.</param>
	/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> containing the source of the serialized stream associated with the new <see cref="T:System.Net.WebHeaderCollection" />.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="headerName" /> contains invalid characters.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="headerName" /> is a null reference or <see cref="F:System.String.Empty" />.</exception>
	protected WebHeaderCollection(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and raises the deserialization event when the deserialization is complete.</summary>
	/// <param name="sender">The source of the deserialization event.</param>
	public override void OnDeserialization(object sender)
	{
	}

	/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data needed to serialize the target object.</summary>
	/// <param name="serializationInfo">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data.</param>
	/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that specifies the destination for this serialization.</param>
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	/// <summary>Serializes this instance into the specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object.</summary>
	/// <param name="serializationInfo">The object into which this <see cref="T:System.Net.WebHeaderCollection" /> will be serialized.</param>
	/// <param name="streamingContext">The destination of the serialization.</param>
	void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	/// <summary>Gets the value of a particular header in the collection, specified by the name of the header.</summary>
	/// <param name="name">The name of the Web header.</param>
	/// <returns>A <see cref="T:System.String" /> holding the value of the specified header.</returns>
	public override string Get(string name)
	{
		return null;
	}

	/// <summary>Returns an enumerator that can iterate through the <see cref="T:System.Net.WebHeaderCollection" /> instance.</summary>
	/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for the <see cref="T:System.Net.WebHeaderCollection" />.</returns>
	public override IEnumerator GetEnumerator()
	{
		return null;
	}

	/// <summary>Gets the value of a particular header in the collection, specified by an index into the collection.</summary>
	/// <param name="index">The zero-based index of the key to get from the collection.</param>
	/// <returns>A <see cref="T:System.String" /> containing the value of the specified header.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is negative.  
	/// -or-  
	/// <paramref name="index" /> exceeds the size of the collection.</exception>
	public override string Get(int index)
	{
		return null;
	}

	/// <summary>Gets an array of header values stored in the <paramref name="index" /> position of the header collection.</summary>
	/// <param name="index">The header index to return.</param>
	/// <returns>An array of header strings.</returns>
	public override string[] GetValues(int index)
	{
		return null;
	}

	/// <summary>Gets the header name at the specified position in the collection.</summary>
	/// <param name="index">The zero-based index of the key to get from the collection.</param>
	/// <returns>A <see cref="T:System.String" /> holding the header name.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is negative.  
	/// -or-  
	/// <paramref name="index" /> exceeds the size of the collection.</exception>
	public override string GetKey(int index)
	{
		return null;
	}
}
