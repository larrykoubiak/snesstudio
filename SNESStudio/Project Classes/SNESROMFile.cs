using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
<<<<<<< HEAD
using Machine;

namespace SNESStudio {
    class SNESROMFile : SNESFile {
        #region Constructor
        public SNESROMFile() : base() {
        }
        public SNESROMFile(SNESFile file) {
=======
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
>>>>>>> 9e5bb24e7c7465ad3fbc7de7fd71d8a195a1c8b7
            this.FileName = file.FileName;
            this.Path = file.Path;
            this.SNESType = file.SNESType;
            this.HasChanged = file.HasChanged;
<<<<<<< HEAD
        }
        #endregion
=======
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
>>>>>>> 9e5bb24e7c7465ad3fbc7de7fd71d8a195a1c8b7
    }
}
