using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Contexts;

internal class CrossContextChannel : IMessageSink
{
	private class ContextRestoreSink : IMessageSink
	{
		private IMessageSink _next;

		private Context _context;

		private IMessage _call;

		public ContextRestoreSink(IMessageSink next, Context context, IMessage call)
		{
		}

		public IMessage SyncProcessMessage(IMessage msg)
		{
			return null;
		}

		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			return null;
		}
	}

	public IMessage SyncProcessMessage(IMessage msg)
	{
		return null;
	}

	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
	{
		return null;
	}
}
