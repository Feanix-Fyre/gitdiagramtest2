using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering;

public class DebugDisplaySettingsUI : IDebugData
{
	private IEnumerable<IDebugDisplaySettingsPanelDisposable> m_DisposablePanels;

	private IDebugDisplaySettings m_Settings;

	private void Reset()
	{
	}

	public void RegisterDebug(IDebugDisplaySettings settings)
	{
	}

	public void UnregisterDebug()
	{
	}

	public Action GetReset()
	{
		return null;
	}
}
