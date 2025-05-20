using System;
using System.ComponentModel;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables;

[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Runtime/Export/Director/PlayableGraph.bindings.h")]
[UsedByNativeCode]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
public struct PlayableGraph
{
	internal IntPtr m_Handle;

	internal uint m_Version;

	public Playable GetRootPlayable(int index)
	{
		return default(Playable);
	}

	public bool Connect<U, V>(U source, int sourceOutputPort, V destination, int destinationInputPort) where U : struct, IPlayable where V : struct, IPlayable
	{
		return false;
	}

	public void Evaluate()
	{
	}

	public bool IsValid()
	{
		return false;
	}

	[FreeFunction("PlayableGraphBindings::IsPlaying", HasExplicitThis = true, ThrowsException = true)]
	public bool IsPlaying()
	{
		return false;
	}

	[FreeFunction("PlayableGraphBindings::Evaluate", HasExplicitThis = true, ThrowsException = true)]
	public void Evaluate([DefaultValue("0")] float deltaTime)
	{
	}

	[FreeFunction("PlayableGraphBindings::GetResolver", HasExplicitThis = true, ThrowsException = true)]
	public IExposedPropertyTable GetResolver()
	{
		return null;
	}

	[FreeFunction("PlayableGraphBindings::GetPlayableCount", HasExplicitThis = true, ThrowsException = true)]
	public int GetPlayableCount()
	{
		return 0;
	}

	[FreeFunction("PlayableGraphBindings::GetRootPlayableCount", HasExplicitThis = true, ThrowsException = true)]
	public int GetRootPlayableCount()
	{
		return 0;
	}

	[FreeFunction("PlayableGraphBindings::SynchronizeEvaluation", HasExplicitThis = true, ThrowsException = true)]
	internal void SynchronizeEvaluation(PlayableGraph playable)
	{
	}

	[FreeFunction("PlayableGraphBindings::CreatePlayableHandle", HasExplicitThis = true, ThrowsException = true)]
	internal PlayableHandle CreatePlayableHandle()
	{
		return default(PlayableHandle);
	}

	[FreeFunction("PlayableGraphBindings::CreateScriptOutputInternal", HasExplicitThis = true, ThrowsException = true)]
	internal bool CreateScriptOutputInternal(string name, out PlayableOutputHandle handle)
	{
		handle = default(PlayableOutputHandle);
		return false;
	}

	[FreeFunction("PlayableGraphBindings::GetRootPlayableInternal", HasExplicitThis = true, ThrowsException = true)]
	internal PlayableHandle GetRootPlayableInternal(int index)
	{
		return default(PlayableHandle);
	}

	[FreeFunction("PlayableGraphBindings::IsMatchFrameRateEnabled", HasExplicitThis = true, ThrowsException = true)]
	internal bool IsMatchFrameRateEnabled()
	{
		return false;
	}

	[FreeFunction("PlayableGraphBindings::GetFrameRate", HasExplicitThis = true, ThrowsException = true)]
	internal FrameRate GetFrameRate()
	{
		return default(FrameRate);
	}

	[FreeFunction("PlayableGraphBindings::ConnectInternal", HasExplicitThis = true, ThrowsException = true)]
	private bool ConnectInternal(PlayableHandle source, int sourceOutputPort, PlayableHandle destination, int destinationInputPort)
	{
		return false;
	}

	private static bool IsValid_Injected(ref PlayableGraph _unity_self)
	{
		return false;
	}

	private static bool IsPlaying_Injected(ref PlayableGraph _unity_self)
	{
		return false;
	}

	private static void Evaluate_Injected(ref PlayableGraph _unity_self, [DefaultValue("0")] float deltaTime)
	{
	}

	private static IExposedPropertyTable GetResolver_Injected(ref PlayableGraph _unity_self)
	{
		return null;
	}

	private static int GetPlayableCount_Injected(ref PlayableGraph _unity_self)
	{
		return 0;
	}

	private static int GetRootPlayableCount_Injected(ref PlayableGraph _unity_self)
	{
		return 0;
	}

	private static void SynchronizeEvaluation_Injected(ref PlayableGraph _unity_self, ref PlayableGraph playable)
	{
	}

	private static void CreatePlayableHandle_Injected(ref PlayableGraph _unity_self, out PlayableHandle ret)
	{
		ret = default(PlayableHandle);
	}

	private static bool CreateScriptOutputInternal_Injected(ref PlayableGraph _unity_self, string name, out PlayableOutputHandle handle)
	{
		handle = default(PlayableOutputHandle);
		return false;
	}

	private static void GetRootPlayableInternal_Injected(ref PlayableGraph _unity_self, int index, out PlayableHandle ret)
	{
		ret = default(PlayableHandle);
	}

	private static bool IsMatchFrameRateEnabled_Injected(ref PlayableGraph _unity_self)
	{
		return false;
	}

	private static void GetFrameRate_Injected(ref PlayableGraph _unity_self, out FrameRate ret)
	{
		ret = default(FrameRate);
	}

	private static bool ConnectInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle source, int sourceOutputPort, ref PlayableHandle destination, int destinationInputPort)
	{
		return false;
	}
}
