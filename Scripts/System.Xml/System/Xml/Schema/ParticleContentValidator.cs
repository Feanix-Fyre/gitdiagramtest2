using System.Collections;

namespace System.Xml.Schema;

internal sealed class ParticleContentValidator : ContentValidator
{
	private SymbolsDictionary symbols;

	private Positions positions;

	private Stack stack;

	private SyntaxTreeNode contentNode;

	private bool isPartial;

	private int minMaxNodesCount;

	private bool enableUpaCheck;

	public ParticleContentValidator(XmlSchemaContentType contentType)
		: base(default(XmlSchemaContentType))
	{
	}

	public ParticleContentValidator(XmlSchemaContentType contentType, bool enableUpaCheck)
		: base(default(XmlSchemaContentType))
	{
	}

	public override void InitValidation(ValidationState context)
	{
	}

	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode)
	{
		errorCode = default(int);
		return null;
	}

	public override bool CompleteValidation(ValidationState context)
	{
		return false;
	}

	public void Start()
	{
	}

	public void OpenGroup()
	{
	}

	public void CloseGroup()
	{
	}

	public bool Exists(XmlQualifiedName name)
	{
		return false;
	}

	public void AddName(XmlQualifiedName name, object particle)
	{
	}

	public void AddNamespaceList(NamespaceList namespaceList, object particle)
	{
	}

	private void AddLeafNode(SyntaxTreeNode node)
	{
	}

	public void AddChoice()
	{
	}

	public void AddSequence()
	{
	}

	public void AddStar()
	{
	}

	public void AddPlus()
	{
	}

	public void AddQMark()
	{
	}

	public void AddLeafRange(decimal min, decimal max)
	{
	}

	private void Closure(InteriorNode node)
	{
	}

	public ContentValidator Finish(bool useDFA)
	{
		return null;
	}

	private BitSet[] CalculateTotalFollowposForRangeNodes(BitSet firstpos, BitSet[] followpos, out BitSet posWithRangeTerminals)
	{
		posWithRangeTerminals = null;
		return null;
	}

	private void CheckCMUPAWithLeafRangeNodes(BitSet curpos)
	{
	}

	private BitSet GetApplicableMinMaxFollowPos(BitSet curpos, BitSet posWithRangeTerminals, BitSet[] minmaxFollowPos)
	{
		return null;
	}

	private void CheckUniqueParticleAttribution(BitSet firstpos, BitSet[] followpos)
	{
	}

	private void CheckUniqueParticleAttribution(BitSet curpos)
	{
	}

	private int[][] BuildTransitionTable(BitSet firstpos, BitSet[] followpos, int endMarkerPos)
	{
		return null;
	}
}
