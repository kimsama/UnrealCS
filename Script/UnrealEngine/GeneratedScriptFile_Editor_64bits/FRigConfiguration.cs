#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FRigConfiguration
	{
		/// <summary>@todo in the future we can make this to be run-time data</summary>
		public TStructArray<FNameMapping> BoneMappingTable
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FNameMapping>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+8, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+8, false);}}}
			
		}
		
	}
	
}
#endif
#endif
