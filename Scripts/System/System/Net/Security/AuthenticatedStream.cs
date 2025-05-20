using System.IO;

namespace System.Net.Security;

/// <summary>Provides methods for passing credentials across a stream and requesting or performing authentication for client-server applications.</summary>
public abstract class AuthenticatedStream : Stream
{
	private Stream _InnerStream;

	private bool _LeaveStreamOpen;

	/// <summary>Gets the stream used by this <see cref="T:System.Net.Security.AuthenticatedStream" /> for sending and receiving data.</summary>
	/// <returns>A <see cref="T:System.IO.Stream" /> object.</returns>
	protected Stream InnerStream => null;

	/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether authentication was successful.</summary>
	/// <returns>
	///   <see langword="true" /> if successful authentication occurred; otherwise, <see langword="false" />.</returns>
	public abstract bool IsAuthenticated { get; }

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Security.AuthenticatedStream" /> class.</summary>
	/// <param name="innerStream">A <see cref="T:System.IO.Stream" /> object used by the <see cref="T:System.Net.Security.AuthenticatedStream" /> for sending and receiving data.</param>
	/// <param name="leaveInnerStreamOpen">A <see cref="T:System.Boolean" /> that indicates whether closing this <see cref="T:System.Net.Security.AuthenticatedStream" /> object also closes <paramref name="innerStream" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="innerStream" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="innerStream" /> is equal to <see cref="F:System.IO.Stream.Null" />.</exception>
	protected AuthenticatedStream(Stream innerStream, bool leaveInnerStreamOpen)
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Net.Security.AuthenticatedStream" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}
}
