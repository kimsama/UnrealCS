#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Remaps the SoundClass of SoundWaves underneath this</summary>
	public partial class USoundNodeSoundClass
	{
		static readonly int SoundClassOverride__Offset;
		public USoundClass SoundClassOverride
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SoundClassOverride__Offset); if (v == IntPtr.Zero)return null; USoundClass retValue = new USoundClass(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + SoundClassOverride__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + SoundClassOverride__Offset, value._this.Get()); }
			
		}
		
		static USoundNodeSoundClass()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SoundNodeSoundClass");
			SoundClassOverride__Offset=GetPropertyOffset(NativeClassPtr,"SoundClassOverride");
			
		}
		
	}
	
}
#endif
#endif
