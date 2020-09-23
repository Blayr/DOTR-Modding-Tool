using System;

public class CardAttribute
{
	public static string[] AttributeNames = {
		"Light",
		"Dark",
		"Fire",
		"Earth",
		"Water",
		"Wind",
	};

	public CardAttribute(byte attributeId)
	{
		this.id = attributeId;
		this.name = CardAttribute.AttributeNames[id];
	}

	public byte ID
	{
		get
		{
			return this.id;
		}
	}

	public string Name
	{
		get
		{
			return this.name;
		}
	}

	private byte id;
	private string name;
}

