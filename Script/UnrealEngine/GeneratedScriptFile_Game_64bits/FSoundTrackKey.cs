#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FSoundTrackKey
	{
		[FieldOffset(0)]
		public float Time;
		[FieldOffset(4)]
		public float Volume;
		[FieldOffset(8)]
		public float Pitch;
		
	}
	
}
#endif
#endif
