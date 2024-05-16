using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviko {
    internal class Locomotive {
        private Engine engine;
        private Person driver;

        public Locomotive() { }

        public Locomotive(Engine engine, Person driver) {
            this.engine = engine;
            this.driver = driver;
        }

        internal Engine Engine { get => engine; set => engine = value; }
        internal Person Driver { get => driver; set => driver = value; }

        public override string ToString() {
            return ($"lokomotiva má řidiče " + driver.ToString() + " a motor " + engine.ToString());
        }
    }
}
