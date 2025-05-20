using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;

namespace System.Resources;

/// <summary>Enumerates the resources in a binary resources (.resources) file by reading sequential resource name/value pairs.</summary>
[ComVisible(true)]
public sealed class ResourceReader : IResourceReader, IEnumerable, IDisposable
{
	internal sealed class ResourceEnumerator : IDictionaryEnumerator, IEnumerator
	{
		private ResourceReader _reader;

		private bool _currentIsValid;

		private int _currentName;

		private int _dataPosition;

		public object Key => null;

		public object Current => null;

		internal int DataPosition => 0;

		public DictionaryEntry Entry => default(DictionaryEntry);

		public object Value => null;

		internal ResourceEnumerator(ResourceReader reader)
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}
	}

	private BinaryReader _store;

	internal Dictionary<string, ResourceLocator> _resCache;

	private long _nameSectionOffset;

	private long _dataSectionOffset;

	private int[] _nameHashes;

	private unsafe int* _nameHashesPtr;

	private int[] _namePositions;

	private unsafe int* _namePositionsPtr;

	private RuntimeType[] _typeTable;

	private int[] _typeNamePositions;

	private BinaryFormatter _objFormatter;

	private int _numResources;

	private UnmanagedMemoryStream _ums;

	private int _version;

	internal ResourceReader(Stream stream, Dictionary<string, ResourceLocator> resCache)
	{
	}

	/// <summary>Releases all operating system resources associated with this <see cref="T:System.Resources.ResourceReader" /> object.</summary>
	public void Close()
	{
	}

	/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Resources.ResourceReader" /> class.</summary>
	public void Dispose()
	{
	}

	private void Dispose(bool disposing)
	{
	}

	internal unsafe static int ReadUnalignedI4(int* p)
	{
		return 0;
	}

	private void SkipString()
	{
	}

	private int GetNameHash(int index)
	{
		return 0;
	}

	private int GetNamePosition(int index)
	{
		return 0;
	}

	/// <summary>Returns an enumerator for this <see cref="T:System.Resources.ResourceReader" /> object.</summary>
	/// <returns>An enumerator for this <see cref="T:System.Resources.ResourceReader" /> object.</returns>
	/// <exception cref="T:System.InvalidOperationException">The reader has already been closed and cannot be accessed.</exception>
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	/// <summary>Returns an enumerator for this <see cref="T:System.Resources.ResourceReader" /> object.</summary>
	/// <returns>An enumerator for this <see cref="T:System.Resources.ResourceReader" /> object.</returns>
	/// <exception cref="T:System.InvalidOperationException">The reader has been closed or disposed, and cannot be accessed.</exception>
	public IDictionaryEnumerator GetEnumerator()
	{
		return null;
	}

	internal ResourceEnumerator GetEnumeratorInternal()
	{
		return null;
	}

	internal int FindPosForResource(string name)
	{
		return 0;
	}

	private bool CompareStringEqualsName(string name)
	{
		return false;
	}

	private string AllocateStringForNameIndex(int index, out int dataOffset)
	{
		dataOffset = default(int);
		return null;
	}

	private object GetValueForNameIndex(int index)
	{
		return null;
	}

	internal string LoadString(int pos)
	{
		return null;
	}

	internal object LoadObject(int pos)
	{
		return null;
	}

	internal object LoadObject(int pos, out ResourceTypeCode typeCode)
	{
		typeCode = default(ResourceTypeCode);
		return null;
	}

	internal object LoadObjectV1(int pos)
	{
		return null;
	}

	private object _LoadObjectV1(int pos)
	{
		return null;
	}

	internal object LoadObjectV2(int pos, out ResourceTypeCode typeCode)
	{
		typeCode = default(ResourceTypeCode);
		return null;
	}

	private object _LoadObjectV2(int pos, out ResourceTypeCode typeCode)
	{
		typeCode = default(ResourceTypeCode);
		return null;
	}

	private object DeserializeObject(int typeIndex)
	{
		return null;
	}

	private void ReadResources()
	{
	}

	private void _ReadResources()
	{
	}

	private RuntimeType FindType(int typeIndex)
	{
		return null;
	}
}
