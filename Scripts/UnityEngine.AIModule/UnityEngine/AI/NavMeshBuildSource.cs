using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.AI;

[NativeHeader("Modules/AI/Public/NavMeshBindingTypes.h")]
[UsedByNativeCode]
public struct NavMeshBuildSource
{
	private Matrix4x4 m_Transform;

	private Vector3 m_Size;

	private NavMeshBuildSourceShape m_Shape;

	private int m_Area;

	private int m_InstanceID;

	private int m_ComponentID;

	private int m_GenerateLinks;

	public Matrix4x4 transform
	{
		get
		{
			return default(Matrix4x4);
		}
		set
		{
		}
	}

	public Vector3 size
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public NavMeshBuildSourceShape shape
	{
		get
		{
			return default(NavMeshBuildSourceShape);
		}
		set
		{
		}
	}

	public int area
	{
		set
		{
		}
	}

	public Object sourceObject => null;

	public Component component => null;

	[StaticAccessor("NavMeshBuildSource", StaticAccessorType.DoubleColon)]
	private static Component InternalGetComponent(int instanceID)
	{
		return null;
	}

	[StaticAccessor("NavMeshBuildSource", StaticAccessorType.DoubleColon)]
	private static Object InternalGetObject(int instanceID)
	{
		return null;
	}
}
