using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace UnityEngine.Rendering;

internal class AtlasAllocatorDynamic
{
	private class AtlasNodePool
	{
		internal AtlasNode[] m_Nodes;

		private short m_Next;

		private short m_FreelistHead;

		public AtlasNodePool(short capacity)
		{
		}

		public void Dispose()
		{
		}

		public void Clear()
		{
		}

		public short AtlasNodeCreate(short parent)
		{
			return 0;
		}

		public void AtlasNodeFree(short index)
		{
		}
	}

	[StructLayout((LayoutKind)2, Size = 32)]
	private struct AtlasNode
	{
		private enum AtlasNodeFlags : uint
		{
			IsOccupied = 1u
		}

		[FieldOffset(0)]
		public short m_Self;

		[FieldOffset(2)]
		public short m_Parent;

		[FieldOffset(4)]
		public short m_LeftChild;

		[FieldOffset(6)]
		public short m_RightChild;

		[FieldOffset(8)]
		public short m_FreelistNext;

		[FieldOffset(10)]
		public ushort m_Flags;

		[FieldOffset(16)]
		public Vector4 m_Rect;

		public AtlasNode(short self, short parent)
		{
			m_Self = 0;
			m_Parent = 0;
			m_LeftChild = 0;
			m_RightChild = 0;
			m_FreelistNext = 0;
			m_Flags = 0;
			m_Rect = default(Vector4);
		}

		public bool IsOccupied()
		{
			return false;
		}

		public void SetIsOccupied()
		{
		}

		public void ClearIsOccupied()
		{
		}

		public bool IsLeafNode()
		{
			return false;
		}

		public short Allocate(AtlasNodePool pool, int width, int height)
		{
			return 0;
		}

		public void ReleaseChildren(AtlasNodePool pool)
		{
		}

		public void ReleaseAndMerge(AtlasNodePool pool)
		{
		}

		public bool IsMergeNeeded(AtlasNodePool pool)
		{
			return false;
		}
	}

	private int m_Width;

	private int m_Height;

	private AtlasNodePool m_Pool;

	private short m_Root;

	private Dictionary<int, short> m_NodeFromID;

	public AtlasAllocatorDynamic(int width, int height, int capacityAllocations)
	{
	}

	public bool Allocate(out Vector4 result, int key, int width, int height)
	{
		result = default(Vector4);
		return false;
	}

	public void Release(int key)
	{
	}

	public void Release()
	{
	}

	public string DebugStringFromRoot(int depthMax = -1)
	{
		return null;
	}

	private void DebugStringFromNode(ref string res, short n, int depthCurrent = 0, int depthMax = -1)
	{
	}
}
