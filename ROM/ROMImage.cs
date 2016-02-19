using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
<<<<<<< HEAD
using System.ComponentModel;

namespace ROM {
    public class ROMImage {
=======

namespace ROM
{
    public class ROMImage
    {
>>>>>>> 9e5bb24e7c7465ad3fbc7de7fd71d8a195a1c8b7
        private const byte LAYOUT_HIROM = 0x01;
        private const byte LAYOUT_EXHIROM = 0x04;
        private const byte LAYOUT_FASTROM = 0x10;
        private byte[] data;
        private ROMHeader header;
        private DataSet ds;

<<<<<<< HEAD
        public ROMImage() {
            data = null;
            header = null;
            ds = new DataSet();
            ds.ReadXml("ROMHeader.xml");
        }
        public ROMImage(string filename) {
=======
        public ROMImage()
        {
            data = null;
            ds = new DataSet();
            ds.ReadXml("ROMHeader.xml");
        }
        public ROMImage(string filename)
        {
>>>>>>> 9e5bb24e7c7465ad3fbc7de7fd71d8a195a1c8b7
            data = File.ReadAllBytes(filename);
            header = new ROMHeader(data);
            ds = new DataSet();
            ds.ReadXml("ROMHeader.xml");
        }
<<<<<<< HEAD
        
        [Browsable(false)]
        public byte this[uint index] {
        	get { return data[index]; }
        }
        public string ROMName {
            get { return header.ROMName; }
        }
        public string Layout {
            get {
                string strLayout;
                if ((header.ROMLayout & LAYOUT_EXHIROM) > 0)
                    strLayout = "Ex";
                else 
                	strLayout = "";
                if ((header.ROMLayout & LAYOUT_HIROM) > 0)
                    strLayout += "HiRom";
                else 
                	strLayout += "LoRom";
                return strLayout;
            }
        }
        public string Speed {
            get {
                if ((header.ROMLayout & LAYOUT_FASTROM) > 0)
                    return "Fast";
                else 
                	return "Slow";
            }
        }
        public string Chipset {
            get { return ds.Tables["Chipset"].Select("ChipsetId = '" + header.ROMType + "'")[0].Field<string>("ChipsetDescription"); }
        }
        public string RAMSize {
            get { return ds.Tables["Size"].Select("SizeId = '" + header.RAMSize.ToString() + "'")[0].Field<string>("SizeDescription"); }
        }
        public string ROMSize {
            get { return ds.Tables["Size"].Select("SizeId = '" + header.ROMSize.ToString() + "'")[0].Field<string>("SizeDescription"); }
        }
        public string Country {
            get { return ds.Tables["Country"].Select("CountryId= '" + header.CountryCode.ToString() + "'")[0].Field<string>("CountryDescription"); }
        }
        public string VideoMode {
            get { return ds.Tables["Country"].Select("CountryId= '" + header.CountryCode.ToString() + "'")[0].Field<string>("CountryVideoMode"); }
        }
        public string License {
            get {
                if (header.License == 0x33) {
                    return ds.Tables["License"].Select("LicenseId= '" + Convert.ToInt32(header.ExtendedLicense, 16).ToString() + "'")[0].Field<string>("LicenseDescription");
                }
                else {
=======
        public byte[] Data
        {
            get { return data; }
            set { data = value; }
        }
        public string ROMName
        {
            get { return header.ROMName; }
        }
        public string Layout
        {
            get
            {
                string strLayout;
                if ((header.ROMLayout & LAYOUT_EXHIROM) > 0)
                    strLayout = "Ex";
                else strLayout = "";
                if ((header.ROMLayout & LAYOUT_HIROM) > 0)
                    strLayout += "HiRom";
                else strLayout += "LoRom";
                return strLayout;
            }
        }
        public string Speed
        {
            get
            {
                if ((header.ROMLayout & LAYOUT_FASTROM) > 0)
                    return "Fast";
                else return "Slow";
            }
        }
        public string Chipset
        {
            get { return ds.Tables["Chipset"].Select("ChipsetId = '" + header.ROMType + "'")[0].Field<string>("ChipsetDescription"); }
        }
        public string RAMSize
        {
            get { return ds.Tables["Size"].Select("SizeId = '" + header.RAMSize.ToString() + "'")[0].Field<string>("SizeDescription"); }
        }
        public string ROMSize
        {
            get { return ds.Tables["Size"].Select("SizeId = '" + header.ROMSize.ToString() + "'")[0].Field<string>("SizeDescription"); }
        }
        public string Country
        {
            get { return ds.Tables["Country"].Select("CountryId= '" + header.CountryCode.ToString() + "'")[0].Field<string>("CountryDescription"); }
        }
        public string VideoMode
        {
            get { return ds.Tables["Country"].Select("CountryId= '" + header.CountryCode.ToString() + "'")[0].Field<string>("CountryVideoMode"); }
        }
        public string License
        {
            get
            {
                if (header.License == 0x33)
                {
                    return ds.Tables["License"].Select("LicenseId= '" + Convert.ToInt32(header.ExtendedLicense, 16).ToString() + "'")[0].Field<string>("LicenseDescription");
                }
                else
                {
>>>>>>> 9e5bb24e7c7465ad3fbc7de7fd71d8a195a1c8b7
                    return ds.Tables["License"].Select("LicenseId= '" + header.License.ToString() + "'")[0].Field<string>("LicenseDescription");
                }
            }
        }
<<<<<<< HEAD
        public string Version {
            get { return header.Version.ToString(); }
        }
        public ushort ResetVector {
            get { return header.EmuRESET; }
        }
        public ushort NMIVector {
            get { return header.NatNMI; }
        }
        public ushort IRQVector {
=======
        public string Version
        {
            get { return header.Version.ToString(); }
        }
        public ushort ResetVector
        {
            get { return header.EmuRESET; }
        }
        public ushort NMIVector
        {
            get { return header.NatNMI; }
        }
        public ushort IRQVector
        {
>>>>>>> 9e5bb24e7c7465ad3fbc7de7fd71d8a195a1c8b7
            get { return header.NatIRQ; }
        }
    }
}
