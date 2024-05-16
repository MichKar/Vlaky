using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviko {
    abstract class PersonalWagon : IConnection {
        private List<Door> doors = new List<Door>();
        private List<Chair> sits = new List<Chair>();
        private int numberOfChairs;

        protected PersonalWagon(int numberOfChairs) {
            this.numberOfChairs = numberOfChairs;
            for (int i = 0; i < numberOfChairs; i++) {
                sits.Add(new Chair(i+1));
            }
        }

        public int NumberOfChairs { get => numberOfChairs; set => numberOfChairs = value; }
        internal List<Door> Doors { get => doors; set => doors = value; }
        internal List<Chair> Sits { get => sits; set => sits = value; }

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
            }
            else {
                Console.WriteLine("Tento vagón není připojen. Nelze ho tedy odpojit!");
            }
        }
    }
}

