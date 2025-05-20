using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Resources;

namespace System.ComponentModel;

/// <summary>Provides simple functionality for enumerating resources for a component or object. The <see cref="T:System.ComponentModel.ComponentResourceManager" /> class is a <see cref="T:System.Resources.ResourceManager" />.</summary>
public class ComponentResourceManager : ResourceManager
{
	private Hashtable _resourceSets;

	private CultureInfo _neutralResourcesCulture;

	private CultureInfo NeutralResourcesCulture => null;

	/// <summary>Creates a <see cref="T:System.ComponentModel.ComponentResourceManager" /> that looks up resources in satellite assemblies based on information from the specified <see cref="T:System.Type" />.</summary>
	/// <param name="t">A <see cref="T:System.Type" /> from which the <see cref="T:System.ComponentModel.ComponentResourceManager" /> derives all information for finding resource files.</param>
	public ComponentResourceManager(Type t)
	{
	}

	/// <summary>Applies a resource's value to the corresponding property of the object.</summary>
	/// <param name="value">An <see cref="T:System.Object" /> that contains the property value to be applied.</param>
	/// <param name="objectName">A <see cref="T:System.String" /> that contains the name of the object to look up in the resources.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> or <paramref name="objectName" /> is <see langword="null" />.</exception>
	public void ApplyResources(object value, string objectName)
	{
	}

	/// <summary>Applies a resource's value to the corresponding property of the object.</summary>
	/// <param name="value">An <see cref="T:System.Object" /> that contains the property value to be applied.</param>
	/// <param name="objectName">A <see cref="T:System.String" /> that contains the name of the object to look up in the resources.</param>
	/// <param name="culture">The culture for which to apply resources.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> or <paramref name="objectName" /> is <see langword="null" />.</exception>
	public virtual void ApplyResources(object value, string objectName, CultureInfo culture)
	{
	}

	private SortedList<string, object> FillResources(CultureInfo culture, out ResourceSet resourceSet)
	{
		resourceSet = null;
		return null;
	}
}
