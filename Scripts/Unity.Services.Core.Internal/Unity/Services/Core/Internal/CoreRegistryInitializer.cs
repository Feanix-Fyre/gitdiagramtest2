using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace Unity.Services.Core.Internal;

internal class CoreRegistryInitializer
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public Stopwatch stopwatch;

		public List<PackageInitializationInfo> packagesInitInfos;

		public List<Exception> failureReasons;

		public CoreRegistryInitializer _003C_003E4__this;

		public DependencyTree dependencyTree;
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CInitializeRegistryAsync_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<PackageInitializationInfo>> _003C_003Et__builder;

		public CoreRegistryInitializer _003C_003E4__this;

		private _003C_003Ec__DisplayClass3_0 _003C_003E8__1;

		private int _003Ci_003E5__2;

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

	[NotNull]
	private readonly CoreRegistry m_Registry;

	[NotNull]
	private readonly List<int> m_SortedPackageTypeHashes;

	public CoreRegistryInitializer([NotNull] CoreRegistry registry, [NotNull] List<int> sortedPackageTypeHashes)
	{
	}

	[AsyncStateMachine(typeof(_003CInitializeRegistryAsync_003Ed__3))]
	public Task<List<PackageInitializationInfo>> InitializeRegistryAsync()
	{
		return null;
	}
}
