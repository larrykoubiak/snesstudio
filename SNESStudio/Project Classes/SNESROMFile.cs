using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ROM;

namespace SNESStudio
{
    class SNESROMFile : SNESFile
    {
        [NonSerialized]
        private ROMImage rom;
        #region Constructor
        public SNESROMFile() : base()
        {
            rom = new ROMImage();
        }
        public SNESROMFile(SNESFile file)
        {
            this.FileName = file.FileName;
            this.Path = file.Path;
            this.SNESType = file.SNESType;
            this.HasChanged = file.HasChanged;
            rom = new ROMImage(this.Path);
        }
        #endregion
        #region Properties
        [System.Xml.Serialization.XmlIgnore]
        public ROMImage ROM
        {
            get { return rom; }
        } 
        #endregion
    }
}
