using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

<<<<<<< HEAD
namespace SNESStudio {
    public enum SNESFileType {
=======
namespace SNESStudio
{
    public enum SNESFileType
    {
>>>>>>> 9e5bb24e7c7465ad3fbc7de7fd71d8a195a1c8b7
        Source,
        Header,
        Graphics,
        Palette,
        Map,
        Binary,
        ROM
    }
<<<<<<< HEAD
    public class SNESFile {
=======
    public class SNESFile
    {
>>>>>>> 9e5bb24e7c7465ad3fbc7de7fd71d8a195a1c8b7
        private string filename;
        private string path;
        private SNESFileType type;
        [NonSerialized]
        private bool hasChanged;
<<<<<<< HEAD
        public SNESFile() : this("newfile.asm",".\\",SNESFileType.Source) {
            hasChanged = false;
        }
        public SNESFile(string filename, string path,SNESFileType type) {
=======
        [NonSerialized]
        private byte[] data;
        public SNESFile()
        {
            filename = "newfile.asm";
            path = ".\\";
            type = SNESFileType.Source;
            hasChanged = false;
        }
        public SNESFile(string filename, string path,SNESFileType type)
        {
>>>>>>> 9e5bb24e7c7465ad3fbc7de7fd71d8a195a1c8b7
            this.filename = filename;
            this.path = path;
            this.type = type;
            hasChanged = false;
        }
<<<<<<< HEAD
        public string FileName {
            get { return filename; }
            set { filename = value; }
        }
        public string Path {
            get { return path; }
            set { path = value; }
        }
        public SNESFileType SNESType {
=======
        public string FileName
        {
            get { return filename; }
            set { filename = value; }
        }
        public string Path
        {
            get { return path; }
            set { path = value; }
        }
        public SNESFileType SNESType
        {
>>>>>>> 9e5bb24e7c7465ad3fbc7de7fd71d8a195a1c8b7
            get { return type; }
            set { type = value; }
        }
        [System.Xml.Serialization.XmlIgnore]
<<<<<<< HEAD
        public bool HasChanged {
=======
        public bool HasChanged
        {
>>>>>>> 9e5bb24e7c7465ad3fbc7de7fd71d8a195a1c8b7
            get { return hasChanged; }
            set { hasChanged = value; }
        }
    }
}
