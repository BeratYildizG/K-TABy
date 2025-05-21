using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KİTABy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string a,b;
            string yon = "admin", x;
            string sif = "3401", y;
            int j = 3;
            Console.WriteLine("Lütfen İsminizi Giriniz: ");
            x = Console.ReadLine();
            Console.WriteLine("Lütfen Parolanızı Giriniz: ");
            y = Console.ReadLine();
            Console.Clear();
            if (x != yon & y != sif || x != yon & y == sif || x == yon & y != sif)
            {
                do
                {
                    if (j == 0)
                    {
                        Console.WriteLine("Hesap Kitlendi Bay Bay");
                        break;
                    }
                    
                    Console.WriteLine($"{j} Hakkınız Kaldı");
                    Console.WriteLine("Lütfen İsminizi Doğru Giriniz: ");
                    x = Console.ReadLine();
                    Console.WriteLine("Lütfen Parolanızı Doğru Giriniz: ");
                    y = Console.ReadLine();
                    j--;
                    Console.Clear();

                } while (x != yon & y != sif || x != yon & y == sif || x == yon & y != sif);
            }

            string[] ktg = { "Din Ve Felsefe", "Bilim Ve Teknoloji", "Tarih" };
            if (x == yon & y == sif)
            {
                Console.Clear();
                Console.WriteLine("Giriş Yapıldı\n-------------------------------------------------------------------------");
                Console.WriteLine("KİTABy Sitesine Hoşgeldiniz \nLütfen Aşağıdaki Ketegorilerden Birininin Parantez İçinde Belirtilen Şekilde Giriniz!");
                Console.WriteLine("(DVF) Din Ve Felsefe |(BVT) Bilim Ve Teknoloji |(TVM) Tarih Ve Mitoloji");


                a = Console.ReadLine();
                Console.WriteLine("----------------------------------------------------------------------------------------------------");
                Console.Clear();
                if (a == "DVF")
                {                    
                    string[] dvf = {"(TFG)Tehafütül Felasife–Muhammed Bin Ahmed El Gazzali",
                                    "(TKR)Tefsiri Kebir–Fahruddin Er Razi",
                                    "(AEK)Saf Aklın Eleştirisi–Immanuel Kant",
                                    "(STT)Summa Theologica–Thomas Aquinas"};

                    foreach (string kitap in dvf)
                    {
                        Console.WriteLine(kitap);
                    }

                    for (int i = 0; i < 100; i++)
                    {
                        Console.Write("-");
                    }

                }
                if (a == "BVT")
                {
                    string[] kitaplar = {"(İAE)İzafiyet Teorisi–Albert Einstein",
                                         "(KCS)Kozmos–Carl Sagan",
                                         "(GFK)Geleceğin Fiziği–Michio Kaku",
                                         "(YZL)Yapay Zeka Devrimi–Kai Fu Lee"};

                    foreach (string eser in kitaplar)
                    {
                        Console.WriteLine(eser);
                    }

                    for (int i = 0; i < 100; i++)
                    {
                        Console.Write("-");
                    }

                }
                if (a == "TVM")
                {
                    string[] tvm = {"(TMD)Tüfek Mikrop Ve Çelik–Jared Diamond",
                                    "(DAİ)Devleti Aliyye–Halil İnalcık",
                                    "(İTC)İslam Uygarlıkları Tarihi–Corci Zeydan",
                                    "(ADB)Geç Antikçağ Dünyası–Peter Brown"};

                    foreach (string kitap in tvm)
                    {
                        Console.WriteLine(kitap);
                    }

                    for (int i = 0; i < 100; i++)
                    {
                        Console.Write("-");
                    }
                }

                Console.WriteLine("\nLütfen Yukarıda Yer Alan Almak İstediğiniz Kitabı Parantez İçinde Belirtilen Şekilde Yazınız");
                b = Console.ReadLine();

                switch (b)
                {
                    case "TFG":
                        for (int i = 0; i < 100; i++)
                        {
                            Console.Write("-");
                        }
                        Console.WriteLine("\n" + b + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır"); break;

                    case "TKR":
                        for (int i = 0; i < 100; i++)
                        {
                            Console.Write("-");
                        }
                        Console.WriteLine("\n" + b + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır"); break;

                    case "AEK":
                        for (int i = 0; i < 100; i++)
                        {
                            Console.Write("-");
                        }
                        Console.WriteLine("\n" + b + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır"); break;

                    case "STT":
                        for (int i = 0; i < 100; i++)
                        {
                            Console.Write("-");
                        }
                        Console.WriteLine("\n" + b + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır"); break;

                    case "İAE":
                        for (int i = 0; i < 100; i++)
                        {
                            Console.Write("-");
                        }
                        Console.WriteLine("\n" + b + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır"); break;

                    case "KCS":
                        for (int i = 0; i < 100; i++)
                        {
                            Console.Write("-");
                        }
                        Console.WriteLine("\n" + b + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır"); break;

                    case "GFK":
                        for (int i = 0; i < 100; i++)
                        {
                            Console.Write("-");
                        }
                        Console.WriteLine("\n" + b + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır"); break;

                    case "YZL":
                        for (int i = 0; i < 100; i++)
                        {
                            Console.Write("-");
                        }
                        Console.WriteLine("\n" + b + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır"); break;

                    case "TMD":
                        for (int i = 0; i < 100; i++)
                        {
                            Console.Write("-");
                        }
                        Console.WriteLine("\n" + b + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır"); break;

                    case "DAİ":
                        for (int i = 0; i < 100; i++)
                        {
                            Console.Write("-");
                        }
                        Console.WriteLine("\n" + b + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır"); break;

                    case "İTC":
                        for (int i = 0; i < 100; i++)
                        {
                            Console.Write("-");
                        }
                        Console.WriteLine("\n" + b + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır"); break;

                    case "ADB":
                        for (int i = 0; i < 100; i++)
                        {
                            Console.Write("-");
                        }
                        Console.WriteLine("\n" + b + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır"); break;
                }
            }

            Console.ReadKey();
        }
    }
}
