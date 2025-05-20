using System.Collections.Generic;
using JetBrains.Annotations;

namespace Unity.Services.Core.Internal;

internal class ComponentRegistry : IComponentRegistry
{
	[NotNull]
	internal Dictionary<int, IServiceComponent> ComponentTypeHashToInstance { get; }

	public ComponentRegistry()
	{
	}

	public ComponentRegistry([NotNull] Dictionary<int, IServiceComponent> componentTypeHashToInstance)
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

	private bool IsComponentTypeRegistered(int componentTypeHash)
	{
		return false;
	}

	public void ResetProvidedComponents(IDictionary<int, IServiceComponent> componentTypeHashToInstance)
	{
	}
}
