#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=4)]
	public partial struct FTrackToSkeletonMap
	{
		[FieldOffset(0)]
		public int BoneTreeIndex;
		
	}
	
}
#endif
#endif
