using System.Collections;
using System.Collections.Generic;

namespace System.Data;

internal abstract class RBTree<K> : IEnumerable
{
	private enum NodeColor
	{
		red = 0,
		black = 1
	}

	private struct Node
	{
		internal int _selfId;

		internal int _leftId;

		internal int _rightId;

		internal int _parentId;

		internal int _nextId;

		internal int _subTreeSize;

		internal K _keyOfNode;

		internal NodeColor _nodeColor;
	}

	private readonly struct NodePath
	{
		internal readonly int _nodeID;

		internal readonly int _mainTreeNodeID;

		internal NodePath(int nodeID, int mainTreeNodeID)
		{
			_nodeID = 0;
			_mainTreeNodeID = 0;
		}
	}

	private sealed class TreePage
	{
		internal readonly Node[] _slots;

		internal readonly int[] _slotMap;

		private int _inUseCount;

		private int _pageId;

		private int _nextFreeSlotLine;

		internal int InUseCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal int PageId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal TreePage(int size)
		{
		}

		internal int AllocSlot(RBTree<K> tree)
		{
			return 0;
		}
	}

	internal struct RBTreeEnumerator : IEnumerator<K>, IDisposable, IEnumerator
	{
		private readonly RBTree<K> _tree;

		private readonly int _version;

		private int _index;

		private int _mainTreeNodeId;

		private K _current;

		public K Current => default(K);

		object IEnumerator.Current => null;

		internal RBTreeEnumerator(RBTree<K> tree)
		{
			_tree = null;
			_version = 0;
			_index = 0;
			_mainTreeNodeId = 0;
			_current = default(K);
		}

		internal RBTreeEnumerator(RBTree<K> tree, int position)
		{
			_tree = null;
			_version = 0;
			_index = 0;
			_mainTreeNodeId = 0;
			_current = default(K);
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		void IEnumerator.Reset()
		{
		}
	}

	private TreePage[] _pageTable;

	private int[] _pageTableMap;

	private int _inUsePageCount;

	private int _nextFreePageLine;

	public int root;

	private int _version;

	private int _inUseNodeCount;

	private int _inUseSatelliteTreeCount;

	private readonly TreeAccessMethod _accessMethod;

	public int Count => 0;

	public bool HasDuplicates => false;

	public K this[int index] => default(K);

	protected abstract int CompareNode(K record1, K record2);

	protected abstract int CompareSateliteTreeNode(K record1, K record2);

	protected RBTree(TreeAccessMethod accessMethod)
	{
	}

	private void InitTree()
	{
	}

	private void FreePage(TreePage page)
	{
	}

	private TreePage AllocPage(int size)
	{
		return null;
	}

	private void MarkPageFull(TreePage page)
	{
	}

	private void MarkPageFree(TreePage page)
	{
	}

	private static int GetIntValueFromBitMap(uint bitMap)
	{
		return 0;
	}

	private void FreeNode(int nodeId)
	{
	}

	private int GetIndexOfPageWithFreeSlot(bool allocatedPage)
	{
		return 0;
	}

	private int GetNewNode(K key)
	{
		return 0;
	}

	private int Successor(int x_id)
	{
		return 0;
	}

	private bool Successor(ref int nodeId, ref int mainTreeNodeId)
	{
		return false;
	}

	private int Minimum(int x_id)
	{
		return 0;
	}

	private int LeftRotate(int root_id, int x_id, int mainTreeNode)
	{
		return 0;
	}

	private int RightRotate(int root_id, int x_id, int mainTreeNode)
	{
		return 0;
	}

	private int RBInsert(int root_id, int x_id, int mainTreeNodeID, int position, bool append)
	{
		return 0;
	}

	public void UpdateNodeKey(K currentKey, K newKey)
	{
	}

	public K DeleteByIndex(int i)
	{
		return default(K);
	}

	public int RBDelete(int z_id)
	{
		return 0;
	}

	private int RBDeleteX(int root_id, int z_id, int mainTreeNodeID)
	{
		return 0;
	}

	private int RBDeleteFixup(int root_id, int x_id, int px_id, int mainTreeNodeID)
	{
		return 0;
	}

	private int SearchSubTree(int root_id, K key)
	{
		return 0;
	}

	private NodePath GetNodeByKey(K key)
	{
		return default(NodePath);
	}

	public int GetIndexByKey(K key)
	{
		return 0;
	}

	public int GetIndexByNode(int node)
	{
		return 0;
	}

	private int GetIndexByNodePath(NodePath path)
	{
		return 0;
	}

	private int ComputeIndexByNode(int nodeId)
	{
		return 0;
	}

	private int ComputeIndexWithSatelliteByNode(int nodeId)
	{
		return 0;
	}

	private NodePath GetNodeByIndex(int userIndex)
	{
		return default(NodePath);
	}

	private int ComputeNodeByIndex(int index, out int satelliteRootId)
	{
		satelliteRootId = default(int);
		return 0;
	}

	private int ComputeNodeByIndex(int x_id, int index)
	{
		return 0;
	}

	public int Insert(K item)
	{
		return 0;
	}

	public int Add(K item)
	{
		return 0;
	}

	public IEnumerator GetEnumerator()
	{
		return null;
	}

	public int IndexOf(int nodeId, K item)
	{
		return 0;
	}

	public int Insert(int position, K item)
	{
		return 0;
	}

	public int InsertAt(int position, K item, bool append)
	{
		return 0;
	}

	public void RemoveAt(int position)
	{
	}

	public void Clear()
	{
	}

	public void CopyTo(Array array, int index)
	{
	}

	public void CopyTo(K[] array, int index)
	{
	}

	private void SetRight(int nodeId, int rightNodeId)
	{
	}

	private void SetLeft(int nodeId, int leftNodeId)
	{
	}

	private void SetParent(int nodeId, int parentNodeId)
	{
	}

	private void SetColor(int nodeId, NodeColor color)
	{
	}

	private void SetKey(int nodeId, K key)
	{
	}

	private void SetNext(int nodeId, int nextNodeId)
	{
	}

	private void SetSubTreeSize(int nodeId, int size)
	{
	}

	private void IncreaseSize(int nodeId)
	{
	}

	private void RecomputeSize(int nodeId)
	{
	}

	private void DecreaseSize(int nodeId)
	{
	}

	public int Right(int nodeId)
	{
		return 0;
	}

	public int Left(int nodeId)
	{
		return 0;
	}

	public int Parent(int nodeId)
	{
		return 0;
	}

	private NodeColor color(int nodeId)
	{
		return default(NodeColor);
	}

	public int Next(int nodeId)
	{
		return 0;
	}

	public int SubTreeSize(int nodeId)
	{
		return 0;
	}

	public K Key(int nodeId)
	{
		return default(K);
	}
}
