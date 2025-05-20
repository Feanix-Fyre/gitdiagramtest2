using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Profiling;

namespace UnityEngine.UIElements;

public abstract class BaseVerticalCollectionView : BindableElement, ISerializationCallbackReceiver
{
	public new class UxmlTraits : BindableElement.UxmlTraits
	{
		private readonly UxmlIntAttributeDescription m_FixedItemHeight;

		private readonly UxmlEnumAttributeDescription<CollectionVirtualizationMethod> m_VirtualizationMethod;

		private readonly UxmlBoolAttributeDescription m_ShowBorder;

		private readonly UxmlEnumAttributeDescription<SelectionType> m_SelectionType;

		private readonly UxmlEnumAttributeDescription<AlternatingRowBackground> m_ShowAlternatingRowBackgrounds;

		private readonly UxmlBoolAttributeDescription m_Reorderable;

		private readonly UxmlBoolAttributeDescription m_HorizontalScrollingEnabled;

		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}
	}

	private static readonly ProfilerMarker k_RefreshMarker;

	private static readonly ProfilerMarker k_RebuildMarker;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Action<IEnumerable<object>> itemsChosen;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<IEnumerable<object>> selectionChanged;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Action<IEnumerable<int>> selectedIndicesChanged;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Action<int, int> itemIndexChanged;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action itemsSourceChanged;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action selectionNotChanged;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Func<CanStartDragArgs, bool> canStartDrag;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Func<SetupDragAndDropArgs, StartDragArgs> setupDragAndDrop;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Func<HandleDragAndDropArgs, DragVisualMode> dragAndDropUpdate;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Func<HandleDragAndDropArgs, DragVisualMode> handleDrop;

	private SelectionType m_SelectionType;

	private static readonly List<ReusableCollectionItem> k_EmptyItems;

	private bool m_HorizontalScrollingEnabled;

	[SerializeField]
	private AlternatingRowBackground m_ShowAlternatingRowBackgrounds;

	internal static readonly int s_DefaultItemHeight;

	internal float m_FixedItemHeight;

	internal bool m_ItemHeightIsInline;

	private CollectionVirtualizationMethod m_VirtualizationMethod;

	private readonly ScrollView m_ScrollView;

	private CollectionViewController m_ViewController;

	private CollectionVirtualizationController m_VirtualizationController;

	private KeyboardNavigationManipulator m_NavigationManipulator;

	[SerializeField]
	internal SerializedVirtualizationData serializedVirtualizationData;

	[SerializeField]
	private readonly List<int> m_SelectedIds;

	private readonly List<int> m_SelectedIndices;

	private readonly List<object> m_SelectedItems;

	private float m_LastHeight;

	private bool m_IsRangeSelectionDirectionUp;

	private ListViewDragger m_Dragger;

	internal static CustomStyleProperty<int> s_ItemHeightProperty;

	private Action<int, int> m_ItemIndexChangedCallback;

	private Action m_ItemsSourceChangedCallback;

	public static readonly string ussClassName;

	public static readonly string borderUssClassName;

	public static readonly string itemUssClassName;

	public static readonly string dragHoverBarUssClassName;

	public static readonly string dragHoverMarkerUssClassName;

	public static readonly string itemDragHoverUssClassName;

	public static readonly string itemSelectedVariantUssClassName;

	public static readonly string itemAlternativeBackgroundUssClassName;

	public static readonly string listScrollViewUssClassName;

	internal static readonly string backgroundFillUssClassName;

	private Vector3 m_TouchDownPosition;

	public IList itemsSource
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override VisualElement contentContainer => null;

	public SelectionType selectionType
	{
		get
		{
			return default(SelectionType);
		}
		set
		{
		}
	}

	public int selectedIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public IEnumerable<int> selectedIndices => null;

	internal IEnumerable<int> selectedIds => null;

	internal IEnumerable<ReusableCollectionItem> activeItems => null;

	internal ScrollView scrollView => null;

	internal ListViewDragger dragger => null;

	internal CollectionVirtualizationController virtualizationController => null;

	public CollectionViewController viewController => null;

	public bool showBorder
	{
		set
		{
		}
	}

	public bool reorderable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool horizontalScrollingEnabled
	{
		set
		{
		}
	}

	public AlternatingRowBackground showAlternatingRowBackgrounds
	{
		get
		{
			return default(AlternatingRowBackground);
		}
		set
		{
		}
	}

	public CollectionVirtualizationMethod virtualizationMethod
	{
		get
		{
			return default(CollectionVirtualizationMethod);
		}
		set
		{
		}
	}

	public float fixedItemHeight
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	internal float lastHeight => 0f;

	internal bool HasCanStartDrag()
	{
		return false;
	}

	internal bool RaiseCanStartDrag(ReusableCollectionItem item, IEnumerable<int> ids)
	{
		return false;
	}

	internal StartDragArgs RaiseSetupDragAndDrop(ReusableCollectionItem item, IEnumerable<int> ids, StartDragArgs args)
	{
		return default(StartDragArgs);
	}

	internal DragVisualMode RaiseHandleDragAndDrop(Vector2 pointerPosition, DragAndDropArgs dragAndDropArgs)
	{
		return default(DragVisualMode);
	}

	internal DragVisualMode RaiseDrop(Vector2 pointerPosition, DragAndDropArgs dragAndDropArgs)
	{
		return default(DragVisualMode);
	}

	internal float ResolveItemHeight(float height = -1f)
	{
		return 0f;
	}

	private protected virtual void CreateVirtualizationController()
	{
	}

	internal CollectionVirtualizationController GetOrCreateVirtualizationController()
	{
		return null;
	}

	internal void CreateVirtualizationController<T>() where T : ReusableCollectionItem, new()
	{
	}

	internal CollectionViewController GetOrCreateViewController()
	{
		return null;
	}

	protected abstract CollectionViewController CreateViewController();

	public virtual void SetViewController(CollectionViewController controller)
	{
	}

	internal virtual ListViewDragger CreateDragger()
	{
		return null;
	}

	internal void InitializeDragAndDropController(bool enableReordering)
	{
	}

	internal abstract ICollectionDragAndDropController CreateDragAndDropController();

	public BaseVerticalCollectionView()
	{
	}

	public BaseVerticalCollectionView(IList itemsSource, float itemHeight = -1f)
	{
	}

	public VisualElement GetRootElementForId(int id)
	{
		return null;
	}

	internal virtual bool HasValidDataAndBindings()
	{
		return false;
	}

	private void OnItemIndexChanged(int srcIndex, int dstIndex)
	{
	}

	private void OnItemsSourceChanged()
	{
	}

	public void RefreshItems()
	{
	}

	public void Rebuild()
	{
	}

	private void RefreshSelection()
	{
	}

	private protected virtual void PostRefresh()
	{
	}

	public void ScrollToItem(int index)
	{
	}

	public void ScrollToItemById(int id)
	{
	}

	private void OnScroll(Vector2 offset)
	{
	}

	private void Resize(Vector2 size)
	{
	}

	private void OnAttachToPanel(AttachToPanelEvent evt)
	{
	}

	private void OnDetachFromPanel(DetachFromPanelEvent evt)
	{
	}

	private bool Apply(KeyboardNavigationOperation op, bool shiftKey, bool altKey)
	{
		return false;
	}

	private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent)
	{
	}

	private protected virtual bool HandleItemNavigation(bool moveIn, bool altKey)
	{
		return false;
	}

	private void OnPointerMove(PointerMoveEvent evt)
	{
	}

	private void OnPointerDown(PointerDownEvent evt)
	{
	}

	private void OnPointerCancel(PointerCancelEvent evt)
	{
	}

	private void OnPointerUp(PointerUpEvent evt)
	{
	}

	private void ProcessPointerDown(IPointerEvent evt)
	{
	}

	private void ProcessPointerUp(IPointerEvent evt)
	{
	}

	private void DoSelect(Vector2 localPosition, int clickCount, bool actionKey, bool shiftKey)
	{
	}

	internal void DoRangeSelection(int rangeSelectionFinalIndex)
	{
	}

	private void ProcessSingleClick(int clickedIndex)
	{
	}

	internal void SelectAll()
	{
	}

	public void AddToSelection(int index)
	{
	}

	internal void AddToSelection(IList<int> indexes)
	{
	}

	private void AddToSelectionWithoutValidation(int index)
	{
	}

	public void RemoveFromSelection(int index)
	{
	}

	private void RemoveFromSelectionWithoutValidation(int index)
	{
	}

	public void SetSelection(int index)
	{
	}

	public void SetSelection(IEnumerable<int> indices)
	{
	}

	public void SetSelectionWithoutNotify(IEnumerable<int> indices)
	{
	}

	internal void SetSelectionInternal(IEnumerable<int> indices, bool sendNotification)
	{
	}

	private bool MatchesExistingSelection(IEnumerable<int> indices)
	{
		return false;
	}

	private void NotifyOfSelectionChange()
	{
	}

	public void ClearSelection()
	{
	}

	private void ClearSelectionWithoutValidation()
	{
	}

	internal override void OnViewDataReady()
	{
	}

	[EventInterest(new Type[]
	{
		typeof(PointerUpEvent),
		typeof(FocusEvent),
		typeof(NavigationSubmitEvent),
		typeof(BlurEvent)
	})]
	protected override void ExecuteDefaultAction(EventBase evt)
	{
	}

	private void OnSizeChanged(GeometryChangedEvent evt)
	{
	}

	private void OnCustomStyleResolved(CustomStyleResolvedEvent e)
	{
	}

	void ISerializationCallbackReceiver.OnBeforeSerialize()
	{
	}

	void ISerializationCallbackReceiver.OnAfterDeserialize()
	{
	}
}
