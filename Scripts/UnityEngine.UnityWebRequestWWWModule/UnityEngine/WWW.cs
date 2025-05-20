using System;
using UnityEngine.Networking;

namespace UnityEngine;

[Obsolete("Use UnityWebRequest, a fully featured replacement which is more efficient and has additional features")]
public class WWW : CustomYieldInstruction, IDisposable
{
	private UnityWebRequest _uwr;

	public string error => null;

	public bool isDone => false;

	public string text => null;

	public Texture2D texture => null;

	public string url => null;

	public override bool keepWaiting => false;

	public WWW(string url)
	{
	}

	private Texture2D CreateTextureFromDownloadedData(bool markNonReadable)
	{
		return null;
	}

	public void Dispose()
	{
	}

	private bool WaitUntilDoneIfPossible()
	{
		return false;
	}
}
