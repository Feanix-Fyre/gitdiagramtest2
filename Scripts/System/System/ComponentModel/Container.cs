namespace System.ComponentModel;

/// <summary>Encapsulates zero or more components.</summary>
public class Container : IContainer, IDisposable
{
	private class Site : ISite, IServiceProvider
	{
		private IComponent component;

		private Container container;

		private string name;

		public IComponent Component => null;

		public IContainer Container => null;

		public bool DesignMode => false;

		public string Name => null;

		internal Site(IComponent component, Container container, string name)
		{
		}

		public object GetService(Type service)
		{
			return null;
		}
	}

	private ISite[] sites;

	private int siteCount;

	private ComponentCollection components;

	private ContainerFilterService filter;

	private bool checkedFilter;

	private object syncObj;

	/// <summary>Gets all the components in the <see cref="T:System.ComponentModel.Container" />.</summary>
	/// <returns>A collection that contains the components in the <see cref="T:System.ComponentModel.Container" />.</returns>
	public virtual ComponentCollection Components => null;

	/// <summary>Releases unmanaged resources and performs other cleanup operations before the <see cref="T:System.ComponentModel.Container" /> is reclaimed by garbage collection.</summary>
	~Container()
	{
	}

	/// <summary>Adds the specified <see cref="T:System.ComponentModel.Component" /> to the <see cref="T:System.ComponentModel.Container" />. The component is unnamed.</summary>
	/// <param name="component">The component to add.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="component" /> is <see langword="null" />.</exception>
	public virtual void Add(IComponent component)
	{
	}

	/// <summary>Adds the specified <see cref="T:System.ComponentModel.Component" /> to the <see cref="T:System.ComponentModel.Container" /> and assigns it a name.</summary>
	/// <param name="component">The component to add.</param>
	/// <param name="name">The unique, case-insensitive name to assign to the component.  
	///  -or-  
	///  <see langword="null" />, which leaves the component unnamed.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="component" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="name" /> is not unique.</exception>
	public virtual void Add(IComponent component, string name)
	{
	}

	/// <summary>Creates a site <see cref="T:System.ComponentModel.ISite" /> for the given <see cref="T:System.ComponentModel.IComponent" /> and assigns the given name to the site.</summary>
	/// <param name="component">The <see cref="T:System.ComponentModel.IComponent" /> to create a site for.</param>
	/// <param name="name">The name to assign to <paramref name="component" />, or <see langword="null" /> to skip the name assignment.</param>
	/// <returns>The newly created site.</returns>
	protected virtual ISite CreateSite(IComponent component, string name)
	{
		return null;
	}

	/// <summary>Releases all resources used by the <see cref="T:System.ComponentModel.Container" />.</summary>
	public void Dispose()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.ComponentModel.Container" />, and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected virtual void Dispose(bool disposing)
	{
	}

	/// <summary>Gets the service object of the specified type, if it is available.</summary>
	/// <param name="service">The <see cref="T:System.Type" /> of the service to retrieve.</param>
	/// <returns>An <see cref="T:System.Object" /> implementing the requested service, or <see langword="null" /> if the service cannot be resolved.</returns>
	protected virtual object GetService(Type service)
	{
		return null;
	}

	/// <summary>Removes a component from the <see cref="T:System.ComponentModel.Container" />.</summary>
	/// <param name="component">The component to remove.</param>
	public virtual void Remove(IComponent component)
	{
	}

	private void Remove(IComponent component, bool preserveSite)
	{
	}

	/// <summary>Determines whether the component name is unique for this container.</summary>
	/// <param name="component">The named component.</param>
	/// <param name="name">The component name to validate.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="component" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="name" /> is not unique.</exception>
	protected virtual void ValidateName(IComponent component, string name)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Container" /> class.</summary>
	public Container()
	{
	}
}
