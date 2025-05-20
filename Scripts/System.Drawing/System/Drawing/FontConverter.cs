using System.Collections;
using System.ComponentModel;
using System.Globalization;

namespace System.Drawing;

/// <summary>Converts <see cref="T:System.Drawing.Font" /> objects from one data type to another.</summary>
public class FontConverter : TypeConverter
{
	/// <summary>
	///   <see cref="T:System.Drawing.FontConverter.FontNameConverter" /> is a type converter that is used to convert a font name to and from various other representations.</summary>
	public sealed class FontNameConverter : TypeConverter, IDisposable
	{
		private FontFamily[] fonts;

		/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.FontConverter.FontNameConverter" /> class.</summary>
		public FontNameConverter()
		{
		}

		/// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
		void IDisposable.Dispose()
		{
		}

		/// <summary>Determines if this converter can convert an object in the given source type to the native type of the converter.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that can be used to extract additional information about the environment this converter is being invoked from. This may be <see langword="null" />, so you should always check. Also, properties on the context object may return <see langword="null" />.</param>
		/// <param name="sourceType">The type you wish to convert from.</param>
		/// <returns>
		///   <see langword="true" /> if the converter can perform the conversion; otherwise, <see langword="false" />.</returns>
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return false;
		}

		/// <summary>Converts the given object to the converter's native type.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that can be used to extract additional information about the environment this converter is being invoked from. This may be <see langword="null" />, so you should always check. Also, properties on the context object may return <see langword="null" />.</param>
		/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" /> to use to perform the conversion</param>
		/// <param name="value">The object to convert.</param>
		/// <returns>The converted object.</returns>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be completed.</exception>
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			return null;
		}

		/// <summary>Retrieves a collection containing a set of standard values for the data type this converter is designed for.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that can be used to extract additional information about the environment this converter is being invoked from. This may be <see langword="null" />, so you should always check. Also, properties on the context object may return <see langword="null" />.</param>
		/// <returns>A collection containing a standard set of valid values, or <see langword="null" />. The default is <see langword="null" />.</returns>
		public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			return null;
		}

		/// <summary>Determines if the list of standard values returned from the <see cref="Overload:System.Drawing.FontConverter.FontNameConverter.GetStandardValues" /> method is an exclusive list.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that can be used to extract additional information about the environment this converter is being invoked from. This may be <see langword="null" />, so you should always check. Also, properties on the context object may return <see langword="null" />.</param>
		/// <returns>
		///   <see langword="true" /> if the collection returned from <see cref="Overload:System.Drawing.FontConverter.FontNameConverter.GetStandardValues" /> is an exclusive list of possible values; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return false;
		}

		/// <summary>Determines if this object supports a standard set of values that can be picked from a list.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that can be used to extract additional information about the environment this converter is being invoked from. This may be <see langword="null" />, so you should always check. Also, properties on the context object may return <see langword="null" />.</param>
		/// <returns>
		///   <see langword="true" /> if <see cref="Overload:System.Drawing.FontConverter.FontNameConverter.GetStandardValues" /> should be called to find a common set of values the object supports; otherwise, <see langword="false" />.</returns>
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return false;
		}
	}

	/// <summary>Converts font units to and from other unit types.</summary>
	public class FontUnitConverter : EnumConverter
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.FontConverter.FontUnitConverter" /> class.</summary>
		public FontUnitConverter()
			: base(null)
		{
		}

		/// <summary>Returns a collection of standard values valid for the <see cref="T:System.Drawing.Font" /> type.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
		public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			return null;
		}
	}

	/// <summary>Initializes a new <see cref="T:System.Drawing.FontConverter" /> object.</summary>
	public FontConverter()
	{
	}

	/// <summary>Allows the <see cref="T:System.Drawing.FontConverter" /> to attempt to free resources and perform other cleanup operations before the <see cref="T:System.Drawing.FontConverter" /> is reclaimed by garbage collection.</summary>
	~FontConverter()
	{
	}

	/// <summary>Determines whether this converter can convert an object in the specified source type to the native type of the converter.</summary>
	/// <param name="context">A formatter context. This object can be used to get additional information about the environment this converter is being called from. This may be <see langword="null" />, so you should always check. Also, properties on the context object may also return <see langword="null" />.</param>
	/// <param name="sourceType">The type you want to convert from.</param>
	/// <returns>This method returns <see langword="true" /> if this object can perform the conversion.</returns>
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
	{
		return false;
	}

	/// <summary>Gets a value indicating whether this converter can convert an object to the given destination type using the context.</summary>
	/// <param name="context">An <see langword="ITypeDescriptorContext" /> object that provides a format context.</param>
	/// <param name="destinationType">A <see cref="T:System.Type" /> object that represents the type you want to convert to.</param>
	/// <returns>This method returns <see langword="true" /> if this converter can perform the conversion; otherwise, <see langword="false" />.</returns>
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
	{
		return false;
	}

	/// <summary>Converts the specified object to another type.</summary>
	/// <param name="context">A formatter context. This object can be used to get additional information about the environment this converter is being called from. This may be <see langword="null" />, so you should always check. Also, properties on the context object may also return <see langword="null" />.</param>
	/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" /> object that specifies the culture used to represent the object.</param>
	/// <param name="value">The object to convert.</param>
	/// <param name="destinationType">The data type to convert the object to.</param>
	/// <returns>The converted object.</returns>
	/// <exception cref="T:System.NotSupportedException">The conversion was not successful.</exception>
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		return null;
	}

	/// <summary>Converts the specified object to the native type of the converter.</summary>
	/// <param name="context">A formatter context. This object can be used to get additional information about the environment this converter is being called from. This may be <see langword="null" />, so you should always check. Also, properties on the context object may also return <see langword="null" />.</param>
	/// <param name="culture">A <see langword="CultureInfo" /> object that specifies the culture used to represent the font.</param>
	/// <param name="value">The object to convert.</param>
	/// <returns>The converted object.</returns>
	/// <exception cref="T:System.NotSupportedException">The conversion could not be performed.</exception>
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		return null;
	}

	/// <summary>Creates an object of this type by using a specified set of property values for the object.</summary>
	/// <param name="context">A type descriptor through which additional context can be provided.</param>
	/// <param name="propertyValues">A dictionary of new property values. The dictionary contains a series of name-value pairs, one for each property returned from the <see cref="Overload:System.Drawing.FontConverter.GetProperties" /> method.</param>
	/// <returns>The newly created object, or <see langword="null" /> if the object could not be created. The default implementation returns <see langword="null" />.  
	///  <see cref="M:System.Drawing.FontConverter.CreateInstance(System.ComponentModel.ITypeDescriptorContext,System.Collections.IDictionary)" /> useful for creating non-changeable objects that have changeable properties.</returns>
	public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
	{
		return null;
	}

	/// <summary>Determines whether changing a value on this object should require a call to the <see cref="Overload:System.Drawing.FontConverter.CreateInstance" /> method to create a new value.</summary>
	/// <param name="context">A type descriptor through which additional context can be provided.</param>
	/// <returns>This method returns <see langword="true" /> if the <see langword="CreateInstance" /> object should be called when a change is made to one or more properties of this object; otherwise, <see langword="false" />.</returns>
	public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
	{
		return false;
	}

	/// <summary>Retrieves the set of properties for this type. By default, a type does not have any properties to return.</summary>
	/// <param name="context">A type descriptor through which additional context can be provided.</param>
	/// <param name="value">The value of the object to get the properties for.</param>
	/// <param name="attributes">An array of <see cref="T:System.Attribute" /> objects that describe the properties.</param>
	/// <returns>The set of properties that should be exposed for this data type. If no properties should be exposed, this may return <see langword="null" />. The default implementation always returns <see langword="null" />.  
	///  An easy implementation of this method can call the <see cref="Overload:System.ComponentModel.TypeConverter.GetProperties" /> method for the correct data type.</returns>
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
	{
		return null;
	}

	/// <summary>Determines whether this object supports properties. The default is <see langword="false" />.</summary>
	/// <param name="context">A type descriptor through which additional context can be provided.</param>
	/// <returns>This method returns <see langword="true" /> if the <see cref="M:System.Drawing.FontConverter.GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext)" /> method should be called to find the properties of this object; otherwise, <see langword="false" />.</returns>
	public override bool GetPropertiesSupported(ITypeDescriptorContext context)
	{
		return false;
	}
}
