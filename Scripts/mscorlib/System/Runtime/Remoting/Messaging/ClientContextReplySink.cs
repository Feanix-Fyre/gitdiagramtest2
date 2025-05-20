using System.Runtime.Remoting.Contexts;

namespace System.Runtime.Remoting.Messaging;

internal class ClientContextReplySink : IMessageSink
{
	private IMessageSink _replySink;

	private Context _context;

	public ClientContextReplySink(Context ctx, IMessageSink replySink)
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
