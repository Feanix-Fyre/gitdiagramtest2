using System.Collections.Generic;
using System.Runtime.Serialization;

namespace System.Security.Claims;

/// <summary>Represents a claim.</summary>
[Serializable]
public class Claim
{
	private string m_issuer;

	private string m_originalIssuer;

	private string m_type;

	private string m_value;

	private string m_valueType;

	[NonSerialized]
	private byte[] m_userSerializationData;

	private Dictionary<string, string> m_properties;

	[NonSerialized]
	private object m_propertyLock;

	[NonSerialized]
	private ClaimsIdentity m_subject;

	/// <summary>Gets a dictionary that contains additional properties associated with this claim.</summary>
	/// <returns>A dictionary that contains additional properties associated with the claim. The properties are represented as name-value pairs.</returns>
	public IDictionary<string, string> Properties => null;

	/// <summary>Gets the subject of the claim.</summary>
	/// <returns>The subject of the claim.</returns>
	public ClaimsIdentity Subject
	{
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	/// <summary>Gets the claim type of the claim.</summary>
	/// <returns>The claim type.</returns>
	public string Type => null;

	/// <summary>Gets the value of the claim.</summary>
	/// <returns>The claim value.</returns>
	public string Value => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Claims.Claim" /> class with the specified claim type, value, value type, issuer, original issuer and subject.</summary>
	/// <param name="type">The claim type.</param>
	/// <param name="value">The claim value.</param>
	/// <param name="valueType">The claim value type. If this parameter is <see langword="null" />, then <see cref="F:System.Security.Claims.ClaimValueTypes.String" /> is used.</param>
	/// <param name="issuer">The claim issuer. If this parameter is empty or <see langword="null" />, then <see cref="F:System.Security.Claims.ClaimsIdentity.DefaultIssuer" /> is used.</param>
	/// <param name="originalIssuer">The original issuer of the claim. If this parameter is empty or <see langword="null" />, then the <see cref="P:System.Security.Claims.Claim.OriginalIssuer" /> property is set to the value of the <see cref="P:System.Security.Claims.Claim.Issuer" /> property.</param>
	/// <param name="subject">The subject that this claim describes.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="type" /> or <paramref name="value" /> is <see langword="null" />.</exception>
	public Claim(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject)
	{
	}

	internal Claim(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject, string propertyKey, string propertyValue)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Claims.Claim" /> class with the specified security claim and subject.</summary>
	/// <param name="other">The security claim.</param>
	/// <param name="subject">The subject that this claim describes.</param>
	protected Claim(Claim other, ClaimsIdentity subject)
	{
	}

	[OnDeserialized]
	private void OnDeserializedMethod(StreamingContext context)
	{
	}

	/// <summary>Returns a new <see cref="T:System.Security.Claims.Claim" /> object copied from this object. The subject of the new claim is set to the specified ClaimsIdentity.</summary>
	/// <param name="identity">The intended subject of the new claim.</param>
	/// <returns>The new claim object.</returns>
	public virtual Claim Clone(ClaimsIdentity identity)
	{
		return null;
	}

	/// <summary>Returns a string representation of this <see cref="T:System.Security.Claims.Claim" /> object.</summary>
	/// <returns>The string representation of this <see cref="T:System.Security.Claims.Claim" /> object.</returns>
	public override string ToString()
	{
		return null;
	}
}
