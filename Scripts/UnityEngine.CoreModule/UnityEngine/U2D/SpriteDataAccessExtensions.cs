using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine.U2D;

[NativeHeader("Runtime/Graphics/SpriteFrame.h")]
[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
public static class SpriteDataAccessExtensions
{
	private static void CheckAttributeTypeMatchesAndThrow<T>(VertexAttribute channel)
	{
	}

	public static NativeSlice<T> GetVertexAttribute<T>(this Sprite sprite, VertexAttribute channel) where T : struct
	{
		return default(NativeSlice<T>);
	}

	public static NativeArray<ushort> GetIndices(this Sprite sprite)
	{
		return default(NativeArray<ushort>);
	}

	[NativeName("HasChannel")]
	public static bool HasVertexAttribute([NotNull("ArgumentNullException")] this Sprite sprite, VertexAttribute channel)
	{
		return false;
	}

	private static SpriteChannelInfo GetIndicesInfo([NotNull("ArgumentNullException")] Sprite sprite)
	{
		return default(SpriteChannelInfo);
	}

	private static SpriteChannelInfo GetChannelInfo([NotNull("ArgumentNullException")] Sprite sprite, VertexAttribute channel)
	{
		return default(SpriteChannelInfo);
	}

	private static void GetIndicesInfo_Injected(Sprite sprite, out SpriteChannelInfo ret)
	{
		ret = default(SpriteChannelInfo);
	}

	private static void GetChannelInfo_Injected(Sprite sprite, VertexAttribute channel, out SpriteChannelInfo ret)
	{
		ret = default(SpriteChannelInfo);
	}
}
