using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json;

public class JsonTextReader : JsonReader, IJsonLineInfo
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CDoReadAsBooleanAsync_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool?> _003C_003Et__builder;

		public JsonTextReader _003C_003E4__this;

		public CancellationToken cancellationToken;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private BigInteger _003Ci_003E5__2;

		private bool _003CisTrue_003E5__3;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__2;

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
	private struct _003CDoReadAsBytesAsync_003Ed__42 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<byte[]> _003C_003Et__builder;

		public JsonTextReader _003C_003E4__this;

		public CancellationToken cancellationToken;

		private bool _003CisWrapped_003E5__2;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private byte[] _003Cdata_003E5__3;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__2;

		private ConfiguredTaskAwaitable<byte[]?>.ConfiguredTaskAwaiter _003C_003Eu__3;

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
	private struct _003CDoReadAsDateTimeAsync_003Ed__45 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<DateTime?> _003C_003Et__builder;

		public JsonTextReader _003C_003E4__this;

		public CancellationToken cancellationToken;

		private ConfiguredTaskAwaitable<object?>.ConfiguredTaskAwaiter _003C_003Eu__1;

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
	private struct _003CDoReadAsDateTimeOffsetAsync_003Ed__47 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<DateTimeOffset?> _003C_003Et__builder;

		public JsonTextReader _003C_003E4__this;

		public CancellationToken cancellationToken;

		private ConfiguredTaskAwaitable<object?>.ConfiguredTaskAwaiter _003C_003Eu__1;

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
	private struct _003CDoReadAsDecimalAsync_003Ed__49 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<decimal?> _003C_003Et__builder;

		public JsonTextReader _003C_003E4__this;

		public CancellationToken cancellationToken;

		private ConfiguredTaskAwaitable<object?>.ConfiguredTaskAwaiter _003C_003Eu__1;

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
	private struct _003CDoReadAsDoubleAsync_003Ed__51 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<double?> _003C_003Et__builder;

		public JsonTextReader _003C_003E4__this;

		public CancellationToken cancellationToken;

		private ConfiguredTaskAwaitable<object?>.ConfiguredTaskAwaiter _003C_003Eu__1;

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
	private struct _003CDoReadAsInt32Async_003Ed__53 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<int?> _003C_003Et__builder;

		public JsonTextReader _003C_003E4__this;

		public CancellationToken cancellationToken;

		private ConfiguredTaskAwaitable<object?>.ConfiguredTaskAwaiter _003C_003Eu__1;

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
	private struct _003CDoReadAsStringAsync_003Ed__55 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public JsonTextReader _003C_003E4__this;

		public CancellationToken cancellationToken;

		private ConfiguredTaskAwaitable<object?>.ConfiguredTaskAwaiter _003C_003Eu__1;

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
	private struct _003CDoReadAsync_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public Task<bool> task;

		public JsonTextReader _003C_003E4__this;

		public CancellationToken cancellationToken;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

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
	private struct _003CEatWhitespaceAsync_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JsonTextReader _003C_003E4__this;

		public CancellationToken cancellationToken;

		private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__2;

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
	private struct _003CHandleNullAsync_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JsonTextReader _003C_003E4__this;

		public CancellationToken cancellationToken;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__2;

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
	private struct _003CMatchAndSetAsync_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JsonTextReader _003C_003E4__this;

		public string value;

		public CancellationToken cancellationToken;

		public JsonToken newToken;

		public object tokenValue;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

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
	private struct _003CMatchValueAsync_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public JsonTextReader _003C_003E4__this;

		public string value;

		public CancellationToken cancellationToken;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

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
	private struct _003CMatchValueWithTrailingSeparatorAsync_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public JsonTextReader _003C_003E4__this;

		public string value;

		public CancellationToken cancellationToken;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

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
	private struct _003CParseCommentAsync_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JsonTextReader _003C_003E4__this;

		public CancellationToken cancellationToken;

		public bool setToken;

		private bool _003CsinglelineComment_003E5__2;

		private int _003CinitialPosition_003E5__3;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter _003C_003Eu__2;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__3;

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
	private struct _003CParseConstructorAsync_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JsonTextReader _003C_003E4__this;

		public CancellationToken cancellationToken;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private int _003CinitialPosition_003E5__2;

		private int _003CendPosition_003E5__3;

		private string _003CconstructorName_003E5__4;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__2;

		private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter _003C_003Eu__3;

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
	private struct _003CParseNumberAsync_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JsonTextReader _003C_003E4__this;

		public CancellationToken cancellationToken;

		public ReadType readType;

		private char _003CfirstChar_003E5__2;

		private int _003CinitialPosition_003E5__3;

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
	private struct _003CParseNumberNaNAsync_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<object> _003C_003Et__builder;

		public ReadType readType;

		public JsonTextReader _003C_003E4__this;

		public CancellationToken cancellationToken;

		private ReadType _003C_003E7__wrap1;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

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
	private struct _003CParseNumberNegativeInfinityAsync_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<object> _003C_003Et__builder;

		public ReadType readType;

		public JsonTextReader _003C_003E4__this;

		public CancellationToken cancellationToken;

		private ReadType _003C_003E7__wrap1;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

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
	private struct _003CParseNumberPositiveInfinityAsync_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<object> _003C_003Et__builder;

		public ReadType readType;

		public JsonTextReader _003C_003E4__this;

		public CancellationToken cancellationToken;

		private ReadType _003C_003E7__wrap1;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

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
	private struct _003CParseObjectAsync_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public JsonTextReader _003C_003E4__this;

		public CancellationToken cancellationToken;

		private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__2;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__3;

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
	private struct _003CParsePostValueAsync_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public JsonTextReader _003C_003E4__this;

		public CancellationToken cancellationToken;

		public bool ignoreComments;

		private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__2;

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
	private struct _003CParsePropertyAsync_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public JsonTextReader _003C_003E4__this;

		public CancellationToken cancellationToken;

		private char _003CquoteChar_003E5__2;

		private string _003CpropertyName_003E5__3;

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
	private struct _003CParseStringAsync_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CancellationToken cancellationToken;

		public JsonTextReader _003C_003E4__this;

		public char quote;

		public ReadType readType;

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
	private struct _003CParseUnicodeAsync_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<char> _003C_003Et__builder;

		public JsonTextReader _003C_003E4__this;

		public CancellationToken cancellationToken;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

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
	private struct _003CParseUnquotedPropertyAsync_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JsonTextReader _003C_003E4__this;

		public CancellationToken cancellationToken;

		private int _003CinitialPosition_003E5__2;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CParseValueAsync_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public JsonTextReader _003C_003E4__this;

		public CancellationToken cancellationToken;

		private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__2;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__3;

		private ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter _003C_003Eu__4;

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
	private struct _003CProcessCarriageReturnAsync_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Task<bool> task;

		public JsonTextReader _003C_003E4__this;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

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
	private struct _003CReadCharsAsync_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public JsonTextReader _003C_003E4__this;

		public int relativePosition;

		public bool append;

		public CancellationToken cancellationToken;

		private int _003CcharsRequired_003E5__2;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CReadDataAsync_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

		public JsonTextReader _003C_003E4__this;

		public bool append;

		public int charsRequired;

		public CancellationToken cancellationToken;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CReadFinishedAsync_003Ed__36 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JsonTextReader _003C_003E4__this;

		public CancellationToken cancellationToken;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__2;

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
	private struct _003CReadFromFinishedAsync_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public JsonTextReader _003C_003E4__this;

		public CancellationToken cancellationToken;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__2;

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
	private struct _003CReadIntoWrappedTypeObjectAsync_003Ed__43 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JsonTextReader _003C_003E4__this;

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
	private struct _003CReadNullCharAsync_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public JsonTextReader _003C_003E4__this;

		public CancellationToken cancellationToken;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CReadNumberIntoBufferAsync_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JsonTextReader _003C_003E4__this;

		public CancellationToken cancellationToken;

		private int _003CcharPos_003E5__2;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CReadNumberValueAsync_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<object> _003C_003Et__builder;

		public JsonTextReader _003C_003E4__this;

		public CancellationToken cancellationToken;

		public ReadType readType;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__2;

		private ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter _003C_003Eu__3;

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
	private struct _003CReadStringIntoBufferAsync_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JsonTextReader _003C_003E4__this;

		public CancellationToken cancellationToken;

		public char quote;

		private int _003CcharPos_003E5__2;

		private int _003CinitialPosition_003E5__3;

		private int _003ClastWritePosition_003E5__4;

		private int _003CescapeStartPos_003E5__5;

		private char _003CwriteChar_003E5__6;

		private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__2;

		private ConfiguredTaskAwaitable<char>.ConfiguredTaskAwaiter _003C_003Eu__3;

		private bool _003CanotherHighSurrogate_003E5__7;

		private char _003ChighSurrogate_003E5__8;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__4;

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
	private struct _003CReadStringValueAsync_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<object> _003C_003Et__builder;

		public JsonTextReader _003C_003E4__this;

		public CancellationToken cancellationToken;

		public ReadType readType;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private string _003Cexpected_003E5__2;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__2;

		private ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter _003C_003Eu__3;

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

	private const char UnicodeReplacementChar = '\ufffd';

	private const int MaximumJavascriptIntegerCharacterLength = 380;

	private const int LargeBufferLength = 1073741823;

	private readonly TextReader _reader;

	private char[]? _chars;

	private int _charsUsed;

	private int _charPos;

	private int _lineStartPos;

	private int _lineNumber;

	private bool _isEndOfFile;

	private StringBuffer _stringBuffer;

	private StringReference _stringReference;

	private IArrayPool<char>? _arrayPool;

	public JsonNameTable? PropertyNameTable { get; set; }

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

	public int LineNumber => 0;

	public int LinePosition => 0;

	public override Task<bool> ReadAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task<bool> DoReadAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CDoReadAsync_003Ed__3))]
	private Task<bool> DoReadAsync(Task<bool> task, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CParsePostValueAsync_003Ed__4))]
	private Task<bool> ParsePostValueAsync(bool ignoreComments, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CReadFromFinishedAsync_003Ed__5))]
	private Task<bool> ReadFromFinishedAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	private Task<int> ReadDataAsync(bool append, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CReadDataAsync_003Ed__7))]
	private Task<int> ReadDataAsync(bool append, int charsRequired, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CParseValueAsync_003Ed__8))]
	private Task<bool> ParseValueAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CReadStringIntoBufferAsync_003Ed__9))]
	private Task ReadStringIntoBufferAsync(char quote, CancellationToken cancellationToken)
	{
		return null;
	}

	private Task ProcessCarriageReturnAsync(bool append, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CProcessCarriageReturnAsync_003Ed__11))]
	private Task ProcessCarriageReturnAsync(Task<bool> task)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CParseUnicodeAsync_003Ed__12))]
	private Task<char> ParseUnicodeAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	private Task<bool> EnsureCharsAsync(int relativePosition, bool append, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CReadCharsAsync_003Ed__14))]
	private Task<bool> ReadCharsAsync(int relativePosition, bool append, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CParseObjectAsync_003Ed__15))]
	private Task<bool> ParseObjectAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CParseCommentAsync_003Ed__16))]
	private Task ParseCommentAsync(bool setToken, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CEatWhitespaceAsync_003Ed__17))]
	private Task EatWhitespaceAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CParseStringAsync_003Ed__18))]
	private Task ParseStringAsync(char quote, ReadType readType, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CMatchValueAsync_003Ed__19))]
	private Task<bool> MatchValueAsync(string value, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CMatchValueWithTrailingSeparatorAsync_003Ed__20))]
	private Task<bool> MatchValueWithTrailingSeparatorAsync(string value, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CMatchAndSetAsync_003Ed__21))]
	private Task MatchAndSetAsync(string value, JsonToken newToken, object? tokenValue, CancellationToken cancellationToken)
	{
		return null;
	}

	private Task ParseTrueAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	private Task ParseFalseAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	private Task ParseNullAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CParseConstructorAsync_003Ed__25))]
	private Task ParseConstructorAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CParseNumberNaNAsync_003Ed__26))]
	private Task<object> ParseNumberNaNAsync(ReadType readType, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CParseNumberPositiveInfinityAsync_003Ed__27))]
	private Task<object> ParseNumberPositiveInfinityAsync(ReadType readType, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CParseNumberNegativeInfinityAsync_003Ed__28))]
	private Task<object> ParseNumberNegativeInfinityAsync(ReadType readType, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CParseNumberAsync_003Ed__29))]
	private Task ParseNumberAsync(ReadType readType, CancellationToken cancellationToken)
	{
		return null;
	}

	private Task ParseUndefinedAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CParsePropertyAsync_003Ed__31))]
	private Task<bool> ParsePropertyAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CReadNumberIntoBufferAsync_003Ed__32))]
	private Task ReadNumberIntoBufferAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CParseUnquotedPropertyAsync_003Ed__33))]
	private Task ParseUnquotedPropertyAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CReadNullCharAsync_003Ed__34))]
	private Task<bool> ReadNullCharAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CHandleNullAsync_003Ed__35))]
	private Task HandleNullAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CReadFinishedAsync_003Ed__36))]
	private Task ReadFinishedAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CReadStringValueAsync_003Ed__37))]
	private Task<object> ReadStringValueAsync(ReadType readType, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CReadNumberValueAsync_003Ed__38))]
	private Task<object> ReadNumberValueAsync(ReadType readType, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task<bool?> ReadAsBooleanAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CDoReadAsBooleanAsync_003Ed__40))]
	internal Task<bool?> DoReadAsBooleanAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task<byte[]> ReadAsBytesAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CDoReadAsBytesAsync_003Ed__42))]
	internal Task<byte[]> DoReadAsBytesAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CReadIntoWrappedTypeObjectAsync_003Ed__43))]
	private Task ReadIntoWrappedTypeObjectAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task<DateTime?> ReadAsDateTimeAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CDoReadAsDateTimeAsync_003Ed__45))]
	internal Task<DateTime?> DoReadAsDateTimeAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task<DateTimeOffset?> ReadAsDateTimeOffsetAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CDoReadAsDateTimeOffsetAsync_003Ed__47))]
	internal Task<DateTimeOffset?> DoReadAsDateTimeOffsetAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task<decimal?> ReadAsDecimalAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CDoReadAsDecimalAsync_003Ed__49))]
	internal Task<decimal?> DoReadAsDecimalAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task<double?> ReadAsDoubleAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CDoReadAsDoubleAsync_003Ed__51))]
	internal Task<double?> DoReadAsDoubleAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task<int?> ReadAsInt32Async(CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CDoReadAsInt32Async_003Ed__53))]
	internal Task<int?> DoReadAsInt32Async(CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task<string> ReadAsStringAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CDoReadAsStringAsync_003Ed__55))]
	internal Task<string> DoReadAsStringAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	public JsonTextReader(TextReader reader)
	{
	}

	private void EnsureBufferNotEmpty()
	{
	}

	private void SetNewLine(bool hasNextChar)
	{
	}

	private void OnNewLine(int pos)
	{
	}

	private void ParseString(char quote, ReadType readType)
	{
	}

	private void ParseReadString(char quote, ReadType readType)
	{
	}

	private static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count)
	{
	}

	private void ShiftBufferIfNeeded()
	{
	}

	private int ReadData(bool append)
	{
		return 0;
	}

	private void PrepareBufferForReadData(bool append, int charsRequired)
	{
	}

	private int ReadData(bool append, int charsRequired)
	{
		return 0;
	}

	private bool EnsureChars(int relativePosition, bool append)
	{
		return false;
	}

	private bool ReadChars(int relativePosition, bool append)
	{
		return false;
	}

	public override bool Read()
	{
		return false;
	}

	public override int? ReadAsInt32()
	{
		return null;
	}

	public override DateTime? ReadAsDateTime()
	{
		return null;
	}

	public override string? ReadAsString()
	{
		return null;
	}

	public override byte[]? ReadAsBytes()
	{
		return null;
	}

	private object? ReadStringValue(ReadType readType)
	{
		return null;
	}

	private object? FinishReadQuotedStringValue(ReadType readType)
	{
		return null;
	}

	private JsonReaderException CreateUnexpectedCharacterException(char c)
	{
		return null;
	}

	public override bool? ReadAsBoolean()
	{
		return null;
	}

	private void ProcessValueComma()
	{
	}

	private object? ReadNumberValue(ReadType readType)
	{
		return null;
	}

	private object? FinishReadQuotedNumber(ReadType readType)
	{
		return null;
	}

	public override DateTimeOffset? ReadAsDateTimeOffset()
	{
		return null;
	}

	public override decimal? ReadAsDecimal()
	{
		return null;
	}

	public override double? ReadAsDouble()
	{
		return null;
	}

	private void HandleNull()
	{
	}

	private void ReadFinished()
	{
	}

	private bool ReadNullChar()
	{
		return false;
	}

	private void EnsureBuffer()
	{
	}

	private void ReadStringIntoBuffer(char quote)
	{
	}

	private void FinishReadStringIntoBuffer(int charPos, int initialPosition, int lastWritePosition)
	{
	}

	private void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition)
	{
	}

	private char ConvertUnicode(bool enoughChars)
	{
		return '\0';
	}

	private char ParseUnicode()
	{
		return '\0';
	}

	private void ReadNumberIntoBuffer()
	{
	}

	private bool ReadNumberCharIntoBuffer(char currentChar, int charPos)
	{
		return false;
	}

	private void ClearRecentString()
	{
	}

	private bool ParsePostValue(bool ignoreComments)
	{
		return false;
	}

	private bool ParseObject()
	{
		return false;
	}

	private bool ParseProperty()
	{
		return false;
	}

	private bool ValidIdentifierChar(char value)
	{
		return false;
	}

	private void ParseUnquotedProperty()
	{
	}

	private bool ReadUnquotedPropertyReportIfDone(char currentChar, int initialPosition)
	{
		return false;
	}

	private bool ParseValue()
	{
		return false;
	}

	private void ProcessLineFeed()
	{
	}

	private void ProcessCarriageReturn(bool append)
	{
	}

	private void EatWhitespace()
	{
	}

	private void ParseConstructor()
	{
	}

	private void ParseNumber(ReadType readType)
	{
	}

	private void ParseReadNumber(ReadType readType, char firstChar, int initialPosition)
	{
	}

	private JsonReaderException ThrowReaderError(string message, Exception? ex = null)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object BigIntegerParse(string number, CultureInfo culture)
	{
		return null;
	}

	private void ParseComment(bool setToken)
	{
	}

	private void EndComment(bool setToken, int initialPosition, int endPosition)
	{
	}

	private bool MatchValue(string value)
	{
		return false;
	}

	private bool MatchValue(bool enoughChars, string value)
	{
		return false;
	}

	private bool MatchValueWithTrailingSeparator(string value)
	{
		return false;
	}

	private bool IsSeparator(char c)
	{
		return false;
	}

	private void ParseTrue()
	{
	}

	private void ParseNull()
	{
	}

	private void ParseUndefined()
	{
	}

	private void ParseFalse()
	{
	}

	private object ParseNumberNegativeInfinity(ReadType readType)
	{
		return null;
	}

	private object ParseNumberNegativeInfinity(ReadType readType, bool matched)
	{
		return null;
	}

	private object ParseNumberPositiveInfinity(ReadType readType)
	{
		return null;
	}

	private object ParseNumberPositiveInfinity(ReadType readType, bool matched)
	{
		return null;
	}

	private object ParseNumberNaN(ReadType readType)
	{
		return null;
	}

	private object ParseNumberNaN(ReadType readType, bool matched)
	{
		return null;
	}

	public override void Close()
	{
	}

	public bool HasLineInfo()
	{
		return false;
	}
}
