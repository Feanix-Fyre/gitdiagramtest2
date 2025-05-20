using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering.PostProcessing;

internal static class MeshUtilities
{
	private static Dictionary<PrimitiveType, Mesh> s_Primitives;

	private static Dictionary<Type, PrimitiveType> s_ColliderPrimitives;

	static MeshUtilities()
	{
	}

	internal static Mesh GetColliderMesh(Collider collider)
	{
		return null;
	}

	internal static Mesh GetPrimitive(PrimitiveType primitiveType)
	{
		return null;
	}

	private static Mesh GetBuiltinMesh(PrimitiveType primitiveType)
	{
		return null;
	}
}
