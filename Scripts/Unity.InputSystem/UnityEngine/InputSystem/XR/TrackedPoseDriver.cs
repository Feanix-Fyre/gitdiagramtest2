using System;

namespace UnityEngine.InputSystem.XR;

[Serializable]
[AddComponentMenu("XR/Tracked Pose Driver (Input System)")]
public class TrackedPoseDriver : MonoBehaviour, ISerializationCallbackReceiver
{
	public enum TrackingType
	{
		RotationAndPosition = 0,
		RotationOnly = 1,
		PositionOnly = 2
	}

	[Flags]
	private enum TrackingStates
	{
		None = 0,
		Position = 1,
		Rotation = 2
	}

	public enum UpdateType
	{
		UpdateAndBeforeRender = 0,
		Update = 1,
		BeforeRender = 2
	}

	[SerializeField]
	[Tooltip("Which Transform properties to update.")]
	private TrackingType m_TrackingType;

	[Tooltip("Updates the Transform properties after these phases of Input System event processing.")]
	[SerializeField]
	private UpdateType m_UpdateType;

	[Tooltip("Ignore Tracking State and always treat the input pose as valid.")]
	[SerializeField]
	private bool m_IgnoreTrackingState;

	[Tooltip("The input action to read the position value of a tracked device. Must be a Vector 3 control type.")]
	[SerializeField]
	private InputActionProperty m_PositionInput;

	[Tooltip("The input action to read the rotation value of a tracked device. Must be a Quaternion control type.")]
	[SerializeField]
	private InputActionProperty m_RotationInput;

	[Tooltip("The input action to read the tracking state value of a tracked device. Identifies if position and rotation have valid data. Must be an Integer control type.")]
	[SerializeField]
	private InputActionProperty m_TrackingStateInput;

	private Vector3 m_CurrentPosition;

	private Quaternion m_CurrentRotation;

	private TrackingStates m_CurrentTrackingState;

	private bool m_RotationBound;

	private bool m_PositionBound;

	private bool m_TrackingStateBound;

	private bool m_IsFirstUpdate;

	[Obsolete]
	[SerializeField]
	[HideInInspector]
	private InputAction m_PositionAction;

	[HideInInspector]
	[Obsolete]
	[SerializeField]
	private InputAction m_RotationAction;

	public TrackingType trackingType
	{
		get
		{
			return default(TrackingType);
		}
		set
		{
		}
	}

	public UpdateType updateType
	{
		get
		{
			return default(UpdateType);
		}
		set
		{
		}
	}

	public bool ignoreTrackingState
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public InputActionProperty positionInput
	{
		get
		{
			return default(InputActionProperty);
		}
		set
		{
		}
	}

	public InputActionProperty rotationInput
	{
		get
		{
			return default(InputActionProperty);
		}
		set
		{
		}
	}

	public InputActionProperty trackingStateInput
	{
		get
		{
			return default(InputActionProperty);
		}
		set
		{
		}
	}

	public InputAction positionAction
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public InputAction rotationAction
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void BindActions()
	{
	}

	private void UnbindActions()
	{
	}

	private void BindPosition()
	{
	}

	private void BindRotation()
	{
	}

	private void BindTrackingState()
	{
	}

	private void UnbindPosition()
	{
	}

	private void UnbindRotation()
	{
	}

	private void UnbindTrackingState()
	{
	}

	private void OnPositionPerformed(InputAction.CallbackContext context)
	{
	}

	private void OnPositionCanceled(InputAction.CallbackContext context)
	{
	}

	private void OnRotationPerformed(InputAction.CallbackContext context)
	{
	}

	private void OnRotationCanceled(InputAction.CallbackContext context)
	{
	}

	private void OnTrackingStatePerformed(InputAction.CallbackContext context)
	{
	}

	private void OnTrackingStateCanceled(InputAction.CallbackContext context)
	{
	}

	protected void Reset()
	{
	}

	protected virtual void Awake()
	{
	}

	protected void OnEnable()
	{
	}

	protected void OnDisable()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	protected void UpdateCallback()
	{
	}

	private void ReadTrackingState()
	{
	}

	protected virtual void OnUpdate()
	{
	}

	protected virtual void OnBeforeRender()
	{
	}

	protected virtual void PerformUpdate()
	{
	}

	protected virtual void SetLocalTransform(Vector3 newPosition, Quaternion newRotation)
	{
	}

	private bool HasStereoCamera(out Camera cameraComponent)
	{
		cameraComponent = null;
		return false;
	}

	void ISerializationCallbackReceiver.OnBeforeSerialize()
	{
	}

	void ISerializationCallbackReceiver.OnAfterDeserialize()
	{
	}
}
