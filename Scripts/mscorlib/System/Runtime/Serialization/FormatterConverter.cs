using System.Runtime.CompilerServices;

namespace System.Runtime.Serialization;

/// <summary>Represents a base implementation of the <see cref="T:System.Runtime.Serialization.IFormatterConverter" /> interface that uses the <see cref="T:System.Convert" /> class and the <see cref="T:System.IConvertible" /> interface.</summary>
public class FormatterConverter : IFormatterConverter
{
	/// <summary>Converts a value to the given <see cref="T:System.Type" />.</summary>
	/// <param name="value">The object to convert.</param>
	/// <param name="type">The <see cref="T:System.Type" /> into which <paramref name="value" /> is converted.</param>
	/// <returns>The converted <paramref name="value" /> or <see langword="null" /> if the <paramref name="type" /> parameter is <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="value" /> parameter is <see langword="null" />.</exception>
	public object Convert(object value, Type type)
	{
		return null;
	}

	/// <summary>Converts a value to a <see cref="T:System.Boolean" />.</summary>
	/// <param name="value">The object to convert.</param>
	/// <returns>The converted <paramref name="value" /> or <see langword="null" /> if the <paramref name="type" /> parameter is <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="value" /> parameter is <see langword="null" />.</exception>
	public bool ToBoolean(object value)
	{
		return false;
	}

	/// <summary>Converts a value to a 32-bit signed integer.</summary>
	/// <param name="value">The object to convert.</param>
	/// <returns>The converted <paramref name="value" /> or <see langword="null" /> if the <paramref name="type" /> parameter is <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="value" /> parameter is <see langword="null" />.</exception>
	public int ToInt32(object value)
	{
		return 0;
	}

	/// <summary>Converts a value to a 64-bit signed integer.</summary>
	/// <param name="value">The object to convert.</param>
	/// <returns>The converted <paramref name="value" /> or <see langword="null" /> if the <paramref name="type" /> parameter is <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="value" /> parameter is <see langword="null" />.</exception>
	public long ToInt64(object value)
	{
		return 0L;
	}

	/// <summary>Converts a value to a single-precision floating-point number.</summary>
	/// <param name="value">The object to convert.</param>
	/// <returns>The converted <paramref name="value" /> or <see langword="null" /> if the <paramref name="type" /> parameter is <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="value" /> parameter is <see langword="null" />.</exception>
	public float ToSingle(object value)
	{
		return 0f;
	}

	/// <summary>Converts the specified object to a <see cref="T:System.String" />.</summary>
	/// <param name="value">The object to convert.</param>
	/// <returns>The converted <paramref name="value" /> or <see langword="null" /> if the <paramref name="type" /> parameter is <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="value" /> parameter is <see langword="null" />.</exception>
	public string ToString(object value)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ThrowValueNullException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Serialization.FormatterConverter" /> class.</summary>
	public FormatterConverter()
	{
	}
}
