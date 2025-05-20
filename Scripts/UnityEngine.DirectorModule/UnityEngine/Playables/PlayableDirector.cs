using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables;

[RequiredByNativeCode]
[NativeHeader("Modules/Director/PlayableDirector.h")]
[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
public class PlayableDirector : Behaviour, IExposedPropertyTable
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<PlayableDirector> played;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Action<PlayableDirector> paused;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Action<PlayableDirector> stopped;

	public PlayState state => default(PlayState);

	public DirectorWrapMode extrapolationMode => default(DirectorWrapMode);

	public PlayableAsset playableAsset => null;

	public PlayableGraph playableGraph => default(PlayableGraph);

	public double time
	{
		get
		{
			return 0.0;
		}
		set
		{
		}
	}

	public double duration => 0.0;

	internal void Play(FrameRate frameRate)
	{
	}

	[NativeThrows]
	public void Evaluate()
	{
	}

	[NativeThrows]
	private void PlayOnFrame(FrameRate frameRate)
	{
	}

	[NativeThrows]
	public void Play()
	{
	}

	public void Stop()
	{
	}

	public void Pause()
	{
	}

	public Object GetReferenceValue(PropertyName id, out bool idValid)
	{
		idValid = default(bool);
		return null;
	}

	[NativeMethod("GetBindingFor")]
	public Object GetGenericBinding(Object key)
	{
		return null;
	}

	private PlayState GetPlayState()
	{
		return default(PlayState);
	}

	private DirectorWrapMode GetWrapMode()
	{
		return default(DirectorWrapMode);
	}

	private PlayableGraph GetGraphHandle()
	{
		return default(PlayableGraph);
	}

	private ScriptableObject Internal_GetPlayableAsset()
	{
		return null;
	}

	[RequiredByNativeCode]
	private void SendOnPlayableDirectorPlay()
	{
	}

	[RequiredByNativeCode]
	private void SendOnPlayableDirectorPause()
	{
	}

	[RequiredByNativeCode]
	private void SendOnPlayableDirectorStop()
	{
	}

	private void PlayOnFrame_Injected(ref FrameRate frameRate)
	{
	}

	private Object GetReferenceValue_Injected(ref PropertyName id, out bool idValid)
	{
		idValid = default(bool);
		return null;
	}

	private void GetGraphHandle_Injected(out PlayableGraph ret)
	{
		ret = default(PlayableGraph);
	}
}
