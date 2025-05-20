using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables;

[NativeHeader("Runtime/Export/Director/PlayableHandle.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[UsedByNativeCode]
public struct PlayableHandle : IEquatable<PlayableHandle>
{
	internal IntPtr m_Handle;

	internal uint m_Version;

	private static readonly PlayableHandle m_Null;

	public static PlayableHandle Null => default(PlayableHandle);

	internal T GetObject<T>() where T : class, IPlayableBehaviour
	{
		return null;
	}

	[VisibleToOtherModules]
	internal bool IsPlayableOfType<T>()
	{
		return false;
	}

	internal Playable GetInput(int inputPort)
	{
		return default(Playable);
	}

	internal bool SetInputWeight(int inputIndex, float weight)
	{
		return false;
	}

	internal float GetInputWeight(int inputIndex)
	{
		return 0f;
	}

	public static bool operator ==(PlayableHandle x, PlayableHandle y)
	{
		return false;
	}

	public override bool Equals(object p)
	{
		return false;
	}

	public bool Equals(PlayableHandle other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs)
	{
		return false;
	}

	internal bool CheckInputBounds(int inputIndex)
	{
		return false;
	}

	internal bool CheckInputBounds(int inputIndex, bool acceptAny)
	{
		return false;
	}

	[VisibleToOtherModules]
	internal bool IsValid()
	{
		return false;
	}

	[VisibleToOtherModules]
	[FreeFunction("PlayableHandleBindings::GetPlayableType", HasExplicitThis = true, ThrowsException = true)]
	internal Type GetPlayableType()
	{
		return null;
	}

	[VisibleToOtherModules]
	[FreeFunction("PlayableHandleBindings::SetScriptInstance", HasExplicitThis = true, ThrowsException = true)]
	internal void SetScriptInstance(object scriptInstance)
	{
	}

	[FreeFunction("PlayableHandleBindings::GetPlayState", HasExplicitThis = true, ThrowsException = true)]
	[VisibleToOtherModules]
	internal PlayState GetPlayState()
	{
		return default(PlayState);
	}

	[FreeFunction("PlayableHandleBindings::Play", HasExplicitThis = true, ThrowsException = true)]
	[VisibleToOtherModules]
	internal void Play()
	{
	}

	[VisibleToOtherModules]
	[FreeFunction("PlayableHandleBindings::Pause", HasExplicitThis = true, ThrowsException = true)]
	internal void Pause()
	{
	}

	[VisibleToOtherModules]
	[FreeFunction("PlayableHandleBindings::SetSpeed", HasExplicitThis = true, ThrowsException = true)]
	internal void SetSpeed(double value)
	{
	}

	[VisibleToOtherModules]
	[FreeFunction("PlayableHandleBindings::GetTime", HasExplicitThis = true, ThrowsException = true)]
	internal double GetTime()
	{
		return 0.0;
	}

	[VisibleToOtherModules]
	[FreeFunction("PlayableHandleBindings::SetTime", HasExplicitThis = true, ThrowsException = true)]
	internal void SetTime(double value)
	{
	}

	[FreeFunction("PlayableHandleBindings::IsDone", HasExplicitThis = true, ThrowsException = true)]
	[VisibleToOtherModules]
	internal bool IsDone()
	{
		return false;
	}

	[VisibleToOtherModules]
	[FreeFunction("PlayableHandleBindings::SetDone", HasExplicitThis = true, ThrowsException = true)]
	internal void SetDone(bool value)
	{
	}

	[FreeFunction("PlayableHandleBindings::GetDuration", HasExplicitThis = true, ThrowsException = true)]
	[VisibleToOtherModules]
	internal double GetDuration()
	{
		return 0.0;
	}

	[FreeFunction("PlayableHandleBindings::SetDuration", HasExplicitThis = true, ThrowsException = true)]
	[VisibleToOtherModules]
	internal void SetDuration(double value)
	{
	}

	[FreeFunction("PlayableHandleBindings::SetPropagateSetTime", HasExplicitThis = true, ThrowsException = true)]
	[VisibleToOtherModules]
	internal void SetPropagateSetTime(bool value)
	{
	}

	[FreeFunction("PlayableHandleBindings::GetGraph", HasExplicitThis = true, ThrowsException = true)]
	[VisibleToOtherModules]
	internal PlayableGraph GetGraph()
	{
		return default(PlayableGraph);
	}

	[VisibleToOtherModules]
	[FreeFunction("PlayableHandleBindings::GetInputCount", HasExplicitThis = true, ThrowsException = true)]
	internal int GetInputCount()
	{
		return 0;
	}

	[VisibleToOtherModules]
	[FreeFunction("PlayableHandleBindings::SetInputCount", HasExplicitThis = true, ThrowsException = true)]
	internal void SetInputCount(int value)
	{
	}

	[VisibleToOtherModules]
	[FreeFunction("PlayableHandleBindings::SetInputWeight", HasExplicitThis = true, ThrowsException = true)]
	internal void SetInputWeight(PlayableHandle input, float weight)
	{
	}

	[FreeFunction("PlayableHandleBindings::GetPreviousTime", HasExplicitThis = true, ThrowsException = true)]
	[VisibleToOtherModules]
	internal double GetPreviousTime()
	{
		return 0.0;
	}

	[FreeFunction("PlayableHandleBindings::SetTraversalMode", HasExplicitThis = true, ThrowsException = true)]
	[VisibleToOtherModules]
	internal void SetTraversalMode(PlayableTraversalMode mode)
	{
	}

	[FreeFunction("PlayableHandleBindings::GetTimeWrapMode", HasExplicitThis = true, ThrowsException = true)]
	[VisibleToOtherModules]
	internal DirectorWrapMode GetTimeWrapMode()
	{
		return default(DirectorWrapMode);
	}

	[FreeFunction("PlayableHandleBindings::SetTimeWrapMode", HasExplicitThis = true, ThrowsException = true)]
	[VisibleToOtherModules]
	internal void SetTimeWrapMode(DirectorWrapMode mode)
	{
	}

	[FreeFunction("PlayableHandleBindings::GetScriptInstance", HasExplicitThis = true, ThrowsException = true)]
	private object GetScriptInstance()
	{
		return null;
	}

	[FreeFunction("PlayableHandleBindings::GetInputHandle", HasExplicitThis = true, ThrowsException = true)]
	private PlayableHandle GetInputHandle(int index)
	{
		return default(PlayableHandle);
	}

	[FreeFunction("PlayableHandleBindings::SetInputWeightFromIndex", HasExplicitThis = true, ThrowsException = true)]
	private void SetInputWeightFromIndex(int index, float weight)
	{
	}

	[FreeFunction("PlayableHandleBindings::GetInputWeightFromIndex", HasExplicitThis = true, ThrowsException = true)]
	private float GetInputWeightFromIndex(int index)
	{
		return 0f;
	}

	private static bool IsValid_Injected(ref PlayableHandle _unity_self)
	{
		return false;
	}

	private static Type GetPlayableType_Injected(ref PlayableHandle _unity_self)
	{
		return null;
	}

	private static void SetScriptInstance_Injected(ref PlayableHandle _unity_self, object scriptInstance)
	{
	}

	private static PlayState GetPlayState_Injected(ref PlayableHandle _unity_self)
	{
		return default(PlayState);
	}

	private static void Play_Injected(ref PlayableHandle _unity_self)
	{
	}

	private static void Pause_Injected(ref PlayableHandle _unity_self)
	{
	}

	private static void SetSpeed_Injected(ref PlayableHandle _unity_self, double value)
	{
	}

	private static double GetTime_Injected(ref PlayableHandle _unity_self)
	{
		return 0.0;
	}

	private static void SetTime_Injected(ref PlayableHandle _unity_self, double value)
	{
	}

	private static bool IsDone_Injected(ref PlayableHandle _unity_self)
	{
		return false;
	}

	private static void SetDone_Injected(ref PlayableHandle _unity_self, bool value)
	{
	}

	private static double GetDuration_Injected(ref PlayableHandle _unity_self)
	{
		return 0.0;
	}

	private static void SetDuration_Injected(ref PlayableHandle _unity_self, double value)
	{
	}

	private static void SetPropagateSetTime_Injected(ref PlayableHandle _unity_self, bool value)
	{
	}

	private static void GetGraph_Injected(ref PlayableHandle _unity_self, out PlayableGraph ret)
	{
		ret = default(PlayableGraph);
	}

	private static int GetInputCount_Injected(ref PlayableHandle _unity_self)
	{
		return 0;
	}

	private static void SetInputCount_Injected(ref PlayableHandle _unity_self, int value)
	{
	}

	private static void SetInputWeight_Injected(ref PlayableHandle _unity_self, ref PlayableHandle input, float weight)
	{
	}

	private static double GetPreviousTime_Injected(ref PlayableHandle _unity_self)
	{
		return 0.0;
	}

	private static void SetTraversalMode_Injected(ref PlayableHandle _unity_self, PlayableTraversalMode mode)
	{
	}

	private static DirectorWrapMode GetTimeWrapMode_Injected(ref PlayableHandle _unity_self)
	{
		return default(DirectorWrapMode);
	}

	private static void SetTimeWrapMode_Injected(ref PlayableHandle _unity_self, DirectorWrapMode mode)
	{
	}

	private static object GetScriptInstance_Injected(ref PlayableHandle _unity_self)
	{
		return null;
	}

	private static void GetInputHandle_Injected(ref PlayableHandle _unity_self, int index, out PlayableHandle ret)
	{
		ret = default(PlayableHandle);
	}

	private static void SetInputWeightFromIndex_Injected(ref PlayableHandle _unity_self, int index, float weight)
	{
	}

	private static float GetInputWeightFromIndex_Injected(ref PlayableHandle _unity_self, int index)
	{
		return 0f;
	}
}
