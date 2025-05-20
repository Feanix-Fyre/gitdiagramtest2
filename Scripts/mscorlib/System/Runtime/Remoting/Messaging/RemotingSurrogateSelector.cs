using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting.Messaging;

/// <summary>Selects the remoting surrogate that can be used to serialize an object that derives from a <see cref="T:System.MarshalByRefObject" />.</summary>
[ComVisible(true)]
public class RemotingSurrogateSelector : ISurrogateSelector
{
	private static Type s_cachedTypeObjRef;

	private static ObjRefSurrogate _objRefSurrogate;

	private static RemotingSurrogate _objRemotingSurrogate;

	private ISurrogateSelector _next;

	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Messaging.RemotingSurrogateSelector" /> class.</summary>
	public RemotingSurrogateSelector()
	{
	}

	/// <summary>Returns the appropriate surrogate for the given type in the given context.</summary>
	/// <param name="type">The <see cref="T:System.Type" /> for which the surrogate is requested.</param>
	/// <param name="context">The source or destination of serialization.</param>
	/// <param name="ssout">When this method returns, contains an <see cref="T:System.Runtime.Serialization.ISurrogateSelector" /> that is appropriate for the specified object type. This parameter is passed uninitialized.</param>
	/// <returns>The appropriate surrogate for the given type in the given context.</returns>
	public virtual ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector ssout)
	{
		ssout = null;
		return null;
	}
}
