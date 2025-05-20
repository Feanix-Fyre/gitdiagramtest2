using JetBrains.Annotations;

namespace Unity.Services.Core.Internal;

internal class LockedPackageRegistry : IPackageRegistry
{
	private const string k_ErrorMessage = "Package registration has been locked. Make sure to register service packages in[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)].";

	[NotNull]
	internal IPackageRegistry Registry { get; }

	public DependencyTree Tree
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public LockedPackageRegistry([NotNull] IPackageRegistry registryToLock)
	{
	}

	public CoreRegistration RegisterPackage<TPackage>(TPackage package) where TPackage : IInitializablePackage
	{
		return default(CoreRegistration);
	}

	public void RegisterDependency<TComponent>(int packageTypeHash) where TComponent : IServiceComponent
	{
	}

	public void RegisterOptionalDependency<TComponent>(int packageTypeHash) where TComponent : IServiceComponent
	{
	}

	public void RegisterProvision<TComponent>(int packageTypeHash) where TComponent : IServiceComponent
	{
	}
}
