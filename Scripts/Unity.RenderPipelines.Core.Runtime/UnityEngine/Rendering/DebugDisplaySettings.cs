using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering;

public abstract class DebugDisplaySettings<T> : IDebugDisplaySettings, IDebugDisplaySettingsQuery where T : IDebugDisplaySettings, new()
{
	protected readonly HashSet<IDebugDisplaySettingsData> m_Settings;

	private static readonly Lazy<T> s_Instance;

	public static T Instance => default(T);

	public virtual bool AreAnySettingsActive => false;

	public virtual bool IsPostProcessingAllowed => false;

	public virtual bool IsLightingActive => false;

	protected TData Add<TData>(TData newData) where TData : IDebugDisplaySettingsData
	{
		return default(TData);
	}

	public void ForEach(Action<IDebugDisplaySettingsData> onExecute)
	{
	}

	public virtual void Reset()
	{
	}

	public virtual bool TryGetScreenClearColor(ref Color color)
	{
		return false;
	}
}
