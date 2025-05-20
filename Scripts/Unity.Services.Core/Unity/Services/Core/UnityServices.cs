using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Unity.Services.Core;

public static class UnityServices
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CInitializeAsync_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public InitializationOptions options;

		private TaskAwaiter<object> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	internal static ExternalUserIdProperty ExternalUserIdProperty;

	internal static IUnityServices Instance { get; set; }

	internal static TaskCompletionSource<object> InstantiationCompletion { get; set; }

	public static ServicesInitializationState State => default(ServicesInitializationState);

	public static string ExternalUserId
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static Task InitializeAsync()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__15))]
	[PreserveDependency("CaptureUnityThreadInfo()", "Unity.Services.Core.UnityThreadUtils", "Unity.Services.Core")]
	[PreserveDependency("EnableServicesInitializationAsync()", "Unity.Services.Core.Internal.UnityServicesInitializer", "Unity.Services.Core.Internal")]
	[PreserveDependency("CreateStaticInstance()", "Unity.Services.Core.Internal.UnityServicesInitializer", "Unity.Services.Core.Internal")]
	[PreserveDependency("Register()", "Unity.Services.Core.Registration.CorePackageInitializer", "Unity.Services.Core.Registration")]
	public static Task InitializeAsync(InitializationOptions options)
	{
		return null;
	}
}
