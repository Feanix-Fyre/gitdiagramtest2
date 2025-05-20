using System;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class Hash128Field : TextInputBaseField<Hash128>
{
	public new class UxmlFactory : UxmlFactory<Hash128Field, UxmlTraits>
	{
	}

	public new class UxmlTraits : TextValueFieldTraits<Hash128, UxmlHash128AttributeDescription>
	{
	}

	private class Hash128Input : TextInputBase
	{
		protected string allowedCharacters => null;

		internal Hash128Input()
		{
		}

		internal override bool AcceptCharacter(char c)
		{
			return false;
		}

		protected override Hash128 StringToValue(string str)
		{
			return default(Hash128);
		}

		internal static Hash128 Parse(string str)
		{
			return default(Hash128);
		}
	}

	internal bool m_UpdateTextFromValue;

	public new static readonly string ussClassName;

	public new static readonly string labelUssClassName;

	public new static readonly string inputUssClassName;

	public override Hash128 value
	{
		get
		{
			return default(Hash128);
		}
		set
		{
		}
	}

	public Hash128Field()
		: base((string)null, 0, '\0', (TextInputBase)null)
	{
	}

	public Hash128Field(string label, int maxLength = -1)
		: base((string)null, 0, '\0', (TextInputBase)null)
	{
	}

	internal override void UpdateValueFromText()
	{
	}

	internal override void UpdateTextFromValue()
	{
	}

	public override void SetValueWithoutNotify(Hash128 newValue)
	{
	}

	protected override string ValueToString(Hash128 value)
	{
		return null;
	}

	protected override Hash128 StringToValue(string str)
	{
		return default(Hash128);
	}

	[EventInterest(new Type[] { typeof(BlurEvent) })]
	protected override void ExecuteDefaultAction(EventBase evt)
	{
	}
}
