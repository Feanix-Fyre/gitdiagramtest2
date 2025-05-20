using System.ComponentModel;
using System.Globalization;

namespace System.Windows.Forms;

/// <summary>Provides a type converter to convert data for an image index to and from a string.</summary>
public class ImageIndexConverter : Int32Converter
{
	/// <summary>Initializes and instance of the <see cref="T:System.Windows.Forms.ImageIndexConverter" /> class.</summary>
	public ImageIndexConverter()
	{
	}

	/// <summary>Converts the specified value object to a 32-bit signed integer object.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
	/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" /> to provide locale information.</param>
	/// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
	/// <returns>An <see cref="T:System.Object" /> that represents the converted <paramref name="value" />.</returns>
	/// <exception cref="T:System.Exception">The conversion could not be performed.</exception>
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		return null;
	}

	/// <summary>Converts the specified object to the specified destination type.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context, which can be used to extract additional information about the environment this type converter is being invoked from. This parameter or properties of this parameter can be <see langword="null" />.</param>
	/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" /> that provides locale information.</param>
	/// <param name="value">The object to convert, typically an index represented as an <see cref="T:System.Int32" />.</param>
	/// <param name="destinationType">The type to convert the object to, often a <see cref="T:System.String" />.</param>
	/// <returns>An <see cref="T:System.Object" /> that represents the converted <paramref name="value" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="destinationType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">The specified <paramref name="value" /> could not be converted to the specified <paramref name="destinationType" />.</exception>
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		return null;
	}

	/// <summary>Returns a collection of standard index values for the image list associated with the specified format context.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context, which can be used to extract additional information about the environment this type converter is being invoked from. This parameter or properties of this parameter can be <see langword="null" />.</param>
	/// <returns>A <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" /> that holds a standard set of valid index values. If no image list is found, this collection will contain a single object with a value of -1.</returns>
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
	{
		return null;
	}

	/// <summary>Determines if the list of standard values returned from the <see cref="Overload:System.Windows.Forms.ImageIndexConverter.GetStandardValues" /> method is an exclusive list.</summary>
	/// <param name="context">A formatter context.</param>
	/// <returns>
	///   <see langword="true" /> if the <see cref="Overload:System.Windows.Forms.ImageIndexConverter.GetStandardValues" /> method returns an exclusive list of valid values; otherwise, <see langword="false" />. This implementation always returns <see langword="false" />.</returns>
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
	{
		return false;
	}

	/// <summary>Determines if the type converter supports a standard set of values that can be picked from a list.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context, which can be used to extract additional information about the environment this type converter is being invoked from. This parameter or properties of this parameter can be <see langword="null" />.</param>
	/// <returns>
	///   <see langword="true" /> if the <see cref="Overload:System.Windows.Forms.ImageIndexConverter.GetStandardValues" /> method returns a standard set of values; otherwise, <see langword="false" />. Always returns <see langword="true" />.</returns>
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
	{
		return false;
	}
}
