namespace System.Runtime.Remoting.Activation;

internal class RemoteActivator : MarshalByRefObject, IActivator
{
	public IActivator NextActivator => null;

	public IConstructionReturnMessage Activate(IConstructionCallMessage msg)
	{
		return null;
	}
}
