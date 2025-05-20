using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting;

internal class SingletonIdentity : ServerIdentity
{
	public SingletonIdentity(string objectUri, Context context, Type objectType)
		: base(null, null, null)
	{
	}

	public MarshalByRefObject GetServerObject()
	{
		return null;
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
