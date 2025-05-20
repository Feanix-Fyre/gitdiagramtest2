using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Microsoft.Win32.SafeHandles;

namespace System.Net.Sockets;

internal sealed class SafeSocketHandle : SafeHandleMinusOneIsInvalid
{
	private List<Thread> blocking_threads;

	private Dictionary<Thread, StackTrace> threads_stacktraces;

	private bool in_cleanup;

	private const int SOCKET_CLOSED = 10004;

	private const int ABORT_RETRIES = 10;

	private static bool THROW_ON_ABORT_RETRIES;

	public SafeSocketHandle(IntPtr preexistingHandle, bool ownsHandle)
		: base(ownsHandle: false)
	{
	}

	protected override bool ReleaseHandle()
	{
		return false;
	}

	public void RegisterForBlockingSyscall()
	{
	}

	public void UnRegisterForBlockingSyscall()
	{
	}
}
