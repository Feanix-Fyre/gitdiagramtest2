namespace Newtonsoft.Json.Linq.JsonPath;

internal abstract class QueryExpression
{
	internal QueryOperator Operator;

	public QueryExpression(QueryOperator @operator)
	{
	}

	public bool IsMatch(JToken root, JToken t)
	{
		return false;
	}

	public abstract bool IsMatch(JToken root, JToken t, JsonSelectSettings? settings);
}
