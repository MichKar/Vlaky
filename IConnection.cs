using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviko {
    interface IConnection {
        public void ConnectWagon(Train train) {  }
        public void DisconnectWagon(Train train) {  }
       
    }
}
