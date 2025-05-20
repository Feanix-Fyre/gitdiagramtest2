using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements;

public class MultiColumnListView : BaseListView
{
	public new class UxmlFactory : UxmlFactory<MultiColumnListView, UxmlTraits>
	{
	}

	public new class UxmlTraits : BaseListView.UxmlTraits
	{
		private readonly UxmlBoolAttributeDescription m_SortingEnabled;

		private readonly UxmlObjectAttributeDescription<Columns> m_Columns;

		private readonly UxmlObjectAttributeDescription<SortColumnDescriptions> m_SortColumnDescriptions;

		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}
	}

	private Columns m_Columns;

	private bool m_SortingEnabled;

	private SortColumnDescriptions m_SortColumnDescriptions;

	private List<SortColumnDescription> m_SortedColumns;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action columnSortingChanged;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Action<ContextualMenuPopulateEvent, Column> headerContextMenuPopulateEvent;

	public new MultiColumnListViewController viewController => null;

	public Columns columns
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public SortColumnDescriptions sortColumnDescriptions
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public bool sortingEnabled
	{
		set
		{
		}
	}

	public MultiColumnListView()
	{
	}

	public MultiColumnListView(Columns columns)
	{
	}

	protected override CollectionViewController CreateViewController()
	{
		return null;
	}

	public override void SetViewController(CollectionViewController controller)
	{
	}

	private protected override void CreateVirtualizationController()
	{
	}

	private void RaiseColumnSortingChanged()
	{
	}

	private void RaiseHeaderContextMenuPopulate(ContextualMenuPopulateEvent evt, Column column)
	{
	}
}
