using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;

namespace System.Data;

internal class BinaryNode : ExpressionNode
{
	private enum DataTypePrecedence
	{
		SqlDateTime = 25,
		DateTimeOffset = 24,
		DateTime = 23,
		TimeSpan = 20,
		SqlDouble = 19,
		Double = 18,
		SqlSingle = 17,
		Single = 16,
		SqlDecimal = 15,
		Decimal = 14,
		SqlMoney = 13,
		UInt64 = 12,
		SqlInt64 = 11,
		Int64 = 10,
		UInt32 = 9,
		SqlInt32 = 8,
		Int32 = 7,
		UInt16 = 6,
		SqlInt16 = 5,
		Int16 = 4,
		Byte = 3,
		SqlByte = 2,
		SByte = 1,
		Error = 0,
		SqlBoolean = -1,
		Boolean = -2,
		SqlGuid = -3,
		SqlString = -4,
		String = -5,
		SqlXml = -6,
		SqlChars = -7,
		Char = -8,
		SqlBytes = -9,
		SqlBinary = -10
	}

	internal int _op;

	internal ExpressionNode _left;

	internal ExpressionNode _right;

	internal BinaryNode(DataTable table, int op, ExpressionNode left, ExpressionNode right)
		: base(null)
	{
	}

	internal override void Bind(DataTable table, List<DataColumn> list)
	{
	}

	internal override object Eval()
	{
		return null;
	}

	internal override object Eval(DataRow row, DataRowVersion version)
	{
		return null;
	}

	internal override object Eval(int[] recordNos)
	{
		return null;
	}

	internal override bool IsConstant()
	{
		return false;
	}

	internal override bool IsTableConstant()
	{
		return false;
	}

	internal override bool HasLocalAggregate()
	{
		return false;
	}

	internal override bool HasRemoteAggregate()
	{
		return false;
	}

	internal override bool DependsOn(DataColumn column)
	{
		return false;
	}

	internal override ExpressionNode Optimize()
	{
		return null;
	}

	internal void SetTypeMismatchError(int op, Type left, Type right)
	{
	}

	private static object Eval(ExpressionNode expr, DataRow row, DataRowVersion version, int[] recordNos)
	{
		return null;
	}

	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op)
	{
		return 0;
	}

	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op, CompareInfo comparer)
	{
		return 0;
	}

	private object EvalBinaryOp(int op, ExpressionNode left, ExpressionNode right, DataRow row, DataRowVersion version, int[] recordNos)
	{
		return null;
	}

	private DataTypePrecedence GetPrecedence(StorageType storageType)
	{
		return default(DataTypePrecedence);
	}

	private static StorageType GetPrecedenceType(DataTypePrecedence code)
	{
		return default(StorageType);
	}

	private bool IsMixed(StorageType left, StorageType right)
	{
		return false;
	}

	private bool IsMixedSql(StorageType left, StorageType right)
	{
		return false;
	}

	internal StorageType ResultType(StorageType left, StorageType right, bool lc, bool rc, int op)
	{
		return default(StorageType);
	}

	internal StorageType ResultSqlType(StorageType left, StorageType right, bool lc, bool rc, int op)
	{
		return default(StorageType);
	}

	private int SqlResultType(int typeCode)
	{
		return 0;
	}
}
