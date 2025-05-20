using System;
using System.Runtime.CompilerServices;

namespace Unity.Services.Analytics.Internal;

internal class Dispatcher : IDispatcher, IDispatcherDebug
{
	private readonly IWebRequestHelper m_WebRequestHelper;

	private readonly string m_CollectUrl;

	internal const string k_PiplConsentHeaderKey = "PIPL_CONSENT";

	internal const string k_PiplExportHeaderKey = "PIPL_EXPORT";

	internal const string k_HeaderTrueValue = "true";

	private IBuffer m_DataBuffer;

	private IWebRequest m_FlushRequest;

	private byte[] m_LastFlushPayload;

	private int m_FlushBufferIndex;

	public int ConsecutiveFailedUploadCount { get; private set; }

	public bool FlushInProgress { get; private set; }

	public event Action<byte[]> FlushStarted
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<int, bool, bool, bool, bool, byte[]> FlushFinished
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public Dispatcher(IWebRequestHelper webRequestHelper, string collectUrl)
	{
	}

	public void SetBuffer(IBuffer buffer)
	{
	}

	public void Flush()
	{
	}

	private void FlushBufferToService()
	{
	}

	private void UploadCompleted(long responseCode)
	{
	}
}
