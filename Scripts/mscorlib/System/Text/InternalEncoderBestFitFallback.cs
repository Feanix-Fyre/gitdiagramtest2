namespace System.Text;

[Serializable]
internal class InternalEncoderBestFitFallback : EncoderFallback
{
	internal Encoding _encoding;

	internal char[] _arrayBestFit;

	public override int MaxCharCount => 0;

	internal InternalEncoderBestFitFallback(Encoding encoding)
	{
	}

	public override EncoderFallbackBuffer CreateFallbackBuffer()
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
