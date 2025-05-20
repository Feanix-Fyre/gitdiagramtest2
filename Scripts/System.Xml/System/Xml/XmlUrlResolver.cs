using System.Diagnostics;
using System.Net;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace System.Xml;

/// <summary>Resolves external XML resources named by a Uniform Resource Identifier (URI).</summary>
public class XmlUrlResolver : XmlResolver
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CGetEntityAsync_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<object> _003C_003Et__builder;

		public Type ofObjectToReturn;

		public Uri absoluteUri;

		public XmlUrlResolver _003C_003E4__this;

		private ConfiguredTaskAwaitable<System.IO.Stream>.ConfiguredTaskAwaiter _003C_003Eu__1;

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

	private static object s_DownloadManager;

	private ICredentials _credentials;

	private IWebProxy _proxy;

	private RequestCachePolicy _cachePolicy;

	private static XmlDownloadManager DownloadManager => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlUrlResolver" /> class.</summary>
	public XmlUrlResolver()
	{
	}

	/// <summary>Maps a URI to an object that contains the actual resource.</summary>
	/// <param name="absoluteUri">The URI returned from <see cref="M:System.Xml.XmlResolver.ResolveUri(System.Uri,System.String)" />.</param>
	/// <param name="role">Currently not used.</param>
	/// <param name="ofObjectToReturn">The type of object to return. The current implementation only returns <see cref="T:System.IO.Stream" /> objects.</param>
	/// <returns>A stream object or <see langword="null" /> if a type other than stream is specified.</returns>
	/// <exception cref="T:System.Xml.XmlException">
	///         <paramref name="ofObjectToReturn" /> is neither <see langword="null" /> nor a <see langword="Stream" /> type.</exception>
	/// <exception cref="T:System.UriFormatException">The specified URI is not an absolute URI.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="absoluteUri" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Exception">There is a runtime error (for example, an interrupted server connection).</exception>
	public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn)
	{
		return null;
	}

	/// <summary>Resolves the absolute URI from the base and relative URIs.</summary>
	/// <param name="baseUri">The base URI used to resolve the relative URI.</param>
	/// <param name="relativeUri">The URI to resolve. The URI can be absolute or relative. If absolute, this value effectively replaces the <paramref name="baseUri" /> value. If relative, it combines with the <paramref name="baseUri" /> to make an absolute URI.</param>
	/// <returns>The absolute URI, or <see langword="null" /> if the relative URI cannot be resolved.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="baseUri" /> is <see langword="null" /> or <paramref name="relativeUri" /> is <see langword="null" />.</exception>
	public override Uri ResolveUri(Uri baseUri, string relativeUri)
	{
		return null;
	}

	/// <summary>Asynchronously maps a URI to an object that contains the actual resource.</summary>
	/// <param name="absoluteUri">The URI returned from <see cref="M:System.Xml.XmlResolver.ResolveUri(System.Uri,System.String)" />.</param>
	/// <param name="role">Currently not used.</param>
	/// <param name="ofObjectToReturn">The type of object to return. The current implementation only returns <see cref="T:System.IO.Stream" /> objects.</param>
	/// <returns>A stream object or <see langword="null" /> if a type other than stream is specified.</returns>
	[AsyncStateMachine(typeof(_003CGetEntityAsync_003Ed__15))]
	public override Task<object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn)
	{
		return null;
	}
}
