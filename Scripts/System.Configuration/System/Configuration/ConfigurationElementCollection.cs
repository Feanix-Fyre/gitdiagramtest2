using System.Diagnostics;

namespace System.Configuration;

/// <summary>Represents a configuration element containing a collection of child elements.</summary>
[DebuggerDisplay("Count = {Count}")]
public abstract class ConfigurationElementCollection : ConfigurationElement
{
}
