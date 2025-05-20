using System.Globalization;

namespace System;

internal ref struct DateTimeResult
{
	internal int Year;

	internal int Month;

	internal int Day;

	internal int Hour;

	internal int Minute;

	internal int Second;

	internal double fraction;

	internal int era;

	internal ParseFlags flags;

	internal TimeSpan timeZoneOffset;

	internal Calendar calendar;

	internal DateTime parsedDate;

	internal ParseFailureKind failure;

	internal string failureMessageID;

	internal object failureMessageFormatArgument;

	internal string failureArgumentName;

	internal ReadOnlySpan<char> originalDateTimeString;

	internal ReadOnlySpan<char> failedFormatSpecifier;

	internal void Init(ReadOnlySpan<char> originalDateTimeString)
	{
	}

	internal void SetDate(int year, int month, int day)
	{
	}

	internal void SetBadFormatSpecifierFailure()
	{
	}

	internal void SetBadFormatSpecifierFailure(ReadOnlySpan<char> failedFormatSpecifier)
	{
	}

	internal void SetBadDateTimeFailure()
	{
	}

	internal void SetFailure(ParseFailureKind failure, string failureMessageID)
	{
	}

	internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument)
	{
	}

	internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName)
	{
	}
}
