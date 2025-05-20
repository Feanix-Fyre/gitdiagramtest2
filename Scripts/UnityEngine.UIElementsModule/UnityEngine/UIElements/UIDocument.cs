using System.Collections.Generic;

namespace UnityEngine.UIElements;

[DefaultExecutionOrder(-100)]
[DisallowMultipleComponent]
[ExecuteAlways]
[AddComponentMenu("UI Toolkit/UI Document")]
[HelpURL("UIE-get-started-with-runtime-ui")]
public sealed class UIDocument : MonoBehaviour
{
	internal const string k_RootStyleClassName = "unity-ui-document__root";

	internal const string k_VisualElementNameSuffix = "-container";

	private const int k_DefaultSortingOrder = 0;

	private static int s_CurrentUIDocumentCounter;

	internal readonly int m_UIDocumentCreationIndex;

	[SerializeField]
	private PanelSettings m_PanelSettings;

	private PanelSettings m_PreviousPanelSettings;

	[SerializeField]
	private UIDocument m_ParentUI;

	private UIDocumentList m_ChildrenContent;

	private List<UIDocument> m_ChildrenContentCopy;

	[SerializeField]
	private VisualTreeAsset sourceAsset;

	private VisualElement m_RootVisualElement;

	private int m_FirstChildInsertIndex;

	[SerializeField]
	private float m_SortingOrder;

	public PanelSettings panelSettings
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UIDocument parentUI
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public VisualTreeAsset visualTreeAsset
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public VisualElement rootVisualElement => null;

	internal int firstChildInserIndex => 0;

	public float sortingOrder
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	internal void ApplySortingOrder()
	{
	}

	private UIDocument()
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void SetupFromHierarchy()
	{
	}

	private UIDocument FindUIDocumentParent()
	{
		return null;
	}

	internal void Reset()
	{
	}

	private void AddChildAndInsertContentToVisualTree(UIDocument child)
	{
	}

	private void RemoveChild(UIDocument child)
	{
	}

	private void RecreateUI()
	{
	}

	private void SetupRootClassList()
	{
	}

	private void AddRootVisualElementToTree()
	{
	}

	private void RemoveFromHierarchy()
	{
	}

	private void OnDisable()
	{
	}

	private void OnTransformChildrenChanged()
	{
	}

	private void OnTransformParentChanged()
	{
	}

	internal void ReactToHierarchyChanged()
	{
	}
}
