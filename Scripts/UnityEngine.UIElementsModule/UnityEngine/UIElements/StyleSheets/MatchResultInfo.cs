namespace UnityEngine.UIElements.StyleSheets;

internal struct MatchResultInfo
{
	public readonly bool success;

	public readonly PseudoStates triggerPseudoMask;

	public readonly PseudoStates dependencyPseudoMask;

	public MatchResultInfo(bool success, PseudoStates triggerPseudoMask, PseudoStates dependencyPseudoMask)
	{
		this.success = false;
		this.triggerPseudoMask = default(PseudoStates);
		this.dependencyPseudoMask = default(PseudoStates);
	}
}
