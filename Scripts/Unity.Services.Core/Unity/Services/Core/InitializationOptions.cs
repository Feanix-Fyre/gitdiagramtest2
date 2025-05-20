using System.Collections.Generic;

namespace Unity.Services.Core;

public class InitializationOptions
{
	internal IDictionary<string, object> Values { get; }

	public InitializationOptions()
	{
	}

	internal InitializationOptions(IDictionary<string, object> values)
	{
	}

	internal InitializationOptions(InitializationOptions source)
	{
	}

	public bool TryGetOption(string key, out bool option)
	{
		option = default(bool);
		return false;
	}

	public bool TryGetOption(string key, out int option)
	{
		option = default(int);
		return false;
	}

	public bool TryGetOption(string key, out float option)
	{
		option = default(float);
		return false;
	}

	public bool TryGetOption(string key, out string option)
	{
		option = null;
		return false;
	}

	private bool TryGetOption<T>(string key, out T option)
	{
		option = default(T);
		return false;
	}

	public InitializationOptions SetOption(string key, bool value)
	{
		return null;
	}

	public InitializationOptions SetOption(string key, int value)
	{
		return null;
	}

	public InitializationOptions SetOption(string key, float value)
	{
		return null;
	}

	public InitializationOptions SetOption(string key, string value)
	{
		return null;
	}
}
