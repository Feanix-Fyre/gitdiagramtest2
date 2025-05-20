using System.Globalization;

namespace System.ComponentModel;

/// <summary>Provides a type converter to convert <see cref="T:System.Boolean" /> objects to and from various other representations.</summary>
public class BooleanConverter : TypeConverter
{
	private static StandardValuesCollection s_values;

	/// <summary>Gets a value indicating whether this converter can convert an object in the given source type to a Boolean object using the specified context.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
	/// <param name="sourceType">A <see cref="T:System.Type" /> that represents the type you wish to convert from.</param>
	/// <returns>
	///   <see langword="true" /> if this object can perform the conversion; otherwise, <see langword="false" />.</returns>
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
	{
		return false;
	}

	/// <summary>Converts the given value object to a Boolean object.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
	/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" /> that specifies the culture to which to convert.</param>
	/// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
	/// <returns>An <see cref="T:System.Object" /> that represents the converted <paramref name="value" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not a valid value for the target type.</exception>
	/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed.</exception>
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		return null;
	}

	/// <summary>Gets a collection of standard values for the Boolean data type.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
	/// <returns>A <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" /> that holds a standard set of valid values.</returns>
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
	{
		return null;
	}

	/// <summary>Gets a value indicating whether the list of standard values returned from the <see cref="M:System.ComponentModel.BooleanConverter.GetStandardValues(System.ComponentModel.ITypeDescriptorContext)" /> method is an exclusive list.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
	/// <returns>
	///   <see langword="true" /> because the <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" /> returned from <see cref="M:System.ComponentModel.BooleanConverter.GetStandardValues(System.ComponentModel.ITypeDescriptorContext)" /> is an exhaustive list of possible values. This method never returns <see langword="false" />.</returns>
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
	{
		return false;
	}

	/// <summary>Gets a value indicating whether this object supports a standard set of values that can be picked from a list.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
	/// <returns>
	///   <see langword="true" /> because <see cref="M:System.ComponentModel.BooleanConverter.GetStandardValues(System.ComponentModel.ITypeDescriptorContext)" /> can be called to find a common set of values the object supports. This method never returns <see langword="false" />.</returns>
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
	{
		return false;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.BooleanConverter" /> class.</summary>
	public BooleanConverter()
	{
	}
}
