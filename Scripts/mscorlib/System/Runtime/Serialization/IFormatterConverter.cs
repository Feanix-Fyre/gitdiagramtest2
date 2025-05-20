namespace System.Runtime.Serialization;

/// <summary>Provides the connection between an instance of <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and the formatter-provided class best suited to parse the data inside the <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
[CLSCompliant(false)]
public interface IFormatterConverter
{
	/// <summary>Converts a value to the given <see cref="T:System.Type" />.</summary>
	/// <param name="value">The object to be converted.</param>
	/// <param name="type">The <see cref="T:System.Type" /> into which <paramref name="value" /> is to be converted.</param>
	/// <returns>The converted <paramref name="value" />.</returns>
	object Convert(object value, Type type);

	/// <summary>Converts a value to a <see cref="T:System.Boolean" />.</summary>
	/// <param name="value">The object to be converted.</param>
	/// <returns>The converted <paramref name="value" />.</returns>
	bool ToBoolean(object value);

	/// <summary>Converts a value to a 32-bit signed integer.</summary>
	/// <param name="value">The object to be converted.</param>
	/// <returns>The converted <paramref name="value" />.</returns>
	int ToInt32(object value);

	/// <summary>Converts a value to a 64-bit signed integer.</summary>
	/// <param name="value">The object to be converted.</param>
	/// <returns>The converted <paramref name="value" />.</returns>
	long ToInt64(object value);

	/// <summary>Converts a value to a single-precision floating-point number.</summary>
	/// <param name="value">The object to be converted.</param>
	/// <returns>The converted <paramref name="value" />.</returns>
	float ToSingle(object value);

	/// <summary>Converts a value to a <see cref="T:System.String" />.</summary>
	/// <param name="value">The object to be converted.</param>
	/// <returns>The converted <paramref name="value" />.</returns>
	string ToString(object value);
}
