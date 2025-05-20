using System;
using System.Collections.Generic;
using Unity.Services.Analytics.Internal;

namespace Unity.Services.Analytics;

public abstract class Event
{
	private protected readonly Dictionary<string, string> m_Strings;

	private protected readonly Dictionary<string, long> m_Integers;

	private protected readonly Dictionary<string, bool> m_Booleans;

	private protected readonly Dictionary<string, double> m_Floats;

	internal readonly string Name;

	internal readonly bool StandardEvent;

	internal readonly int EventVersion;

	protected Event(string name)
	{
	}

	internal Event(string name, bool standardEvent, int eventVersion)
	{
	}

	protected void SetParameter(string name, string value)
	{
	}

	protected void SetParameter(string name, bool value)
	{
	}

	protected void SetParameter(string name, int value)
	{
	}

	protected void SetParameter(string name, long value)
	{
	}

	protected void SetParameter(string name, float value)
	{
	}

	protected void SetParameter(string name, double value)
	{
	}

	internal virtual void Serialize(IBuffer buffer)
	{
	}

	public virtual void Validate()
	{
	}

	protected bool ParameterHasBeenSet(string name)
	{
		return false;
	}

	public virtual void Reset()
	{
	}

	internal static string[] BakeEnum2String<T>(bool toUpper = false) where T : Enum
	{
		return null;
	}
}
