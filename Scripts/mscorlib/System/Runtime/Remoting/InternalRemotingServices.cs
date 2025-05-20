using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata;

namespace System.Runtime.Remoting;

/// <summary>Defines utility methods for use by the .NET Framework remoting infrastructure.</summary>
[ComVisible(true)]
public class InternalRemotingServices
{
	private static Hashtable _soapAttributes;

	/// <summary>Gets an appropriate SOAP-related attribute for the specified class member or method parameter.</summary>
	/// <param name="reflectionObject">A class member or method parameter.</param>
	/// <returns>The SOAP-related attribute for the specified class member or method parameter.</returns>
	public static SoapAttribute GetCachedSoapAttribute(object reflectionObject)
	{
		return null;
	}
}
