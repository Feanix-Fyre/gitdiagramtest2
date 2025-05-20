using UnityEngine.Serialization;

namespace UnityEngine.UI;

[RequireComponent(typeof(CanvasRenderer))]
[AddComponentMenu("UI/Raw Image", 12)]
public class RawImage : MaskableGraphic
{
	[SerializeField]
	[FormerlySerializedAs("m_Tex")]
	private Texture m_Texture;

	[SerializeField]
	private Rect m_UVRect;

	public override Texture mainTexture => null;

	public Texture texture
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Rect uvRect
	{
		get
		{
			return default(Rect);
		}
		set
		{
		}
	}

	protected RawImage()
	{
	}

	public override void SetNativeSize()
	{
	}

	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}

	protected override void OnDidApplyAnimationProperties()
	{
	}
}
