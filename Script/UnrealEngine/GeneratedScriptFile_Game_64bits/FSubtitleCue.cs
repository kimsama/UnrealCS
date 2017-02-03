#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FSubtitleCue
	{
		[FieldOffset(0)]
		public FText Text;
		[FieldOffset(24)]
		public float Time;
		
	}
	
}
#endif
#endif
