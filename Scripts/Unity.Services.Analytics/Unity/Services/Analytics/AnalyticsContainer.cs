using Unity.Services.Analytics.Internal;
using UnityEngine;

namespace Unity.Services.Analytics;

internal class AnalyticsContainer : MonoBehaviour, IAnalyticsContainer, IContainerDebug
{
	private const float k_AutoFlushPeriod = 60f;

	private const float k_GameRunningPeriod = 60f;

	private static bool s_Created;

	private static GameObject s_Container;

	private static AnalyticsContainer m_Instance;

	private float m_AutoFlushTime;

	private float m_GameRunningTime;

	private AnalyticsServiceInstance m_Service;

	private float AutoFlushPeriod => 0f;

	internal static IContainerDebug ContainerDebug => null;

	public float TimeUntilNextHeartbeat => 0f;

	internal static AnalyticsContainer CreateContainer()
	{
		return null;
	}

	public void Initialize(AnalyticsServiceInstance service)
	{
	}

	public void Enable()
	{
	}

	public void Disable()
	{
	}

	private void Update()
	{
	}

	private void OnApplicationPause(bool paused)
	{
	}

	private void CleanUp()
	{
	}
}
