using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;

namespace System.Net;

internal sealed class NetEventSource : EventSource
{
	public class Keywords
	{
		public const EventKeywords Default = (EventKeywords)1L;

		public const EventKeywords Debug = (EventKeywords)2L;

		public const EventKeywords EnterExit = (EventKeywords)4L;
	}

	public static readonly NetEventSource Log;

	public new static bool IsEnabled => false;

	[NonEvent]
	public static void Enter(object thisOrContextObject, FormattableString formattableString = null, [CallerMemberName] string memberName = null)
	{
	}

	[NonEvent]
	public static void Enter(object thisOrContextObject, object arg0, [CallerMemberName] string memberName = null)
	{
	}

	[NonEvent]
	public static void Enter(object thisOrContextObject, object arg0, object arg1, object arg2, [CallerMemberName] string memberName = null)
	{
	}

	[Event(1, Level = EventLevel.Informational, Keywords = (EventKeywords)4L)]
	private void Enter(string thisOrContextObject, string memberName, string parameters)
	{
	}

	[NonEvent]
	public static void Exit(object thisOrContextObject, FormattableString formattableString = null, [CallerMemberName] string memberName = null)
	{
	}

	[NonEvent]
	public static void Exit(object thisOrContextObject, object arg0, [CallerMemberName] string memberName = null)
	{
	}

	[Event(2, Level = EventLevel.Informational, Keywords = (EventKeywords)4L)]
	private void Exit(string thisOrContextObject, string memberName, string result)
	{
	}

	[NonEvent]
	public static void Info(object thisOrContextObject, FormattableString formattableString = null, [CallerMemberName] string memberName = null)
	{
	}

	[NonEvent]
	public static void Info(object thisOrContextObject, object message, [CallerMemberName] string memberName = null)
	{
	}

	[Event(4, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
	private void Info(string thisOrContextObject, string memberName, string message)
	{
	}

	[NonEvent]
	public static void Error(object thisOrContextObject, object message, [CallerMemberName] string memberName = null)
	{
	}

	[Event(5, Level = EventLevel.Warning, Keywords = (EventKeywords)1L)]
	private void ErrorMessage(string thisOrContextObject, string memberName, string message)
	{
	}

	[NonEvent]
	public static void Fail(object thisOrContextObject, object message, [CallerMemberName] string memberName = null)
	{
	}

	[Event(6, Level = EventLevel.Critical, Keywords = (EventKeywords)2L)]
	private void CriticalFailure(string thisOrContextObject, string memberName, string message)
	{
	}

	[NonEvent]
	public static void Associate(object first, object second, [CallerMemberName] string memberName = null)
	{
	}

	[Event(3, Level = EventLevel.Informational, Keywords = (EventKeywords)1L, Message = "[{2}]<-->[{3}]")]
	private void Associate(string thisOrContextObject, string memberName, string first, string second)
	{
	}

	[NonEvent]
	public static string IdOf(object value)
	{
		return null;
	}

	[NonEvent]
	public static int GetHashCode(object value)
	{
		return 0;
	}

	[NonEvent]
	public static object Format(object value)
	{
		return null;
	}

	[NonEvent]
	private static string Format(FormattableString s)
	{
		return null;
	}

	[NonEvent]
	private void WriteEvent(int eventId, string arg1, string arg2, string arg3, string arg4)
	{
	}
}
