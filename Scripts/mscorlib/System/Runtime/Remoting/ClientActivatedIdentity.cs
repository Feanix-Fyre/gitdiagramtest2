using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting;

internal class ClientActivatedIdentity : ServerIdentity
{
	private MarshalByRefObject _targetThis;

	public ClientActivatedIdentity(string objectUri, Type objectType)
		: base(null, null, null)
	{
	}

	public MarshalByRefObject GetServerObject()
	{
		return null;
	}

	public void SetClientProxy(MarshalByRefObject obj)
	{
	}

	public override void OnLifetimeExpired()
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
