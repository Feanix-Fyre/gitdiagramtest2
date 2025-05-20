using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering.PostProcessing;

public sealed class PostProcessManager
{
	private static PostProcessManager s_Instance;

	private const int k_MaxLayerCount = 32;

	private readonly Dictionary<int, List<PostProcessVolume>> m_SortedVolumes;

	private readonly List<PostProcessVolume> m_Volumes;

	private readonly Dictionary<int, bool> m_SortNeeded;

	private readonly List<PostProcessEffectSettings> m_BaseSettings;

	private readonly List<Collider> m_TempColliders;

	public readonly Dictionary<Type, PostProcessAttribute> settingsTypes;

	public static PostProcessManager instance => null;

	private PostProcessManager()
	{
	}

	private void CleanBaseTypes()
	{
	}

	private void ReloadBaseTypes()
	{
	}

	public void GetActiveVolumes(PostProcessLayer layer, List<PostProcessVolume> results, bool skipDisabled = true, bool skipZeroWeight = true)
	{
	}

	public PostProcessVolume GetHighestPriorityVolume(PostProcessLayer layer)
	{
		return null;
	}

	public PostProcessVolume GetHighestPriorityVolume(LayerMask mask)
	{
		return null;
	}

	public PostProcessVolume QuickVolume(int layer, float priority, params PostProcessEffectSettings[] settings)
	{
		return null;
	}

	internal void SetLayerDirty(int layer)
	{
	}

	internal void UpdateVolumeLayer(PostProcessVolume volume, int prevLayer, int newLayer)
	{
	}

	private void Register(PostProcessVolume volume, int layer)
	{
	}

	internal void Register(PostProcessVolume volume)
	{
	}

	private void Unregister(PostProcessVolume volume, int layer)
	{
	}

	internal void Unregister(PostProcessVolume volume)
	{
	}

	private void ReplaceData(PostProcessLayer postProcessLayer)
	{
	}

	internal void UpdateSettings(PostProcessLayer postProcessLayer, Camera camera)
	{
	}

	private List<PostProcessVolume> GrabVolumes(LayerMask mask)
	{
		return null;
	}

	private static void SortByPriority(List<PostProcessVolume> volumes)
	{
	}

	private static bool IsVolumeRenderedByCamera(PostProcessVolume volume, Camera camera)
	{
		return false;
	}
}
