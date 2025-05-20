using System.Runtime.CompilerServices;

namespace System.Diagnostics.Tracing;

/// <summary>Allows the event tracing for Windows (ETW) name to be defined independently of the name of the event source class.</summary>
[AttributeUsage(AttributeTargets.Class)]
public sealed class EventSourceAttribute : Attribute
{
	[CompilerGenerated]
	private string _003CGuid_003Ek__BackingField;

	[CompilerGenerated]
	private string _003CName_003Ek__BackingField;

	/// <summary>Gets or sets the event source identifier.</summary>
	/// <returns>The event source identifier.</returns>
	public string Guid
	{
		[CompilerGenerated]
		set
		{
			_003CGuid_003Ek__BackingField = value;
		}
	}

	/// <summary>Gets or sets the name of the event source.</summary>
	/// <returns>The name of the event source.</returns>
	public string Name
	{
		[CompilerGenerated]
		set
		{
			_003CName_003Ek__BackingField = value;
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.Tracing.EventSourceAttribute" /> class.</summary>
	public EventSourceAttribute()
	{
	}
}
