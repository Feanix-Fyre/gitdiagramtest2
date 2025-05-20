using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnityEngine.Rendering;

public sealed class VolumeManager
{
	private static readonly Lazy<VolumeManager> s_Instance;

	private static readonly Dictionary<Type, List<(string, Type)>> s_SupportedVolumeComponentsForRenderPipeline;

	private const int k_MaxLayerCount = 32;

	private readonly Dictionary<int, List<Volume>> m_SortedVolumes;

	private readonly List<Volume> m_Volumes;

	private readonly Dictionary<int, bool> m_SortNeeded;

	private readonly List<VolumeComponent> m_ComponentsDefaultState;

	private readonly List<Collider> m_TempColliders;

	private VolumeStack m_DefaultStack;

	public static VolumeManager instance => null;

	public VolumeStack stack { get; set; }

	[Obsolete("Please use baseComponentTypeArray instead.")]
	public IEnumerable<Type> baseComponentTypes
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public Type[] baseComponentTypeArray { get; private set; }

	internal static List<(string, Type)> GetSupportedVolumeComponents(Type currentPipelineType)
	{
		return null;
	}

	private static List<(string, Type)> FilterVolumeComponentTypes(Type[] types, Type currentPipelineType)
	{
		return null;
	}

	internal VolumeComponent GetDefaultVolumeComponent(Type volumeComponentType)
	{
		return null;
	}

	private VolumeManager()
	{
	}

	public VolumeStack CreateStack()
	{
		return null;
	}

	public void ResetMainStack()
	{
	}

	public void DestroyStack(VolumeStack stack)
	{
	}

	private void ReloadBaseTypes()
	{
	}

	public void Register(Volume volume, int layer)
	{
	}

	public void Unregister(Volume volume, int layer)
	{
	}

	public bool IsComponentActiveInMask<T>(LayerMask layerMask) where T : VolumeComponent
	{
		return false;
	}

	internal void SetLayerDirty(int layer)
	{
	}

	internal void UpdateVolumeLayer(Volume volume, int prevLayer, int newLayer)
	{
	}

	private void OverrideData(VolumeStack stack, List<VolumeComponent> components, float interpFactor)
	{
	}

	internal void ReplaceData(VolumeStack stack)
	{
	}

	[Conditional("UNITY_EDITOR")]
	public void CheckBaseTypes()
	{
	}

	[Conditional("UNITY_EDITOR")]
	public void CheckStack(VolumeStack stack)
	{
	}

	private bool CheckUpdateRequired(VolumeStack stack)
	{
		return false;
	}

	public void Update(Transform trigger, LayerMask layerMask)
	{
	}

	public void Update(VolumeStack stack, Transform trigger, LayerMask layerMask)
	{
	}

	public Volume[] GetVolumes(LayerMask layerMask)
	{
		return null;
	}

	private List<Volume> GrabVolumes(LayerMask mask)
	{
		return null;
	}

	private static void SortByPriority(List<Volume> volumes)
	{
	}

	private static bool IsVolumeRenderedByCamera(Volume volume, Camera camera)
	{
		return false;
	}
}
