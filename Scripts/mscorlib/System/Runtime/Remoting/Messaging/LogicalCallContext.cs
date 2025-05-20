using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting.Messaging;

/// <summary>Provides a set of properties that are carried with the execution code path during remote method calls.</summary>
[Serializable]
[ComVisible(true)]
public sealed class LogicalCallContext : ISerializable, ICloneable
{
	internal struct Reader
	{
		private LogicalCallContext m_ctx;

		public bool IsNull => false;

		public bool HasInfo => false;

		public Reader(LogicalCallContext ctx)
		{
			m_ctx = null;
		}

		public LogicalCallContext Clone()
		{
			return null;
		}

		public object GetData(string name)
		{
			return null;
		}
	}

	private static Type s_callContextType;

	private const string s_CorrelationMgrSlotName = "System.Diagnostics.Trace.CorrelationManagerSlot";

	private Hashtable m_Datastore;

	private CallContextRemotingData m_RemotingData;

	private CallContextSecurityData m_SecurityData;

	private object m_HostContext;

	private bool m_IsCorrelationMgr;

	private Header[] _sendHeaders;

	private Header[] _recvHeaders;

	/// <summary>Gets a value indicating whether the current <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> contains information.</summary>
	/// <returns>A Boolean value indicating whether the current <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> contains information.</returns>
	public bool HasInfo => false;

	private bool HasUserData => false;

	private Hashtable Datastore => null;

	internal LogicalCallContext()
	{
	}

	internal LogicalCallContext(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Populates a specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data needed to serialize the current <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" />.</summary>
	/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data.</param>
	/// <param name="context">The contextual information about the source or destination of the serialization.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="info" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have SerializationFormatter permission.</exception>
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Creates a new object that is a copy of the current instance.</summary>
	/// <returns>A new object that is a copy of this instance.</returns>
	public object Clone()
	{
		return null;
	}

	internal void Merge(LogicalCallContext lc)
	{
	}

	/// <summary>Retrieves an object associated with the specified name from the current instance.</summary>
	/// <param name="name">The name of the item in the call context.</param>
	/// <returns>The object in the logical call context associated with the specified name.</returns>
	public object GetData(string name)
	{
		return null;
	}

	/// <summary>Stores the specified object in the current instance, and associates it with the specified name.</summary>
	/// <param name="name">The name with which to associate the new item in the call context.</param>
	/// <param name="data">The object to store in the call context.</param>
	public void SetData(string name, object data)
	{
	}
}
