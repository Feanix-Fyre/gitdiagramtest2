using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Drawing.Imaging;

/// <summary>Defines a 5 x 5 matrix that contains the coordinates for the RGBAW space. Several methods of the <see cref="T:System.Drawing.Imaging.ImageAttributes" /> class adjust image colors by using a color matrix. This class cannot be inherited.</summary>
[StructLayout((LayoutKind)0)]
[DefaultMember("Item")]
public sealed class ColorMatrix
{
	private float _matrix00;

	private float _matrix01;

	private float _matrix02;

	private float _matrix03;

	private float _matrix04;

	private float _matrix10;

	private float _matrix11;

	private float _matrix12;

	private float _matrix13;

	private float _matrix14;

	private float _matrix20;

	private float _matrix21;

	private float _matrix22;

	private float _matrix23;

	private float _matrix24;

	private float _matrix30;

	private float _matrix31;

	private float _matrix32;

	private float _matrix33;

	private float _matrix34;

	private float _matrix40;

	private float _matrix41;

	private float _matrix42;

	private float _matrix43;

	private float _matrix44;

	/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Imaging.ColorMatrix" /> class using the elements in the specified matrix <paramref name="newColorMatrix" />.</summary>
	/// <param name="newColorMatrix">The values of the elements for the new <see cref="T:System.Drawing.Imaging.ColorMatrix" />.</param>
	[CLSCompliant(false)]
	public ColorMatrix(float[][] newColorMatrix)
	{
	}

	internal void SetMatrix(float[][] newColorMatrix)
	{
	}
}
