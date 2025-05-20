using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Messaging;

/// <summary>Defines the method call message interface.</summary>
[ComVisible(true)]
public interface IMethodCallMessage : IMethodMessage, IMessage
{
}
