using System.Runtime.CompilerServices;
using Mono.Interop;

namespace System.Threading;

internal class OSSpecificSynchronizationContext : SynchronizationContext
{
	private delegate void InvocationEntryDelegate(IntPtr arg);

	private class InvocationContext
	{
		private SendOrPostCallback m_Delegate;

		private object m_State;

		public InvocationContext(SendOrPostCallback d, object state)
		{
		}

		public void Invoke()
		{
		}
	}

	private object m_OSSynchronizationContext;

	private static readonly ConditionalWeakTable<object, OSSpecificSynchronizationContext> s_ContextCache;

	private OSSpecificSynchronizationContext(object osContext)
	{
	}

	public static OSSpecificSynchronizationContext Get()
	{
		return null;
	}

	public override SynchronizationContext CreateCopy()
	{
		return null;
	}

	public override void Send(SendOrPostCallback d, object state)
	{
	}

	public override void Post(SendOrPostCallback d, object state)
	{
	}

	[MonoPInvokeCallback(typeof(InvocationEntryDelegate))]
	private static void InvocationEntry(IntPtr arg)
	{
	}

	private static object GetOSContext()
	{
		return null;
	}

	private static void PostInternal(object osSynchronizationContext, IntPtr callback, IntPtr arg)
	{
	}
}
