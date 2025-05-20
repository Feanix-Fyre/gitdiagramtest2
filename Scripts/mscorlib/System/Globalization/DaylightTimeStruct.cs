namespace System.Globalization;

internal readonly struct DaylightTimeStruct
{
	public readonly DateTime Start;

	public readonly DateTime End;

	public readonly TimeSpan Delta;

	public DaylightTimeStruct(DateTime start, DateTime end, TimeSpan delta)
	{
		Start = default(DateTime);
		End = default(DateTime);
		Delta = default(TimeSpan);
	}
}
