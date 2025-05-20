namespace System.Xml.Schema;

internal class UpaException : Exception
{
	private object particle1;

	private object particle2;

	public object Particle1 => null;

	public object Particle2 => null;

	public UpaException(object particle1, object particle2)
	{
	}
}
