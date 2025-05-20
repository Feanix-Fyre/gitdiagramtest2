using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements.Internal;

internal class MultiColumnCollectionHeader : VisualElement, IDisposable
{
	[Serializable]
	private class ViewState
	{
		[Serializable]
		private struct ColumnState
		{
			public int index;

			public string name;

			public float actualWidth;

			public Length width;

			public bool visible;
		}

		[SerializeField]
		private bool m_HasPersistedData;

		[SerializeField]
		private List<SortColumnDescription> m_SortDescriptions;

		[SerializeField]
		private List<ColumnState> m_OrderedColumnStates;

		internal void Save(MultiColumnCollectionHeader header)
		{
		}

		internal void Apply(MultiColumnCollectionHeader header)
		{
		}
	}

	internal class ColumnData
	{
		public MultiColumnHeaderColumn control { get; set; }

		public MultiColumnHeaderColumnResizeHandle resizeHandle { get; set; }
	}

	private struct SortedColumnState
	{
		public SortColumnDescription columnDesc;

		public SortDirection direction;

		public SortedColumnState(SortColumnDescription desc, SortDirection dir)
		{
			columnDesc = null;
			direction = default(SortDirection);
		}
	}

	public static readonly string ussClassName;

	public static readonly string columnContainerUssClassName;

	public static readonly string handleContainerUssClassName;

	public static readonly string reorderableUssClassName;

	private bool m_SortingEnabled;

	private List<SortColumnDescription> m_SortedColumns;

	private SortColumnDescriptions m_SortDescriptions;

	private List<SortedColumnState> m_OldSortedColumnStates;

	private bool m_SortingUpdatesTemporarilyDisabled;

	private ViewState m_ViewState;

	private bool m_ApplyingViewState;

	private bool m_DoLayoutScheduled;

	internal bool isApplyingViewState => false;

	public Dictionary<Column, ColumnData> columnDataMap { get; }

	public ColumnLayout columnLayout { get; }

	public VisualElement columnContainer { get; }

	public VisualElement resizeHandleContainer { get; }

	public IEnumerable<SortColumnDescription> sortedColumns => null;

	public SortColumnDescriptions sortDescriptions
	{
		get
		{
			return null;
		}
		protected internal set
		{
		}
	}

	public Columns columns { get; }

	public bool sortingEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public event Action<int, float> columnResized
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

	public event Action columnSortingChanged
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

	public event Action<ContextualMenuPopulateEvent, Column> contextMenuPopulateEvent
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

	internal event Action viewDataRestored
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

	public MultiColumnCollectionHeader(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns)
	{
	}

	private void ScheduleDoLayout()
	{
	}

	private void ResizeToFit()
	{
	}

	private void UpdateSortedColumns()
	{
	}

	private void UpdateColumnControls()
	{
	}

	private void OnColumnAdded(Column column, int index)
	{
	}

	private void OnColumnAdded(Column column)
	{
	}

	private void OnColumnRemoved(Column column)
	{
	}

	private void OnColumnChanged(Column column, ColumnDataType type)
	{
	}

	private void OnColumnReordered(Column column, int from, int to)
	{
	}

	private void OnColumnResized(Column column)
	{
	}

	private void OnContextualMenuManipulator(ContextualMenuPopulateEvent evt)
	{
	}

	private void OnMoveManipulatorActivated(ColumnMover mover)
	{
	}

	private void OnGeometryChanged(GeometryChangedEvent e)
	{
	}

	private void DoLayout()
	{
	}

	private void OnColumnControlGeometryChanged(GeometryChangedEvent evt)
	{
	}

	private void OnColumnClicked(EventBase evt)
	{
	}

	private void UpdateSortColumnDescriptionsOnClick(Column column, EventModifiers modifiers)
	{
	}

	public void ScrollHorizontally(float horizontalOffset)
	{
	}

	private void RaiseColumnResized(int columnIndex)
	{
	}

	private void RaiseColumnSortingChanged()
	{
	}

	private void ApplyColumnSorting()
	{
	}

	private void UpdateSortingStatus()
	{
	}

	internal override void OnViewDataReady()
	{
	}

	private void SaveViewState()
	{
	}

	public void Dispose()
	{
	}
}
