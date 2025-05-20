namespace UnityEngine.UIElements.Experimental;

public interface ITransitionAnimations
{
	ValueAnimation<StyleValues> Start(StyleValues to, int durationMs);
}
