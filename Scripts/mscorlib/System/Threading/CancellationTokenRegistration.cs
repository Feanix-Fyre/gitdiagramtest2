namespace System.Threading;

/// <summary>Represents a callback delegate that has been registered with a <see cref="T:System.Threading.CancellationToken" />.</summary>
public readonly struct CancellationTokenRegistration : IEquatable<CancellationTokenRegistration>, IDisposable
{
	private readonly CancellationCallbackInfo m_callbackInfo;

	private readonly SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> m_registrationInfo;

	internal CancellationTokenRegistration(CancellationCallbackInfo callbackInfo, SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> registrationInfo)
	{
		m_callbackInfo = null;
		m_registrationInfo = default(SparselyPopulatedArrayAddInfo<CancellationCallbackInfo>);
	}

	public bool Unregister()
	{
		return false;
	}

	/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Threading.CancellationTokenRegistration" /> class.</summary>
	public void Dispose()
	{
	}

	/// <summary>Determines whether the current <see cref="T:System.Threading.CancellationTokenRegistration" /> instance is equal to the specified <see cref="T:System.Threading.CancellationTokenRegistration" />.</summary>
	/// <param name="obj">The other object to which to compare this instance.</param>
	/// <returns>True, if both this and <paramref name="obj" /> are equal. False, otherwise.  
	///  Two <see cref="T:System.Threading.CancellationTokenRegistration" /> instances are equal if they both refer to the output of a single call to the same Register method of a <see cref="T:System.Threading.CancellationToken" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Determines whether the current <see cref="T:System.Threading.CancellationTokenRegistration" /> instance is equal to the specified <see cref="T:System.Threading.CancellationTokenRegistration" />.</summary>
	/// <param name="other">The other <see cref="T:System.Threading.CancellationTokenRegistration" /> to which to compare this instance.</param>
	/// <returns>True, if both this and <paramref name="other" /> are equal. False, otherwise.  
	///  Two <see cref="T:System.Threading.CancellationTokenRegistration" /> instances are equal if they both refer to the output of a single call to the same Register method of a <see cref="T:System.Threading.CancellationToken" />.</returns>
	public bool Equals(CancellationTokenRegistration other)
	{
		return false;
	}

	/// <summary>Serves as a hash function for a <see cref="T:System.Threading.CancellationTokenRegistration" />.</summary>
	/// <returns>A hash code for the current <see cref="T:System.Threading.CancellationTokenRegistration" /> instance.</returns>
	public override int GetHashCode()
	{
		return 0;
	}
}
