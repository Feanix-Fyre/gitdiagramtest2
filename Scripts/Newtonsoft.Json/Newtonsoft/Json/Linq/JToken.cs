using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Newtonsoft.Json.Linq;

public abstract class JToken : IJEnumerable<JToken>, IEnumerable<JToken>, IEnumerable, IJsonLineInfo, ICloneable, IDynamicMetaObjectProvider
{
	private class LineInfoAnnotation
	{
		internal readonly int LineNumber;

		internal readonly int LinePosition;

		public LineInfoAnnotation(int lineNumber, int linePosition)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CAfterSelf_003Ed__49 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private JToken _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public JToken _003C_003E4__this;

		private JToken _003Co_003E5__2;

		JToken IEnumerator<JToken>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CAfterSelf_003Ed__49(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		IEnumerator<JToken> IEnumerable<JToken>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CAnnotations_003Ed__185<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : class
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public JToken _003C_003E4__this;

		private object[] _003Cannotations_003E5__2;

		private int _003Ci_003E5__3;

		T IEnumerator<T>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CAnnotations_003Ed__185(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CAnnotations_003Ed__186 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private Type type;

		public Type _003C_003E3__type;

		public JToken _003C_003E4__this;

		private object[] _003Cannotations_003E5__2;

		private int _003Ci_003E5__3;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CAnnotations_003Ed__186(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		IEnumerator<object> IEnumerable<object>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CBeforeSelf_003Ed__50 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private JToken _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public JToken _003C_003E4__this;

		private JToken _003Co_003E5__2;

		JToken IEnumerator<JToken>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CBeforeSelf_003Ed__50(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		IEnumerator<JToken> IEnumerable<JToken>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetAncestors_003Ed__48 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private JToken _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private bool self;

		public bool _003C_003E3__self;

		public JToken _003C_003E4__this;

		private JToken _003Ccurrent_003E5__2;

		JToken IEnumerator<JToken>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CGetAncestors_003Ed__48(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		IEnumerator<JToken> IEnumerable<JToken>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CReadFromAsync_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<JToken> _003C_003Et__builder;

		public JsonReader reader;

		public JsonLoadSettings settings;

		public CancellationToken cancellationToken;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable<JObject>.ConfiguredTaskAwaiter _003C_003Eu__2;

		private ConfiguredTaskAwaitable<JArray>.ConfiguredTaskAwaiter _003C_003Eu__3;

		private ConfiguredTaskAwaitable<JConstructor>.ConfiguredTaskAwaiter _003C_003Eu__4;

		private ConfiguredTaskAwaitable<JProperty>.ConfiguredTaskAwaiter _003C_003Eu__5;

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

	private static JTokenEqualityComparer? _equalityComparer;

	private JContainer? _parent;

	private JToken? _previous;

	private JToken? _next;

	private object? _annotations;

	private static readonly JTokenType[] BooleanTypes;

	private static readonly JTokenType[] NumberTypes;

	private static readonly JTokenType[] BigIntegerTypes;

	private static readonly JTokenType[] StringTypes;

	private static readonly JTokenType[] GuidTypes;

	private static readonly JTokenType[] TimeSpanTypes;

	private static readonly JTokenType[] UriTypes;

	private static readonly JTokenType[] CharTypes;

	private static readonly JTokenType[] DateTimeTypes;

	private static readonly JTokenType[] BytesTypes;

	public static JTokenEqualityComparer EqualityComparer => null;

	public JContainer? Parent
	{
		[DebuggerStepThrough]
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	public JToken Root => null;

	public abstract JTokenType Type { get; }

	public abstract bool HasValues { get; }

	public JToken? Next
	{
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	public JToken? Previous
	{
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	public string Path => null;

	public virtual JToken? this[object key]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual JToken? First => null;

	public virtual JToken? Last => null;

	IJEnumerable<JToken> IJEnumerable<JToken>.this[object key] => null;

	int IJsonLineInfo.LineNumber => 0;

	int IJsonLineInfo.LinePosition => 0;

	public virtual Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, params JsonConverter[] converters)
	{
		return null;
	}

	public Task WriteToAsync(JsonWriter writer, params JsonConverter[] converters)
	{
		return null;
	}

	public static Task<JToken> ReadFromAsync(JsonReader reader, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CReadFromAsync_003Ed__3))]
	public static Task<JToken> ReadFromAsync(JsonReader reader, JsonLoadSettings? settings, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public static Task<JToken> LoadAsync(JsonReader reader, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public static Task<JToken> LoadAsync(JsonReader reader, JsonLoadSettings? settings, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal abstract JToken CloneToken(JsonCloneSettings? settings);

	internal abstract bool DeepEquals(JToken node);

	public static bool DeepEquals(JToken? t1, JToken? t2)
	{
		return false;
	}

	internal JToken()
	{
	}

	public void AddAfterSelf(object? content)
	{
	}

	public void AddBeforeSelf(object? content)
	{
	}

	public IEnumerable<JToken> Ancestors()
	{
		return null;
	}

	public IEnumerable<JToken> AncestorsAndSelf()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGetAncestors_003Ed__48))]
	internal IEnumerable<JToken> GetAncestors(bool self)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAfterSelf_003Ed__49))]
	public IEnumerable<JToken> AfterSelf()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CBeforeSelf_003Ed__50))]
	public IEnumerable<JToken> BeforeSelf()
	{
		return null;
	}

	public virtual T? Value<T>(object key)
	{
		return default(T);
	}

	public virtual JEnumerable<JToken> Children()
	{
		return default(JEnumerable<JToken>);
	}

	public JEnumerable<T> Children<T>() where T : JToken
	{
		return default(JEnumerable<T>);
	}

	public virtual IEnumerable<T?>? Values<T>()
	{
		return null;
	}

	public void Remove()
	{
	}

	public void Replace(JToken value)
	{
	}

	public abstract void WriteTo(JsonWriter writer, params JsonConverter[] converters);

	public override string ToString()
	{
		return null;
	}

	public string ToString(Formatting formatting, params JsonConverter[] converters)
	{
		return null;
	}

	private static JValue EnsureValue(JToken value)
	{
		return null;
	}

	private static string GetType(JToken token)
	{
		return null;
	}

	private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable)
	{
		return false;
	}

	public static explicit operator bool(JToken value)
	{
		return false;
	}

	public static explicit operator DateTimeOffset(JToken value)
	{
		return default(DateTimeOffset);
	}

	public static explicit operator bool?(JToken? value)
	{
		return null;
	}

	public static explicit operator long(JToken value)
	{
		return 0L;
	}

	public static explicit operator DateTime?(JToken? value)
	{
		return null;
	}

	public static explicit operator DateTimeOffset?(JToken? value)
	{
		return null;
	}

	public static explicit operator decimal?(JToken? value)
	{
		return null;
	}

	public static explicit operator double?(JToken? value)
	{
		return null;
	}

	public static explicit operator char?(JToken? value)
	{
		return null;
	}

	public static explicit operator int(JToken value)
	{
		return 0;
	}

	public static explicit operator short(JToken value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static explicit operator ushort(JToken value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static explicit operator char(JToken value)
	{
		return '\0';
	}

	public static explicit operator byte(JToken value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static explicit operator sbyte(JToken value)
	{
		return 0;
	}

	public static explicit operator int?(JToken? value)
	{
		return null;
	}

	public static explicit operator short?(JToken? value)
	{
		return null;
	}

	[CLSCompliant(false)]
	public static explicit operator ushort?(JToken? value)
	{
		return null;
	}

	public static explicit operator byte?(JToken? value)
	{
		return null;
	}

	[CLSCompliant(false)]
	public static explicit operator sbyte?(JToken? value)
	{
		return null;
	}

	public static explicit operator DateTime(JToken value)
	{
		return default(DateTime);
	}

	public static explicit operator long?(JToken? value)
	{
		return null;
	}

	public static explicit operator float?(JToken? value)
	{
		return null;
	}

	public static explicit operator decimal(JToken value)
	{
		return default(decimal);
	}

	[CLSCompliant(false)]
	public static explicit operator uint?(JToken? value)
	{
		return null;
	}

	[CLSCompliant(false)]
	public static explicit operator ulong?(JToken? value)
	{
		return null;
	}

	public static explicit operator double(JToken value)
	{
		return 0.0;
	}

	public static explicit operator float(JToken value)
	{
		return 0f;
	}

	public static explicit operator string?(JToken? value)
	{
		return null;
	}

	[CLSCompliant(false)]
	public static explicit operator uint(JToken value)
	{
		return 0u;
	}

	[CLSCompliant(false)]
	public static explicit operator ulong(JToken value)
	{
		return 0uL;
	}

	public static explicit operator byte[]?(JToken? value)
	{
		return null;
	}

	public static explicit operator Guid(JToken value)
	{
		return default(Guid);
	}

	public static explicit operator Guid?(JToken? value)
	{
		return null;
	}

	public static explicit operator TimeSpan(JToken value)
	{
		return default(TimeSpan);
	}

	public static explicit operator TimeSpan?(JToken? value)
	{
		return null;
	}

	public static explicit operator Uri?(JToken? value)
	{
		return null;
	}

	private static BigInteger ToBigInteger(JToken value)
	{
		return default(BigInteger);
	}

	private static BigInteger? ToBigIntegerNullable(JToken value)
	{
		return null;
	}

	public static implicit operator JToken(bool value)
	{
		return null;
	}

	public static implicit operator JToken(DateTimeOffset value)
	{
		return null;
	}

	public static implicit operator JToken(byte value)
	{
		return null;
	}

	public static implicit operator JToken(byte? value)
	{
		return null;
	}

	[CLSCompliant(false)]
	public static implicit operator JToken(sbyte value)
	{
		return null;
	}

	[CLSCompliant(false)]
	public static implicit operator JToken(sbyte? value)
	{
		return null;
	}

	public static implicit operator JToken(bool? value)
	{
		return null;
	}

	public static implicit operator JToken(long value)
	{
		return null;
	}

	public static implicit operator JToken(DateTime? value)
	{
		return null;
	}

	public static implicit operator JToken(DateTimeOffset? value)
	{
		return null;
	}

	public static implicit operator JToken(decimal? value)
	{
		return null;
	}

	public static implicit operator JToken(double? value)
	{
		return null;
	}

	[CLSCompliant(false)]
	public static implicit operator JToken(short value)
	{
		return null;
	}

	[CLSCompliant(false)]
	public static implicit operator JToken(ushort value)
	{
		return null;
	}

	public static implicit operator JToken(int value)
	{
		return null;
	}

	public static implicit operator JToken(int? value)
	{
		return null;
	}

	public static implicit operator JToken(DateTime value)
	{
		return null;
	}

	public static implicit operator JToken(long? value)
	{
		return null;
	}

	public static implicit operator JToken(float? value)
	{
		return null;
	}

	public static implicit operator JToken(decimal value)
	{
		return null;
	}

	[CLSCompliant(false)]
	public static implicit operator JToken(short? value)
	{
		return null;
	}

	[CLSCompliant(false)]
	public static implicit operator JToken(ushort? value)
	{
		return null;
	}

	[CLSCompliant(false)]
	public static implicit operator JToken(uint? value)
	{
		return null;
	}

	[CLSCompliant(false)]
	public static implicit operator JToken(ulong? value)
	{
		return null;
	}

	public static implicit operator JToken(double value)
	{
		return null;
	}

	public static implicit operator JToken(float value)
	{
		return null;
	}

	public static implicit operator JToken(string? value)
	{
		return null;
	}

	[CLSCompliant(false)]
	public static implicit operator JToken(uint value)
	{
		return null;
	}

	[CLSCompliant(false)]
	public static implicit operator JToken(ulong value)
	{
		return null;
	}

	public static implicit operator JToken(byte[] value)
	{
		return null;
	}

	public static implicit operator JToken(Uri? value)
	{
		return null;
	}

	public static implicit operator JToken(TimeSpan value)
	{
		return null;
	}

	public static implicit operator JToken(TimeSpan? value)
	{
		return null;
	}

	public static implicit operator JToken(Guid value)
	{
		return null;
	}

	public static implicit operator JToken(Guid? value)
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	IEnumerator<JToken> IEnumerable<JToken>.GetEnumerator()
	{
		return null;
	}

	internal abstract int GetDeepHashCode();

	public JsonReader CreateReader()
	{
		return null;
	}

	internal static JToken FromObjectInternal(object o, JsonSerializer jsonSerializer)
	{
		return null;
	}

	public static JToken FromObject(object o)
	{
		return null;
	}

	public static JToken FromObject(object o, JsonSerializer jsonSerializer)
	{
		return null;
	}

	public T? ToObject<T>()
	{
		return default(T);
	}

	public object ToObject(Type objectType)
	{
		return null;
	}

	public T? ToObject<T>(JsonSerializer jsonSerializer)
	{
		return default(T);
	}

	public object? ToObject(Type? objectType, JsonSerializer jsonSerializer)
	{
		return null;
	}

	public static JToken ReadFrom(JsonReader reader)
	{
		return null;
	}

	public static JToken ReadFrom(JsonReader reader, JsonLoadSettings? settings)
	{
		return null;
	}

	public static JToken Parse(string json)
	{
		return null;
	}

	public static JToken Parse(string json, JsonLoadSettings? settings)
	{
		return null;
	}

	public static JToken Load(JsonReader reader, JsonLoadSettings? settings)
	{
		return null;
	}

	public static JToken Load(JsonReader reader)
	{
		return null;
	}

	internal void SetLineInfo(IJsonLineInfo? lineInfo, JsonLoadSettings? settings)
	{
	}

	internal void SetLineInfo(int lineNumber, int linePosition)
	{
	}

	bool IJsonLineInfo.HasLineInfo()
	{
		return false;
	}

	public JToken SelectToken(string path)
	{
		return null;
	}

	public JToken SelectToken(string path, bool errorWhenNoMatch)
	{
		return null;
	}

	public JToken? SelectToken(string path, JsonSelectSettings? settings)
	{
		return null;
	}

	public IEnumerable<JToken> SelectTokens(string path)
	{
		return null;
	}

	public IEnumerable<JToken> SelectTokens(string path, bool errorWhenNoMatch)
	{
		return null;
	}

	public IEnumerable<JToken> SelectTokens(string path, JsonSelectSettings? settings)
	{
		return null;
	}

	protected virtual DynamicMetaObject GetMetaObject(Expression parameter)
	{
		return null;
	}

	DynamicMetaObject IDynamicMetaObjectProvider.GetMetaObject(Expression parameter)
	{
		return null;
	}

	object ICloneable.Clone()
	{
		return null;
	}

	public JToken DeepClone()
	{
		return null;
	}

	public JToken DeepClone(JsonCloneSettings settings)
	{
		return null;
	}

	public void AddAnnotation(object annotation)
	{
	}

	public T Annotation<T>() where T : class
	{
		return null;
	}

	public object Annotation(Type type)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAnnotations_003Ed__185<>))]
	public IEnumerable<T> Annotations<T>() where T : class
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAnnotations_003Ed__186))]
	public IEnumerable<object> Annotations(Type type)
	{
		return null;
	}

	public void RemoveAnnotations<T>() where T : class
	{
	}

	public void RemoveAnnotations(Type type)
	{
	}

	internal void CopyAnnotations(JToken target, JToken source)
	{
	}
}
