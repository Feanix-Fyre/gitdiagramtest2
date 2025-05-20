using System.Collections;

namespace System.Windows.Forms;

internal class MwfFileViewItemComparer : IComparer
{
	private int column_index;

	private bool asc;

	public int ColumnIndex
	{
		set
		{
		}
	}

	public bool Ascendent
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public MwfFileViewItemComparer(bool asc)
	{
	}

	public int Compare(object a, object b)
	{
		return 0;
	}
}
