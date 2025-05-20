namespace System.Security;

/// <summary>Defines the methods that convert permission object state to and from XML element representation.</summary>
public interface ISecurityEncodable
{
	/// <summary>Creates an XML encoding of the security object and its current state.</summary>
	/// <returns>An XML encoding of the security object, including any state information.</returns>
	SecurityElement ToXml();
}
