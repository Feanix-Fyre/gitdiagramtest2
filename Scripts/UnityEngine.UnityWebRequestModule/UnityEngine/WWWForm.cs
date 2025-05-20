using System.Collections.Generic;
using System.Text;
using UnityEngine.Internal;

namespace UnityEngine;

public class WWWForm
{
	private List<byte[]> formData;

	private List<string> fieldNames;

	private List<string> fileNames;

	private List<string> types;

	private byte[] boundary;

	private bool containsFiles;

	private static byte[] dDash;

	private static byte[] crlf;

	private static byte[] contentTypeHeader;

	private static byte[] dispositionHeader;

	private static byte[] endQuote;

	private static byte[] fileNameField;

	private static byte[] ampersand;

	private static byte[] equal;

	internal static Encoding DefaultEncoding => null;

	public Dictionary<string, string> headers => null;

	public byte[] data => null;

	public void AddField(string fieldName, string value)
	{
	}

	public void AddField(string fieldName, string value, Encoding e)
	{
	}

	[ExcludeFromDocs]
	public void AddBinaryData(string fieldName, byte[] contents)
	{
	}

	[ExcludeFromDocs]
	public void AddBinaryData(string fieldName, byte[] contents, string fileName)
	{
	}

	public void AddBinaryData(string fieldName, byte[] contents, [DefaultValue("null")] string fileName, [DefaultValue("null")] string mimeType)
	{
	}
}
