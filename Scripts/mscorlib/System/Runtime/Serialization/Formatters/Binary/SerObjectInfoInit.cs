using System.Collections;

namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class SerObjectInfoInit
{
	internal Hashtable seenBeforeTable;

	internal int objectInfoIdCount;

	internal SerStack oiPool;
}
