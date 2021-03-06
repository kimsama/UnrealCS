#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A packed normal.
	/// The full C++ class is located here: Engine\Source\Runtime\RenderCore\Public\PackedNormal.h
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=4)]
	public partial struct FPackedNormal
	{
		[FieldOffset(0)]
		public byte X;
		[FieldOffset(1)]
		public byte Y;
		[FieldOffset(2)]
		public byte Z;
		[FieldOffset(3)]
		public byte W;
		
	}
	
}
#endif
#endif
