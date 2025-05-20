using System;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

[InputControlLayout(stateType = typeof(KeyboardState), isGenericTypeOfDevice = true)]
public class Keyboard : InputDevice, ITextInputReceiver
{
	public const int KeyCount = 110;

	private InlinedArray<Action<char>> m_TextInputListeners;

	private string m_KeyboardLayoutName;

	private KeyControl[] m_Keys;

	private InlinedArray<Action<IMECompositionString>> m_ImeCompositionListeners;

	public string keyboardLayout
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	public AnyKeyControl anyKey { get; protected set; }

	public KeyControl spaceKey => null;

	public KeyControl enterKey => null;

	public KeyControl tabKey => null;

	public KeyControl backquoteKey => null;

	public KeyControl quoteKey => null;

	public KeyControl semicolonKey => null;

	public KeyControl commaKey => null;

	public KeyControl periodKey => null;

	public KeyControl slashKey => null;

	public KeyControl backslashKey => null;

	public KeyControl leftBracketKey => null;

	public KeyControl rightBracketKey => null;

	public KeyControl minusKey => null;

	public KeyControl equalsKey => null;

	public KeyControl aKey => null;

	public KeyControl bKey => null;

	public KeyControl cKey => null;

	public KeyControl dKey => null;

	public KeyControl eKey => null;

	public KeyControl fKey => null;

	public KeyControl gKey => null;

	public KeyControl hKey => null;

	public KeyControl iKey => null;

	public KeyControl jKey => null;

	public KeyControl kKey => null;

	public KeyControl lKey => null;

	public KeyControl mKey => null;

	public KeyControl nKey => null;

	public KeyControl oKey => null;

	public KeyControl pKey => null;

	public KeyControl qKey => null;

	public KeyControl rKey => null;

	public KeyControl sKey => null;

	public KeyControl tKey => null;

	public KeyControl uKey => null;

	public KeyControl vKey => null;

	public KeyControl wKey => null;

	public KeyControl xKey => null;

	public KeyControl yKey => null;

	public KeyControl zKey => null;

	public KeyControl digit1Key => null;

	public KeyControl digit2Key => null;

	public KeyControl digit3Key => null;

	public KeyControl digit4Key => null;

	public KeyControl digit5Key => null;

	public KeyControl digit6Key => null;

	public KeyControl digit7Key => null;

	public KeyControl digit8Key => null;

	public KeyControl digit9Key => null;

	public KeyControl digit0Key => null;

	public KeyControl leftShiftKey => null;

	public KeyControl rightShiftKey => null;

	public KeyControl leftAltKey => null;

	public KeyControl rightAltKey => null;

	public KeyControl leftCtrlKey => null;

	public KeyControl rightCtrlKey => null;

	public KeyControl leftMetaKey => null;

	public KeyControl rightMetaKey => null;

	public KeyControl leftWindowsKey => null;

	public KeyControl rightWindowsKey => null;

	public KeyControl leftAppleKey => null;

	public KeyControl rightAppleKey => null;

	public KeyControl leftCommandKey => null;

	public KeyControl rightCommandKey => null;

	public KeyControl contextMenuKey => null;

	public KeyControl escapeKey => null;

	public KeyControl leftArrowKey => null;

	public KeyControl rightArrowKey => null;

	public KeyControl upArrowKey => null;

	public KeyControl downArrowKey => null;

	public KeyControl backspaceKey => null;

	public KeyControl pageDownKey => null;

	public KeyControl pageUpKey => null;

	public KeyControl homeKey => null;

	public KeyControl endKey => null;

	public KeyControl insertKey => null;

	public KeyControl deleteKey => null;

	public KeyControl capsLockKey => null;

	public KeyControl scrollLockKey => null;

	public KeyControl numLockKey => null;

	public KeyControl printScreenKey => null;

	public KeyControl pauseKey => null;

	public KeyControl numpadEnterKey => null;

	public KeyControl numpadDivideKey => null;

	public KeyControl numpadMultiplyKey => null;

	public KeyControl numpadMinusKey => null;

	public KeyControl numpadPlusKey => null;

	public KeyControl numpadPeriodKey => null;

	public KeyControl numpadEqualsKey => null;

	public KeyControl numpad0Key => null;

	public KeyControl numpad1Key => null;

	public KeyControl numpad2Key => null;

	public KeyControl numpad3Key => null;

	public KeyControl numpad4Key => null;

	public KeyControl numpad5Key => null;

	public KeyControl numpad6Key => null;

	public KeyControl numpad7Key => null;

	public KeyControl numpad8Key => null;

	public KeyControl numpad9Key => null;

	public KeyControl f1Key => null;

	public KeyControl f2Key => null;

	public KeyControl f3Key => null;

	public KeyControl f4Key => null;

	public KeyControl f5Key => null;

	public KeyControl f6Key => null;

	public KeyControl f7Key => null;

	public KeyControl f8Key => null;

	public KeyControl f9Key => null;

	public KeyControl f10Key => null;

	public KeyControl f11Key => null;

	public KeyControl f12Key => null;

	public KeyControl oem1Key => null;

	public KeyControl oem2Key => null;

	public KeyControl oem3Key => null;

	public KeyControl oem4Key => null;

	public KeyControl oem5Key => null;

	public ButtonControl shiftKey { get; protected set; }

	public ButtonControl ctrlKey { get; protected set; }

	public ButtonControl altKey { get; protected set; }

	public ButtonControl imeSelected { get; protected set; }

	public KeyControl this[Key key] => null;

	public ReadOnlyArray<KeyControl> allKeys => default(ReadOnlyArray<KeyControl>);

	public static Keyboard current { get; private set; }

	protected KeyControl[] keys
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public event Action<char> onTextInput
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<IMECompositionString> onIMECompositionChange
	{
		add
		{
		}
		remove
		{
		}
	}

	public void SetIMEEnabled(bool enabled)
	{
	}

	public void SetIMECursorPosition(Vector2 position)
	{
	}

	public override void MakeCurrent()
	{
	}

	protected override void OnRemoved()
	{
	}

	protected override void FinishSetup()
	{
	}

	protected override void RefreshConfiguration()
	{
	}

	public void OnTextInput(char character)
	{
	}

	public KeyControl FindKeyOnCurrentKeyboardLayout(string displayName)
	{
		return null;
	}

	public void OnIMECompositionChanged(IMECompositionString compositionString)
	{
	}
}
