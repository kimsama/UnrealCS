#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FEventTrackKey
	{
		[FieldOffset(0)]
		public float Time;
		[FieldOffset(8)]
		public FName EventName;
		
	}
	
}
#endif
#endif
