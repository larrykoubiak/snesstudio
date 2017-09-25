using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SNESStudio
{
    public class SNESProject
    {
        private string name;
        [NonSerialized]
        private string path;
        private ObservableCollection<SNESFile> files;
        public SNESProject()
        {
            name = "newProject";
            files = new ObservableCollection<SNESFile>();
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [XmlIgnore]
        public string Path
        {
            get { return path; }
            set { path = value; }
        }
        public ObservableCollection<SNESFile> Files
        {
            get { return files; }
            set { files = value; }
        }
    }
}
