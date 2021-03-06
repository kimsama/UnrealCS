#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionTextureCoordinate
	{
		static readonly int CoordinateIndex__Offset;
		public int CoordinateIndex
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+CoordinateIndex__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CoordinateIndex__Offset, false);}
			
		}
		
		static readonly int UTiling__Offset;
		public float UTiling
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+UTiling__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+UTiling__Offset, false);}
			
		}
		
		static readonly int VTiling__Offset;
		public float VTiling
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+VTiling__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VTiling__Offset, false);}
			
		}
		
		static readonly int UnMirrorU__Offset;
		public bool UnMirrorU
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), UnMirrorU__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), UnMirrorU__Offset, 1,0,1,1);}
			
		}
		
		static readonly int UnMirrorV__Offset;
		public bool UnMirrorV
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), UnMirrorV__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), UnMirrorV__Offset, 1,0,2,2);}
			
		}
		
		static UMaterialExpressionTextureCoordinate()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionTextureCoordinate");
			CoordinateIndex__Offset=GetPropertyOffset(NativeClassPtr,"CoordinateIndex");
			UTiling__Offset=GetPropertyOffset(NativeClassPtr,"UTiling");
			VTiling__Offset=GetPropertyOffset(NativeClassPtr,"VTiling");
			UnMirrorU__Offset=GetPropertyOffset(NativeClassPtr,"UnMirrorU");
			UnMirrorV__Offset=GetPropertyOffset(NativeClassPtr,"UnMirrorV");
			
		}
		
	}
	
}
#endif
#endif
