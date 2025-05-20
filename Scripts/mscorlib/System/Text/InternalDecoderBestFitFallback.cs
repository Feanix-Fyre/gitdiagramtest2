namespace System.Text;

[Serializable]
internal sealed class InternalDecoderBestFitFallback : DecoderFallback
{
	internal Encoding _encoding;

	internal char[] _arrayBestFit;

	internal char _cReplacement;

	public override int MaxCharCount => 0;

	internal InternalDecoderBestFitFallback(Encoding encoding)
	{
	}

	public override DecoderFallbackBuffer CreateFallbackBuffer()
	{
		return null;
	}

	public override bool Equals(object value)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
