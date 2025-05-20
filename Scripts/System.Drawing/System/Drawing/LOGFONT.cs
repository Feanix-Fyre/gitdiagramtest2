using System.Runtime.InteropServices;

namespace System.Drawing;

[StructLayout((LayoutKind)0, CharSet = CharSet.Auto)]
internal struct LOGFONT
{
	internal int lfHeight;

	internal uint lfWidth;

	internal uint lfEscapement;

	internal uint lfOrientation;

	internal uint lfWeight;

	internal byte lfItalic;

	internal byte lfUnderline;

	internal byte lfStrikeOut;

	internal byte lfCharSet;

	internal byte lfOutPrecision;

	internal byte lfClipPrecision;

	internal byte lfQuality;

	internal byte lfPitchAndFamily;

	internal string lfFaceName;
}
