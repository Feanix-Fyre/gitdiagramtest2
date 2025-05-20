using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine.Rendering;

namespace UnityEngine.UI;

public static class StencilMaterial
{
	private class MatEntry
	{
		public Material baseMat;

		public Material customMat;

		public int count;

		public int stencilId;

		public StencilOp operation;

		public CompareFunction compareFunction;

		public int readMask;

		public int writeMask;

		public bool useAlphaClip;

		public ColorWriteMask colorMask;
	}

	private static List<MatEntry> m_List;

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Use Material.Add instead.", true)]
	public static Material Add(Material baseMat, int stencilID)
	{
		return null;
	}

	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask)
	{
		return null;
	}

	private static void LogWarningWhenNotInBatchmode(string warning, Object context)
	{
	}

	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask)
	{
		return null;
	}

	public static void Remove(Material customMat)
	{
	}

	public static void ClearAll()
	{
	}
}
