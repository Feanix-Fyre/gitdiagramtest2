namespace UnityEngine.UIElements.Internal;

internal class MultiColumnHeaderColumn : VisualElement
{
	public static readonly string ussClassName;

	public static readonly string sortableUssClassName;

	public static readonly string sortedAscendingUssClassName;

	public static readonly string sortedDescendingUssClassName;

	public static readonly string movingUssClassName;

	public static readonly string contentContainerUssClassName;

	public static readonly string contentUssClassName;

	public static readonly string defaultContentUssClassName;

	public static readonly string hasIconUssClassName;

	public static readonly string hasTitleUssClassName;

	public static readonly string titleUssClassName;

	public static readonly string iconElementName;

	public static readonly string titleElementName;

	private static readonly string s_BoundVEPropertyName;

	private static readonly string s_BindingCallbackVEPropertyName;

	private static readonly string s_UnbindingCallbackVEPropertyName;

	private static readonly string s_DestroyCallbackVEPropertyName;

	private VisualElement m_ContentContainer;

	private VisualElement m_Content;

	private MultiColumnHeaderColumnSortIndicator m_SortIndicatorContainer;

	private IVisualElementScheduledItem m_ScheduledHeaderTemplateUpdate;

	public Clickable clickable { get; private set; }

	public ColumnMover mover { get; private set; }

	public string sortOrderLabel
	{
		set
		{
		}
	}

	public Column column { get; set; }

	public VisualElement content
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private bool isContentBound
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public MultiColumnHeaderColumn(Column column)
	{
	}

	private void InitManipulators()
	{
	}

	private void UpdateDataFromColumn()
	{
	}

	private void BindHeaderContent()
	{
	}

	private void UnbindHeaderContent()
	{
	}

	private void DestroyHeaderContent()
	{
	}

	private VisualElement CreateDefaultHeaderContent()
	{
		return null;
	}

	private void DefaultBindHeaderContent(VisualElement ve)
	{
	}

	private void UpdateHeaderTemplate()
	{
	}

	private void UpdateGeometryFromColumn()
	{
	}
}
