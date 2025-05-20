namespace System.Xml.Schema;

internal class ForwardAxis
{
	private DoubleLinkAxis _topNode;

	private DoubleLinkAxis _rootNode;

	private bool _isAttribute;

	private bool _isDss;

	private bool _isSelfAxis;

	internal DoubleLinkAxis RootNode => null;

	internal DoubleLinkAxis TopNode => null;

	internal bool IsAttribute => false;

	internal bool IsDss => false;

	internal bool IsSelfAxis => false;

	public ForwardAxis(DoubleLinkAxis axis, bool isdesorself)
	{
	}
}
