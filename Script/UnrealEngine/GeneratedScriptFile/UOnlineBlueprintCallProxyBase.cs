using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UOnlineBlueprintCallProxyBase:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Activate(IntPtr _this);
/// <summary>Called to trigger the actual online action once the delegates have been bound</summary>
public  void Activate()
{
	CheckIsValid();
	Activate(_this.Get());
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
