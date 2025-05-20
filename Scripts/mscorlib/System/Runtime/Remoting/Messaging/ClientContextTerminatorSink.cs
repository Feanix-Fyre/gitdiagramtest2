using System.Runtime.Remoting.Contexts;

namespace System.Runtime.Remoting.Messaging;

internal class ClientContextTerminatorSink : IMessageSink
{
	private Context _context;

	public ClientContextTerminatorSink(Context ctx)
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
