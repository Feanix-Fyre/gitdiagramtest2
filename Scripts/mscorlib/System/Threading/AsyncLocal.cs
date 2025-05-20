namespace System.Threading;

/// <summary>Represents ambient data that is local to a given asynchronous control flow, such as an asynchronous method.</summary>
/// <typeparam name="T">The type of the ambient data.</typeparam>
public sealed class AsyncLocal<T>
{
	private readonly Action<AsyncLocalValueChangedArgs<T>> m_valueChangedHandler;
}
