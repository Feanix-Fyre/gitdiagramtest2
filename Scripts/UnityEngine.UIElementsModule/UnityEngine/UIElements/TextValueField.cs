using System;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public abstract class TextValueField<TValueType> : TextInputBaseField<TValueType>, IValueField<TValueType>
{
	protected abstract class TextValueInput : TextInputBase
	{
		private TextValueField<TValueType> textValueFieldParent => null;

		protected abstract string allowedCharacters { get; }

		public string formatString { get; set; }

		internal override bool AcceptCharacter(char c)
		{
			return false;
		}

		public abstract void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, TValueType startValue);

		public void StartDragging()
		{
		}

		public void StopDragging()
		{
		}

		protected abstract string ValueToString(TValueType value);

		protected override TValueType StringToValue(string str)
		{
			return default(TValueType);
		}
	}

	private BaseFieldMouseDragger m_Dragger;

	internal bool m_UpdateTextFromValue;

	private bool m_ForceUpdateDisplay;

	private TextValueInput textValueInput => null;

	public string formatString => null;

	public override TValueType value
	{
		get
		{
			return default(TValueType);
		}
		set
		{
		}
	}

	protected TextValueField(string label, int maxLength, TextValueInput textValueInput)
		: base((string)null, 0, '\0', (TextInputBase)null)
	{
	}

	public abstract void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, TValueType startValue);

	public void StartDragging()
	{
	}

	public void StopDragging()
	{
	}

	internal override void UpdateValueFromText()
	{
	}

	internal override void UpdateTextFromValue()
	{
	}

	private void OnIsReadOnlyChanged(bool newValue)
	{
	}

	internal virtual bool CanTryParse(string textString)
	{
		return false;
	}

	protected void AddLabelDragger<TDraggerType>()
	{
	}

	private void EnableLabelDragger(bool enable)
	{
	}

	public override void SetValueWithoutNotify(TValueType newValue)
	{
	}

	[EventInterest(new Type[]
	{
		typeof(BlurEvent),
		typeof(FocusEvent)
	})]
	protected override void ExecuteDefaultAction(EventBase evt)
	{
	}

	internal override void OnViewDataReady()
	{
	}

	internal override void RegisterEditingCallbacks()
	{
	}

	internal override void UnregisterEditingCallbacks()
	{
	}
}
