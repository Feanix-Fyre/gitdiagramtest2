using System.Collections;

namespace System.Xml.Schema;

internal sealed class Compiler : BaseProcessor
{
	private string restrictionErrorMsg;

	private XmlSchemaObjectTable attributes;

	private XmlSchemaObjectTable attributeGroups;

	private XmlSchemaObjectTable elements;

	private XmlSchemaObjectTable schemaTypes;

	private XmlSchemaObjectTable groups;

	private XmlSchemaObjectTable notations;

	private XmlSchemaObjectTable examplars;

	private XmlSchemaObjectTable identityConstraints;

	private Stack complexTypeStack;

	private Hashtable schemasToCompile;

	private Hashtable importedSchemas;

	private XmlSchema schemaForSchema;

	public Compiler(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchema schemaForSchema, XmlSchemaCompilationSettings compilationSettings)
		: base(null, null, null)
	{
	}

	public bool Execute(XmlSchemaSet schemaSet, SchemaInfo schemaCompiledInfo)
	{
		return false;
	}

	internal void Prepare(XmlSchema schema, bool cleanup)
	{
	}

	private void UpdateSForSSimpleTypes()
	{
	}

	private void Output(SchemaInfo schemaInfo)
	{
	}

	internal void ImportAllCompiledSchemas(XmlSchemaSet schemaSet)
	{
	}

	internal bool Compile()
	{
		return false;
	}

	private void CleanupAttribute(XmlSchemaAttribute attribute)
	{
	}

	private void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup)
	{
	}

	private void CleanupComplexType(XmlSchemaComplexType complexType)
	{
	}

	private void CleanupSimpleType(XmlSchemaSimpleType simpleType)
	{
	}

	private void CleanupElement(XmlSchemaElement element)
	{
	}

	private void CleanupAttributes(XmlSchemaObjectCollection attributes)
	{
	}

	private void CleanupGroup(XmlSchemaGroup group)
	{
	}

	private void CleanupParticle(XmlSchemaParticle particle)
	{
	}

	private void ProcessSubstitutionGroups()
	{
	}

	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup)
	{
	}

	private void RecursivelyCheckRedefinedGroups(XmlSchemaGroup redefinedGroup, XmlSchemaGroup baseGroup)
	{
	}

	private void RecursivelyCheckRedefinedAttributeGroups(XmlSchemaAttributeGroup attributeGroup, XmlSchemaAttributeGroup baseAttributeGroup)
	{
	}

	private void CompileGroup(XmlSchemaGroup group)
	{
	}

	private void CompileSimpleType(XmlSchemaSimpleType simpleType)
	{
	}

	private XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType)
	{
		return null;
	}

	private void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType)
	{
	}

	private void CompileComplexType(XmlSchemaComplexType complexType)
	{
	}

	private void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension)
	{
	}

	private void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction)
	{
	}

	private void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension)
	{
	}

	private void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction)
	{
	}

	private void CheckParticleDerivation(XmlSchemaComplexType complexType)
	{
	}

	private void CheckParticleDerivation(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle)
	{
	}

	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle)
	{
		return null;
	}

	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root)
	{
		return null;
	}

	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element)
	{
		return null;
	}

	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root)
	{
		return null;
	}

	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root)
	{
		return null;
	}

	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root)
	{
		return null;
	}

	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root)
	{
		return null;
	}

	private XmlSchemaParticle CannonicalizePointlessRoot(XmlSchemaParticle particle)
	{
		return null;
	}

	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle)
	{
		return false;
	}

	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement)
	{
		return false;
	}

	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny)
	{
		return false;
	}

	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny)
	{
		return false;
	}

	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny)
	{
		return false;
	}

	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase)
	{
		return false;
	}

	private bool IsChoiceFromChoiceSubstGroup(XmlSchemaChoice derivedChoice, XmlSchemaChoice baseChoice)
	{
		return false;
	}

	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly)
	{
		return false;
	}

	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll)
	{
		return false;
	}

	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice)
	{
		return false;
	}

	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle)
	{
		return false;
	}

	private bool IsValidOccurrenceRangeRestriction(decimal minOccurs, decimal maxOccurs, decimal baseMinOccurs, decimal baseMaxOccurs)
	{
		return false;
	}

	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection)
	{
		return 0;
	}

	private bool IsParticleEmptiable(XmlSchemaParticle particle)
	{
		return false;
	}

	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, out decimal minOccurs, out decimal maxOccurs)
	{
		minOccurs = default(decimal);
		maxOccurs = default(decimal);
	}

	private void PushComplexType(XmlSchemaComplexType complexType)
	{
	}

	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle)
	{
		return default(XmlSchemaContentType);
	}

	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup)
	{
	}

	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy)
	{
	}

	private void CheckAtrributeGroupRestriction(XmlSchemaAttributeGroup baseAttributeGroup, XmlSchemaAttributeGroup derivedAttributeGroup)
	{
	}

	private bool IsProcessContentsRestricted(XmlSchemaComplexType baseType, XmlSchemaAnyAttribute derivedAttributeWildcard, XmlSchemaAnyAttribute baseAttributeWildcard)
	{
		return false;
	}

	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b)
	{
		return null;
	}

	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b)
	{
		return null;
	}

	private void CompileAttribute(XmlSchemaAttribute xa)
	{
	}

	private void SetDefaultFixed(XmlSchemaAttribute xa, SchemaAttDef decl)
	{
	}

	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi)
	{
	}

	private void CompileElement(XmlSchemaElement xe)
	{
	}

	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType)
	{
		return null;
	}

	private bool BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle)
	{
		return false;
	}

	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle)
	{
	}

	private void CompileParticleElements(XmlSchemaParticle particle)
	{
	}

	private void CompileComplexTypeElements(XmlSchemaComplexType complexType)
	{
	}

	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name)
	{
		return null;
	}

	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name)
	{
		return null;
	}

	private XmlSchemaType GetAnySchemaType(XmlQualifiedName name)
	{
		return null;
	}

	private void CopyPosition(XmlSchemaAnnotated to, XmlSchemaAnnotated from, bool copyParent)
	{
	}

	private bool IsFixedEqual(SchemaDeclBase baseDecl, SchemaDeclBase derivedDecl)
	{
		return false;
	}
}
