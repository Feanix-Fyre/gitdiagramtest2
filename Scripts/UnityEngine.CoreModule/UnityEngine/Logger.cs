using System;

namespace UnityEngine;

public class Logger : ILogger, ILogHandler
{
	public ILogHandler logHandler { get; set; }

	public bool logEnabled { get; set; }

	public LogType filterLogType { get; set; }

	public Logger(ILogHandler logHandler)
	{
	}

	public bool IsLogTypeAllowed(LogType logType)
	{
		return false;
	}

	private static string GetString(object message)
	{
		return null;
	}

	public void Log(LogType logType, object message)
	{
	}

	public void Log(LogType logType, object message, Object context)
	{
	}

	public void Log(LogType logType, string tag, object message)
	{
	}

	public void Log(string tag, object message)
	{
	}

	public void LogWarning(string tag, object message)
	{
	}

	public void LogError(string tag, object message)
	{
	}

	public void LogException(Exception exception, Object context)
	{
	}

	public void LogFormat(LogType logType, string format, params object[] args)
	{
	}

	public void LogFormat(LogType logType, Object context, string format, params object[] args)
	{
	}
}
