namespace System.Runtime.Remoting.Activation;

[Serializable]
internal class ContextLevelActivator : IActivator
{
	private IActivator m_NextActivator;

	public IActivator NextActivator => null;

	public ContextLevelActivator(IActivator next)
	{
	}

	public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall)
	{
		return null;
	}
}
