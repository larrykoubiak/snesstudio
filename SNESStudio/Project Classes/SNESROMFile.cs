using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine;

namespace SNESStudio {
    class SNESROMFile : SNESFile {
        #region Constructor
        public SNESROMFile() : base() {
        }
        public SNESROMFile(SNESFile file) {
            this.FileName = file.FileName;
            this.Path = file.Path;
            this.SNESType = file.SNESType;
            this.HasChanged = file.HasChanged;
        }
        #endregion
    }
}
