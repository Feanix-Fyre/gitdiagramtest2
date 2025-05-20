using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Newtonsoft.Json.Linq;

public class JProperty : JContainer
{
	private class JPropertyList : IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
	{
		[CompilerGenerated]
		private sealed class _003CGetEnumerator_003Ed__1 : IEnumerator<JToken>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private JToken _003C_003E2__current;

			public JPropertyList _003C_003E4__this;

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
			public _003CGetEnumerator_003Ed__1(int _003C_003E1__state)
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

		internal JToken? _token;

		public int Count => 0;

		public bool IsReadOnly => false;

		public JToken this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__1))]
		public IEnumerator<JToken> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public void Add(JToken item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(JToken item)
		{
			return false;
		}

		public void CopyTo(JToken[] array, int arrayIndex)
		{
		}

		public bool Remove(JToken item)
		{
			return false;
		}

		public int IndexOf(JToken item)
		{
			return 0;
		}

		public void Insert(int index, JToken item)
		{
		}

		public void RemoveAt(int index)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CLoadAsync_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<JProperty> _003C_003Et__builder;

		public JsonReader reader;

		public CancellationToken cancellationToken;

		public JsonLoadSettings settings;

		private JProperty _003Cp_003E5__2;

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
	private struct _003CWriteToAsync_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Task task;

		public JProperty _003C_003E4__this;

		public JsonWriter writer;

		public CancellationToken cancellationToken;

		public JsonConverter[] converters;

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

	private readonly JPropertyList _content;

	private readonly string _name;

	protected override IList<JToken> ChildrenTokens => null;

	public string Name
	{
		[DebuggerStepThrough]
		get
		{
			return null;
		}
	}

	public new JToken Value
	{
		[DebuggerStepThrough]
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override JTokenType Type
	{
		[DebuggerStepThrough]
		get
		{
			return default(JTokenType);
		}
	}

	public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, params JsonConverter[] converters)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CWriteToAsync_003Ed__1))]
	private Task WriteToAsync(Task task, JsonWriter writer, CancellationToken cancellationToken, params JsonConverter[] converters)
	{
		return null;
	}

	private Task WriteValueAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters)
	{
		return null;
	}

	public new static Task<JProperty> LoadAsync(JsonReader reader, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CLoadAsync_003Ed__4))]
	public new static Task<JProperty> LoadAsync(JsonReader reader, JsonLoadSettings? settings, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public JProperty(JProperty other)
	{
	}

	internal JProperty(JProperty other, JsonCloneSettings? settings)
	{
	}

	internal override JToken GetItem(int index)
	{
		return null;
	}

	internal override void SetItem(int index, JToken? item)
	{
	}

	internal override bool RemoveItem(JToken? item)
	{
		return false;
	}

	internal override void RemoveItemAt(int index)
	{
	}

	internal override int IndexOfItem(JToken? item)
	{
		return 0;
	}

	internal override bool InsertItem(int index, JToken? item, bool skipParentCheck, bool copyAnnotations)
	{
		return false;
	}

	internal override bool ContainsItem(JToken? item)
	{
		return false;
	}

	internal override void MergeItem(object content, JsonMergeSettings? settings)
	{
	}

	internal override void ClearItems()
	{
	}

	internal override bool DeepEquals(JToken node)
	{
		return false;
	}

	internal override JToken CloneToken(JsonCloneSettings? settings)
	{
		return null;
	}

	internal JProperty(string name)
	{
	}

	public JProperty(string name, params object[] content)
	{
	}

	public JProperty(string name, object? content)
	{
	}

	public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
	{
	}

	internal override int GetDeepHashCode()
	{
		return 0;
	}

	public new static JProperty Load(JsonReader reader)
	{
		return null;
	}

	public new static JProperty Load(JsonReader reader, JsonLoadSettings? settings)
	{
		return null;
	}
}
