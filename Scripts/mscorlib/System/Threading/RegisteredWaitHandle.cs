using System.Runtime.InteropServices;

namespace System.Threading;

/// <summary>Represents a handle that has been registered when calling <see cref="M:System.Threading.ThreadPool.RegisterWaitForSingleObject(System.Threading.WaitHandle,System.Threading.WaitOrTimerCallback,System.Object,System.UInt32,System.Boolean)" />. This class cannot be inherited.</summary>
[ComVisible(true)]
public sealed class RegisteredWaitHandle : MarshalByRefObject
{
	private WaitHandle _waitObject;

	private WaitOrTimerCallback _callback;

	private object _state;

	private WaitHandle _finalEvent;

	private ManualResetEvent _cancelEvent;

	private TimeSpan _timeout;

	private int _callsInProcess;

	private bool _executeOnlyOnce;

	private bool _unregistered;

	internal RegisteredWaitHandle(WaitHandle waitObject, WaitOrTimerCallback callback, object state, TimeSpan timeout, bool executeOnlyOnce)
	{
	}

	internal void Wait(object state)
	{
	}

	private void DoCallBack(object timedOut)
	{
	}

	/// <summary>Cancels a registered wait operation issued by the <see cref="M:System.Threading.ThreadPool.RegisterWaitForSingleObject(System.Threading.WaitHandle,System.Threading.WaitOrTimerCallback,System.Object,System.UInt32,System.Boolean)" /> method.</summary>
	/// <param name="waitObject">The <see cref="T:System.Threading.WaitHandle" /> to be signaled.</param>
	/// <returns>
	///   <see langword="true" /> if the function succeeds; otherwise, <see langword="false" />.</returns>
	[ComVisible(true)]
	public bool Unregister(WaitHandle waitObject)
	{
		return false;
	}
}
