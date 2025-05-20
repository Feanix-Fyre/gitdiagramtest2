using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace System.Drawing;

internal class GDIPlus
{
	public delegate int StreamGetHeaderDelegate(IntPtr buf, int bufsz);

	public delegate int StreamGetBytesDelegate(IntPtr buf, int bufsz, bool peek);

	public delegate long StreamSeekDelegate(int offset, int whence);

	public delegate int StreamPutBytesDelegate(IntPtr buf, int bufsz);

	public delegate void StreamCloseDelegate();

	public delegate long StreamSizeDelegate();

	internal sealed class GdiPlusStreamHelper
	{
		public Stream stream;

		private StreamGetHeaderDelegate sghd;

		private StreamGetBytesDelegate sgbd;

		private StreamSeekDelegate skd;

		private StreamPutBytesDelegate spbd;

		private StreamCloseDelegate scd;

		private StreamSizeDelegate ssd;

		private byte[] start_buf;

		private int start_buf_pos;

		private int start_buf_len;

		private byte[] managedBuf;

		public StreamGetHeaderDelegate GetHeaderDelegate => null;

		public StreamGetBytesDelegate GetBytesDelegate => null;

		public StreamSeekDelegate SeekDelegate => null;

		public StreamPutBytesDelegate PutBytesDelegate => null;

		public StreamCloseDelegate CloseDelegate => null;

		public StreamSizeDelegate SizeDelegate => null;

		public GdiPlusStreamHelper(Stream s, bool seekToOrigin)
		{
		}

		public int StreamGetHeaderImpl(IntPtr buf, int bufsz)
		{
			return 0;
		}

		public int StreamGetBytesImpl(IntPtr buf, int bufsz, bool peek)
		{
			return 0;
		}

		public long StreamSeekImpl(int offset, int whence)
		{
			return 0L;
		}

		public int StreamPutBytesImpl(IntPtr buf, int bufsz)
		{
			return 0;
		}

		public void StreamCloseImpl()
		{
		}

		public long StreamSizeImpl()
		{
			return 0L;
		}
	}

	public static IntPtr Display;

	public static bool UseX11Drawable;

	public static bool UseCarbonDrawable;

	public static bool UseCocoaDrawable;

	internal static ulong GdiPlusToken;

	[PreserveSig]
	internal static extern Status GdiplusStartup(ref ulong token, ref GdiplusStartupInput input, ref GdiplusStartupOutput output);

	private static void ProcessExit(object sender, EventArgs e)
	{
	}

	static GDIPlus()
	{
	}

	public static bool RunningOnWindows()
	{
		return false;
	}

	public static bool RunningOnUnix()
	{
		return false;
	}

	internal static void CheckStatus(Status status)
	{
	}

	[PreserveSig]
	internal static extern int GdipCloneBrush(HandleRef brush, out IntPtr clonedBrush);

	[PreserveSig]
	internal static extern int GdipDeleteBrush(HandleRef brush);

	[PreserveSig]
	internal static extern Status GdipCreateRegion(out IntPtr region);

	[PreserveSig]
	internal static extern Status GdipDeleteRegion(IntPtr region);

	[PreserveSig]
	internal static extern Status GdipCreateRegionRectI(ref Rectangle rect, out IntPtr region);

	[PreserveSig]
	internal static extern Status GdipCombineRegionRectI(IntPtr region, ref Rectangle rect, CombineMode combineMode);

	[PreserveSig]
	internal static extern Status GdipGetRegionBounds(IntPtr region, IntPtr graphics, ref RectangleF rect);

	[PreserveSig]
	internal static extern Status GdipSetEmpty(IntPtr region);

	[PreserveSig]
	internal static extern Status GdipIsInfiniteRegion(IntPtr region, IntPtr graphics, out bool result);

	[PreserveSig]
	internal static extern Status GdipCombineRegionRegion(IntPtr region, IntPtr region2, CombineMode combineMode);

	[PreserveSig]
	internal static extern Status GdipGetRegionHRgn(IntPtr region, IntPtr graphics, ref IntPtr hRgn);

	[PreserveSig]
	internal static extern Status GdipCreateRegionHrgn(IntPtr hRgn, out IntPtr region);

	[PreserveSig]
	internal static extern int GdipCreateSolidFill(int color, out IntPtr brush);

	[PreserveSig]
	internal static extern int GdipCreateHatchBrush(int hatchstyle, int foreColor, int backColor, out IntPtr brush);

	[PreserveSig]
	internal static extern int GdipCreateTexture(HandleRef image, int wrapMode, out IntPtr texture);

	[PreserveSig]
	internal static extern Status GdipCreateLineBrushI(ref Point point1, ref Point point2, int color1, int color2, WrapMode wrapMode, out IntPtr brush);

	[PreserveSig]
	internal static extern Status GdipCreateLineBrushFromRectI(ref Rectangle rect, int color1, int color2, LinearGradientMode linearGradientMode, WrapMode wrapMode, out IntPtr brush);

	[PreserveSig]
	internal static extern Status GdipGetLineRect(IntPtr brush, out RectangleF rect);

	[PreserveSig]
	internal static extern Status GdipCreateFromHDC(IntPtr hDC, out IntPtr graphics);

	[PreserveSig]
	internal static extern Status GdipDeleteGraphics(IntPtr graphics);

	[PreserveSig]
	internal static extern Status GdipRestoreGraphics(IntPtr graphics, uint graphicsState);

	[PreserveSig]
	internal static extern Status GdipSaveGraphics(IntPtr graphics, out uint state);

	[PreserveSig]
	internal static extern Status GdipRotateWorldTransform(IntPtr graphics, float angle, MatrixOrder order);

	[PreserveSig]
	internal static extern Status GdipTranslateWorldTransform(IntPtr graphics, float dx, float dy, MatrixOrder order);

	[PreserveSig]
	internal static extern Status GdipDrawLine(IntPtr graphics, IntPtr pen, float x1, float y1, float x2, float y2);

	[PreserveSig]
	internal static extern Status GdipDrawLineI(IntPtr graphics, IntPtr pen, int x1, int y1, int x2, int y2);

	[PreserveSig]
	internal static extern Status GdipDrawLinesI(IntPtr graphics, IntPtr pen, Point[] points, int count);

	[PreserveSig]
	internal static extern Status GdipDrawPolygonI(IntPtr graphics, IntPtr pen, Point[] points, int count);

	[PreserveSig]
	internal static extern Status GdipDrawRectangleI(IntPtr graphics, IntPtr pen, int x, int y, int width, int height);

	[PreserveSig]
	internal static extern Status GdipFillEllipseI(IntPtr graphics, IntPtr pen, int x, int y, int width, int height);

	[PreserveSig]
	internal static extern Status GdipFillPolygonI(IntPtr graphics, IntPtr brush, Point[] points, int count, FillMode fillMode);

	[PreserveSig]
	internal static extern Status GdipFillPolygon2(IntPtr graphics, IntPtr brush, PointF[] points, int count);

	[PreserveSig]
	internal static extern Status GdipFillRectangle(IntPtr graphics, IntPtr brush, float x1, float y1, float x2, float y2);

	[PreserveSig]
	internal static extern Status GdipFillRectangleI(IntPtr graphics, IntPtr brush, int x1, int y1, int x2, int y2);

	[PreserveSig]
	internal static extern Status GdipDrawString(IntPtr graphics, string text, int len, IntPtr font, ref RectangleF rc, IntPtr format, IntPtr brush);

	[PreserveSig]
	internal static extern Status GdipGetDC(IntPtr graphics, out IntPtr hdc);

	[PreserveSig]
	internal static extern Status GdipReleaseDC(IntPtr graphics, IntPtr hdc);

	[PreserveSig]
	internal static extern Status GdipDrawImageRectI(IntPtr graphics, IntPtr image, int x, int y, int width, int height);

	[PreserveSig]
	internal static extern Status GdipResetWorldTransform(IntPtr graphics);

	[PreserveSig]
	internal static extern Status GdipGetWorldTransform(IntPtr graphics, IntPtr matrix);

	[PreserveSig]
	internal static extern Status GdipGraphicsClear(IntPtr graphics, int argb);

	[PreserveSig]
	internal static extern Status GdipSetClipRectI(IntPtr graphics, int x, int y, int width, int height, CombineMode combineMode);

	[PreserveSig]
	internal static extern Status GdipSetClipRegion(IntPtr graphics, IntPtr region, CombineMode combineMode);

	[PreserveSig]
	internal static extern Status GdipResetClip(IntPtr graphics);

	[PreserveSig]
	internal static extern Status GdipGetClip(IntPtr graphics, IntPtr region);

	[PreserveSig]
	internal static extern Status GdipGetDpiX(IntPtr graphics, out float dpi);

	[PreserveSig]
	internal static extern Status GdipGetDpiY(IntPtr graphics, out float dpi);

	[PreserveSig]
	internal static extern Status GdipFlush(IntPtr graphics, FlushIntention intention);

	[PreserveSig]
	internal static extern Status GdipCreatePen1(int argb, float width, GraphicsUnit unit, out IntPtr pen);

	[PreserveSig]
	internal static extern Status GdipCreatePen2(IntPtr brush, float width, GraphicsUnit unit, out IntPtr pen);

	[PreserveSig]
	internal static extern Status GdipClonePen(IntPtr pen, out IntPtr clonepen);

	[PreserveSig]
	internal static extern Status GdipDeletePen(IntPtr pen);

	[PreserveSig]
	internal static extern Status GdipSetPenDashStyle(IntPtr pen, DashStyle dashStyle);

	[PreserveSig]
	internal static extern Status GdipGetPenWidth(IntPtr pen, out float width);

	[PreserveSig]
	internal static extern Status GdipCreateFromHWND(IntPtr hwnd, out IntPtr graphics);

	[PreserveSig]
	internal unsafe static extern Status GdipMeasureString(IntPtr graphics, string str, int length, IntPtr font, ref RectangleF layoutRect, IntPtr stringFormat, out RectangleF boundingBox, int* codepointsFitted, int* linesFilled);

	[PreserveSig]
	internal static extern Status GdipCreateBitmapFromScan0(int width, int height, int stride, PixelFormat format, IntPtr scan0, out IntPtr bmp);

	[PreserveSig]
	internal static extern Status GdipCreateBitmapFromGraphics(int width, int height, IntPtr target, out IntPtr bitmap);

	[PreserveSig]
	internal static extern Status GdipBitmapLockBits(IntPtr bmp, ref Rectangle rc, ImageLockMode flags, PixelFormat format, [In][Out] BitmapData bmpData);

	[PreserveSig]
	internal static extern Status GdipBitmapUnlockBits(IntPtr bmp, [In][Out] BitmapData bmpData);

	[PreserveSig]
	internal static extern Status GdipBitmapGetPixel(IntPtr bmp, int x, int y, out int argb);

	[PreserveSig]
	internal static extern Status GdipBitmapSetPixel(IntPtr bmp, int x, int y, int argb);

	[PreserveSig]
	internal static extern Status GdipLoadImageFromStream(IStream stream, out IntPtr image);

	[PreserveSig]
	internal static extern Status GdipSaveImageToStream(HandleRef image, IStream stream, [In] ref Guid clsidEncoder, HandleRef encoderParams);

	[PreserveSig]
	internal static extern Status GdipCloneImage(IntPtr image, out IntPtr imageclone);

	[PreserveSig]
	internal static extern Status GdipCreateBitmapFromHBITMAP(IntPtr hBitMap, IntPtr gdiPalette, out IntPtr image);

	[PreserveSig]
	internal static extern Status GdipDisposeImage(IntPtr image);

	[PreserveSig]
	internal static extern Status GdipGetImageType(IntPtr image, out ImageType type);

	[PreserveSig]
	internal static extern Status GdipImageGetFrameDimensionsCount(IntPtr image, out uint count);

	[PreserveSig]
	internal static extern Status GdipImageGetFrameDimensionsList(IntPtr image, [Out] Guid[] dimensionIDs, uint count);

	[PreserveSig]
	internal static extern Status GdipGetImageHeight(IntPtr image, out uint height);

	[PreserveSig]
	internal static extern Status GdipGetImagePaletteSize(IntPtr image, out int size);

	[PreserveSig]
	internal static extern Status GdipGetImagePalette(IntPtr image, IntPtr palette, int size);

	[PreserveSig]
	internal static extern Status GdipSetImagePalette(IntPtr image, IntPtr palette);

	[PreserveSig]
	internal static extern Status GdipGetImagePixelFormat(IntPtr image, out PixelFormat format);

	[PreserveSig]
	internal static extern Status GdipGetImageRawFormat(IntPtr image, out Guid format);

	[PreserveSig]
	internal static extern Status GdipGetImageWidth(IntPtr image, out uint width);

	[PreserveSig]
	internal static extern Status GdipImageGetFrameCount(IntPtr image, ref Guid guidDimension, out uint count);

	[PreserveSig]
	internal static extern Status GdipImageSelectActiveFrame(IntPtr image, ref Guid guidDimension, int frameIndex);

	[PreserveSig]
	internal static extern Status GdipGetPropertyItemSize(IntPtr image, int propertyID, out int propertySize);

	[PreserveSig]
	internal static extern Status GdipGetPropertyItem(IntPtr image, int propertyID, int propertySize, IntPtr buffer);

	[PreserveSig]
	internal static extern Status GdipImageRotateFlip(IntPtr image, RotateFlipType rotateFlipType);

	[PreserveSig]
	internal static extern Status GdipDrawImageI(IntPtr graphics, IntPtr image, int x, int y);

	[PreserveSig]
	internal static extern Status GdipGetImageGraphicsContext(IntPtr image, out IntPtr graphics);

	[PreserveSig]
	internal static extern Status GdipDrawImageRectRectI(IntPtr graphics, IntPtr image, int dstx, int dsty, int dstwidth, int dstheight, int srcx, int srcy, int srcwidth, int srcheight, GraphicsUnit srcUnit, IntPtr imageattr, Graphics.DrawImageAbort callback, IntPtr callbackData);

	[PreserveSig]
	internal static extern Status GdipCreateStringFormat(StringFormatFlags formatAttributes, int language, out IntPtr native);

	[PreserveSig]
	internal static extern Status GdipCreateHBITMAPFromBitmap(IntPtr bmp, out IntPtr HandleBmp, int clrbackground);

	[PreserveSig]
	internal static extern Status GdipCreateBitmapFromHICON(IntPtr hicon, out IntPtr bitmap);

	[PreserveSig]
	internal static extern Status GdipCreateMatrix(out IntPtr matrix);

	[PreserveSig]
	internal static extern Status GdipDeleteMatrix(IntPtr matrix);

	[PreserveSig]
	internal static extern Status GdipGetMatrixElements(IntPtr matrix, IntPtr matrixOut);

	[PreserveSig]
	internal static extern Status GdipIsMatrixEqual(IntPtr matrix, IntPtr matrix2, out bool result);

	[PreserveSig]
	internal static extern int GdipCreateImageAttributes(out IntPtr imageattr);

	[PreserveSig]
	internal static extern int GdipSetImageAttributesColorKeys(HandleRef imageattr, ColorAdjustType type, bool enableFlag, int colorLow, int colorHigh);

	[PreserveSig]
	internal static extern int GdipDisposeImageAttributes(HandleRef imageattr);

	[PreserveSig]
	internal static extern int GdipSetImageAttributesColorMatrix(HandleRef imageattr, ColorAdjustType type, bool enableFlag, ColorMatrix colorMatrix, ColorMatrix grayMatrix, ColorMatrixFlag flags);

	[PreserveSig]
	internal static extern int GdipCloneImageAttributes(HandleRef imageattr, out IntPtr cloneImageattr);

	[PreserveSig]
	internal static extern Status GdipCreateFont(IntPtr fontFamily, float emSize, FontStyle style, GraphicsUnit unit, out IntPtr font);

	[PreserveSig]
	internal static extern Status GdipDeleteFont(IntPtr font);

	[PreserveSig]
	internal static extern Status GdipGetLogFont(IntPtr font, IntPtr graphics, [Out] object logfontA);

	[PreserveSig]
	internal static extern IntPtr CreateFontIndirect(ref LOGFONT logfont);

	[PreserveSig]
	internal static extern IntPtr GetDC(IntPtr hwnd);

	[PreserveSig]
	internal static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

	[PreserveSig]
	internal static extern bool GetIconInfo(IntPtr hIcon, out IconInfo iconinfo);

	[PreserveSig]
	internal static extern IntPtr CreateIconIndirect([In] ref IconInfo piconinfo);

	[PreserveSig]
	internal static extern bool DestroyIcon(IntPtr hIcon);

	[PreserveSig]
	internal static extern IntPtr XOpenDisplay(IntPtr display);

	[PreserveSig]
	internal static extern IntPtr XRootWindow(IntPtr display, int screen);

	[PreserveSig]
	internal static extern int XDefaultScreen(IntPtr display);

	[PreserveSig]
	internal static extern int GdipGetFontCollectionFamilyCount(HandleRef collection, out int found);

	[PreserveSig]
	internal static extern int GdipGetFontCollectionFamilyList(HandleRef collection, int getCount, IntPtr[] dest, out int retCount);

	[PreserveSig]
	internal static extern int GdipNewInstalledFontCollection(out IntPtr collection);

	[PreserveSig]
	internal static extern Status GdipNewPrivateFontCollection(out IntPtr collection);

	[PreserveSig]
	internal static extern Status GdipDeletePrivateFontCollection(ref IntPtr collection);

	[PreserveSig]
	internal static extern Status GdipCreateFontFamilyFromName(string fName, IntPtr collection, out IntPtr fontFamily);

	[PreserveSig]
	internal static extern Status GdipGetFamilyName(IntPtr family, IntPtr name, int language);

	[PreserveSig]
	internal static extern Status GdipGetGenericFontFamilySansSerif(out IntPtr fontFamily);

	[PreserveSig]
	internal static extern Status GdipGetGenericFontFamilySerif(out IntPtr fontFamily);

	[PreserveSig]
	internal static extern Status GdipGetGenericFontFamilyMonospace(out IntPtr fontFamily);

	[PreserveSig]
	internal static extern Status GdipGetCellAscent(IntPtr fontFamily, int style, out short ascent);

	[PreserveSig]
	internal static extern Status GdipGetCellDescent(IntPtr fontFamily, int style, out short descent);

	[PreserveSig]
	internal static extern Status GdipDeleteFontFamily(IntPtr fontFamily);

	[PreserveSig]
	internal static extern Status GdipGetFontHeightGivenDPI(IntPtr font, float dpi, out float height);

	[PreserveSig]
	internal static extern int GdipCloneFontFamily(HandleRef fontFamily, out IntPtr clone);

	[PreserveSig]
	internal static extern Status GdipStringFormatGetGenericTypographic(out IntPtr format);

	[PreserveSig]
	internal static extern Status GdipDeleteStringFormat(IntPtr format);

	[PreserveSig]
	internal static extern Status GdipCloneStringFormat(IntPtr srcformat, out IntPtr format);

	[PreserveSig]
	internal static extern Status GdipSetStringFormatFlags(IntPtr format, StringFormatFlags flags);

	[PreserveSig]
	internal static extern Status GdipGetStringFormatFlags(IntPtr format, out StringFormatFlags flags);

	[PreserveSig]
	internal static extern Status GdipSetStringFormatAlign(IntPtr format, StringAlignment align);

	[PreserveSig]
	internal static extern Status GdipGetStringFormatAlign(IntPtr format, out StringAlignment align);

	[PreserveSig]
	internal static extern Status GdipSetStringFormatLineAlign(IntPtr format, StringAlignment align);

	[PreserveSig]
	internal static extern Status GdipSetStringFormatTrimming(IntPtr format, StringTrimming trimming);

	[PreserveSig]
	internal static extern Status GdipSetStringFormatHotkeyPrefix(IntPtr format, HotkeyPrefix hotkeyPrefix);

	[PreserveSig]
	internal static extern Status GdipSetStringFormatTabStops(IntPtr format, float firstTabOffset, int count, float[] tabStops);

	[PreserveSig]
	internal static extern int GdipGetImageEncodersSize(out int encoderNums, out int arraySize);

	[PreserveSig]
	internal static extern int GdipGetImageEncoders(int encoderNums, int arraySize, IntPtr encoders);

	[PreserveSig]
	internal static extern Status GdipCreateFromContext_macosx(IntPtr cgref, int width, int height, out IntPtr graphics);

	[PreserveSig]
	internal static extern Status GdipSetVisibleClip_linux(IntPtr graphics, ref Rectangle rect);

	[PreserveSig]
	internal static extern Status GdipCreateFromXDrawable_linux(IntPtr drawable, IntPtr display, out IntPtr graphics);

	[PreserveSig]
	internal static extern Status GdipLoadImageFromDelegate_linux(StreamGetHeaderDelegate getHeader, StreamGetBytesDelegate getBytes, StreamPutBytesDelegate putBytes, StreamSeekDelegate doSeek, StreamCloseDelegate close, StreamSizeDelegate size, out IntPtr image);

	[PreserveSig]
	internal static extern Status GdipSaveImageToDelegate_linux(IntPtr image, StreamGetBytesDelegate getBytes, StreamPutBytesDelegate putBytes, StreamSeekDelegate doSeek, StreamCloseDelegate close, StreamSizeDelegate size, ref Guid encoderClsID, IntPtr encoderParameters);

	[PreserveSig]
	private static extern int uname(IntPtr buf);
}
