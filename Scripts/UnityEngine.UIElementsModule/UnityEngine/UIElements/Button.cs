using System;

namespace UnityEngine.UIElements;

public class Button : TextElement
{
	public new class UxmlFactory : UxmlFactory<Button, UxmlTraits>
	{
	}

	public new class UxmlTraits : TextElement.UxmlTraits
	{
	}

	public new static readonly string ussClassName;

	private Clickable m_Clickable;

	private static readonly string NonEmptyString;

	public Clickable clickable
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Button()
	{
	}

	public Button(Action clickEvent)
	{
	}

	private void OnNavigationSubmit(NavigationSubmitEvent evt)
	{
	}

	protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode)
	{
		return default(Vector2);
	}
}
