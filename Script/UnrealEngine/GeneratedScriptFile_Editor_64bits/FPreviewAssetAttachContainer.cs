#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Component which deals with attaching assets</summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FPreviewAssetAttachContainer
	{
		public TStructArray<FPreviewAttachedObjectPair> AttachedObjects
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FPreviewAttachedObjectPair>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+0, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+0, false);}}}
			
		}
		
	}
	
}
#endif
#endif
