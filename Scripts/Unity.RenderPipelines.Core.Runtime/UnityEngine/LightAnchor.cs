namespace UnityEngine;

[AddComponentMenu("Rendering/Light Anchor")]
[ExecuteInEditMode]
[DisallowMultipleComponent]
public class LightAnchor : MonoBehaviour
{
	public enum UpDirection
	{
		World = 0,
		Local = 1
	}

	private struct Axes
	{
		public Vector3 up;

		public Vector3 right;

		public Vector3 forward;
	}

	private const float k_ArcRadius = 5f;

	private const float k_AxisLength = 10f;

	internal const float k_MaxDistance = 10000f;

	[Min(0f)]
	[SerializeField]
	private float m_Distance;

	[SerializeField]
	private UpDirection m_FrameSpace;

	[SerializeField]
	private Transform m_AnchorPositionOverride;

	[SerializeField]
	private Vector3 m_AnchorPositionOffset;

	[SerializeField]
	private float m_Yaw;

	[SerializeField]
	private float m_Pitch;

	[SerializeField]
	private float m_Roll;

	public float yaw
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float pitch
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float roll
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float distance
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public UpDirection frameSpace
	{
		get
		{
			return default(UpDirection);
		}
		set
		{
		}
	}

	public Vector3 anchorPosition => default(Vector3);

	public Transform anchorPositionOverride
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Vector3 anchorPositionOffset
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public static float NormalizeAngleDegree(float angle)
	{
		return 0f;
	}

	public void SynchronizeOnTransform(Camera camera)
	{
	}

	public void UpdateTransform(Camera camera, Vector3 anchor)
	{
	}

	private Axes GetWorldSpaceAxes(Camera camera, Vector3 anchor)
	{
		return default(Axes);
	}

	private void Update()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	private void UpdateTransform(Vector3 up, Vector3 right, Vector3 forward, Vector3 anchor)
	{
	}
}
