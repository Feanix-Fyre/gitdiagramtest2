using System.Collections;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.ComponentModel;

/// <summary>Provides a unified way of converting types of values to other types, as well as for accessing standard values and subproperties.</summary>
[ComVisible(true)]
public class TypeConverter
{
	/// <summary>Represents an <see langword="abstract" /> class that provides properties for objects that do not have properties.</summary>
	protected abstract class SimplePropertyDescriptor : PropertyDescriptor
	{
		private Type componentType;

		private Type propertyType;

		/// <summary>Gets the type of component to which this property description binds.</summary>
		/// <returns>A <see cref="T:System.Type" /> that represents the type of component to which this property binds.</returns>
		public override Type ComponentType => null;

		/// <summary>Gets a value indicating whether this property is read-only.</summary>
		/// <returns>
		///   <see langword="true" /> if the property is read-only; <see langword="false" /> if the property is read/write.</returns>
		public override bool IsReadOnly => false;

		/// <summary>Gets the type of the property.</summary>
		/// <returns>A <see cref="T:System.Type" /> that represents the type of the property.</returns>
		public override Type PropertyType => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.TypeConverter.SimplePropertyDescriptor" /> class.</summary>
		/// <param name="componentType">A <see cref="T:System.Type" /> that represents the type of component to which this property descriptor binds.</param>
		/// <param name="name">The name of the property.</param>
		/// <param name="propertyType">A <see cref="T:System.Type" /> that represents the data type for this property.</param>
		protected SimplePropertyDescriptor(Type componentType, string name, Type propertyType)
			: base((string)null, (Attribute[])null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.TypeConverter.SimplePropertyDescriptor" /> class.</summary>
		/// <param name="componentType">A <see cref="T:System.Type" /> that represents the type of component to which this property descriptor binds.</param>
		/// <param name="name">The name of the property.</param>
		/// <param name="propertyType">A <see cref="T:System.Type" /> that represents the data type for this property.</param>
		/// <param name="attributes">An <see cref="T:System.Attribute" /> array with the attributes to associate with the property.</param>
		protected SimplePropertyDescriptor(Type componentType, string name, Type propertyType, Attribute[] attributes)
			: base((string)null, (Attribute[])null)
		{
		}

		/// <summary>Returns whether resetting the component changes the value of the component.</summary>
		/// <param name="component">The component to test for reset capability.</param>
		/// <returns>
		///   <see langword="true" /> if resetting the component changes the value of the component; otherwise, <see langword="false" />.</returns>
		public override bool CanResetValue(object component)
		{
			return false;
		}

		/// <summary>Resets the value for this property of the component.</summary>
		/// <param name="component">The component with the property value to be reset.</param>
		public override void ResetValue(object component)
		{
		}

		/// <summary>Returns whether the value of this property can persist.</summary>
		/// <param name="component">The component with the property that is to be examined for persistence.</param>
		/// <returns>
		///   <see langword="true" /> if the value of the property can persist; otherwise, <see langword="false" />.</returns>
		public override bool ShouldSerializeValue(object component)
		{
			return false;
		}
	}

	/// <summary>Represents a collection of values.</summary>
	public class StandardValuesCollection : ICollection, IEnumerable
	{
		private ICollection values;

		private Array valueArray;

		/// <summary>Gets the number of objects in the collection.</summary>
		/// <returns>The number of objects in the collection.</returns>
		public int Count => 0;

		/// <summary>Gets the object at the specified index number.</summary>
		/// <param name="index">The zero-based index of the <see cref="T:System.Object" /> to get from the collection.</param>
		/// <returns>The <see cref="T:System.Object" /> with the specified index.</returns>
		public object this[int index] => null;

		/// <summary>For a description of this member, see <see cref="P:System.Collections.ICollection.Count" />.</summary>
		/// <returns>The number of elements contained in the <see cref="T:System.Collections.ICollection" />.</returns>
		int ICollection.Count => 0;

		/// <summary>For a description of this member, see <see cref="P:System.Collections.ICollection.IsSynchronized" />.</summary>
		/// <returns>
		///   <see langword="false" /> in all cases.</returns>
		bool ICollection.IsSynchronized => false;

		/// <summary>For a description of this member, see <see cref="P:System.Collections.ICollection.SyncRoot" />.</summary>
		/// <returns>
		///   <see langword="null" /> in all cases.</returns>
		object ICollection.SyncRoot => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" /> class.</summary>
		/// <param name="values">An <see cref="T:System.Collections.ICollection" /> that represents the objects to put into the collection.</param>
		public StandardValuesCollection(ICollection values)
		{
		}

		/// <summary>Copies the contents of this collection to an array.</summary>
		/// <param name="array">An <see cref="T:System.Array" /> that represents the array to copy to.</param>
		/// <param name="index">The index to start from.</param>
		public void CopyTo(Array array, int index)
		{
		}

		/// <summary>Returns an enumerator for this collection.</summary>
		/// <returns>An enumerator of type <see cref="T:System.Collections.IEnumerator" />.</returns>
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		/// <summary>Copies the contents of this collection to an array.</summary>
		/// <param name="array">The array to copy to.</param>
		/// <param name="index">The index in the array where copying should begin.</param>
		void ICollection.CopyTo(Array array, int index)
		{
		}

		/// <summary>For a description of this member, see <see cref="M:System.Collections.IEnumerable.GetEnumerator" />.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that can be used to iterate through the collection.</returns>
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	private const string s_UseCompatibleTypeConverterBehavior = "UseCompatibleTypeConverterBehavior";

	private static bool useCompatibleTypeConversion;

	private static bool UseCompatibleTypeConversion => false;

	/// <summary>Returns whether this converter can convert an object of the given type to the type of this converter.</summary>
	/// <param name="sourceType">A <see cref="T:System.Type" /> that represents the type you want to convert from.</param>
	/// <returns>
	///   <see langword="true" /> if this converter can perform the conversion; otherwise, <see langword="false" />.</returns>
	public bool CanConvertFrom(Type sourceType)
	{
		return false;
	}

	/// <summary>Returns whether this converter can convert an object of the given type to the type of this converter, using the specified context.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
	/// <param name="sourceType">A <see cref="T:System.Type" /> that represents the type you want to convert from.</param>
	/// <returns>
	///   <see langword="true" /> if this converter can perform the conversion; otherwise, <see langword="false" />.</returns>
	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
	{
		return false;
	}

	/// <summary>Returns whether this converter can convert the object to the specified type.</summary>
	/// <param name="destinationType">A <see cref="T:System.Type" /> that represents the type you want to convert to.</param>
	/// <returns>
	///   <see langword="true" /> if this converter can perform the conversion; otherwise, <see langword="false" />.</returns>
	public bool CanConvertTo(Type destinationType)
	{
		return false;
	}

	/// <summary>Returns whether this converter can convert the object to the specified type, using the specified context.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
	/// <param name="destinationType">A <see cref="T:System.Type" /> that represents the type you want to convert to.</param>
	/// <returns>
	///   <see langword="true" /> if this converter can perform the conversion; otherwise, <see langword="false" />.</returns>
	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
	{
		return false;
	}

	/// <summary>Converts the given value to the type of this converter.</summary>
	/// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
	/// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
	/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed.</exception>
	public object ConvertFrom(object value)
	{
		return null;
	}

	/// <summary>Converts the given object to the type of this converter, using the specified context and culture information.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
	/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use as the current culture.</param>
	/// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
	/// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
	/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed.</exception>
	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		return null;
	}

	/// <summary>Converts the given string to the type of this converter, using the invariant culture.</summary>
	/// <param name="text">The <see cref="T:System.String" /> to convert.</param>
	/// <returns>An <see cref="T:System.Object" /> that represents the converted text.</returns>
	/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed.</exception>
	public object ConvertFromInvariantString(string text)
	{
		return null;
	}

	/// <summary>Converts the given string to the type of this converter, using the invariant culture and the specified context.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
	/// <param name="text">The <see cref="T:System.String" /> to convert.</param>
	/// <returns>An <see cref="T:System.Object" /> that represents the converted text.</returns>
	/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed.</exception>
	public object ConvertFromInvariantString(ITypeDescriptorContext context, string text)
	{
		return null;
	}

	/// <summary>Converts the specified text to an object.</summary>
	/// <param name="text">The text representation of the object to convert.</param>
	/// <returns>An <see cref="T:System.Object" /> that represents the converted text.</returns>
	/// <exception cref="T:System.NotSupportedException">The string cannot be converted into the appropriate object.</exception>
	public object ConvertFromString(string text)
	{
		return null;
	}

	/// <summary>Converts the given text to an object, using the specified context.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
	/// <param name="text">The <see cref="T:System.String" /> to convert.</param>
	/// <returns>An <see cref="T:System.Object" /> that represents the converted text.</returns>
	/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed.</exception>
	public object ConvertFromString(ITypeDescriptorContext context, string text)
	{
		return null;
	}

	/// <summary>Converts the given text to an object, using the specified context and culture information.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
	/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" />. If <see langword="null" /> is passed, the current culture is assumed.</param>
	/// <param name="text">The <see cref="T:System.String" /> to convert.</param>
	/// <returns>An <see cref="T:System.Object" /> that represents the converted text.</returns>
	/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed.</exception>
	public object ConvertFromString(ITypeDescriptorContext context, CultureInfo culture, string text)
	{
		return null;
	}

	/// <summary>Converts the given value object to the specified type, using the arguments.</summary>
	/// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
	/// <param name="destinationType">The <see cref="T:System.Type" /> to convert the <paramref name="value" /> parameter to.</param>
	/// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="destinationType" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed.</exception>
	public object ConvertTo(object value, Type destinationType)
	{
		return null;
	}

	/// <summary>Converts the given value object to the specified type, using the specified context and culture information.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
	/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" />. If <see langword="null" /> is passed, the current culture is assumed.</param>
	/// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
	/// <param name="destinationType">The <see cref="T:System.Type" /> to convert the <paramref name="value" /> parameter to.</param>
	/// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="destinationType" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed.</exception>
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		return null;
	}

	/// <summary>Converts the specified value to a culture-invariant string representation.</summary>
	/// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
	/// <returns>A <see cref="T:System.String" /> that represents the converted value.</returns>
	/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed.</exception>
	public string ConvertToInvariantString(object value)
	{
		return null;
	}

	/// <summary>Converts the specified value to a culture-invariant string representation, using the specified context.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
	/// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
	/// <returns>A <see cref="T:System.String" /> that represents the converted value.</returns>
	/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed.</exception>
	public string ConvertToInvariantString(ITypeDescriptorContext context, object value)
	{
		return null;
	}

	/// <summary>Converts the specified value to a string representation.</summary>
	/// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
	/// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
	/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed.</exception>
	public string ConvertToString(object value)
	{
		return null;
	}

	/// <summary>Converts the given value to a string representation, using the given context.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
	/// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
	/// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
	/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed.</exception>
	public string ConvertToString(ITypeDescriptorContext context, object value)
	{
		return null;
	}

	/// <summary>Converts the given value to a string representation, using the specified context and culture information.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
	/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" />. If <see langword="null" /> is passed, the current culture is assumed.</param>
	/// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
	/// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
	/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed.</exception>
	public string ConvertToString(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		return null;
	}

	/// <summary>Re-creates an <see cref="T:System.Object" /> given a set of property values for the object.</summary>
	/// <param name="propertyValues">An <see cref="T:System.Collections.IDictionary" /> that represents a dictionary of new property values.</param>
	/// <returns>An <see cref="T:System.Object" /> representing the given <see cref="T:System.Collections.IDictionary" />, or <see langword="null" /> if the object cannot be created. This method always returns <see langword="null" />.</returns>
	public object CreateInstance(IDictionary propertyValues)
	{
		return null;
	}

	/// <summary>Creates an instance of the type that this <see cref="T:System.ComponentModel.TypeConverter" /> is associated with, using the specified context, given a set of property values for the object.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
	/// <param name="propertyValues">An <see cref="T:System.Collections.IDictionary" /> of new property values.</param>
	/// <returns>An <see cref="T:System.Object" /> representing the given <see cref="T:System.Collections.IDictionary" />, or <see langword="null" /> if the object cannot be created. This method always returns <see langword="null" />.</returns>
	public virtual object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
	{
		return null;
	}

	/// <summary>Returns an exception to throw when a conversion cannot be performed.</summary>
	/// <param name="value">The <see cref="T:System.Object" /> to convert, or <see langword="null" /> if the object is not available.</param>
	/// <returns>An <see cref="T:System.Exception" /> that represents the exception to throw when a conversion cannot be performed.</returns>
	/// <exception cref="T:System.NotSupportedException">Automatically thrown by this method.</exception>
	protected Exception GetConvertFromException(object value)
	{
		return null;
	}

	/// <summary>Returns an exception to throw when a conversion cannot be performed.</summary>
	/// <param name="value">The <see cref="T:System.Object" /> to convert, or <see langword="null" /> if the object is not available.</param>
	/// <param name="destinationType">A <see cref="T:System.Type" /> that represents the type the conversion was trying to convert to.</param>
	/// <returns>An <see cref="T:System.Exception" /> that represents the exception to throw when a conversion cannot be performed.</returns>
	/// <exception cref="T:System.NotSupportedException">Automatically thrown by this method.</exception>
	protected Exception GetConvertToException(object value, Type destinationType)
	{
		return null;
	}

	/// <summary>Returns whether changing a value on this object requires a call to the <see cref="M:System.ComponentModel.TypeConverter.CreateInstance(System.Collections.IDictionary)" /> method to create a new value.</summary>
	/// <returns>
	///   <see langword="true" /> if changing a property on this object requires a call to <see cref="M:System.ComponentModel.TypeConverter.CreateInstance(System.Collections.IDictionary)" /> to create a new value; otherwise, <see langword="false" />.</returns>
	public bool GetCreateInstanceSupported()
	{
		return false;
	}

	/// <summary>Returns whether changing a value on this object requires a call to <see cref="M:System.ComponentModel.TypeConverter.CreateInstance(System.Collections.IDictionary)" /> to create a new value, using the specified context.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
	/// <returns>
	///   <see langword="true" /> if changing a property on this object requires a call to <see cref="M:System.ComponentModel.TypeConverter.CreateInstance(System.Collections.IDictionary)" /> to create a new value; otherwise, <see langword="false" />.</returns>
	public virtual bool GetCreateInstanceSupported(ITypeDescriptorContext context)
	{
		return false;
	}

	/// <summary>Returns a collection of properties for the type of array specified by the value parameter.</summary>
	/// <param name="value">An <see cref="T:System.Object" /> that specifies the type of array for which to get properties.</param>
	/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> with the properties that are exposed for this data type, or <see langword="null" /> if there are no properties.</returns>
	public PropertyDescriptorCollection GetProperties(object value)
	{
		return null;
	}

	/// <summary>Returns a collection of properties for the type of array specified by the value parameter, using the specified context.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
	/// <param name="value">An <see cref="T:System.Object" /> that specifies the type of array for which to get properties.</param>
	/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> with the properties that are exposed for this data type, or <see langword="null" /> if there are no properties.</returns>
	public PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value)
	{
		return null;
	}

	/// <summary>Returns a collection of properties for the type of array specified by the value parameter, using the specified context and attributes.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
	/// <param name="value">An <see cref="T:System.Object" /> that specifies the type of array for which to get properties.</param>
	/// <param name="attributes">An array of type <see cref="T:System.Attribute" /> that is used as a filter.</param>
	/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> with the properties that are exposed for this data type, or <see langword="null" /> if there are no properties.</returns>
	public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
	{
		return null;
	}

	/// <summary>Returns whether this object supports properties.</summary>
	/// <returns>
	///   <see langword="true" /> if <see cref="M:System.ComponentModel.TypeConverter.GetProperties(System.Object)" /> should be called to find the properties of this object; otherwise, <see langword="false" />.</returns>
	public bool GetPropertiesSupported()
	{
		return false;
	}

	/// <summary>Returns whether this object supports properties, using the specified context.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
	/// <returns>
	///   <see langword="true" /> if <see cref="M:System.ComponentModel.TypeConverter.GetProperties(System.Object)" /> should be called to find the properties of this object; otherwise, <see langword="false" />.</returns>
	public virtual bool GetPropertiesSupported(ITypeDescriptorContext context)
	{
		return false;
	}

	/// <summary>Returns a collection of standard values from the default context for the data type this type converter is designed for.</summary>
	/// <returns>A <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" /> containing a standard set of valid values, or <see langword="null" /> if the data type does not support a standard set of values.</returns>
	public ICollection GetStandardValues()
	{
		return null;
	}

	/// <summary>Returns a collection of standard values for the data type this type converter is designed for when provided with a format context.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context that can be used to extract additional information about the environment from which this converter is invoked. This parameter or properties of this parameter can be <see langword="null" />.</param>
	/// <returns>A <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" /> that holds a standard set of valid values, or <see langword="null" /> if the data type does not support a standard set of values.</returns>
	public virtual StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
	{
		return null;
	}

	/// <summary>Returns whether the collection of standard values returned from <see cref="M:System.ComponentModel.TypeConverter.GetStandardValues" /> is an exclusive list.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" /> returned from <see cref="M:System.ComponentModel.TypeConverter.GetStandardValues" /> is an exhaustive list of possible values; <see langword="false" /> if other values are possible.</returns>
	public bool GetStandardValuesExclusive()
	{
		return false;
	}

	/// <summary>Returns whether the collection of standard values returned from <see cref="M:System.ComponentModel.TypeConverter.GetStandardValues" /> is an exclusive list of possible values, using the specified context.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" /> returned from <see cref="M:System.ComponentModel.TypeConverter.GetStandardValues" /> is an exhaustive list of possible values; <see langword="false" /> if other values are possible.</returns>
	public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context)
	{
		return false;
	}

	/// <summary>Returns whether this object supports a standard set of values that can be picked from a list.</summary>
	/// <returns>
	///   <see langword="true" /> if <see cref="M:System.ComponentModel.TypeConverter.GetStandardValues" /> should be called to find a common set of values the object supports; otherwise, <see langword="false" />.</returns>
	public bool GetStandardValuesSupported()
	{
		return false;
	}

	/// <summary>Returns whether this object supports a standard set of values that can be picked from a list, using the specified context.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
	/// <returns>
	///   <see langword="true" /> if <see cref="M:System.ComponentModel.TypeConverter.GetStandardValues" /> should be called to find a common set of values the object supports; otherwise, <see langword="false" />.</returns>
	public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context)
	{
		return false;
	}

	/// <summary>Returns whether the given value object is valid for this type.</summary>
	/// <param name="value">The object to test for validity.</param>
	/// <returns>
	///   <see langword="true" /> if the specified value is valid for this object; otherwise, <see langword="false" />.</returns>
	public bool IsValid(object value)
	{
		return false;
	}

	/// <summary>Returns whether the given value object is valid for this type and for the specified context.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
	/// <param name="value">The <see cref="T:System.Object" /> to test for validity.</param>
	/// <returns>
	///   <see langword="true" /> if the specified value is valid for this object; otherwise, <see langword="false" />.</returns>
	public virtual bool IsValid(ITypeDescriptorContext context, object value)
	{
		return false;
	}

	/// <summary>Sorts a collection of properties.</summary>
	/// <param name="props">A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> that has the properties to sort.</param>
	/// <param name="names">An array of names in the order you want the properties to appear in the collection.</param>
	/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> that contains the sorted properties.</returns>
	protected PropertyDescriptorCollection SortProperties(PropertyDescriptorCollection props, string[] names)
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.TypeConverter" /> class.</summary>
	public TypeConverter()
	{
	}
}
