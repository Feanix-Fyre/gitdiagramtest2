namespace System;

internal struct DateTimeRawInfo
{
	private unsafe int* num;

	internal int numCount;

	internal int month;

	internal int year;

	internal int dayOfWeek;

	internal int era;

	internal DateTimeParse.TM timeMark;

	internal double fraction;

	internal bool hasSameDateAndTimeSeparators;

	internal unsafe void Init(int* numberBuffer)
	{
	}

	internal void AddNumber(int value)
	{
	}

	internal int GetNumber(int index)
	{
		return 0;
	}
}
