using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes;

/// <summary>Represents the date and time data ranging in value from January 1, 1753 to December 31, 9999 to an accuracy of 3.33 milliseconds to be stored in or retrieved from a database. The <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure has a different underlying data structure from its corresponding .NET Framework type, <see cref="T:System.DateTime" />, which can represent any time between 12:00:00 AM 1/1/0001 and 11:59:59 PM 12/31/9999, to the accuracy of 100 nanoseconds. <see cref="T:System.Data.SqlTypes.SqlDateTime" /> actually stores the relative difference to 00:00:00 AM 1/1/1900. Therefore, a conversion from "00:00:00 AM 1/1/1900" to an integer will return 0.</summary>
[Serializable]
[XmlSchemaProvider("GetXsdType")]
public struct SqlDateTime : INullable, IComparable, IXmlSerializable
{
	private bool m_fNotNull;

	private int m_day;

	private int m_time;

	private static readonly double s_SQLTicksPerMillisecond;

	/// <summary>A constant whose value is the number of ticks equivalent to one second.</summary>
	public static readonly int SQLTicksPerSecond;

	/// <summary>A constant whose value is the number of ticks equivalent to one minute.</summary>
	public static readonly int SQLTicksPerMinute;

	/// <summary>A constant whose value is the number of ticks equivalent to one hour.</summary>
	public static readonly int SQLTicksPerHour;

	private static readonly int s_SQLTicksPerDay;

	private static readonly long s_ticksPerSecond;

	private static readonly DateTime s_SQLBaseDate;

	private static readonly long s_SQLBaseDateTicks;

	private static readonly int s_minYear;

	private static readonly int s_maxYear;

	private static readonly int s_minDay;

	private static readonly int s_maxDay;

	private static readonly int s_minTime;

	private static readonly int s_maxTime;

	private static readonly int s_dayBase;

	private static readonly int[] s_daysToMonth365;

	private static readonly int[] s_daysToMonth366;

	private static readonly DateTime s_minDateTime;

	private static readonly DateTime s_maxDateTime;

	private static readonly TimeSpan s_minTimeSpan;

	private static readonly TimeSpan s_maxTimeSpan;

	private static readonly string s_ISO8601_DateTimeFormat;

	private static readonly string[] s_dateTimeFormats;

	/// <summary>Represents the minimum valid date value for a <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</summary>
	public static readonly SqlDateTime MinValue;

	/// <summary>Represents the maximum valid date value for a <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</summary>
	public static readonly SqlDateTime MaxValue;

	/// <summary>Represents a <see cref="T:System.DBNull" /> that can be assigned to this instance of the <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</summary>
	public static readonly SqlDateTime Null;

	/// <summary>Indicates whether this <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure is null.</summary>
	/// <returns>
	///   <see langword="true" /> if null. Otherwise, <see langword="false" />.</returns>
	public bool IsNull => false;

	/// <summary>Gets the value of the <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. This property is read-only.</summary>
	/// <returns>The value of this <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</returns>
	/// <exception cref="T:System.Data.SqlTypes.SqlNullValueException">The exception that is thrown when the <see langword="Value" /> property of a <see cref="N:System.Data.SqlTypes" /> structure is set to null.</exception>
	public DateTime Value => default(DateTime);

	/// <summary>Gets the number of ticks representing the date of this <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</summary>
	/// <returns>The number of ticks representing the date that is contained in the <see cref="P:System.Data.SqlTypes.SqlDateTime.Value" /> property of this <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</returns>
	/// <exception cref="T:System.Data.SqlTypes.SqlNullValueException">The exception that is thrown when the <see langword="Value" /> property of a <see cref="N:System.Data.SqlTypes" /> structure is set to null.</exception>
	public int DayTicks => 0;

	/// <summary>Gets the number of ticks representing the time of this <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</summary>
	/// <returns>The number of ticks representing the time of this <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</returns>
	public int TimeTicks => 0;

	private SqlDateTime(bool fNull)
	{
		m_fNotNull = false;
		m_day = 0;
		m_time = 0;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure using the specified <see cref="T:System.DateTime" /> value.</summary>
	/// <param name="value">A <see langword="DateTime" /> structure.</param>
	public SqlDateTime(DateTime value)
	{
		m_fNotNull = false;
		m_day = 0;
		m_time = 0;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure using the supplied parameters.</summary>
	/// <param name="dayTicks">An integer value that represents the date as ticks.</param>
	/// <param name="timeTicks">An integer value that represents the time as ticks.</param>
	public SqlDateTime(int dayTicks, int timeTicks)
	{
		m_fNotNull = false;
		m_day = 0;
		m_time = 0;
	}

	private static TimeSpan ToTimeSpan(SqlDateTime value)
	{
		return default(TimeSpan);
	}

	private static DateTime ToDateTime(SqlDateTime value)
	{
		return default(DateTime);
	}

	private static SqlDateTime FromTimeSpan(TimeSpan value)
	{
		return default(SqlDateTime);
	}

	private static SqlDateTime FromDateTime(DateTime value)
	{
		return default(SqlDateTime);
	}

	/// <summary>Converts a <see cref="T:System.DateTime" /> structure to a <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</summary>
	/// <param name="value">A <see langword="DateTime" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDateTime.Value" /> is equal to the combined <see cref="P:System.DateTime.Date" /> and <see cref="P:System.DateTime.TimeOfDay" /> properties of the supplied <see cref="T:System.DateTime" /> structure.</returns>
	public static implicit operator SqlDateTime(DateTime value)
	{
		return default(SqlDateTime);
	}

	/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure to a <see cref="T:System.String" />.</summary>
	/// <returns>A <see langword="String" /> representing the <see cref="P:System.Data.SqlTypes.SqlDateTime.Value" /> property of this <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Performs a logical comparison of two <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structures to determine whether they are equal.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</param>
	/// <returns>
	///   <see langword="true" /> if the two values are equal. Otherwise, <see langword="false" />.</returns>
	public static SqlBoolean operator ==(SqlDateTime x, SqlDateTime y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlDateTime" /> to determine whether the first is less than the second.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlDateTime" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
	public static SqlBoolean operator <(SqlDateTime x, SqlDateTime y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlDateTime" /> to determine whether the first is greater than the second.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlBoolean" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
	public static SqlBoolean operator >(SqlDateTime x, SqlDateTime y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlDateTime" /> to determine whether the first is less than the second.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlDateTime" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
	public static SqlBoolean LessThan(SqlDateTime x, SqlDateTime y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlDateTime" /> to determine whether the first is greater than the second.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlDateTime" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
	public static SqlBoolean GreaterThan(SqlDateTime x, SqlDateTime y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Compares this <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure to the supplied <see cref="T:System.Object" /> and returns an indication of their relative values.</summary>
	/// <param name="value">The <see cref="T:System.Object" /> to be compared.</param>
	/// <returns>A signed number that indicates the relative values of the instance and the object.  
	///   Return value  
	///
	///   Condition  
	///
	///   Less than zero  
	///
	///   This instance is less than the object.  
	///
	///   Zero  
	///
	///   This instance is the same as the object.  
	///
	///   Greater than zero  
	///
	///   This instance is greater than the object  
	///
	///  -or-  
	///
	///  The object is a null reference (<see langword="Nothing" /> as Visual Basic).</returns>
	public int CompareTo(object value)
	{
		return 0;
	}

	/// <summary>Compares this <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure to the supplied <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure and returns an indication of their relative values.</summary>
	/// <param name="value">The <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure to be compared.</param>
	/// <returns>A signed number that indicates the relative values of the instance and the object.  
	///   Return value  
	///
	///   Condition  
	///
	///   Less than zero  
	///
	///   This instance is less than <see cref="T:System.Data.SqlTypes.SqlDateTime" />.  
	///
	///   Zero  
	///
	///   This instance is the same as <see cref="T:System.Data.SqlTypes.SqlDateTime" />.  
	///
	///   Greater than zero  
	///
	///   This instance is greater than <see cref="T:System.Data.SqlTypes.SqlDateTime" />  
	///
	///  -or-  
	///
	///  <see cref="T:System.Data.SqlTypes.SqlDateTime" /> is a null reference (<see langword="Nothing" /> in Visual Basic)</returns>
	public int CompareTo(SqlDateTime value)
	{
		return 0;
	}

	/// <summary>Compares the supplied object parameter to the <see cref="P:System.Data.SqlTypes.SqlDateTime.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlDateTime" /> object.</summary>
	/// <param name="value">The object to be compared.</param>
	/// <returns>
	///   <see langword="true" /> if the object is an instance of <see cref="T:System.Data.SqlTypes.SqlDateTime" /> and the two are equal; otherwise <see langword="false" />.</returns>
	public override bool Equals(object value)
	{
		return false;
	}

	/// <summary>Gets the hash code for this instance.</summary>
	/// <returns>A 32-bit signed integer hash code.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
	/// <returns>An <see langword="XmlSchema" />.</returns>
	XmlSchema IXmlSerializable.GetSchema()
	{
		return null;
	}

	/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
	/// <param name="reader">
	///   <see langword="XmlReader" />
	/// </param>
	void IXmlSerializable.ReadXml(XmlReader reader)
	{
	}

	/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
	/// <param name="writer">
	///   <see langword="XmlWriter" />
	/// </param>
	void IXmlSerializable.WriteXml(XmlWriter writer)
	{
	}

	/// <summary>Returns the XML Schema definition language (XSD) of the specified <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
	/// <param name="schemaSet">A <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</param>
	/// <returns>A <see langword="string" /> value that indicates the XSD of the specified <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</returns>
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
	{
		return null;
	}
}
