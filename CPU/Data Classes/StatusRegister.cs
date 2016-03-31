using System;
using System.Collections.Specialized;

namespace CPU {

    public class StatusRegister {
        private BitVector32 v;
        public StatusRegister() {
            v = new BitVector32();
        }
        public StatusRegister(int value) {
            v = new BitVector32(value);
        }
        public bool C {
            get { return v[0x01];}
            set { v[0x01] = value; }
        }
        public bool Z {
            get { return v[0x02]; }
            set { v[0x02] = value; }
        }
        public bool I {
            get { return v[0x04]; }
            set { v[0x04] = value; }
        }
        public bool D {
            get { return v[0x08]; }
            set { v[0x08] = value; }
        }
        public bool X {
            get { return v[0x10]; }
            set { v[0x10] = value; }
        }
        public bool M {
            get { return v[0x20]; }
            set { v[0x20] = value; }
        }
        public bool V {
            get { return v[0x40]; }
            set { v[0x40] = value; }
        }
        public bool N {
            get { return v[0x80]; }
            set { v[0x80] = value; }
        }
        public byte Value {
            get { return (byte)v.Data; }
            set { v = new BitVector32((int)value);}
        }
    }
    
}
