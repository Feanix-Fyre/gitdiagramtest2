using System.Collections.Specialized;
using System.IO;

namespace System.Windows.Forms;

internal class FDOMimeConfigReader
{
	private bool fdo_mime_available;

	private StringCollection shared_mime_paths;

	private BinaryReader br;

	private int max_offset_and_range;

	public int Init()
	{
		return 0;
	}

	private void CheckFDOMimePaths()
	{
	}

	private void ReadMagicData()
	{
	}

	private void MakeMatches()
	{
	}

	private void ReadGlobsData()
	{
	}

	private void ReadSubclasses()
	{
	}

	private void ReadAliases()
	{
	}

	private int ReadValue()
	{
		return 0;
	}

	private string ReadPriorityAndMimeType(ref int priority)
	{
		return null;
	}

	private bool CheckMagicHeader()
	{
		return false;
	}
}
