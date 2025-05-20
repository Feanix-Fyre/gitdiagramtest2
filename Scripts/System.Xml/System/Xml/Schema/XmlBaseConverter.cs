namespace System.Xml.Schema;

internal abstract class XmlBaseConverter : XmlValueConverter
{
	private XmlSchemaType schemaType;

	private XmlTypeCode typeCode;

	private Type clrTypeDefault;

	protected static readonly Type ICollectionType;

	protected static readonly Type IEnumerableType;

	protected static readonly Type IListType;

	protected static readonly Type ObjectArrayType;

	protected static readonly Type StringArrayType;

	protected static readonly Type XmlAtomicValueArrayType;

	protected static readonly Type DecimalType;

	protected static readonly Type Int32Type;

	protected static readonly Type Int64Type;

	protected static readonly Type StringType;

	protected static readonly Type XmlAtomicValueType;

	protected static readonly Type ObjectType;

	protected static readonly Type ByteType;

	protected static readonly Type Int16Type;

	protected static readonly Type SByteType;

	protected static readonly Type UInt16Type;

	protected static readonly Type UInt32Type;

	protected static readonly Type UInt64Type;

	protected static readonly Type XPathItemType;

	protected static readonly Type DoubleType;

	protected static readonly Type SingleType;

	protected static readonly Type DateTimeType;

	protected static readonly Type DateTimeOffsetType;

	protected static readonly Type BooleanType;

	protected static readonly Type ByteArrayType;

	protected static readonly Type XmlQualifiedNameType;

	protected static readonly Type UriType;

	protected static readonly Type TimeSpanType;

	protected static readonly Type XPathNavigatorType;

	protected XmlSchemaType SchemaType => null;

	protected XmlTypeCode TypeCode => default(XmlTypeCode);

	protected string XmlTypeName => null;

	protected Type DefaultClrType => null;

	protected XmlBaseConverter(XmlSchemaType schemaType)
	{
	}

	protected XmlBaseConverter(XmlTypeCode typeCode)
	{
	}

	protected XmlBaseConverter(XmlBaseConverter converterAtomic)
	{
	}

	protected XmlBaseConverter(XmlBaseConverter converterAtomic, Type clrTypeDefault)
	{
	}

	public override bool ToBoolean(DateTime value)
	{
		return false;
	}

	public override bool ToBoolean(double value)
	{
		return false;
	}

	public override bool ToBoolean(int value)
	{
		return false;
	}

	public override bool ToBoolean(long value)
	{
		return false;
	}

	public override bool ToBoolean(string value)
	{
		return false;
	}

	public override bool ToBoolean(object value)
	{
		return false;
	}

	public override DateTime ToDateTime(bool value)
	{
		return default(DateTime);
	}

	public override DateTime ToDateTime(DateTimeOffset value)
	{
		return default(DateTime);
	}

	public override DateTime ToDateTime(double value)
	{
		return default(DateTime);
	}

	public override DateTime ToDateTime(int value)
	{
		return default(DateTime);
	}

	public override DateTime ToDateTime(long value)
	{
		return default(DateTime);
	}

	public override DateTime ToDateTime(string value)
	{
		return default(DateTime);
	}

	public override DateTime ToDateTime(object value)
	{
		return default(DateTime);
	}

	public override DateTimeOffset ToDateTimeOffset(DateTime value)
	{
		return default(DateTimeOffset);
	}

	public override DateTimeOffset ToDateTimeOffset(string value)
	{
		return default(DateTimeOffset);
	}

	public override DateTimeOffset ToDateTimeOffset(object value)
	{
		return default(DateTimeOffset);
	}

	public override decimal ToDecimal(string value)
	{
		return default(decimal);
	}

	public override decimal ToDecimal(object value)
	{
		return default(decimal);
	}

	public override double ToDouble(bool value)
	{
		return 0.0;
	}

	public override double ToDouble(DateTime value)
	{
		return 0.0;
	}

	public override double ToDouble(int value)
	{
		return 0.0;
	}

	public override double ToDouble(long value)
	{
		return 0.0;
	}

	public override double ToDouble(string value)
	{
		return 0.0;
	}

	public override double ToDouble(object value)
	{
		return 0.0;
	}

	public override int ToInt32(bool value)
	{
		return 0;
	}

	public override int ToInt32(DateTime value)
	{
		return 0;
	}

	public override int ToInt32(double value)
	{
		return 0;
	}

	public override int ToInt32(long value)
	{
		return 0;
	}

	public override int ToInt32(string value)
	{
		return 0;
	}

	public override int ToInt32(object value)
	{
		return 0;
	}

	public override long ToInt64(bool value)
	{
		return 0L;
	}

	public override long ToInt64(DateTime value)
	{
		return 0L;
	}

	public override long ToInt64(double value)
	{
		return 0L;
	}

	public override long ToInt64(int value)
	{
		return 0L;
	}

	public override long ToInt64(string value)
	{
		return 0L;
	}

	public override long ToInt64(object value)
	{
		return 0L;
	}

	public override float ToSingle(double value)
	{
		return 0f;
	}

	public override float ToSingle(string value)
	{
		return 0f;
	}

	public override float ToSingle(object value)
	{
		return 0f;
	}

	public override string ToString(bool value)
	{
		return null;
	}

	public override string ToString(DateTime value)
	{
		return null;
	}

	public override string ToString(DateTimeOffset value)
	{
		return null;
	}

	public override string ToString(decimal value)
	{
		return null;
	}

	public override string ToString(double value)
	{
		return null;
	}

	public override string ToString(int value)
	{
		return null;
	}

	public override string ToString(long value)
	{
		return null;
	}

	public override string ToString(float value)
	{
		return null;
	}

	public override string ToString(object value, IXmlNamespaceResolver nsResolver)
	{
		return null;
	}

	public override string ToString(object value)
	{
		return null;
	}

	public override object ChangeType(bool value, Type destinationType)
	{
		return null;
	}

	public override object ChangeType(DateTime value, Type destinationType)
	{
		return null;
	}

	public override object ChangeType(decimal value, Type destinationType)
	{
		return null;
	}

	public override object ChangeType(double value, Type destinationType)
	{
		return null;
	}

	public override object ChangeType(int value, Type destinationType)
	{
		return null;
	}

	public override object ChangeType(long value, Type destinationType)
	{
		return null;
	}

	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver)
	{
		return null;
	}

	public override object ChangeType(object value, Type destinationType)
	{
		return null;
	}

	protected static bool IsDerivedFrom(Type derivedType, Type baseType)
	{
		return false;
	}

	protected Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType)
	{
		return null;
	}

	protected static string QNameToString(XmlQualifiedName name)
	{
		return null;
	}

	protected virtual object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
	{
		return null;
	}

	protected static byte[] StringToBase64Binary(string value)
	{
		return null;
	}

	protected static DateTime StringToDate(string value)
	{
		return default(DateTime);
	}

	protected static DateTime StringToDateTime(string value)
	{
		return default(DateTime);
	}

	protected static TimeSpan StringToDayTimeDuration(string value)
	{
		return default(TimeSpan);
	}

	protected static TimeSpan StringToDuration(string value)
	{
		return default(TimeSpan);
	}

	protected static DateTime StringToGDay(string value)
	{
		return default(DateTime);
	}

	protected static DateTime StringToGMonth(string value)
	{
		return default(DateTime);
	}

	protected static DateTime StringToGMonthDay(string value)
	{
		return default(DateTime);
	}

	protected static DateTime StringToGYear(string value)
	{
		return default(DateTime);
	}

	protected static DateTime StringToGYearMonth(string value)
	{
		return default(DateTime);
	}

	protected static DateTimeOffset StringToDateOffset(string value)
	{
		return default(DateTimeOffset);
	}

	protected static DateTimeOffset StringToDateTimeOffset(string value)
	{
		return default(DateTimeOffset);
	}

	protected static DateTimeOffset StringToGDayOffset(string value)
	{
		return default(DateTimeOffset);
	}

	protected static DateTimeOffset StringToGMonthOffset(string value)
	{
		return default(DateTimeOffset);
	}

	protected static DateTimeOffset StringToGMonthDayOffset(string value)
	{
		return default(DateTimeOffset);
	}

	protected static DateTimeOffset StringToGYearOffset(string value)
	{
		return default(DateTimeOffset);
	}

	protected static DateTimeOffset StringToGYearMonthOffset(string value)
	{
		return default(DateTimeOffset);
	}

	protected static byte[] StringToHexBinary(string value)
	{
		return null;
	}

	protected static XmlQualifiedName StringToQName(string value, IXmlNamespaceResolver nsResolver)
	{
		return null;
	}

	protected static DateTime StringToTime(string value)
	{
		return default(DateTime);
	}

	protected static DateTimeOffset StringToTimeOffset(string value)
	{
		return default(DateTimeOffset);
	}

	protected static TimeSpan StringToYearMonthDuration(string value)
	{
		return default(TimeSpan);
	}

	protected static string AnyUriToString(Uri value)
	{
		return null;
	}

	protected static string Base64BinaryToString(byte[] value)
	{
		return null;
	}

	protected static string DateToString(DateTime value)
	{
		return null;
	}

	protected static string DateTimeToString(DateTime value)
	{
		return null;
	}

	protected static string DayTimeDurationToString(TimeSpan value)
	{
		return null;
	}

	protected static string DurationToString(TimeSpan value)
	{
		return null;
	}

	protected static string GDayToString(DateTime value)
	{
		return null;
	}

	protected static string GMonthToString(DateTime value)
	{
		return null;
	}

	protected static string GMonthDayToString(DateTime value)
	{
		return null;
	}

	protected static string GYearToString(DateTime value)
	{
		return null;
	}

	protected static string GYearMonthToString(DateTime value)
	{
		return null;
	}

	protected static string DateOffsetToString(DateTimeOffset value)
	{
		return null;
	}

	protected static string DateTimeOffsetToString(DateTimeOffset value)
	{
		return null;
	}

	protected static string GDayOffsetToString(DateTimeOffset value)
	{
		return null;
	}

	protected static string GMonthOffsetToString(DateTimeOffset value)
	{
		return null;
	}

	protected static string GMonthDayOffsetToString(DateTimeOffset value)
	{
		return null;
	}

	protected static string GYearOffsetToString(DateTimeOffset value)
	{
		return null;
	}

	protected static string GYearMonthOffsetToString(DateTimeOffset value)
	{
		return null;
	}

	protected static string QNameToString(XmlQualifiedName qname, IXmlNamespaceResolver nsResolver)
	{
		return null;
	}

	protected static string TimeToString(DateTime value)
	{
		return null;
	}

	protected static string TimeOffsetToString(DateTimeOffset value)
	{
		return null;
	}

	protected static string YearMonthDurationToString(TimeSpan value)
	{
		return null;
	}

	internal static DateTime DateTimeOffsetToDateTime(DateTimeOffset value)
	{
		return default(DateTime);
	}

	internal static int DecimalToInt32(decimal value)
	{
		return 0;
	}

	protected static long DecimalToInt64(decimal value)
	{
		return 0L;
	}

	protected static ulong DecimalToUInt64(decimal value)
	{
		return 0uL;
	}

	protected static byte Int32ToByte(int value)
	{
		return 0;
	}

	protected static short Int32ToInt16(int value)
	{
		return 0;
	}

	protected static sbyte Int32ToSByte(int value)
	{
		return 0;
	}

	protected static ushort Int32ToUInt16(int value)
	{
		return 0;
	}

	protected static int Int64ToInt32(long value)
	{
		return 0;
	}

	protected static uint Int64ToUInt32(long value)
	{
		return 0u;
	}

	protected static DateTime UntypedAtomicToDateTime(string value)
	{
		return default(DateTime);
	}

	protected static DateTimeOffset UntypedAtomicToDateTimeOffset(string value)
	{
		return default(DateTimeOffset);
	}
}
