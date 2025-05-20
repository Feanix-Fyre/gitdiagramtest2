using System;
using UnityEngine.Networking;

namespace Unity.Services.Analytics.Internal;

internal class AnalyticsWebRequest : UnityWebRequest, IWebRequest, IDisposable
{
	public bool IsNetworkError => false;

	UploadHandler IWebRequest.uploadHandler
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal AnalyticsWebRequest(string url, string method)
		: base(null, null)
	{
	}

	UnityWebRequestAsyncOperation IWebRequest.SendWebRequest()
	{
		return null;
	}

	void IWebRequest.SetRequestHeader(string key, string value)
	{
	}
}
