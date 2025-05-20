using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Profiling;

[NativeHeader("Runtime/Profiler/ScriptBindings/Sampler.bindings.h")]
[UsedByNativeCode]
public class Sampler
{
	internal IntPtr m_Ptr;

	internal static Sampler s_InvalidSampler;

	public bool isValid => false;

	internal Sampler()
	{
	}

	public Recorder GetRecorder()
	{
		return null;
	}
}
