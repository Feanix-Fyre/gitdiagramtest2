using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Messaging;

[Serializable]
[StructLayout((LayoutKind)0)]
internal class MonoMethodMessage : IMethodCallMessage, IMethodMessage, IMessage, IMethodReturnMessage, IInternalMessage
{
	private RuntimeMethodInfo method;

	private object[] args;

	private string[] names;

	private byte[] arg_types;

	public LogicalCallContext ctx;

	public object rval;

	public Exception exc;

	private AsyncResult asyncResult;

	private CallType call_type;

	private string uri;

	private MCMDictionary properties;

	private Identity identity;

	private Type[] methodSignature;

	public IDictionary Properties => null;

	public int ArgCount => 0;

	public object[] Args => null;

	public LogicalCallContext LogicalCallContext
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public MethodBase MethodBase => null;

	public string MethodName => null;

	public object MethodSignature => null;

	public string TypeName => null;

	public string Uri
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Exception Exception => null;

	public int OutArgCount => 0;

	public object[] OutArgs => null;

	public object ReturnValue => null;

	Identity IInternalMessage.TargetIdentity
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public AsyncResult AsyncResult => null;

	internal CallType CallType => default(CallType);

	internal void InitMessage(RuntimeMethodInfo method, object[] out_args)
	{
	}

	public MonoMethodMessage(MethodBase method, object[] out_args)
	{
	}

	internal MonoMethodMessage(MethodInfo minfo, object[] in_args, object[] out_args)
	{
	}

	private static MethodInfo GetMethodInfo(Type type, string methodName)
	{
		return null;
	}

	public MonoMethodMessage(Type type, string methodName, object[] in_args)
	{
	}

	public object GetArg(int arg_num)
	{
		return null;
	}

	public bool NeedsOutProcessing(out int outCount)
	{
		outCount = default(int);
		return false;
	}
}
