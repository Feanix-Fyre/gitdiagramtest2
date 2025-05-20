using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class PopupField<T> : BasePopupField<T, T>
{
	private int m_Index;

	public new static readonly string ussClassName;

	public new static readonly string labelUssClassName;

	public new static readonly string inputUssClassName;

	public override T value
	{
		get
		{
			return default(T);
		}
		set
		{
		}
	}

	public int index
	{
		set
		{
		}
	}

	internal override string GetValueToDisplay()
	{
		return null;
	}

	internal override string GetListItemToDisplay(T value)
	{
		return null;
	}

	public override void SetValueWithoutNotify(T newValue)
	{
	}

	public PopupField(string label = null)
		: base((string)null)
	{
	}

	internal override void AddMenuItems(IGenericMenu menu)
	{
	}

	private void ChangeValueFromMenu(T menuItem)
	{
	}
}
