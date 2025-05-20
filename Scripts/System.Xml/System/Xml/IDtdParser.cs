namespace System.Xml;

internal interface IDtdParser
{
	IDtdInfo ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset);

	IDtdInfo ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter);
}
