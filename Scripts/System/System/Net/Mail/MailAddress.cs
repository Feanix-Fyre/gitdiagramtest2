using System.Net.Mime;
using System.Text;

namespace System.Net.Mail;

/// <summary>Represents the address of an electronic mail sender or recipient.</summary>
public class MailAddress
{
	private readonly Encoding _displayNameEncoding;

	private readonly string _displayName;

	private readonly string _userName;

	private readonly string _host;

	private static readonly EncodedStreamFactory s_encoderFactory;

	/// <summary>Gets the display name composed from the display name and address information specified when this instance was created.</summary>
	/// <returns>A <see cref="T:System.String" /> that contains the display name; otherwise, <see cref="F:System.String.Empty" /> ("") if no display name information was specified when this instance was created.</returns>
	public string DisplayName => null;

	/// <summary>Gets the email address specified when this instance was created.</summary>
	/// <returns>A <see cref="T:System.String" /> that contains the email address.</returns>
	public string Address => null;

	private string SmtpAddress => null;

	internal MailAddress(string displayName, string userName, string domain)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Mail.MailAddress" /> class using the specified address.</summary>
	/// <param name="address">A <see cref="T:System.String" /> that contains an email address.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="address" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="address" /> is <see cref="F:System.String.Empty" /> ("").</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="address" /> is not in a recognized format.</exception>
	public MailAddress(string address)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Mail.MailAddress" /> class using the specified address, display name, and encoding.</summary>
	/// <param name="address">A <see cref="T:System.String" /> that contains an email address.</param>
	/// <param name="displayName">A <see cref="T:System.String" /> that contains the display name associated with <paramref name="address" />.</param>
	/// <param name="displayNameEncoding">The <see cref="T:System.Text.Encoding" /> that defines the character set used for <paramref name="displayName" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="address" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="displayName" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="address" /> is <see cref="F:System.String.Empty" /> ("").  
	/// -or-  
	/// <paramref name="displayName" /> is <see cref="F:System.String.Empty" /> ("").</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="address" /> is not in a recognized format.  
	/// -or-  
	/// <paramref name="address" /> contains non-ASCII characters.</exception>
	public MailAddress(string address, string displayName, Encoding displayNameEncoding)
	{
	}

	/// <summary>Returns a string representation of this instance.</summary>
	/// <returns>A <see cref="T:System.String" /> that contains the contents of this <see cref="T:System.Net.Mail.MailAddress" />.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Compares two mail addresses.</summary>
	/// <param name="value">A <see cref="T:System.Net.Mail.MailAddress" /> instance to compare to the current instance.</param>
	/// <returns>
	///   <see langword="true" /> if the two mail addresses are equal; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object value)
	{
		return false;
	}

	/// <summary>Returns a hash value for a mail address.</summary>
	/// <returns>An integer hash value.</returns>
	public override int GetHashCode()
	{
		return 0;
	}
}
