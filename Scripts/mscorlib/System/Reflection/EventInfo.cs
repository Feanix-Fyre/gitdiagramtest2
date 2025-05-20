using Mono;

namespace System.Reflection;

/// <summary>Discovers the attributes of an event and provides access to event metadata.</summary>
[Serializable]
public abstract class EventInfo : MemberInfo
{
	private delegate void AddEventAdapter(object _this, Delegate dele);

	private AddEventAdapter cached_add_event;

	/// <summary>Gets a <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is an event.</summary>
	/// <returns>A <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is an event.</returns>
	public override MemberTypes MemberType => default(MemberTypes);

	/// <summary>Gets the <see langword="Type" /> object of the underlying event-handler delegate associated with this event.</summary>
	/// <returns>A read-only <see langword="Type" /> object representing the delegate event handler.</returns>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	public virtual Type EventHandlerType => null;

	/// <summary>Initializes a new instance of the <see langword="EventInfo" /> class.</summary>
	protected EventInfo()
	{
	}

	/// <summary>Returns the method used to add an event handler delegate to the event source.</summary>
	/// <returns>A <see cref="T:System.Reflection.MethodInfo" /> object representing the method used to add an event handler delegate to the event source.</returns>
	public MethodInfo GetAddMethod()
	{
		return null;
	}

	/// <summary>Returns the method used to remove an event handler delegate from the event source.</summary>
	/// <returns>A <see cref="T:System.Reflection.MethodInfo" /> object representing the method used to remove an event handler delegate from the event source.</returns>
	public MethodInfo GetRemoveMethod()
	{
		return null;
	}

	/// <summary>When overridden in a derived class, retrieves the <see langword="MethodInfo" /> object for the <see cref="M:System.Reflection.EventInfo.AddEventHandler(System.Object,System.Delegate)" /> method of the event, specifying whether to return non-public methods.</summary>
	/// <param name="nonPublic">
	///   <see langword="true" /> if non-public methods can be returned; otherwise, <see langword="false" />.</param>
	/// <returns>A <see cref="T:System.Reflection.MethodInfo" /> object representing the method used to add an event handler delegate to the event source.</returns>
	/// <exception cref="T:System.MethodAccessException">
	///   <paramref name="nonPublic" /> is <see langword="true" />, the method used to add an event handler delegate is non-public, and the caller does not have permission to reflect on non-public methods.</exception>
	public abstract MethodInfo GetAddMethod(bool nonPublic);

	/// <summary>When overridden in a derived class, retrieves the <see langword="MethodInfo" /> object for removing a method of the event, specifying whether to return non-public methods.</summary>
	/// <param name="nonPublic">
	///   <see langword="true" /> if non-public methods can be returned; otherwise, <see langword="false" />.</param>
	/// <returns>A <see cref="T:System.Reflection.MethodInfo" /> object representing the method used to remove an event handler delegate from the event source.</returns>
	/// <exception cref="T:System.MethodAccessException">
	///   <paramref name="nonPublic" /> is <see langword="true" />, the method used to add an event handler delegate is non-public, and the caller does not have permission to reflect on non-public methods.</exception>
	public abstract MethodInfo GetRemoveMethod(bool nonPublic);

	/// <summary>When overridden in a derived class, returns the method that is called when the event is raised, specifying whether to return non-public methods.</summary>
	/// <param name="nonPublic">
	///   <see langword="true" /> if non-public methods can be returned; otherwise, <see langword="false" />.</param>
	/// <returns>A <see langword="MethodInfo" /> object that was called when the event was raised.</returns>
	/// <exception cref="T:System.MethodAccessException">
	///   <paramref name="nonPublic" /> is <see langword="true" />, the method used to add an event handler delegate is non-public, and the caller does not have permission to reflect on non-public methods.</exception>
	public abstract MethodInfo GetRaiseMethod(bool nonPublic);

	/// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
	/// <param name="obj">An object to compare with this instance, or <see langword="null" />.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="obj" /> equals the type and value of this instance; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Returns the hash code for this instance.</summary>
	/// <returns>A 32-bit signed integer hash code.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Indicates whether two <see cref="T:System.Reflection.EventInfo" /> objects are equal.</summary>
	/// <param name="left">The first object to compare.</param>
	/// <param name="right">The second object to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="left" /> is equal to <paramref name="right" />; otherwise, <see langword="false" />.</returns>
	public static bool operator ==(EventInfo left, EventInfo right)
	{
		return false;
	}

	/// <summary>Indicates whether two <see cref="T:System.Reflection.EventInfo" /> objects are not equal.</summary>
	/// <param name="left">The first object to compare.</param>
	/// <param name="right">The second object to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="left" /> is not equal to <paramref name="right" />; otherwise, <see langword="false" />.</returns>
	public static bool operator !=(EventInfo left, EventInfo right)
	{
		return false;
	}

	private static EventInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle)
	{
		return null;
	}

	internal static EventInfo GetEventFromHandle(RuntimeEventHandle handle, RuntimeTypeHandle reflectedType)
	{
		return null;
	}
}
