using System;
using Unity.Collections;
using Unity.Jobs;

namespace UnityEngine.UIElements.UIR;

internal class JobMerger : IDisposable
{
	private NativeArray<JobHandle> m_Jobs;

	private int m_JobCount;

	protected bool disposed { get; private set; }

	public JobMerger(int capacity)
	{
	}

	public void Add(JobHandle job)
	{
	}

	public JobHandle MergeAndReset()
	{
		return default(JobHandle);
	}

	public void Dispose()
	{
	}

	protected void Dispose(bool disposing)
	{
	}
}
