using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements;

internal class ColumnLayout
{
	private List<Column> m_StretchableColumns;

	private List<Column> m_FixedColumns;

	private List<Column> m_RelativeWidthColumns;

	private List<Column> m_MixedWidthColumns;

	private Columns m_Columns;

	private float m_ColumnsWidth;

	private bool m_ColumnsWidthDirty;

	private float m_MaxColumnsWidth;

	private float m_MinColumnsWidth;

	private bool m_IsDirty;

	private float m_PreviousWidth;

	private float m_LayoutWidth;

	private bool m_DragResizeInPreviewMode;

	private bool m_DragResizing;

	private float m_DragStartPos;

	private float m_DragLastPos;

	private float m_DragInitialColumnWidth;

	private List<Column> m_DragStretchableColumns;

	private List<Column> m_DragRelativeColumns;

	private List<Column> m_DragFixedColumns;

	private Dictionary<Column, float> m_PreviewDesiredWidths;

	public Columns columns => null;

	public float columnsWidth => 0f;

	public float layoutWidth => 0f;

	public float minColumnsWidth => 0f;

	public float maxColumnsWidth => 0f;

	public bool hasStretchableColumns => false;

	public bool hasRelativeWidthColumns => false;

	public event Action layoutRequested
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

	public ColumnLayout(Columns columns)
	{
	}

	public void Dirty()
	{
	}

	private void OnColumnAdded(Column column, int index)
	{
	}

	private void OnColumnRemoved(Column column)
	{
	}

	private void OnColumnReordered(Column column, int from, int to)
	{
	}

	private bool RequiresLayoutUpdate(ColumnDataType type)
	{
		return false;
	}

	private void OnColumnChanged(Column column, ColumnDataType type)
	{
	}

	private void OnColumnResized(Column column)
	{
	}

	private static bool IsClamped(float value, float min, float max)
	{
		return false;
	}

	public void DoLayout(float width)
	{
	}

	public void StretchResizeColumns(List<Column> stretchableColumns, List<Column> fixedColumns, List<Column> relativeWidthColumns, ref float delta, bool resizeToFit, bool dragResize)
	{
	}

	private void DistributeOverflow(List<Column> stretchableColumns, List<Column> fixedColumns, List<Column> relativeWidthColumns, ref float delta, bool resizeToFit, bool dragResize)
	{
	}

	private void DistributeExcess(List<Column> stretchableColumns, List<Column> fixedColumns, List<Column> relativeWidthColumns, ref float delta, bool resizeToFit, bool dragResize)
	{
	}

	private float RecomputeToMaxWidthProportionally(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false)
	{
		return 0f;
	}

	private float RecomputeToMinWidthProportionally(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false)
	{
		return 0f;
	}

	private float RecomputeToDesiredWidth(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly, bool distributeOverflow)
	{
		return 0f;
	}

	private float RecomputeToDesiredWidth(Column column, float distributedDelta, bool setDesiredWidthOnly, bool distributeOverflow)
	{
		return 0f;
	}

	private float RecomputeToMinWidth(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false)
	{
		return 0f;
	}

	private float RecomputeToMaxWidth(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false)
	{
		return 0f;
	}

	public void ResizeToFit(float width)
	{
	}

	private void ResizeColumn(Column column, float width, bool setDesiredWidthOnly = false)
	{
	}

	internal void BeginDragResize(Column column, float pos, bool previewMode)
	{
	}

	public float GetDesiredPosition(Column column)
	{
		return 0f;
	}

	public float GetDesiredWidth(Column c)
	{
		return 0f;
	}

	public void DragResize(Column column, float pos)
	{
	}

	internal void EndDragResize(Column column, bool cancelled)
	{
	}

	private void UpdateCache()
	{
	}

	private void UpdateMinAndMaxColumnsWidth()
	{
	}

	private void ClearCache()
	{
	}
}
