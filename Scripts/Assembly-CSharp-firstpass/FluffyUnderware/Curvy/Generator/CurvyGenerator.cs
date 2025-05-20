using System;
using System.Collections.Generic;
using System.Diagnostics;
using FluffyUnderware.DevTools;
using JetBrains.Annotations;
using UnityEngine;

namespace FluffyUnderware.Curvy.Generator;

[AddComponentMenu("Curvy/Generator")]
[HelpURL("https://curvyeditor.com/doclink/generator")]
[ExecuteAlways]
[RequireComponent(typeof(PoolManager))]
public class CurvyGenerator : DTVersionedMonoBehaviour
{
	private class ModuleSorter
	{
		[NotNull]
		[ItemNotNull]
		private readonly HashSet<CGModule> modulesWithCircularReferences;

		[NotNull]
		private readonly Dictionary<CGModule, int> modulesAncestorCount;

		public bool SortingNeeded { get; set; }

		public bool HasCircularReference([NotNull] CGModule module)
		{
			return false;
		}

		public void EnsureIsSorted(List<CGModule> modules)
		{
		}

		private void Sort([NotNull] List<CGModule> modules)
		{
		}
	}

	private class ModulesSynchronizer
	{
		private bool hasPendingRequest;

		[System.Diagnostics.Conditional("UNITY_EDITOR")]
		public void RequestSynchronization()
		{
		}

		[System.Diagnostics.Conditional("UNITY_EDITOR")]
		public void CancelRequests()
		{
		}

		[System.Diagnostics.Conditional("UNITY_EDITOR")]
		public void ProcessRequests([NotNull] CurvyGenerator curvyGenerator)
		{
		}

		[System.Diagnostics.Conditional("UNITY_EDITOR")]
		private static void AddMissingChildModules([NotNull] CurvyGenerator curvyGenerator)
		{
		}
	}

	private class Timer
	{
		private double lastTimestamp;

		private static double Now => 0.0;

		private void ValidateTimes(float timeLimit, float editorTimeLimit)
		{
		}

		public bool Update(float timeLimit, float editorTimeLimit)
		{
			return false;
		}

		public void Reset()
		{
		}
	}

	[Tooltip("Show Debug Output?")]
	[SerializeField]
	private bool m_ShowDebug;

	[Tooltip("Whether to automatically refresh the generator's output when necessary")]
	[SerializeField]
	private bool m_AutoRefresh;

	[Positive(Tooltip = "The minimum delay between two automatic generator's refreshing while in Play mode. Expressed in milliseconds of real time")]
	[FieldCondition(/*Could not decode attribute arguments.*/)]
	[SerializeField]
	private int m_RefreshDelay;

	[SerializeField]
	[Positive(Tooltip = "The minimum delay between two automatic generator's refreshing while in Edit mode. Expressed in milliseconds of real time")]
	[FieldCondition(/*Could not decode attribute arguments.*/)]
	private int m_RefreshDelayEditor;

	[Section("Events", false, false, 1000, HelpURL = "https://curvyeditor.com/doclink/generator_events")]
	[SerializeField]
	protected CurvyCGEvent m_OnRefresh;

	[HideInInspector]
	public List<CGModule> Modules;

	private bool isInitialized;

	private bool isInitializedPhaseOne;

	private PoolManager poolManager;

	[NotNull]
	private readonly Timer autoRefreshTimer;

	[NotNull]
	private readonly ModuleSorter moduleSorter;

	[NotNull]
	private readonly ModulesSynchronizer modulesSynchronizer;

	private const int ModulesReorderingDeltaX = 50;

	private const int ModulesReorderingDeltaY = 20;

	[Obsolete("No more used. Retrieve the Ids from Modules by using Modules[x].UniqueID")]
	[UsedImplicitly]
	internal int m_LastModuleID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool ShowDebug
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool AutoRefresh
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int RefreshDelay
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int RefreshDelayEditor
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public PoolManager PoolManager => null;

	public CurvyCGEvent OnRefresh
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool IsInitialized => false;

	public bool Destroying { get; private set; }

	[UsedImplicitly]
	[Obsolete("Dictionary no more used. Retrieve he Ids from Modules by using Modules[x].UniqueID")]
	public Dictionary<int, CGModule> ModulesByID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private bool HasModulesWithSameID => false;

	protected override void OnEnable()
	{
	}

	protected override void OnDisable()
	{
	}

	[UsedImplicitly]
	private void OnDestroy()
	{
	}

	[UsedImplicitly]
	private void Update()
	{
	}

	public static CurvyGenerator Create()
	{
		return null;
	}

	public T AddModule<T>() where T : CGModule
	{
		return null;
	}

	[NotNull]
	public CGModule AddModule(Type type)
	{
		return null;
	}

	public void AddModule([NotNull] CGModule module)
	{
	}

	public void RemoveModule([NotNull] CGModule module)
	{
	}

	public void ArrangeModules()
	{
	}

	public void ReorderModules()
	{
	}

	public void Clear()
	{
	}

	public void DeleteModule(CGModule module)
	{
	}

	[UsedImplicitly]
	[Obsolete("Use the overload that has a mandatory includeOnRequestProcessing parameter")]
	public List<T> FindModules<T>() where T : CGModule
	{
		return null;
	}

	public List<T> FindModules<T>(bool includeOnRequestProcessing) where T : CGModule
	{
		return null;
	}

	[UsedImplicitly]
	[Obsolete("Use the overload that has a mandatory includeOnRequestProcessing parameter")]
	public List<CGModule> GetModules()
	{
		return null;
	}

	[Obsolete("Method will be removed. You can copy its implementation if needed.")]
	[UsedImplicitly]
	public List<CGModule> GetModules(bool includeOnRequestProcessing)
	{
		return null;
	}

	[UsedImplicitly]
	[Obsolete("Use the overload that has a mandatory includeOnRequestProcessing parameter")]
	public CGModule GetModule(int moduleID)
	{
		return null;
	}

	[CanBeNull]
	public CGModule GetModule(int moduleID, bool includeOnRequestProcessing)
	{
		return null;
	}

	[UsedImplicitly]
	[Obsolete("Use the overload that has a mandatory includeOnRequestProcessing parameter")]
	public T GetModule<T>(int moduleID) where T : CGModule
	{
		return null;
	}

	public T GetModule<T>(int moduleID, bool includeOnRequestProcessing) where T : CGModule
	{
		return null;
	}

	[Obsolete("Use the overload that has a mandatory includeOnRequestProcessing parameter")]
	[UsedImplicitly]
	public CGModule GetModule(string moduleName)
	{
		return null;
	}

	public CGModule GetModule(string moduleName, bool includeOnRequestProcessing)
	{
		return null;
	}

	[UsedImplicitly]
	[Obsolete("Use the overload that has a mandatory includeOnRequestProcessing parameter")]
	public T GetModule<T>(string moduleName) where T : CGModule
	{
		return null;
	}

	public T GetModule<T>(string moduleName, bool includeOnRequestProcessing) where T : CGModule
	{
		return null;
	}

	[Obsolete("Use GetModule and CGModule.GetOutputSlot instead")]
	[UsedImplicitly]
	public CGModuleOutputSlot GetModuleOutputSlot(int moduleId, string slotName)
	{
		return null;
	}

	[Obsolete("Use GetModule and CGModule.GetOutputSlot instead")]
	[UsedImplicitly]
	public CGModuleOutputSlot GetModuleOutputSlot(string moduleName, string slotName)
	{
		return null;
	}

	public void Initialize(bool force = false)
	{
	}

	public void Refresh(bool forceUpdate = false)
	{
	}

	public void TryAutoRefresh()
	{
	}

	public bool DeleteAllOutputManagedResources(out bool associatedPrefabWasModified)
	{
		associatedPrefabWasModified = default(bool);
		return false;
	}

	public string GetModuleUniqueName(CGModule module)
	{
		return null;
	}

	public int GetModuleUniqueID(CGModule module)
	{
		return 0;
	}

	protected CurvyCGEventArgs OnRefreshEvent(CurvyCGEventArgs e)
	{
		return null;
	}

	protected override void ResetOnEnable()
	{
	}

	private bool IsModuleNameUnique(CGModule module, string uniqueName)
	{
		return false;
	}

	[UsedImplicitly]
	[Obsolete]
	public string getUniqueModuleNameINTERNAL(string name)
	{
		return null;
	}

	internal void sortModulesINTERNAL()
	{
	}

	private bool CorrectDuplicateModuleIDs()
	{
		return false;
	}

	[UsedImplicitly]
	private void ResetAllModuleLinks()
	{
	}

	public bool HasCircularReference([NotNull] CGModule module)
	{
		return false;
	}

	private static void ReorderEndpointRecursiveInputs(CGModule endPoint, HashSet<int> reordredModuleIds, Dictionary<CGModule, HashSet<CGModule>> modulesRecursiveInputs)
	{
	}

	private static HashSet<CGModule> UpdateModulesRecursiveInputs(Dictionary<CGModule, HashSet<CGModule>> modulesRecursiveInputs, CGModule moduleToAdd)
	{
		return null;
	}

	private void SetModulesFromChildren()
	{
	}

	public bool DeleteAllOutputManagedResourcesFromAssociatedPrefab()
	{
		return false;
	}

	public void SaveAllOutputManagedResources()
	{
	}
}
