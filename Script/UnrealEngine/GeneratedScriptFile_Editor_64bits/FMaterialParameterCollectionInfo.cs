#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Stores information about a parameter collection that this material references, used to know when the material needs to be recompiled.</summary>
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FMaterialParameterCollectionInfo
	{
		/// <summary>Id that the collection had when this material was last compiled.</summary>
		[FieldOffset(0)]
		public FGuid StateId;
		/// <summary>The collection which this material has a dependency on.</summary>
		
	}
	
}
#endif
#endif
