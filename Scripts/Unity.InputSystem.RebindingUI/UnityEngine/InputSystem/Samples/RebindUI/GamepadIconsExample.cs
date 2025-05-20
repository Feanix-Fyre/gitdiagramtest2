using System;

namespace UnityEngine.InputSystem.Samples.RebindUI;

public class GamepadIconsExample : MonoBehaviour
{
	[Serializable]
	public struct GamepadIcons
	{
		public Sprite buttonSouth;

		public Sprite buttonNorth;

		public Sprite buttonEast;

		public Sprite buttonWest;

		public Sprite startButton;

		public Sprite selectButton;

		public Sprite leftTrigger;

		public Sprite rightTrigger;

		public Sprite leftShoulder;

		public Sprite rightShoulder;

		public Sprite dpad;

		public Sprite dpadUp;

		public Sprite dpadDown;

		public Sprite dpadLeft;

		public Sprite dpadRight;

		public Sprite leftStick;

		public Sprite rightStick;

		public Sprite leftStickPress;

		public Sprite rightStickPress;

		public Sprite GetSprite(string controlPath)
		{
			return null;
		}
	}

	public GamepadIcons xbox;

	public GamepadIcons ps4;

	protected void OnEnable()
	{
	}

	protected void OnUpdateBindingDisplay(RebindActionUI component, string bindingDisplayString, string deviceLayoutName, string controlPath)
	{
	}
}
