using System;
using Unity.Profiling;

namespace UnityEngine.UIElements;

internal interface IVisualTreeUpdater : IDisposable
{
	BaseVisualElementPanel panel { set; }

	ProfilerMarker profilerMarker { get; }

	void Update();

	void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType);
}
