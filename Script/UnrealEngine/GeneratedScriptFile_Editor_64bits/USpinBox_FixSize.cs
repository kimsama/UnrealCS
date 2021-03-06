#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A numerical entry box that allows for direct entry of the number or allows the user to click and slide the number.</summary>
	public partial class USpinBox
	{
		static readonly int Value__Offset;
		/// <summary>Value stored in this spin box</summary>
		public float Value
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Value__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Value__Offset, false);}
			
		}
		
		static readonly int WidgetStyle__Offset;
		/// <summary>The Style</summary>
		public FSpinBoxStyle WidgetStyle
		{
			get{ CheckIsValid();return (FSpinBoxStyle)Marshal.PtrToStructure(_this.Get()+WidgetStyle__Offset, typeof(FSpinBoxStyle));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WidgetStyle__Offset, false);}
			
		}
		
		static readonly int Style__Offset;
		public USlateWidgetStyleAsset Style
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Style__Offset); if (v == IntPtr.Zero)return null; USlateWidgetStyleAsset retValue = new USlateWidgetStyleAsset(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int Delta__Offset;
		/// <summary>The amount by which to change the spin box value as the slider moves.</summary>
		public float Delta
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Delta__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Delta__Offset, false);}
			
		}
		
		static readonly int SliderExponent__Offset;
		/// <summary>The exponent by which to increase the delta as the mouse moves. 1 is constant (never increases the delta).</summary>
		public float SliderExponent
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SliderExponent__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SliderExponent__Offset, false);}
			
		}
		
		static readonly int Font__Offset;
		/// <summary>Font color and opacity (overrides style)</summary>
		public FSlateFontInfo Font
		{
			get{ CheckIsValid();return (FSlateFontInfo)Marshal.PtrToStructure(_this.Get()+Font__Offset, typeof(FSlateFontInfo));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Font__Offset, false);}
			
		}
		
		static readonly int MinDesiredWidth__Offset;
		/// <summary>The minimum width of the spin box</summary>
		public float MinDesiredWidth
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinDesiredWidth__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinDesiredWidth__Offset, false);}
			
		}
		
		static readonly int ClearKeyboardFocusOnCommit__Offset;
		/// <summary>Whether to remove the keyboard focus from the spin box when the value is committed</summary>
		public bool ClearKeyboardFocusOnCommit
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), ClearKeyboardFocusOnCommit__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), ClearKeyboardFocusOnCommit__Offset, 1,0,1,255);}
			
		}
		
		static readonly int SelectAllTextOnCommit__Offset;
		/// <summary>Whether to select the text in the spin box when the value is committed</summary>
		public bool SelectAllTextOnCommit
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), SelectAllTextOnCommit__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), SelectAllTextOnCommit__Offset, 1,0,1,255);}
			
		}
		
		static readonly int ForegroundColor__Offset;
		public FSlateColor ForegroundColor
		{
			get{ CheckIsValid();return (FSlateColor)Marshal.PtrToStructure(_this.Get()+ForegroundColor__Offset, typeof(FSlateColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ForegroundColor__Offset, false);}
			
		}
		
		static readonly int OnValueChanged__Offset;
		/// <summary>Called when the value is changed interactively by the user</summary>
		public FMulticastScriptDelegate OnValueChanged
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnValueChanged__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnValueChanged__Offset, false);}
			
		}
		
		static readonly int OnValueCommitted__Offset;
		/// <summary>Called when the value is committed. Occurs when the user presses Enter or the text box loses focus.</summary>
		public FMulticastScriptDelegate OnValueCommitted
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnValueCommitted__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnValueCommitted__Offset, false);}
			
		}
		
		static readonly int OnBeginSliderMovement__Offset;
		/// <summary>Called right before the slider begins to move</summary>
		public FMulticastScriptDelegate OnBeginSliderMovement
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnBeginSliderMovement__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnBeginSliderMovement__Offset, false);}
			
		}
		
		static readonly int OnEndSliderMovement__Offset;
		/// <summary>Called right after the slider handle is released by the user</summary>
		public FMulticastScriptDelegate OnEndSliderMovement
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnEndSliderMovement__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnEndSliderMovement__Offset, false);}
			
		}
		
		static readonly int bOverride_MinValue__Offset;
		/// <summary>Whether the optional MinValue attribute of the widget is set</summary>
		public bool bOverride_MinValue
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverride_MinValue__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverride_MinValue__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bOverride_MaxValue__Offset;
		/// <summary>Whether the optional MaxValue attribute of the widget is set</summary>
		public bool bOverride_MaxValue
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverride_MaxValue__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverride_MaxValue__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bOverride_MinSliderValue__Offset;
		/// <summary>Whether the optional MinSliderValue attribute of the widget is set</summary>
		public bool bOverride_MinSliderValue
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverride_MinSliderValue__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverride_MinSliderValue__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bOverride_MaxSliderValue__Offset;
		/// <summary>Whether the optional MaxSliderValue attribute of the widget is set</summary>
		public bool bOverride_MaxSliderValue
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverride_MaxSliderValue__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverride_MaxSliderValue__Offset, 1,0,8,8);}
			
		}
		
		static readonly int MinValue__Offset;
		/// <summary>The minimum allowable value that can be manually entered into the spin box</summary>
		public float MinValue
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinValue__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinValue__Offset, false);}
			
		}
		
		static readonly int MaxValue__Offset;
		/// <summary>The maximum allowable value that can be manually entered into the spin box</summary>
		public float MaxValue
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxValue__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxValue__Offset, false);}
			
		}
		
		static readonly int MinSliderValue__Offset;
		/// <summary>The minimum allowable value that can be specified using the slider</summary>
		public float MinSliderValue
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinSliderValue__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinSliderValue__Offset, false);}
			
		}
		
		static readonly int MaxSliderValue__Offset;
		/// <summary>The maximum allowable value that can be specified using the slider</summary>
		public float MaxSliderValue
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxSliderValue__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxSliderValue__Offset, false);}
			
		}
		
		static USpinBox()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SpinBox");
			Value__Offset=GetPropertyOffset(NativeClassPtr,"Value");
			WidgetStyle__Offset=GetPropertyOffset(NativeClassPtr,"WidgetStyle");
			Style__Offset=GetPropertyOffset(NativeClassPtr,"Style");
			Delta__Offset=GetPropertyOffset(NativeClassPtr,"Delta");
			SliderExponent__Offset=GetPropertyOffset(NativeClassPtr,"SliderExponent");
			Font__Offset=GetPropertyOffset(NativeClassPtr,"Font");
			MinDesiredWidth__Offset=GetPropertyOffset(NativeClassPtr,"MinDesiredWidth");
			ClearKeyboardFocusOnCommit__Offset=GetPropertyOffset(NativeClassPtr,"ClearKeyboardFocusOnCommit");
			SelectAllTextOnCommit__Offset=GetPropertyOffset(NativeClassPtr,"SelectAllTextOnCommit");
			ForegroundColor__Offset=GetPropertyOffset(NativeClassPtr,"ForegroundColor");
			OnValueChanged__Offset=GetPropertyOffset(NativeClassPtr,"OnValueChanged");
			OnValueCommitted__Offset=GetPropertyOffset(NativeClassPtr,"OnValueCommitted");
			OnBeginSliderMovement__Offset=GetPropertyOffset(NativeClassPtr,"OnBeginSliderMovement");
			OnEndSliderMovement__Offset=GetPropertyOffset(NativeClassPtr,"OnEndSliderMovement");
			bOverride_MinValue__Offset=GetPropertyOffset(NativeClassPtr,"bOverride_MinValue");
			bOverride_MaxValue__Offset=GetPropertyOffset(NativeClassPtr,"bOverride_MaxValue");
			bOverride_MinSliderValue__Offset=GetPropertyOffset(NativeClassPtr,"bOverride_MinSliderValue");
			bOverride_MaxSliderValue__Offset=GetPropertyOffset(NativeClassPtr,"bOverride_MaxSliderValue");
			MinValue__Offset=GetPropertyOffset(NativeClassPtr,"MinValue");
			MaxValue__Offset=GetPropertyOffset(NativeClassPtr,"MaxValue");
			MinSliderValue__Offset=GetPropertyOffset(NativeClassPtr,"MinSliderValue");
			MaxSliderValue__Offset=GetPropertyOffset(NativeClassPtr,"MaxSliderValue");
			
		}
		
	}
	
}
#endif
#endif
