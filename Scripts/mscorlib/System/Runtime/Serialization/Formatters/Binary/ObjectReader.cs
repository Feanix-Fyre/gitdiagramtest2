using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class ObjectReader
{
	internal class TypeNAssembly
	{
		public Type type;

		public string assemblyName;
	}

	internal sealed class TopLevelAssemblyTypeResolver
	{
		private Assembly m_topLevelAssembly;

		public TopLevelAssemblyTypeResolver(Assembly topLevelAssembly)
		{
		}

		public Type ResolveType(Assembly assembly, string simpleTypeName, bool ignoreCase)
		{
			return null;
		}
	}

	internal Stream m_stream;

	internal ISurrogateSelector m_surrogates;

	internal StreamingContext m_context;

	internal ObjectManager m_objectManager;

	internal InternalFE formatterEnums;

	internal SerializationBinder m_binder;

	internal long topId;

	internal bool bSimpleAssembly;

	internal object handlerObject;

	internal object m_topObject;

	internal Header[] headers;

	internal HeaderHandler handler;

	internal SerObjectInfoInit serObjectInfoInit;

	internal IFormatterConverter m_formatterConverter;

	internal SerStack stack;

	private SerStack valueFixupStack;

	internal object[] crossAppDomainArray;

	private bool bFullDeserialization;

	private bool bOldFormatDetected;

	private IntSizedArray valTypeObjectIdTable;

	private NameCache typeCache;

	private string previousAssemblyString;

	private string previousName;

	private Type previousType;

	private SerStack ValueFixupStack => null;

	internal object TopObject
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal ObjectReader(Stream stream, ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder)
	{
	}

	internal object Deserialize(HeaderHandler handler, __BinaryParser serParser, bool fCheck)
	{
		return null;
	}

	private bool HasSurrogate(Type t)
	{
		return false;
	}

	private void CheckSerializable(Type t)
	{
	}

	private void InitFullDeserialization()
	{
	}

	internal object CrossAppDomainArray(int index)
	{
		return null;
	}

	internal ReadObjectInfo CreateReadObjectInfo(Type objectType)
	{
		return null;
	}

	internal ReadObjectInfo CreateReadObjectInfo(Type objectType, string[] memberNames, Type[] memberTypes)
	{
		return null;
	}

	internal void Parse(ParseRecord pr)
	{
	}

	private void ParseError(ParseRecord processing, ParseRecord onStack)
	{
	}

	private void ParseSerializedStreamHeader(ParseRecord pr)
	{
	}

	private void ParseSerializedStreamHeaderEnd(ParseRecord pr)
	{
	}

	private void ParseObject(ParseRecord pr)
	{
	}

	private void ParseObjectEnd(ParseRecord pr)
	{
	}

	private void ParseArray(ParseRecord pr)
	{
	}

	private void NextRectangleMap(ParseRecord pr)
	{
	}

	private void ParseArrayMember(ParseRecord pr)
	{
	}

	private void ParseArrayMemberEnd(ParseRecord pr)
	{
	}

	private void ParseMember(ParseRecord pr)
	{
	}

	private void ParseMemberEnd(ParseRecord pr)
	{
	}

	private void ParseString(ParseRecord pr, ParseRecord parentPr)
	{
	}

	private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr)
	{
	}

	private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr, bool bIsString)
	{
	}

	internal long GetId(long objectId)
	{
		return 0L;
	}

	internal Type Bind(string assemblyString, string typeString)
	{
		return null;
	}

	internal Type FastBindToType(string assemblyName, string typeName)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Assembly ResolveSimpleAssemblyName(AssemblyName assemblyName)
	{
		return null;
	}

	private static void GetSimplyNamedTypeFromAssembly(Assembly assm, string typeName, ref Type type)
	{
	}

	internal Type GetType(BinaryAssemblyInfo assemblyInfo, string name)
	{
		return null;
	}

	private static void CheckTypeForwardedTo(Assembly sourceAssembly, Assembly destAssembly, Type resolvedType)
	{
	}
}
