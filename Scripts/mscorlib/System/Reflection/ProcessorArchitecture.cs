namespace System.Reflection;

/// <summary>Identifies the processor and bits-per-word of the platform targeted by an executable.</summary>
public enum ProcessorArchitecture
{
	/// <summary>An unknown or unspecified combination of processor and bits-per-word.</summary>
	None = 0,
	/// <summary>Neutral with respect to processor and bits-per-word.</summary>
	MSIL = 1,
	/// <summary>A 32-bit Intel processor, either native or in the Windows on Windows environment on a 64-bit platform (WOW64).</summary>
	X86 = 2,
	/// <summary>A 64-bit Intel Itanium processor only.</summary>
	IA64 = 3,
	/// <summary>A 64-bit processor based on the x64 architecture.</summary>
	Amd64 = 4,
	/// <summary>An ARM processor.</summary>
	Arm = 5
}
