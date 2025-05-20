using System.Runtime.InteropServices;

namespace System.Drawing.Imaging;

/// <summary>Used to pass a value, or an array of values, to an image encoder.</summary>
[StructLayout((LayoutKind)0)]
public sealed class EncoderParameter : IDisposable
{
	private Guid _parameterGuid;

	private int _numberOfValues;

	private EncoderParameterValueType _parameterValueType;

	private IntPtr _parameterValue;

	/// <summary>Releases all resources used by this <see cref="T:System.Drawing.Imaging.EncoderParameter" /> object.</summary>
	public void Dispose()
	{
	}

	private void Dispose(bool disposing)
	{
	}
}
