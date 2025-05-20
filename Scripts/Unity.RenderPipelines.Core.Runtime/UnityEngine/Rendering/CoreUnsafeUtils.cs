using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Collections;

namespace UnityEngine.Rendering;

public static class CoreUnsafeUtils
{
	public struct FixedBufferStringQueue
	{
		private unsafe byte* m_ReadCursor;

		private unsafe byte* m_WriteCursor;

		private unsafe readonly byte* m_BufferEnd;

		private unsafe readonly byte* m_BufferStart;

		private readonly int m_BufferLength;

		public int Count { get; private set; }

		public unsafe FixedBufferStringQueue(byte* ptr, int length)
		{
			m_ReadCursor = null;
			m_WriteCursor = null;
			m_BufferEnd = null;
			m_BufferStart = null;
			m_BufferLength = 0;
			Count = 0;
		}

		public bool TryPush(string v)
		{
			return false;
		}

		public bool TryPop(out string v)
		{
			v = null;
			return false;
		}

		public void Clear()
		{
		}
	}

	public interface IKeyGetter<TValue, TKey>
	{
		TKey Get(ref TValue v);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct DefaultKeyGetter<T> : IKeyGetter<T, T>
	{
		public T Get(ref T v)
		{
			return default(T);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct UintKeyGetter : IKeyGetter<uint, uint>
	{
		public uint Get(ref uint v)
		{
			return 0u;
		}
	}

	public unsafe static void CopyTo<T>(this List<T> list, void* dest, int count) where T : struct
	{
	}

	public unsafe static void CopyTo<T>(this T[] list, void* dest, int count) where T : struct
	{
	}

	private static void CalculateRadixParams(int radixBits, out int bitStates)
	{
		bitStates = default(int);
	}

	private static int CalculateRadixSupportSize(int bitStates, int arrayLength)
	{
		return 0;
	}

	private unsafe static void CalculateRadixSortSupportArrays(int bitStates, int arrayLength, uint* supportArray, out uint* bucketIndices, out uint* bucketSizes, out uint* bucketPrefix, out uint* arrayOutput)
	{
		System.Runtime.CompilerServices.Unsafe.As<uint*, @null>(ref bucketIndices) = null;
		System.Runtime.CompilerServices.Unsafe.As<uint*, @null>(ref bucketSizes) = null;
		System.Runtime.CompilerServices.Unsafe.As<uint*, @null>(ref bucketPrefix) = null;
		System.Runtime.CompilerServices.Unsafe.As<uint*, @null>(ref arrayOutput) = null;
	}

	private unsafe static void MergeSort(uint* array, uint* support, int length)
	{
	}

	public static void MergeSort(uint[] arr, int sortSize, ref uint[] supportArray)
	{
	}

	public static void MergeSort(NativeArray<uint> arr, int sortSize, ref NativeArray<uint> supportArray)
	{
	}

	private unsafe static void InsertionSort(uint* arr, int length)
	{
	}

	public static void InsertionSort(uint[] arr, int sortSize)
	{
	}

	public static void InsertionSort(NativeArray<uint> arr, int sortSize)
	{
	}

	private unsafe static void RadixSort(uint* array, uint* support, int radixBits, int bitStates, int length)
	{
	}

	public static void RadixSort(uint[] arr, int sortSize, ref uint[] supportArray, int radixBits = 8)
	{
	}

	public static void RadixSort(NativeArray<uint> array, int sortSize, ref NativeArray<uint> supportArray, int radixBits = 8)
	{
	}

	public static void QuickSort(uint[] arr, int left, int right)
	{
	}

	public unsafe static void QuickSort<T>(int count, void* data) where T : struct, IComparable<T>
	{
	}

	public unsafe static void QuickSort<TValue, TKey, TGetter>(int count, void* data) where TValue : struct where TKey : struct, IComparable<TKey> where TGetter : struct, IKeyGetter<TValue, TKey>
	{
	}

	public unsafe static void QuickSort<TValue, TKey, TGetter>(void* data, int left, int right) where TValue : struct where TKey : struct, IComparable<TKey> where TGetter : struct, IKeyGetter<TValue, TKey>
	{
	}

	public unsafe static int IndexOf<T>(void* data, int count, T v) where T : struct, IEquatable<T>
	{
		return 0;
	}

	public unsafe static int CompareHashes<TOldValue, TOldGetter, TNewValue, TNewGetter>(int oldHashCount, void* oldHashes, int newHashCount, void* newHashes, int* addIndices, int* removeIndices, out int addCount, out int remCount) where TOldValue : struct where TOldGetter : struct, IKeyGetter<TOldValue, Hash128> where TNewValue : struct where TNewGetter : struct, IKeyGetter<TNewValue, Hash128>
	{
		addCount = default(int);
		remCount = default(int);
		return 0;
	}

	public unsafe static int CompareHashes(int oldHashCount, Hash128* oldHashes, int newHashCount, Hash128* newHashes, int* addIndices, int* removeIndices, out int addCount, out int remCount)
	{
		addCount = default(int);
		remCount = default(int);
		return 0;
	}

	public unsafe static void CombineHashes<TValue, TGetter>(int count, void* hashes, Hash128* outHash) where TValue : struct where TGetter : struct, IKeyGetter<TValue, Hash128>
	{
	}

	public unsafe static void CombineHashes(int count, Hash128* hashes, Hash128* outHash)
	{
	}

	private unsafe static int Partition<TValue, TKey, TGetter>(void* data, int left, int right) where TValue : struct where TKey : struct, IComparable<TKey> where TGetter : struct, IKeyGetter<TValue, TKey>
	{
		return 0;
	}

	public static bool HaveDuplicates(int[] arr)
	{
		return false;
	}
}
