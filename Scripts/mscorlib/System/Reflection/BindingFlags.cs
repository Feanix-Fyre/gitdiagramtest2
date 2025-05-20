namespace System.Reflection;

/// <summary>Specifies flags that control binding and the way in which the search for members and types is conducted by reflection.</summary>
[Flags]
public enum BindingFlags
{
	/// <summary>Specifies that no binding flags are defined.</summary>
	Default = 0,
	/// <summary>Specifies that the case of the member name should not be considered when binding.</summary>
	IgnoreCase = 1,
	/// <summary>Specifies that only members declared at the level of the supplied type's hierarchy should be considered. Inherited members are not considered.</summary>
	DeclaredOnly = 2,
	/// <summary>Specifies that instance members are to be included in the search.</summary>
	Instance = 4,
	/// <summary>Specifies that static members are to be included in the search.</summary>
	Static = 8,
	/// <summary>Specifies that public members are to be included in the search.</summary>
	Public = 0x10,
	/// <summary>Specifies that non-public members are to be included in the search.</summary>
	NonPublic = 0x20,
	/// <summary>Specifies that public and protected static members up the hierarchy should be returned. Private static members in inherited classes are not returned. Static members include fields, methods, events, and properties. Nested types are not returned.</summary>
	FlattenHierarchy = 0x40,
	/// <summary>Specifies that a method is to be invoked. This must not be a constructor or a type initializer.  
	///  This flag is passed to an <see langword="InvokeMember" /> method to invoke a method.</summary>
	InvokeMethod = 0x100,
	/// <summary>Specifies that reflection should create an instance of the specified type. Calls the constructor that matches the given arguments. The supplied member name is ignored. If the type of lookup is not specified, (Instance | Public) will apply. It is not possible to call a type initializer.  
	///  This flag is passed to an <see langword="InvokeMember" /> method to invoke a constructor.</summary>
	CreateInstance = 0x200,
	/// <summary>Specifies that the value of the specified field should be returned.  
	///  This flag is passed to an <see langword="InvokeMember" /> method to get a field value.</summary>
	GetField = 0x400,
	/// <summary>Specifies that the value of the specified field should be set.  
	///  This flag is passed to an <see langword="InvokeMember" /> method to set a field value.</summary>
	SetField = 0x800,
	/// <summary>Specifies that the value of the specified property should be returned.  
	///  This flag is passed to an <see langword="InvokeMember" /> method to invoke a property getter.</summary>
	GetProperty = 0x1000,
	/// <summary>Specifies that the value of the specified property should be set. For COM properties, specifying this binding flag is equivalent to specifying <see langword="PutDispProperty" /> and <see langword="PutRefDispProperty" />.  
	///  This flag is passed to an <see langword="InvokeMember" /> method to invoke a property setter.</summary>
	SetProperty = 0x2000,
	/// <summary>Specifies that the <see langword="PROPPUT" /> member on a COM object should be invoked. <see langword="PROPPUT" /> specifies a property-setting function that uses a value. Use <see langword="PutDispProperty" /> if a property has both <see langword="PROPPUT" /> and <see langword="PROPPUTREF" /> and you need to distinguish which one is called.</summary>
	PutDispProperty = 0x4000,
	/// <summary>Specifies that the <see langword="PROPPUTREF" /> member on a COM object should be invoked. <see langword="PROPPUTREF" /> specifies a property-setting function that uses a reference instead of a value. Use <see langword="PutRefDispProperty" /> if a property has both <see langword="PROPPUT" /> and <see langword="PROPPUTREF" /> and you need to distinguish which one is called.</summary>
	PutRefDispProperty = 0x8000,
	/// <summary>Specifies that types of the supplied arguments must exactly match the types of the corresponding formal parameters. Reflection throws an exception if the caller supplies a non-null <see langword="Binder" /> object, since that implies that the caller is supplying <see langword="BindToXXX" /> implementations that will pick the appropriate method.</summary>
	ExactBinding = 0x10000,
	/// <summary>Not implemented.</summary>
	SuppressChangeType = 0x20000,
	/// <summary>Returns the set of members whose parameter count matches the number of supplied arguments. This binding flag is used for methods with parameters that have default values and methods with variable arguments (varargs). This flag should only be used with <see cref="M:System.Type.InvokeMember(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object,System.Object[],System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[])" />.</summary>
	OptionalParamBinding = 0x40000,
	/// <summary>Used in COM interop to specify that the return value of the member can be ignored.</summary>
	IgnoreReturn = 0x1000000,
	DoNotWrapExceptions = 0x2000000
}
