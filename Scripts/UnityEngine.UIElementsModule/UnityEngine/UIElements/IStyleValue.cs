namespace UnityEngine.UIElements;

internal interface IStyleValue<T>
{
	T value { get; }

	StyleKeyword keyword { get; }
}
