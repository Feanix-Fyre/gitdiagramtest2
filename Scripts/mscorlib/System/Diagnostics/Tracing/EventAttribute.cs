using System.Runtime.CompilerServices;

namespace System.Diagnostics.Tracing;

/// <summary>Specifies additional event schema information for an event.</summary>
[AttributeUsage(AttributeTargets.Method)]
public sealed class EventAttribute : Attribute
{
	[CompilerGenerated]
	private int _003CEventId_003Ek__BackingField;

	[CompilerGenerated]
	private EventLevel _003CLevel_003Ek__BackingField;

	[CompilerGenerated]
	private EventKeywords _003CKeywords_003Ek__BackingField;

	[CompilerGenerated]
	private EventOpcode _003COpcode_003Ek__BackingField;

	[CompilerGenerated]
	private string _003CMessage_003Ek__BackingField;

	[CompilerGenerated]
	private EventTask _003CTask_003Ek__BackingField;

	/// <summary>Gets or sets the identifier for the event.</summary>
	/// <returns>The event identifier. This value should be between 0 and 65535.</returns>
	private int EventId
	{
		[CompilerGenerated]
		set
		{
			_003CEventId_003Ek__BackingField = value;
		}
	}

	/// <summary>Gets or sets the level for the event.</summary>
	/// <returns>One of the enumeration values that specifies the level for the event.</returns>
	public EventLevel Level
	{
		[CompilerGenerated]
		set
		{
			_003CLevel_003Ek__BackingField = value;
		}
	}

	/// <summary>Gets or sets the keywords for the event.</summary>
	/// <returns>A bitwise combination of the enumeration values.</returns>
	public EventKeywords Keywords
	{
		[CompilerGenerated]
		set
		{
			_003CKeywords_003Ek__BackingField = value;
		}
	}

	/// <summary>Gets or sets the operation code for the event.</summary>
	/// <returns>One of the enumeration values that specifies the operation code.</returns>
	public EventOpcode Opcode
	{
		[CompilerGenerated]
		set
		{
			_003COpcode_003Ek__BackingField = value;
		}
	}

	/// <summary>Gets or sets the message for the event.</summary>
	/// <returns>The message for the event.</returns>
	public string Message
	{
		[CompilerGenerated]
		set
		{
			_003CMessage_003Ek__BackingField = value;
		}
	}

	/// <summary>Gets or sets the task for the event.</summary>
	/// <returns>The task for the event.</returns>
	public EventTask Task
	{
		[CompilerGenerated]
		set
		{
			_003CTask_003Ek__BackingField = value;
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.Tracing.EventAttribute" /> class with the specified event identifier.</summary>
	/// <param name="eventId">The event identifier for the event.</param>
	public EventAttribute(int eventId)
	{
	}
}
