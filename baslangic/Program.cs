using System;
using System.Collections;
using static baslangic.Class1;
using static baslangic.Class2;

namespace baslangic
{
    internal class Program
    {
        static void Main(string[] args)
        {
        

        }

        private static void arrayListMetodu()
        {

            /* //tanımlama
            ArrayList listem = new ArrayList();
            //var                  //System.Collections.ArrayList();

            //ekleme
            listem.Add(10);
            listem.Add("BTK");
            listem.Add(5.6);
            listem.Add(false); */

            //tanımlama & ekleme
            var listem = new ArrayList()
            {
                "Btk", 10 , 5.6 , false
            };

            //dizi ekleme
            int[] dizicik = new int[] { 1, 2, 3, 4, 5 };

            listem.AddRange(dizicik);

            //dolaşma
            foreach (var item in listem)
            {
                Console.Write($"{item}              ");
            }

            //Elemana erişme, atama, silme ...



        }
        private static void cokBoyutluDiziler3()
        {
            double[,] matrix = new double[,]   //2 boyutlu       ,, 3 boyutlu    ,,, 4 boyutlu ...
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i==j)
                    {
                        matrix[i, j] = -1;
                    }
                    Console.Write($"{matrix[i, j],5}");
                }
                Console.WriteLine();
            }
        }
        private static void cokBoyutluDiziler2()
        {
            double[,] matrix = new double[,]   //2 boyutlu       ,, 3 boyutlu    ,,, 4 boyutlu ...
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j],5}");
                }
                Console.WriteLine();
            }
        }
        private static void cokBoyutluDiziler1()
        {
            Console.WriteLine("Lütfen dizinin boyutunu giriniz: ");
            int boyut = int.Parse(Console.ReadLine());
            int[] dizicik = new int[boyut];
            var randomMetodu = new Random();

            for (int i = 0; i < boyut; i++)
            {
                dizicik[i] = randomMetodu.Next(1, 50);
            }

            foreach (var sayi in dizicik)
            {
                Console.WriteLine($"{sayi,5} {sayi * sayi,5} ");
            }
        }
        private static void diziIslemleri()
        {
            /*
            //tanımlama
            int[] diziAdi;

            //baslatma & atama
            diziAdi = new int[3];

            diziAdi[0] = 5;
            diziAdi[1] = 7;
            diziAdi[2] = 9;
            Console.WriteLine(diziAdi); 
            */

            //tanımlama & baslatma & atama
            int[] diziAdi = new int[] { 5, 7, 9 };
            //int[] diziAdi = { 5, 7, 9 };

            //indexleri dolasma
            for (int i = 0; i < diziAdi.Length; i++)
            {
                Console.WriteLine(diziAdi[i]);
            }

            //dolasma2
            for (int i = 0; i < diziAdi.Length; i++)
            {
                Console.WriteLine($"Dizinin[{i}]indeksi = {diziAdi[i]}");
            }

        }
        private static void ucgenyabma()
        {
            //int boyut =int.Parse(Console.ReadLine());
            int boyut = Convert.ToInt32(Console.ReadLine());
            //int boyut = 5;

            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }
        private static void kareMatrix()
        {
            int boyut = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= boyut; i++)
            {
                for (int j = 1; j <= boyut; j++)
                {
                    Console.Write(" ({0},{1}) ",i,j);
                }
                Console.WriteLine();
            }
        }
        private static void uceBolunurMU()
        {
            Console.WriteLine("Baslangic degerini giriniz: ");
            int baslangic = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Son degeri giriniz: ");
            int sonuncu = Convert.ToInt32(Console.ReadLine());

            for (int i = baslangic; i <= sonuncu; i++)
            {
                if (i % 3 == 0)
                    continue;
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
        public static void inputluIslem()
        {
            Console.WriteLine("Baslangic degerini giriniz: ");
            int baslangic = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Son degeri giriniz: ");
            int sonuncu = Convert.ToInt32(Console.ReadLine());

            for (int i = baslangic ; i <= sonuncu; i++)
            {
                Console.Write("{0 3}", baslangic);
            }
        }
        private static void boslukluKareWritingForlu()
        {
            for (int i = 0; i <= 8; i++)
            {
                Console.WriteLine("{0,-3} {1,-3}", i, i*i);
            }
        }
        private static void boslukluKareWriting()
        {
            int sayi = 0;
            
            while (sayi<8)
            {
                
                sayi++;
                int sayininkaresi = sayi * sayi;
                Console.WriteLine("{0,-3} {1,-3}", sayi, sayininkaresi);

            }
        }
        private static void boslukluWriting()
        {
            int a = 0;
            while (a<20)
            {
                a++;
                Console.Write("{0,5}",a);  // 0 oraya bir elemanın(a) geleceğini ifade ediyor, 5 te boşluk sayısı   
                                           // "{0,-3}"
            }
        }
        private static void sayacliSonsuzDongu()
        {
            int a = 0;
            int sayac = 0;
            while (a<10)
            {
                sayac = sayac+1;
                Console.WriteLine(sayac);
            }
        }
        private static void sonsuzDongu()
        {
            int a = 0;
            Console.Write("Sonsuz döng");
            while (a<10)
            {
                Console.Write("üüü");
            }
        }
        private static void altsatiragecme()
        {
            string cumle = "Boj belej bijeyler ogrenıyorum.";
            Console.WriteLine(cumle);
            Console.WriteLine("\nBoj \nbelej \nbijeyler \nogreniyorum.");
            Console.WriteLine("\aBoj \nbelej \nbijeyler \nogreniyorum.");
            Console.WriteLine("\tBoj \nbelej \nbijeyler \nogreniyorum.");
        }
        private static void ikiylecarp(double x)
        {
            
            //var x = Convert.ToDouble(Console.ReadLine());
            var y = x * 2;
            Console.WriteLine(x.GetType() + " " + y.GetType());
            System.Console.WriteLine(y);
        }
        public static void yazdir()
        {

            while (true)
            
            {
                Console.WriteLine("Lütfen 4 haneli bir sayı giriniz:");
                int sonrakam = Convert.ToInt32(Console.ReadLine());
                
                if (sonrakam < 10000 & sonrakam > 999)
                {
                    Console.WriteLine("Tatli Sayiciklar");
                    for (int j = 0; j <= sonrakam; j++)
                    {
                        Console.Write(j + " ");
                    }
                    break;
                    
                }
                else
                {
                    Console.WriteLine("Lütfen istediğim sayıyı gir, ayıp oluyor.");
                }
                
            }
        }
        private static void merhaba()
        {
            Console.WriteLine("Merabayn");
        }
    }
}

