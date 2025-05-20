using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting;

/// <summary>Provides several methods for using and publishing remoted objects in SOAP format.</summary>
[ComVisible(true)]
public class SoapServices
{
	private class TypeInfo
	{
		public Hashtable Attributes;

		public Hashtable Elements;
	}

	private static Hashtable _xmlTypes;

	private static Hashtable _xmlElements;

	private static Hashtable _soapActions;

	private static Hashtable _soapActionsMethods;

	private static Hashtable _typeInfos;

	/// <summary>Gets the default XML namespace prefix that should be used for XML encoding of a common language runtime class that has an assembly, but no native namespace.</summary>
	/// <returns>The default XML namespace prefix that should be used for XML encoding of a common language runtime class that has an assembly, but no native namespace.</returns>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission.</exception>
	public static string XmlNsForClrTypeWithAssembly => null;

	/// <summary>Gets the XML namespace prefix that should be used for XML encoding of a common language runtime class that is part of the mscorlib.dll file.</summary>
	/// <returns>The XML namespace prefix that should be used for XML encoding of a common language runtime class that is part of the mscorlib.dll file.</returns>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission.</exception>
	public static string XmlNsForClrTypeWithNs => null;

	/// <summary>Gets the default XML namespace prefix that should be used for XML encoding of a common language runtime class that has both a common language runtime namespace and an assembly.</summary>
	/// <returns>The default XML namespace prefix that should be used for XML encoding of a common language runtime class that has both a common language runtime namespace and an assembly.</returns>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission.</exception>
	public static string XmlNsForClrTypeWithNsAndAssembly => null;

	/// <summary>Returns the common language runtime type namespace name from the provided namespace and assembly names.</summary>
	/// <param name="typeNamespace">The namespace that is to be coded.</param>
	/// <param name="assemblyName">The name of the assembly that is to be coded.</param>
	/// <returns>The common language runtime type namespace name from the provided namespace and assembly names.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="assemblyName" /> and <paramref name="typeNamespace" /> parameters are both either <see langword="null" /> or empty.</exception>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission.</exception>
	public static string CodeXmlNamespaceForClrTypeNamespace(string typeNamespace, string assemblyName)
	{
		return null;
	}

	private static string GetNameKey(string name, string namspace)
	{
		return null;
	}

	private static string GetAssemblyName(MethodBase mb)
	{
		return null;
	}

	/// <summary>Returns XML element information that should be used when serializing the given type.</summary>
	/// <param name="type">The object <see cref="T:System.Type" /> for which the XML element and namespace names were requested.</param>
	/// <param name="xmlElement">When this method returns, contains a <see cref="T:System.String" /> that holds the XML element name of the specified object type. This parameter is passed uninitialized.</param>
	/// <param name="xmlNamespace">When this method returns, contains a <see cref="T:System.String" /> that holds the XML namespace name of the specified object type. This parameter is passed uninitialized.</param>
	/// <returns>
	///   <see langword="true" /> if the requested values have been set flagged with <see cref="T:System.Runtime.Remoting.Metadata.SoapTypeAttribute" />; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission.</exception>
	public static bool GetXmlElementForInteropType(Type type, out string xmlElement, out string xmlNamespace)
	{
		xmlElement = null;
		xmlNamespace = null;
		return false;
	}

	/// <summary>Retrieves the XML namespace used during remote calls of the method specified in the given <see cref="T:System.Reflection.MethodBase" />.</summary>
	/// <param name="mb">The <see cref="T:System.Reflection.MethodBase" /> of the method for which the XML namespace was requested.</param>
	/// <returns>The XML namespace used during remote calls of the specified method.</returns>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission.</exception>
	public static string GetXmlNamespaceForMethodCall(MethodBase mb)
	{
		return null;
	}

	/// <summary>Retrieves the XML namespace used during the generation of responses to the remote call to the method specified in the given <see cref="T:System.Reflection.MethodBase" />.</summary>
	/// <param name="mb">The <see cref="T:System.Reflection.MethodBase" /> of the method for which the XML namespace was requested.</param>
	/// <returns>The XML namespace used during the generation of responses to a remote method call.</returns>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission.</exception>
	public static string GetXmlNamespaceForMethodResponse(MethodBase mb)
	{
		return null;
	}

	/// <summary>Returns XML type information that should be used when serializing the given <see cref="T:System.Type" />.</summary>
	/// <param name="type">The object <see cref="T:System.Type" /> for which the XML element and namespace names were requested.</param>
	/// <param name="xmlType">The XML type of the specified object <see cref="T:System.Type" />.</param>
	/// <param name="xmlTypeNamespace">The XML type namespace of the specified object <see cref="T:System.Type" />.</param>
	/// <returns>
	///   <see langword="true" /> if the requested values have been set flagged with <see cref="T:System.Runtime.Remoting.Metadata.SoapTypeAttribute" />; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission.</exception>
	public static bool GetXmlTypeForInteropType(Type type, out string xmlType, out string xmlTypeNamespace)
	{
		xmlType = null;
		xmlTypeNamespace = null;
		return false;
	}

	/// <summary>Preloads every <see cref="T:System.Type" /> found in the specified <see cref="T:System.Reflection.Assembly" /> from the information found in the <see cref="T:System.Runtime.Remoting.Metadata.SoapTypeAttribute" /> associated with each type.</summary>
	/// <param name="assembly">The <see cref="T:System.Reflection.Assembly" /> for each type of which to call <see cref="M:System.Runtime.Remoting.SoapServices.PreLoad(System.Type)" />.</param>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission.</exception>
	public static void PreLoad(Assembly assembly)
	{
	}

	/// <summary>Preloads the given <see cref="T:System.Type" /> based on values set in a <see cref="T:System.Runtime.Remoting.Metadata.SoapTypeAttribute" /> on the type.</summary>
	/// <param name="type">The <see cref="T:System.Type" /> to preload.</param>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission.</exception>
	public static void PreLoad(Type type)
	{
	}

	/// <summary>Associates the given XML element name and namespace with a run-time type that should be used for deserialization.</summary>
	/// <param name="xmlElement">The XML element name to use in deserialization.</param>
	/// <param name="xmlNamespace">The XML namespace to use in deserialization.</param>
	/// <param name="type">The run-time <see cref="T:System.Type" /> to use in deserialization.</param>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission.</exception>
	public static void RegisterInteropXmlElement(string xmlElement, string xmlNamespace, Type type)
	{
	}

	/// <summary>Associates the given XML type name and namespace with the run-time type that should be used for deserialization.</summary>
	/// <param name="xmlType">The XML type to use in deserialization.</param>
	/// <param name="xmlTypeNamespace">The XML namespace to use in deserialization.</param>
	/// <param name="type">The run-time <see cref="T:System.Type" /> to use in deserialization.</param>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission.</exception>
	public static void RegisterInteropXmlType(string xmlType, string xmlTypeNamespace, Type type)
	{
	}

	private static string EncodeNs(string ns)
	{
		return null;
	}
}
