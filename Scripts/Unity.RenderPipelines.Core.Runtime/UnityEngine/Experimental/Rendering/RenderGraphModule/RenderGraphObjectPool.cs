using System;
using System.Collections.Generic;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

public sealed class RenderGraphObjectPool
{
	private abstract class SharedObjectPoolBase
	{
		protected static List<SharedObjectPoolBase> s_AllocatedPools;

		protected abstract void Clear();

		public static void ClearAll()
		{
		}
	}

	private class SharedObjectPool<T> : SharedObjectPoolBase where T : new()
	{
		private Stack<T> m_Pool;

		private static readonly Lazy<SharedObjectPool<T>> s_Instance;

		public static SharedObjectPool<T> sharedPool => null;

		public T Get()
		{
			return default(T);
		}

		public void Release(T value)
		{
		}

		private static SharedObjectPool<T> AllocatePool()
		{
			return null;
		}

		protected override void Clear()
		{
		}
	}

	private Dictionary<(Type, int), Stack<object>> m_ArrayPool;

	private List<(object, (Type, int))> m_AllocatedArrays;

	private List<MaterialPropertyBlock> m_AllocatedMaterialPropertyBlocks;

	internal RenderGraphObjectPool()
	{
	}

	public T[] GetTempArray<T>(int size)
	{
		return null;
	}

	public MaterialPropertyBlock GetTempMaterialPropertyBlock()
	{
		return null;
	}

	internal void ReleaseAllTempAlloc()
	{
	}

	internal T Get<T>() where T : new()
	{
		return default(T);
	}

	internal void Release<T>(T value) where T : new()
	{
	}

	internal void Cleanup()
	{
	}
}
