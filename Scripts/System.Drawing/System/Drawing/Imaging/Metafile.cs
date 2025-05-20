using System.ComponentModel;
using System.Drawing.Design;
using System.IO;

namespace System.Drawing.Imaging;

/// <summary>Defines a graphic metafile. A metafile contains records that describe a sequence of graphics operations that can be recorded (constructed) and played back (displayed). This class is not inheritable.</summary>
[Serializable]
[System.MonoTODO("Metafiles, both WMF and EMF formats, are only partially supported.")]
[Editor("System.Drawing.Design.MetafileEditor, System.Drawing.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
public sealed class Metafile : Image
{
	internal sealed class MetafileHolder : IDisposable
	{
		private bool _disposed;

		private IntPtr _nativeImage;

		internal bool Disposed => false;

		internal MetafileHolder()
		{
		}

		~MetafileHolder()
		{
		}

		public void Dispose()
		{
		}

		internal void Dispose(bool disposing)
		{
		}

		internal void MetafileDisposed(IntPtr nativeImage)
		{
		}

		internal void GraphicsDisposed()
		{
		}
	}

	private MetafileHolder _metafileHolder;

	internal MetafileHolder AddMetafileHolder()
	{
		return null;
	}

	internal Metafile(IntPtr ptr)
	{
	}

	internal Metafile(IntPtr ptr, Stream stream)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}
}
