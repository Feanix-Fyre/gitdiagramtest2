namespace UnityEngine.UIElements;

internal interface IGroupManager
{
	void Init(IGroupBox groupBox);

	void OnOptionSelectionChanged(IGroupBoxOption selectedOption);

	void RegisterOption(IGroupBoxOption option);

	void UnregisterOption(IGroupBoxOption option);
}
