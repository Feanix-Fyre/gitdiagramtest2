using Unity.Profiling;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine.Scripting;

namespace UnityEngine.Profiling;

[UsedByNativeCode]
public sealed class Recorder
{
	private const ProfilerRecorderOptions s_RecorderDefaultOptions = (ProfilerRecorderOptions)153;

	internal static Recorder s_InvalidRecorder;

	private ProfilerRecorder m_RecorderCPU;

	private ProfilerRecorder m_RecorderGPU;

	public bool enabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public long elapsedNanoseconds => 0L;

	public long gpuElapsedNanoseconds => 0L;

	public int sampleBlockCount => 0;

	public int gpuSampleBlockCount => 0;

	internal Recorder()
	{
	}

	internal Recorder(ProfilerRecorderHandle handle)
	{
	}

	~Recorder()
	{
	}

	private void SetEnabled(bool state)
	{
	}
}
