using System;

namespace zadania{
    public enum elementy {
        jakies = 1651,
        mega = 5416,
        fajne = 9410,
        elementy = 3511
    }

    internal class Program {
        static void Z1(int n) {
            int suma = 0;
            Console.WriteLine($"Liczby \'doskonale\' w przedziale <1, {n}> to: ");

            for (int liczb = 1; liczb <= n; liczb++) {
                suma = 0;
                for (int i = 1; i <= liczb / 2; i++) {
                    if (liczb % i == 0) {
                        suma += i;
                    }
                }

                if (liczb == suma) {
                    Console.Write(liczb + "; ");
                }

            }
        }
        static void Z2(int indeks, int kwota, string poprzednie) {
            int[] monety = { 1, 2, 5 };

            int ile = 0;
            int g = kwota / monety[indeks];

            if (indeks != 0) {
                for (int i = 0; i <= g; i++) {

                    if (i > 0) {
                        Console.Write(poprzednie);
                    }

                    string obecne = "";

                    for (int x = 0; x < i; x++) {
                        obecne += monety[indeks] + " ";
                    }

                    Console.Write(obecne);
                    Z2(indeks - 1, kwota - monety[indeks] * i, poprzednie + obecne);
                }
            } else {
                for (int i = 0; i < g; i++) {
                    Console.Write(monety[indeks] + " ");
                }

                Console.WriteLine();

                ile++;
            }
        }

        static void Z3() {
            int[] tab = {5, 4, -32, -43, 72, 94, -58, 39, 1, 9};

            //max
            int max = tab.Max();
            int maxP = tab.ToList().IndexOf(max);

            Console.WriteLine("Max: " + max + " Poz: " + maxP);

            //min
            int min = tab.Min();
            int minP = tab.ToList().IndexOf(min);

            Console.WriteLine("Min: " + min + " Poz: " + minP);

            //avg
            double avg = tab.Average();
            Console.WriteLine("Avg: " + avg);

            //unsigned
            int count = 0;
            for (int i = 0; i < tab.Length; i++) {
                if (tab[i] >= 0) {
                    count++;
                }
            }
            Console.WriteLine("Unsigned: " + count);

        }
           
        static void Z4(int n, int m) {
            for (int i = n; i <= m; i++) {


                if (i == 2) {
                    Console.Write(i + ", ");
                }else if (i%2!=0 && i%3!=0 && i%5!=0 && i%7!=0) {
                    Console.Write(i + ", ");
                }


            }
        }

        static void Z5(int n1) {
            int n = n1;
            int m = n;

            int[,] mac1 = new int[n, m];
            int[,] mac2 = new int[n, m];
            int[,] res = new int[n, m];

            Random rng = new Random();

            for (int i = 0; i < n; i++){
                for (int j = 0; j < n; j++) {
                    mac1[i, j] = rng.Next(0, 5);
                    mac2[i, j] = rng.Next(0, 5);
                }
            }

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write(mac1[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n    +\n");

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write(mac2[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n    =\n");

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    res[i, j] = mac1[i, j] + mac2[i, j];
                }
            }

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write(res[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        //static void Z6(string text) {
        //    text.Split();
        //
        //    for () {
        //        
        //    }
        //    
        //}

        static void Z7(string[] produkty) {
            DateTime current = DateTime.Now;
            int cYear = current.Year;
            int prodYear;
            int minYear;
            
            foreach (string produkt in produkty) {
                string[] prod = produkt.Split("-");
                prodYear = int.Parse(prod[1]);
                prodYear = int.Parse(prod[1]);
                minYear = cYear - prodYear;
                Console.WriteLine("Od zakupu \'" + produkt + "\' minelo " + minYear + " lat");
            }
        }

        static void Z10(int day, int month, int year) {

            DateTime date1 = new DateTime(year, month, day);

            Console.WriteLine("Dzien Tygodnia: " + date1.DayOfWeek);

            Console.WriteLine("Miesiąc: " + date1.ToString("MMMM"));

            Console.WriteLine($"Masz {DateTime.Now.Subtract(date1).Days / 365} lat");

        }
        static void Main() {
            Console.WriteLine("ogolnie to nie bylo dzisiaj (t.j. 13.01.2022) weny. zrobilem co moglem, moge dorobic reszte zadan innego dnia, lecz dzisiaj niestety musze sie poddac. 7 zadan to tez dobry wynik jak na taka przerwe. pozdrawiam: Kozicki Pawel");

            //zad1
                Console.WriteLine("\n\n\nZADANIE: 1------------------------------------------\n");

                int n2 = 30;
                Z1(n2);


                Console.WriteLine("\n\n\nZADANIE: 2------------------------------------------\n");

            //zad2
                int rozmiar_tab = 3;
                int kwota = 10;

                Z2(rozmiar_tab - 1, kwota, "");

                Console.WriteLine("\n\n\nZADANIE: 3------------------------------------------\n");

            //zad3
                Z3();

                Console.WriteLine("\n\n\nZADANIE: 4------------------------------------------\n");

            //zad4
                int n = 10;
                int m = 30;
                Z4(n, m);

                Console.WriteLine("\n\n\nZADANIE: 5------------------------------------------\n");

            //zad5
                int n1 = 5;

                Z5(n1);

                //Console.WriteLine("\n\n\nZADANIE: 6------------------------------------------\n");

            //zad6
                //string text = "abrakadabra";
                //Z6(text);

                Console.WriteLine("\n\n\nZADANIE: 7------------------------------------------\n");

            //zad7
                string[] produkty = { "ZXCV-2005", "QWER-2015", "MNBV-2020", "POIU-2001", "LKJH-2018" };
                Z7(produkty);

                Console.WriteLine("\n\n\nZADANIE: 10------------------------------------------\n");

            //zad10
                string date = "1983.5.7";
                string[] result = date.Split(".");

                int day = int.Parse(result[2]);
                int month = int.Parse(result[1]);
                int year = int.Parse(result[0]);

                Z10(day, month, year);
        }
    }
}