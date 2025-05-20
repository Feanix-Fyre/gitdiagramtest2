namespace System.Runtime.Remoting.Activation;

internal class AppDomainLevelActivator : IActivator
{
	private string _activationUrl;

	private IActivator _next;

	public IActivator NextActivator => null;

	public AppDomainLevelActivator(string activationUrl, IActivator next)
	{
	}

	public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall)
	{
		return null;
	}
}
