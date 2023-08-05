    namespace GameplayPatches {
    public class FastIntro : Patch {
        static int Name2 = 0x1ee960;
        static int DeckLeader = 0x1eec98;
        static int DeckLeader2 = 0x1eebf8;
        static int PostDeckLeader1 = 0x1eeff4;
        static int PostDeckLeader2 = 0x1ef044;
        static int ChooseSides1 = 0x1ef380;
        static int ChooseSides2 = 0x1ef054;
        static int SkipSeto1 = 0x1f1fd0;
        static int SkipSeto2 = 0x1f1fe4;
        static int SkipToBoat = 0x1ef4e4;
        static int SkipYugi1 = 0x1ef8c8;
        static int SkipYugi2 = 0x1ef724;

        static PatchByteSequences Name1 = new PatchByteSequences
        {
          Offset = 0x1ee63c,
          Original = new byte[216] { 0x90, 0x01, 0x05, 0x24, 0x28, 0x26, 0x00, 0x70, 0x28, 0x36, 0x00, 0x70, 0x28, 0x3e, 0x00, 0x70, 0x3c, 0xd2, 0x07, 0x0c, 0x28, 0x46, 0x00, 0x70, 0x18, 0x00, 0x04, 0x24, 0x60, 0x5e, 0x08, 0x0c, 0x01, 0x00, 0x05, 0x24, 0xed, 0x01, 0x01, 0x3c, 0x40, 0x00, 0x20, 0xac, 0xed, 0x01, 0x01, 0x3c, 0x48, 0x00, 0x20, 0xac, 0xed, 0x01, 0x01, 0x3c, 0x4c, 0x00, 0x20, 0xac, 0x01, 0x00, 0x04, 0x24, 0xed, 0x01, 0x01, 0x3c, 0x1c, 0x00, 0x24, 0xa4, 0x02, 0x00, 0x03, 0x24, 0xed, 0x01, 0x01, 0x3c, 0x1a, 0x00, 0x23, 0xa4, 0xed, 0x01, 0x01, 0x3c, 0xb3, 0x53, 0x24, 0xa0, 0xed, 0x01, 0x01, 0x3c, 0x62, 0x00, 0x20, 0xa0, 0x00, 0x10, 0x03, 0x24, 0xed, 0x01, 0x01, 0x3c, 0x64, 0x00, 0x23, 0xa4, 0xed, 0x01, 0x01, 0x3c, 0xa2, 0x53, 0x24, 0xa4, 0xed, 0x01, 0x01, 0x3c, 0xa4, 0x53, 0x23, 0xa4, 0xed, 0x01, 0x01, 0x3c, 0x7b, 0x53, 0x20, 0xa0, 0xed, 0x01, 0x01, 0x3c, 0x7d, 0x53, 0x20, 0xa0, 0xed, 0x01, 0x01, 0x3c, 0xb4, 0x53, 0x20, 0xa0, 0xed, 0x01, 0x01, 0x3c, 0xb5, 0x53, 0x20, 0xa0, 0xed, 0x01, 0x01, 0x3c, 0xa6, 0x53, 0x20, 0xa0, 0xed, 0x01, 0x01, 0x3c, 0xa7, 0x53, 0x20, 0xa0, 0xed, 0x01, 0x01, 0x3c, 0x6c, 0x54, 0x20, 0xa0, 0xed, 0x01, 0x01, 0x3c, 0x6d, 0x54, 0x20, 0xa0, 0xed, 0x01, 0x01, 0x3c, 0x6c, 0x53, 0x23, 0x84, 0x01, 0x00, 0x63, 0x24, 0xed, 0x01, 0x01, 0x3c, 0x34, 0x13, 0x00, 0x10, 0x6c, 0x53, 0x23, 0xa4 },
          Patch = new byte[216] { 0x00, 0x00, 0x00, 0x00, 0x28, 0x26, 0x00, 0x70, 0x28, 0x36, 0x00, 0x70, 0x28, 0x3e, 0x00, 0x70, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x18, 0x00, 0x04, 0x24, 0x60, 0x5e, 0x08, 0x0c, 0x01, 0x00, 0x05, 0x24, 0xed, 0x01, 0x01, 0x3c, 0x40, 0x00, 0x20, 0xac, 0xed, 0x01, 0x01, 0x3c, 0x48, 0x00, 0x20, 0xac, 0xed, 0x01, 0x01, 0x3c, 0x4c, 0x00, 0x20, 0xac, 0x0b, 0x00, 0x04, 0x24, 0xed, 0x01, 0x01, 0x3c, 0x1c, 0x00, 0x24, 0xa4, 0x00, 0x00, 0x03, 0x24, 0x02, 0x00, 0x04, 0x24, 0x1a, 0x00, 0x23, 0xa4, 0xed, 0x01, 0x01, 0x3c, 0xb3, 0x53, 0x24, 0xa0, 0xed, 0x01, 0x01, 0x3c, 0x62, 0x00, 0x20, 0xa0, 0x00, 0x10, 0x03, 0x24, 0xed, 0x01, 0x01, 0x3c, 0x64, 0x00, 0x23, 0xa4, 0xed, 0x01, 0x01, 0x3c, 0xa2, 0x53, 0x24, 0xa4, 0xed, 0x01, 0x01, 0x3c, 0xa4, 0x53, 0x23, 0xa4, 0xed, 0x01, 0x01, 0x3c, 0x7b, 0x53, 0x20, 0xa0, 0xed, 0x01, 0x01, 0x3c, 0x7d, 0x53, 0x20, 0xa0, 0xed, 0x01, 0x01, 0x3c, 0xb4, 0x53, 0x20, 0xa0, 0xed, 0x01, 0x01, 0x3c, 0xb5, 0x53, 0x20, 0xa0, 0xed, 0x01, 0x01, 0x3c, 0xa6, 0x53, 0x20, 0xa0, 0xed, 0x01, 0x01, 0x3c, 0xa7, 0x53, 0x20, 0xa0, 0xed, 0x01, 0x01, 0x3c, 0x6c, 0x54, 0x20, 0xa0, 0xed, 0x01, 0x01, 0x3c, 0x6d, 0x54, 0x20, 0xa0, 0xed, 0x01, 0x01, 0x3c, 0x05, 0x00, 0x02, 0x24, 0x08, 0x00, 0x03, 0x24, 0x38, 0x27, 0x05, 0x24, 0xc2, 0x00, 0x05, 0xa6, 0x2d, 0x13, 0x00, 0x10 }
        };

        public override bool IsApplied() {
            return DataAccess.Instance.CheckIfPatchApplied(DeckLeader, new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x56, 0x27, 0x05, 0x24 });
        }

        public override void Apply() {
            DataAccess.Instance.ApplyPatch(Name1.Offset, Name1.Patch);
            DataAccess.Instance.ApplyPatch(Name2, new byte[96] { 0xed, 0x01, 0x01, 0x3c, 0xa2, 0x53, 0x24, 0x84, 0x15, 0x00, 0x03, 0x24, 0x9c, 0x12, 0x83, 0x14, 0x00, 0x00, 0x00, 0x00, 0x22, 0x00, 0x05, 0x24, 0xc4, 0x5d, 0x08, 0x0c, 0x28, 0x26, 0x00, 0x70, 0x23, 0x00, 0x05, 0x24, 0xc4, 0x5d, 0x08, 0x0c, 0x28, 0x26, 0x00, 0x70, 0xed, 0x01, 0x01, 0x3c, 0x06, 0x00, 0x03, 0x24, 0x6c, 0x53, 0x23, 0xa4, 0x0e, 0x00, 0x02, 0x24, 0x7b, 0x53, 0x22, 0xa4, 0x03, 0x00, 0x03, 0x24, 0xb3, 0x53, 0x23, 0xa0, 0x02, 0x00, 0x03, 0x24, 0x62, 0x00, 0x23, 0xa0, 0x19, 0x00, 0x04, 0x24, 0x60, 0x5e, 0x08, 0x0c, 0x01, 0x00, 0x05, 0x24, 0x88, 0x12, 0x00, 0x10 });

            DataAccess.Instance.ApplyPatch(DeckLeader, new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x56, 0x27, 0x05, 0x24 });
            DataAccess.Instance.ApplyPatch(DeckLeader2, new byte[4] { 0x25, 0x00, 0x00, 0x10 });

            DataAccess.Instance.NopInstructions(PostDeckLeader1, 1);
            DataAccess.Instance.ApplyPatch(PostDeckLeader2, new byte[4] { 0x6a, 0x27, 0x05, 0x24 });

            DataAccess.Instance.NopInstructions(ChooseSides1, 1);
            DataAccess.Instance.ApplyPatch(ChooseSides2, new byte[24] { 0x02, 0x00, 0x05, 0x24, 0x00, 0x00, 0x18, 0x24, 0xa8, 0x53, 0x38, 0xa0, 0xed, 0x01, 0x01, 0x3c, 0xdd, 0x10, 0x00, 0x10, 0x6c, 0x53, 0x25, 0xa4 });
            
            DataAccess.Instance.NopInstructions(SkipSeto1, 1);
            DataAccess.Instance.NopInstructions(SkipSeto2, 1);
            DataAccess.Instance.NopInstructions(SkipToBoat, 1);
            DataAccess.Instance.NopInstructions(SkipYugi1, 1);
            DataAccess.Instance.ApplyPatch(SkipYugi2, new byte[4] { 0x05, 0x00, 0x03, 0x24 });
        }

        public override void Remove() {
            DataAccess.Instance.ApplyPatch(Name1.Offset, Name1.Original);
            DataAccess.Instance.ApplyPatch(Name2, new byte[96] { 0xed, 0x01, 0x01, 0x3c, 0xa2, 0x53, 0x24, 0x84, 0x15, 0x00, 0x03, 0x24, 0x9c, 0x12, 0x83, 0x14, 0x00, 0x00, 0x00, 0x00, 0x22, 0x00, 0x05, 0x24, 0xc4, 0x5d, 0x08, 0x0c, 0x28, 0x26, 0x00, 0x70, 0x23, 0x00, 0x05, 0x24, 0xc4, 0x5d, 0x08, 0x0c, 0x28, 0x26, 0x00, 0x70, 0x02, 0x00, 0x03, 0x24, 0xed, 0x01, 0x01, 0x3c, 0x62, 0x00, 0x23, 0xa0, 0xed, 0x01, 0x01, 0x3c, 0x6c, 0x53, 0x23, 0x84, 0x01, 0x00, 0x63, 0x24, 0xed, 0x01, 0x01, 0x3c, 0x8d, 0x12, 0x00, 0x10, 0x6c, 0x53, 0x23, 0xa4, 0xed, 0x01, 0x01, 0x3c, 0x62, 0x00, 0x23, 0x80, 0x89, 0x12, 0x60, 0x14, 0x00, 0x00, 0x00, 0x00 });

            DataAccess.Instance.ApplyPatch(DeckLeader, new byte[8] { 0xd1, 0x11, 0x83, 0x14, 0x00, 0x00, 0x00, 0x00 });
            DataAccess.Instance.ApplyPatch(DeckLeader2, new byte[4] { 0x25, 0x00, 0x83, 0x10 });

            DataAccess.Instance.ApplyPatch(PostDeckLeader1, new byte[4] { 0xfa, 0x10, 0x83, 0x14 });
            DataAccess.Instance.ApplyPatch(PostDeckLeader2, new byte[4] { 0x00, 0x00, 0x00, 0x00 });

            DataAccess.Instance.ApplyPatch(ChooseSides1, new byte[4] { 0x17, 0x10, 0x83, 0x14 });
            DataAccess.Instance.ApplyPatch(ChooseSides2, new byte[24] { 0xed, 0x01, 0x01, 0x3c, 0xe1, 0x10, 0x00, 0x10, 0x6c, 0x53, 0x20, 0xa4, 0xed, 0x01, 0x01, 0x3c, 0x6c, 0x53, 0x24, 0x84, 0x01, 0x00, 0x03, 0x24 });

            DataAccess.Instance.ApplyPatch(SkipSeto1, new byte[4] { 0x03, 0x05, 0x83, 0x14 });
            DataAccess.Instance.ApplyPatch(SkipSeto2, new byte[4] { 0xfe, 0x04, 0x83, 0x14 });
            DataAccess.Instance.ApplyPatch(SkipToBoat, new byte[4] { 0xbe, 0x0f, 0x83, 0x14 });
            DataAccess.Instance.ApplyPatch(SkipYugi1, new byte[4] { 0xc5, 0x0e, 0x83, 0x14 });
            DataAccess.Instance.ApplyPatch(SkipYugi2, new byte[4] { 0x01, 0x00, 0x63, 0x24 });
        }
    }
    }