using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

public class InputStateHistory : IDisposable, IEnumerable<InputStateHistory.Record>, IEnumerable, IInputStateChangeMonitor
{
	private struct Enumerator : IEnumerator<Record>, IEnumerator, IDisposable
	{
		private readonly InputStateHistory m_History;

		private int m_Index;

		public Record Current => default(Record);

		object IEnumerator.Current => null;

		public Enumerator(InputStateHistory history)
		{
			m_History = null;
			m_Index = 0;
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}

		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)2)]
	protected internal struct RecordHeader
	{
		[FieldOffset(0)]
		public double time;

		[FieldOffset(8)]
		public uint version;

		[FieldOffset(12)]
		public int controlIndex;

		[FieldOffset(12)]
		private unsafe fixed byte m_StateWithoutControlIndex[1];

		[FieldOffset(16)]
		private unsafe fixed byte m_StateWithControlIndex[1];

		public const int kSizeWithControlIndex = 16;

		public const int kSizeWithoutControlIndex = 12;

		public unsafe byte* statePtrWithControlIndex => null;

		public unsafe byte* statePtrWithoutControlIndex => null;
	}

	public struct Record : IEquatable<Record>
	{
		private readonly InputStateHistory m_Owner;

		private readonly int m_IndexPlusOne;

		private uint m_Version;

		internal unsafe RecordHeader* header => null;

		internal int recordIndex => 0;

		internal uint version => 0u;

		public bool valid => false;

		public InputStateHistory owner => null;

		public int index => 0;

		public double time => 0.0;

		public InputControl control => null;

		public Record next => default(Record);

		public Record previous => default(Record);

		internal unsafe Record(InputStateHistory owner, int index, RecordHeader* header)
		{
			m_Owner = null;
			m_IndexPlusOne = 0;
			m_Version = 0u;
		}

		public TValue ReadValue<TValue>() where TValue : struct
		{
			return default(TValue);
		}

		public object ReadValueAsObject()
		{
			return null;
		}

		public unsafe void* GetUnsafeMemoryPtr()
		{
			return null;
		}

		internal unsafe void* GetUnsafeMemoryPtrUnchecked()
		{
			return null;
		}

		public unsafe void* GetUnsafeExtraMemoryPtr()
		{
			return null;
		}

		internal unsafe void* GetUnsafeExtraMemoryPtrUnchecked()
		{
			return null;
		}

		public void CopyFrom(Record record)
		{
		}

		internal void CheckValid()
		{
		}

		public bool Equals(Record other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}

	private const int kDefaultHistorySize = 128;

	internal InputControl[] m_Controls;

	internal int m_ControlCount;

	private NativeArray<byte> m_RecordBuffer;

	private int m_StateSizeInBytes;

	private int m_RecordCount;

	private int m_HistoryDepth;

	private int m_ExtraMemoryPerRecord;

	internal int m_HeadIndex;

	internal uint m_CurrentVersion;

	private InputUpdateType? m_UpdateMask;

	internal readonly bool m_AddNewControls;

	public int Count => 0;

	public uint version => 0u;

	public int historyDepth
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int extraMemoryPerRecord
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public InputUpdateType updateMask
	{
		get
		{
			return default(InputUpdateType);
		}
		set
		{
		}
	}

	public ReadOnlyArray<InputControl> controls => default(ReadOnlyArray<InputControl>);

	public Record this[int index]
	{
		get
		{
			return default(Record);
		}
		set
		{
		}
	}

	public Action<Record> onRecordAdded { get; set; }

	public Func<InputControl, double, InputEventPtr, bool> onShouldRecordStateChange { get; set; }

	internal int bytesPerRecord => 0;

	public InputStateHistory(int maxStateSizeInBytes)
	{
	}

	public InputStateHistory(string path)
	{
	}

	public InputStateHistory(InputControl control)
	{
	}

	public InputStateHistory(IEnumerable<InputControl> controls)
	{
	}

	~InputStateHistory()
	{
	}

	public void Clear()
	{
	}

	public Record AddRecord(Record record)
	{
		return default(Record);
	}

	public void StartRecording()
	{
	}

	public void StopRecording()
	{
	}

	public Record RecordStateChange(InputControl control, InputEventPtr eventPtr)
	{
		return default(Record);
	}

	public unsafe Record RecordStateChange(InputControl control, void* statePtr, double time)
	{
		return default(Record);
	}

	public IEnumerator<Record> GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public void Dispose()
	{
	}

	protected void Destroy()
	{
	}

	private void Allocate()
	{
	}

	protected internal int RecordIndexToUserIndex(int index)
	{
		return 0;
	}

	protected internal int UserIndexToRecordIndex(int index)
	{
		return 0;
	}

	protected internal unsafe RecordHeader* GetRecord(int index)
	{
		return null;
	}

	internal unsafe RecordHeader* GetRecordUnchecked(int index)
	{
		return null;
	}

	protected internal unsafe RecordHeader* AllocateRecord(out int index)
	{
		index = default(int);
		return null;
	}

	protected unsafe TValue ReadValue<TValue>(RecordHeader* data) where TValue : struct
	{
		return default(TValue);
	}

	protected unsafe object ReadValueAsObject(RecordHeader* data)
	{
		return null;
	}

	void IInputStateChangeMonitor.NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long monitorIndex)
	{
	}

	void IInputStateChangeMonitor.NotifyTimerExpired(InputControl control, double time, long monitorIndex, int timerIndex)
	{
	}
}
public class InputStateHistory<TValue> : InputStateHistory, IReadOnlyList<InputStateHistory<TValue>.Record>, IEnumerable<InputStateHistory<TValue>.Record>, IEnumerable, IReadOnlyCollection<InputStateHistory<TValue>.Record> where TValue : struct
{
	private struct Enumerator : IEnumerator<Record>, IEnumerator, IDisposable
	{
		private readonly InputStateHistory<TValue> m_History;

		private int m_Index;

		public Record Current => default(Record);

		object IEnumerator.Current => null;

		public Enumerator(InputStateHistory<TValue> history)
		{
			m_History = null;
			m_Index = 0;
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}

		public void Dispose()
		{
		}
	}

	public new struct Record : IEquatable<Record>
	{
		private readonly InputStateHistory<TValue> m_Owner;

		private readonly int m_IndexPlusOne;

		private uint m_Version;

		internal unsafe RecordHeader* header => null;

		internal int recordIndex => 0;

		public bool valid => false;

		public InputStateHistory<TValue> owner => null;

		public int index => 0;

		public double time => 0.0;

		public InputControl<TValue> control => null;

		public Record next => default(Record);

		public Record previous => default(Record);

		internal unsafe Record(InputStateHistory<TValue> owner, int index, RecordHeader* header)
		{
			m_Owner = null;
			m_IndexPlusOne = 0;
			m_Version = 0u;
		}

		internal Record(InputStateHistory<TValue> owner, int index)
		{
			m_Owner = null;
			m_IndexPlusOne = 0;
			m_Version = 0u;
		}

		public TValue ReadValue()
		{
			return default(TValue);
		}

		public unsafe void* GetUnsafeMemoryPtr()
		{
			return null;
		}

		internal unsafe void* GetUnsafeMemoryPtrUnchecked()
		{
			return null;
		}

		public unsafe void* GetUnsafeExtraMemoryPtr()
		{
			return null;
		}

		internal unsafe void* GetUnsafeExtraMemoryPtrUnchecked()
		{
			return null;
		}

		public void CopyFrom(Record record)
		{
		}

		private void CheckValid()
		{
		}

		public bool Equals(Record other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}

	public new Record this[int index]
	{
		get
		{
			return default(Record);
		}
		set
		{
		}
	}

	public InputStateHistory(int? maxStateSizeInBytes = null)
		: base(0)
	{
	}

	public InputStateHistory(InputControl<TValue> control)
		: base(0)
	{
	}

	public InputStateHistory(string path)
		: base(0)
	{
	}

	~InputStateHistory()
	{
	}

	public Record AddRecord(Record record)
	{
		return default(Record);
	}

	public Record RecordStateChange(InputControl<TValue> control, TValue value, double time = -1.0)
	{
		return default(Record);
	}

	public new IEnumerator<Record> GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
