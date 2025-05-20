using System.Collections;
using System.Collections.Specialized;
using System.Drawing;

namespace System.Windows.Forms;

internal class ClipboardData
{
	private ListDictionary source_data;

	private string plain_text_source;

	private Image image_source;

	internal object Item;

	internal ArrayList Formats;

	internal bool Retrieving;

	internal bool Enumerating;

	internal XplatUI.ObjectToClipboard Converter;

	public bool IsSourceText => false;

	public bool IsSourceImage => false;

	public void ClearSources()
	{
	}

	public void AddSource(int type, object source)
	{
	}

	public object GetSource(int type)
	{
		return null;
	}

	public string GetPlainText()
	{
		return null;
	}

	public string GetRtfText()
	{
		return null;
	}
}
