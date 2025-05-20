using System.Collections;
using System.IO;
using System.Net.Cache;
using System.Net.Security;
using System.Runtime.Serialization;
using System.Security.Principal;
using System.Threading.Tasks;

namespace System.Net;

/// <summary>Makes a request to a Uniform Resource Identifier (URI). This is an <see langword="abstract" /> class.</summary>
[Serializable]
public abstract class WebRequest : MarshalByRefObject, ISerializable
{
	internal class DesignerWebRequestCreate : IWebRequestCreate
	{
		public WebRequest Create(Uri uri)
		{
			return null;
		}
	}

	private static ArrayList s_PrefixList;

	private static object s_InternalSyncObject;

	private static TimerThread.Queue s_DefaultTimerQueue;

	private AuthenticationLevel m_AuthenticationLevel;

	private TokenImpersonationLevel m_ImpersonationLevel;

	private RequestCachePolicy m_CachePolicy;

	private RequestCacheProtocol m_CacheProtocol;

	private RequestCacheBinding m_CacheBinding;

	private static DesignerWebRequestCreate webRequestCreate;

	private static IWebProxy s_DefaultWebProxy;

	private static bool s_DefaultWebProxyInitialized;

	private static object InternalSyncObject => null;

	internal static ArrayList PrefixList => null;

	/// <summary>Gets or sets the default cache policy for this request.</summary>
	/// <returns>A <see cref="T:System.Net.Cache.HttpRequestCachePolicy" /> that specifies the cache policy in effect for this request when no other policy is applicable.</returns>
	public static RequestCachePolicy DefaultCachePolicy => null;

	/// <summary>Gets or sets the cache policy for this request.</summary>
	/// <returns>A <see cref="T:System.Net.Cache.RequestCachePolicy" /> object that defines a cache policy.</returns>
	public virtual RequestCachePolicy CachePolicy
	{
		set
		{
		}
	}

	/// <summary>When overridden in a descendant class, gets or sets the protocol method to use in this request.</summary>
	/// <returns>The protocol method to use in this request.</returns>
	/// <exception cref="T:System.NotImplementedException">If the property is not overridden in a descendant class, any attempt is made to get or set the property.</exception>
	public virtual string Method
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>When overridden in a descendant class, gets the URI of the Internet resource associated with the request.</summary>
	/// <returns>A <see cref="T:System.Uri" /> representing the resource associated with the request</returns>
	/// <exception cref="T:System.NotImplementedException">Any attempt is made to get or set the property, when the property is not overridden in a descendant class.</exception>
	public virtual Uri RequestUri => null;

	/// <summary>When overridden in a descendant class, gets or sets the name of the connection group for the request.</summary>
	/// <returns>The name of the connection group for the request.</returns>
	/// <exception cref="T:System.NotImplementedException">Any attempt is made to get or set the property, when the property is not overridden in a descendant class.</exception>
	public virtual string ConnectionGroupName
	{
		set
		{
		}
	}

	/// <summary>When overridden in a descendant class, gets or sets the collection of header name/value pairs associated with the request.</summary>
	/// <returns>A <see cref="T:System.Net.WebHeaderCollection" /> containing the header name/value pairs associated with this request.</returns>
	/// <exception cref="T:System.NotImplementedException">Any attempt is made to get or set the property, when the property is not overridden in a descendant class.</exception>
	public virtual WebHeaderCollection Headers => null;

	/// <summary>When overridden in a descendant class, gets or sets the content length of the request data being sent.</summary>
	/// <returns>The number of bytes of request data being sent.</returns>
	/// <exception cref="T:System.NotImplementedException">Any attempt is made to get or set the property, when the property is not overridden in a descendant class.</exception>
	public virtual long ContentLength
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	/// <summary>When overridden in a descendant class, gets or sets the network credentials used for authenticating the request with the Internet resource.</summary>
	/// <returns>An <see cref="T:System.Net.ICredentials" /> containing the authentication credentials associated with the request. The default is <see langword="null" />.</returns>
	/// <exception cref="T:System.NotImplementedException">Any attempt is made to get or set the property, when the property is not overridden in a descendant class.</exception>
	public virtual ICredentials Credentials
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>When overridden in a descendant class, gets or sets a <see cref="T:System.Boolean" /> value that controls whether <see cref="P:System.Net.CredentialCache.DefaultCredentials" /> are sent with requests.</summary>
	/// <returns>
	///   <see langword="true" /> if the default credentials are used; otherwise <see langword="false" />. The default value is <see langword="false" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">You attempted to set this property after the request was sent.</exception>
	/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the property, when the property is not overridden in a descendant class.</exception>
	public virtual bool UseDefaultCredentials => false;

	/// <summary>When overridden in a descendant class, gets or sets the network proxy to use to access this Internet resource.</summary>
	/// <returns>The <see cref="T:System.Net.IWebProxy" /> to use to access the Internet resource.</returns>
	/// <exception cref="T:System.NotImplementedException">Any attempt is made to get or set the property, when the property is not overridden in a descendant class.</exception>
	public virtual IWebProxy Proxy
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>When overridden in a descendant class, indicates whether to pre-authenticate the request.</summary>
	/// <returns>
	///   <see langword="true" /> to pre-authenticate; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.NotImplementedException">Any attempt is made to get or set the property, when the property is not overridden in a descendant class.</exception>
	public virtual bool PreAuthenticate
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the length of time, in milliseconds, before the request times out.</summary>
	/// <returns>The length of time, in milliseconds, until the request times out, or the value <see cref="F:System.Threading.Timeout.Infinite" /> to indicate that the request does not time out. The default value is defined by the descendant class.</returns>
	/// <exception cref="T:System.NotImplementedException">Any attempt is made to get or set the property, when the property is not overridden in a descendant class.</exception>
	public virtual int Timeout
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal RequestCacheProtocol CacheProtocol
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal static IWebProxy InternalDefaultWebProxy => null;

	private static WebRequest Create(Uri requestUri, bool useUriBase)
	{
		return null;
	}

	/// <summary>Initializes a new <see cref="T:System.Net.WebRequest" /> instance for the specified URI scheme.</summary>
	/// <param name="requestUriString">The URI that identifies the Internet resource.</param>
	/// <returns>A <see cref="T:System.Net.WebRequest" /> descendant for the specific URI scheme.</returns>
	/// <exception cref="T:System.NotSupportedException">The request scheme specified in <paramref name="requestUriString" /> has not been registered.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="requestUriString" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have <see cref="T:System.Net.WebPermissionAttribute" /> permission to connect to the requested URI or a URI that the request is redirected to.</exception>
	/// <exception cref="T:System.UriFormatException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.FormatException" />, instead.  
	///
	///
	///
	///
	///  The URI specified in <paramref name="requestUriString" /> is not a valid URI.</exception>
	public static WebRequest Create(string requestUriString)
	{
		return null;
	}

	/// <summary>Initializes a new <see cref="T:System.Net.WebRequest" /> instance for the specified URI scheme.</summary>
	/// <param name="requestUri">A <see cref="T:System.Uri" /> containing the URI of the requested resource.</param>
	/// <returns>A <see cref="T:System.Net.WebRequest" /> descendant for the specified URI scheme.</returns>
	/// <exception cref="T:System.NotSupportedException">The request scheme specified in <paramref name="requestUri" /> is not registered.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="requestUri" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have <see cref="T:System.Net.WebPermissionAttribute" /> permission to connect to the requested URI or a URI that the request is redirected to.</exception>
	public static WebRequest Create(Uri requestUri)
	{
		return null;
	}

	private static ArrayList PopulatePrefixList()
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebRequest" /> class.</summary>
	protected WebRequest()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebRequest" /> class from the specified instances of the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> classes.</summary>
	/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that contains the information required to serialize the new <see cref="T:System.Net.WebRequest" /> instance.</param>
	/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that indicates the source of the serialized stream associated with the new <see cref="T:System.Net.WebRequest" /> instance.</param>
	/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the constructor, when the constructor is not overridden in a descendant class.</exception>
	protected WebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	/// <summary>When overridden in a descendant class, populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> instance with the data needed to serialize the <see cref="T:System.Net.WebRequest" />.</summary>
	/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" />, which holds the serialized data for the <see cref="T:System.Net.WebRequest" />.</param>
	/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains the destination of the serialized stream associated with the new <see cref="T:System.Net.WebRequest" />.</param>
	/// <exception cref="T:System.NotImplementedException">An attempt is made to serialize the object, when the interface is not overridden in a descendant class.</exception>
	void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data needed to serialize the target object.</summary>
	/// <param name="serializationInfo">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data.</param>
	/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that specifies the destination for this serialization.</param>
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	private void InternalSetCachePolicy(RequestCachePolicy policy)
	{
	}

	/// <summary>When overridden in a descendant class, returns a response to an Internet request.</summary>
	/// <returns>A <see cref="T:System.Net.WebResponse" /> containing the response to the Internet request.</returns>
	/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the method, when the method is not overridden in a descendant class.</exception>
	public virtual WebResponse GetResponse()
	{
		return null;
	}

	/// <summary>When overridden in a descendant class, begins an asynchronous request for an Internet resource.</summary>
	/// <param name="callback">The <see cref="T:System.AsyncCallback" /> delegate.</param>
	/// <param name="state">An object containing state information for this asynchronous request.</param>
	/// <returns>An <see cref="T:System.IAsyncResult" /> that references the asynchronous request.</returns>
	/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the method, when the method is not overridden in a descendant class.</exception>
	public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
	{
		return null;
	}

	/// <summary>When overridden in a descendant class, returns a <see cref="T:System.Net.WebResponse" />.</summary>
	/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> that references a pending request for a response.</param>
	/// <returns>A <see cref="T:System.Net.WebResponse" /> that contains a response to the Internet request.</returns>
	/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the method, when the method is not overridden in a descendant class.</exception>
	public virtual WebResponse EndGetResponse(IAsyncResult asyncResult)
	{
		return null;
	}

	/// <summary>When overridden in a descendant class, provides an asynchronous version of the <see cref="M:System.Net.WebRequest.GetRequestStream" /> method.</summary>
	/// <param name="callback">The <see cref="T:System.AsyncCallback" /> delegate.</param>
	/// <param name="state">An object containing state information for this asynchronous request.</param>
	/// <returns>An <see cref="T:System.IAsyncResult" /> that references the asynchronous request.</returns>
	/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the method, when the method is not overridden in a descendant class.</exception>
	public virtual IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
	{
		return null;
	}

	/// <summary>When overridden in a descendant class, returns a <see cref="T:System.IO.Stream" /> for writing data to the Internet resource.</summary>
	/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> that references a pending request for a stream.</param>
	/// <returns>A <see cref="T:System.IO.Stream" /> to write data to.</returns>
	/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the method, when the method is not overridden in a descendant class.</exception>
	public virtual Stream EndGetRequestStream(IAsyncResult asyncResult)
	{
		return null;
	}

	/// <summary>When overridden in a descendant class, returns a <see cref="T:System.IO.Stream" /> for writing data to the Internet resource as an asynchronous operation.</summary>
	/// <returns>The task object representing the asynchronous operation.</returns>
	public virtual Task<Stream> GetRequestStreamAsync()
	{
		return null;
	}

	/// <summary>When overridden in a descendant class, returns a response to an Internet request as an asynchronous operation.</summary>
	/// <returns>The task object representing the asynchronous operation.</returns>
	public virtual Task<WebResponse> GetResponseAsync()
	{
		return null;
	}

	private WindowsIdentity SafeCaptureIdenity()
	{
		return null;
	}

	/// <summary>Aborts the request.</summary>
	/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the method, when the method is not overridden in a descendant class.</exception>
	public virtual void Abort()
	{
	}
}
