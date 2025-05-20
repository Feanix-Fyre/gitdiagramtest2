using System.Collections.Generic;
using System.ComponentModel;

namespace System.Xml.Xsl.Runtime;

[EditorBrowsable(EditorBrowsableState.Never)]
public struct StringConcat
{
	private string s1;

	private string s2;

	private string s3;

	private string s4;

	private string delimiter;

	private List<string> strList;

	private int idxStr;

	internal int Count => 0;

	public void Clear()
	{
	}

	public string GetResult()
	{
		return null;
	}

	internal void ConcatNoDelimiter(string s)
	{
	}
}
