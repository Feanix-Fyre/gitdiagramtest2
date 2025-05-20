using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[Serializable]
public sealed class InputEventTrace : IDisposable, IEnumerable<InputEventPtr>, IEnumerable
{
	private class Enumerator : IEnumerator<InputEventPtr>, IEnumerator, IDisposable
	{
		private InputEventTrace m_Trace;

		private int m_ChangeCounter;

		internal InputEventPtr m_Current;

		public InputEventPtr Current => default(InputEventPtr);

		object IEnumerator.Current => null;

		public Enumerator(InputEventTrace trace)
		{
		}

		public void Dispose()
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

	[Flags]
	private enum FileFlags
	{
		FixedUpdate = 1
	}

	public class ReplayController : IDisposable
	{
		private InputEventTrace m_EventTrace;

		private Enumerator m_Enumerator;

		private InlinedArray<KeyValuePair<int, int>> m_DeviceIDMappings;

		private bool m_CreateNewDevices;

		private InlinedArray<InputDevice> m_CreatedDevices;

		private Action m_OnFinished;

		private Action<InputEventPtr> m_OnEvent;

		private double m_StartTimeAsPerFirstEvent;

		private double m_StartTimeAsPerRuntime;

		private int m_AllEventsByTimeIndex;

		private List<InputEventPtr> m_AllEventsByTime;

		public InputEventTrace trace => null;

		public bool finished { get; private set; }

		public bool paused { get; set; }

		public int position { get; private set; }

		public IEnumerable<InputDevice> createdDevices => null;

		internal ReplayController(InputEventTrace trace)
		{
		}

		public void Dispose()
		{
		}

		public ReplayController WithDeviceMappedFromTo(InputDevice recordedDevice, InputDevice playbackDevice)
		{
			return null;
		}

		public ReplayController WithDeviceMappedFromTo(int recordedDeviceId, int playbackDeviceId)
		{
			return null;
		}

		public ReplayController WithAllDevicesMappedToNewInstances()
		{
			return null;
		}

		public ReplayController OnFinished(Action action)
		{
			return null;
		}

		public ReplayController OnEvent(Action<InputEventPtr> action)
		{
			return null;
		}

		public ReplayController PlayOneEvent()
		{
			return null;
		}

		public ReplayController Rewind()
		{
			return null;
		}

		public ReplayController PlayAllFramesOneByOne()
		{
			return null;
		}

		public ReplayController PlayAllEvents()
		{
			return null;
		}

		public ReplayController PlayAllEventsAccordingToTimestamps()
		{
			return null;
		}

		private void OnBeginFrame()
		{
		}

		private void Finished()
		{
		}

		private void QueueEvent(InputEventPtr eventPtr)
		{
		}

		private bool MoveNext(bool skipFrameEvents, out InputEventPtr eventPtr)
		{
			eventPtr = default(InputEventPtr);
			return false;
		}

		private int ApplyDeviceMapping(int originalDeviceId)
		{
			return 0;
		}
	}

	[Serializable]
	public struct DeviceInfo
	{
		[SerializeField]
		internal int m_DeviceId;

		[SerializeField]
		internal string m_Layout;

		[SerializeField]
		internal FourCC m_StateFormat;

		[SerializeField]
		internal int m_StateSizeInBytes;

		[SerializeField]
		internal string m_FullLayoutJson;

		public int deviceId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string layout
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FourCC stateFormat
		{
			get
			{
				return default(FourCC);
			}
			set
			{
			}
		}

		public int stateSizeInBytes
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}
	}

	private const int kDefaultBufferSize = 1048576;

	[NonSerialized]
	private int m_ChangeCounter;

	[NonSerialized]
	private bool m_Enabled;

	[NonSerialized]
	private Func<InputEventPtr, InputDevice, bool> m_OnFilterEvent;

	[SerializeField]
	private int m_DeviceId;

	[NonSerialized]
	private CallbackArray<Action<InputEventPtr>> m_EventListeners;

	[SerializeField]
	private long m_EventBufferSize;

	[SerializeField]
	private long m_MaxEventBufferSize;

	[SerializeField]
	private long m_GrowIncrementSize;

	[SerializeField]
	private long m_EventCount;

	[SerializeField]
	private long m_EventSizeInBytes;

	[SerializeField]
	private ulong m_EventBufferStorage;

	[SerializeField]
	private ulong m_EventBufferHeadStorage;

	[SerializeField]
	private ulong m_EventBufferTailStorage;

	[SerializeField]
	private bool m_HasWrapped;

	[SerializeField]
	private bool m_RecordFrameMarkers;

	[SerializeField]
	private DeviceInfo[] m_DeviceInfos;

	private static int kFileVersion;

	public static FourCC FrameMarkerEvent => default(FourCC);

	public int deviceId
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool enabled => false;

	public bool recordFrameMarkers
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public long eventCount => 0L;

	public long totalEventSizeInBytes => 0L;

	public long allocatedSizeInBytes => 0L;

	public long maxSizeInBytes => 0L;

	public ReadOnlyArray<DeviceInfo> deviceInfos => default(ReadOnlyArray<DeviceInfo>);

	public Func<InputEventPtr, InputDevice, bool> onFilterEvent
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private unsafe byte* m_EventBuffer
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private unsafe byte* m_EventBufferHead
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private unsafe byte* m_EventBufferTail
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private static FourCC kFileFormat => default(FourCC);

	public event Action<InputEventPtr> onEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	public InputEventTrace(InputDevice device, long bufferSizeInBytes = 1048576L, bool growBuffer = false, long maxBufferSizeInBytes = -1L, long growIncrementSizeInBytes = -1L)
	{
	}

	public InputEventTrace(long bufferSizeInBytes = 1048576L, bool growBuffer = false, long maxBufferSizeInBytes = -1L, long growIncrementSizeInBytes = -1L)
	{
	}

	public void WriteTo(string filePath)
	{
	}

	public void WriteTo(Stream stream)
	{
	}

	public void ReadFrom(string filePath)
	{
	}

	public void ReadFrom(Stream stream)
	{
	}

	public static InputEventTrace LoadFrom(string filePath)
	{
		return null;
	}

	public static InputEventTrace LoadFrom(Stream stream)
	{
		return null;
	}

	public ReplayController Replay()
	{
		return null;
	}

	public bool Resize(long newBufferSize, long newMaxBufferSize = -1L)
	{
		return false;
	}

	public void Clear()
	{
	}

	public void Enable()
	{
	}

	public void Disable()
	{
	}

	public bool GetNextEvent(ref InputEventPtr current)
	{
		return false;
	}

	public IEnumerator<InputEventPtr> GetEnumerator()
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

	private void Allocate()
	{
	}

	private void Release()
	{
	}

	private void OnBeforeUpdate()
	{
	}

	private void OnInputEvent(InputEventPtr inputEvent, InputDevice device)
	{
	}
}
