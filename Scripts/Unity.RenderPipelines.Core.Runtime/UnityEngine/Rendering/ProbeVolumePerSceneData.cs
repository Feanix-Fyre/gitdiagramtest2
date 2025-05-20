using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering;

[ExecuteAlways]
[AddComponentMenu(null)]
public class ProbeVolumePerSceneData : MonoBehaviour, ISerializationCallbackReceiver
{
	[Serializable]
	internal struct PerScenarioData
	{
		public int sceneHash;

		public TextAsset cellDataAsset;

		public TextAsset cellOptionalDataAsset;
	}

	[Serializable]
	private struct SerializablePerScenarioDataItem
	{
		public string scenario;

		public PerScenarioData data;
	}

	[SerializeField]
	internal ProbeVolumeAsset asset;

	[SerializeField]
	internal TextAsset cellSharedDataAsset;

	[SerializeField]
	internal TextAsset cellSupportDataAsset;

	[SerializeField]
	private List<SerializablePerScenarioDataItem> serializedScenarios;

	internal Dictionary<string, PerScenarioData> scenarios;

	private bool assetLoaded;

	private string activeScenario;

	private string otherScenario;

	void ISerializationCallbackReceiver.OnAfterDeserialize()
	{
	}

	void ISerializationCallbackReceiver.OnBeforeSerialize()
	{
	}

	internal void Clear()
	{
	}

	internal void RemoveScenario(string scenario)
	{
	}

	internal void RenameScenario(string scenario, string newName)
	{
	}

	internal bool ResolveCells()
	{
		return false;
	}

	internal bool ResolveSharedCellData()
	{
		return false;
	}

	private bool ResolvePerScenarioCellData()
	{
		return false;
	}

	internal void QueueAssetLoading()
	{
	}

	internal void QueueAssetRemoval()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	internal void Initialize()
	{
	}

	internal void UpdateActiveScenario(string activeScenario, string otherScenario)
	{
	}
}
