using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine.SceneManagement;

namespace UnityEngine.Rendering;

[Serializable]
public class ProbeVolumeSceneData : ISerializationCallbackReceiver
{
	[Serializable]
	private struct SerializableBoundItem
	{
		[SerializeField]
		public string sceneGUID;

		[SerializeField]
		public Bounds bounds;
	}

	[Serializable]
	private struct SerializableHasPVItem
	{
		[SerializeField]
		public string sceneGUID;

		[SerializeField]
		public bool hasProbeVolumes;
	}

	[Serializable]
	private struct SerializablePVProfile
	{
		[SerializeField]
		public string sceneGUID;

		[SerializeField]
		public ProbeReferenceVolumeProfile profile;
	}

	[Serializable]
	private struct SerializablePVBakeSettings
	{
		public string sceneGUID;

		public ProbeVolumeBakingProcessSettings settings;
	}

	[Serializable]
	internal class BakingSet
	{
		public string name;

		public List<string> sceneGUIDs;

		public ProbeVolumeBakingProcessSettings settings;

		public ProbeReferenceVolumeProfile profile;

		public List<string> lightingScenarios;

		internal string CreateScenario(string name)
		{
			return null;
		}

		internal bool RemoveScenario(string name)
		{
			return false;
		}
	}

	private static PropertyInfo s_SceneGUID;

	[SerializeField]
	private List<SerializableBoundItem> serializedBounds;

	[SerializeField]
	private List<SerializableHasPVItem> serializedHasVolumes;

	[SerializeField]
	private List<SerializablePVProfile> serializedProfiles;

	[SerializeField]
	private List<SerializablePVBakeSettings> serializedBakeSettings;

	[SerializeField]
	private List<BakingSet> serializedBakingSets;

	internal Object parentAsset;

	internal string parentSceneDataPropertyName;

	public Dictionary<string, Bounds> sceneBounds;

	internal Dictionary<string, bool> hasProbeVolumes;

	internal Dictionary<string, ProbeReferenceVolumeProfile> sceneProfiles;

	internal Dictionary<string, ProbeVolumeBakingProcessSettings> sceneBakingSettings;

	internal List<BakingSet> bakingSets;

	[SerializeField]
	private string m_LightingScenario;

	private string m_OtherScenario;

	private float m_ScenarioBlendingFactor;

	internal string lightingScenario => null;

	internal string otherScenario => null;

	internal float scenarioBlendingFactor => 0f;

	internal static string GetSceneGUID(Scene scene)
	{
		return null;
	}

	internal void SetActiveScenario(string scenario)
	{
	}

	internal void BlendLightingScenario(string otherScenario, float blendingFactor)
	{
	}

	public ProbeVolumeSceneData(Object parentAsset, string parentSceneDataPropertyName)
	{
	}

	public void SetParentObject(Object parent, string parentSceneDataPropertyName)
	{
	}

	public void OnAfterDeserialize()
	{
	}

	private void UpdateBakingSets()
	{
	}

	public void OnBeforeSerialize()
	{
	}

	internal BakingSet CreateNewBakingSet(string name)
	{
		return null;
	}

	private void InitializeBakingSet(BakingSet set, string name)
	{
	}

	private void InitializeScenarios(BakingSet set)
	{
	}

	internal void SyncBakingSetSettings()
	{
	}
}
