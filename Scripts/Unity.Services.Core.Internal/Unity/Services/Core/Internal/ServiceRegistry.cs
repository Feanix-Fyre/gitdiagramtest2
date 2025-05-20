using System.Collections.Generic;
using JetBrains.Annotations;

namespace Unity.Services.Core.Internal;

internal class ServiceRegistry : IServiceRegistry
{
	[NotNull]
	internal Dictionary<int, object> ServiceTypeHashToInstance { get; }

	public ServiceRegistry()
	{
	}

	public ServiceRegistry([NotNull] Dictionary<int, object> serviceTypeHashToInstance)
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
