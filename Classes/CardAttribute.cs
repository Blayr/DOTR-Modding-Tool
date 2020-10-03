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
		this.Id = attributeId;
		this.Name = CardAttribute.AttributeNames[this.Id];
	}

	public byte Id { get; }
	public string Name { get; }
}

