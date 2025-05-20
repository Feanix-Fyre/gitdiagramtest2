namespace UnityEngine;

public interface ILogger : ILogHandler
{
	ILogHandler logHandler { get; }

	bool logEnabled { get; }

	void Log(LogType logType, object message);

	void Log(LogType logType, object message, Object context);

	void Log(LogType logType, string tag, object message);

	void Log(string tag, object message);

	void LogWarning(string tag, object message);

	void LogError(string tag, object message);

	void LogFormat(LogType logType, string format, params object[] args);
}
