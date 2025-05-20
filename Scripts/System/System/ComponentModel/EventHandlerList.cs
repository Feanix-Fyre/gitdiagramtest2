namespace System.ComponentModel;

/// <summary>Provides a simple list of delegates. This class cannot be inherited.</summary>
public sealed class EventHandlerList : IDisposable
{
	private sealed class ListEntry
	{
		internal ListEntry _next;

		internal object _key;

		internal Delegate _handler;

		public ListEntry(object key, Delegate handler, ListEntry next)
		{
		}
	}

	private ListEntry _head;

	private Component _parent;

	/// <summary>Gets or sets the delegate for the specified object.</summary>
	/// <param name="key">An object to find in the list.</param>
	/// <returns>The delegate for the specified key, or <see langword="null" /> if a delegate does not exist.</returns>
	public Delegate this[object key]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal EventHandlerList(Component parent)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.EventHandlerList" /> class.</summary>
	public EventHandlerList()
	{
	}

	/// <summary>Adds a delegate to the list.</summary>
	/// <param name="key">The object that owns the event.</param>
	/// <param name="value">The delegate to add to the list.</param>
	public void AddHandler(object key, Delegate value)
	{
	}

	/// <summary>Disposes the delegate list.</summary>
	public void Dispose()
	{
	}

	private ListEntry Find(object key)
	{
		return null;
	}

	/// <summary>Removes a delegate from the list.</summary>
	/// <param name="key">The object that owns the event.</param>
	/// <param name="value">The delegate to remove from the list.</param>
	public void RemoveHandler(object key, Delegate value)
	{
	}
}
