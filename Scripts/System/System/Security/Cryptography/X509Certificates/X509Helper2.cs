using Mono.Security.X509;

namespace System.Security.Cryptography.X509Certificates;

internal static class X509Helper2
{
	[System.MonoTODO("Investigate replacement; see comments in source.")]
	internal static Mono.Security.X509.X509Certificate GetMonoCertificate(X509Certificate2 certificate)
	{
		return null;
	}

	internal static X509ChainImpl CreateChainImpl(bool useMachineContext)
	{
		return null;
	}

	public static bool IsValid(X509ChainImpl impl)
	{
		return false;
	}

	internal static void ThrowIfContextInvalid(X509ChainImpl impl)
	{
	}

	internal static Exception GetInvalidChainContextException()
	{
		return null;
	}
}
