using System.ComponentModel.Design.Serialization;
using System.Runtime.InteropServices;

namespace System.ComponentModel;

/// <summary>Provides functionality required by all components.</summary>
[ComVisible(true)]
[TypeConverter(typeof(ComponentConverter))]
[RootDesignerSerializer("System.ComponentModel.Design.Serialization.RootCodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", true)]
public interface IComponent : IDisposable
{
	/// <summary>Gets or sets the <see cref="T:System.ComponentModel.ISite" /> associated with the <see cref="T:System.ComponentModel.IComponent" />.</summary>
	/// <returns>The <see cref="T:System.ComponentModel.ISite" /> object associated with the component; or <see langword="null" />, if the component does not have a site.</returns>
	ISite Site { get; set; }
}
