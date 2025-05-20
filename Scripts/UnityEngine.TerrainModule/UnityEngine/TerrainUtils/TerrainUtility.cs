using System.Collections.Generic;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.TerrainUtils;

[MovedFrom("UnityEngine.Experimental.TerrainAPI")]
public static class TerrainUtility
{
	internal static bool ValidTerrainsExist()
	{
		return false;
	}

	internal static void ClearConnectivity()
	{
	}

	internal static Dictionary<int, TerrainMap> CollectTerrains(bool onlyAutoConnectedTerrains = true)
	{
		return null;
	}

	[RequiredByNativeCode]
	public static void AutoConnect()
	{
	}
}
