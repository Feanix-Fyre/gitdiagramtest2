using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.AI;

[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
[StaticAccessor("NavMeshBindings", StaticAccessorType.DoubleColon)]
[MovedFrom("UnityEngine")]
[NativeHeader("Modules/AI/NavMeshManager.h")]
public static class NavMesh
{
	public delegate void OnNavMeshPreUpdate();

	public static OnNavMeshPreUpdate onPreUpdate;

	[RequiredByNativeCode]
	private static void Internal_CallOnNavMeshPreUpdate()
	{
	}

	public static bool CalculatePath(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path)
	{
		return false;
	}

	private static bool CalculatePathInternal(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path)
	{
		return false;
	}

	public static bool SamplePosition(Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask)
	{
		hit = default(NavMeshHit);
		return false;
	}

	public static NavMeshDataInstance AddNavMeshData(NavMeshData navMeshData, Vector3 position, Quaternion rotation)
	{
		return default(NavMeshDataInstance);
	}

	[NativeName("IsValidSurfaceID")]
	[StaticAccessor("GetNavMeshManager()")]
	internal static bool IsValidNavMeshDataHandle(int handle)
	{
		return false;
	}

	[StaticAccessor("GetNavMeshManager()")]
	internal static bool IsValidLinkHandle(int handle)
	{
		return false;
	}

	[StaticAccessor("GetNavMeshManager()")]
	[NativeName("SetSurfaceUserID")]
	internal static bool InternalSetOwner(int dataID, int ownerID)
	{
		return false;
	}

	[StaticAccessor("GetNavMeshManager()")]
	[NativeName("SetLinkUserID")]
	internal static bool InternalSetLinkOwner(int linkID, int ownerID)
	{
		return false;
	}

	[NativeName("LoadData")]
	[StaticAccessor("GetNavMeshManager()")]
	internal static int AddNavMeshDataTransformedInternal(NavMeshData navMeshData, Vector3 position, Quaternion rotation)
	{
		return 0;
	}

	[NativeName("UnloadData")]
	[StaticAccessor("GetNavMeshManager()")]
	internal static void RemoveNavMeshDataInternal(int handle)
	{
	}

	public static NavMeshLinkInstance AddLink(NavMeshLinkData link, Vector3 position, Quaternion rotation)
	{
		return default(NavMeshLinkInstance);
	}

	[StaticAccessor("GetNavMeshManager()")]
	[NativeName("AddLink")]
	internal static int AddLinkInternal(NavMeshLinkData link, Vector3 position, Quaternion rotation)
	{
		return 0;
	}

	[StaticAccessor("GetNavMeshManager()")]
	[NativeName("RemoveLink")]
	internal static void RemoveLinkInternal(int handle)
	{
	}

	public static bool SamplePosition(Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, NavMeshQueryFilter filter)
	{
		hit = default(NavMeshHit);
		return false;
	}

	private static bool SamplePositionFilter(Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int type, int mask)
	{
		hit = default(NavMeshHit);
		return false;
	}

	public static NavMeshBuildSettings GetSettingsByID(int agentTypeID)
	{
		return default(NavMeshBuildSettings);
	}

	[StaticAccessor("GetNavMeshProjectSettings()")]
	public static int GetSettingsCount()
	{
		return 0;
	}

	public static NavMeshBuildSettings GetSettingsByIndex(int index)
	{
		return default(NavMeshBuildSettings);
	}

	public static string GetSettingsNameFromID(int agentTypeID)
	{
		return null;
	}

	private static bool CalculatePathInternal_Injected(ref Vector3 sourcePosition, ref Vector3 targetPosition, int areaMask, NavMeshPath path)
	{
		return false;
	}

	private static bool SamplePosition_Injected(ref Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask)
	{
		hit = default(NavMeshHit);
		return false;
	}

	private static int AddNavMeshDataTransformedInternal_Injected(NavMeshData navMeshData, ref Vector3 position, ref Quaternion rotation)
	{
		return 0;
	}

	private static int AddLinkInternal_Injected(ref NavMeshLinkData link, ref Vector3 position, ref Quaternion rotation)
	{
		return 0;
	}

	private static bool SamplePositionFilter_Injected(ref Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int type, int mask)
	{
		hit = default(NavMeshHit);
		return false;
	}

	private static void GetSettingsByID_Injected(int agentTypeID, out NavMeshBuildSettings ret)
	{
		ret = default(NavMeshBuildSettings);
	}

	private static void GetSettingsByIndex_Injected(int index, out NavMeshBuildSettings ret)
	{
		ret = default(NavMeshBuildSettings);
	}
}
