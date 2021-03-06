#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UBlueprintCore
	{
		static readonly int SkeletonGeneratedClass__Offset;
		/// <summary>
		/// Pointer to the skeleton class; this is regenerated any time a member variable or function is added but
		///       is usually incomplete (no code or hidden autogenerated variables are added to it)
		/// </summary>
		public TSubclassOf<UObject>  SkeletonGeneratedClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SkeletonGeneratedClass__Offset); return v; }
			
		}
		
		static readonly int GeneratedClass__Offset;
		/// <summary>Pointer to the 'most recent' fully generated class</summary>
		public TSubclassOf<UObject>  GeneratedClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GeneratedClass__Offset); return v; }
			
		}
		
		static readonly int bLegacyNeedToPurgeSkelRefs__Offset;
		/// <summary>BackCompat:  Whether or not we need to purge references in this blueprint to the skeleton generated during compile-on-load</summary>
		public bool bLegacyNeedToPurgeSkelRefs
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLegacyNeedToPurgeSkelRefs__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bLegacyGeneratedClassIsAuthoritative__Offset;
		/// <summary>BackCompat: Whether or not this blueprint's authoritative CDO data has been migrated from the SkeletonGeneratedClass CDO to the GeneratedClass CDO</summary>
		public bool bLegacyGeneratedClassIsAuthoritative
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLegacyGeneratedClassIsAuthoritative__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int BlueprintGuid__Offset;
		/// <summary>Blueprint Guid</summary>
		public FGuid BlueprintGuid
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+BlueprintGuid__Offset, typeof(FGuid));}
			
		}
		
		static UBlueprintCore()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("BlueprintCore");
			SkeletonGeneratedClass__Offset=GetPropertyOffset(NativeClassPtr,"SkeletonGeneratedClass");
			GeneratedClass__Offset=GetPropertyOffset(NativeClassPtr,"GeneratedClass");
			bLegacyNeedToPurgeSkelRefs__Offset=GetPropertyOffset(NativeClassPtr,"bLegacyNeedToPurgeSkelRefs");
			bLegacyGeneratedClassIsAuthoritative__Offset=GetPropertyOffset(NativeClassPtr,"bLegacyGeneratedClassIsAuthoritative");
			BlueprintGuid__Offset=GetPropertyOffset(NativeClassPtr,"BlueprintGuid");
			
		}
		
	}
	
}
#endif
#endif
