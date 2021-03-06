#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A simple collection of skeletal meshes used for in-editor preview</summary>
	public partial class UPreviewMeshCollection
	{
		static readonly int Skeleton__Offset;
		public USkeleton Skeleton
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Skeleton__Offset); if (v == IntPtr.Zero)return null; USkeleton retValue = new USkeleton(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Skeleton__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Skeleton__Offset, value._this.Get()); }
			
		}
		
		static readonly int SkeletalMeshes__Offset;
		/// <summary>The skeletal meshes that this collection contains</summary>
		public TStructArray<FPreviewMeshCollectionEntry> SkeletalMeshes
		{
			get{ CheckIsValid();return new TStructArray<FPreviewMeshCollectionEntry>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SkeletalMeshes__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SkeletalMeshes__Offset, false);}
			
		}
		
		static UPreviewMeshCollection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PreviewMeshCollection");
			Skeleton__Offset=GetPropertyOffset(NativeClassPtr,"Skeleton");
			SkeletalMeshes__Offset=GetPropertyOffset(NativeClassPtr,"SkeletalMeshes");
			
		}
		
	}
	
}
#endif
#endif
