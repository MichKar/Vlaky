using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviko {
    internal class BusinessWagon : PersonalWagon {
        private Person steward;

        public BusinessWagon(Person steward, int numberOfChairs) : base(numberOfChairs) {
            this.steward = steward;
   
        }

        internal Person Steward { get => steward; set => steward = value; }

        public override string ToString() {
            return ($"Business vagón má kapacitu {base.NumberOfChairs} a stewarda {steward}");
        }

    }
}
