namespace UnityEngine.UIElements;

public interface IBindable
{
	IBinding binding { get; }

	string bindingPath { set; }
}
