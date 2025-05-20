using System;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json;

public class JsonTextWriter : JsonWriter
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CCloseBufferAndWriterAsync_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JsonTextWriter _003C_003E4__this;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CDoCloseAsync_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JsonTextWriter _003C_003E4__this;

		public CancellationToken cancellationToken;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CDoWriteCommentAsync_003Ed__115 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JsonTextWriter _003C_003E4__this;

		public CancellationToken cancellationToken;

		public string text;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CDoWritePropertyNameAsync_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Task task;

		public JsonTextWriter _003C_003E4__this;

		public string name;

		public CancellationToken cancellationToken;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CDoWritePropertyNameAsync_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JsonTextWriter _003C_003E4__this;

		public string name;

		public CancellationToken cancellationToken;

		public bool escape;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CDoWriteRawValueAsync_003Ed__121 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Task task;

		public JsonTextWriter _003C_003E4__this;

		public string json;

		public CancellationToken cancellationToken;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CDoWriteStartArrayAsync_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Task task;

		public JsonTextWriter _003C_003E4__this;

		public CancellationToken cancellationToken;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CDoWriteStartConstructorAsync_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JsonTextWriter _003C_003E4__this;

		public CancellationToken cancellationToken;

		public string name;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CDoWriteStartObjectAsync_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Task task;

		public JsonTextWriter _003C_003E4__this;

		public CancellationToken cancellationToken;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CDoWriteUndefinedAsync_003Ed__43 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Task task;

		public JsonTextWriter _003C_003E4__this;

		public CancellationToken cancellationToken;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CDoWriteValueAsync_003Ed__60 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JsonTextWriter _003C_003E4__this;

		public CancellationToken cancellationToken;

		public DateTime value;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CDoWriteValueAsync_003Ed__64 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JsonTextWriter _003C_003E4__this;

		public CancellationToken cancellationToken;

		public DateTimeOffset value;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CDoWriteValueAsync_003Ed__78 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JsonTextWriter _003C_003E4__this;

		public CancellationToken cancellationToken;

		public Guid value;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CDoWriteValueAsync_003Ed__97 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Task task;

		public string value;

		public JsonTextWriter _003C_003E4__this;

		public CancellationToken cancellationToken;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CDoWriteValueAsync_003Ed__99 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JsonTextWriter _003C_003E4__this;

		public CancellationToken cancellationToken;

		public TimeSpan value;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CWriteIndentAsync_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JsonTextWriter _003C_003E4__this;

		public int newLineLen;

		public int currentIndentCount;

		public CancellationToken cancellationToken;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CWriteIntegerValueAsync_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Task task;

		public JsonTextWriter _003C_003E4__this;

		public ulong uvalue;

		public bool negative;

		public CancellationToken cancellationToken;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CWriteValueInternalAsync_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Task task;

		public JsonTextWriter _003C_003E4__this;

		public string value;

		public CancellationToken cancellationToken;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CWriteValueNonNullAsync_003Ed__54 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JsonTextWriter _003C_003E4__this;

		public CancellationToken cancellationToken;

		public byte[] value;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CWriteValueNotNullAsync_003Ed__110 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Task task;

		public JsonTextWriter _003C_003E4__this;

		public Uri value;

		public CancellationToken cancellationToken;

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

	private readonly bool _safeAsync;

	private const int IndentCharBufferSize = 12;

	private readonly TextWriter _writer;

	private Base64Encoder? _base64Encoder;

	private char _indentChar;

	private int _indentation;

	private char _quoteChar;

	private bool _quoteName;

	private bool[]? _charEscapeFlags;

	private char[]? _writeBuffer;

	private IArrayPool<char>? _arrayPool;

	private char[]? _indentChars;

	private Base64Encoder Base64Encoder => null;

	public IArrayPool<char>? ArrayPool
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int Indentation
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public char QuoteChar
	{
		get
		{
			return '\0';
		}
		set
		{
		}
	}

	public char IndentChar
	{
		get
		{
			return '\0';
		}
		set
		{
		}
	}

	public bool QuoteName
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override Task FlushAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task DoFlushAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	protected override Task WriteValueDelimiterAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	internal Task DoWriteValueDelimiterAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	protected override Task WriteEndAsync(JsonToken token, CancellationToken cancellationToken)
	{
		return null;
	}

	internal Task DoWriteEndAsync(JsonToken token, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task CloseAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CDoCloseAsync_003Ed__8))]
	internal Task DoCloseAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CCloseBufferAndWriterAsync_003Ed__9))]
	private Task CloseBufferAndWriterAsync()
	{
		return null;
	}

	public override Task WriteEndAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	protected override Task WriteIndentAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	internal Task DoWriteIndentAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CWriteIndentAsync_003Ed__13))]
	private Task WriteIndentAsync(int currentIndentCount, int newLineLen, CancellationToken cancellationToken)
	{
		return null;
	}

	private Task WriteValueInternalAsync(JsonToken token, string value, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CWriteValueInternalAsync_003Ed__15))]
	private Task WriteValueInternalAsync(Task task, string value, CancellationToken cancellationToken)
	{
		return null;
	}

	protected override Task WriteIndentSpaceAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	internal Task DoWriteIndentSpaceAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteRawAsync(string? json, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task DoWriteRawAsync(string? json, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteNullAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task DoWriteNullAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	private Task WriteDigitsAsync(ulong uvalue, bool negative, CancellationToken cancellationToken)
	{
		return null;
	}

	private Task WriteIntegerValueAsync(ulong uvalue, bool negative, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CWriteIntegerValueAsync_003Ed__24))]
	private Task WriteIntegerValueAsync(Task task, ulong uvalue, bool negative, CancellationToken cancellationToken)
	{
		return null;
	}

	internal Task WriteIntegerValueAsync(long value, CancellationToken cancellationToken)
	{
		return null;
	}

	internal Task WriteIntegerValueAsync(ulong uvalue, CancellationToken cancellationToken)
	{
		return null;
	}

	private Task WriteEscapedStringAsync(string value, bool quote, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WritePropertyNameAsync(string name, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task DoWritePropertyNameAsync(string name, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CDoWritePropertyNameAsync_003Ed__30))]
	private Task DoWritePropertyNameAsync(Task task, string name, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WritePropertyNameAsync(string name, bool escape, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CDoWritePropertyNameAsync_003Ed__32))]
	internal Task DoWritePropertyNameAsync(string name, bool escape, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteStartArrayAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task DoWriteStartArrayAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CDoWriteStartArrayAsync_003Ed__35))]
	internal Task DoWriteStartArrayAsync(Task task, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteStartObjectAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task DoWriteStartObjectAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CDoWriteStartObjectAsync_003Ed__38))]
	internal Task DoWriteStartObjectAsync(Task task, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteStartConstructorAsync(string name, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CDoWriteStartConstructorAsync_003Ed__40))]
	internal Task DoWriteStartConstructorAsync(string name, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteUndefinedAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task DoWriteUndefinedAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CDoWriteUndefinedAsync_003Ed__43))]
	private Task DoWriteUndefinedAsync(Task task, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteWhitespaceAsync(string ws, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task DoWriteWhitespaceAsync(string ws, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteValueAsync(bool value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task DoWriteValueAsync(bool value, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteValueAsync(bool? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task DoWriteValueAsync(bool? value, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteValueAsync(byte value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public override Task WriteValueAsync(byte? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task DoWriteValueAsync(byte? value, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteValueAsync(byte[]? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CWriteValueNonNullAsync_003Ed__54))]
	internal Task WriteValueNonNullAsync(byte[] value, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteValueAsync(char value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task DoWriteValueAsync(char value, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteValueAsync(char? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task DoWriteValueAsync(char? value, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteValueAsync(DateTime value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CDoWriteValueAsync_003Ed__60))]
	internal Task DoWriteValueAsync(DateTime value, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteValueAsync(DateTime? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task DoWriteValueAsync(DateTime? value, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteValueAsync(DateTimeOffset value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CDoWriteValueAsync_003Ed__64))]
	internal Task DoWriteValueAsync(DateTimeOffset value, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteValueAsync(DateTimeOffset? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task DoWriteValueAsync(DateTimeOffset? value, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteValueAsync(decimal value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task DoWriteValueAsync(decimal value, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteValueAsync(decimal? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task DoWriteValueAsync(decimal? value, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteValueAsync(double value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task WriteValueAsync(double value, bool nullable, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteValueAsync(double? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public override Task WriteValueAsync(float value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task WriteValueAsync(float value, bool nullable, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteValueAsync(float? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public override Task WriteValueAsync(Guid value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CDoWriteValueAsync_003Ed__78))]
	internal Task DoWriteValueAsync(Guid value, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteValueAsync(Guid? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task DoWriteValueAsync(Guid? value, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteValueAsync(int value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public override Task WriteValueAsync(int? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task DoWriteValueAsync(int? value, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteValueAsync(long value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public override Task WriteValueAsync(long? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task DoWriteValueAsync(long? value, CancellationToken cancellationToken)
	{
		return null;
	}

	internal Task WriteValueAsync(BigInteger value, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteValueAsync(object? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[CLSCompliant(false)]
	public override Task WriteValueAsync(sbyte value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[CLSCompliant(false)]
	public override Task WriteValueAsync(sbyte? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task DoWriteValueAsync(sbyte? value, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteValueAsync(short value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public override Task WriteValueAsync(short? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task DoWriteValueAsync(short? value, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteValueAsync(string? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task DoWriteValueAsync(string? value, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CDoWriteValueAsync_003Ed__97))]
	private Task DoWriteValueAsync(Task task, string? value, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteValueAsync(TimeSpan value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CDoWriteValueAsync_003Ed__99))]
	internal Task DoWriteValueAsync(TimeSpan value, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteValueAsync(TimeSpan? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task DoWriteValueAsync(TimeSpan? value, CancellationToken cancellationToken)
	{
		return null;
	}

	[CLSCompliant(false)]
	public override Task WriteValueAsync(uint value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[CLSCompliant(false)]
	public override Task WriteValueAsync(uint? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task DoWriteValueAsync(uint? value, CancellationToken cancellationToken)
	{
		return null;
	}

	[CLSCompliant(false)]
	public override Task WriteValueAsync(ulong value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[CLSCompliant(false)]
	public override Task WriteValueAsync(ulong? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task DoWriteValueAsync(ulong? value, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteValueAsync(Uri? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task WriteValueNotNullAsync(Uri value, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CWriteValueNotNullAsync_003Ed__110))]
	internal Task WriteValueNotNullAsync(Task task, Uri value, CancellationToken cancellationToken)
	{
		return null;
	}

	[CLSCompliant(false)]
	public override Task WriteValueAsync(ushort value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[CLSCompliant(false)]
	public override Task WriteValueAsync(ushort? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task DoWriteValueAsync(ushort? value, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteCommentAsync(string? text, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CDoWriteCommentAsync_003Ed__115))]
	internal Task DoWriteCommentAsync(string? text, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteEndArrayAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public override Task WriteEndConstructorAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public override Task WriteEndObjectAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public override Task WriteRawValueAsync(string? json, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task DoWriteRawValueAsync(string? json, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CDoWriteRawValueAsync_003Ed__121))]
	private Task DoWriteRawValueAsync(Task task, string? json, CancellationToken cancellationToken)
	{
		return null;
	}

	internal char[] EnsureWriteBuffer(int length, int copyTo)
	{
		return null;
	}

	public JsonTextWriter(TextWriter textWriter)
	{
	}

	public override void Flush()
	{
	}

	public override void Close()
	{
	}

	private void CloseBufferAndWriter()
	{
	}

	public override void WriteStartObject()
	{
	}

	public override void WriteStartArray()
	{
	}

	public override void WriteStartConstructor(string name)
	{
	}

	protected override void WriteEnd(JsonToken token)
	{
	}

	public override void WritePropertyName(string name)
	{
	}

	public override void WritePropertyName(string name, bool escape)
	{
	}

	internal override void OnStringEscapeHandlingChanged()
	{
	}

	private void UpdateCharEscapeFlags()
	{
	}

	protected override void WriteIndent()
	{
	}

	private int SetIndentChars()
	{
		return 0;
	}

	protected override void WriteValueDelimiter()
	{
	}

	protected override void WriteIndentSpace()
	{
	}

	private void WriteValueInternal(string value, JsonToken token)
	{
	}

	public override void WriteValue(object? value)
	{
	}

	public override void WriteNull()
	{
	}

	public override void WriteUndefined()
	{
	}

	public override void WriteRaw(string? json)
	{
	}

	public override void WriteValue(string? value)
	{
	}

	private void WriteEscapedString(string value, bool quote)
	{
	}

	public override void WriteValue(int value)
	{
	}

	[CLSCompliant(false)]
	public override void WriteValue(uint value)
	{
	}

	public override void WriteValue(long value)
	{
	}

	[CLSCompliant(false)]
	public override void WriteValue(ulong value)
	{
	}

	public override void WriteValue(float value)
	{
	}

	public override void WriteValue(float? value)
	{
	}

	public override void WriteValue(double value)
	{
	}

	public override void WriteValue(double? value)
	{
	}

	public override void WriteValue(bool value)
	{
	}

	public override void WriteValue(short value)
	{
	}

	[CLSCompliant(false)]
	public override void WriteValue(ushort value)
	{
	}

	public override void WriteValue(char value)
	{
	}

	public override void WriteValue(byte value)
	{
	}

	[CLSCompliant(false)]
	public override void WriteValue(sbyte value)
	{
	}

	public override void WriteValue(decimal value)
	{
	}

	public override void WriteValue(DateTime value)
	{
	}

	private int WriteValueToBuffer(DateTime value)
	{
		return 0;
	}

	public override void WriteValue(byte[]? value)
	{
	}

	public override void WriteValue(DateTimeOffset value)
	{
	}

	private int WriteValueToBuffer(DateTimeOffset value)
	{
		return 0;
	}

	public override void WriteValue(Guid value)
	{
	}

	public override void WriteValue(TimeSpan value)
	{
	}

	public override void WriteValue(Uri? value)
	{
	}

	public override void WriteComment(string? text)
	{
	}

	public override void WriteWhitespace(string ws)
	{
	}

	private void EnsureWriteBuffer()
	{
	}

	private void WriteIntegerValue(long value)
	{
	}

	private void WriteIntegerValue(ulong value, bool negative)
	{
	}

	private int WriteNumberToBuffer(ulong value, bool negative)
	{
		return 0;
	}

	private void WriteIntegerValue(int value)
	{
	}

	private void WriteIntegerValue(uint value, bool negative)
	{
	}

	private int WriteNumberToBuffer(uint value, bool negative)
	{
		return 0;
	}
}
