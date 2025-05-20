using System.IO;
using System.Text;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Runtime/Export/Logging/UnityLogWriter.bindings.h")]
internal class UnityLogWriter : TextWriter
{
	public override Encoding Encoding => null;

	[ThreadAndSerializationSafe]
	public static void WriteStringToUnityLog(string s)
	{
	}

	[FreeFunction(IsThreadSafe = true)]
	private static void WriteStringToUnityLogImpl(string s)
	{
	}

	public static void Init()
	{
	}

	public override void Write(char value)
	{
	}

	public override void Write(string s)
	{
	}

	public override void Write(char[] buffer, int index, int count)
	{
	}
}
