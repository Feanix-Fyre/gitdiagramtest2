using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Serialization;

namespace System.Data.Common;

internal sealed class ObjectStorage : DataStorage
{
	private enum Families
	{
		DATETIME = 0,
		NUMBER = 1,
		STRING = 2,
		BOOLEAN = 3,
		ARRAY = 4
	}

	private class TempAssemblyComparer : IEqualityComparer<KeyValuePair<Type, XmlRootAttribute>>
	{
		internal static readonly IEqualityComparer<KeyValuePair<Type, XmlRootAttribute>> s_default;

		private TempAssemblyComparer()
		{
		}

		public bool Equals(KeyValuePair<Type, XmlRootAttribute> x, KeyValuePair<Type, XmlRootAttribute> y)
		{
			return false;
		}

		public int GetHashCode(KeyValuePair<Type, XmlRootAttribute> obj)
		{
			return 0;
		}
	}

	private static readonly object s_defaultValue;

	private object[] _values;

	private readonly bool _implementsIXmlSerializable;

	private static readonly object s_tempAssemblyCacheLock;

	private static Dictionary<KeyValuePair<Type, XmlRootAttribute>, XmlSerializer> s_tempAssemblyCache;

	private static readonly XmlSerializerFactory s_serializerFactory;

	internal ObjectStorage(DataColumn column, Type type)
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

	public override int CompareValueTo(int recordNo1, object value)
	{
		return 0;
	}

	private int CompareTo(object valueNo1, object valueNo2)
	{
		return 0;
	}

	private int CompareWithFamilies(object valueNo1, object valueNo2)
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

	private Families GetFamily(Type dataType)
	{
		return default(Families);
	}

	public override bool IsNull(int record)
	{
		return false;
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

	internal static void VerifyIDynamicMetaObjectProvider(Type type)
	{
	}

	internal static XmlSerializer GetXmlSerializer(Type type)
	{
		return null;
	}

	internal static XmlSerializer GetXmlSerializer(Type type, XmlRootAttribute attribute)
	{
		return null;
	}
}
