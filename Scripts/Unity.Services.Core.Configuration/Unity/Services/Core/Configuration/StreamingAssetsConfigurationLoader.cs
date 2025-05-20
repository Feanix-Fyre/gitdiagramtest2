using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Unity.Services.Core.Internal.Serialization;

namespace Unity.Services.Core.Configuration;

internal class StreamingAssetsConfigurationLoader : IConfigurationLoader
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CGetConfigAsync_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<SerializableProjectConfiguration> _003C_003Et__builder;

		public StreamingAssetsConfigurationLoader _003C_003E4__this;

		private TaskAwaiter<string> _003C_003Eu__1;

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

	private readonly IJsonSerializer m_Serializer;

	public StreamingAssetsConfigurationLoader(IJsonSerializer serializer)
	{
	}

	[AsyncStateMachine(typeof(_003CGetConfigAsync_003Ed__2))]
	public Task<SerializableProjectConfiguration> GetConfigAsync()
	{
		return null;
	}
}
