using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("PhysicsScriptingClasses.h")]
[NativeHeader("Modules/Physics/RaycastHit.h")]
[NativeHeader("Runtime/Interfaces/IRaycast.h")]
[UsedByNativeCode]
public struct RaycastHit
{
	[NativeName("point")]
	internal Vector3 m_Point;

	[NativeName("normal")]
	internal Vector3 m_Normal;

	[NativeName("faceID")]
	internal uint m_FaceID;

	[NativeName("distance")]
	internal float m_Distance;

	[NativeName("uv")]
	internal Vector2 m_UV;

	[NativeName("collider")]
	internal int m_Collider;

	public Collider collider => null;

	public Vector3 point
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 normal
	{
		get
		{
			return default(Vector3);
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

	public Transform transform => null;

	public Rigidbody rigidbody => null;
}
