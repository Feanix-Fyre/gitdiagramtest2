using System.Collections;

namespace System.Data.Common;

internal sealed class SingleStorage : DataStorage
{
	private float[] _values;

	public SingleStorage(DataColumn column)
		: base(null, null, null, default(StorageType))
	{
	}

	public override object Aggregate(int[] records, AggregateType kind)
	{
		return null;
	}

	public override int Compare(int recordNo1, int recordNo2)
	{
		return 0;
	}

	public override int CompareValueTo(int recordNo, object value)
	{
		return 0;
	}

	public override object ConvertValue(object value)
	{
		return null;
	}

	public override void Copy(int recordNo1, int recordNo2)
	{
	}

	public override object Get(int record)
	{
		return null;
	}

	public override void Set(int record, object value)
	{
	}

	public override void SetCapacity(int capacity)
	{
	}

	public override object ConvertXmlToObject(string s)
	{
		return null;
	}

	public override string ConvertObjectToXml(object value)
	{
		return null;
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
