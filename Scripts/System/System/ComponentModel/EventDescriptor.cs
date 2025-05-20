namespace System.ComponentModel;

/// <summary>Provides information about an event.</summary>
public abstract class EventDescriptor : MemberDescriptor
{
	/// <summary>When overridden in a derived class, gets the type of delegate for the event.</summary>
	/// <returns>A <see cref="T:System.Type" /> that represents the type of delegate for the event.</returns>
	public abstract Type EventType { get; }

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.EventDescriptor" /> class with the specified name and attribute array.</summary>
	/// <param name="name">The name of the event.</param>
	/// <param name="attrs">An array of type <see cref="T:System.Attribute" /> that contains the event attributes.</param>
	protected EventDescriptor(string name, Attribute[] attrs)
		: base((string)null, (Attribute[])null)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.EventDescriptor" /> class with the name in the specified <see cref="T:System.ComponentModel.MemberDescriptor" /> and the attributes in both the <see cref="T:System.ComponentModel.MemberDescriptor" /> and the <see cref="T:System.Attribute" /> array.</summary>
	/// <param name="descr">A <see cref="T:System.ComponentModel.MemberDescriptor" /> that has the name of the member and its attributes.</param>
	/// <param name="attrs">An <see cref="T:System.Attribute" /> array with the attributes you want to add to this event description.</param>
	protected EventDescriptor(MemberDescriptor descr, Attribute[] attrs)
		: base((string)null, (Attribute[])null)
	{
	}

	/// <summary>When overridden in a derived class, binds the event to the component.</summary>
	/// <param name="component">A component that provides events to the delegate.</param>
	/// <param name="value">A delegate that represents the method that handles the event.</param>
	public abstract void AddEventHandler(object component, Delegate value);

	/// <summary>When overridden in a derived class, unbinds the delegate from the component so that the delegate will no longer receive events from the component.</summary>
	/// <param name="component">The component that the delegate is bound to.</param>
	/// <param name="value">The delegate to unbind from the component.</param>
	public abstract void RemoveEventHandler(object component, Delegate value);
}
