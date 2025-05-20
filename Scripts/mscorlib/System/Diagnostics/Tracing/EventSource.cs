using System.Runtime.CompilerServices;

namespace System.Diagnostics.Tracing;

/// <summary>Provides the ability to create events for event tracing for Windows (ETW).</summary>
public class EventSource : IDisposable
{
	/// <summary>Provides the event data for creating fast <see cref="Overload:System.Diagnostics.Tracing.EventSource.WriteEvent" /> overloads by using the <see cref="M:System.Diagnostics.Tracing.EventSource.WriteEventCore(System.Int32,System.Int32,System.Diagnostics.Tracing.EventSource.EventData*)" /> method.</summary>
	protected internal struct EventData
	{
		[CompilerGenerated]
		private IntPtr _003CDataPointer_003Ek__BackingField;

		[CompilerGenerated]
		private int _003CSize_003Ek__BackingField;

		[CompilerGenerated]
		private int _003CReserved_003Ek__BackingField;

		/// <summary>Gets or sets the pointer to the data for the new <see cref="Overload:System.Diagnostics.Tracing.EventSource.WriteEvent" /> overload.</summary>
		/// <returns>The pointer to the data.</returns>
		public IntPtr DataPointer
		{
			[CompilerGenerated]
			set
			{
				_003CDataPointer_003Ek__BackingField = value;
			}
		}

		/// <summary>Gets or sets the number of payload items in the new <see cref="Overload:System.Diagnostics.Tracing.EventSource.WriteEvent" /> overload.</summary>
		/// <returns>The number of payload items in the new overload.</returns>
		public int Size
		{
			[CompilerGenerated]
			set
			{
				_003CSize_003Ek__BackingField = value;
			}
		}

		internal int Reserved
		{
			[CompilerGenerated]
			set
			{
				_003CReserved_003Ek__BackingField = value;
			}
		}
	}

	[CompilerGenerated]
	private string _003CName_003Ek__BackingField;

	/// <summary>The friendly name of the class that is derived from the event source.</summary>
	/// <returns>The friendly name of the derived class.  The default is the simple name of the class.</returns>
	private string Name
	{
		[CompilerGenerated]
		set
		{
			_003CName_003Ek__BackingField = value;
		}
	}

	/// <summary>Creates a new instance of the <see cref="T:System.Diagnostics.Tracing.EventSource" /> class.</summary>
	protected EventSource()
	{
	}

	/// <summary>Creates a new instance of the <see cref="T:System.Diagnostics.Tracing.EventSource" /> class with the specified name.</summary>
	/// <param name="eventSourceName">The name to apply to the event source. Must not be <see langword="null" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="eventSourceName" /> is <see langword="null" />.</exception>
	public EventSource(string eventSourceName)
	{
	}

	internal EventSource(Guid eventSourceGuid, string eventSourceName)
	{
	}

	/// <summary>Allows the <see cref="T:System.Diagnostics.Tracing.EventSource" /> object to attempt to free resources and perform other cleanup operations before the  object is reclaimed by garbage collection.</summary>
	~EventSource()
	{
	}

	/// <summary>Determines whether the current event source is enabled.</summary>
	/// <returns>
	///   <see langword="true" /> if the current event source is enabled; otherwise, <see langword="false" />.</returns>
	public bool IsEnabled()
	{
		return false;
	}

	/// <summary>Determines whether the current event source that has the specified level and keyword is enabled.</summary>
	/// <param name="level">The level of the event source.</param>
	/// <param name="keywords">The keyword of the event source.</param>
	/// <returns>
	///   <see langword="true" /> if the event source is enabled; otherwise, <see langword="false" />.</returns>
	public bool IsEnabled(EventLevel level, EventKeywords keywords)
	{
		return false;
	}

	/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Diagnostics.Tracing.EventSource" /> class.</summary>
	public void Dispose()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Diagnostics.Tracing.EventSource" /> class and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected virtual void Dispose(bool disposing)
	{
	}

	/// <summary>Writes an event by using the provided event identifier and 32-bit integer argument.</summary>
	/// <param name="eventId">The event identifier.  This value should be between 0 and 65535.</param>
	/// <param name="arg1">An integer argument.</param>
	protected void WriteEvent(int eventId, int arg1)
	{
	}

	/// <summary>Writes an event by using the provided event identifier and string argument.</summary>
	/// <param name="eventId">The event identifier.  This value should be between 0 and 65535.</param>
	/// <param name="arg1">A string argument.</param>
	protected void WriteEvent(int eventId, string arg1)
	{
	}

	/// <summary>Writes an event by using the provided event identifier and 32-bit integer arguments.</summary>
	/// <param name="eventId">The event identifier.  This value should be between 0 and 65535.</param>
	/// <param name="arg1">An integer argument.</param>
	/// <param name="arg2">An integer argument.</param>
	protected void WriteEvent(int eventId, int arg1, int arg2)
	{
	}

	/// <summary>Writes an event by using the provided event identifier and 32-bit integer arguments.</summary>
	/// <param name="eventId">The event identifier.  This value should be between 0 and 65535.</param>
	/// <param name="arg1">An integer argument.</param>
	/// <param name="arg2">An integer argument.</param>
	/// <param name="arg3">An integer argument.</param>
	protected void WriteEvent(int eventId, int arg1, int arg2, int arg3)
	{
	}

	/// <summary>Writes an event by using the provided event identifier and 64-bit integer argument.</summary>
	/// <param name="eventId">The event identifier.  This value should be between 0 and 65535.</param>
	/// <param name="arg1">A 64 bit integer argument.</param>
	protected void WriteEvent(int eventId, long arg1)
	{
	}

	/// <summary>Writes an event by using the provided event identifier and 64-bit integer, and string arguments.</summary>
	/// <param name="eventId">The event identifier.  This value should be between 0 and 65535.</param>
	/// <param name="arg1">A 64-bit integer argument.</param>
	/// <param name="arg2">A string argument.</param>
	protected void WriteEvent(int eventId, long arg1, string arg2)
	{
	}

	/// <summary>Writes an event by using the provided event identifier and array of arguments.</summary>
	/// <param name="eventId">The event identifier.  This value should be between 0 and 65535.</param>
	/// <param name="args">An array of objects.</param>
	protected void WriteEvent(int eventId, params object[] args)
	{
	}

	/// <summary>Writes an event by using the provided event identifier and string arguments.</summary>
	/// <param name="eventId">The event identifier.  This value should be between 0 and 65535.</param>
	/// <param name="arg1">A string argument.</param>
	/// <param name="arg2">A string argument.</param>
	/// <param name="arg3">A string argument.</param>
	protected void WriteEvent(int eventId, string arg1, string arg2, string arg3)
	{
	}

	/// <summary>Creates a new <see cref="Overload:System.Diagnostics.Tracing.EventSource.WriteEvent" /> overload by using the provided event identifier and event data.</summary>
	/// <param name="eventId">The event identifier.</param>
	/// <param name="eventDataCount">The number of event data items.</param>
	/// <param name="data">The structure that contains the event data.</param>
	[CLSCompliant(false)]
	protected unsafe void WriteEventCore(int eventId, int eventDataCount, EventData* data)
	{
	}
}
