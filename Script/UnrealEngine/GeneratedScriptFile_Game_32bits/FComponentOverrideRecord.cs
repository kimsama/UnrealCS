#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=92)]
	public partial struct FComponentOverrideRecord
	{
		[FieldOffset(8)]
		public FComponentKey ComponentKey;
		[FieldOffset(36)]
		public FBlueprintCookedComponentInstancingData CookedComponentInstancingData;
		
	}
	
}
#endif
#endif
