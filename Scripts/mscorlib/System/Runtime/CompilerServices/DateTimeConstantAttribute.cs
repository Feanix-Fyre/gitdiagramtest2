namespace System.Runtime.CompilerServices;

/// <summary>Persists an 8-byte <see cref="T:System.DateTime" /> constant for a field or parameter.</summary>
[Serializable]
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter, Inherited = false)]
public sealed class DateTimeConstantAttribute : CustomConstantAttribute
{
	private DateTime _date;

	/// <summary>Gets the number of 100-nanosecond ticks that represent the date and time of this instance.</summary>
	/// <returns>The number of 100-nanosecond ticks that represent the date and time of this instance.</returns>
	public override object Value => null;
}
