using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


<<<<<<< HEAD
namespace ROM {
    [StructLayout(LayoutKind.Sequential,Size=64,Pack=1)]
    public struct _romHeader {
=======
namespace ROM
{
    [StructLayout(LayoutKind.Sequential,Size=64,Pack=1)]
    public struct _romHeader
    {
>>>>>>> 9e5bb24e7c7465ad3fbc7de7fd71d8a195a1c8b7
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
        public char[] ROMName;
        [MarshalAs(UnmanagedType.U1)]
        public byte ROMLayout;
        [MarshalAs(UnmanagedType.U1)]
        public byte ROMType;
        [MarshalAs(UnmanagedType.U1)]
        public byte ROMSize;
        [MarshalAs(UnmanagedType.U1)]
        public byte RAMSize;
        [MarshalAs(UnmanagedType.U1)]
        public byte CountryCode;
        [MarshalAs(UnmanagedType.U1)]
        public byte License;
        [MarshalAs(UnmanagedType.U1)]
        public byte Version;
        [MarshalAs(UnmanagedType.U2)]
        public ushort ChecksumComplement;
        [MarshalAs(UnmanagedType.U2)]
        public ushort Checksum;
        [MarshalAs(UnmanagedType.U4)]
        public uint NatUnknown;
        [MarshalAs(UnmanagedType.U2)]
        public ushort NatCOP;
        [MarshalAs(UnmanagedType.U2)]
        public ushort NatBRK;
        [MarshalAs(UnmanagedType.U2)]
        public ushort NatABORT;
        [MarshalAs(UnmanagedType.U2)]
        public ushort NatNMI;
        [MarshalAs(UnmanagedType.U2)]
        public ushort NatUnused;
        [MarshalAs(UnmanagedType.U2)]
        public ushort NatIRQ;
        [MarshalAs(UnmanagedType.U4)]
        public uint EmuUnknown;
        [MarshalAs(UnmanagedType.U2)]
        public ushort EmuCOP;
        [MarshalAs(UnmanagedType.U2)]
        public ushort EmuUnused;
        [MarshalAs(UnmanagedType.U2)]
        public ushort EmuABORT;
        [MarshalAs(UnmanagedType.U2)]
        public ushort EmuNMI;
        [MarshalAs(UnmanagedType.U2)]
        public ushort EmuRESET;
        [MarshalAs(UnmanagedType.U2)]
        public ushort EmuIRQ;
    }
    [StructLayout(LayoutKind.Sequential,Size =16,Pack =1)]
<<<<<<< HEAD
    public struct _extendedHeader {
=======
    public struct _extendedHeader
    {
>>>>>>> 9e5bb24e7c7465ad3fbc7de7fd71d8a195a1c8b7
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public char[] License;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public char[] Gamecode;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public byte[] Reserved;
        [MarshalAs(UnmanagedType.U1)]
        public byte ExpansionFLASHSize;
        [MarshalAs(UnmanagedType.U1)]
        public byte ExpansionRAMSize;
        [MarshalAs(UnmanagedType.U1)]
        public byte SpecialVersion;
        [MarshalAs(UnmanagedType.U1)]
        public byte Chipset;
    }
<<<<<<< HEAD
    public class ROMHeader {
=======
    public class ROMHeader
    {
>>>>>>> 9e5bb24e7c7465ad3fbc7de7fd71d8a195a1c8b7
        private _romHeader header;
        private _extendedHeader exHeader;

        private const ushort HEADER_LOC_LOROM = 0x7FC0;
        private const ushort HEADER_LOC_HIROM = 0xFFC0;
        private const byte LAYOUT_HIROM = 0x01;
        private const byte LAYOUT_EXHIROM = 0x04;
        private const byte LAYOUT_FASTROM = 0x10;
<<<<<<< HEAD
        public ROMHeader() {
            header = new _romHeader();
            exHeader = new _extendedHeader();
        }
        public ROMHeader(byte[] data) {
            LoadFromBytes(data);
        }
        #region Properties
        public string ROMName {
            get { return new string(header.ROMName); }
        }
        public byte ROMLayout {
            get { return header.ROMLayout; }
        }
        public byte ROMType {
            get { return header.ROMType; }
        }
        public byte ROMSize {
            get { return header.ROMSize; }
        }
        public byte RAMSize {
            get { return header.RAMSize; }
        }
        public byte CountryCode {
            get { return header.CountryCode; }
        }
        public byte License {
            get { return header.License; }
        }
        public byte Version {
            get { return header.Version; }
        }
        public ushort ChecksumComplement {
            get { return header.ChecksumComplement; }
        }
        public ushort Checksum {
            get { return header.Checksum; }
        }
        public ushort NatCOP {
            get { return header.NatCOP; }
        }
        public ushort NatBRK {
            get { return header.NatBRK; }
        }
        public ushort NatABORT {
            get { return header.NatABORT; }
        }
        public ushort NatNMI {
            get { return header.NatNMI; }
        }
        public ushort NatIRQ {
            get { return header.NatIRQ; }
        }
        public ushort EmuCOP {
            get { return header.EmuCOP; }
        }
        public ushort EmuABORT {
            get { return header.EmuABORT; }
        }
        public ushort EmuNMI {
            get { return header.EmuNMI; }
        }
        public ushort EmuRESET {
            get { return header.EmuRESET; }
        }
        public ushort EmuIRQ {
            get { return header.EmuIRQ; }
        }
        public string ExtendedLicense {
            get { return new string(exHeader.License); }
        }
        public string ExtendedGamecode {
            get { return new string(exHeader.Gamecode); }
        }
        public byte ExpansionFLASHSize {
            get { return exHeader.ExpansionFLASHSize; }
        }
        public byte ExpansionRAMSize {
            get { return exHeader.ExpansionRAMSize; }
        }
        public byte ExtendedVersion {
            get { return exHeader.SpecialVersion; }
        }
        public byte ExtendedChipset {
=======
        public ROMHeader()
        {
            header = new _romHeader();
            exHeader = new _extendedHeader();
        }
        public ROMHeader(byte[] data)
        {
            LoadFromBytes(data);
        }
        #region Properties
        public string ROMName
        {
            get { return new string(header.ROMName); }
        }
        public byte ROMLayout
        {
            get { return header.ROMLayout; }
        }
        public byte ROMType
        {
            get { return header.ROMType; }
        }
        public byte ROMSize
        {
            get { return header.ROMSize; }
        }
        public byte RAMSize
        {
            get { return header.RAMSize; }
        }
        public byte CountryCode
        {
            get { return header.CountryCode; }
        }
        public byte License
        {
            get { return header.License; }
        }
        public byte Version
        {
            get { return header.Version; }
        }
        public ushort ChecksumComplement
        {
            get { return header.ChecksumComplement; }
        }
        public ushort Checksum
        {
            get { return header.Checksum; }
        }
        public ushort NatCOP
        {
            get { return header.NatCOP; }
        }
        public ushort NatBRK
        {
            get { return header.NatBRK; }
        }
        public ushort NatABORT
        {
            get { return header.NatABORT; }
        }
        public ushort NatNMI
        {
            get { return header.NatNMI; }
        }
        public ushort NatIRQ
        {
            get { return header.NatIRQ; }
        }
        public ushort EmuCOP
        {
            get { return header.EmuCOP; }
        }
        public ushort EmuABORT
        {
            get { return header.EmuABORT; }
        }
        public ushort EmuNMI
        {
            get { return header.EmuNMI; }
        }
        public ushort EmuRESET
        {
            get { return header.EmuRESET; }
        }
        public ushort EmuIRQ
        {
            get { return header.EmuIRQ; }
        }
        public string ExtendedLicense
        {
            get { return new string(exHeader.License); }
        }
        public string ExtendedGamecode
        {
            get { return new string(exHeader.Gamecode); }
        }
        public byte ExpansionFLASHSize
        {
            get { return exHeader.ExpansionFLASHSize; }
        }
        public byte ExpansionRAMSize
        {
            get { return exHeader.ExpansionRAMSize; }
        }
        public byte ExtendedVersion
        {
            get { return exHeader.SpecialVersion; }
        }
        public byte ExtendedChipset
        {
>>>>>>> 9e5bb24e7c7465ad3fbc7de7fd71d8a195a1c8b7
            get { return exHeader.SpecialVersion; }
        }
        #endregion

        #region Private Members
<<<<<<< HEAD
        private void LoadFromBytes(byte[] data) {
=======
        private void LoadFromBytes(byte[] data)
        {
>>>>>>> 9e5bb24e7c7465ad3fbc7de7fd71d8a195a1c8b7
            _romHeader loheader = new _romHeader();
            _extendedHeader loextended = new _extendedHeader();
            _romHeader hiheader = new _romHeader();
            _extendedHeader hiextended = new _extendedHeader();
            GCHandle handle = GCHandle.Alloc(data, GCHandleType.Pinned);
            IntPtr dataptr = handle.AddrOfPinnedObject();
            loextended = (_extendedHeader)Marshal.PtrToStructure(IntPtr.Add(dataptr, HEADER_LOC_LOROM - 0x10), typeof(_extendedHeader));
            loheader = (_romHeader)Marshal.PtrToStructure(IntPtr.Add(dataptr, HEADER_LOC_LOROM), typeof(_romHeader));
            hiextended = (_extendedHeader)Marshal.PtrToStructure(IntPtr.Add(dataptr, HEADER_LOC_HIROM - 0x10), typeof(_extendedHeader));
            hiheader = (_romHeader)Marshal.PtrToStructure(IntPtr.Add(dataptr, HEADER_LOC_HIROM), typeof(_romHeader));
            handle.Free();
<<<<<<< HEAD
            if(ScoreLOROM(loheader,loextended,data.Length) > ScoreHIROM(hiheader,hiextended,data.Length)) {
                header = loheader;
                exHeader = loextended;
            }
            else {
=======
            if(ScoreLOROM(loheader,loextended,data.Length) > ScoreHIROM(hiheader,hiextended,data.Length))
            {
                header = loheader;
                exHeader = loextended;
            }
            else
            {
>>>>>>> 9e5bb24e7c7465ad3fbc7de7fd71d8a195a1c8b7
                header = hiheader;
                exHeader = hiextended;
            }
        }

<<<<<<< HEAD
        private int ScoreLOROM(_romHeader loheader,_extendedHeader loextended, int romlength) {
=======
        private int ScoreLOROM(_romHeader loheader,_extendedHeader loextended, int romlength)
        {
>>>>>>> 9e5bb24e7c7465ad3fbc7de7fd71d8a195a1c8b7
            int score = 0;
            if ((loheader.ROMLayout & LAYOUT_HIROM) == 0) score += 3;
            if ((loheader.ROMLayout & 0x0F) < 4) score += 2;
            if (loheader.ROMLayout == 0x23) score += 2;
            if (loheader.ROMName[20] == 0x20) score += 2;
<<<<<<< HEAD
            if ((loheader.Checksum ^ loheader.ChecksumComplement) == 0xFFFF) {
=======
            if ((loheader.Checksum ^ loheader.ChecksumComplement) == 0xFFFF)
            {
>>>>>>> 9e5bb24e7c7465ad3fbc7de7fd71d8a195a1c8b7
                score += 2;
                if (loheader.Checksum != 0) score++;
            }
            if (loheader.License == 0x33) score += 2;
            if ((loheader.EmuRESET & 0x8000) == 0) score -= 6;
            if (loheader.EmuRESET > 0xFFB0) score -= 2;
            if (romlength <= 0x2FFFFF) score += 4;
            if (Math.Pow(2, loheader.ROMSize - 7) > 48) score--;
            if (!AllASCII(loextended.License) && !AllASCII(loextended.Gamecode)) score--;
            if (!AllASCII(loheader.ROMName)) score--;
            return score;
        }

<<<<<<< HEAD
        private int ScoreHIROM(_romHeader hiheader,_extendedHeader hiextended, int romlength) {
=======
        private int ScoreHIROM(_romHeader hiheader,_extendedHeader hiextended, int romlength)
        {
>>>>>>> 9e5bb24e7c7465ad3fbc7de7fd71d8a195a1c8b7
            int score = 0;
            if ((hiheader.ROMLayout & LAYOUT_HIROM) != 0) score += 2;
            if ((hiheader.ROMLayout & 0x0F) < 4) score += 2;
            if (hiheader.ROMLayout == 0x23) score -= 2;
            if (hiheader.ROMName[20] == 0x20) score += 2;
<<<<<<< HEAD
            if ((hiheader.Checksum ^ hiheader.ChecksumComplement) == 0xFFFF) {
=======
            if ((hiheader.Checksum ^ hiheader.ChecksumComplement) == 0xFFFF)
            {
>>>>>>> 9e5bb24e7c7465ad3fbc7de7fd71d8a195a1c8b7
                score += 2;
                if (hiheader.Checksum != 0) score++;
            }
            if (hiheader.License == 0x33) score += 2;
            if ((hiheader.EmuRESET & 0x8000) == 0) score -= 6;
            if (hiheader.EmuRESET > 0xFFB0) score -= 2;
            if (romlength > 0x2FFFFF) score += 4;
            if (Math.Pow(2, hiheader.ROMSize - 7) > 48) score--;
            if (!AllASCII(hiextended.License) && !AllASCII(hiextended.Gamecode)) score--;
            if (!AllASCII(hiheader.ROMName)) score--;
            return score;
        }

<<<<<<< HEAD
        private bool AllASCII(char[] array) {
            for(int i=0;i<array.Length;i++) {
=======
        private bool AllASCII(char[] array)
        {
            for(int i=0;i<array.Length;i++)
            {
>>>>>>> 9e5bb24e7c7465ad3fbc7de7fd71d8a195a1c8b7
                if (array[i] < 0x20 || array[i] > 0x7E) return false;
            }
            return true;
        }
        #endregion
    }
}
