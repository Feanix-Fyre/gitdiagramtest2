using System;
using System.Collections.Generic;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.EnhancedTouch;

public struct Touch : IEquatable<Touch>
{
	internal struct GlobalState
	{
		internal InlinedArray<Touchscreen> touchscreens;

		internal int historyLengthPerFinger;

		internal CallbackArray<Action<Finger>> onFingerDown;

		internal CallbackArray<Action<Finger>> onFingerMove;

		internal CallbackArray<Action<Finger>> onFingerUp;

		internal FingerAndTouchState playerState;
	}

	internal struct FingerAndTouchState
	{
		public InputUpdateType updateMask;

		public Finger[] fingers;

		public Finger[] activeFingers;

		public Touch[] activeTouches;

		public int activeFingerCount;

		public int activeTouchCount;

		public int totalFingerCount;

		public uint lastId;

		public bool haveBuiltActiveTouches;

		public bool haveActiveTouchesNeedingRefreshNextUpdate;

		public InputStateHistory<TouchState> activeTouchState;

		public void AddFingers(Touchscreen screen)
		{
		}

		public void RemoveFingers(Touchscreen screen)
		{
		}

		public void Destroy()
		{
		}

		public void UpdateActiveFingers()
		{
		}

		public void UpdateActiveTouches()
		{
		}
	}

	internal struct ExtraDataPerTouchState
	{
		public Vector2 accumulatedDelta;

		public uint uniqueId;
	}

	private readonly Finger m_Finger;

	internal InputStateHistory<TouchState>.Record m_TouchRecord;

	internal static GlobalState s_GlobalState;

	public bool valid => false;

	public Finger finger => null;

	public TouchPhase phase => default(TouchPhase);

	public bool began => false;

	public bool inProgress => false;

	public bool ended => false;

	public int touchId => 0;

	public float pressure => 0f;

	public Vector2 radius => default(Vector2);

	public double startTime => 0.0;

	public double time => 0.0;

	public Touchscreen screen => null;

	public Vector2 screenPosition => default(Vector2);

	public Vector2 startScreenPosition => default(Vector2);

	public Vector2 delta => default(Vector2);

	public int tapCount => 0;

	public bool isTap => false;

	public int displayIndex => 0;

	public bool isInProgress => false;

	internal uint updateStepCount => 0u;

	internal uint uniqueId => 0u;

	private ref TouchState state
	{
		get
		{
			throw null;
		}
	}

	private ref ExtraDataPerTouchState extraData
	{
		get
		{
			throw null;
		}
	}

	public TouchHistory history => default(TouchHistory);

	public static ReadOnlyArray<Touch> activeTouches => default(ReadOnlyArray<Touch>);

	public static ReadOnlyArray<Finger> fingers => default(ReadOnlyArray<Finger>);

	public static ReadOnlyArray<Finger> activeFingers => default(ReadOnlyArray<Finger>);

	public static IEnumerable<Touchscreen> screens => null;

	public static int maxHistoryLengthPerFinger => 0;

	public static event Action<Finger> onFingerDown
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<Finger> onFingerUp
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<Finger> onFingerMove
	{
		add
		{
		}
		remove
		{
		}
	}

	internal Touch(Finger finger, InputStateHistory<TouchState>.Record touchRecord)
	{
		m_Finger = null;
		m_TouchRecord = default(InputStateHistory<TouchState>.Record);
	}

	public override string ToString()
	{
		return null;
	}

	public bool Equals(Touch other)
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

	internal static void AddTouchscreen(Touchscreen screen)
	{
	}

	internal static void RemoveTouchscreen(Touchscreen screen)
	{
	}

	internal static void BeginUpdate()
	{
	}

	private static GlobalState CreateGlobalState()
	{
		return default(GlobalState);
	}

	internal static ISavedState SaveAndResetState()
	{
		return null;
	}
}
