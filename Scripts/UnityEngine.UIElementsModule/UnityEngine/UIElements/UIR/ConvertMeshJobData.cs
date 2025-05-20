using System;

namespace UnityEngine.UIElements.UIR;

internal struct ConvertMeshJobData
{
	public IntPtr vertSrc;

	public IntPtr vertDst;

	public int vertCount;

	public Matrix4x4 transform;

	public int transformUVs;

	public Color32 xformClipPages;

	public Color32 ids;

	public Color32 addFlags;

	public Color32 opacityPage;

	public Color32 textCoreSettingsPage;

	public int isText;

	public float textureId;

	public IntPtr indexSrc;

	public IntPtr indexDst;

	public int indexCount;

	public int indexOffset;

	public int flipIndices;
}
