using System.Diagnostics;
using System.Runtime.InteropServices;
using SramCommons.Extensions;

namespace RosettaStone.Sram.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// DogStatusBuffs
	/// </summary>
	/// <remarks><see cref="SramSizes.SaveSlot.Chunk10"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	public struct Chunk10
	{
		// Dog Status Buffs 1-4
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public CharacterBuffStatus[] DogStatusBuffs; // [177|xB1] :: (24 bytes)

		public override string ToString() => this.FormatAsString();
	}
}