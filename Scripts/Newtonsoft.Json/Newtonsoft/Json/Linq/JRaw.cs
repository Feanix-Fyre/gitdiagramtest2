using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Newtonsoft.Json.Linq;

public class JRaw : JValue
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CCreateAsync_003Ed__0 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<JRaw> _003C_003Et__builder;

		public JsonReader reader;

		public CancellationToken cancellationToken;

		private StringWriter _003Csw_003E5__2;

		private JsonTextWriter _003CjsonWriter_003E5__3;

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

	[AsyncStateMachine(typeof(_003CCreateAsync_003Ed__0))]
	public static Task<JRaw> CreateAsync(JsonReader reader, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	public JRaw(JRaw other)
		: base(null, default(JTokenType))
	{
	}

	internal JRaw(JRaw other, JsonCloneSettings? settings)
		: base(null, default(JTokenType))
	{
	}

	public JRaw(object? rawJson)
		: base(null, default(JTokenType))
	{
	}

	public static JRaw Create(JsonReader reader)
	{
		return null;
	}

	internal override JToken CloneToken(JsonCloneSettings? settings)
	{
		return null;
	}
}
