using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace UnityEngine.UIElements;

public sealed class EventDispatcher
{
	private struct EventRecord
	{
		public EventBase m_Event;

		public IPanel m_Panel;
	}

	private struct DispatchContext
	{
		public uint m_GateCount;

		public Queue<EventRecord> m_Queue;
	}

	internal ClickDetector m_ClickDetector;

	private List<IEventDispatchingStrategy> m_DispatchingStrategies;

	private static readonly ObjectPool<Queue<EventRecord>> k_EventQueuePool;

	private Queue<EventRecord> m_Queue;

	private uint m_GateCount;

	private Stack<DispatchContext> m_DispatchContexts;

	private static readonly IEventDispatchingStrategy[] s_EditorStrategies;

	private bool m_Immediate;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CprocessingEvents_003Ek__BackingField;

	internal PointerDispatchState pointerState { get; }

	private bool dispatchImmediately => false;

	private bool processingEvents
	{
		[CompilerGenerated]
		set
		{
			_003CprocessingEvents_003Ek__BackingField = value;
		}
	}

	internal static EventDispatcher CreateForRuntime(IList<IEventDispatchingStrategy> strategies)
	{
		return null;
	}

	private EventDispatcher(IList<IEventDispatchingStrategy> strategies)
	{
	}

	internal void Dispatch(EventBase evt, [NotNull] IPanel panel, DispatchMode dispatchMode)
	{
	}

	internal void CloseGate()
	{
	}

	internal void OpenGate()
	{
	}

	private void ProcessEventQueue()
	{
	}

	private void ProcessEvent(EventBase evt, [NotNull] IPanel panel)
	{
	}

	private void ApplyDispatchingStrategies(EventBase evt, IPanel panel, bool imguiEventIsInitiallyUsed)
	{
	}
}
