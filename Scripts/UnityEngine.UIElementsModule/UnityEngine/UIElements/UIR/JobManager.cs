using System;

namespace UnityEngine.UIElements.UIR;

internal class JobManager : IDisposable
{
	private NativePagedList<NudgeJobData> m_NudgeJobs;

	private NativePagedList<ConvertMeshJobData> m_ConvertMeshJobs;

	private NativePagedList<CopyClosingMeshJobData> m_CopyClosingMeshJobs;

	private JobMerger m_JobMerger;

	protected bool disposed { get; private set; }

	public void Add(ref NudgeJobData job)
	{
	}

	public void Add(ref ConvertMeshJobData job)
	{
	}

	public void Add(ref CopyClosingMeshJobData job)
	{
	}

	public void CompleteNudgeJobs()
	{
	}

	public void CompleteConvertMeshJobs()
	{
	}

	public void CompleteClosingMeshJobs()
	{
	}

	public void Dispose()
	{
	}

	protected void Dispose(bool disposing)
	{
	}
}
