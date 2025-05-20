using System.Collections;
using System.ComponentModel;
using System.Globalization;

namespace System.Windows.Forms;

/// <summary>Provides a <see cref="T:System.ComponentModel.TypeConverter" /> to convert <see cref="T:System.Windows.Forms.Keys" /> objects to and from other representations.</summary>
public class KeysConverter : TypeConverter, IComparer
{
	/// <summary>Initializes an instance of the <see cref="T:System.Windows.Forms.KeysConverter" /> class.</summary>
	public KeysConverter()
	{
	}

	/// <summary>Returns a value indicating whether this converter can convert an object in the specified source type to the native type of the converter using the specified context.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context, which can be used to extract additional information about the environment this converter is being invoked from. This parameter or properties of this parameter can be <see langword="null" />.</param>
	/// <param name="sourceType">The <see cref="T:System.Type" /> to convert from.</param>
	/// <returns>
	///   <see langword="true" /> if the conversion can be performed; otherwise, <see langword="false" />.</returns>
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
	{
		return false;
	}

	/// <summary>Returns a value indicating whether this converter can convert an object in the specified source type to the native type of the converter using the specified context.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context, which can be used to extract additional information about the environment this converter is being invoked from. This parameter or properties of this parameter can be <see langword="null" />.</param>
	/// <param name="destinationType">The <see cref="T:System.Type" /> to convert to.</param>
	/// <returns>
	///   <see langword="true" /> if the conversion can be performed; otherwise, <see langword="false" />.</returns>
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
	{
		return false;
	}

	/// <summary>Compares two key values for equivalence.</summary>
	/// <param name="a">An <see cref="T:System.Object" /> that represents the first key to compare.</param>
	/// <param name="b">An <see cref="T:System.Object" /> that represents the second key to compare.</param>
	/// <returns>An integer indicating the relationship between the two parameters.  
	///   Value Type  
	///
	///   Condition  
	///
	///   A negative integer.  
	///
	///  <paramref name="a" /> is less than <paramref name="b" />.  
	///
	///   zero  
	///
	///  <paramref name="a" /> equals <paramref name="b" />.  
	///
	///   A positive integer.  
	///
	///  <paramref name="a" /> is greater than <paramref name="b" />.</returns>
	public int Compare(object a, object b)
	{
		return 0;
	}

	/// <summary>Converts the specified object to the converter's native type.</summary>
	/// <param name="context">An <see langword="ITypeDescriptorContext" /> that provides a format context, which can be used to extract additional information about the environment this converter is being invoked from. This parameter or properties of this parameter can be null.</param>
	/// <param name="culture">A <see langword="CultureInfo" /> object to provide locale information.</param>
	/// <param name="value">The object to convert.</param>
	/// <returns>An object that represents the converted <paramref name="value" />.</returns>
	/// <exception cref="T:System.FormatException">An invalid key combination was supplied.  
	///  -or-  
	///  An invalid key name was supplied.</exception>
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		return null;
	}

	/// <summary>Converts the specified object to the specified destination type.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context, which can be used to extract additional information about the environment this converter is being invoked from. This parameter or properties of this parameter can be <see langword="null" />.</param>
	/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" /> to provide locale information.</param>
	/// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
	/// <param name="destinationType">The <see cref="T:System.Type" /> to convert the object to.</param>
	/// <returns>An <see cref="T:System.Object" /> that represents the converted <paramref name="value" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="destinationType" /> is <see langword="null" />.</exception>
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		return null;
	}

	/// <summary>Returns a collection of standard values for the data type that this type converter is designed for when provided with a format context.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context, which can be used to extract additional information about the environment this converter is being invoked from. This parameter or properties of this parameter can be <see langword="null" />.</param>
	/// <returns>A <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" /> that holds a standard set of valid values, which can be empty if the data type does not support a standard set of values.</returns>
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
	{
		return null;
	}

	/// <summary>Determines if the list of standard values returned from <see langword="GetStandardValues" /> is an exclusive list using the specified <see cref="T:System.ComponentModel.ITypeDescriptorContext" />.</summary>
	/// <param name="context">A formatter context. This object can be used to extract additional information about the environment this converter is being invoked from. This may be <see langword="null" />, so you should always check. Also, properties on the context object may also return <see langword="null" />.</param>
	/// <returns>
	///   <see langword="true" /> if the collection returned from <see cref="Overload:System.Windows.Forms.KeysConverter.GetStandardValues" /> is an exhaustive list of possible values; otherwise, <see langword="false" /> if other values are possible. The default implementation for this method always returns <see langword="false" />.</returns>
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
	{
		return false;
	}

	/// <summary>Gets a value indicating whether this object supports a standard set of values that can be picked from a list.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context, which can be used to extract additional information about the environment this converter is being invoked from. This parameter or properties of this parameter can be <see langword="null" />.</param>
	/// <returns>Always returns <see langword="true" />.</returns>
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
	{
		return false;
	}
}
