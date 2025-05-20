namespace System.Security.Authentication;

/// <summary>Defines the possible versions of <see cref="T:System.Security.Authentication.SslProtocols" />.</summary>
[Flags]
public enum SslProtocols
{
	/// <summary>Allows the operating system to choose the best protocol to use, and to block protocols that are not secure. Unless your app has a specific reason not to, you should use this field.</summary>
	None = 0,
	/// <summary>Specifies the SSL 2.0 protocol. SSL 2.0 has been superseded by the TLS protocol and is provided for backward compatibility only.</summary>
	Ssl2 = 0xC,
	/// <summary>Specifies the SSL 3.0 protocol. SSL 3.0 has been superseded by the TLS protocol and is provided for backward compatibility only.</summary>
	Ssl3 = 0x30,
	/// <summary>Specifies the TLS 1.0 security protocol. The TLS protocol is defined in IETF RFC 2246.</summary>
	Tls = 0xC0,
	/// <summary>Specifies the TLS 1.1 security protocol. The TLS protocol is defined in IETF RFC 4346.</summary>
	[System.MonoTODO("unsupported")]
	Tls11 = 0x300,
	/// <summary>Specifies the TLS 1.2 security protocol. The TLS protocol is defined in IETF RFC 5246.</summary>
	[System.MonoTODO("unsupported")]
	Tls12 = 0xC00,
	/// <summary>Specifies the TLS 1.3 security protocol. The TLS protocol is defined in IETF RFC 8446.</summary>
	Tls13 = 0x3000,
	/// <summary>Use None instead of Default. Default permits only the Secure Sockets Layer (SSL) 3.0 or Transport Layer Security (TLS) 1.0 protocols to be negotiated, and those options are now considered obsolete. Consequently, Default is not allowed in many organizations. Despite the name of this field, <see cref="T:System.Net.Security.SslStream" /> does not use it as a default except under special circumstances.</summary>
	Default = 0xF0
}
