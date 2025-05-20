namespace UnityEngine.InputSystem.LowLevel;

internal struct InputEventStream
{
	private InputEventBuffer m_NativeBuffer;

	private unsafe InputEvent* m_CurrentNativeEventReadPtr;

	private unsafe InputEvent* m_CurrentNativeEventWritePtr;

	private int m_RemainingNativeEventCount;

	private readonly int m_MaxAppendedEvents;

	private InputEventBuffer m_AppendBuffer;

	private unsafe InputEvent* m_CurrentAppendEventReadPtr;

	private unsafe InputEvent* m_CurrentAppendEventWritePtr;

	private int m_RemainingAppendEventCount;

	private int m_NumEventsRetainedInBuffer;

	private bool m_IsOpen;

	public bool isOpen => false;

	public int remainingEventCount => 0;

	public int numEventsRetainedInBuffer => 0;

	public unsafe InputEvent* currentEventPtr => null;

	public uint numBytesRetainedInBuffer => 0u;

	public unsafe InputEventStream(ref InputEventBuffer eventBuffer, int maxAppendedEvents)
	{
		m_NativeBuffer = default(InputEventBuffer);
		m_CurrentNativeEventReadPtr = null;
		m_CurrentNativeEventWritePtr = null;
		m_RemainingNativeEventCount = 0;
		m_MaxAppendedEvents = 0;
		m_AppendBuffer = default(InputEventBuffer);
		m_CurrentAppendEventReadPtr = null;
		m_CurrentAppendEventWritePtr = null;
		m_RemainingAppendEventCount = 0;
		m_NumEventsRetainedInBuffer = 0;
		m_IsOpen = false;
	}

	public void Close(ref InputEventBuffer eventBuffer)
	{
	}

	public void CleanUpAfterException()
	{
	}

	public unsafe void Write(InputEvent* eventPtr)
	{
	}

	public unsafe InputEvent* Advance(bool leaveEventInBuffer)
	{
		return null;
	}

	public unsafe InputEvent* Peek()
	{
		return null;
	}
}
