namespace System.Runtime.CompilerServices;

/// <summary>Provides a static method to create a <see cref="T:System.FormattableString" /> object from a composite format string and its arguments.</summary>
public static class FormattableStringFactory
{
	private sealed class ConcreteFormattableString : FormattableString
	{
		private readonly string _format;

		private readonly object[] _arguments;

		public override string Format => null;

		public override int ArgumentCount => 0;

		internal ConcreteFormattableString(string format, object[] arguments)
		{
		}

		public override object[] GetArguments()
		{
			return null;
		}

		public override object GetArgument(int index)
		{
			return null;
		}

		public override string ToString(IFormatProvider formatProvider)
		{
			return null;
		}
	}

	/// <summary>Creates a <see cref="T:System.FormattableString" /> instance from a composite format string and its arguments.</summary>
	/// <param name="format">A composite format string.</param>
	/// <param name="arguments">The arguments whose string representations are to be inserted in the result string.</param>
	/// <returns>The object that represents the composite format string and its arguments.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="format" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="arguments" /> is <see langword="null" />.</exception>
	public static FormattableString Create(string format, params object[] arguments)
	{
		return null;
	}
}
