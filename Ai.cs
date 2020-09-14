using System;
using System.Collections.Generic;
using System.Linq;

public class Ai
{
	public static List<Ai> All { get; }
	byte[] Bytes { get; }
	string Name { get; }

	static Ai()
	{
		Ai.All = new List<Ai> {
			new Ai("00117C90", "Seto"),
			new Ai("00110F00", "Weevil Underwood"),
			new Ai("0011C430", "Rex Raptor"),
			new Ai("00121630", "Keith"),
			new Ai("00126AB0", "Ishtar"),
			new Ai("0012B9A0", "Necromancer"),
			new Ai("00130E90", "Darkness-ruler"),
			new Ai("00135060", "Labyrinth-ruler"),
			new Ai("001396C0", "Pegasus Crawford"),
			new Ai("0013DAD0", "Richard Slysheen of York"),
			new Ai("001422E0", "Tea"),
			new Ai("00146790", "T. Tristan Grey"),
			new Ai("0014B730", "Margaret Mai Beaufort"),
			new Ai("0014FB70", "Mako"),
			new Ai("00154040", "Joey"),
			new Ai("00154210", "J. Shadi Morton"),
			new Ai("00158AB0", "Jasper Dice Tudor"),
			new Ai("0015D180", "Bakura"),
			new Ai("00162F60", "Yugi"),
			new Ai("001676E0", "Manawyddan fab Llyr (Skull Knight)"),
			new Ai("0016B1F0", "Manawyddan fab Llyr (Chakra)"),
			new Ai("00172370", "Deck Master K")
		};
	}

	public Ai(byte[] bytes)
	{
		this.Bytes = bytes;
		this.Name = Ai.GetAiName(bytes);
	}

	public Ai(string hexPointerAddress, string name)
	{
		byte[] bytes = BitHelper.HexStringToByteArray(hexPointerAddress);
		this.Bytes = bytes;
		this.Name = name;
	}

	public static string GetAiName(byte[] aiAddressPointer)
	{
		if (BitConverter.IsLittleEndian)
		{
			Array.Reverse(aiAddressPointer);
		}

		Ai matchedAi = Ai.All.Find(x => x.Bytes.SequenceEqual(aiAddressPointer));

		return matchedAi == null ? "???" : matchedAi.Name;
	}
}