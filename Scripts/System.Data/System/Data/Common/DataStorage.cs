using System.Collections;
using System.Collections.Concurrent;
using System.Xml;
using System.Xml.Serialization;

namespace System.Data.Common;

internal abstract class DataStorage
{
	private static readonly Type[] s_storageClassType;

	internal readonly DataColumn _column;

	internal readonly DataTable _table;

	internal readonly Type _dataType;

	internal readonly StorageType _storageTypeCode;

	private BitArray _dbNullBits;

	private readonly object _defaultValue;

	internal readonly object _nullValue;

	internal readonly bool _isCloneable;

	internal readonly bool _isCustomDefinedType;

	internal readonly bool _isStringType;

	internal readonly bool _isValueType;

	private static readonly Func<Type, Tuple<bool, bool, bool, bool>> s_inspectTypeForInterfaces;

	private static readonly ConcurrentDictionary<Type, Tuple<bool, bool, bool, bool>> s_typeImplementsInterface;

	internal DataSetDateTime DateTimeMode => default(DataSetDateTime);

	internal IFormatProvider FormatProvider => null;

	protected DataStorage(DataColumn column, Type type, object defaultValue, StorageType storageType)
	{
	}

	protected DataStorage(DataColumn column, Type type, object defaultValue, object nullValue, StorageType storageType)
	{
	}

	protected DataStorage(DataColumn column, Type type, object defaultValue, object nullValue, bool isICloneable, StorageType storageType)
	{
	}

	public virtual object Aggregate(int[] recordNos, AggregateType kind)
	{
		return null;
	}

	public object AggregateCount(int[] recordNos)
	{
		return null;
	}

	protected int CompareBits(int recordNo1, int recordNo2)
	{
		return 0;
	}

	public abstract int Compare(int recordNo1, int recordNo2);

	public abstract int CompareValueTo(int recordNo1, object value);

	public virtual object ConvertValue(object value)
	{
		return null;
	}

	protected void CopyBits(int srcRecordNo, int dstRecordNo)
	{
	}

	public abstract void Copy(int recordNo1, int recordNo2);

	public abstract object Get(int recordNo);

	protected object GetBits(int recordNo)
	{
		return null;
	}

	public virtual int GetStringLength(int record)
	{
		return 0;
	}

	protected bool HasValue(int recordNo)
	{
		return false;
	}

	public virtual bool IsNull(int recordNo)
	{
		return false;
	}

	public abstract void Set(int recordNo, object value);

	protected void SetNullBit(int recordNo, bool flag)
	{
	}

	public virtual void SetCapacity(int capacity)
	{
	}

	public abstract object ConvertXmlToObject(string s);

	public virtual object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib)
	{
		return null;
	}

	public abstract string ConvertObjectToXml(object value);

	public virtual void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib)
	{
	}

	public static DataStorage CreateStorage(DataColumn column, Type dataType, StorageType typeCode)
	{
		return null;
	}

	internal static StorageType GetStorageType(Type dataType)
	{
		return default(StorageType);
	}

	internal static Type GetTypeStorage(StorageType storageType)
	{
		return null;
	}

	internal static bool IsTypeCustomType(Type type)
	{
		return false;
	}

	internal static bool IsTypeCustomType(StorageType typeCode)
	{
		return false;
	}

	internal static bool IsSqlType(StorageType storageType)
	{
		return false;
	}

	public static bool IsSqlType(Type dataType)
	{
		return false;
	}

	private static bool DetermineIfValueType(StorageType typeCode, Type dataType)
	{
		return false;
	}

	internal static void ImplementsInterfaces(StorageType typeCode, Type dataType, out bool sqlType, out bool nullable, out bool xmlSerializable, out bool changeTracking, out bool revertibleChangeTracking)
	{
		sqlType = default(bool);
		nullable = default(bool);
		xmlSerializable = default(bool);
		changeTracking = default(bool);
		revertibleChangeTracking = default(bool);
	}

	private static Tuple<bool, bool, bool, bool> InspectTypeForInterfaces(Type dataType)
	{
		return null;
	}

	internal static bool ImplementsINullableValue(StorageType typeCode, Type dataType)
	{
		return false;
	}

	public static bool IsObjectNull(object value)
	{
		return false;
	}

	public static bool IsObjectSqlNull(object value)
	{
		return false;
	}

	internal object GetEmptyStorageInternal(int recordCount)
	{
		return null;
	}

	internal void CopyValueInternal(int record, object store, BitArray nullbits, int storeIndex)
	{
	}

	internal void SetStorageInternal(object store, BitArray nullbits)
	{
	}

	protected abstract object GetEmptyStorage(int recordCount);

	protected abstract void CopyValue(int record, object store, BitArray nullbits, int storeIndex);

	protected abstract void SetStorage(object store, BitArray nullbits);

	protected void SetNullStorage(BitArray nullbits)
	{
	}

	internal static Type GetType(string value)
	{
		return null;
	}

	internal static string GetQualifiedName(Type type)
	{
		return null;
	}
}
