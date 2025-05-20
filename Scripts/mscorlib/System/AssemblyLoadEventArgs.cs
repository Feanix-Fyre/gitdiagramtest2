using System.Reflection;

namespace System;

/// <summary>Provides data for the <see cref="E:System.AppDomain.AssemblyLoad" /> event.</summary>
public class AssemblyLoadEventArgs : EventArgs
{
	/// <summary>Initializes a new instance of the <see cref="T:System.AssemblyLoadEventArgs" /> class using the specified <see cref="T:System.Reflection.Assembly" />.</summary>
	/// <param name="loadedAssembly">An instance that represents the currently loaded assembly.</param>
	public AssemblyLoadEventArgs(Assembly loadedAssembly)
	{
	}
}
