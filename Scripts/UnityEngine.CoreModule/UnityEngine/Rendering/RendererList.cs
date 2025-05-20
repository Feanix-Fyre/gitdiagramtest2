using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Graphics/ScriptableRenderLoop/RendererList.h")]
[MovedFrom("UnityEngine.Rendering.RendererUtils")]
public struct RendererList
{
	internal UIntPtr context;

	internal uint index;

	internal uint frame;

	internal uint type;

	public static readonly RendererList nullRendererList;

	public bool isValid => false;

	internal RendererList(UIntPtr ctx, uint indx)
	{
		context = (UIntPtr)0u;
		index = 0u;
		frame = 0u;
		type = 0u;
	}

	[SpecialName]
	private static bool get_isValid_Injected(ref RendererList _unity_self)
	{
		return false;
	}
}
