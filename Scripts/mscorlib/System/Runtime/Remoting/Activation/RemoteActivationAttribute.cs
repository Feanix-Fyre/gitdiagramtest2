using System.Collections;
using System.Runtime.Remoting.Contexts;

namespace System.Runtime.Remoting.Activation;

internal class RemoteActivationAttribute : Attribute, IContextAttribute
{
	private IList _contextProperties;

	public RemoteActivationAttribute(IList contextProperties)
	{
	}

	public bool IsContextOK(Context ctx, IConstructionCallMessage ctor)
	{
		return false;
	}

	public void GetPropertiesForNewContext(IConstructionCallMessage ctor)
	{
	}
}
