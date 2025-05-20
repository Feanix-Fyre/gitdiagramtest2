using System.Collections.Specialized;

namespace System.Windows.Forms;

internal struct FilterStruct
{
	public string filterName;

	public StringCollection filters;

	public FilterStruct(string filterName, string filter)
	{
		this.filterName = null;
		filters = null;
	}

	private void SplitFilters(string filter)
	{
	}
}
