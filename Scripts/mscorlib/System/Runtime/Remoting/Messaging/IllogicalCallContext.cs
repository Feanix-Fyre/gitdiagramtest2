using System.Collections;

namespace System.Runtime.Remoting.Messaging;

internal class IllogicalCallContext
{
	private Hashtable m_Datastore;

	private object m_HostContext;

	private Hashtable Datastore => null;

	internal object HostContext
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal bool HasUserData => false;

	public void FreeNamedDataSlot(string name)
	{
	}

	public IllogicalCallContext CreateCopy()
	{
		return null;
	}
}
