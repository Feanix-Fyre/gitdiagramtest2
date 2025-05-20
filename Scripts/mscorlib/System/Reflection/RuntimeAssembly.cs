using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.Threading;

namespace System.Reflection;

[Serializable]
[StructLayout((LayoutKind)0)]
[ComVisible(true)]
[ComDefaultInterface(typeof(_Assembly))]
[ClassInterface(ClassInterfaceType.None)]
internal class RuntimeAssembly : Assembly
{
	internal class UnmanagedMemoryStreamForModule : UnmanagedMemoryStream
	{
		private Module module;

		public unsafe UnmanagedMemoryStreamForModule(byte* pointer, long length, Module module)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}
	}

	internal IntPtr _mono_assembly;

	private object _evidence;

	internal ResolveEventHolder resolve_event_holder;

	private object _minimum;

	private object _optional;

	private object _refuse;

	private object _granted;

	private object _denied;

	internal bool fromByteArray;

	internal string assemblyName;

	[ComVisible(false)]
	public override bool ReflectionOnly => false;

	public override string CodeBase => null;

	public override string FullName => null;

	internal override IntPtr MonoAssembly => (IntPtr)0;

	public override string Location => null;

	protected RuntimeAssembly()
	{
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	internal static RuntimeAssembly LoadWithPartialNameInternal(string partialName, Evidence securityEvidence, ref StackCrawlMark stackMark)
	{
		return null;
	}

	internal static RuntimeAssembly LoadWithPartialNameInternal(AssemblyName an, Evidence securityEvidence, ref StackCrawlMark stackMark)
	{
		return null;
	}

	public override AssemblyName GetName(bool copiedName)
	{
		return null;
	}

	public override Type GetType(string name, bool throwOnError, bool ignoreCase)
	{
		return null;
	}

	public override Module GetModule(string name)
	{
		return null;
	}

	public override Module[] GetModules(bool getResourceModules)
	{
		return null;
	}

	internal static byte[] GetAotId()
	{
		return null;
	}

	private static string get_code_base(Assembly a, bool escaped)
	{
		return null;
	}

	private string get_location()
	{
		return null;
	}

	internal static string get_fullname(Assembly a)
	{
		return null;
	}

	internal static bool GetAotIdInternal(byte[] aotid)
	{
		return false;
	}

	internal static string GetCodeBase(Assembly a, bool escaped)
	{
		return null;
	}

	private bool GetManifestResourceInfoInternal(string name, ManifestResourceInfo info)
	{
		return false;
	}

	public override ManifestResourceInfo GetManifestResourceInfo(string resourceName)
	{
		return null;
	}

	public override string[] GetManifestResourceNames()
	{
		return null;
	}

	internal IntPtr GetManifestResourceInternal(string name, out int size, out Module module)
	{
		size = default(int);
		module = null;
		return (IntPtr)0;
	}

	public override Stream GetManifestResourceStream(string name)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Stream GetManifestResourceStream(Type type, string name)
	{
		return null;
	}

	public override bool IsDefined(Type attributeType, bool inherit)
	{
		return false;
	}

	public override object[] GetCustomAttributes(bool inherit)
	{
		return null;
	}

	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		return null;
	}

	internal override Module[] GetModulesInternal()
	{
		return null;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object o)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
