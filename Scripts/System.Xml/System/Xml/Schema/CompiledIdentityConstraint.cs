namespace System.Xml.Schema;

internal class CompiledIdentityConstraint
{
	public enum ConstraintRole
	{
		Unique = 0,
		Key = 1,
		Keyref = 2
	}

	internal XmlQualifiedName name;

	private ConstraintRole role;

	private Asttree selector;

	private Asttree[] fields;

	internal XmlQualifiedName refer;

	public static readonly CompiledIdentityConstraint Empty;

	public ConstraintRole Role => default(ConstraintRole);

	public Asttree Selector => null;

	public Asttree[] Fields => null;

	private CompiledIdentityConstraint()
	{
	}

	public CompiledIdentityConstraint(XmlSchemaIdentityConstraint constraint, XmlNamespaceManager nsmgr)
	{
	}
}
