using System;

namespace UnityEngine.UIElements;

internal sealed class VisualTreeUpdater : IDisposable
{
	private class UpdaterArray
	{
		private IVisualTreeUpdater[] m_VisualTreeUpdaters;

		public IVisualTreeUpdater this[VisualTreeUpdatePhase phase]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IVisualTreeUpdater this[int index] => null;
	}

	private BaseVisualElementPanel m_Panel;

	private UpdaterArray m_UpdaterArray;

	public VisualTreeUpdater(BaseVisualElementPanel panel)
	{
	}

	public void Dispose()
	{
	}

	public void UpdateVisualTreePhase(VisualTreeUpdatePhase phase)
	{
	}

	public void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
	{
	}

	public void SetUpdater<T>(VisualTreeUpdatePhase phase) where T : IVisualTreeUpdater, new()
	{
	}

	public IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase)
	{
		return null;
	}

	private void SetDefaultUpdaters()
	{
	}
}
