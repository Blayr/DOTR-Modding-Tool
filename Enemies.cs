﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class Enemies
{
	public Enemies(byte[] bytes)
  {
		this.List = new List<Enemy> { };

		for (int i = 0, bi = 0; bi < bytes.Length; i++, bi += DataAccess.EnemyAIByteLength)
    {
			byte[] enemyBytes = new byte[] { bytes[bi], bytes[bi + 1], bytes[bi + 2], bytes[bi + 3] };
			this.List.Add(new Enemy(i, enemyBytes));
    }
  }

	public Enemy this[int index]
  {
    get
    {
			return this.List[index];
    }

    set
    {
			this.List[index] = value;
    }
  }

	public List<Enemy> List { get; set; }
}

public class Enemy
{
	public int Index { get; }
	public string Name { get; }
	public Ai AI { get; set; }

	private static string[] nameList = new string[]
	{
		"Seto",
		"Weevil Underwood",
		"Rex Raptor",
		"Keith",
		"Ishtar",
		"Necromancer",
		"Darkness-ruler",
		"Labyrinth-ruler",
		"Pegasus Crawford",
		"Richard Slysheen of York",
		"Tea",
		"T. Tristan Grey",
		"Margaret Mai Beaufort",
		"Mako",
		"Joey",
		"J. Shadi Morton",
		"Jasper Dice Tudor",
		"Bakura",
		"Yugi",
		"Manawyddan fab Llyr (Skull Knight)",
		"Manawyddan fab Llyr (Chakra)",
		"Deck Master K",
		"Deck Master I",
		"Deck Master T",
		"Deck Master S"
	};

	public Enemy(int index, byte[] aiBytes)
	{
		this.Index = index;
		this.Name = Enemy.GetEnemyNameByIndex(index);
		this.AI = new Ai(aiBytes);
	}

	public static string GetEnemyNameByIndex(int index)
  {
		return Enemy.nameList.ElementAtOrDefault(index) == null ? "???" : Enemy.nameList[index];
	}

	public int AiId
  {
		get
    {
			return this.AI.Id;
    }

		set
    {
			this.AI = Ai.All.Find(x => x.Id == value);
    }
  }

	public string AiName
  {
		get
		{
			return this.AI.Name;
		}
  }
}

