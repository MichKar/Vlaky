namespace cviko {

    class Program {
        static void Main() {
            Person per = new Person("Petr", "Novák");
            Locomotive loc1 = new Locomotive(new Engine("parní"), per);
            Train vlak1 = new Train(loc1);

            EconomyWagon eco1 = new EconomyWagon(40);
            NightWagon night1 = new NightWagon(50, 10);
            Hopper hop = new Hopper(1080);
            EconomyWagon eco2 = new EconomyWagon(10);
          
            eco1.ConnectWagon(vlak1);
            night1.ConnectWagon(vlak1);
            hop.ConnectWagon(vlak1);
            eco2.ConnectWagon(vlak1);
            Console.WriteLine("Rezervace sedadel");

            vlak1.ReserveChair(1, 20); //úspěšná rez.
            vlak1.ReserveChair(2, 20); //úspěšná rez.
            vlak1.ReserveChair(2, 20); //neúspěšná rez.-již je rezervováno
            vlak1.ReserveChair(3, 20); //neúspěšná rez.-nákladní vůz

            Console.WriteLine("Pokračování programu");
        }
    }
}