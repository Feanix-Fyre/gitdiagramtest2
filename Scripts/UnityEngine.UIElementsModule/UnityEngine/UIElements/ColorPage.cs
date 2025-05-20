using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements;

internal struct ColorPage
{
	public bool isValid;

	public Color32 pageAndID;

	public static ColorPage Init(RenderChain renderChain, BMPAlloc alloc)
	{
		return default(ColorPage);
	}

	public MeshBuilderNative.NativeColorPage ToNativeColorPage()
	{
		return default(MeshBuilderNative.NativeColorPage);
	}
}
