using System.Globalization;

namespace System.ComponentModel;

/// <summary>Provides a type converter to convert collection objects to and from various other representations.</summary>
public class CollectionConverter : TypeConverter
{
	/// <summary>Converts the given value object to the specified destination type.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
	/// <param name="culture">The culture to which <paramref name="value" /> will be converted.</param>
	/// <param name="value">The <see cref="T:System.Object" /> to convert. This parameter must inherit from <see cref="T:System.Collections.ICollection" />.</param>
	/// <param name="destinationType">The <see cref="T:System.Type" /> to convert the value to.</param>
	/// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="destinationType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed.</exception>
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		return null;
	}

	/// <summary>Gets a collection of properties for the type of array specified by the value parameter using the specified context and attributes.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
	/// <param name="value">An <see cref="T:System.Object" /> that specifies the type of array to get the properties for.</param>
	/// <param name="attributes">An array of type <see cref="T:System.Attribute" /> that will be used as a filter.</param>
	/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> with the properties that are exposed for this data type, or <see langword="null" /> if there are no properties. This method always returns <see langword="null" />.</returns>
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
	{
		return null;
	}

	/// <summary>Gets a value indicating whether this object supports properties.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
	/// <returns>
	///   <see langword="false" /> because <see cref="M:System.ComponentModel.CollectionConverter.GetProperties(System.ComponentModel.ITypeDescriptorContext,System.Object,System.Attribute[])" /> should not be called to find the properties of this object. This method never returns <see langword="true" />.</returns>
	public override bool GetPropertiesSupported(ITypeDescriptorContext context)
	{
		return false;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.CollectionConverter" /> class.</summary>
	public CollectionConverter()
	{
	}
}
