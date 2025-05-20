using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements;

public abstract class BaseListView : BaseVerticalCollectionView
{
	public new class UxmlTraits : BaseVerticalCollectionView.UxmlTraits
	{
		private readonly UxmlBoolAttributeDescription m_ShowFoldoutHeader;

		private readonly UxmlStringAttributeDescription m_HeaderTitle;

		private readonly UxmlBoolAttributeDescription m_ShowAddRemoveFooter;

		private readonly UxmlEnumAttributeDescription<ListViewReorderMode> m_ReorderMode;

		private readonly UxmlBoolAttributeDescription m_ShowBoundCollectionSize;

		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		protected UxmlTraits()
		{
		}
	}

	private static readonly string k_SizeFieldLabel;

	private bool m_ShowBoundCollectionSize;

	private bool m_ShowFoldoutHeader;

	private string m_HeaderTitle;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<IEnumerable<int>> itemsAdded;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<IEnumerable<int>> itemsRemoved;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action itemsSourceSizeChanged;

	private Label m_ListViewLabel;

	private Foldout m_Foldout;

	private TextField m_ArraySizeField;

	private bool m_IsOverMultiEditLimit;

	private VisualElement m_Footer;

	private Button m_AddButton;

	private Button m_RemoveButton;

	private Action<IEnumerable<int>> m_ItemAddedCallback;

	private Action<IEnumerable<int>> m_ItemRemovedCallback;

	private Action m_ItemsSourceSizeChangedCallback;

	private ListViewReorderMode m_ReorderMode;

	public new static readonly string ussClassName;

	public new static readonly string itemUssClassName;

	public static readonly string emptyLabelUssClassName;

	public static readonly string overMaxMultiEditLimitClassName;

	public static readonly string reorderableUssClassName;

	public static readonly string reorderableItemUssClassName;

	public static readonly string reorderableItemContainerUssClassName;

	public static readonly string reorderableItemHandleUssClassName;

	public static readonly string reorderableItemHandleBarUssClassName;

	public static readonly string footerUssClassName;

	public static readonly string foldoutHeaderUssClassName;

	public static readonly string arraySizeFieldUssClassName;

	public static readonly string arraySizeFieldWithHeaderUssClassName;

	public static readonly string arraySizeFieldWithFooterUssClassName;

	public static readonly string listViewWithHeaderUssClassName;

	public static readonly string listViewWithFooterUssClassName;

	public static readonly string scrollViewWithFooterUssClassName;

	public static readonly string footerAddButtonName;

	public static readonly string footerRemoveButtonName;

	private string m_MaxMultiEditStr;

	private static readonly string k_EmptyListStr;

	public bool showBoundCollectionSize
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool showFoldoutHeader
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string headerTitle
	{
		set
		{
		}
	}

	public bool showAddRemoveFooter
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal VisualElement footer => null;

	public new BaseListViewController viewController => null;

	public ListViewReorderMode reorderMode
	{
		get
		{
			return default(ListViewReorderMode);
		}
		set
		{
		}
	}

	internal event Action reorderModeChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	internal void SetupArraySizeField()
	{
	}

	private void EnableFooter(bool enabled)
	{
	}

	private void AddItems(int itemCount)
	{
	}

	private void OnArraySizeFieldChanged(ChangeEvent<string> evt)
	{
	}

	internal void UpdateArraySizeField()
	{
	}

	internal void UpdateListViewLabel()
	{
	}

	private void OnAddClicked()
	{
	}

	private void OnRemoveClicked()
	{
	}

	private protected override void CreateVirtualizationController()
	{
	}

	public override void SetViewController(CollectionViewController controller)
	{
	}

	private void OnItemAdded(IEnumerable<int> indices)
	{
	}

	private void OnItemsRemoved(IEnumerable<int> indices)
	{
	}

	private void OnItemsSourceSizeChanged()
	{
	}

	internal override ListViewDragger CreateDragger()
	{
		return null;
	}

	internal override ICollectionDragAndDropController CreateDragAndDropController()
	{
		return null;
	}

	public BaseListView()
	{
	}

	private protected override void PostRefresh()
	{
	}

	private protected override bool HandleItemNavigation(bool moveIn, bool altPressed)
	{
		return false;
	}
}
