namespace Unity.Services.Core.Internal;

public readonly struct CoreRegistration
{
	private readonly IPackageRegistry m_Registry;

	private readonly int m_PackageHash;

	internal CoreRegistration(IPackageRegistry registry, int packageHash)
	{
		m_Registry = null;
		m_PackageHash = 0;
	}

	public CoreRegistration DependsOn<T>() where T : IServiceComponent
	{
		return default(CoreRegistration);
	}

	public CoreRegistration OptionallyDependsOn<T>() where T : IServiceComponent
	{
		return default(CoreRegistration);
	}

	public CoreRegistration ProvidesComponent<T>() where T : IServiceComponent
	{
		return default(CoreRegistration);
	}
}
