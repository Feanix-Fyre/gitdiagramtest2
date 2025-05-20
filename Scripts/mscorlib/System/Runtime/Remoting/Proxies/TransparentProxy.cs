using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using Mono;

namespace System.Runtime.Remoting.Proxies;

[StructLayout((LayoutKind)0)]
internal class TransparentProxy
{
	public RealProxy _rp;

	private RuntimeRemoteClassHandle _class;

	private bool _custom_type_info;

	private bool IsContextBoundObject => false;

	private Context TargetContext => null;

	internal RuntimeType GetProxyType()
	{
		return null;
	}

	private bool InCurrentContext()
	{
		return false;
	}

	internal object LoadRemoteFieldNew(IntPtr classPtr, IntPtr fieldPtr)
	{
		return null;
	}

	internal void StoreRemoteField(IntPtr classPtr, IntPtr fieldPtr, object arg)
	{
	}
}
