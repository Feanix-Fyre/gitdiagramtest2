using System.Collections;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Contexts;

internal class DynamicPropertyCollection
{
	private class DynamicPropertyReg
	{
		public IDynamicProperty Property;

		public IDynamicMessageSink Sink;
	}

	private ArrayList _properties;

	public bool HasProperties => false;

	public bool RegisterDynamicProperty(IDynamicProperty prop)
	{
		return false;
	}

	public bool UnregisterDynamicProperty(string name)
	{
		return false;
	}

	public void NotifyMessage(bool start, IMessage msg, bool client_site, bool async)
	{
	}

	private int FindProperty(string name)
	{
		return 0;
	}
}
