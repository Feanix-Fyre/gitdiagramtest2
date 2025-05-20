using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements;

public class Column
{
	internal class UxmlObjectFactory<T> : UxmlObjectFactory<T, UxmlObjectTraits<T>> where T : Column, new()
	{
	}

	internal class UxmlObjectTraits<T> : UnityEngine.UIElements.UxmlObjectTraits<T> where T : Column
	{
		private UxmlStringAttributeDescription m_Name;

		private UxmlStringAttributeDescription m_Text;

		private UxmlBoolAttributeDescription m_Visible;

		private UxmlStringAttributeDescription m_Width;

		private UxmlStringAttributeDescription m_MinWidth;

		private UxmlStringAttributeDescription m_MaxWidth;

		private UxmlBoolAttributeDescription m_Stretch;

		private UxmlBoolAttributeDescription m_Sortable;

		private UxmlBoolAttributeDescription m_Optional;

		private UxmlBoolAttributeDescription m_Resizable;

		private UxmlStringAttributeDescription m_HeaderTemplateId;

		private UxmlStringAttributeDescription m_CellTemplateId;

		private static Length ParseLength(string str, Length defaultValue)
		{
			return default(Length);
		}

		public override void Init(ref T obj, IUxmlAttributes bag, CreationContext cc)
		{
		}
	}

	private static readonly string k_InvalidTemplateError;

	private string m_Name;

	private string m_Title;

	private Background m_Icon;

	private bool m_Visible;

	private Length m_Width;

	private Length m_MinWidth;

	private Length m_MaxWidth;

	private float m_DesiredWidth;

	private bool m_Stretchable;

	private bool m_Sortable;

	private bool m_Optional;

	private bool m_Resizable;

	private Func<VisualElement> m_MakeHeader;

	private Action<VisualElement> m_BindHeader;

	private Action<VisualElement> m_UnbindHeader;

	private Action<VisualElement> m_DestroyHeader;

	private Func<VisualElement> m_MakeCell;

	private Action<VisualElement, int> m_BindCell;

	private Action<VisualElement, int> m_UnbindCellItem;

	public string name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string title
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Background icon => default(Background);

	internal int index => 0;

	internal int displayIndex => 0;

	internal int visibleIndex => 0;

	public bool visible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Length width
	{
		get
		{
			return default(Length);
		}
		set
		{
		}
	}

	public Length minWidth
	{
		get
		{
			return default(Length);
		}
		set
		{
		}
	}

	public Length maxWidth
	{
		get
		{
			return default(Length);
		}
		set
		{
		}
	}

	internal float desiredWidth
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool sortable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool stretchable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool optional
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool resizable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Func<VisualElement> makeHeader
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Action<VisualElement> bindHeader => null;

	public Action<VisualElement> unbindHeader => null;

	public Action<VisualElement> destroyHeader => null;

	public Func<VisualElement> makeCell
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Action<VisualElement, int> bindCell => null;

	public Action<VisualElement, int> unbindCell => null;

	public Action<VisualElement> destroyCell { get; }

	public Columns collection { get; internal set; }

	internal event Action<Column, ColumnDataType> changed
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

	internal event Action<Column> resized
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

	private void NotifyChange(ColumnDataType type)
	{
	}

	internal float GetWidth(float layoutWidth)
	{
		return 0f;
	}

	internal float GetMaxWidth(float layoutWidth)
	{
		return 0f;
	}

	internal float GetMinWidth(float layoutWidth)
	{
		return 0f;
	}
}
