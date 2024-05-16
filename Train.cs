using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cviko {
    internal class Train {
        private Locomotive locomotive;
        private List<IConnection> vagons = new List<IConnection>();

        public Train() { }

        public Train(Locomotive locomotive) {
            this.locomotive = locomotive;
        }

        public Train(Locomotive locomotive, List<IConnection> vagons) {
            this.locomotive = locomotive;
            this.vagons = vagons;
        }

        internal Locomotive Locomotive { get => locomotive; set => locomotive = value; }
        internal List<IConnection> Vagons { get => vagons; set => vagons = value; }

        public void ReserveChair(int nrVagon, int nrChair) {

            //zda počet vagonu je ok
            if (nrVagon > 0 && nrVagon <= vagons.Count()) {
                
                //zda je vagon osobní
                if (Vagons[nrVagon - 1] is PersonalWagon osobni) {

                    //zda sedadlo vůbec existuje
                    if (nrChair > 0 && nrChair <= osobni.NumberOfChairs) {
                        Chair sedadlo = osobni.Sits[nrChair - 1];
                        
                        //zda není náhodou už jednou rezervováno
                        if (!sedadlo.GetReserved()) {
                            sedadlo.SetReserved(true);
                            Console.WriteLine("Úspěšná rezervace :)");
                        }
                        else {
                            Console.WriteLine("Zadané sedadlo je již rezervované.");
                        }
                    }
                    else {
                        Console.WriteLine("Zadané sedadlo neexistuje.");
                    }
                }
                else {
                    Console.WriteLine("Nejde udělat rezervaci do nákladního vagonu");
                }
            }
            else {
                Console.WriteLine("Musíš zadat správný vagon!");
            }
        }
    }
}
