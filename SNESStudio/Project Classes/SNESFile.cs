using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace SNESStudio {
    public enum SNESFileType {
        Source,
        Header,
        Graphics,
        Palette,
        Map,
        Binary,
        ROM
    }
    public class SNESFile {
        private string filename;
        private string path;
        private SNESFileType type;
        [NonSerialized]
        private bool hasChanged;
        public SNESFile() : this("newfile.asm",".\\",SNESFileType.Source) {
            hasChanged = false;
        }
        public SNESFile(string filename, string path,SNESFileType type) {
            this.filename = filename;
            this.path = path;
            this.type = type;
            hasChanged = false;
        }
        public string FileName {
            get { return filename; }
            set { filename = value; }
        }
        public string Path {
            get { return path; }
            set { path = value; }
        }
        public SNESFileType SNESType {
            get { return type; }
            set { type = value; }
        }
        [XmlIgnore]
        public bool HasChanged {
            get { return hasChanged; }
            set { hasChanged = value; }
        }
    }
}
