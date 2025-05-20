using System.Data.SqlTypes;

namespace System.Data.Common;

internal static class SqlConvert
{
	public static SqlByte ConvertToSqlByte(object value)
	{
		return default(SqlByte);
	}

	public static SqlInt16 ConvertToSqlInt16(object value)
	{
		return default(SqlInt16);
	}

	public static SqlInt32 ConvertToSqlInt32(object value)
	{
		return default(SqlInt32);
	}

	public static SqlInt64 ConvertToSqlInt64(object value)
	{
		return default(SqlInt64);
	}

	public static SqlDouble ConvertToSqlDouble(object value)
	{
		return default(SqlDouble);
	}

	public static SqlDecimal ConvertToSqlDecimal(object value)
	{
		return default(SqlDecimal);
	}

	public static SqlSingle ConvertToSqlSingle(object value)
	{
		return default(SqlSingle);
	}

	public static SqlMoney ConvertToSqlMoney(object value)
	{
		return default(SqlMoney);
	}

	public static SqlDateTime ConvertToSqlDateTime(object value)
	{
		return default(SqlDateTime);
	}

	public static SqlBoolean ConvertToSqlBoolean(object value)
	{
		return default(SqlBoolean);
	}

	public static SqlGuid ConvertToSqlGuid(object value)
	{
		return default(SqlGuid);
	}

	public static SqlBinary ConvertToSqlBinary(object value)
	{
		return default(SqlBinary);
	}

	public static SqlString ConvertToSqlString(object value)
	{
		return default(SqlString);
	}

	public static SqlChars ConvertToSqlChars(object value)
	{
		return null;
	}

	public static SqlBytes ConvertToSqlBytes(object value)
	{
		return null;
	}

	public static DateTimeOffset ConvertStringToDateTimeOffset(string value, IFormatProvider formatProvider)
	{
		return default(DateTimeOffset);
	}

	public static object ChangeTypeForDefaultValue(object value, Type type, IFormatProvider formatProvider)
	{
		return null;
	}

	public static object ChangeType2(object value, StorageType stype, Type type, IFormatProvider formatProvider)
	{
		return null;
	}

	public static object ChangeTypeForXML(object value, Type type)
	{
		return null;
	}
}
