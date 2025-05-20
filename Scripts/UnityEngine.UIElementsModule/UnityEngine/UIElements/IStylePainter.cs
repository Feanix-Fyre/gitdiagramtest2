using System;

namespace UnityEngine.UIElements;

internal interface IStylePainter
{
	void DrawText(TextElement te);

	void DrawRectangle(MeshGenerationContextUtils.RectangleParams rectParams);

	void DrawImmediate(Action callback, bool cullingEnabled);
}
