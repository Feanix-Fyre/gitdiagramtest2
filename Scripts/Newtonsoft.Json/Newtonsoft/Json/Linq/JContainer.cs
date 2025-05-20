using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Newtonsoft.Json.Linq;

public abstract class JContainer : JToken, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable, ITypedList, IBindingList, ICollection, IList, INotifyCollectionChanged
{
	[CompilerGenerated]
	private sealed class _003CGetDescendants_003Ed__36 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private JToken _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private bool self;

		public bool _003C_003E3__self;

		public JContainer _003C_003E4__this;

		private IEnumerator<JToken> _003C_003E7__wrap1;

		private JToken _003Co_003E5__3;

		private IEnumerator<JToken> _003C_003E7__wrap3;

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
		public _003CGetDescendants_003Ed__36(int _003C_003E1__state)
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

		private void _003C_003Em__Finally2()
		{
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
	private struct _003CReadContentFromAsync_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JsonReader reader;

		public JContainer _003C_003E4__this;

		public JsonLoadSettings settings;

		public CancellationToken cancellationToken;

		private IJsonLineInfo _003ClineInfo_003E5__2;

		private JContainer _003Cparent_003E5__3;

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
	private struct _003CReadTokenFromAsync_003Ed__0 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JsonReader reader;

		public CancellationToken cancellationToken;

		public JContainer _003C_003E4__this;

		public JsonLoadSettings options;

		private int _003CstartDepth_003E5__2;

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

	internal ListChangedEventHandler? _listChanged;

	internal AddingNewEventHandler? _addingNew;

	internal NotifyCollectionChangedEventHandler? _collectionChanged;

	private object? _syncRoot;

	private bool _busy;

	protected abstract IList<JToken> ChildrenTokens { get; }

	public override bool HasValues => false;

	public override JToken? First => null;

	public override JToken? Last => null;

	JToken IList<JToken>.this[int index]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	bool ICollection<JToken>.IsReadOnly => false;

	bool IList.IsFixedSize => false;

	bool IList.IsReadOnly => false;

	object? IList.this[int index]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int Count => 0;

	bool ICollection.IsSynchronized => false;

	object ICollection.SyncRoot => null;

	bool IBindingList.AllowEdit => false;

	bool IBindingList.AllowNew => false;

	bool IBindingList.AllowRemove => false;

	bool IBindingList.IsSorted => false;

	ListSortDirection IBindingList.SortDirection => default(ListSortDirection);

	PropertyDescriptor? IBindingList.SortProperty => null;

	bool IBindingList.SupportsChangeNotification => false;

	bool IBindingList.SupportsSearching => false;

	bool IBindingList.SupportsSorting => false;

	public event ListChangedEventHandler ListChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	public event AddingNewEventHandler AddingNew
	{
		add
		{
		}
		remove
		{
		}
	}

	public event NotifyCollectionChangedEventHandler? CollectionChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	[AsyncStateMachine(typeof(_003CReadTokenFromAsync_003Ed__0))]
	internal Task ReadTokenFromAsync(JsonReader reader, JsonLoadSettings? options, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CReadContentFromAsync_003Ed__1))]
	private Task ReadContentFromAsync(JsonReader reader, JsonLoadSettings? settings, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal JContainer()
	{
	}

	internal JContainer(JContainer other, JsonCloneSettings? settings)
	{
	}

	internal void CheckReentrancy()
	{
	}

	internal virtual IList<JToken> CreateChildrenCollection()
	{
		return null;
	}

	protected virtual void OnAddingNew(AddingNewEventArgs e)
	{
	}

	protected virtual void OnListChanged(ListChangedEventArgs e)
	{
	}

	protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
	{
	}

	internal bool ContentsEqual(JContainer container)
	{
		return false;
	}

	public override JEnumerable<JToken> Children()
	{
		return default(JEnumerable<JToken>);
	}

	public override IEnumerable<T?>? Values<T>()
	{
		return null;
	}

	public IEnumerable<JToken> Descendants()
	{
		return null;
	}

	public IEnumerable<JToken> DescendantsAndSelf()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGetDescendants_003Ed__36))]
	internal IEnumerable<JToken> GetDescendants(bool self)
	{
		return null;
	}

	internal bool IsMultiContent([NotNullWhen(true)] object? content)
	{
		return false;
	}

	internal JToken EnsureParentToken(JToken? item, bool skipParentCheck, bool copyAnnotations)
	{
		return null;
	}

	internal abstract int IndexOfItem(JToken? item);

	internal virtual bool InsertItem(int index, JToken? item, bool skipParentCheck, bool copyAnnotations)
	{
		return false;
	}

	internal virtual void RemoveItemAt(int index)
	{
	}

	internal virtual bool RemoveItem(JToken? item)
	{
		return false;
	}

	internal virtual JToken GetItem(int index)
	{
		return null;
	}

	internal virtual void SetItem(int index, JToken? item)
	{
	}

	internal virtual void ClearItems()
	{
	}

	internal virtual void ReplaceItem(JToken existing, JToken replacement)
	{
	}

	internal virtual bool ContainsItem(JToken? item)
	{
		return false;
	}

	internal virtual void CopyItemsTo(Array array, int arrayIndex)
	{
	}

	internal static bool IsTokenUnchanged(JToken currentValue, JToken? newValue)
	{
		return false;
	}

	internal virtual void ValidateToken(JToken o, JToken? existing)
	{
	}

	public virtual void Add(object? content)
	{
	}

	internal bool TryAdd(object? content)
	{
		return false;
	}

	internal void AddAndSkipParentCheck(JToken token)
	{
	}

	public void AddFirst(object? content)
	{
	}

	internal bool TryAddInternal(int index, object? content, bool skipParentCheck, bool copyAnnotations)
	{
		return false;
	}

	internal static JToken CreateFromContent(object? content)
	{
		return null;
	}

	public JsonWriter CreateWriter()
	{
		return null;
	}

	public void ReplaceAll(object content)
	{
	}

	public void RemoveAll()
	{
	}

	internal abstract void MergeItem(object content, JsonMergeSettings? settings);

	public void Merge(object? content)
	{
	}

	public void Merge(object? content, JsonMergeSettings? settings)
	{
	}

	private void ValidateContent(object content)
	{
	}

	internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings? options)
	{
	}

	internal void ReadContentFrom(JsonReader r, JsonLoadSettings? settings)
	{
	}

	private static JProperty? ReadProperty(JsonReader r, JsonLoadSettings? settings, IJsonLineInfo? lineInfo, JContainer parent)
	{
		return null;
	}

	internal int ContentsHashCode()
	{
		return 0;
	}

	string ITypedList.GetListName(PropertyDescriptor[] listAccessors)
	{
		return null;
	}

	PropertyDescriptorCollection ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors)
	{
		return null;
	}

	int IList<JToken>.IndexOf(JToken item)
	{
		return 0;
	}

	void IList<JToken>.Insert(int index, JToken item)
	{
	}

	void IList<JToken>.RemoveAt(int index)
	{
	}

	void ICollection<JToken>.Add(JToken item)
	{
	}

	void ICollection<JToken>.Clear()
	{
	}

	bool ICollection<JToken>.Contains(JToken item)
	{
		return false;
	}

	void ICollection<JToken>.CopyTo(JToken[] array, int arrayIndex)
	{
	}

	bool ICollection<JToken>.Remove(JToken item)
	{
		return false;
	}

	private JToken? EnsureValue(object? value)
	{
		return null;
	}

	int IList.Add(object? value)
	{
		return 0;
	}

	void IList.Clear()
	{
	}

	bool IList.Contains(object? value)
	{
		return false;
	}

	int IList.IndexOf(object? value)
	{
		return 0;
	}

	void IList.Insert(int index, object? value)
	{
	}

	void IList.Remove(object? value)
	{
	}

	void IList.RemoveAt(int index)
	{
	}

	void ICollection.CopyTo(Array array, int index)
	{
	}

	void IBindingList.AddIndex(PropertyDescriptor property)
	{
	}

	object IBindingList.AddNew()
	{
		return null;
	}

	void IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction)
	{
	}

	int IBindingList.Find(PropertyDescriptor property, object key)
	{
		return 0;
	}

	void IBindingList.RemoveIndex(PropertyDescriptor property)
	{
	}

	void IBindingList.RemoveSort()
	{
	}

	internal static void MergeEnumerableContent(JContainer target, IEnumerable content, JsonMergeSettings? settings)
	{
	}
}
