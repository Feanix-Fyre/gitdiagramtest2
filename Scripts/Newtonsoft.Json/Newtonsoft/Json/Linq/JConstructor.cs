using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Newtonsoft.Json.Linq;

public class JConstructor : JContainer
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CLoadAsync_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<JConstructor> _003C_003Et__builder;

		public JsonReader reader;

		public CancellationToken cancellationToken;

		public JsonLoadSettings settings;

		private JConstructor _003Cc_003E5__2;

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
	private struct _003CWriteToAsync_003Ed__0 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JsonWriter writer;

		public JConstructor _003C_003E4__this;

		public CancellationToken cancellationToken;

		public JsonConverter[] converters;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private int _003Ci_003E5__2;

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

	private string? _name;

	private readonly List<JToken> _values;

	protected override IList<JToken> ChildrenTokens => null;

	public string? Name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

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

	[AsyncStateMachine(typeof(_003CWriteToAsync_003Ed__0))]
	public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, params JsonConverter[] converters)
	{
		return null;
	}

	public new static Task<JConstructor> LoadAsync(JsonReader reader, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CLoadAsync_003Ed__2))]
	public new static Task<JConstructor> LoadAsync(JsonReader reader, JsonLoadSettings? settings, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	internal override int IndexOfItem(JToken? item)
	{
		return 0;
	}

	internal override void MergeItem(object content, JsonMergeSettings? settings)
	{
	}

	public JConstructor()
	{
	}

	public JConstructor(JConstructor other)
	{
	}

	internal JConstructor(JConstructor other, JsonCloneSettings? settings)
	{
	}

	public JConstructor(string name, params object[] content)
	{
	}

	public JConstructor(string name, object content)
	{
	}

	public JConstructor(string name)
	{
	}

	internal override bool DeepEquals(JToken node)
	{
		return false;
	}

	internal override JToken CloneToken(JsonCloneSettings? settings = null)
	{
		return null;
	}

	public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
	{
	}

	internal override int GetDeepHashCode()
	{
		return 0;
	}

	public new static JConstructor Load(JsonReader reader)
	{
		return null;
	}

	public new static JConstructor Load(JsonReader reader, JsonLoadSettings? settings)
	{
		return null;
	}
}
