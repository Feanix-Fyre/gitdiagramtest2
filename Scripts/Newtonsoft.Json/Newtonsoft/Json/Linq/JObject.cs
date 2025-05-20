using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq;

public class JObject : JContainer, IDictionary<string, JToken>, ICollection<KeyValuePair<string, JToken>>, IEnumerable<KeyValuePair<string, JToken>>, IEnumerable, INotifyPropertyChanged, ICustomTypeDescriptor, INotifyPropertyChanging
{
	private class JObjectDynamicProxy : DynamicProxy<JObject>
	{
		public override bool TryGetMember(JObject instance, GetMemberBinder binder, out object? result)
		{
			result = null;
			return false;
		}

		public override bool TrySetMember(JObject instance, SetMemberBinder binder, object value)
		{
			return false;
		}

		public override IEnumerable<string> GetDynamicMemberNames(JObject instance)
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetEnumerator_003Ed__64 : IEnumerator<KeyValuePair<string, JToken>>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private KeyValuePair<string, JToken?> _003C_003E2__current;

		public JObject _003C_003E4__this;

		private IEnumerator<JToken> _003C_003E7__wrap1;

		KeyValuePair<string, JToken> IEnumerator<KeyValuePair<string, JToken>>.Current
		{
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, JToken>);
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
		public _003CGetEnumerator_003Ed__64(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CLoadAsync_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<JObject> _003C_003Et__builder;

		public JsonReader reader;

		public CancellationToken cancellationToken;

		public JsonLoadSettings settings;

		private JObject _003Co_003E5__2;

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

	private readonly JPropertyKeyedCollection _properties;

	protected override IList<JToken> ChildrenTokens => null;

	public override JTokenType Type => default(JTokenType);

	public override JToken? this[object key]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public JToken? this[string propertyName]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	ICollection<string> IDictionary<string, JToken>.Keys => null;

	ICollection<JToken?> IDictionary<string, JToken>.Values => null;

	bool ICollection<KeyValuePair<string, JToken>>.IsReadOnly => false;

	public event PropertyChangedEventHandler? PropertyChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event PropertyChangingEventHandler? PropertyChanging
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, params JsonConverter[] converters)
	{
		return null;
	}

	public new static Task<JObject> LoadAsync(JsonReader reader, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CLoadAsync_003Ed__2))]
	public new static Task<JObject> LoadAsync(JsonReader reader, JsonLoadSettings? settings, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public JObject()
	{
	}

	public JObject(JObject other)
	{
	}

	internal JObject(JObject other, JsonCloneSettings? settings)
	{
	}

	public JObject(params object[] content)
	{
	}

	public JObject(object content)
	{
	}

	internal override bool DeepEquals(JToken node)
	{
		return false;
	}

	internal override int IndexOfItem(JToken? item)
	{
		return 0;
	}

	internal override bool InsertItem(int index, JToken? item, bool skipParentCheck, bool copyAnnotations)
	{
		return false;
	}

	internal override void ValidateToken(JToken o, JToken? existing)
	{
	}

	internal override void MergeItem(object content, JsonMergeSettings? settings)
	{
	}

	private static bool IsNull(JToken token)
	{
		return false;
	}

	internal void InternalPropertyChanged(JProperty childProperty)
	{
	}

	internal void InternalPropertyChanging(JProperty childProperty)
	{
	}

	internal override JToken CloneToken(JsonCloneSettings? settings)
	{
		return null;
	}

	public IEnumerable<JProperty> Properties()
	{
		return null;
	}

	public JProperty Property(string name)
	{
		return null;
	}

	public JProperty Property(string name, StringComparison comparison)
	{
		return null;
	}

	public JEnumerable<JToken> PropertyValues()
	{
		return default(JEnumerable<JToken>);
	}

	public new static JObject Load(JsonReader reader)
	{
		return null;
	}

	public new static JObject Load(JsonReader reader, JsonLoadSettings? settings)
	{
		return null;
	}

	public new static JObject Parse(string json)
	{
		return null;
	}

	public new static JObject Parse(string json, JsonLoadSettings? settings)
	{
		return null;
	}

	public new static JObject FromObject(object o)
	{
		return null;
	}

	public new static JObject FromObject(object o, JsonSerializer jsonSerializer)
	{
		return null;
	}

	public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
	{
	}

	public JToken? GetValue(string? propertyName)
	{
		return null;
	}

	public JToken? GetValue(string? propertyName, StringComparison comparison)
	{
		return null;
	}

	public bool TryGetValue(string propertyName, StringComparison comparison, [NotNullWhen(true)] out JToken? value)
	{
		value = null;
		return false;
	}

	public void Add(string propertyName, JToken? value)
	{
	}

	public bool ContainsKey(string propertyName)
	{
		return false;
	}

	public bool Remove(string propertyName)
	{
		return false;
	}

	public bool TryGetValue(string propertyName, [NotNullWhen(true)] out JToken? value)
	{
		value = null;
		return false;
	}

	void ICollection<KeyValuePair<string, JToken>>.Add(KeyValuePair<string, JToken?> item)
	{
	}

	void ICollection<KeyValuePair<string, JToken>>.Clear()
	{
	}

	bool ICollection<KeyValuePair<string, JToken>>.Contains(KeyValuePair<string, JToken?> item)
	{
		return false;
	}

	void ICollection<KeyValuePair<string, JToken>>.CopyTo(KeyValuePair<string, JToken?>[] array, int arrayIndex)
	{
	}

	bool ICollection<KeyValuePair<string, JToken>>.Remove(KeyValuePair<string, JToken?> item)
	{
		return false;
	}

	internal override int GetDeepHashCode()
	{
		return 0;
	}

	[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__64))]
	public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator()
	{
		return null;
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}

	protected virtual void OnPropertyChanging(string propertyName)
	{
	}

	PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
	{
		return null;
	}

	PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[]? attributes)
	{
		return null;
	}

	AttributeCollection ICustomTypeDescriptor.GetAttributes()
	{
		return null;
	}

	string? ICustomTypeDescriptor.GetClassName()
	{
		return null;
	}

	string? ICustomTypeDescriptor.GetComponentName()
	{
		return null;
	}

	TypeConverter ICustomTypeDescriptor.GetConverter()
	{
		return null;
	}

	EventDescriptor? ICustomTypeDescriptor.GetDefaultEvent()
	{
		return null;
	}

	PropertyDescriptor? ICustomTypeDescriptor.GetDefaultProperty()
	{
		return null;
	}

	object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
	{
		return null;
	}

	EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[]? attributes)
	{
		return null;
	}

	EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
	{
		return null;
	}

	object? ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor? pd)
	{
		return null;
	}

	protected override DynamicMetaObject GetMetaObject(Expression parameter)
	{
		return null;
	}
}
