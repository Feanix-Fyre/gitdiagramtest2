using System.Collections.Generic;
using System.Data.Common;

namespace System.Data;

internal abstract class ExpressionNode
{
	private DataTable _table;

	internal IFormatProvider FormatProvider => null;

	internal virtual bool IsSqlColumn => false;

	protected DataTable table => null;

	protected ExpressionNode(DataTable table)
	{
	}

	protected void BindTable(DataTable table)
	{
	}

	internal abstract void Bind(DataTable table, List<DataColumn> list);

	internal abstract object Eval();

	internal abstract object Eval(DataRow row, DataRowVersion version);

	internal abstract object Eval(int[] recordNos);

	internal abstract bool IsConstant();

	internal abstract bool IsTableConstant();

	internal abstract bool HasLocalAggregate();

	internal abstract bool HasRemoteAggregate();

	internal abstract ExpressionNode Optimize();

	internal virtual bool DependsOn(DataColumn column)
	{
		return false;
	}

	internal static bool IsInteger(StorageType type)
	{
		return false;
	}

	internal static bool IsIntegerSql(StorageType type)
	{
		return false;
	}

	internal static bool IsSigned(StorageType type)
	{
		return false;
	}

	internal static bool IsSignedSql(StorageType type)
	{
		return false;
	}

	internal static bool IsUnsigned(StorageType type)
	{
		return false;
	}

	internal static bool IsUnsignedSql(StorageType type)
	{
		return false;
	}

	internal static bool IsNumeric(StorageType type)
	{
		return false;
	}

	internal static bool IsNumericSql(StorageType type)
	{
		return false;
	}

	internal static bool IsFloat(StorageType type)
	{
		return false;
	}

	internal static bool IsFloatSql(StorageType type)
	{
		return false;
	}
}
