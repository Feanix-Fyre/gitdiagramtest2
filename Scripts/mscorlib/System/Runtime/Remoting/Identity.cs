using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting;

internal abstract class Identity
{
	protected string _objectUri;

	protected IMessageSink _channelSink;

	protected IMessageSink _envoySink;

	private DynamicPropertyCollection _clientDynamicProperties;

	private DynamicPropertyCollection _serverDynamicProperties;

	protected ObjRef _objRef;

	private bool _disposed;

	public IMessageSink ChannelSink
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public IMessageSink EnvoySink => null;

	public string ObjectUri
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool IsConnected => false;

	public bool Disposed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public DynamicPropertyCollection ClientDynamicProperties => null;

	public bool HasServerDynamicSinks => false;

	public Identity(string objectUri)
	{
	}

	public abstract ObjRef CreateObjRef(Type requestedType);

	public void NotifyClientDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async)
	{
	}

	public void NotifyServerDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async)
	{
	}
}
