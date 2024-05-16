using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviko {
    internal class Hopper : IConnection {
        private double LoadingCapacity;
        public Hopper(double tonnage) {
            this.LoadingCapacity = tonnage;
        }
        public double LoadingCapacity1 { get => LoadingCapacity; set => LoadingCapacity = value; }

        public override string ToString() {
            return ($"nákladní vagón s nosností {LoadingCapacity}");
        }

        public void ConnectWagon(Train train) {
            if ((train.Locomotive.Engine.Type == "parní") && (train.Vagons.Count >= 5)) {
                Console.WriteLine("K parní lokomotivě nelze přidat další vagón, je již vyčerpán limit 5 vagónů.");
            }
            else {
                train.Vagons.Add(this);
                Console.WriteLine("Napojení proběhlo v pořádku");
            }
        }
        public void DisconnectWagon(Train train) {
            if (train.Vagons.Contains(this)) {
                train.Vagons.Remove(this);
                Console.WriteLine("Odpojení proběhlo v pořádku.");
            }
            else {
                Console.WriteLine("Tento vagón není připojen.Nelze ho tedy odpojit!");
            }
        }
    }
}
