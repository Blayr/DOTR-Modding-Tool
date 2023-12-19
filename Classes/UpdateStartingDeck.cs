using GameplayPatches;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;

namespace DOTR_MODDING_TOOL.Classes
{
    public static class UpdateStartingDeck
    {
        static int patchLocation = 0x269E00;
        static DataAccess dataAccess = DataAccess.Instance;


        public static void CreateNewStartingDeckData(List<Deck> decks)
        {
            byte[][] patchBytes = new byte[17][];

            // Pre-initialize dictionaries
            var attributeEnumValues = Enum.GetValues(typeof(StarterDeckDataEnums.Attribute)).Cast<StarterDeckDataEnums.Attribute>();
            var kindEnumValues = Enum.GetValues(typeof(StarterDeckDataEnums.Kind)).Cast<StarterDeckDataEnums.Kind>();

            for (int i = 0; i < 17; i++)
            {
                StartingDeckData startingDeckData = new StartingDeckData();
                var attributeCounts = attributeEnumValues.ToDictionary(attr => attr, attr => (byte)0);
                var kindCounts = kindEnumValues.ToDictionary(kind => kind, kind => (byte)0);
                float totalSummonPower = 0;
                Deck deck = decks[i];
                startingDeckData.LeaderID = deck.DeckLeader.Number;
                byte numberOfMonsters = 0;
                for (int j = 0; j < deck.CardList.Count; j++)
                {
                    DeckCard card = deck.CardList[j];
                    if (card.CardConstant.CardColor == CardColorType.NormalMonster || card.CardConstant.CardColor == CardColorType.EffectMonster)
                    {
                        numberOfMonsters++;
                        string kindString = card.CardConstant.KindName.Replace(' ', '_').Replace("-", "_");
                        if (Enum.TryParse(card.Attribute, out StarterDeckDataEnums.Attribute attribute))
                        {
                            totalSummonPower += card.Level;
                            attributeCounts[attribute]++;
                        }
                        if (Enum.TryParse(kindString, out StarterDeckDataEnums.Kind kind))
                        {
                            kindCounts[kind]++;
                        }
                    }
                }

                SetStartingDeckDataAttributes(startingDeckData, attributeCounts);
                SetStartingDeckDataKinds(startingDeckData, kindCounts);

                startingDeckData.AverageSummonLevel = (ushort)((totalSummonPower / numberOfMonsters) * 100);
                patchBytes[i] = startingDeckData.ToByteArray();
            }

            byte[] combinedArray = CombineArrays(patchBytes);
            dataAccess.ApplyPatch(patchLocation, combinedArray);
        }

        private static void SetStartingDeckDataAttributes(StartingDeckData data, Dictionary<StarterDeckDataEnums.Attribute, byte> counts)
        {
            var topAttributes = counts.OrderByDescending(pair => pair.Value)
                                     .Take(4)
                                     .Select(pair => pair.Value > 0 ? pair.Key : StarterDeckDataEnums.Attribute.None)
                                     .ToArray();

            data.Attributes = ((byte)topAttributes[0] * (8 * 8 * 8) + (byte)topAttributes[1] * (8 * 8) + (byte)topAttributes[2] * 8 + (byte)topAttributes[3]);
        }

        private static void SetStartingDeckDataKinds(StartingDeckData data, Dictionary<StarterDeckDataEnums.Kind, byte> counts)
        {
            var topKinds = counts.OrderByDescending(pair => pair.Value)
                                 .Take(4)
                                 .Select(pair => pair.Value > 0 ? pair.Key : StarterDeckDataEnums.Kind.None)
                                 .ToArray();

            data.Kinds = ((byte)topKinds[0] * (32 * 32 * 32) + (byte)topKinds[1] * (32 * 32) + (byte)topKinds[2] * 32 + (byte)topKinds[3]);
        }

        private static byte[] CombineArrays(byte[][] arrays)
        {
            using (var memoryStream = new MemoryStream())
            {
                foreach (byte[] subArray in arrays)
                {
                    if (subArray != null)
                    {
                        memoryStream.Write(subArray, 0, subArray.Length);
                    }
                }
                return memoryStream.ToArray();
            }
        }


    }


    class StartingDeckData
    {
        public ushort LeaderID;
        public ushort AverageSummonLevel;
        public int Attributes;
        public int Kinds;


        public byte[] ToByteArray()
        {
            using (var memoryStream = new MemoryStream())
            using (var writer = new BinaryWriter(memoryStream))
            {
                writer.Write(LeaderID);
                writer.Write(AverageSummonLevel);
                writer.Write(Attributes);
                writer.Write(Kinds);

                return memoryStream.ToArray();
            }
        }
    }
}
