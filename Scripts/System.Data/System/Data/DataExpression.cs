using System.Data.Common;

namespace System.Data;

internal sealed class DataExpression : IFilter
{
	internal string _originalExpression;

	private bool _parsed;

	private bool _bound;

	private ExpressionNode _expr;

	private DataTable _table;

	private readonly StorageType _storageType;

	private readonly Type _dataType;

	private DataColumn[] _dependency;

	internal string Expression => null;

	internal bool HasValue => false;

	internal DataExpression(DataTable table, string expression)
	{
	}

	internal DataExpression(DataTable table, string expression, Type type)
	{
	}

	internal void Bind(DataTable table)
	{
	}

	internal bool DependsOn(DataColumn column)
	{
		return false;
	}

	internal object Evaluate()
	{
		return null;
	}

	internal object Evaluate(DataRow row, DataRowVersion version)
	{
		return null;
	}

	public bool Invoke(DataRow row, DataRowVersion version)
	{
		return false;
	}

	internal DataColumn[] GetDependency()
	{
		return null;
	}

	internal bool IsTableAggregate()
	{
		return false;
	}

	internal static bool IsUnknown(object value)
	{
		return false;
	}

	internal bool HasLocalAggregate()
	{
		return false;
	}

	internal bool HasRemoteAggregate()
	{
		return false;
	}

	internal static bool ToBoolean(object value)
	{
		return false;
	}
}
