using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Dynamic;

/// <summary>Represents an object whose members can be dynamically added and removed at run time.</summary>
public sealed class ExpandoObject : IDynamicMetaObjectProvider, IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable, INotifyPropertyChanged
{
	private sealed class KeyCollectionDebugView
	{
	}

	[DebuggerTypeProxy(typeof(KeyCollectionDebugView))]
	[DebuggerDisplay("Count = {Count}")]
	private class KeyCollection : ICollection<string>, IEnumerable<string>, IEnumerable
	{
		[CompilerGenerated]
		private sealed class _003CGetEnumerator_003Ed__15 : IEnumerator<string>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private string _003C_003E2__current;

			public KeyCollection _003C_003E4__this;

			private int _003Ci_003E5__2;

			private int _003Cn_003E5__3;

			string IEnumerator<string>.Current
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
			public _003CGetEnumerator_003Ed__15(int _003C_003E1__state)
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
		}

		private readonly ExpandoObject _expando;

		private readonly int _expandoVersion;

		private readonly int _expandoCount;

		private readonly ExpandoData _expandoData;

		public int Count => 0;

		public bool IsReadOnly => false;

		internal KeyCollection(ExpandoObject expando)
		{
		}

		private void CheckVersion()
		{
		}

		public void Add(string item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(string item)
		{
			return false;
		}

		public void CopyTo(string[] array, int arrayIndex)
		{
		}

		public bool Remove(string item)
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__15))]
		public IEnumerator<string> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	private sealed class ValueCollectionDebugView
	{
	}

	[DebuggerTypeProxy(typeof(ValueCollectionDebugView))]
	[DebuggerDisplay("Count = {Count}")]
	private class ValueCollection : ICollection<object>, IEnumerable<object>, IEnumerable
	{
		[CompilerGenerated]
		private sealed class _003CGetEnumerator_003Ed__15 : IEnumerator<object>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ValueCollection _003C_003E4__this;

			private ExpandoData _003Cdata_003E5__2;

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
			public _003CGetEnumerator_003Ed__15(int _003C_003E1__state)
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
		}

		private readonly ExpandoObject _expando;

		private readonly int _expandoVersion;

		private readonly int _expandoCount;

		private readonly ExpandoData _expandoData;

		public int Count => 0;

		public bool IsReadOnly => false;

		internal ValueCollection(ExpandoObject expando)
		{
		}

		private void CheckVersion()
		{
		}

		public void Add(object item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(object item)
		{
			return false;
		}

		public void CopyTo(object[] array, int arrayIndex)
		{
		}

		public bool Remove(object item)
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__15))]
		public IEnumerator<object> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	private class MetaExpando : DynamicMetaObject
	{
		[CompilerGenerated]
		private sealed class _003CGetDynamicMemberNames_003Ed__6 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private string _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public MetaExpando _003C_003E4__this;

			private ExpandoData _003CexpandoData_003E5__2;

			private ExpandoClass _003Cklass_003E5__3;

			private int _003Ci_003E5__4;

			string IEnumerator<string>.Current
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
			public _003CGetDynamicMemberNames_003Ed__6(int _003C_003E1__state)
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
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		public new ExpandoObject Value => null;

		public MetaExpando(Expression expression, ExpandoObject value)
			: base(null, null)
		{
		}

		private DynamicMetaObject BindGetOrInvokeMember(DynamicMetaObjectBinder binder, string name, bool ignoreCase, DynamicMetaObject fallback, Func<DynamicMetaObject, DynamicMetaObject> fallbackInvoke)
		{
			return null;
		}

		public override DynamicMetaObject BindGetMember(GetMemberBinder binder)
		{
			return null;
		}

		public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args)
		{
			return null;
		}

		public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
		{
			return null;
		}

		public override DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetDynamicMemberNames_003Ed__6))]
		public override IEnumerable<string> GetDynamicMemberNames()
		{
			return null;
		}

		private DynamicMetaObject AddDynamicTestAndDefer(DynamicMetaObjectBinder binder, ExpandoClass klass, ExpandoClass originalClass, DynamicMetaObject succeeds)
		{
			return null;
		}

		private ExpandoClass GetClassEnsureIndex(string name, bool caseInsensitive, ExpandoObject obj, out ExpandoClass klass, out int index)
		{
			klass = null;
			index = default(int);
			return null;
		}

		private Expression GetLimitedSelf()
		{
			return null;
		}

		private BindingRestrictions GetRestrictions()
		{
			return null;
		}
	}

	private class ExpandoData
	{
		internal static ExpandoData Empty;

		internal readonly ExpandoClass Class;

		private readonly object[] _dataArray;

		private int _version;

		internal object this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal int Version => 0;

		internal int Length => 0;

		private ExpandoData()
		{
		}

		internal ExpandoData(ExpandoClass klass, object[] data, int version)
		{
		}

		internal ExpandoData UpdateClass(ExpandoClass newClass)
		{
			return null;
		}

		private static int GetAlignedSize(int len)
		{
			return 0;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetExpandoEnumerator_003Ed__51 : IEnumerator<KeyValuePair<string, object>>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private KeyValuePair<string, object> _003C_003E2__current;

		public ExpandoObject _003C_003E4__this;

		public int version;

		public ExpandoData data;

		private int _003Ci_003E5__2;

		KeyValuePair<string, object> IEnumerator<KeyValuePair<string, object>>.Current
		{
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, object>);
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
		public _003CGetExpandoEnumerator_003Ed__51(int _003C_003E1__state)
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
	}

	private static readonly MethodInfo s_expandoTryGetValue;

	private static readonly MethodInfo s_expandoTrySetValue;

	private static readonly MethodInfo s_expandoTryDeleteValue;

	private static readonly MethodInfo s_expandoPromoteClass;

	private static readonly MethodInfo s_expandoCheckVersion;

	internal readonly object LockObject;

	private ExpandoData _data;

	private int _count;

	internal static readonly object Uninitialized;

	private PropertyChangedEventHandler _propertyChanged;

	internal ExpandoClass Class => null;

	ICollection<string> IDictionary<string, object>.Keys => null;

	ICollection<object> IDictionary<string, object>.Values => null;

	object IDictionary<string, object>.this[string key]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	int ICollection<KeyValuePair<string, object>>.Count => 0;

	bool ICollection<KeyValuePair<string, object>>.IsReadOnly => false;

	/// <summary>Initializes a new <see langword="ExpandoObject" /> that does not have members.</summary>
	public ExpandoObject()
	{
	}

	internal bool TryGetValue(object indexClass, int index, string name, bool ignoreCase, out object value)
	{
		value = null;
		return false;
	}

	internal void TrySetValue(object indexClass, int index, object value, string name, bool ignoreCase, bool add)
	{
	}

	internal bool TryDeleteValue(object indexClass, int index, string name, bool ignoreCase, object deleteValue)
	{
		return false;
	}

	internal bool IsDeletedMember(int index)
	{
		return false;
	}

	private ExpandoData PromoteClassCore(ExpandoClass oldClass, ExpandoClass newClass)
	{
		return null;
	}

	internal void PromoteClass(object oldClass, object newClass)
	{
	}

	/// <summary>The provided MetaObject will dispatch to the dynamic virtual methods. The object can be encapsulated inside another MetaObject to provide custom behavior for individual actions.</summary>
	/// <param name="parameter">The expression that represents the MetaObject to dispatch to the Dynamic virtual methods.</param>
	/// <returns>The object of the <see cref="T:System.Dynamic.DynamicMetaObject" /> type.</returns>
	DynamicMetaObject IDynamicMetaObjectProvider.GetMetaObject(Expression parameter)
	{
		return null;
	}

	private void TryAddMember(string key, object value)
	{
	}

	private bool TryGetValueForKey(string key, out object value)
	{
		value = null;
		return false;
	}

	private bool ExpandoContainsKey(string key)
	{
		return false;
	}

	void IDictionary<string, object>.Add(string key, object value)
	{
	}

	bool IDictionary<string, object>.ContainsKey(string key)
	{
		return false;
	}

	bool IDictionary<string, object>.Remove(string key)
	{
		return false;
	}

	bool IDictionary<string, object>.TryGetValue(string key, out object value)
	{
		value = null;
		return false;
	}

	void ICollection<KeyValuePair<string, object>>.Add(KeyValuePair<string, object> item)
	{
	}

	void ICollection<KeyValuePair<string, object>>.Clear()
	{
	}

	bool ICollection<KeyValuePair<string, object>>.Contains(KeyValuePair<string, object> item)
	{
		return false;
	}

	void ICollection<KeyValuePair<string, object>>.CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
	{
	}

	bool ICollection<KeyValuePair<string, object>>.Remove(KeyValuePair<string, object> item)
	{
		return false;
	}

	IEnumerator<KeyValuePair<string, object>> IEnumerable<KeyValuePair<string, object>>.GetEnumerator()
	{
		return null;
	}

	/// <summary>Returns an enumerator that iterates through the collection.</summary>
	/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that can be used to iterate through the collection.</returns>
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGetExpandoEnumerator_003Ed__51))]
	private IEnumerator<KeyValuePair<string, object>> GetExpandoEnumerator(ExpandoData data, int version)
	{
		return null;
	}
}
