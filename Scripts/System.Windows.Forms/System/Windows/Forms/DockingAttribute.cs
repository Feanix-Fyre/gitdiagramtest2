namespace System.Windows.Forms;

/// <summary>Specifies the default docking behavior for a control.</summary>
[AttributeUsage(AttributeTargets.Class)]
public sealed class DockingAttribute : Attribute
{
	private DockingBehavior dockingBehavior;

	/// <summary>The default <see cref="T:System.Windows.Forms.DockingAttribute" /> for this control.</summary>
	public static readonly DockingAttribute Default;

	/// <summary>Gets the docking behavior supplied to this attribute.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.DockingBehavior" /> value.</returns>
	public DockingBehavior DockingBehavior => default(DockingBehavior);

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.DockingAttribute" /> class.</summary>
	public DockingAttribute()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.DockingAttribute" /> class with the given docking behavior.</summary>
	/// <param name="dockingBehavior">A <see cref="T:System.Windows.Forms.DockingBehavior" /> value specifying the default behavior.</param>
	public DockingAttribute(DockingBehavior dockingBehavior)
	{
	}

	/// <summary>Compares an arbitrary object with the <see cref="T:System.Windows.Forms.DockingAttribute" /> object for equality.</summary>
	/// <param name="obj">The <see cref="T:System.Object" /> against which to compare this <see cref="T:System.Windows.Forms.DockingAttribute" />.</param>
	/// <returns>
	///   <see langword="true" /> is <paramref name="obj" /> is equal to this <see cref="T:System.Windows.Forms.DockingAttribute" />; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>The hash code for this object.</summary>
	/// <returns>An <see cref="T:System.Int32" /> representing an in-memory hash of this object.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Specifies whether this <see cref="T:System.Windows.Forms.DockingAttribute" /> is the default docking attribute.</summary>
	/// <returns>
	///   <see langword="true" /> is the current <see cref="T:System.Windows.Forms.DockingAttribute" /> is the default; otherwise, <see langword="false" />.</returns>
	public override bool IsDefaultAttribute()
	{
		return false;
	}
}
