using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting;

internal class DisposerReplySink : IMessageSink
{
	private IMessageSink _next;

	private IDisposable _disposable;

	public DisposerReplySink(IMessageSink next, IDisposable disposable)
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
