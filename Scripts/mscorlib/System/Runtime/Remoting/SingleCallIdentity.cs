using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting;

internal class SingleCallIdentity : ServerIdentity
{
	public SingleCallIdentity(string objectUri, Context context, Type objectType)
		: base(null, null, null)
	{
	}

	public override IMessage SyncObjectProcessMessage(IMessage msg)
	{
		return null;
	}

	public override IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink)
	{
		return null;
	}
}
