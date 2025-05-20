using System.Drawing.Imaging;

namespace System.Drawing;

internal struct GdipPropertyItem
{
	internal int id;

	internal int len;

	internal short type;

	internal IntPtr value;

	internal static void MarshalTo(GdipPropertyItem gdipProp, PropertyItem prop)
	{
	}
}
