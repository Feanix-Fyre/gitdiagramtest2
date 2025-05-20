using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Newtonsoft.Json.Utilities;

internal class Base64Encoder
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CEncodeAsync_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Base64Encoder _003C_003E4__this;

		public byte[] buffer;

		public int index;

		public int count;

		public CancellationToken cancellationToken;

		private int _003Cnum4_003E5__2;

		private int _003Clength_003E5__3;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

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

	private const int Base64LineSize = 76;

	private const int LineSizeInBytes = 57;

	private readonly char[] _charsLine;

	private readonly TextWriter _writer;

	private byte[]? _leftOverBytes;

	private int _leftOverBytesCount;

	public Base64Encoder(TextWriter writer)
	{
	}

	private void ValidateEncode(byte[] buffer, int index, int count)
	{
	}

	public void Encode(byte[] buffer, int index, int count)
	{
	}

	private void StoreLeftOverBytes(byte[] buffer, int index, ref int count)
	{
	}

	private bool FulfillFromLeftover(byte[] buffer, int index, ref int count)
	{
		return false;
	}

	public void Flush()
	{
	}

	private void WriteChars(char[] chars, int index, int count)
	{
	}

	[AsyncStateMachine(typeof(_003CEncodeAsync_003Ed__13))]
	public Task EncodeAsync(byte[] buffer, int index, int count, CancellationToken cancellationToken)
	{
		return null;
	}

	private Task WriteCharsAsync(char[] chars, int index, int count, CancellationToken cancellationToken)
	{
		return null;
	}

	public Task FlushAsync(CancellationToken cancellationToken)
	{
		return null;
	}
}
