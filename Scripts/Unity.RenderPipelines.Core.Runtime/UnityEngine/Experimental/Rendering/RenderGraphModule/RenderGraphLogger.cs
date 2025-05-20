using System.Collections.Generic;
using System.Text;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

internal class RenderGraphLogger
{
	private Dictionary<string, StringBuilder> m_LogMap;

	private StringBuilder m_CurrentBuilder;

	private int m_CurrentIndentation;

	public void Initialize(string logName)
	{
	}

	public void IncrementIndentation(int value)
	{
	}

	public void DecrementIndentation(int value)
	{
	}

	public void LogLine(string format, params object[] args)
	{
	}

	public string GetLog(string logName)
	{
		return null;
	}

	public string GetAllLogs()
	{
		return null;
	}
}
