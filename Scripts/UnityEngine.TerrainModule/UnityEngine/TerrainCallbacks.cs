using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine;

[MovedFrom("UnityEngine.Experimental.TerrainAPI")]
public static class TerrainCallbacks
{
	public delegate void HeightmapChangedCallback(Terrain terrain, RectInt heightRegion, bool synched);

	public delegate void TextureChangedCallback(Terrain terrain, string textureName, RectInt texelRegion, bool synched);

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static HeightmapChangedCallback heightmapChanged;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static TextureChangedCallback textureChanged;

	[RequiredByNativeCode]
	internal static void InvokeHeightmapChangedCallback(TerrainData terrainData, RectInt heightRegion, bool synched)
	{
	}

	[RequiredByNativeCode]
	internal static void InvokeTextureChangedCallback(TerrainData terrainData, string textureName, RectInt texelRegion, bool synched)
	{
	}
}
