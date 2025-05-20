using System.Drawing;

namespace System.Windows.Forms.Theming.Default;

internal class LabelPainter
{
	public virtual Size DefaultSize => default(Size);

	public virtual void Draw(Graphics dc, Rectangle client_rectangle, Label label)
	{
	}
}
