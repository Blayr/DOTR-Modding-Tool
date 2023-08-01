﻿using System;
using System.Collections.Generic;

namespace GameplayPatches
{
    public class PatchByteSequences
    {
        public int Offset { get; set; }
        public byte[] Original { get; set; }
        public byte[] Patch { get; set; }
    }


    public class Patcher
    {
        protected DataAccess dataAccess = null;



        public Patcher(DataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }


        public static PatchByteSequences AllowAllHandFusions = new PatchByteSequences
        {
            Offset = 0x0023E794,
            Original = new byte[696] { 0x00, 0x00, 0xE3, 0x92, 0x43, 0x21, 0x03, 0x00, 0x1E, 0x00, 0x80, 0x14, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x43, 0x90, 0x43, 0x19, 0x03, 0x00, 0x1A, 0x00, 0x60, 0x14, 0x00, 0x00, 0x00, 0x00, 0x28, 0x26, 0x00, 0x72, 0x68, 0x25, 0x09, 0x0C, 0x28, 0x2E, 0x20, 0x72, 0xE7, 0x03, 0x03, 0x24, 0x0C, 0x00, 0x43, 0x14, 0x00, 0x22, 0x16, 0x00, 0x02, 0x00, 0x04, 0x24, 0x00, 0x12, 0x16, 0x00, 0x25, 0x18, 0x55, 0x00, 0x00, 0x00, 0x44, 0xAE, 0x25, 0x10, 0x53, 0x00, 0x04, 0x00, 0x43, 0xAE, 0x08, 0x00, 0x42, 0xAE, 0xFF, 0xFF, 0x02, 0x24, 0x8B, 0x00, 0x00, 0x10, 0x0C, 0x00, 0x40, 0xAE, 0x00, 0x22, 0x16, 0x00, 0x00, 0x00, 0x40, 0xAE, 0x25, 0x18, 0x95, 0x00, 0x04, 0x00, 0x43, 0xAE, 0x25, 0x18, 0x93, 0x00, 0x08, 0x00, 0x43, 0xAE, 0x0C, 0x00, 0x42, 0xAE, 0x82, 0x00, 0x00, 0x10, 0x28, 0x16, 0x00, 0x70, 0x3C, 0x00, 0x80, 0x14, 0x02, 0x00, 0x03, 0x24, 0x00, 0x00, 0x43, 0x90, 0x02, 0x00, 0x02, 0x24, 0x43, 0x19, 0x03, 0x00, 0x04, 0x00, 0x62, 0x10, 0x28, 0x26, 0xC0, 0x72, 0x2C, 0x00, 0x00, 0x10, 0x00, 0x00, 0x42, 0xAE, 0x28, 0x26, 0xC0, 0x72, 0x28, 0x2E, 0xA0, 0x72, 0xF4, 0x23, 0x09, 0x0C, 0x28, 0x36, 0x20, 0x72, 0x0C, 0x00, 0x41, 0x04, 0x03, 0x1C, 0x02, 0x00, 0x02, 0x00, 0x04, 0x24, 0x00, 0x12, 0x16, 0x00, 0x25, 0x18, 0x55, 0x00, 0x00, 0x00, 0x44, 0xAE, 0x25, 0x10, 0x53, 0x00, 0x04, 0x00, 0x43, 0xAE, 0x08, 0x00, 0x42, 0xAE, 0xFF, 0xFF, 0x02, 0x24, 0x69, 0x00, 0x00, 0x10, 0x0C, 0x00, 0x40, 0xAE, 0x03, 0x1C, 0x02, 0x00, 0x0C, 0x00, 0x60, 0x54, 0x00, 0x12, 0x16, 0x00, 0x00, 0x22, 0x16, 0x00, 0x00, 0x00, 0x40, 0xAE, 0x25, 0x18, 0x95, 0x00, 0x04, 0x00, 0x43, 0xAE, 0x25, 0x18, 0x93, 0x00, 0x08, 0x00, 0x43, 0xAE, 0xFF, 0xFF, 0x42, 0x30, 0x0C, 0x00, 0x42, 0xAE, 0x5C, 0x00, 0x00, 0x10, 0x28, 0x16, 0x00, 0x70, 0x00, 0x12, 0x16, 0x00, 0x25, 0x18, 0x55, 0x00, 0x25, 0x10, 0x53, 0x00, 0x00, 0x1C, 0x03, 0x00, 0x25, 0x10, 0x62, 0x00, 0x01, 0x00, 0x03, 0x24, 0x00, 0x00, 0x43, 0xAE, 0x50, 0x79, 0x07, 0x0C, 0x04, 0x00, 0x42, 0xAE, 0x08, 0x00, 0x42, 0xAE, 0x01, 0x00, 0x02, 0x24, 0x4F, 0x00, 0x00, 0x10, 0x0C, 0x00, 0x51, 0xAE, 0x00, 0x00, 0x42, 0xAE, 0x00, 0x1A, 0x16, 0x00, 0x25, 0x10, 0x75, 0x00, 0x04, 0x00, 0x42, 0xAE, 0x25, 0x10, 0x73, 0x00, 0x08, 0x00, 0x42, 0xAE, 0xFF, 0xFF, 0x02, 0x24, 0x46, 0x00, 0x00, 0x10, 0x0C, 0x00, 0x40, 0xAE, 0x02, 0x00, 0x03, 0x24, 0x3B, 0x00, 0x83, 0x14, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x42, 0x90, 0x43, 0x11, 0x02, 0x00, 0x04, 0x00, 0x40, 0x10, 0x28, 0x26, 0x80, 0x72, 0x2D, 0x00, 0x00, 0x10, 0x00, 0x00, 0x43, 0xAE, 0x28, 0x26, 0x80, 0x72, 0x28, 0x2E, 0x60, 0x72, 0xF4, 0x23, 0x09, 0x0C, 0x28, 0x36, 0x00, 0x72, 0x0C, 0x00, 0x41, 0x04, 0x03, 0x1C, 0x02, 0x00, 0x02, 0x00, 0x04, 0x24, 0x00, 0x12, 0x16, 0x00, 0x25, 0x18, 0x55, 0x00, 0x00, 0x00, 0x44, 0xAE, 0x25, 0x10, 0x53, 0x00, 0x04, 0x00, 0x43, 0xAE, 0x08, 0x00, 0x42, 0xAE, 0xFF, 0xFF, 0x02, 0x24, 0x2D, 0x00, 0x00, 0x10, 0x0C, 0x00, 0x40, 0xAE, 0x03, 0x1C, 0x02, 0x00, 0x0C, 0x00, 0x60, 0x54, 0x00, 0x12, 0x16, 0x00, 0x00, 0x22, 0x16, 0x00, 0x00, 0x00, 0x40, 0xAE, 0x25, 0x18, 0x95, 0x00, 0x04, 0x00, 0x43, 0xAE, 0x25, 0x18, 0x93, 0x00, 0x08, 0x00, 0x43, 0xAE, 0xFF, 0xFF, 0x42, 0x30, 0x0C, 0x00, 0x42, 0xAE, 0x20, 0x00, 0x00, 0x10, 0x28, 0x16, 0x00, 0x70, 0x00, 0x12, 0x16, 0x00, 0x25, 0x18, 0x55, 0x00, 0x25, 0x10, 0x53, 0x00, 0x00, 0x1C, 0x03, 0x00, 0x25, 0x10, 0x62, 0x00, 0x01, 0x00, 0x03, 0x24, 0x00, 0x00, 0x43, 0xAE, 0x50, 0x79, 0x07, 0x0C, 0x04, 0x00, 0x42, 0xAE, 0x08, 0x00, 0x42, 0xAE, 0x01, 0x00, 0x02, 0x3C, 0x0C, 0x00, 0x50, 0xAE, 0x12, 0x00, 0x00, 0x10, 0x01, 0x00, 0x42, 0x34, 0x00, 0x00, 0x43, 0xAE, 0x00, 0x1A, 0x16, 0x00, 0x25, 0x10, 0x75, 0x00, 0x04, 0x00, 0x42, 0xAE, 0x25, 0x10, 0x73, 0x00, 0x08, 0x00, 0x42, 0xAE, 0xFF, 0xFF, 0x02, 0x24, 0x09, 0x00, 0x00, 0x10, 0x0C, 0x00, 0x40, 0xAE, 0x00, 0x00, 0x43, 0xAE, 0x00, 0x1A, 0x16, 0x00, 0x25, 0x10, 0x75, 0x00, 0x04, 0x00, 0x42, 0xAE, 0x25, 0x10, 0x73, 0x00, 0x08, 0x00, 0x42, 0xAE, 0xFF, 0xFF, 0x02, 0x24, 0x0C, 0x00, 0x40, 0xAE, 0x80, 0x00, 0xBF, 0x7B, 0x70, 0x00, 0xB7, 0x7B, 0x60, 0x00, 0xB6, 0x7B, 0x50, 0x00, 0xB5, 0x7B, 0x40, 0x00, 0xB4, 0x7B, 0x30, 0x00, 0xB3, 0x7B, 0x20, 0x00, 0xB2, 0x7B, 0x10, 0x00, 0xB1, 0x7B, 0x00, 0x00, 0xB0, 0x7B, 0x08, 0x00, 0xE0, 0x03, 0x90, 0x00, 0xBD, 0x27, 0x00, 0x00, 0x00, 0x00 },
            Patch = new byte[696] { 0x02, 0x00, 0x06, 0x24, 0x00, 0x00, 0xe3, 0x92, 0x43, 0x21, 0x03, 0x00, 0x1e, 0x00, 0x86, 0x10, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x43, 0x90, 0x43, 0x19, 0x03, 0x00, 0x1a, 0x00, 0x66, 0x10, 0x00, 0x00, 0x00, 0x00, 0x28, 0x26, 0x00, 0x72, 0x68, 0x25, 0x09, 0x0c, 0x28, 0x2e, 0x20, 0x72, 0xe7, 0x03, 0x03, 0x24, 0x0c, 0x00, 0x43, 0x14, 0x00, 0x22, 0x16, 0x00, 0x02, 0x00, 0x04, 0x24, 0x00, 0x12, 0x16, 0x00, 0x25, 0x18, 0x55, 0x00, 0x00, 0x00, 0x44, 0xae, 0x25, 0x10, 0x53, 0x00, 0x04, 0x00, 0x43, 0xae, 0x08, 0x00, 0x42, 0xae, 0xff, 0xff, 0x02, 0x24, 0x8b, 0x00, 0x00, 0x10, 0x0c, 0x00, 0x40, 0xae, 0x00, 0x22, 0x16, 0x00, 0x00, 0x00, 0x40, 0xae, 0x25, 0x18, 0x95, 0x00, 0x04, 0x00, 0x43, 0xae, 0x25, 0x18, 0x93, 0x00, 0x08, 0x00, 0x43, 0xae, 0x0c, 0x00, 0x42, 0xae, 0x82, 0x00, 0x00, 0x10, 0x28, 0x16, 0x00, 0x70, 0x3c, 0x00, 0x80, 0x14, 0x02, 0x00, 0x03, 0x24, 0x00, 0x00, 0x43, 0x90, 0x02, 0x00, 0x02, 0x24, 0x43, 0x19, 0x03, 0x00, 0x04, 0x00, 0x62, 0x10, 0x28, 0x26, 0xc0, 0x72, 0x2c, 0x00, 0x00, 0x10, 0x00, 0x00, 0x42, 0xae, 0x28, 0x26, 0xc0, 0x72, 0x28, 0x2e, 0xa0, 0x72, 0xf4, 0x23, 0x09, 0x0c, 0x28, 0x36, 0x20, 0x72, 0x0c, 0x00, 0x41, 0x04, 0x03, 0x1c, 0x02, 0x00, 0x02, 0x00, 0x04, 0x24, 0x00, 0x12, 0x16, 0x00, 0x25, 0x18, 0x55, 0x00, 0x00, 0x00, 0x44, 0xae, 0x25, 0x10, 0x53, 0x00, 0x04, 0x00, 0x43, 0xae, 0x08, 0x00, 0x42, 0xae, 0xff, 0xff, 0x02, 0x24, 0x69, 0x00, 0x00, 0x10, 0x0c, 0x00, 0x40, 0xae, 0x03, 0x1c, 0x02, 0x00, 0x0c, 0x00, 0x60, 0x54, 0x00, 0x12, 0x16, 0x00, 0x00, 0x22, 0x16, 0x00, 0x00, 0x00, 0x40, 0xae, 0x25, 0x18, 0x95, 0x00, 0x04, 0x00, 0x43, 0xae, 0x25, 0x18, 0x93, 0x00, 0x08, 0x00, 0x43, 0xae, 0xff, 0xff, 0x42, 0x30, 0x0c, 0x00, 0x42, 0xae, 0x5c, 0x00, 0x00, 0x10, 0x28, 0x16, 0x00, 0x70, 0x00, 0x12, 0x16, 0x00, 0x25, 0x18, 0x55, 0x00, 0x25, 0x10, 0x53, 0x00, 0x00, 0x1c, 0x03, 0x00, 0x25, 0x10, 0x62, 0x00, 0x01, 0x00, 0x03, 0x24, 0x00, 0x00, 0x43, 0xae, 0x50, 0x79, 0x07, 0x0c, 0x04, 0x00, 0x42, 0xae, 0x08, 0x00, 0x42, 0xae, 0x01, 0x00, 0x02, 0x24, 0x4f, 0x00, 0x00, 0x10, 0x0c, 0x00, 0x51, 0xae, 0x00, 0x00, 0x42, 0xae, 0x00, 0x1a, 0x16, 0x00, 0x25, 0x10, 0x75, 0x00, 0x04, 0x00, 0x42, 0xae, 0x25, 0x10, 0x73, 0x00, 0x08, 0x00, 0x42, 0xae, 0xff, 0xff, 0x02, 0x24, 0x46, 0x00, 0x00, 0x10, 0x0c, 0x00, 0x40, 0xae, 0x02, 0x00, 0x03, 0x24, 0x3b, 0x00, 0x83, 0x14, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x42, 0x90, 0x43, 0x11, 0x02, 0x00, 0x04, 0x00, 0x40, 0x10, 0x28, 0x26, 0x80, 0x72, 0x2d, 0x00, 0x00, 0x10, 0x00, 0x00, 0x43, 0xae, 0x28, 0x26, 0x80, 0x72, 0x28, 0x2e, 0x60, 0x72, 0xf4, 0x23, 0x09, 0x0c, 0x28, 0x36, 0x00, 0x72, 0x0c, 0x00, 0x41, 0x04, 0x03, 0x1c, 0x02, 0x00, 0x02, 0x00, 0x04, 0x24, 0x00, 0x12, 0x16, 0x00, 0x25, 0x18, 0x55, 0x00, 0x00, 0x00, 0x44, 0xae, 0x25, 0x10, 0x53, 0x00, 0x04, 0x00, 0x43, 0xae, 0x08, 0x00, 0x42, 0xae, 0xff, 0xff, 0x02, 0x24, 0x2d, 0x00, 0x00, 0x10, 0x0c, 0x00, 0x40, 0xae, 0x03, 0x1c, 0x02, 0x00, 0x0c, 0x00, 0x60, 0x54, 0x00, 0x12, 0x16, 0x00, 0x00, 0x22, 0x16, 0x00, 0x00, 0x00, 0x40, 0xae, 0x25, 0x18, 0x95, 0x00, 0x04, 0x00, 0x43, 0xae, 0x25, 0x18, 0x93, 0x00, 0x08, 0x00, 0x43, 0xae, 0xff, 0xff, 0x42, 0x30, 0x0c, 0x00, 0x42, 0xae, 0x20, 0x00, 0x00, 0x10, 0x28, 0x16, 0x00, 0x70, 0x00, 0x12, 0x16, 0x00, 0x25, 0x18, 0x55, 0x00, 0x25, 0x10, 0x53, 0x00, 0x00, 0x1c, 0x03, 0x00, 0x25, 0x10, 0x62, 0x00, 0x01, 0x00, 0x03, 0x24, 0x00, 0x00, 0x43, 0xae, 0x50, 0x79, 0x07, 0x0c, 0x04, 0x00, 0x42, 0xae, 0x08, 0x00, 0x42, 0xae, 0x01, 0x00, 0x02, 0x3c, 0x0c, 0x00, 0x50, 0xae, 0x12, 0x00, 0x00, 0x10, 0x01, 0x00, 0x42, 0x34, 0x00, 0x00, 0x43, 0xae, 0x00, 0x1a, 0x16, 0x00, 0x25, 0x10, 0x75, 0x00, 0x04, 0x00, 0x42, 0xae, 0x25, 0x10, 0x73, 0x00, 0x08, 0x00, 0x42, 0xae, 0xff, 0xff, 0x02, 0x24, 0x09, 0x00, 0x00, 0x10, 0x0c, 0x00, 0x40, 0xae, 0x00, 0x00, 0x43, 0xae, 0x00, 0x1a, 0x16, 0x00, 0x25, 0x10, 0x75, 0x00, 0x04, 0x00, 0x42, 0xae, 0x25, 0x10, 0x73, 0x00, 0x08, 0x00, 0x42, 0xae, 0xff, 0xff, 0x02, 0x24, 0x0c, 0x00, 0x40, 0xae, 0x80, 0x00, 0xbf, 0x7b, 0x70, 0x00, 0xb7, 0x7b, 0x60, 0x00, 0xb6, 0x7b, 0x50, 0x00, 0xb5, 0x7b, 0x40, 0x00, 0xb4, 0x7b, 0x30, 0x00, 0xb3, 0x7b, 0x20, 0x00, 0xb2, 0x7b, 0x10, 0x00, 0xb1, 0x7b, 0x00, 0x00, 0xb0, 0x7b, 0x08, 0x00, 0xe0, 0x03, 0x90, 0x00, 0xbd, 0x27 }
        };

        public static PatchByteSequences AllowAllFieldFusions = new PatchByteSequences
        {
            Offset = 0x002180A4,
            Original = new byte[972] { 0xC0, 0x81, 0x07, 0x0C, 0x00, 0x00, 0x00, 0x00, 0x43, 0x81, 0x02, 0x00, 0x28, 0x26, 0x60, 0x72, 0xC0, 0x81, 0x07, 0x0C, 0x28, 0x2E, 0x40, 0x72, 0x25, 0x00, 0x00, 0x16, 0x43, 0x19, 0x02, 0x00, 0x23, 0x00, 0x60, 0x14, 0x00, 0x00, 0x00, 0x00, 0x0D, 0x00, 0x80, 0x16, 0x28, 0x26, 0xA0, 0x72, 0x00, 0x12, 0x13, 0x00, 0x5F, 0x00, 0x04, 0x24, 0x25, 0x18, 0x52, 0x00, 0x00, 0x12, 0x15, 0x00, 0x00, 0x00, 0x24, 0xAE, 0x25, 0x10, 0x54, 0x00, 0x04, 0x00, 0x23, 0xAE, 0x08, 0x00, 0x22, 0xAE, 0x01, 0x00, 0x02, 0x24, 0xD3, 0x00, 0x00, 0x10, 0x0C, 0x00, 0x22, 0xAE, 0x28, 0x26, 0xA0, 0x72, 0x0C, 0x84, 0x07, 0x0C, 0x28, 0x2E, 0x80, 0x72, 0x28, 0x86, 0x40, 0x70, 0x28, 0x26, 0x60, 0x72, 0x0C, 0x84, 0x07, 0x0C, 0x28, 0x2E, 0x40, 0x72, 0x28, 0x26, 0x00, 0x72, 0x68, 0x25, 0x09, 0x0C, 0x28, 0x2E, 0x40, 0x70, 0x00, 0x1A, 0x15, 0x00, 0x64, 0x00, 0x05, 0x24, 0x25, 0x20, 0x74, 0x00, 0x00, 0x1A, 0x13, 0x00, 0x00, 0x00, 0x25, 0xAE, 0x25, 0x18, 0x72, 0x00, 0x04, 0x00, 0x24, 0xAE, 0x08, 0x00, 0x23, 0xAE, 0x0C, 0x00, 0x22, 0xAE, 0xBE, 0x00, 0x00, 0x10, 0x01, 0x00, 0x02, 0x24, 0x5B, 0x00, 0x00, 0x16, 0x02, 0x00, 0x02, 0x24, 0x02, 0x00, 0x02, 0x24, 0x57, 0x00, 0x62, 0x14, 0x00, 0x00, 0x00, 0x00, 0x0D, 0x00, 0x80, 0x16, 0x28, 0x26, 0x60, 0x72, 0x00, 0x12, 0x13, 0x00, 0x5F, 0x00, 0x04, 0x24, 0x25, 0x18, 0x52, 0x00, 0x00, 0x12, 0x15, 0x00, 0x00, 0x00, 0x24, 0xAE, 0x25, 0x10, 0x54, 0x00, 0x04, 0x00, 0x23, 0xAE, 0x08, 0x00, 0x22, 0xAE, 0x01, 0x00, 0x02, 0x24, 0xAC, 0x00, 0x00, 0x10, 0x0C, 0x00, 0x22, 0xAE, 0x28, 0x26, 0x60, 0x72, 0x0C, 0x84, 0x07, 0x0C, 0x28, 0x2E, 0x40, 0x72, 0x28, 0x26, 0xA0, 0x72, 0x28, 0x2E, 0x80, 0x72, 0xBC, 0x22, 0x09, 0x0C, 0x28, 0x36, 0x40, 0x70, 0xE7, 0x03, 0x05, 0x24, 0x28, 0x86, 0x40, 0x70, 0x0D, 0x00, 0x05, 0x16, 0x83, 0x17, 0x10, 0x00, 0x00, 0x12, 0x15, 0x00, 0x24, 0x00, 0x04, 0x24, 0x25, 0x18, 0x54, 0x00, 0x00, 0x12, 0x13, 0x00, 0x00, 0x00, 0x24, 0xAE, 0x25, 0x10, 0x52, 0x00, 0x04, 0x00, 0x23, 0xAE, 0x08, 0x00, 0x22, 0xAE, 0x01, 0x00, 0x02, 0x24, 0x96, 0x00, 0x00, 0x10, 0x0C, 0x00, 0x25, 0xAE, 0x83, 0x17, 0x10, 0x00, 0x01, 0x00, 0x43, 0x30, 0x01, 0x00, 0x02, 0x24, 0x10, 0x00, 0x62, 0x14, 0x19, 0x02, 0x02, 0x24, 0x00, 0x12, 0x13, 0x00, 0x25, 0x20, 0x52, 0x00, 0x2B, 0x00, 0x05, 0x24, 0x00, 0x12, 0x15, 0x00, 0x25, 0x18, 0x54, 0x00, 0x00, 0x00, 0x25, 0xAE, 0x83, 0x13, 0x10, 0x00, 0x04, 0x00, 0x24, 0xAE, 0xFF, 0x3F, 0x42, 0x30, 0x08, 0x00, 0x23, 0xAE, 0x0C, 0x00, 0x22, 0xAE, 0x01, 0x00, 0x02, 0x3C, 0x83, 0x00, 0x00, 0x10, 0x01, 0x00, 0x42, 0x34, 0x19, 0x02, 0x02, 0x24, 0x83, 0x1B, 0x10, 0x00, 0x12, 0x00, 0x62, 0x14, 0x00, 0x12, 0x15, 0x00, 0x25, 0x00, 0x03, 0x24, 0x00, 0x00, 0x23, 0xAE, 0x00, 0x1A, 0x15, 0x00, 0x00, 0x12, 0x13, 0x00, 0x25, 0x18, 0x74, 0x00, 0x25, 0x10, 0x52, 0x00, 0x04, 0x00, 0x23, 0xAE, 0x08, 0x00, 0x22, 0xAE, 0x28, 0x26, 0xA0, 0x72, 0x9C, 0x37, 0x09, 0x0C, 0x28, 0x2E, 0x80, 0x72, 0x00, 0x1C, 0x02, 0x00, 0xFF, 0x3F, 0x02, 0x32, 0x25, 0x10, 0x43, 0x00, 0x0A, 0x00, 0x00, 0x10, 0x0C, 0x00, 0x22, 0xAE, 0x00, 0x12, 0x15, 0x00, 0x24, 0x00, 0x04, 0x24, 0x25, 0x18, 0x54, 0x00, 0x00, 0x12, 0x13, 0x00, 0x00, 0x00, 0x24, 0xAE, 0x25, 0x10, 0x52, 0x00, 0x04, 0x00, 0x23, 0xAE, 0x08, 0x00, 0x22, 0xAE, 0x0C, 0x00, 0x30, 0xAE, 0x01, 0x00, 0x02, 0x3C, 0x63, 0x00, 0x00, 0x10, 0x01, 0x00, 0x42, 0x34, 0x02, 0x00, 0x02, 0x24, 0x57, 0x00, 0x02, 0x16, 0x00, 0x12, 0x15, 0x00, 0x54, 0x00, 0x60, 0x14, 0x00, 0x00, 0x00, 0x00, 0x0D, 0x00, 0x40, 0x16, 0x28, 0x26, 0xA0, 0x72, 0x00, 0x12, 0x15, 0x00, 0x5F, 0x00, 0x04, 0x24, 0x25, 0x18, 0x54, 0x00, 0x00, 0x12, 0x13, 0x00, 0x00, 0x00, 0x24, 0xAE, 0x25, 0x10, 0x52, 0x00, 0x04, 0x00, 0x23, 0xAE, 0x08, 0x00, 0x22, 0xAE, 0x01, 0x00, 0x02, 0x24, 0x51, 0x00, 0x00, 0x10, 0x0C, 0x00, 0x20, 0xAE, 0x28, 0x26, 0xA0, 0x72, 0x0C, 0x84, 0x07, 0x0C, 0x28, 0x2E, 0x80, 0x72, 0x28, 0x26, 0x60, 0x72, 0x28, 0x2E, 0x40, 0x72, 0xBC, 0x22, 0x09, 0x0C, 0x28, 0x36, 0x40, 0x70, 0xE7, 0x03, 0x05, 0x24, 0x28, 0x86, 0x40, 0x70, 0x0D, 0x00, 0x05, 0x16, 0x83, 0x17, 0x10, 0x00, 0x00, 0x12, 0x15, 0x00, 0x24, 0x00, 0x04, 0x24, 0x25, 0x18, 0x54, 0x00, 0x00, 0x12, 0x13, 0x00, 0x00, 0x00, 0x24, 0xAE, 0x25, 0x10, 0x52, 0x00, 0x04, 0x00, 0x23, 0xAE, 0x08, 0x00, 0x22, 0xAE, 0x01, 0x00, 0x02, 0x24, 0x3B, 0x00, 0x00, 0x10, 0x0C, 0x00, 0x25, 0xAE, 0x83, 0x17, 0x10, 0x00, 0x01, 0x00, 0x43, 0x30, 0x01, 0x00, 0x02, 0x24, 0x0E, 0x00, 0x62, 0x54, 0x19, 0x02, 0x02, 0x24, 0x00, 0x1A, 0x15, 0x00, 0x25, 0x28, 0x74, 0x00, 0x2B, 0x00, 0x06, 0x24, 0x00, 0x1A, 0x13, 0x00, 0x25, 0x20, 0x72, 0x00, 0x00, 0x00, 0x26, 0xAE, 0x83, 0x1B, 0x10, 0x00, 0x04, 0x00, 0x25, 0xAE, 0xFF, 0x3F, 0x63, 0x30, 0x08, 0x00, 0x24, 0xAE, 0x2A, 0x00, 0x00, 0x10, 0x0C, 0x00, 0x23, 0xAE, 0x19, 0x02, 0x02, 0x24, 0x83, 0x1B, 0x10, 0x00, 0x12, 0x00, 0x62, 0x14, 0x00, 0x12, 0x15, 0x00, 0x25, 0x00, 0x03, 0x24, 0x00, 0x12, 0x15, 0x00, 0x25, 0x10, 0x54, 0x00, 0x00, 0x00, 0x23, 0xAE, 0x04, 0x00, 0x22, 0xAE, 0x00, 0x12, 0x13, 0x00, 0x25, 0x10, 0x52, 0x00, 0x08, 0x00, 0x22, 0xAE, 0x28, 0x26, 0x60, 0x72, 0x9C, 0x37, 0x09, 0x0C, 0x28, 0x2E, 0x40, 0x72, 0x00, 0x1C, 0x02, 0x00, 0xFF, 0x3F, 0x02, 0x32, 0x25, 0x10, 0x43, 0x00, 0x0A, 0x00, 0x00, 0x10, 0x0C, 0x00, 0x22, 0xAE, 0x00, 0x12, 0x15, 0x00, 0x24, 0x00, 0x04, 0x24, 0x25, 0x18, 0x54, 0x00, 0x00, 0x12, 0x13, 0x00, 0x00, 0x00, 0x24, 0xAE, 0x25, 0x10, 0x52, 0x00, 0x04, 0x00, 0x23, 0xAE, 0x08, 0x00, 0x22, 0xAE, 0x0C, 0x00, 0x30, 0xAE, 0x0B, 0x00, 0x00, 0x10, 0x01, 0x00, 0x02, 0x24, 0x00, 0x12, 0x15, 0x00, 0x5F, 0x00, 0x04, 0x24, 0x25, 0x18, 0x54, 0x00, 0x00, 0x12, 0x13, 0x00, 0x00, 0x00, 0x24, 0xAE, 0x25, 0x10, 0x52, 0x00, 0x04, 0x00, 0x23, 0xAE, 0x08, 0x00, 0x22, 0xAE, 0x01, 0x00, 0x02, 0x24, 0x0C, 0x00, 0x20, 0xAE, 0x60, 0x00, 0xBF, 0x7B, 0x50, 0x00, 0xB5, 0x7B, 0x40, 0x00, 0xB4, 0x7B, 0x30, 0x00, 0xB3, 0x7B, 0x20, 0x00, 0xB2, 0x7B, 0x10, 0x00, 0xB1, 0x7B, 0x00, 0x00, 0xB0, 0x7B, 0x08, 0x00, 0xE0, 0x03, 0x70, 0x00, 0xBD, 0x27, 0x00, 0x00, 0x00, 0x00 },
            Patch = new byte[972] { 0x02, 0x00, 0x19, 0x24, 0xc0, 0x81, 0x07, 0x0c, 0x00, 0x00, 0x00, 0x00, 0x43, 0x81, 0x02, 0x00, 0x28, 0x26, 0x60, 0x72, 0xc0, 0x81, 0x07, 0x0c, 0x28, 0x2e, 0x40, 0x72, 0x25, 0x00, 0x19, 0x12, 0x43, 0x19, 0x02, 0x00, 0x23, 0x00, 0x79, 0x10, 0x00, 0x00, 0x00, 0x00, 0x0d, 0x00, 0x80, 0x16, 0x28, 0x26, 0xa0, 0x72, 0x00, 0x12, 0x13, 0x00, 0x5f, 0x00, 0x04, 0x24, 0x25, 0x18, 0x52, 0x00, 0x00, 0x12, 0x15, 0x00, 0x00, 0x00, 0x24, 0xae, 0x25, 0x10, 0x54, 0x00, 0x04, 0x00, 0x23, 0xae, 0x08, 0x00, 0x22, 0xae, 0x01, 0x00, 0x02, 0x24, 0xd3, 0x00, 0x00, 0x10, 0x0c, 0x00, 0x22, 0xae, 0x28, 0x26, 0xa0, 0x72, 0x0c, 0x84, 0x07, 0x0c, 0x28, 0x2e, 0x80, 0x72, 0x28, 0x86, 0x40, 0x70, 0x28, 0x26, 0x60, 0x72, 0x0c, 0x84, 0x07, 0x0c, 0x28, 0x2e, 0x40, 0x72, 0x28, 0x26, 0x00, 0x72, 0x68, 0x25, 0x09, 0x0c, 0x28, 0x2e, 0x40, 0x70, 0x00, 0x1a, 0x15, 0x00, 0x64, 0x00, 0x05, 0x24, 0x25, 0x20, 0x74, 0x00, 0x00, 0x1a, 0x13, 0x00, 0x00, 0x00, 0x25, 0xae, 0x25, 0x18, 0x72, 0x00, 0x04, 0x00, 0x24, 0xae, 0x08, 0x00, 0x23, 0xae, 0x0c, 0x00, 0x22, 0xae, 0xbe, 0x00, 0x00, 0x10, 0x01, 0x00, 0x02, 0x24, 0x5b, 0x00, 0x00, 0x16, 0x02, 0x00, 0x02, 0x24, 0x02, 0x00, 0x02, 0x24, 0x57, 0x00, 0x62, 0x14, 0x00, 0x00, 0x00, 0x00, 0x0d, 0x00, 0x80, 0x16, 0x28, 0x26, 0x60, 0x72, 0x00, 0x12, 0x13, 0x00, 0x5f, 0x00, 0x04, 0x24, 0x25, 0x18, 0x52, 0x00, 0x00, 0x12, 0x15, 0x00, 0x00, 0x00, 0x24, 0xae, 0x25, 0x10, 0x54, 0x00, 0x04, 0x00, 0x23, 0xae, 0x08, 0x00, 0x22, 0xae, 0x01, 0x00, 0x02, 0x24, 0xac, 0x00, 0x00, 0x10, 0x0c, 0x00, 0x22, 0xae, 0x28, 0x26, 0x60, 0x72, 0x0c, 0x84, 0x07, 0x0c, 0x28, 0x2e, 0x40, 0x72, 0x28, 0x26, 0xa0, 0x72, 0x28, 0x2e, 0x80, 0x72, 0xbc, 0x22, 0x09, 0x0c, 0x28, 0x36, 0x40, 0x70, 0xe7, 0x03, 0x05, 0x24, 0x28, 0x86, 0x40, 0x70, 0x0d, 0x00, 0x05, 0x16, 0x83, 0x17, 0x10, 0x00, 0x00, 0x12, 0x15, 0x00, 0x24, 0x00, 0x04, 0x24, 0x25, 0x18, 0x54, 0x00, 0x00, 0x12, 0x13, 0x00, 0x00, 0x00, 0x24, 0xae, 0x25, 0x10, 0x52, 0x00, 0x04, 0x00, 0x23, 0xae, 0x08, 0x00, 0x22, 0xae, 0x01, 0x00, 0x02, 0x24, 0x96, 0x00, 0x00, 0x10, 0x0c, 0x00, 0x25, 0xae, 0x83, 0x17, 0x10, 0x00, 0x01, 0x00, 0x43, 0x30, 0x01, 0x00, 0x02, 0x24, 0x10, 0x00, 0x62, 0x14, 0x19, 0x02, 0x02, 0x24, 0x00, 0x12, 0x13, 0x00, 0x25, 0x20, 0x52, 0x00, 0x2b, 0x00, 0x05, 0x24, 0x00, 0x12, 0x15, 0x00, 0x25, 0x18, 0x54, 0x00, 0x00, 0x00, 0x25, 0xae, 0x83, 0x13, 0x10, 0x00, 0x04, 0x00, 0x24, 0xae, 0xff, 0x3f, 0x42, 0x30, 0x08, 0x00, 0x23, 0xae, 0x0c, 0x00, 0x22, 0xae, 0x01, 0x00, 0x02, 0x3c, 0x83, 0x00, 0x00, 0x10, 0x01, 0x00, 0x42, 0x34, 0x19, 0x02, 0x02, 0x24, 0x83, 0x1b, 0x10, 0x00, 0x12, 0x00, 0x62, 0x14, 0x00, 0x12, 0x15, 0x00, 0x25, 0x00, 0x03, 0x24, 0x00, 0x00, 0x23, 0xae, 0x00, 0x1a, 0x15, 0x00, 0x00, 0x12, 0x13, 0x00, 0x25, 0x18, 0x74, 0x00, 0x25, 0x10, 0x52, 0x00, 0x04, 0x00, 0x23, 0xae, 0x08, 0x00, 0x22, 0xae, 0x28, 0x26, 0xa0, 0x72, 0x9c, 0x37, 0x09, 0x0c, 0x28, 0x2e, 0x80, 0x72, 0x00, 0x1c, 0x02, 0x00, 0xff, 0x3f, 0x02, 0x32, 0x25, 0x10, 0x43, 0x00, 0x0a, 0x00, 0x00, 0x10, 0x0c, 0x00, 0x22, 0xae, 0x00, 0x12, 0x15, 0x00, 0x24, 0x00, 0x04, 0x24, 0x25, 0x18, 0x54, 0x00, 0x00, 0x12, 0x13, 0x00, 0x00, 0x00, 0x24, 0xae, 0x25, 0x10, 0x52, 0x00, 0x04, 0x00, 0x23, 0xae, 0x08, 0x00, 0x22, 0xae, 0x0c, 0x00, 0x30, 0xae, 0x01, 0x00, 0x02, 0x3c, 0x63, 0x00, 0x00, 0x10, 0x01, 0x00, 0x42, 0x34, 0x02, 0x00, 0x02, 0x24, 0x57, 0x00, 0x02, 0x16, 0x00, 0x12, 0x15, 0x00, 0x54, 0x00, 0x60, 0x14, 0x00, 0x00, 0x00, 0x00, 0x0d, 0x00, 0x40, 0x16, 0x28, 0x26, 0xa0, 0x72, 0x00, 0x12, 0x15, 0x00, 0x5f, 0x00, 0x04, 0x24, 0x25, 0x18, 0x54, 0x00, 0x00, 0x12, 0x13, 0x00, 0x00, 0x00, 0x24, 0xae, 0x25, 0x10, 0x52, 0x00, 0x04, 0x00, 0x23, 0xae, 0x08, 0x00, 0x22, 0xae, 0x01, 0x00, 0x02, 0x24, 0x51, 0x00, 0x00, 0x10, 0x0c, 0x00, 0x20, 0xae, 0x28, 0x26, 0xa0, 0x72, 0x0c, 0x84, 0x07, 0x0c, 0x28, 0x2e, 0x80, 0x72, 0x28, 0x26, 0x60, 0x72, 0x28, 0x2e, 0x40, 0x72, 0xbc, 0x22, 0x09, 0x0c, 0x28, 0x36, 0x40, 0x70, 0xe7, 0x03, 0x05, 0x24, 0x28, 0x86, 0x40, 0x70, 0x0d, 0x00, 0x05, 0x16, 0x83, 0x17, 0x10, 0x00, 0x00, 0x12, 0x15, 0x00, 0x24, 0x00, 0x04, 0x24, 0x25, 0x18, 0x54, 0x00, 0x00, 0x12, 0x13, 0x00, 0x00, 0x00, 0x24, 0xae, 0x25, 0x10, 0x52, 0x00, 0x04, 0x00, 0x23, 0xae, 0x08, 0x00, 0x22, 0xae, 0x01, 0x00, 0x02, 0x24, 0x3b, 0x00, 0x00, 0x10, 0x0c, 0x00, 0x25, 0xae, 0x83, 0x17, 0x10, 0x00, 0x01, 0x00, 0x43, 0x30, 0x01, 0x00, 0x02, 0x24, 0x0e, 0x00, 0x62, 0x54, 0x19, 0x02, 0x02, 0x24, 0x00, 0x1a, 0x15, 0x00, 0x25, 0x28, 0x74, 0x00, 0x2b, 0x00, 0x06, 0x24, 0x00, 0x1a, 0x13, 0x00, 0x25, 0x20, 0x72, 0x00, 0x00, 0x00, 0x26, 0xae, 0x83, 0x1b, 0x10, 0x00, 0x04, 0x00, 0x25, 0xae, 0xff, 0x3f, 0x63, 0x30, 0x08, 0x00, 0x24, 0xae, 0x2a, 0x00, 0x00, 0x10, 0x0c, 0x00, 0x23, 0xae, 0x19, 0x02, 0x02, 0x24, 0x83, 0x1b, 0x10, 0x00, 0x12, 0x00, 0x62, 0x14, 0x00, 0x12, 0x15, 0x00, 0x25, 0x00, 0x03, 0x24, 0x00, 0x12, 0x15, 0x00, 0x25, 0x10, 0x54, 0x00, 0x00, 0x00, 0x23, 0xae, 0x04, 0x00, 0x22, 0xae, 0x00, 0x12, 0x13, 0x00, 0x25, 0x10, 0x52, 0x00, 0x08, 0x00, 0x22, 0xae, 0x28, 0x26, 0x60, 0x72, 0x9c, 0x37, 0x09, 0x0c, 0x28, 0x2e, 0x40, 0x72, 0x00, 0x1c, 0x02, 0x00, 0xff, 0x3f, 0x02, 0x32, 0x25, 0x10, 0x43, 0x00, 0x0a, 0x00, 0x00, 0x10, 0x0c, 0x00, 0x22, 0xae, 0x00, 0x12, 0x15, 0x00, 0x24, 0x00, 0x04, 0x24, 0x25, 0x18, 0x54, 0x00, 0x00, 0x12, 0x13, 0x00, 0x00, 0x00, 0x24, 0xae, 0x25, 0x10, 0x52, 0x00, 0x04, 0x00, 0x23, 0xae, 0x08, 0x00, 0x22, 0xae, 0x0c, 0x00, 0x30, 0xae, 0x0b, 0x00, 0x00, 0x10, 0x01, 0x00, 0x02, 0x24, 0x00, 0x12, 0x15, 0x00, 0x5f, 0x00, 0x04, 0x24, 0x25, 0x18, 0x54, 0x00, 0x00, 0x12, 0x13, 0x00, 0x00, 0x00, 0x24, 0xae, 0x25, 0x10, 0x52, 0x00, 0x04, 0x00, 0x23, 0xae, 0x08, 0x00, 0x22, 0xae, 0x01, 0x00, 0x02, 0x24, 0x0c, 0x00, 0x20, 0xae, 0x60, 0x00, 0xbf, 0x7b, 0x50, 0x00, 0xb5, 0x7b, 0x40, 0x00, 0xb4, 0x7b, 0x30, 0x00, 0xb3, 0x7b, 0x20, 0x00, 0xb2, 0x7b, 0x10, 0x00, 0xb1, 0x7b, 0x00, 0x00, 0xb0, 0x7b, 0x08, 0x00, 0xe0, 0x03, 0x70, 0x00, 0xbd, 0x27 }
        };

        public static PatchByteSequences ChangeReincarnationAmount = new PatchByteSequences
        {
            Offset = 0x1f8290,
            Original = new byte[4] { 0x05, 0x00, 0xa5, 0x28 },
            Patch = new byte[4] { 0x05, 0x00, 0xa5, 0x28 }
        };



        public static PatchByteSequences FixAiInput1 = new PatchByteSequences
        {
            Offset = 0x00246400,
            Original = new byte[8] { 0xff, 0xff, 0x8a, 0x32, 0xff, 0x00, 0x83, 0x32 },
            Patch = new byte[8] { 0x40, 0x80, 0x0d, 0x08, 0x00, 0x00, 0x00, 0x00 }
        };
        public static PatchByteSequences FixAiInput2 = new PatchByteSequences
        {
            //Replace offsets with moving to Tutorial offsets
            Offset = 0x000,
            Original = new byte[1] { 0x00 },
            Patch = new byte[156] { 0x02, 0x00, 0x03, 0x92, 0x06, 0x00, 0x0b, 0x24, 0x21, 0x00, 0x6b, 0x14, 0x00, 0x00, 0x00, 0x00, 0xff, 0x00, 0x4c, 0x30, 0x04, 0x00, 0x0d, 0x96, 0xff, 0x00, 0xb8, 0x31, 0x23, 0x70, 0x98, 0x01, 0x1b, 0x00, 0xc0, 0x15, 0x00, 0x00, 0x00, 0x00, 0x03, 0x62, 0x02, 0x00, 0x03, 0xc2, 0x0d, 0x00, 0x22, 0x70, 0x98, 0x01, 0x16, 0x00, 0xc0, 0x15, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0c, 0x00, 0x0d, 0x8e, 0x01, 0x00, 0x09, 0x24, 0x0f, 0x00, 0xa9, 0x11, 0x02, 0x00, 0x09, 0x24, 0x10, 0x00, 0x0d, 0x92, 0x0c, 0x00, 0xa9, 0x15, 0x00, 0x00, 0x00, 0x00, 0x50, 0x7d, 0x07, 0x0c, 0x00, 0x00, 0x00, 0x00, 0x57, 0x00, 0x4d, 0x80, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0xad, 0x35, 0x57, 0x00, 0x4d, 0xa0, 0x60, 0x01, 0x28, 0x26, 0x20, 0x00, 0x09, 0x24, 0x00, 0x00, 0x09, 0xa5, 0xc1, 0xda, 0x09, 0x08, 0x00, 0x00, 0x00, 0x00, 0xff, 0xff, 0x8a, 0x32, 0xff, 0x00, 0x83, 0x32, 0xc2, 0xd8, 0x09, 0x08 }
        };


        public void applyPatch(PatchByteSequences patch)
        {
            this.dataAccess.ApplyPatch(patch.Offset, patch.Patch);
        }

        public void undoPatch(PatchByteSequences patch)
        {
            this.dataAccess.ApplyPatch(patch.Offset, patch.Original);

        }
        public bool CheckIfPatchApplied(PatchByteSequences patch)
        {
            return dataAccess.CheckIfPatchApplied(patch.Offset, patch.Patch);
        }

    }

}