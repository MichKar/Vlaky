using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviko {
    internal class Bed {
        private int number;
        private Boolean reserved;

        public Bed() { }

        public int Number { get => number; set => number = value; }
        public bool Reserved { get => reserved; set => reserved = value; }
    }
}
