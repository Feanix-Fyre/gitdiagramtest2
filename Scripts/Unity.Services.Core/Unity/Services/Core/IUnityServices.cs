using System.Threading.Tasks;

namespace Unity.Services.Core;

public interface IUnityServices
{
	ServicesInitializationState State { get; }

	Task InitializeAsync(InitializationOptions options = null);

	T GetService<T>();
}
