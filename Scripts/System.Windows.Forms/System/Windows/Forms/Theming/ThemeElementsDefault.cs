using System.Windows.Forms.Theming.Default;

namespace System.Windows.Forms.Theming;

internal class ThemeElementsDefault
{
	protected ButtonPainter buttonPainter;

	protected LabelPainter labelPainter;

	protected CheckBoxPainter checkBoxPainter;

	public virtual ButtonPainter ButtonPainter => null;

	public virtual LabelPainter LabelPainter => null;

	public virtual CheckBoxPainter CheckBoxPainter => null;
}
