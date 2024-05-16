
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviko {
    internal class Chair {
        private Boolean nearWindow;
        private int number;
        private Boolean reserved;

        public Chair(int number) {
            this.number = number;
            reserved = false;
        }

        public Chair(bool nearWindow, int number) {
            this.nearWindow = nearWindow;
            this.number = number;
            reserved = false;
        }

        public bool NearWindow { get => nearWindow; set => nearWindow = value; }
        public int Number { get => number; set => number = value; }

        public bool GetReserved() {
            return reserved;
        }

        public void SetReserved(bool value) {
            reserved = value;
        }
    }
}
