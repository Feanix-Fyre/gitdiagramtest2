using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements;

[Serializable]
public class SortColumnDescription
{
	internal class UxmlObjectFactory<T> : UxmlObjectFactory<T, UxmlObjectTraits<T>> where T : SortColumnDescription, new()
	{
	}

	internal class UxmlObjectTraits<T> : UnityEngine.UIElements.UxmlObjectTraits<T> where T : SortColumnDescription
	{
		private readonly UxmlStringAttributeDescription m_ColumnName;

		private readonly UxmlIntAttributeDescription m_ColumnIndex;

		private readonly UxmlEnumAttributeDescription<SortDirection> m_SortDescription;

		public override void Init(ref T obj, IUxmlAttributes bag, CreationContext cc)
		{
		}
	}

	[SerializeField]
	private int m_ColumnIndex;

	[SerializeField]
	private string m_ColumnName;

	[SerializeField]
	private SortDirection m_SortDirection;

	public string columnName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int columnIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Column column { get; internal set; }

	public SortDirection direction
	{
		get
		{
			return default(SortDirection);
		}
		set
		{
		}
	}

	internal event Action<SortColumnDescription> changed
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

	public SortColumnDescription()
	{
	}

	public SortColumnDescription(int columnIndex, SortDirection direction)
	{
	}

	public SortColumnDescription(string columnName, SortDirection direction)
	{
	}
}
