namespace UnityEngine.Timeline;

internal abstract class RuntimeClipBase : RuntimeElement
{
	public abstract double start { get; }

	public abstract double duration { get; }

	public override long intervalStart => 0L;

	public override long intervalEnd => 0L;
}
