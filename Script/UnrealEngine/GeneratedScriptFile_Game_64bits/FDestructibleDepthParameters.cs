#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=1)]
	public partial struct FDestructibleDepthParameters
	{
		[FieldOffset(0)]
		public EImpactDamageOverride ImpactDamageOverride;
		
	}
	
}
#endif
#endif
