using System.Collections;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Serialization;

namespace System.Data.Common;

internal sealed class SqlUdtStorage : DataStorage
{
	private object[] _values;

	private readonly bool _implementsIXmlSerializable;

	private readonly bool _implementsIComparable;

	private static readonly ConcurrentDictionary<Type, object> s_typeToNull;

	public SqlUdtStorage(DataColumn column, Type type)
		: base(null, null, null, default(StorageType))
	{
	}

	private SqlUdtStorage(DataColumn column, Type type, object nullValue)
		: base(null, null, null, default(StorageType))
	{
	}

	internal static object GetStaticNullForUdtType(Type type)
	{
		return null;
	}

	public override bool IsNull(int record)
	{
		return false;
	}

	public override object Aggregate(int[] records, AggregateType kind)
	{
		return null;
	}

	public override int Compare(int recordNo1, int recordNo2)
	{
		return 0;
	}

	public override int CompareValueTo(int recordNo1, object value)
	{
		return 0;
	}

	public override void Copy(int recordNo1, int recordNo2)
	{
	}

	public override object Get(int recordNo)
	{
		return null;
	}

	public override void Set(int recordNo, object value)
	{
	}

	public override void SetCapacity(int capacity)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object ConvertXmlToObject(string s)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib)
	{
		return null;
	}

	public override string ConvertObjectToXml(object value)
	{
		return null;
	}

	public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib)
	{
	}

	protected override object GetEmptyStorage(int recordCount)
	{
		return null;
	}

	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
	{
	}

	protected override void SetStorage(object store, BitArray nullbits)
	{
	}
}
