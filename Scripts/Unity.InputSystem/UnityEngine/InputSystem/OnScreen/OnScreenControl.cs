using Unity.Collections;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.OnScreen;

public abstract class OnScreenControl : MonoBehaviour
{
	private struct OnScreenDeviceInfo
	{
		public InputEventPtr eventPtr;

		public NativeArray<byte> buffer;

		public InputDevice device;

		public OnScreenControl firstControl;

		public OnScreenDeviceInfo AddControl(OnScreenControl control)
		{
			return default(OnScreenDeviceInfo);
		}

		public OnScreenDeviceInfo RemoveControl(OnScreenControl control)
		{
			return default(OnScreenDeviceInfo);
		}

		public void Destroy()
		{
		}
	}

	private InputControl m_Control;

	private OnScreenControl m_NextControlOnDevice;

	private InputEventPtr m_InputEventPtr;

	private static InlinedArray<OnScreenDeviceInfo> s_OnScreenDevices;

	public string controlPath
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public InputControl control => null;

	protected abstract string controlPathInternal { get; set; }

	private void SetupInputControl()
	{
	}

	protected void SendValueToControl<TValue>(TValue value) where TValue : struct
	{
	}

	protected void SentDefaultValueToControl()
	{
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}
}
