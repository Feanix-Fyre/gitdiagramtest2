using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Contexts;

/// <summary>Defines an environment for the objects that are resident inside it and for which a policy can be enforced.</summary>
[StructLayout((LayoutKind)0)]
[ComVisible(true)]
public class Context
{
	private int domain_id;

	private int context_id;

	private UIntPtr static_data;

	private UIntPtr data;

	[ContextStatic]
	private static object[] local_slots;

	private static IMessageSink default_server_context_sink;

	private IMessageSink server_context_sink_chain;

	private IMessageSink client_context_sink_chain;

	private List<IContextProperty> context_properties;

	private static int global_count;

	private LocalDataStoreHolder _localDataStore;

	private static LocalDataStoreMgr _localDataStoreMgr;

	private static DynamicPropertyCollection global_dynamic_properties;

	private DynamicPropertyCollection context_dynamic_properties;

	private ContextCallbackObject callback_object;

	/// <summary>Gets the default context for the current application domain.</summary>
	/// <returns>The default context for the <see cref="T:System.AppDomain" /> namespace.</returns>
	public static Context DefaultContext => null;

	/// <summary>Gets the context ID for the current context.</summary>
	/// <returns>The context ID for the current context.</returns>
	public virtual int ContextID => 0;

	/// <summary>Gets the array of the current context properties.</summary>
	/// <returns>The current context properties array; otherwise, <see langword="null" /> if the context does not have any properties attributed to it.</returns>
	public virtual IContextProperty[] ContextProperties => null;

	internal bool IsDefaultContext => false;

	internal bool NeedsContextSink => false;

	internal static bool HasGlobalDynamicSinks => false;

	internal bool HasDynamicSinks => false;

	internal bool HasExitSinks => false;

	private LocalDataStore MyLocalStore => null;

	private static void RegisterContext(Context ctx)
	{
	}

	private static void ReleaseContext(Context ctx)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Contexts.Context" /> class.</summary>
	public Context()
	{
	}

	/// <summary>Cleans up the backing objects for the nondefault contexts.</summary>
	~Context()
	{
	}

	/// <summary>Registers a dynamic property implementing the <see cref="T:System.Runtime.Remoting.Contexts.IDynamicProperty" /> interface with the remoting service.</summary>
	/// <param name="prop">The dynamic property to register.</param>
	/// <param name="obj">The object/proxy for which the property is registered.</param>
	/// <param name="ctx">The context for which the property is registered.</param>
	/// <returns>
	///   <see langword="true" /> if the property was successfully registered; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">Either <paramref name="prop" /> or its name is <see langword="null" />, or it is not dynamic (it does not implement <see cref="T:System.Runtime.Remoting.Contexts.IDynamicProperty" />).</exception>
	/// <exception cref="T:System.ArgumentException">Both an object as well as a context are specified (both <paramref name="obj" /> and <paramref name="ctx" /> are not <see langword="null" />).</exception>
	public static bool RegisterDynamicProperty(IDynamicProperty prop, ContextBoundObject obj, Context ctx)
	{
		return false;
	}

	/// <summary>Unregisters a dynamic property implementing the <see cref="T:System.Runtime.Remoting.Contexts.IDynamicProperty" /> interface.</summary>
	/// <param name="name">The name of the dynamic property to unregister.</param>
	/// <param name="obj">The object/proxy for which the property is registered.</param>
	/// <param name="ctx">The context for which the property is registered.</param>
	/// <returns>
	///   <see langword="true" /> if the object was successfully unregistered; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">Both an object as well as a context are specified (both <paramref name="obj" /> and <paramref name="ctx" /> are not <see langword="null" />).</exception>
	public static bool UnregisterDynamicProperty(string name, ContextBoundObject obj, Context ctx)
	{
		return false;
	}

	private static DynamicPropertyCollection GetDynamicPropertyCollection(ContextBoundObject obj, Context ctx)
	{
		return null;
	}

	internal static void NotifyGlobalDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async)
	{
	}

	internal void NotifyDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async)
	{
	}

	/// <summary>Returns a specific context property, specified by name.</summary>
	/// <param name="name">The name of the property.</param>
	/// <returns>The specified context property.</returns>
	public virtual IContextProperty GetProperty(string name)
	{
		return null;
	}

	/// <summary>Sets a specific context property by name.</summary>
	/// <param name="prop">The actual context property.</param>
	/// <exception cref="T:System.InvalidOperationException">The context is frozen.</exception>
	/// <exception cref="T:System.ArgumentNullException">The property or the property name is <see langword="null" />.</exception>
	public virtual void SetProperty(IContextProperty prop)
	{
	}

	/// <summary>Freezes the context, making it impossible to add or remove context properties from the current context.</summary>
	/// <exception cref="T:System.InvalidOperationException">The context is already frozen.</exception>
	public virtual void Freeze()
	{
	}

	/// <summary>Returns a <see cref="T:System.String" /> class representation of the current context.</summary>
	/// <returns>A <see cref="T:System.String" /> class representation of the current context.</returns>
	public override string ToString()
	{
		return null;
	}

	internal IMessageSink GetServerContextSinkChain()
	{
		return null;
	}

	internal IMessageSink GetClientContextSinkChain()
	{
		return null;
	}

	internal IMessageSink CreateServerObjectSinkChain(MarshalByRefObject obj, bool forceInternalExecute)
	{
		return null;
	}

	internal IMessageSink CreateEnvoySink(MarshalByRefObject serverObject)
	{
		return null;
	}

	internal static Context SwitchToContext(Context newContext)
	{
		return null;
	}

	internal static Context CreateNewContext(IConstructionCallMessage msg)
	{
		return null;
	}

	/// <summary>Executes code in another context.</summary>
	/// <param name="deleg">The delegate used to request the callback.</param>
	public void DoCallBack(CrossContextDelegate deleg)
	{
	}

	/// <summary>Allocates an unnamed data slot.</summary>
	/// <returns>A local data slot.</returns>
	public static LocalDataStoreSlot AllocateDataSlot()
	{
		return null;
	}

	/// <summary>Allocates a named data slot.</summary>
	/// <param name="name">The required name for the data slot.</param>
	/// <returns>A local data slot object.</returns>
	public static LocalDataStoreSlot AllocateNamedDataSlot(string name)
	{
		return null;
	}

	/// <summary>Frees a named data slot on all the contexts.</summary>
	/// <param name="name">The name of the data slot to free.</param>
	public static void FreeNamedDataSlot(string name)
	{
	}

	/// <summary>Looks up a named data slot.</summary>
	/// <param name="name">The data slot name.</param>
	/// <returns>A local data slot.</returns>
	public static LocalDataStoreSlot GetNamedDataSlot(string name)
	{
		return null;
	}

	/// <summary>Retrieves the value from the specified slot on the current context.</summary>
	/// <param name="slot">The data slot that contains the data.</param>
	/// <returns>The data associated with <paramref name="slot" />.</returns>
	public static object GetData(LocalDataStoreSlot slot)
	{
		return null;
	}

	/// <summary>Sets the data in the specified slot on the current context.</summary>
	/// <param name="slot">The data slot where the data is to be added.</param>
	/// <param name="data">The data that is to be added.</param>
	public static void SetData(LocalDataStoreSlot slot, object data)
	{
	}
}
