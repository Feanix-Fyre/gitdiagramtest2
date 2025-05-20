using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting;

/// <summary>Stores all relevant information required to generate a proxy in order to communicate with a remote object.</summary>
[Serializable]
[ComVisible(true)]
public class ObjRef : IObjectReference, ISerializable
{
	private IChannelInfo channel_info;

	private string uri;

	private IRemotingTypeInfo typeInfo;

	private IEnvoyInfo envoyInfo;

	private int flags;

	private Type _serverType;

	private static int MarshalledObjectRef;

	private static int WellKnowObjectRef;

	internal bool IsReferenceToWellKnow => false;

	/// <summary>Gets or sets the <see cref="T:System.Runtime.Remoting.IChannelInfo" /> for the <see cref="T:System.Runtime.Remoting.ObjRef" />.</summary>
	/// <returns>The <see cref="T:System.Runtime.Remoting.IChannelInfo" /> interface for the <see cref="T:System.Runtime.Remoting.ObjRef" />.</returns>
	public virtual IChannelInfo ChannelInfo
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			return null;
		}
	}

	/// <summary>Gets or sets the <see cref="T:System.Runtime.Remoting.IEnvoyInfo" /> for the <see cref="T:System.Runtime.Remoting.ObjRef" />.</summary>
	/// <returns>The <see cref="T:System.Runtime.Remoting.IEnvoyInfo" /> interface for the <see cref="T:System.Runtime.Remoting.ObjRef" />.</returns>
	public virtual IEnvoyInfo EnvoyInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the <see cref="T:System.Runtime.Remoting.IRemotingTypeInfo" /> for the object that the <see cref="T:System.Runtime.Remoting.ObjRef" /> describes.</summary>
	/// <returns>The <see cref="T:System.Runtime.Remoting.IRemotingTypeInfo" /> for the object that the <see cref="T:System.Runtime.Remoting.ObjRef" /> describes.</returns>
	public virtual IRemotingTypeInfo TypeInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the URI of the specific object instance.</summary>
	/// <returns>The URI of the specific object instance.</returns>
	public virtual string URI
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal Type ServerType => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.ObjRef" /> class with default values.</summary>
	public ObjRef()
	{
	}

	internal ObjRef(string uri, IChannelInfo cinfo)
	{
	}

	internal ObjRef DeserializeInTheCurrentDomain(int domainId, byte[] tInfo)
	{
		return null;
	}

	internal byte[] SerializeType()
	{
		return null;
	}

	internal ObjRef(Type type, string url, object remoteChannelData)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.ObjRef" /> class from serialized data.</summary>
	/// <param name="info">The object that holds the serialized object data.</param>
	/// <param name="context">The contextual information about the source or destination of the exception.</param>
	protected ObjRef(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Populates a specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data needed to serialize the current <see cref="T:System.Runtime.Remoting.ObjRef" /> instance.</summary>
	/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data.</param>
	/// <param name="context">The contextual information about the source or destination of the serialization.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have serialization formatter permission.</exception>
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Returns a reference to the remote object that the <see cref="T:System.Runtime.Remoting.ObjRef" /> describes.</summary>
	/// <param name="context">The context where the current object resides.</param>
	/// <returns>A reference to the remote object that the <see cref="T:System.Runtime.Remoting.ObjRef" /> describes.</returns>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have serialization formatter permission.</exception>
	public virtual object GetRealObject(StreamingContext context)
	{
		return null;
	}

	internal void UpdateChannelInfo()
	{
	}
}
