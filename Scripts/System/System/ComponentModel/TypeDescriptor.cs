using System.Collections;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.ComponentModel;

/// <summary>Provides information about the characteristics for a component, such as its attributes, properties, and events. This class cannot be inherited.</summary>
public sealed class TypeDescriptor
{
	private sealed class AttributeProvider : TypeDescriptionProvider
	{
		private class AttributeTypeDescriptor : CustomTypeDescriptor
		{
			private Attribute[] _attributeArray;

			internal AttributeTypeDescriptor(Attribute[] attrs, ICustomTypeDescriptor parent)
			{
			}

			public override AttributeCollection GetAttributes()
			{
				return null;
			}
		}

		private Attribute[] _attrs;

		internal AttributeProvider(TypeDescriptionProvider existingProvider, params Attribute[] attrs)
		{
		}

		public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
		{
			return null;
		}
	}

	private sealed class ComNativeDescriptionProvider : TypeDescriptionProvider
	{
		private sealed class ComNativeTypeDescriptor : ICustomTypeDescriptor
		{
			private IComNativeDescriptorHandler _handler;

			private object _instance;

			internal ComNativeTypeDescriptor(IComNativeDescriptorHandler handler, object instance)
			{
			}

			AttributeCollection ICustomTypeDescriptor.GetAttributes()
			{
				return null;
			}

			string ICustomTypeDescriptor.GetClassName()
			{
				return null;
			}

			string ICustomTypeDescriptor.GetComponentName()
			{
				return null;
			}

			TypeConverter ICustomTypeDescriptor.GetConverter()
			{
				return null;
			}

			EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
			{
				return null;
			}

			PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
			{
				return null;
			}

			object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
			{
				return null;
			}

			EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
			{
				return null;
			}

			EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
			{
				return null;
			}

			PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
			{
				return null;
			}

			PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
			{
				return null;
			}

			object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
			{
				return null;
			}
		}

		private IComNativeDescriptorHandler _handler;

		internal IComNativeDescriptorHandler Handler
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal ComNativeDescriptionProvider(IComNativeDescriptorHandler handler)
		{
		}

		public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
		{
			return null;
		}
	}

	private sealed class AttributeFilterCacheItem
	{
		private Attribute[] _filter;

		internal ICollection FilteredMembers;

		internal AttributeFilterCacheItem(Attribute[] filter, ICollection filteredMembers)
		{
		}

		internal bool IsValid(Attribute[] filter)
		{
			return false;
		}
	}

	private sealed class FilterCacheItem
	{
		private ITypeDescriptorFilterService _filterService;

		internal ICollection FilteredMembers;

		internal FilterCacheItem(ITypeDescriptorFilterService filterService, ICollection filteredMembers)
		{
		}

		internal bool IsValid(ITypeDescriptorFilterService filterService)
		{
			return false;
		}
	}

	private interface IUnimplemented
	{
	}

	private sealed class MemberDescriptorComparer : IComparer
	{
		public static readonly MemberDescriptorComparer Instance;

		public int Compare(object left, object right)
		{
			return 0;
		}
	}

	private sealed class MergedTypeDescriptor : ICustomTypeDescriptor
	{
		private ICustomTypeDescriptor _primary;

		private ICustomTypeDescriptor _secondary;

		internal MergedTypeDescriptor(ICustomTypeDescriptor primary, ICustomTypeDescriptor secondary)
		{
		}

		AttributeCollection ICustomTypeDescriptor.GetAttributes()
		{
			return null;
		}

		string ICustomTypeDescriptor.GetClassName()
		{
			return null;
		}

		string ICustomTypeDescriptor.GetComponentName()
		{
			return null;
		}

		TypeConverter ICustomTypeDescriptor.GetConverter()
		{
			return null;
		}

		EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
		{
			return null;
		}

		PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
		{
			return null;
		}

		object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
		{
			return null;
		}

		EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
		{
			return null;
		}

		EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
		{
			return null;
		}

		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
		{
			return null;
		}

		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
		{
			return null;
		}

		object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
		{
			return null;
		}
	}

	private sealed class TypeDescriptionNode : TypeDescriptionProvider
	{
		private struct DefaultExtendedTypeDescriptor : ICustomTypeDescriptor
		{
			private TypeDescriptionNode _node;

			private object _instance;

			internal DefaultExtendedTypeDescriptor(TypeDescriptionNode node, object instance)
			{
				_node = null;
				_instance = null;
			}

			AttributeCollection ICustomTypeDescriptor.GetAttributes()
			{
				return null;
			}

			string ICustomTypeDescriptor.GetClassName()
			{
				return null;
			}

			string ICustomTypeDescriptor.GetComponentName()
			{
				return null;
			}

			TypeConverter ICustomTypeDescriptor.GetConverter()
			{
				return null;
			}

			EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
			{
				return null;
			}

			PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
			{
				return null;
			}

			object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
			{
				return null;
			}

			EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
			{
				return null;
			}

			EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
			{
				return null;
			}

			PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
			{
				return null;
			}

			PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
			{
				return null;
			}

			object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
			{
				return null;
			}
		}

		private struct DefaultTypeDescriptor : ICustomTypeDescriptor
		{
			private TypeDescriptionNode _node;

			private Type _objectType;

			private object _instance;

			internal DefaultTypeDescriptor(TypeDescriptionNode node, Type objectType, object instance)
			{
				_node = null;
				_objectType = null;
				_instance = null;
			}

			AttributeCollection ICustomTypeDescriptor.GetAttributes()
			{
				return null;
			}

			string ICustomTypeDescriptor.GetClassName()
			{
				return null;
			}

			string ICustomTypeDescriptor.GetComponentName()
			{
				return null;
			}

			TypeConverter ICustomTypeDescriptor.GetConverter()
			{
				return null;
			}

			EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
			{
				return null;
			}

			PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
			{
				return null;
			}

			object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
			{
				return null;
			}

			EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
			{
				return null;
			}

			EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
			{
				return null;
			}

			PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
			{
				return null;
			}

			PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
			{
				return null;
			}

			object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
			{
				return null;
			}
		}

		internal TypeDescriptionNode Next;

		internal TypeDescriptionProvider Provider;

		internal TypeDescriptionNode(TypeDescriptionProvider provider)
		{
		}

		public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
		{
			return null;
		}

		public override IDictionary GetCache(object instance)
		{
			return null;
		}

		public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance)
		{
			return null;
		}

		protected internal override IExtenderProvider[] GetExtenderProviders(object instance)
		{
			return null;
		}

		public override string GetFullComponentName(object component)
		{
			return null;
		}

		public override Type GetReflectionType(Type objectType, object instance)
		{
			return null;
		}

		public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
		{
			return null;
		}
	}

	[TypeDescriptionProvider("System.Windows.Forms.ComponentModel.Com2Interop.ComNativeDescriptor, System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	private sealed class TypeDescriptorComObject
	{
	}

	private sealed class TypeDescriptorInterface
	{
	}

	private static WeakHashtable _providerTable;

	private static Hashtable _providerTypeTable;

	private static Hashtable _defaultProviders;

	private static WeakHashtable _associationTable;

	private static int _metadataVersion;

	private static int _collisionIndex;

	private static BooleanSwitch TraceDescriptor;

	private const int PIPELINE_ATTRIBUTES = 0;

	private const int PIPELINE_PROPERTIES = 1;

	private const int PIPELINE_EVENTS = 2;

	private static readonly Guid[] _pipelineInitializeKeys;

	private static readonly Guid[] _pipelineMergeKeys;

	private static readonly Guid[] _pipelineFilterKeys;

	private static readonly Guid[] _pipelineAttributeFilterKeys;

	private static object _internalSyncObject;

	/// <summary>Gets or sets the provider for the Component Object Model (COM) type information for the target component.</summary>
	/// <returns>An <see cref="T:System.ComponentModel.IComNativeDescriptorHandler" /> instance representing the COM type information provider.</returns>
	[Obsolete("This property has been deprecated.  Use a type description provider to supply type information for COM types instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	public static IComNativeDescriptorHandler ComNativeDescriptorHandler
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the type of the Component Object Model (COM) object represented by the target component.</summary>
	/// <returns>The <see cref="T:System.Type" /> of the COM object represented by this component, or <see langword="null" /> for non-COM objects.</returns>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static Type ComObjectType => null;

	/// <summary>Gets a type that represents a type description provider for all interface types.</summary>
	/// <returns>A <see cref="T:System.Type" /> that represents a custom type description provider for all interface types.</returns>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static Type InterfaceType => null;

	internal static int MetadataVersion => 0;

	/// <summary>Occurs when the cache for a component is cleared.</summary>
	public static event RefreshEventHandler Refreshed
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private TypeDescriptor()
	{
	}

	/// <summary>Adds class-level attributes to the target component type.</summary>
	/// <param name="type">The <see cref="T:System.Type" /> of the target component.</param>
	/// <param name="attributes">An array of <see cref="T:System.Attribute" /> objects to add to the component's class.</param>
	/// <returns>The newly created <see cref="T:System.ComponentModel.TypeDescriptionProvider" /> that was used to add the specified attributes.</returns>
	/// <exception cref="T:System.ArgumentNullException">One or both of the parameters is <see langword="null" />.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static TypeDescriptionProvider AddAttributes(Type type, params Attribute[] attributes)
	{
		return null;
	}

	/// <summary>Adds class-level attributes to the target component instance.</summary>
	/// <param name="instance">An instance of the target component.</param>
	/// <param name="attributes">An array of <see cref="T:System.Attribute" /> objects to add to the component's class.</param>
	/// <returns>The newly created <see cref="T:System.ComponentModel.TypeDescriptionProvider" /> that was used to add the specified attributes.</returns>
	/// <exception cref="T:System.ArgumentNullException">One or both of the parameters is <see langword="null" />.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static TypeDescriptionProvider AddAttributes(object instance, params Attribute[] attributes)
	{
		return null;
	}

	/// <summary>Adds an editor table for the given editor base type.</summary>
	/// <param name="editorBaseType">The editor base type to add the editor table for. If a table already exists for this type, this method will do nothing.</param>
	/// <param name="table">The <see cref="T:System.Collections.Hashtable" /> to add.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static void AddEditorTable(Type editorBaseType, Hashtable table)
	{
	}

	/// <summary>Adds a type description provider for a component class.</summary>
	/// <param name="provider">The <see cref="T:System.ComponentModel.TypeDescriptionProvider" /> to add.</param>
	/// <param name="type">The <see cref="T:System.Type" /> of the target component.</param>
	/// <exception cref="T:System.ArgumentNullException">One or both of the parameters are <see langword="null" />.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static void AddProvider(TypeDescriptionProvider provider, Type type)
	{
	}

	/// <summary>Adds a type description provider for a single instance of a component.</summary>
	/// <param name="provider">The <see cref="T:System.ComponentModel.TypeDescriptionProvider" /> to add.</param>
	/// <param name="instance">An instance of the target component.</param>
	/// <exception cref="T:System.ArgumentNullException">One or both of the parameters are <see langword="null" />.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static void AddProvider(TypeDescriptionProvider provider, object instance)
	{
	}

	/// <summary>Adds a type description provider for a component class.</summary>
	/// <param name="provider">The <see cref="T:System.ComponentModel.TypeDescriptionProvider" /> to add.</param>
	/// <param name="type">The <see cref="T:System.Type" /> of the target component.</param>
	/// <exception cref="T:System.ArgumentNullException">One or both of the parameters are <see langword="null" />.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static void AddProviderTransparent(TypeDescriptionProvider provider, Type type)
	{
	}

	/// <summary>Adds a type description provider for a single instance of a component.</summary>
	/// <param name="provider">The <see cref="T:System.ComponentModel.TypeDescriptionProvider" /> to add.</param>
	/// <param name="instance">An instance of the target component.</param>
	/// <exception cref="T:System.ArgumentNullException">One or both of the parameters are <see langword="null" />.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static void AddProviderTransparent(TypeDescriptionProvider provider, object instance)
	{
	}

	private static void CheckDefaultProvider(Type type)
	{
	}

	/// <summary>Creates a primary-secondary association between two objects.</summary>
	/// <param name="primary">The primary <see cref="T:System.Object" />.</param>
	/// <param name="secondary">The secondary <see cref="T:System.Object" />.</param>
	/// <exception cref="T:System.ArgumentNullException">One or both of the parameters are <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="primary" /> is equal to <paramref name="secondary" />.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static void CreateAssociation(object primary, object secondary)
	{
	}

	/// <summary>Creates an instance of the designer associated with the specified component and of the specified type of designer.</summary>
	/// <param name="component">An <see cref="T:System.ComponentModel.IComponent" /> that specifies the component to associate with the designer.</param>
	/// <param name="designerBaseType">A <see cref="T:System.Type" /> that represents the type of designer to create.</param>
	/// <returns>An <see cref="T:System.ComponentModel.Design.IDesigner" /> that is an instance of the designer for the component, or <see langword="null" /> if no designer can be found.</returns>
	public static IDesigner CreateDesigner(IComponent component, Type designerBaseType)
	{
		return null;
	}

	/// <summary>Creates a new event descriptor that is identical to an existing event descriptor by dynamically generating descriptor information from a specified event on a type.</summary>
	/// <param name="componentType">The type of the component the event lives on.</param>
	/// <param name="name">The name of the event.</param>
	/// <param name="type">The type of the delegate that handles the event.</param>
	/// <param name="attributes">The attributes for this event.</param>
	/// <returns>An <see cref="T:System.ComponentModel.EventDescriptor" /> that is bound to a type.</returns>
	public static EventDescriptor CreateEvent(Type componentType, string name, Type type, params Attribute[] attributes)
	{
		return null;
	}

	/// <summary>Creates a new event descriptor that is identical to an existing event descriptor, when passed the existing <see cref="T:System.ComponentModel.EventDescriptor" />.</summary>
	/// <param name="componentType">The type of the component for which to create the new event.</param>
	/// <param name="oldEventDescriptor">The existing event information.</param>
	/// <param name="attributes">The new attributes.</param>
	/// <returns>A new <see cref="T:System.ComponentModel.EventDescriptor" /> that has merged the specified metadata attributes with the existing metadata attributes.</returns>
	public static EventDescriptor CreateEvent(Type componentType, EventDescriptor oldEventDescriptor, params Attribute[] attributes)
	{
		return null;
	}

	/// <summary>Creates an object that can substitute for another data type.</summary>
	/// <param name="provider">The service provider that provides a <see cref="T:System.ComponentModel.TypeDescriptionProvider" /> service. This parameter can be <see langword="null" />.</param>
	/// <param name="objectType">The <see cref="T:System.Type" /> of object to create.</param>
	/// <param name="argTypes">An optional array of parameter types to be passed to the object's constructor. This parameter can be <see langword="null" /> or an array of zero length.</param>
	/// <param name="args">An optional array of parameter values to pass to the object's constructor. If not <see langword="null" />, the number of elements must be the same as <paramref name="argTypes" />.</param>
	/// <returns>An instance of the substitute data type if an associated <see cref="T:System.ComponentModel.TypeDescriptionProvider" /> is found; otherwise, <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="objectType" /> is <see langword="null" />, or <paramref name="args" /> is <see langword="null" /> when <paramref name="argTypes" /> is not <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="argTypes" /> and <paramref name="args" /> have different number of elements.</exception>
	public static object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
	{
		return null;
	}

	/// <summary>Creates and dynamically binds a property descriptor to a type, using the specified property name, type, and attribute array.</summary>
	/// <param name="componentType">The <see cref="T:System.Type" /> of the component that the property is a member of.</param>
	/// <param name="name">The name of the property.</param>
	/// <param name="type">The <see cref="T:System.Type" /> of the property.</param>
	/// <param name="attributes">The new attributes for this property.</param>
	/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptor" /> that is bound to the specified type and that has the specified metadata attributes merged with the existing metadata attributes.</returns>
	public static PropertyDescriptor CreateProperty(Type componentType, string name, Type type, params Attribute[] attributes)
	{
		return null;
	}

	/// <summary>Creates a new property descriptor from an existing property descriptor, using the specified existing <see cref="T:System.ComponentModel.PropertyDescriptor" /> and attribute array.</summary>
	/// <param name="componentType">The <see cref="T:System.Type" /> of the component that the property is a member of.</param>
	/// <param name="oldPropertyDescriptor">The existing property descriptor.</param>
	/// <param name="attributes">The new attributes for this property.</param>
	/// <returns>A new <see cref="T:System.ComponentModel.PropertyDescriptor" /> that has the specified metadata attributes merged with the existing metadata attributes.</returns>
	public static PropertyDescriptor CreateProperty(Type componentType, PropertyDescriptor oldPropertyDescriptor, params Attribute[] attributes)
	{
		return null;
	}

	[Conditional("DEBUG")]
	private static void DebugValidate(Type type, AttributeCollection attributes, AttributeCollection debugAttributes)
	{
	}

	[Conditional("DEBUG")]
	private static void DebugValidate(AttributeCollection attributes, AttributeCollection debugAttributes)
	{
	}

	[Conditional("DEBUG")]
	private static void DebugValidate(AttributeCollection attributes, Type type)
	{
	}

	[Conditional("DEBUG")]
	private static void DebugValidate(AttributeCollection attributes, object instance, bool noCustomTypeDesc)
	{
	}

	[Conditional("DEBUG")]
	private static void DebugValidate(TypeConverter converter, Type type)
	{
	}

	[Conditional("DEBUG")]
	private static void DebugValidate(TypeConverter converter, object instance, bool noCustomTypeDesc)
	{
	}

	[Conditional("DEBUG")]
	private static void DebugValidate(EventDescriptorCollection events, Type type, Attribute[] attributes)
	{
	}

	[Conditional("DEBUG")]
	private static void DebugValidate(EventDescriptorCollection events, object instance, Attribute[] attributes, bool noCustomTypeDesc)
	{
	}

	[Conditional("DEBUG")]
	private static void DebugValidate(PropertyDescriptorCollection properties, Type type, Attribute[] attributes)
	{
	}

	[Conditional("DEBUG")]
	private static void DebugValidate(PropertyDescriptorCollection properties, object instance, Attribute[] attributes, bool noCustomTypeDesc)
	{
	}

	private static ArrayList FilterMembers(IList members, Attribute[] attributes)
	{
		return null;
	}

	/// <summary>Returns an instance of the type associated with the specified primary object.</summary>
	/// <param name="type">The <see cref="T:System.Type" /> of the target component.</param>
	/// <param name="primary">The primary object of the association.</param>
	/// <returns>An instance of the secondary type that has been associated with the primary object if an association exists; otherwise, <paramref name="primary" /> if no specified association exists.</returns>
	/// <exception cref="T:System.ArgumentNullException">One or both of the parameters are <see langword="null" />.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static object GetAssociation(Type type, object primary)
	{
		return null;
	}

	/// <summary>Returns a collection of attributes for the specified type of component.</summary>
	/// <param name="componentType">The <see cref="T:System.Type" /> of the target component.</param>
	/// <returns>An <see cref="T:System.ComponentModel.AttributeCollection" /> with the attributes for the type of the component. If the component is <see langword="null" />, this method returns an empty collection.</returns>
	public static AttributeCollection GetAttributes(Type componentType)
	{
		return null;
	}

	/// <summary>Returns the collection of attributes for the specified component.</summary>
	/// <param name="component">The component for which you want to get attributes.</param>
	/// <returns>An <see cref="T:System.ComponentModel.AttributeCollection" /> containing the attributes for the component. If <paramref name="component" /> is <see langword="null" />, this method returns an empty collection.</returns>
	public static AttributeCollection GetAttributes(object component)
	{
		return null;
	}

	/// <summary>Returns a collection of attributes for the specified component and a Boolean indicating that a custom type descriptor has been created.</summary>
	/// <param name="component">The component for which you want to get attributes.</param>
	/// <param name="noCustomTypeDesc">
	///   <see langword="true" /> to use a baseline set of attributes from the custom type descriptor if <paramref name="component" /> is of type <see cref="T:System.ComponentModel.ICustomTypeDescriptor" />; otherwise, <see langword="false" />.</param>
	/// <returns>An <see cref="T:System.ComponentModel.AttributeCollection" /> with the attributes for the component. If the component is <see langword="null" />, this method returns an empty collection.</returns>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static AttributeCollection GetAttributes(object component, bool noCustomTypeDesc)
	{
		return null;
	}

	internal static IDictionary GetCache(object instance)
	{
		return null;
	}

	/// <summary>Returns the name of the class for the specified component using the default type descriptor.</summary>
	/// <param name="component">The <see cref="T:System.Object" /> for which you want the class name.</param>
	/// <returns>A <see cref="T:System.String" /> containing the name of the class for the specified component.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="component" /> is <see langword="null" />.</exception>
	public static string GetClassName(object component)
	{
		return null;
	}

	/// <summary>Returns the name of the class for the specified component using a custom type descriptor.</summary>
	/// <param name="component">The <see cref="T:System.Object" /> for which you want the class name.</param>
	/// <param name="noCustomTypeDesc">
	///   <see langword="true" /> to consider custom type description information; otherwise, <see langword="false" />.</param>
	/// <returns>A <see cref="T:System.String" /> containing the name of the class for the specified component.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="component" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="component" /> is a cross-process remoted object.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static string GetClassName(object component, bool noCustomTypeDesc)
	{
		return null;
	}

	/// <summary>Returns the name of the class for the specified type.</summary>
	/// <param name="componentType">The <see cref="T:System.Type" /> of the target component.</param>
	/// <returns>A <see cref="T:System.String" /> containing the name of the class for the specified component type.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="componentType" /> is <see langword="null" />.</exception>
	public static string GetClassName(Type componentType)
	{
		return null;
	}

	/// <summary>Returns the name of the specified component using the default type descriptor.</summary>
	/// <param name="component">The <see cref="T:System.Object" /> for which you want the class name.</param>
	/// <returns>A <see cref="T:System.String" /> containing the name of the specified component, or <see langword="null" /> if there is no component name.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="component" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="component" /> is a cross-process remoted object.</exception>
	public static string GetComponentName(object component)
	{
		return null;
	}

	/// <summary>Returns the name of the specified component using a custom type descriptor.</summary>
	/// <param name="component">The <see cref="T:System.Object" /> for which you want the class name.</param>
	/// <param name="noCustomTypeDesc">
	///   <see langword="true" /> to consider custom type description information; otherwise, <see langword="false" />.</param>
	/// <returns>The name of the class for the specified component, or <see langword="null" /> if there is no component name.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="component" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="component" /> is a cross-process remoted object.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static string GetComponentName(object component, bool noCustomTypeDesc)
	{
		return null;
	}

	/// <summary>Returns a type converter for the type of the specified component.</summary>
	/// <param name="component">A component to get the converter for.</param>
	/// <returns>A <see cref="T:System.ComponentModel.TypeConverter" /> for the specified component.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="component" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="component" /> is a cross-process remoted object.</exception>
	public static TypeConverter GetConverter(object component)
	{
		return null;
	}

	/// <summary>Returns a type converter for the type of the specified component with a custom type descriptor.</summary>
	/// <param name="component">A component to get the converter for.</param>
	/// <param name="noCustomTypeDesc">
	///   <see langword="true" /> to consider custom type description information; otherwise, <see langword="false" />.</param>
	/// <returns>A <see cref="T:System.ComponentModel.TypeConverter" /> for the specified component.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="component" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="component" /> is a cross-process remoted object.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static TypeConverter GetConverter(object component, bool noCustomTypeDesc)
	{
		return null;
	}

	/// <summary>Returns a type converter for the specified type.</summary>
	/// <param name="type">The <see cref="T:System.Type" /> of the target component.</param>
	/// <returns>A <see cref="T:System.ComponentModel.TypeConverter" /> for the specified type.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="type" /> is <see langword="null" />.</exception>
	public static TypeConverter GetConverter(Type type)
	{
		return null;
	}

	private static object ConvertFromInvariantString(Type type, string stringValue)
	{
		return null;
	}

	/// <summary>Returns the default event for the specified type of component.</summary>
	/// <param name="componentType">The <see cref="T:System.Type" /> of the target component.</param>
	/// <returns>An <see cref="T:System.ComponentModel.EventDescriptor" /> with the default event, or <see langword="null" /> if there are no events.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="componentType" /> is <see langword="null" />.</exception>
	public static EventDescriptor GetDefaultEvent(Type componentType)
	{
		return null;
	}

	/// <summary>Returns the default event for the specified component.</summary>
	/// <param name="component">The component to get the event for.</param>
	/// <returns>An <see cref="T:System.ComponentModel.EventDescriptor" /> with the default event, or <see langword="null" /> if there are no events.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="component" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="component" /> is a cross-process remoted object.</exception>
	public static EventDescriptor GetDefaultEvent(object component)
	{
		return null;
	}

	/// <summary>Returns the default event for a component with a custom type descriptor.</summary>
	/// <param name="component">The component to get the event for.</param>
	/// <param name="noCustomTypeDesc">
	///   <see langword="true" /> to consider custom type description information; otherwise, <see langword="false" />.</param>
	/// <returns>An <see cref="T:System.ComponentModel.EventDescriptor" /> with the default event, or <see langword="null" /> if there are no events.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="component" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="component" /> is a cross-process remoted object.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static EventDescriptor GetDefaultEvent(object component, bool noCustomTypeDesc)
	{
		return null;
	}

	/// <summary>Returns the default property for the specified type of component.</summary>
	/// <param name="componentType">A <see cref="T:System.Type" /> that represents the class to get the property for.</param>
	/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptor" /> with the default property, or <see langword="null" /> if there are no properties.</returns>
	public static PropertyDescriptor GetDefaultProperty(Type componentType)
	{
		return null;
	}

	/// <summary>Returns the default property for the specified component.</summary>
	/// <param name="component">The component to get the default property for.</param>
	/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptor" /> with the default property, or <see langword="null" /> if there are no properties.</returns>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="component" /> is a cross-process remoted object.</exception>
	public static PropertyDescriptor GetDefaultProperty(object component)
	{
		return null;
	}

	/// <summary>Returns the default property for the specified component with a custom type descriptor.</summary>
	/// <param name="component">The component to get the default property for.</param>
	/// <param name="noCustomTypeDesc">
	///   <see langword="true" /> to consider custom type description information; otherwise, <see langword="false" />.</param>
	/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptor" /> with the default property, or <see langword="null" /> if there are no properties.</returns>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="component" /> is a cross-process remoted object.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static PropertyDescriptor GetDefaultProperty(object component, bool noCustomTypeDesc)
	{
		return null;
	}

	internal static ICustomTypeDescriptor GetDescriptor(Type type, string typeName)
	{
		return null;
	}

	internal static ICustomTypeDescriptor GetDescriptor(object component, bool noCustomTypeDesc)
	{
		return null;
	}

	internal static ICustomTypeDescriptor GetExtendedDescriptor(object component)
	{
		return null;
	}

	/// <summary>Gets an editor with the specified base type for the specified component.</summary>
	/// <param name="component">The component to get the editor for.</param>
	/// <param name="editorBaseType">A <see cref="T:System.Type" /> that represents the base type of the editor you want to find.</param>
	/// <returns>An instance of the editor that can be cast to the specified editor type, or <see langword="null" /> if no editor of the requested type can be found.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="component" /> or <paramref name="editorBaseType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="component" /> is a cross-process remoted object.</exception>
	public static object GetEditor(object component, Type editorBaseType)
	{
		return null;
	}

	/// <summary>Returns an editor with the specified base type and with a custom type descriptor for the specified component.</summary>
	/// <param name="component">The component to get the editor for.</param>
	/// <param name="editorBaseType">A <see cref="T:System.Type" /> that represents the base type of the editor you want to find.</param>
	/// <param name="noCustomTypeDesc">A flag indicating whether custom type description information should be considered.</param>
	/// <returns>An instance of the editor that can be cast to the specified editor type, or <see langword="null" /> if no editor of the requested type can be found.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="component" /> or <paramref name="editorBaseType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="component" /> is a cross-process remoted object.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static object GetEditor(object component, Type editorBaseType, bool noCustomTypeDesc)
	{
		return null;
	}

	/// <summary>Returns an editor with the specified base type for the specified type.</summary>
	/// <param name="type">The <see cref="T:System.Type" /> of the target component.</param>
	/// <param name="editorBaseType">A <see cref="T:System.Type" /> that represents the base type of the editor you are trying to find.</param>
	/// <returns>An instance of the editor object that can be cast to the given base type, or <see langword="null" /> if no editor of the requested type can be found.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="type" /> or <paramref name="editorBaseType" /> is <see langword="null" />.</exception>
	public static object GetEditor(Type type, Type editorBaseType)
	{
		return null;
	}

	/// <summary>Returns the collection of events for a specified type of component.</summary>
	/// <param name="componentType">The <see cref="T:System.Type" /> of the target component.</param>
	/// <returns>An <see cref="T:System.ComponentModel.EventDescriptorCollection" /> with the events for this component.</returns>
	public static EventDescriptorCollection GetEvents(Type componentType)
	{
		return null;
	}

	/// <summary>Returns the collection of events for a specified type of component using a specified array of attributes as a filter.</summary>
	/// <param name="componentType">The <see cref="T:System.Type" /> of the target component.</param>
	/// <param name="attributes">An array of type <see cref="T:System.Attribute" /> that you can use as a filter.</param>
	/// <returns>An <see cref="T:System.ComponentModel.EventDescriptorCollection" /> with the events that match the specified attributes for this component.</returns>
	public static EventDescriptorCollection GetEvents(Type componentType, Attribute[] attributes)
	{
		return null;
	}

	/// <summary>Returns the collection of events for the specified component.</summary>
	/// <param name="component">A component to get the events for.</param>
	/// <returns>An <see cref="T:System.ComponentModel.EventDescriptorCollection" /> with the events for this component.</returns>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="component" /> is a cross-process remoted object.</exception>
	public static EventDescriptorCollection GetEvents(object component)
	{
		return null;
	}

	/// <summary>Returns the collection of events for a specified component with a custom type descriptor.</summary>
	/// <param name="component">A component to get the events for.</param>
	/// <param name="noCustomTypeDesc">
	///   <see langword="true" /> to consider custom type description information; otherwise, <see langword="false" />.</param>
	/// <returns>An <see cref="T:System.ComponentModel.EventDescriptorCollection" /> with the events for this component.</returns>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="component" /> is a cross-process remoted object.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static EventDescriptorCollection GetEvents(object component, bool noCustomTypeDesc)
	{
		return null;
	}

	/// <summary>Returns the collection of events for a specified component using a specified array of attributes as a filter.</summary>
	/// <param name="component">A component to get the events for.</param>
	/// <param name="attributes">An array of type <see cref="T:System.Attribute" /> that you can use as a filter.</param>
	/// <returns>An <see cref="T:System.ComponentModel.EventDescriptorCollection" /> with the events that match the specified attributes for this component.</returns>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="component" /> is a cross-process remoted object.</exception>
	public static EventDescriptorCollection GetEvents(object component, Attribute[] attributes)
	{
		return null;
	}

	/// <summary>Returns the collection of events for a specified component using a specified array of attributes as a filter and using a custom type descriptor.</summary>
	/// <param name="component">A component to get the events for.</param>
	/// <param name="attributes">An array of type <see cref="T:System.Attribute" /> to use as a filter.</param>
	/// <param name="noCustomTypeDesc">
	///   <see langword="true" /> to consider custom type description information; otherwise, <see langword="false" />.</param>
	/// <returns>An <see cref="T:System.ComponentModel.EventDescriptorCollection" /> with the events that match the specified attributes for this component.</returns>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="component" /> is a cross-process remoted object.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static EventDescriptorCollection GetEvents(object component, Attribute[] attributes, bool noCustomTypeDesc)
	{
		return null;
	}

	private static string GetExtenderCollisionSuffix(MemberDescriptor member)
	{
		return null;
	}

	/// <summary>Returns the fully qualified name of the component.</summary>
	/// <param name="component">The <see cref="T:System.ComponentModel.Component" /> to find the name for.</param>
	/// <returns>The fully qualified name of the specified component, or <see langword="null" /> if the component has no name.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="component" /> is <see langword="null" />.</exception>
	public static string GetFullComponentName(object component)
	{
		return null;
	}

	private static Type GetNodeForBaseType(Type searchType)
	{
		return null;
	}

	/// <summary>Returns the collection of properties for a specified type of component.</summary>
	/// <param name="componentType">A <see cref="T:System.Type" /> that represents the component to get properties for.</param>
	/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> with the properties for a specified type of component.</returns>
	public static PropertyDescriptorCollection GetProperties(Type componentType)
	{
		return null;
	}

	/// <summary>Returns the collection of properties for a specified type of component using a specified array of attributes as a filter.</summary>
	/// <param name="componentType">The <see cref="T:System.Type" /> of the target component.</param>
	/// <param name="attributes">An array of type <see cref="T:System.Attribute" /> to use as a filter.</param>
	/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> with the properties that match the specified attributes for this type of component.</returns>
	public static PropertyDescriptorCollection GetProperties(Type componentType, Attribute[] attributes)
	{
		return null;
	}

	/// <summary>Returns the collection of properties for a specified component.</summary>
	/// <param name="component">A component to get the properties for.</param>
	/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> with the properties for the specified component.</returns>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="component" /> is a cross-process remoted object.</exception>
	public static PropertyDescriptorCollection GetProperties(object component)
	{
		return null;
	}

	/// <summary>Returns the collection of properties for a specified component using the default type descriptor.</summary>
	/// <param name="component">A component to get the properties for.</param>
	/// <param name="noCustomTypeDesc">
	///   <see langword="true" /> to not consider custom type description information; otherwise, <see langword="false" />.</param>
	/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> with the properties for a specified component.</returns>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="component" /> is a cross-process remoted object.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc)
	{
		return null;
	}

	/// <summary>Returns the collection of properties for a specified component using a specified array of attributes as a filter.</summary>
	/// <param name="component">A component to get the properties for.</param>
	/// <param name="attributes">An array of type <see cref="T:System.Attribute" /> to use as a filter.</param>
	/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> with the properties that match the specified attributes for the specified component.</returns>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="component" /> is a cross-process remoted object.</exception>
	public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes)
	{
		return null;
	}

	/// <summary>Returns the collection of properties for a specified component using a specified array of attributes as a filter and using a custom type descriptor.</summary>
	/// <param name="component">A component to get the properties for.</param>
	/// <param name="attributes">An array of type <see cref="T:System.Attribute" /> to use as a filter.</param>
	/// <param name="noCustomTypeDesc">
	///   <see langword="true" /> to consider custom type description information; otherwise, <see langword="false" />.</param>
	/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> with the events that match the specified attributes for the specified component.</returns>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="component" /> is a cross-process remoted object.</exception>
	public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes, bool noCustomTypeDesc)
	{
		return null;
	}

	private static PropertyDescriptorCollection GetPropertiesImpl(object component, Attribute[] attributes, bool noCustomTypeDesc, bool noAttributes)
	{
		return null;
	}

	/// <summary>Returns the type description provider for the specified type.</summary>
	/// <param name="type">The <see cref="T:System.Type" /> of the target component.</param>
	/// <returns>A <see cref="T:System.ComponentModel.TypeDescriptionProvider" /> associated with the specified type.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="type" /> is <see langword="null" />.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static TypeDescriptionProvider GetProvider(Type type)
	{
		return null;
	}

	/// <summary>Returns the type description provider for the specified component.</summary>
	/// <param name="instance">An instance of the target component.</param>
	/// <returns>A <see cref="T:System.ComponentModel.TypeDescriptionProvider" /> associated with the specified component.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="instance" /> is <see langword="null" />.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static TypeDescriptionProvider GetProvider(object instance)
	{
		return null;
	}

	internal static TypeDescriptionProvider GetProviderRecursive(Type type)
	{
		return null;
	}

	/// <summary>Returns a <see cref="T:System.Type" /> that can be used to perform reflection, given a class type.</summary>
	/// <param name="type">The <see cref="T:System.Type" /> of the target component.</param>
	/// <returns>A <see cref="T:System.Type" /> of the specified class.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="type" /> is <see langword="null" />.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static Type GetReflectionType(Type type)
	{
		return null;
	}

	/// <summary>Returns a <see cref="T:System.Type" /> that can be used to perform reflection, given an object.</summary>
	/// <param name="instance">An instance of the target component.</param>
	/// <returns>A <see cref="T:System.Type" /> for the specified object.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="instance" /> is <see langword="null" />.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static Type GetReflectionType(object instance)
	{
		return null;
	}

	private static TypeDescriptionNode NodeFor(Type type)
	{
		return null;
	}

	private static TypeDescriptionNode NodeFor(Type type, bool createDelegator)
	{
		return null;
	}

	private static TypeDescriptionNode NodeFor(object instance)
	{
		return null;
	}

	private static TypeDescriptionNode NodeFor(object instance, bool createDelegator)
	{
		return null;
	}

	private static void NodeRemove(object key, TypeDescriptionProvider provider)
	{
	}

	private static ICollection PipelineAttributeFilter(int pipelineType, ICollection members, Attribute[] filter, object instance, IDictionary cache)
	{
		return null;
	}

	private static ICollection PipelineFilter(int pipelineType, ICollection members, object instance, IDictionary cache)
	{
		return null;
	}

	private static ICollection PipelineInitialize(int pipelineType, ICollection members, IDictionary cache)
	{
		return null;
	}

	private static ICollection PipelineMerge(int pipelineType, ICollection primary, ICollection secondary, object instance, IDictionary cache)
	{
		return null;
	}

	private static void RaiseRefresh(object component)
	{
	}

	private static void RaiseRefresh(Type type)
	{
	}

	/// <summary>Clears the properties and events for the specified component from the cache.</summary>
	/// <param name="component">A component for which the properties or events have changed.</param>
	public static void Refresh(object component)
	{
	}

	private static void Refresh(object component, bool refreshReflectionProvider)
	{
	}

	/// <summary>Clears the properties and events for the specified type of component from the cache.</summary>
	/// <param name="type">The <see cref="T:System.Type" /> of the target component.</param>
	public static void Refresh(Type type)
	{
	}

	/// <summary>Clears the properties and events for the specified module from the cache.</summary>
	/// <param name="module">The <see cref="T:System.Reflection.Module" /> that represents the module to refresh. Each <see cref="T:System.Type" /> in this module will be refreshed.</param>
	public static void Refresh(Module module)
	{
	}

	/// <summary>Clears the properties and events for the specified assembly from the cache.</summary>
	/// <param name="assembly">The <see cref="T:System.Reflection.Assembly" /> that represents the assembly to refresh. Each <see cref="T:System.Type" /> in this assembly will be refreshed.</param>
	public static void Refresh(Assembly assembly)
	{
	}

	/// <summary>Removes an association between two objects.</summary>
	/// <param name="primary">The primary <see cref="T:System.Object" />.</param>
	/// <param name="secondary">The secondary <see cref="T:System.Object" />.</param>
	/// <exception cref="T:System.ArgumentNullException">One or both of the parameters are <see langword="null" />.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static void RemoveAssociation(object primary, object secondary)
	{
	}

	/// <summary>Removes all associations for a primary object.</summary>
	/// <param name="primary">The primary <see cref="T:System.Object" /> in an association.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="primary" /> is <see langword="null" />.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static void RemoveAssociations(object primary)
	{
	}

	/// <summary>Removes a previously added type description provider that is associated with the specified type.</summary>
	/// <param name="provider">The <see cref="T:System.ComponentModel.TypeDescriptionProvider" /> to remove.</param>
	/// <param name="type">The <see cref="T:System.Type" /> of the target component.</param>
	/// <exception cref="T:System.ArgumentNullException">One or both of the parameters are <see langword="null" />.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static void RemoveProvider(TypeDescriptionProvider provider, Type type)
	{
	}

	/// <summary>Removes a previously added type description provider that is associated with the specified object.</summary>
	/// <param name="provider">The <see cref="T:System.ComponentModel.TypeDescriptionProvider" /> to remove.</param>
	/// <param name="instance">An instance of the target component.</param>
	/// <exception cref="T:System.ArgumentNullException">One or both of the parameters are <see langword="null" />.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static void RemoveProvider(TypeDescriptionProvider provider, object instance)
	{
	}

	/// <summary>Removes a previously added type description provider that is associated with the specified type.</summary>
	/// <param name="provider">The <see cref="T:System.ComponentModel.TypeDescriptionProvider" /> to remove.</param>
	/// <param name="type">The <see cref="T:System.Type" /> of the target component.</param>
	/// <exception cref="T:System.ArgumentNullException">One or both of the parameters are <see langword="null" />.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static void RemoveProviderTransparent(TypeDescriptionProvider provider, Type type)
	{
	}

	/// <summary>Removes a previously added type description provider that is associated with the specified object.</summary>
	/// <param name="provider">The <see cref="T:System.ComponentModel.TypeDescriptionProvider" /> to remove.</param>
	/// <param name="instance">An instance of the target component.</param>
	/// <exception cref="T:System.ArgumentNullException">One or both of the parameters are <see langword="null" />.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static void RemoveProviderTransparent(TypeDescriptionProvider provider, object instance)
	{
	}

	private static bool ShouldHideMember(MemberDescriptor member, Attribute attribute)
	{
		return false;
	}

	/// <summary>Sorts descriptors using the name of the descriptor.</summary>
	/// <param name="infos">An <see cref="T:System.Collections.IList" /> that contains the descriptors to sort.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="infos" /> is <see langword="null" />.</exception>
	public static void SortDescriptorArray(IList infos)
	{
	}

	[Conditional("DEBUG")]
	internal static void Trace(string message, params object[] args)
	{
	}
}
