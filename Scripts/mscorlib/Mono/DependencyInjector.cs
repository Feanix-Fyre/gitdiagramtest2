namespace Mono;

internal static class DependencyInjector
{
	private static object locker;

	private static ISystemDependencyProvider systemDependency;

	internal static ISystemDependencyProvider SystemProvider => null;

	internal static void Register(ISystemDependencyProvider provider)
	{
	}

	private static ISystemDependencyProvider ReflectionLoad()
	{
		return null;
	}
}
