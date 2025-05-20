using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements;

[Serializable]
[HelpURL("UIE-VisualTree-landing")]
public class VisualTreeAsset : ScriptableObject
{
	[Serializable]
	internal struct UsingEntry
	{
		internal static readonly IComparer<UsingEntry> comparer;

		[SerializeField]
		public string alias;

		[SerializeField]
		public string path;

		[SerializeField]
		public VisualTreeAsset asset;

		public UsingEntry(string alias, string path)
		{
			this.alias = null;
			this.path = null;
			asset = null;
		}
	}

	private class UsingEntryComparer : IComparer<UsingEntry>
	{
		public int Compare(UsingEntry x, UsingEntry y)
		{
			return 0;
		}
	}

	[Serializable]
	internal struct SlotDefinition
	{
		[SerializeField]
		public string name;

		[SerializeField]
		public int insertionPointId;
	}

	[Serializable]
	internal struct SlotUsageEntry
	{
		[SerializeField]
		public string slotName;

		[SerializeField]
		public int assetId;
	}

	[Serializable]
	internal struct UxmlObjectEntry
	{
		[SerializeField]
		public int parentId;

		[SerializeField]
		public List<UxmlObjectAsset> uxmlObjectAssets;

		public UxmlObjectEntry(int parentId, List<UxmlObjectAsset> uxmlObjectAssets)
		{
			this.parentId = 0;
			this.uxmlObjectAssets = null;
		}
	}

	[Serializable]
	private struct AssetEntry
	{
		[SerializeField]
		public string path;

		[SerializeField]
		public string typeFullName;

		[SerializeField]
		public Object asset;

		private Type m_CachedType;

		public Type type => null;

		public AssetEntry(string path, Type type, Object asset)
		{
			this.path = null;
			typeFullName = null;
			this.asset = null;
			m_CachedType = null;
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_stylesheets_003Ed__23 : IEnumerable<StyleSheet>, IEnumerable, IEnumerator<StyleSheet>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private StyleSheet _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public VisualTreeAsset _003C_003E4__this;

		private HashSet<StyleSheet> _003Csent_003E5__1;

		private List<VisualElementAsset>.Enumerator _003C_003Es__2;

		private VisualElementAsset _003Cvea_003E5__3;

		private List<StyleSheet>.Enumerator _003C_003Es__4;

		private StyleSheet _003Cstylesheet_003E5__5;

		private List<string>.Enumerator _003C_003Es__6;

		private string _003CstylesheetPath_003E5__7;

		private StyleSheet _003Cstylesheet_003E5__8;

		StyleSheet IEnumerator<StyleSheet>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003Cget_stylesheets_003Ed__23(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		private void _003C_003Em__Finally2()
		{
		}

		private void _003C_003Em__Finally3()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		IEnumerator<StyleSheet> IEnumerable<StyleSheet>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_templateDependencies_003Ed__19 : IEnumerable<VisualTreeAsset>, IEnumerable, IEnumerator<VisualTreeAsset>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private VisualTreeAsset _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public VisualTreeAsset _003C_003E4__this;

		private HashSet<VisualTreeAsset> _003Csent_003E5__1;

		private List<UsingEntry>.Enumerator _003C_003Es__2;

		private UsingEntry _003Centry_003E5__3;

		private VisualTreeAsset _003Cvta_003E5__4;

		VisualTreeAsset IEnumerator<VisualTreeAsset>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003Cget_templateDependencies_003Ed__19(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		IEnumerator<VisualTreeAsset> IEnumerable<VisualTreeAsset>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	internal static string LinkedVEAInTemplatePropertyName;

	[SerializeField]
	private bool m_ImportedWithErrors;

	[SerializeField]
	private bool m_ImportedWithWarnings;

	private static readonly Dictionary<string, VisualElement> s_TemporarySlotInsertionPoints;

	[SerializeField]
	private List<UsingEntry> m_Usings;

	[SerializeField]
	internal StyleSheet inlineSheet;

	[SerializeField]
	private List<VisualElementAsset> m_VisualElementAssets;

	[SerializeField]
	private List<TemplateAsset> m_TemplateAssets;

	[SerializeField]
	private List<UxmlObjectEntry> m_UxmlObjectEntries;

	[SerializeField]
	private List<int> m_UxmlObjectIds;

	[SerializeField]
	private List<AssetEntry> m_AssetEntries;

	[SerializeField]
	private List<SlotDefinition> m_Slots;

	[SerializeField]
	private int m_ContentContainerId;

	[SerializeField]
	private int m_ContentHash;

	public bool importedWithErrors
	{
		get
		{
			return false;
		}
		internal set
		{
		}
	}

	public bool importedWithWarnings
	{
		get
		{
			return false;
		}
		internal set
		{
		}
	}

	public IEnumerable<VisualTreeAsset> templateDependencies
	{
		[IteratorStateMachine(typeof(_003Cget_templateDependencies_003Ed__19))]
		get
		{
			return null;
		}
	}

	public IEnumerable<StyleSheet> stylesheets
	{
		[IteratorStateMachine(typeof(_003Cget_stylesheets_003Ed__23))]
		get
		{
			return null;
		}
	}

	internal List<VisualElementAsset> visualElementAssets
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal List<TemplateAsset> templateAssets
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal List<UxmlObjectEntry> uxmlObjectEntries => null;

	internal List<int> uxmlObjectIds => null;

	internal List<SlotDefinition> slots
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal int contentContainerId
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int contentHash
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal int GetNextChildSerialNumber()
	{
		return 0;
	}

	internal void RegisterUxmlObject(UxmlObjectAsset uxmlObjectAsset)
	{
	}

	internal List<T> GetUxmlObjects<T>(IUxmlAttributes asset, CreationContext cc) where T : new()
	{
		return null;
	}

	internal bool AssetEntryExists(string path, Type type)
	{
		return false;
	}

	internal void RegisterAssetEntry(string path, Type type, Object asset)
	{
	}

	internal T GetAsset<T>(string path) where T : Object
	{
		return null;
	}

	internal UxmlObjectEntry GetUxmlObjectEntry(int id)
	{
		return default(UxmlObjectEntry);
	}

	private IBaseUxmlObjectFactory GetUxmlObjectFactory(UxmlObjectAsset uxmlObjectAsset)
	{
		return null;
	}

	public TemplateContainer Instantiate()
	{
		return null;
	}

	public TemplateContainer Instantiate(string bindingPath)
	{
		return null;
	}

	public TemplateContainer CloneTree()
	{
		return null;
	}

	public TemplateContainer CloneTree(string bindingPath)
	{
		return null;
	}

	public void CloneTree(VisualElement target)
	{
	}

	public void CloneTree(VisualElement target, out int firstElementIndex, out int elementAddedCount)
	{
		firstElementIndex = default(int);
		elementAddedCount = default(int);
	}

	internal void CloneTree(VisualElement target, Dictionary<string, VisualElement> slotInsertionPoints, List<TemplateAsset.AttributeOverride> attributeOverrides)
	{
	}

	private VisualElement CloneSetupRecursively(VisualElementAsset root, Dictionary<int, List<VisualElementAsset>> idToChildren, CreationContext context)
	{
		return null;
	}

	private static int CompareForOrder(VisualElementAsset a, VisualElementAsset b)
	{
		return 0;
	}

	internal bool TryGetSlotInsertionPoint(int insertionPointId, out string slotName)
	{
		slotName = null;
		return false;
	}

	internal VisualTreeAsset ResolveTemplate(string templateName)
	{
		return null;
	}

	internal static VisualElement Create(VisualElementAsset asset, CreationContext ctx)
	{
		return null;
	}

	private static void AssignClassListFromAssetToElement(VisualElementAsset asset, VisualElement element)
	{
	}

	private static void AssignStyleSheetFromAssetToElement(VisualElementAsset asset, VisualElement element)
	{
	}
}
