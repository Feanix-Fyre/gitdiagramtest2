namespace System.Runtime.Remoting.Activation;

[Serializable]
internal class ConstructionLevelActivator : IActivator
{
	public IActivator NextActivator => null;

	public IConstructionReturnMessage Activate(IConstructionCallMessage msg)
	{
		return null;
	}
}
