using JetBrains.Annotations;

namespace Unity.Services.Core.Internal;

internal class LockedServiceRegistry : IServiceRegistry
{
	private const string k_ErrorMessage = "Service registration has been locked. Make sure to register service services before all packages have finished initializing.";

	[NotNull]
	internal IServiceRegistry Registry { get; }

	public LockedServiceRegistry([NotNull] IServiceRegistry registryToLock)
	{
	}

	public void RegisterService<T>(T service)
	{
	}

	public T GetService<T>()
	{
		return default(T);
	}
}
