using System;

namespace UnityEngine.UIElements;

public interface ITextEdition
{
	internal bool multiline { get; set; }

	bool isReadOnly { get; set; }

	int maxLength { get; set; }

	bool isDelayed { get; set; }

	internal Func<char, bool> AcceptCharacter { get; set; }

	internal Action<bool> UpdateScrollOffset { get; set; }

	internal Action UpdateValueFromText { get; set; }

	internal Action UpdateTextFromValue { get; set; }

	internal Action MoveFocusToCompositeRoot { get; set; }

	char maskChar { set; }

	bool isPassword { get; set; }

	bool autoCorrection
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	bool hideMobileInput
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	TouchScreenKeyboardType keyboardType
	{
		get
		{
			return default(TouchScreenKeyboardType);
		}
		set
		{
		}
	}

	internal void SaveValueAndText();

	internal void RestoreValueAndText();

	internal void UpdateText(string value);

	internal string CullString(string s);
}
