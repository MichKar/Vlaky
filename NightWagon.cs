using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviko {
    internal class NightWagon : PersonalWagon {
        private Bed[] beds = new Bed[10];
        private int numberOfBeds;

        public NightWagon(int numberOfChairs, int numberOfBeds) : base(numberOfChairs) {
            this.numberOfBeds = numberOfBeds;
            this.NumberOfChairs = numberOfChairs;
        }

        public int NumberOfBeds { get => numberOfBeds; set => numberOfBeds = value; }
        internal Bed[] Beds { get => beds; set => beds = value; }

        public override string ToString() {
            return ($"noční vagon má počet sedadel {base.NumberOfChairs} a počet lůžek {numberOfBeds}");
        }
    }
}
