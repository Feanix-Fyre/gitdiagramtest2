using System;
using Unity.Profiling;
using UnityEngine.Profiling;

namespace UnityEngine.Rendering;

[IgnoredByDeepProfiler]
[Obsolete("Please use ProfilingScope")]
public struct ProfilingSample : IDisposable
{
	private readonly CommandBuffer m_Cmd;

	private readonly string m_Name;

	private bool m_Disposed;

	private CustomSampler m_Sampler;

	public ProfilingSample(CommandBuffer cmd, string name, CustomSampler sampler = null)
	{
		m_Cmd = null;
		m_Name = null;
		m_Disposed = false;
		m_Sampler = null;
	}

	public ProfilingSample(CommandBuffer cmd, string format, object arg)
	{
		m_Cmd = null;
		m_Name = null;
		m_Disposed = false;
		m_Sampler = null;
	}

	public ProfilingSample(CommandBuffer cmd, string format, params object[] args)
	{
		m_Cmd = null;
		m_Name = null;
		m_Disposed = false;
		m_Sampler = null;
	}

	public void Dispose()
	{
	}

	private void Dispose(bool disposing)
	{
	}
}
