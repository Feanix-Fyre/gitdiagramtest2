using System.Configuration.Assemblies;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Mono;

namespace System.Reflection;

/// <summary>Describes an assembly's unique identity in full.</summary>
[Serializable]
[StructLayout((LayoutKind)0)]
[ClassInterface(ClassInterfaceType.None)]
[ComDefaultInterface(typeof(_AssemblyName))]
[ComVisible(true)]
public sealed class AssemblyName : ICloneable, ISerializable, IDeserializationCallback, _AssemblyName
{
	private string name;

	private string codebase;

	private int major;

	private int minor;

	private int build;

	private int revision;

	private CultureInfo cultureinfo;

	private AssemblyNameFlags flags;

	private AssemblyHashAlgorithm hashalg;

	private StrongNameKeyPair keypair;

	private byte[] publicKey;

	private byte[] keyToken;

	private AssemblyVersionCompatibility versioncompat;

	private Version version;

	private ProcessorArchitecture processor_architecture;

	private AssemblyContentType contentType;

	/// <summary>Gets or sets the simple name of the assembly. This is usually, but not necessarily, the file name of the manifest file of the assembly, minus its extension.</summary>
	/// <returns>The simple name of the assembly.</returns>
	public string Name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the location of the assembly as a URL.</summary>
	/// <returns>A string that is the URL location of the assembly.</returns>
	public string CodeBase => null;

	/// <summary>Gets or sets the culture supported by the assembly.</summary>
	/// <returns>An object that represents the culture supported by the assembly.</returns>
	public CultureInfo CultureInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the attributes of the assembly.</summary>
	/// <returns>A value that represents the attributes of the assembly.</returns>
	public AssemblyNameFlags Flags
	{
		get
		{
			return default(AssemblyNameFlags);
		}
		set
		{
		}
	}

	/// <summary>Gets the full name of the assembly, also known as the display name.</summary>
	/// <returns>A string that is the full name of the assembly, also known as the display name.</returns>
	public string FullName => null;

	/// <summary>Gets or sets the major, minor, build, and revision numbers of the assembly.</summary>
	/// <returns>An object that represents the major, minor, build, and revision numbers of the assembly.</returns>
	public Version Version
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private bool IsPublicKeyValid => false;

	/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyName" /> class.</summary>
	public AssemblyName()
	{
	}

	private static bool ParseAssemblyName(IntPtr name, out MonoAssemblyName aname, out bool is_version_definited, out bool is_token_defined)
	{
		aname = default(MonoAssemblyName);
		is_version_definited = default(bool);
		is_token_defined = default(bool);
		return false;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyName" /> class with the specified display name.</summary>
	/// <param name="assemblyName">The display name of the assembly, as returned by the <see cref="P:System.Reflection.AssemblyName.FullName" /> property.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="assemblyName" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="assemblyName" /> is a zero length string.</exception>
	/// <exception cref="T:System.IO.FileLoadException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.IO.IOException" />, instead.  
	///
	///
	///
	///
	///  The referenced assembly could not be found, or could not be loaded.</exception>
	public AssemblyName(string assemblyName)
	{
	}

	internal AssemblyName(SerializationInfo si, StreamingContext sc)
	{
	}

	/// <summary>Returns the full name of the assembly, also known as the display name.</summary>
	/// <returns>The full name of the assembly, or the class name if the full name cannot be determined.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Gets the public key of the assembly.</summary>
	/// <returns>A byte array that contains the public key of the assembly.</returns>
	/// <exception cref="T:System.Security.SecurityException">A public key was provided (for example, by using the <see cref="M:System.Reflection.AssemblyName.SetPublicKey(System.Byte[])" /> method), but no public key token was provided.</exception>
	public byte[] GetPublicKey()
	{
		return null;
	}

	/// <summary>Gets the public key token, which is the last 8 bytes of the SHA-1 hash of the public key under which the application or assembly is signed.</summary>
	/// <returns>A byte array that contains the public key token.</returns>
	public byte[] GetPublicKeyToken()
	{
		return null;
	}

	private byte[] InternalGetPublicKeyToken()
	{
		return null;
	}

	private unsafe static void get_public_token(byte* token, byte* pubkey, int len)
	{
	}

	private byte[] ComputePublicKeyToken()
	{
		return null;
	}

	/// <summary>Sets the public key identifying the assembly.</summary>
	/// <param name="publicKey">A byte array containing the public key of the assembly.</param>
	public void SetPublicKey(byte[] publicKey)
	{
	}

	/// <summary>Gets serialization information with all the data needed to recreate an instance of this <see langword="AssemblyName" />.</summary>
	/// <param name="info">The object to be populated with serialization information.</param>
	/// <param name="context">The destination context of the serialization.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="info" /> is <see langword="null" />.</exception>
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Makes a copy of this <see cref="T:System.Reflection.AssemblyName" /> object.</summary>
	/// <returns>An object that is a copy of this <see cref="T:System.Reflection.AssemblyName" /> object.</returns>
	public object Clone()
	{
		return null;
	}

	/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and is called back by the deserialization event when deserialization is complete.</summary>
	/// <param name="sender">The source of the deserialization event.</param>
	public void OnDeserialization(object sender)
	{
	}

	private unsafe static MonoAssemblyName* GetNativeName(IntPtr assembly_ptr)
	{
		return null;
	}

	internal unsafe void FillName(MonoAssemblyName* native, string codeBase, bool addVersion, bool addPublickey, bool defaultToken, bool assemblyRef)
	{
	}

	internal static AssemblyName Create(Assembly assembly, bool fillCodebase)
	{
		return null;
	}
}
