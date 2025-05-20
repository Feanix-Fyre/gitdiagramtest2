namespace System.Drawing.Imaging;

/// <summary>Encapsulates an array of <see cref="T:System.Drawing.Imaging.EncoderParameter" /> objects.</summary>
public sealed class EncoderParameters
{
	private EncoderParameter[] _param;

	internal IntPtr ConvertToMemory()
	{
		return (IntPtr)0;
	}
}
