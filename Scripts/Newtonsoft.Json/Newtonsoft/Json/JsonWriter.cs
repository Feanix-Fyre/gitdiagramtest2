using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json;

public abstract class JsonWriter : IDisposable
{
	internal enum State
	{
		Start = 0,
		Property = 1,
		ObjectStart = 2,
		Object = 3,
		ArrayStart = 4,
		Array = 5,
		ConstructorStart = 6,
		Constructor = 7,
		Closed = 8,
		Error = 9
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CAutoCompleteAsync_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JsonWriter _003C_003E4__this;

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
	private struct _003CInternalWriteStartAsync_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JsonWriter _003C_003E4__this;

		public JsonToken token;

		public CancellationToken cancellationToken;

		public JsonContainerType container;

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
	private struct _003CWriteConstructorDateAsync_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JsonReader reader;

		public CancellationToken cancellationToken;

		public JsonWriter _003C_003E4__this;

		private DateTime _003Cdate_003E5__2;

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
	private struct _003CWriteTokenAsync_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JsonWriter _003C_003E4__this;

		public JsonReader reader;

		public bool writeDateConstructorAsDate;

		public CancellationToken cancellationToken;

		public bool writeComments;

		public bool writeChildren;

		private int _003CinitialDepth_003E5__2;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__2;

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
	private struct _003CWriteTokenSyncReadingAsync_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JsonWriter _003C_003E4__this;

		public JsonReader reader;

		public CancellationToken cancellationToken;

		private int _003CinitialDepth_003E5__2;

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

	private static readonly State[][] StateArray;

	internal static readonly State[][] StateArrayTemplate;

	private List<JsonPosition>? _stack;

	private JsonPosition _currentPosition;

	private State _currentState;

	private Formatting _formatting;

	private DateFormatHandling _dateFormatHandling;

	private DateTimeZoneHandling _dateTimeZoneHandling;

	private StringEscapeHandling _stringEscapeHandling;

	private FloatFormatHandling _floatFormatHandling;

	private string? _dateFormatString;

	private CultureInfo? _culture;

	public bool CloseOutput { get; set; }

	public bool AutoCompleteOnClose { get; set; }

	protected internal int Top => 0;

	public WriteState WriteState => default(WriteState);

	internal string ContainerPath => null;

	public string Path => null;

	public Formatting Formatting
	{
		get
		{
			return default(Formatting);
		}
		set
		{
		}
	}

	public DateFormatHandling DateFormatHandling
	{
		get
		{
			return default(DateFormatHandling);
		}
		set
		{
		}
	}

	public DateTimeZoneHandling DateTimeZoneHandling
	{
		get
		{
			return default(DateTimeZoneHandling);
		}
		set
		{
		}
	}

	public StringEscapeHandling StringEscapeHandling
	{
		get
		{
			return default(StringEscapeHandling);
		}
		set
		{
		}
	}

	public FloatFormatHandling FloatFormatHandling
	{
		get
		{
			return default(FloatFormatHandling);
		}
		set
		{
		}
	}

	public string? DateFormatString
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public CultureInfo Culture
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal Task AutoCompleteAsync(JsonToken tokenBeingWritten, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CAutoCompleteAsync_003Ed__1))]
	private Task AutoCompleteAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	public virtual Task CloseAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task FlushAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	protected virtual Task WriteEndAsync(JsonToken token, CancellationToken cancellationToken)
	{
		return null;
	}

	protected virtual Task WriteIndentAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	protected virtual Task WriteValueDelimiterAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	protected virtual Task WriteIndentSpaceAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	public virtual Task WriteRawAsync(string? json, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteEndAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task WriteEndInternalAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	internal Task InternalWriteEndAsync(JsonContainerType type, CancellationToken cancellationToken)
	{
		return null;
	}

	public virtual Task WriteEndArrayAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteEndConstructorAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteEndObjectAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteNullAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WritePropertyNameAsync(string name, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WritePropertyNameAsync(string name, bool escape, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task InternalWritePropertyNameAsync(string name, CancellationToken cancellationToken)
	{
		return null;
	}

	public virtual Task WriteStartArrayAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CInternalWriteStartAsync_003Ed__20))]
	internal Task InternalWriteStartAsync(JsonToken token, JsonContainerType container, CancellationToken cancellationToken)
	{
		return null;
	}

	public virtual Task WriteCommentAsync(string? text, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task InternalWriteCommentAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	public virtual Task WriteRawValueAsync(string? json, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteStartConstructorAsync(string name, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteStartObjectAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public Task WriteTokenAsync(JsonReader reader, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public Task WriteTokenAsync(JsonReader reader, bool writeChildren, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public Task WriteTokenAsync(JsonToken token, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public Task WriteTokenAsync(JsonToken token, object? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CWriteTokenAsync_003Ed__30))]
	internal virtual Task WriteTokenAsync(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CWriteTokenSyncReadingAsync_003Ed__31))]
	internal Task WriteTokenSyncReadingAsync(JsonReader reader, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CWriteConstructorDateAsync_003Ed__32))]
	private Task WriteConstructorDateAsync(JsonReader reader, CancellationToken cancellationToken)
	{
		return null;
	}

	public virtual Task WriteValueAsync(bool value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteValueAsync(bool? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteValueAsync(byte value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteValueAsync(byte? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteValueAsync(byte[]? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteValueAsync(char value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteValueAsync(char? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteValueAsync(DateTime value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteValueAsync(DateTime? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteValueAsync(DateTimeOffset value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteValueAsync(DateTimeOffset? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteValueAsync(decimal value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteValueAsync(decimal? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteValueAsync(double value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteValueAsync(double? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteValueAsync(float value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteValueAsync(float? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteValueAsync(Guid value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteValueAsync(Guid? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteValueAsync(int value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteValueAsync(int? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteValueAsync(long value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteValueAsync(long? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteValueAsync(object? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[CLSCompliant(false)]
	public virtual Task WriteValueAsync(sbyte value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[CLSCompliant(false)]
	public virtual Task WriteValueAsync(sbyte? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteValueAsync(short value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteValueAsync(short? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteValueAsync(string? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteValueAsync(TimeSpan value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteValueAsync(TimeSpan? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[CLSCompliant(false)]
	public virtual Task WriteValueAsync(uint value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[CLSCompliant(false)]
	public virtual Task WriteValueAsync(uint? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[CLSCompliant(false)]
	public virtual Task WriteValueAsync(ulong value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[CLSCompliant(false)]
	public virtual Task WriteValueAsync(ulong? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteValueAsync(Uri? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[CLSCompliant(false)]
	public virtual Task WriteValueAsync(ushort value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[CLSCompliant(false)]
	public virtual Task WriteValueAsync(ushort? value, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteUndefinedAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public virtual Task WriteWhitespaceAsync(string ws, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal Task InternalWriteValueAsync(JsonToken token, CancellationToken cancellationToken)
	{
		return null;
	}

	protected Task SetWriteStateAsync(JsonToken token, object value, CancellationToken cancellationToken)
	{
		return null;
	}

	internal static Task WriteValueAsync(JsonWriter writer, PrimitiveTypeCode typeCode, object value, CancellationToken cancellationToken)
	{
		return null;
	}

	internal static State[][] BuildStateArray()
	{
		return null;
	}

	static JsonWriter()
	{
	}

	internal virtual void OnStringEscapeHandlingChanged()
	{
	}

	internal void UpdateScopeWithFinishedValue()
	{
	}

	private void Push(JsonContainerType value)
	{
	}

	private JsonContainerType Pop()
	{
		return default(JsonContainerType);
	}

	private JsonContainerType Peek()
	{
		return default(JsonContainerType);
	}

	public abstract void Flush();

	public virtual void Close()
	{
	}

	public virtual void WriteStartObject()
	{
	}

	public virtual void WriteEndObject()
	{
	}

	public virtual void WriteStartArray()
	{
	}

	public virtual void WriteEndArray()
	{
	}

	public virtual void WriteStartConstructor(string name)
	{
	}

	public virtual void WriteEndConstructor()
	{
	}

	public virtual void WritePropertyName(string name)
	{
	}

	public virtual void WritePropertyName(string name, bool escape)
	{
	}

	public virtual void WriteEnd()
	{
	}

	public void WriteToken(JsonReader reader)
	{
	}

	public void WriteToken(JsonReader reader, bool writeChildren)
	{
	}

	public void WriteToken(JsonToken token, object? value)
	{
	}

	public void WriteToken(JsonToken token)
	{
	}

	internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments)
	{
	}

	private bool IsWriteTokenIncomplete(JsonReader reader, bool writeChildren, int initialDepth)
	{
		return false;
	}

	private int CalculateWriteTokenInitialDepth(JsonReader reader)
	{
		return 0;
	}

	private int CalculateWriteTokenFinalDepth(JsonReader reader)
	{
		return 0;
	}

	private void WriteConstructorDate(JsonReader reader)
	{
	}

	private void WriteEnd(JsonContainerType type)
	{
	}

	private void AutoCompleteAll()
	{
	}

	private JsonToken GetCloseTokenForType(JsonContainerType type)
	{
		return default(JsonToken);
	}

	private void AutoCompleteClose(JsonContainerType type)
	{
	}

	private int CalculateLevelsToComplete(JsonContainerType type)
	{
		return 0;
	}

	private void UpdateCurrentState()
	{
	}

	protected virtual void WriteEnd(JsonToken token)
	{
	}

	protected virtual void WriteIndent()
	{
	}

	protected virtual void WriteValueDelimiter()
	{
	}

	protected virtual void WriteIndentSpace()
	{
	}

	internal void AutoComplete(JsonToken tokenBeingWritten)
	{
	}

	public virtual void WriteNull()
	{
	}

	public virtual void WriteUndefined()
	{
	}

	public virtual void WriteRaw(string? json)
	{
	}

	public virtual void WriteRawValue(string? json)
	{
	}

	public virtual void WriteValue(string? value)
	{
	}

	public virtual void WriteValue(int value)
	{
	}

	[CLSCompliant(false)]
	public virtual void WriteValue(uint value)
	{
	}

	public virtual void WriteValue(long value)
	{
	}

	[CLSCompliant(false)]
	public virtual void WriteValue(ulong value)
	{
	}

	public virtual void WriteValue(float value)
	{
	}

	public virtual void WriteValue(double value)
	{
	}

	public virtual void WriteValue(bool value)
	{
	}

	public virtual void WriteValue(short value)
	{
	}

	[CLSCompliant(false)]
	public virtual void WriteValue(ushort value)
	{
	}

	public virtual void WriteValue(char value)
	{
	}

	public virtual void WriteValue(byte value)
	{
	}

	[CLSCompliant(false)]
	public virtual void WriteValue(sbyte value)
	{
	}

	public virtual void WriteValue(decimal value)
	{
	}

	public virtual void WriteValue(DateTime value)
	{
	}

	public virtual void WriteValue(DateTimeOffset value)
	{
	}

	public virtual void WriteValue(Guid value)
	{
	}

	public virtual void WriteValue(TimeSpan value)
	{
	}

	public virtual void WriteValue(int? value)
	{
	}

	[CLSCompliant(false)]
	public virtual void WriteValue(uint? value)
	{
	}

	public virtual void WriteValue(long? value)
	{
	}

	[CLSCompliant(false)]
	public virtual void WriteValue(ulong? value)
	{
	}

	public virtual void WriteValue(float? value)
	{
	}

	public virtual void WriteValue(double? value)
	{
	}

	public virtual void WriteValue(bool? value)
	{
	}

	public virtual void WriteValue(short? value)
	{
	}

	[CLSCompliant(false)]
	public virtual void WriteValue(ushort? value)
	{
	}

	public virtual void WriteValue(char? value)
	{
	}

	public virtual void WriteValue(byte? value)
	{
	}

	[CLSCompliant(false)]
	public virtual void WriteValue(sbyte? value)
	{
	}

	public virtual void WriteValue(decimal? value)
	{
	}

	public virtual void WriteValue(DateTime? value)
	{
	}

	public virtual void WriteValue(DateTimeOffset? value)
	{
	}

	public virtual void WriteValue(Guid? value)
	{
	}

	public virtual void WriteValue(TimeSpan? value)
	{
	}

	public virtual void WriteValue(byte[]? value)
	{
	}

	public virtual void WriteValue(Uri? value)
	{
	}

	public virtual void WriteValue(object? value)
	{
	}

	public virtual void WriteComment(string? text)
	{
	}

	public virtual void WriteWhitespace(string ws)
	{
	}

	void IDisposable.Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value)
	{
	}

	private static void ResolveConvertibleValue(IConvertible convertible, out PrimitiveTypeCode typeCode, out object value)
	{
		typeCode = default(PrimitiveTypeCode);
		value = null;
	}

	private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value)
	{
		return null;
	}

	protected void SetWriteState(JsonToken token, object value)
	{
	}

	internal void InternalWriteEnd(JsonContainerType container)
	{
	}

	internal void InternalWritePropertyName(string name)
	{
	}

	internal void InternalWriteRaw()
	{
	}

	internal void InternalWriteStart(JsonToken token, JsonContainerType container)
	{
	}

	internal void InternalWriteValue(JsonToken token)
	{
	}

	internal void InternalWriteWhitespace(string ws)
	{
	}

	internal void InternalWriteComment()
	{
	}
}
