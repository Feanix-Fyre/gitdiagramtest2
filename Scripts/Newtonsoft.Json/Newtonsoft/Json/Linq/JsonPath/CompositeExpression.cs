using System.Collections.Generic;

namespace Newtonsoft.Json.Linq.JsonPath;

internal class CompositeExpression : QueryExpression
{
	public List<QueryExpression> Expressions { get; set; }

	public CompositeExpression(QueryOperator @operator)
		: base(default(QueryOperator))
	{
	}

	public override bool IsMatch(JToken root, JToken t, JsonSelectSettings? settings)
	{
		return false;
	}
}
