using UnityEngine.InputSystem;

namespace UnityEngine.Rendering;

public class FreeCamera : MonoBehaviour
{
	private const float k_MouseSensitivityMultiplier = 0.01f;

	public float m_LookSpeedController;

	public float m_LookSpeedMouse;

	public float m_MoveSpeed;

	public float m_MoveSpeedIncrement;

	public float m_Turbo;

	private InputAction lookAction;

	private InputAction moveAction;

	private InputAction speedAction;

	private InputAction yMoveAction;

	private float inputRotateAxisX;

	private float inputRotateAxisY;

	private float inputChangeSpeed;

	private float inputVertical;

	private float inputHorizontal;

	private float inputYAxis;

	private bool leftShiftBoost;

	private bool leftShift;

	private bool fire1;

	private void OnEnable()
	{
	}

	private void RegisterInputs()
	{
	}

	private void UpdateInputs()
	{
	}

	private void Update()
	{
	}
}
