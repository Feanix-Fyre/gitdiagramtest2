using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements;

internal class UITKTextHandle : TextHandle
{
	private TextElement m_TextElement;

	internal bool isOverridingCursor;

	internal int currentLinkIDHash;

	internal bool hasLinkTag;

	internal bool hasATag;

	internal static readonly float k_MinPadding;

	public Vector2 MeasuredSizes { get; set; }

	public Vector2 RoundedSizes { get; set; }

	public UITKTextHandle(TextElement te)
	{
	}

	public float ComputeTextWidth(string textToMeasure, bool wordWrap, float width, float height)
	{
		return 0f;
	}

	public float ComputeTextHeight(string textToMeasure, float width, float height)
	{
		return 0f;
	}

	public TextInfo Update()
	{
		return null;
	}

	private void ATagOnPointerUp(PointerUpEvent pue)
	{
	}

	private void ATagOnPointerOver(PointerOverEvent _)
	{
	}

	private void ATagOnPointerMove(PointerMoveEvent pme)
	{
	}

	private void ATagOnPointerOut(PointerOutEvent _)
	{
	}

	internal void LinkTagOnPointerDown(PointerDownEvent pde)
	{
	}

	internal void LinkTagOnPointerUp(PointerUpEvent pue)
	{
	}

	internal void LinkTagOnPointerMove(PointerMoveEvent pme)
	{
	}

	private void LinkTagOnPointerOut(PointerOutEvent poe)
	{
	}

	private void HandleLinkTag()
	{
	}

	private void HandleATag()
	{
	}

	private TextOverflowMode GetTextOverflowMode()
	{
		return default(TextOverflowMode);
	}

	internal void ConvertUssToTextGenerationSettings(UnityEngine.TextCore.Text.TextGenerationSettings tgs)
	{
	}

	internal bool TextLibraryCanElide()
	{
		return false;
	}

	internal float GetTextEffectPadding(FontAsset fontAsset)
	{
		return 0f;
	}
}
