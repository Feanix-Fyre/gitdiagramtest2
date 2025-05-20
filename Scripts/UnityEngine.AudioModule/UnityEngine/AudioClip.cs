using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
[StaticAccessor("AudioClipBindings", StaticAccessorType.DoubleColon)]
public sealed class AudioClip : Object
{
	public delegate void PCMReaderCallback(float[] data);

	public delegate void PCMSetPositionCallback(int position);

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private PCMReaderCallback m_PCMReaderCallback;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private PCMSetPositionCallback m_PCMSetPositionCallback;

	[NativeProperty("LengthSec")]
	public float length => 0f;

	[NativeProperty("SampleCount")]
	public int samples => 0;

	public int frequency => 0;

	private AudioClip()
	{
	}

	[RequiredByNativeCode]
	private void InvokePCMReaderCallback_Internal(float[] data)
	{
	}

	[RequiredByNativeCode]
	private void InvokePCMSetPositionCallback_Internal(int position)
	{
	}
}
