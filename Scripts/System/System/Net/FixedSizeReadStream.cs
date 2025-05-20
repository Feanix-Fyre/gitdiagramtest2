using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net;

internal class FixedSizeReadStream : WebReadStream
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CProcessReadAsync_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

		public CancellationToken cancellationToken;

		public FixedSizeReadStream _003C_003E4__this;

		public int size;

		public byte[] buffer;

		public int offset;

		private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter _003C_003Eu__1;

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

	private long position;

	public long ContentLength { get; }

	public FixedSizeReadStream(WebOperation operation, Stream innerStream, long contentLength)
		: base(null, null)
	{
	}

	[AsyncStateMachine(typeof(_003CProcessReadAsync_003Ed__5))]
	protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
	{
		return null;
	}
}
