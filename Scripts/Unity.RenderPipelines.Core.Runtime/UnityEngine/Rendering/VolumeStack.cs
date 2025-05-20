using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering;

public sealed class VolumeStack : IDisposable
{
	internal readonly Dictionary<Type, VolumeComponent> components;

	internal (VolumeParameter parameter, VolumeParameter defaultValue)[] defaultParameters;

	internal bool requiresReset;

	internal VolumeStack()
	{
	}

	internal void Clear()
	{
	}

	internal void Reload(List<VolumeComponent> componentDefaultStates)
	{
	}

	public T GetComponent<T>() where T : VolumeComponent
	{
		return null;
	}

	public VolumeComponent GetComponent(Type type)
	{
		return null;
	}

	public void Dispose()
	{
	}
}
