#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FKey
	{
		[FieldOffset(0)]
		public FName KeyName;
		
	}
	
}
#endif
#endif
