using System.ComponentModel;
using System.Globalization;

namespace System.Windows.Forms;

/// <summary>Provides a type converter to convert <see cref="T:System.Windows.Forms.ColumnHeader" /> objects from one type to another.</summary>
public class ColumnHeaderConverter : ExpandableObjectConverter
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ColumnHeaderConverter" /> class.</summary>
	public ColumnHeaderConverter()
	{
	}

	/// <summary>Converts the specified object to the specified type, using the specified context and culture information.</summary>
	/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
	/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" /> that represents information about a culture, such as language and calendar system. Can be <see langword="null" />.</param>
	/// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
	/// <param name="destinationType">The <see cref="T:System.Type" /> to convert to.</param>
	/// <returns>The <see cref="T:System.Object" /> that is the result of the conversion.</returns>
	/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed <paramref name="." /></exception>
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		return null;
	}

	/// <summary>Returns a value indicating whether the <see cref="T:System.Windows.Forms.ColumnHeaderConverter" /> can convert a <see cref="T:System.Windows.Forms.ColumnHeader" /> to the specified type, using the specified context.</summary>
	/// <param name="context">A <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
	/// <param name="destinationType">A type representing the type to convert to.</param>
	/// <returns>
	///   <see langword="true" /> if this converter can perform the conversion; otherwise, <see langword="false" />.</returns>
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
	{
		return false;
	}
}
