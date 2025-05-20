using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Unity.Services.Core.Configuration;
using Unity.Services.Core.Configuration.Internal;
using Unity.Services.Core.Device;
using Unity.Services.Core.Environments.Internal;
using Unity.Services.Core.Internal;
using Unity.Services.Core.Internal.Serialization;
using Unity.Services.Core.Scheduler.Internal;
using Unity.Services.Core.Telemetry.Internal;
using Unity.Services.Core.Threading.Internal;
using UnityEngine;

namespace Unity.Services.Core.Registration;

internal class CorePackageInitializer : IInitializablePackageV2, IInitializablePackage, IDiagnosticsComponentProvider
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CCreateDiagnosticsComponents_003Ed__61 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IDiagnosticsFactory> _003C_003Et__builder;

		public CorePackageInitializer _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CGenerateProjectConfigurationAsync_003Ed__53 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ProjectConfiguration> _003C_003Et__builder;

		public InitializationOptions options;

		public CorePackageInitializer _003C_003E4__this;

		private TaskAwaiter<SerializableProjectConfiguration> _003C_003Eu__1;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CGetSerializedConfigOrEmptyAsync_003Ed__54 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<SerializableProjectConfiguration> _003C_003Et__builder;

		private TaskAwaiter<SerializableProjectConfiguration> _003C_003Eu__1;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CGetSerializedProjectConfigurationAsync_003Ed__63 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public CorePackageInitializer _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CInitializeComponents_003Ed__47 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CorePackageInitializer _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CInitializeProjectConfigAsync_003Ed__52 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CorePackageInitializer _003C_003E4__this;

		public InitializationOptions options;

		private TaskAwaiter<ProjectConfiguration> _003C_003Eu__1;

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

	private CoreRegistry m_Registry;

	private readonly IJsonSerializer m_Serializer;

	private InitializationOptions m_CurrentInitializationOptions;

	internal ActionScheduler ActionScheduler { get; private set; }

	internal InstallationId InstallationId { get; private set; }

	internal ProjectConfiguration ProjectConfig { get; private set; }

	internal Unity.Services.Core.Environments.Internal.Environments Environments { get; private set; }

	internal ExternalUserId ExternalUserId { get; private set; }

	internal ICloudProjectId CloudProjectId { get; private set; }

	internal IDiagnosticsFactory DiagnosticsFactory { get; private set; }

	internal IMetricsFactory MetricsFactory { get; private set; }

	internal UnityThreadUtilsInternal UnityThreadUtils { get; private set; }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	private static void InitializeOnLoad()
	{
	}

	public void Register(CorePackageRegistry registry)
	{
	}

	public CorePackageInitializer(IJsonSerializer serializer)
	{
	}

	public Task Initialize(CoreRegistry registry)
	{
		return null;
	}

	public Task InitializeInstanceAsync(CoreRegistry registry)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CInitializeComponents_003Ed__47))]
	private Task InitializeComponents()
	{
		return null;
	}

	private bool HaveInitOptionsChanged()
	{
		return false;
	}

	private void FreeOptionsDependantComponents()
	{
	}

	internal void InitializeInstallationId()
	{
	}

	internal void InitializeActionScheduler()
	{
	}

	[AsyncStateMachine(typeof(_003CInitializeProjectConfigAsync_003Ed__52))]
	internal Task InitializeProjectConfigAsync([NotNull] InitializationOptions options)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CGenerateProjectConfigurationAsync_003Ed__53))]
	internal Task<ProjectConfiguration> GenerateProjectConfigurationAsync([NotNull] InitializationOptions options)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CGetSerializedConfigOrEmptyAsync_003Ed__54))]
	internal static Task<SerializableProjectConfiguration> GetSerializedConfigOrEmptyAsync()
	{
		return null;
	}

	internal void InitializeExternalUserId(IProjectConfiguration projectConfiguration)
	{
	}

	internal void InitializeEnvironments(IProjectConfiguration projectConfiguration)
	{
	}

	internal void InitializeMetrics()
	{
	}

	internal void InitializeDiagnostics()
	{
	}

	internal void InitializeCloudProjectId(ICloudProjectId cloudProjectId = null)
	{
	}

	internal void InitializeUnityThreadUtils()
	{
	}

	[AsyncStateMachine(typeof(_003CCreateDiagnosticsComponents_003Ed__61))]
	public Task<IDiagnosticsFactory> CreateDiagnosticsComponents()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CGetSerializedProjectConfigurationAsync_003Ed__63))]
	public Task<string> GetSerializedProjectConfigurationAsync()
	{
		return null;
	}
}
