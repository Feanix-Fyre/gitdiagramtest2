using System.ComponentModel;
using System.Globalization;

namespace System.Drawing;

/// <summary>
///   <see cref="T:System.Drawing.ImageFormatConverter" /> is a class that can be used to convert <see cref="T:System.Drawing.Imaging.ImageFormat" /> objects from one data type to another. Access this class through the <see cref="T:System.ComponentModel.TypeDescriptor" /> object.</summary>
public class ImageFormatConverter : TypeConverter
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.ImageFormatConverter" /> class.</summary>
	public ImageFormatConverter()
	{
	}

	/// <summary>Indicates whether this converter can convert an object in the specified source type to the native type of the converter.</summary>
	/// <param name="context">A formatter context. This object can be used to get more information about the environment this converter is being called from. This may be <see langword="null" />, so you should always check. Also, properties on the context object may also return <see langword="null" />.</param>
	/// <param name="sourceType">The type you want to convert from.</param>
	/// <returns>This method returns <see langword="true" /> if this object can perform the conversion.</returns>
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
	{
		return false;
	}

	/// <summary>Gets a value indicating whether this converter can convert an object to the specified destination type using the context.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that specifies the context for this type conversion.</param>
	/// <param name="destinationType">The <see cref="T:System.Type" /> that represents the type to which you want to convert this <see cref="T:System.Drawing.Imaging.ImageFormat" /> object.</param>
	/// <returns>This method returns <see langword="true" /> if this object can perform the conversion.</returns>
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
	{
		return false;
	}

	/// <summary>Converts the specified object to an <see cref="T:System.Drawing.Imaging.ImageFormat" /> object.</summary>
	/// <param name="context">A formatter context. This object can be used to get more information about the environment this converter is being called from. This may be <see langword="null" />, so you should always check. Also, properties on the context object may also return <see langword="null" />.</param>
	/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" /> object that specifies formatting conventions for a particular culture.</param>
	/// <param name="value">The object to convert.</param>
	/// <returns>The converted object.</returns>
	/// <exception cref="T:System.NotSupportedException">The conversion cannot be completed.</exception>
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		return null;
	}

	/// <summary>Converts the specified object to the specified type.</summary>
	/// <param name="context">A formatter context. This object can be used to get more information about the environment this converter is being called from. This may be <see langword="null" />, so you should always check. Also, properties on the context object may also return <see langword="null" />.</param>
	/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" /> object that specifies formatting conventions for a particular culture.</param>
	/// <param name="value">The object to convert.</param>
	/// <param name="destinationType">The type to convert the object to.</param>
	/// <returns>The converted object.</returns>
	/// <exception cref="T:System.NotSupportedException">The conversion cannot be completed.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="destinationType" /> is <see langword="null." /></exception>
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		return null;
	}

	/// <summary>Gets a collection that contains a set of standard values for the data type this validator is designed for. Returns <see langword="null" /> if the data type does not support a standard set of values.</summary>
	/// <param name="context">A formatter context. This object can be used to get more information about the environment this converter is being called from. This may be <see langword="null" />, so you should always check. Also, properties on the context object may also return <see langword="null" />.</param>
	/// <returns>A collection that contains a standard set of valid values, or <see langword="null" />. The default implementation always returns <see langword="null" />.</returns>
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
	{
		return null;
	}

	/// <summary>Indicates whether this object supports a standard set of values that can be picked from a list.</summary>
	/// <param name="context">A type descriptor through which additional context can be provided.</param>
	/// <returns>This method returns <see langword="true" /> if the <see cref="Overload:System.Drawing.ImageFormatConverter.GetStandardValues" /> method should be called to find a common set of values the object supports.</returns>
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
	{
		return false;
	}
}
