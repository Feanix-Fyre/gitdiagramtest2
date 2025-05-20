using System.Collections;

namespace System.Xml.Schema;

internal sealed class SchemaCollectionCompiler : BaseProcessor
{
	private bool compileContentModel;

	private XmlSchemaObjectTable examplars;

	private Stack complexTypeStack;

	private XmlSchema schema;

	public SchemaCollectionCompiler(XmlNameTable nameTable, ValidationEventHandler eventHandler)
		: base(null, null, null)
	{
	}

	public bool Execute(XmlSchema schema, SchemaInfo schemaInfo, bool compileContentModel)
	{
		return false;
	}

	private void Prepare()
	{
	}

	private void Cleanup()
	{
	}

	internal static void Cleanup(XmlSchema schema)
	{
	}

	private void Compile()
	{
	}

	private void Output(SchemaInfo schemaInfo)
	{
	}

	private static void CleanupAttribute(XmlSchemaAttribute attribute)
	{
	}

	private static void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup)
	{
	}

	private static void CleanupComplexType(XmlSchemaComplexType complexType)
	{
	}

	private static void CleanupSimpleType(XmlSchemaSimpleType simpleType)
	{
	}

	private static void CleanupElement(XmlSchemaElement element)
	{
	}

	private static void CleanupAttributes(XmlSchemaObjectCollection attributes)
	{
	}

	private static void CleanupGroup(XmlSchemaGroup group)
	{
	}

	private static void CleanupParticle(XmlSchemaParticle particle)
	{
	}

	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroupV1Compat substitutionGroup)
	{
	}

	private void CheckSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup)
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

	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle, bool substitution)
	{
		return null;
	}

	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root, bool substitution)
	{
		return null;
	}

	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element, bool substitution)
	{
		return null;
	}

	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root, bool substitution)
	{
		return null;
	}

	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root, bool substitution)
	{
		return null;
	}

	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root, bool substitution)
	{
		return null;
	}

	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root, bool substitution)
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

	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly)
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

	private void CalculateSequenceRange(XmlSchemaSequence sequence, out decimal minOccurs, out decimal maxOccurs)
	{
		minOccurs = default(decimal);
		maxOccurs = default(decimal);
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

	private void BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle)
	{
	}

	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle)
	{
	}

	private void CompileCompexTypeElements(XmlSchemaComplexType complexType)
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
}
