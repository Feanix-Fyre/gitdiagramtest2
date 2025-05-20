using System.Collections.Generic;

namespace Newtonsoft.Json.Linq.JsonPath;

internal abstract class PathFilter
{
	public abstract IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings? settings);

	protected static JToken? GetTokenIndex(JToken t, JsonSelectSettings? settings, int index)
	{
		return null;
	}

	protected static JToken? GetNextScanValue(JToken originalParent, JToken? container, JToken? value)
	{
		return null;
	}
}
