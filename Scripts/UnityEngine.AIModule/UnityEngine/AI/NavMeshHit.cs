using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.AI;

[MovedFrom("UnityEngine")]
public struct NavMeshHit
{
	private Vector3 m_Position;

	private Vector3 m_Normal;

	private float m_Distance;

	private int m_Mask;

	private int m_Hit;

	public Vector3 position
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}
}
