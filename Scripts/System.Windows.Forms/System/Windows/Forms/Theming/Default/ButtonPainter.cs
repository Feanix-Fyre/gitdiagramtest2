using System.Drawing;

namespace System.Windows.Forms.Theming.Default;

internal class ButtonPainter
{
	protected SystemResPool ResPool => null;

	public virtual void Draw(Graphics g, Rectangle bounds, ButtonThemeState state, Color backColor, Color foreColor)
	{
	}

	public virtual void DrawFlat(Graphics g, Rectangle bounds, ButtonThemeState state, Color backColor, Color foreColor, FlatButtonAppearance appearance)
	{
	}

	public virtual void DrawPopup(Graphics g, Rectangle bounds, ButtonThemeState state, Color backColor, Color foreColor)
	{
	}

	private static Color ChangeIntensity(Color baseColor, float percent)
	{
		return default(Color);
	}
}
