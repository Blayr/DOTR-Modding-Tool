﻿

namespace GameplayPatches
{
    /// <summary>
    /// NOT EVEN CLOSE TO WORKING YET
    /// </summary>
    public class AiFixAttackLeaderOnCrush : Patch
    {
        static int patchLocation = 0x21FF88;
        static int TaTuto_Init036Location = 0x24F6B0;

        public override bool IsApplied()
        {

            return dataAccess.CheckIfPatchApplied(patchLocation, new byte[8] { 0x6C, 0xFD, 0x09, 0x08, 0x00, 0x00, 0x00, 0x00 });
        }

        public override void Apply()
        {
           //Patch jump to Draw Trap area
            dataAccess.ApplyPatch(patchLocation, new byte[8] { 0x6C, 0xFD, 0x09, 0x08, 0x00, 0x00, 0x00, 0x00 });
            dataAccess.ApplyPatch(TaTuto_Init036Location, new byte[116] { 0x25, 0x70, 0x80, 0x00, 0x98, 0x42, 0x09, 0x0C, 0x00, 0x00, 0x00, 0x00, 0x25, 0xC8, 0x40, 0x00, 0x44, 0x00, 0x88, 0x80, 0x04, 0x00, 0x00, 0x11, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x09, 0x24, 0x02, 0x00, 0x00, 0x10, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x09, 0x24, 0x00, 0x00, 0x00, 0x00, 0x25, 0x78, 0xA0, 0x00, 0x25, 0xC0, 0xC0, 0x00, 0x25, 0x20, 0x20, 0x01, 0x25, 0x28, 0x00, 0x00, 0x50, 0x7D, 0x07, 0x0C, 0x00, 0x00, 0x00, 0x00, 0x40, 0x00, 0x4A, 0x80, 0x40, 0x00, 0xC8, 0x81, 0x03, 0x00, 0x0A, 0x11, 0x00, 0x00, 0x00, 0x00, 0x03, 0x00, 0x00, 0x10, 0x00, 0x00, 0x00, 0x00, 0xA7, 0x3F, 0x09, 0x08, 0x00, 0x00, 0x02, 0x24, 0x25, 0x10, 0x20, 0x03, 0xA4, 0x3F, 0x09, 0x08, 0x00, 0x00, 0x00, 0x00 });
        }

        public override void Remove()
        {
            dataAccess.ApplyPatch(patchLocation, new byte[8] { 0x98, 0x42, 0x09, 0x0C, 0x00, 0x00, 0x00, 0x00 });
            dataAccess.ApplyPatch(TaTuto_Init036Location, new byte[128] { 0xF0, 0xFF, 0xBD, 0x27, 0x00, 0x00, 0xBF, 0x7F, 0x28, 0x26, 0x00, 0x70, 0x9C, 0x7B, 0x07, 0x0C, 0x28, 0x2E, 0x00, 0x70, 0x03, 0x00, 0x05, 0x24, 0x9C, 0x7B, 0x07, 0x0C, 0x28, 0x26, 0x00, 0x70, 0x06, 0x00, 0x05, 0x24, 0x9C, 0x7B, 0x07, 0x0C, 0x28, 0x26, 0x00, 0x70, 0xBC, 0x02, 0x05, 0x24, 0x9C, 0x7B, 0x07, 0x0C, 0x28, 0x26, 0x00, 0x70, 0x01, 0x00, 0x04, 0x24, 0x9C, 0x7B, 0x07, 0x0C, 0x28, 0x2E, 0x00, 0x70, 0x01, 0x00, 0x04, 0x24, 0x9C, 0x7B, 0x07, 0x0C, 0x03, 0x00, 0x05, 0x24, 0x01, 0x00, 0x04, 0x24, 0x9C, 0x7B, 0x07, 0x0C, 0x06, 0x00, 0x05, 0x24, 0x01, 0x00, 0x04, 0x24, 0x9C, 0x7B, 0x07, 0x0C, 0xBB, 0x02, 0x05, 0x24, 0x00, 0x00, 0xBF, 0x7B, 0x08, 0x00, 0xE0, 0x03, 0x10, 0x00, 0xBD, 0x27, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
        }

    
    }
}