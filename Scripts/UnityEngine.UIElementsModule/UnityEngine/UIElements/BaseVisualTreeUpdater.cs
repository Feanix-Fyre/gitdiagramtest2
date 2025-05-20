using System;
using System.Runtime.CompilerServices;
using Unity.Profiling;

namespace UnityEngine.UIElements;

internal abstract class BaseVisualTreeUpdater : IVisualTreeUpdater, IDisposable
{
	private BaseVisualElementPanel m_Panel;

	public BaseVisualElementPanel panel
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public VisualElement visualTree => null;

	public abstract ProfilerMarker profilerMarker { get; }

	public event Action<BaseVisualElementPanel> panelChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	public abstract void Update();

	public abstract void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType);
}
