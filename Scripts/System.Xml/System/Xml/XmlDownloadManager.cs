using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace System.Xml;

internal class XmlDownloadManager
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CGetNonFileStreamAsync_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Stream> _003C_003Et__builder;

		public Uri uri;

		public ICredentials credentials;

		public IWebProxy proxy;

		public RequestCachePolicy cachePolicy;

		public XmlDownloadManager _003C_003E4__this;

		private WebRequest _003Creq_003E5__2;

		private ConfiguredTaskAwaitable<WebResponse>.ConfiguredTaskAwaiter _003C_003Eu__1;

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

	private Hashtable connections;

	internal Stream GetStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy)
	{
		return null;
	}

	private Stream GetNonFileStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy)
	{
		return null;
	}

	internal void Remove(string host)
	{
	}

	internal Task<Stream> GetStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CGetNonFileStreamAsync_003Ed__5))]
	private Task<Stream> GetNonFileStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy)
	{
		return null;
	}
}
