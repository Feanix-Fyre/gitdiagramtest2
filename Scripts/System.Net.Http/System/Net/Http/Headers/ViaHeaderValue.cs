using System.Collections.Generic;

namespace System.Net.Http.Headers;

/// <summary>Represents the value of a Via header.</summary>
public class ViaHeaderValue : ICloneable
{
	/// <summary>Gets the comment field used to identify the software of the recipient proxy or gateway.</summary>
	/// <returns>The comment field used to identify the software of the recipient proxy or gateway.</returns>
	public string Comment { get; private set; }

	/// <summary>Gets the protocol name of the received protocol.</summary>
	/// <returns>The protocol name.</returns>
	public string ProtocolName { get; private set; }

	/// <summary>Gets the protocol version of the received protocol.</summary>
	/// <returns>The protocol version.</returns>
	public string ProtocolVersion { get; private set; }

	/// <summary>Gets the host and port that the request or response was received by.</summary>
	/// <returns>The host and port that the request or response was received by.</returns>
	public string ReceivedBy { get; private set; }

	private ViaHeaderValue()
	{
	}

	/// <summary>Creates a new object that is a copy of the current <see cref="T:System.Net.Http.Headers.ViaHeaderValue" /> instance.</summary>
	/// <returns>A copy of the current instance.</returns>
	object ICloneable.Clone()
	{
		return null;
	}

	/// <summary>Determines whether the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Net.Http.Headers.ViaHeaderValue" /> object.</summary>
	/// <param name="obj">The object to compare with the current object.</param>
	/// <returns>
	///   <see langword="true" /> if the specified <see cref="T:System.Object" /> is equal to the current object; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Serves as a hash function for an <see cref="T:System.Net.Http.Headers.ViaHeaderValue" /> object.</summary>
	/// <returns>A hash code for the current object.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	internal static bool TryParse(string input, int minimalCount, out List<ViaHeaderValue> result)
	{
		result = null;
		return false;
	}

	private static bool TryParseElement(Lexer lexer, out ViaHeaderValue parsedValue, out Token t)
	{
		parsedValue = null;
		t = default(Token);
		return false;
	}

	/// <summary>Returns a string that represents the current <see cref="T:System.Net.Http.Headers.ViaHeaderValue" /> object.</summary>
	/// <returns>A string that represents the current object.</returns>
	public override string ToString()
	{
		return null;
	}
}
