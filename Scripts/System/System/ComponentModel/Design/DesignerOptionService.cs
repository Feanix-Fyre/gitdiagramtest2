using System.Collections;
using System.Globalization;
using System.Reflection;

namespace System.ComponentModel.Design;

/// <summary>Provides a base class for getting and setting option values for a designer.</summary>
public abstract class DesignerOptionService
{
	/// <summary>Contains a collection of designer options. This class cannot be inherited.</summary>
	[Editor(null, "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[DefaultMember("Item")]
	[TypeConverter(typeof(DesignerOptionConverter))]
	public sealed class DesignerOptionCollection : ICollection
	{
		private sealed class WrappedPropertyDescriptor : PropertyDescriptor
		{
			private object target;

			private PropertyDescriptor property;

			public override AttributeCollection Attributes => null;

			public override Type ComponentType => null;

			public override bool IsReadOnly => false;

			public override Type PropertyType => null;

			internal WrappedPropertyDescriptor(PropertyDescriptor property, object target)
				: base((string)null, (Attribute[])null)
			{
			}

			public override bool CanResetValue(object component)
			{
				return false;
			}

			public override object GetValue(object component)
			{
				return null;
			}

			public override void ResetValue(object component)
			{
			}

			public override void SetValue(object component, object value)
			{
			}

			public override bool ShouldSerializeValue(object component)
			{
				return false;
			}
		}

		private DesignerOptionService _service;

		private string _name;

		private object _value;

		private ArrayList _children;

		private PropertyDescriptorCollection _properties;

		/// <summary>Gets the number of child option collections this <see cref="T:System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection" /> contains.</summary>
		/// <returns>The number of child option collections this <see cref="T:System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection" /> contains.</returns>
		public int Count => 0;

		/// <summary>Gets the name of this <see cref="T:System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection" />.</summary>
		/// <returns>The name of this <see cref="T:System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection" />.</returns>
		public string Name => null;

		/// <summary>Gets the collection of properties offered by this <see cref="T:System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection" />, along with all of its children.</summary>
		/// <returns>The collection of properties offered by this <see cref="T:System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection" />, along with all of its children.</returns>
		public PropertyDescriptorCollection Properties => null;

		/// <summary>Gets a value indicating whether access to the collection is synchronized and, therefore, thread safe.</summary>
		/// <returns>
		///   <see langword="true" /> if the access to the collection is synchronized; otherwise, <see langword="false" />.</returns>
		bool ICollection.IsSynchronized => false;

		/// <summary>Gets an object that can be used to synchronize access to the collection.</summary>
		/// <returns>An object that can be used to synchronize access to the collection.</returns>
		object ICollection.SyncRoot => null;

		/// <summary>Copies the entire collection to a compatible one-dimensional <see cref="T:System.Array" />, starting at the specified index of the target array.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from the collection. The <paramref name="array" /> must have zero-based indexing.</param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		public void CopyTo(Array array, int index)
		{
		}

		private void EnsurePopulated()
		{
		}

		/// <summary>Returns an <see cref="T:System.Collections.IEnumerator" /> that can be used to iterate this collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that can be used to iterate this collection.</returns>
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}

	internal sealed class DesignerOptionConverter : TypeConverter
	{
		private class OptionPropertyDescriptor : PropertyDescriptor
		{
			private DesignerOptionCollection _option;

			public override Type ComponentType => null;

			public override bool IsReadOnly => false;

			public override Type PropertyType => null;

			internal OptionPropertyDescriptor(DesignerOptionCollection option)
				: base((string)null, (Attribute[])null)
			{
			}

			public override bool CanResetValue(object component)
			{
				return false;
			}

			public override object GetValue(object component)
			{
				return null;
			}

			public override void ResetValue(object component)
			{
			}

			public override void SetValue(object component, object value)
			{
			}

			public override bool ShouldSerializeValue(object component)
			{
				return false;
			}
		}

		public override bool GetPropertiesSupported(ITypeDescriptorContext cxt)
		{
			return false;
		}

		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext cxt, object value, Attribute[] attributes)
		{
			return null;
		}

		public override object ConvertTo(ITypeDescriptorContext cxt, CultureInfo culture, object value, Type destinationType)
		{
			return null;
		}
	}

	/// <summary>Populates a <see cref="T:System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection" />.</summary>
	/// <param name="options">The collection to populate.</param>
	protected virtual void PopulateOptionCollection(DesignerOptionCollection options)
	{
	}
}
