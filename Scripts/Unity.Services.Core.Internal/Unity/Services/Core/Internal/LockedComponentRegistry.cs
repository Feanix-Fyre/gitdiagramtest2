using System.Collections.Generic;
using JetBrains.Annotations;

namespace Unity.Services.Core.Internal;

internal class LockedComponentRegistry : IComponentRegistry
{
	private const string k_ErrorMessage = "Component registration has been locked. Make sure to register service components before all packages have finished initializing.";

	[NotNull]
	internal IComponentRegistry Registry { get; }

	public LockedComponentRegistry([NotNull] IComponentRegistry registryToLock)
	{
	}

	public void RegisterServiceComponent<TComponent>(TComponent component) where TComponent : IServiceComponent
	{
	}

	public TComponent GetServiceComponent<TComponent>() where TComponent : IServiceComponent
	{
		return default(TComponent);
	}

	public bool TryGetServiceComponent<TComponent>(out TComponent component) where TComponent : IServiceComponent
	{
		component = default(TComponent);
		return false;
	}

	public void ResetProvidedComponents(IDictionary<int, IServiceComponent> componentTypeHashToInstance)
	{
	}
}
