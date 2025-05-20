using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering;

public abstract class DebugDisplaySettingsPanel : IDebugDisplaySettingsPanelDisposable, IDebugDisplaySettingsPanel, IDisposable
{
	private readonly List<DebugUI.Widget> m_Widgets;

	private readonly DisplayInfoAttribute m_DisplayInfo;

	public virtual string PanelName => null;

	public virtual int Order => 0;

	public DebugUI.Widget[] Widgets => null;

	public virtual DebugUI.Flags Flags => default(DebugUI.Flags);

	protected void AddWidget(DebugUI.Widget widget)
	{
	}

	protected void Clear()
	{
	}

	public void Dispose()
	{
	}
}
public abstract class DebugDisplaySettingsPanel<T> : DebugDisplaySettingsPanel where T : IDebugDisplaySettingsData
{
	internal T m_Data;

	public T data
	{
		get
		{
			return default(T);
		}
		internal set
		{
		}
	}

	protected DebugDisplaySettingsPanel(T data)
	{
	}
}
