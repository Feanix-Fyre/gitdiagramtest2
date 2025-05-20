namespace Mono.Math.Prime.Generator;

internal abstract class PrimeGeneratorBase
{
	public virtual ConfidenceFactor Confidence => default(ConfidenceFactor);

	public virtual PrimalityTest PrimalityTest => null;

	public virtual int TrialDivisionBounds => 0;

	public abstract BigInteger GenerateNewPrime(int bits);
}
