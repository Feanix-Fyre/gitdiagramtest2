namespace System.ComponentModel.Design;

/// <summary>Extends the design mode behavior of a component.</summary>
public class ComponentDesigner : IDesigner, IDisposable
{
	/// <summary>Gets the component this designer is designing.</summary>
	/// <returns>The component managed by the designer.</returns>
	public IComponent Component => null;

	/// <summary>Gets the design-time verbs supported by the component that is associated with the designer.</summary>
	/// <returns>A <see cref="T:System.ComponentModel.Design.DesignerVerbCollection" /> of <see cref="T:System.ComponentModel.Design.DesignerVerb" /> objects, or <see langword="null" /> if no designer verbs are available. This default implementation always returns <see langword="null" />.</returns>
	public virtual DesignerVerbCollection Verbs => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.ComponentDesigner" /> class.</summary>
	public ComponentDesigner()
	{
	}

	/// <summary>Releases all resources used by the <see cref="T:System.ComponentModel.Design.ComponentDesigner" />.</summary>
	public void Dispose()
	{
	}
}
