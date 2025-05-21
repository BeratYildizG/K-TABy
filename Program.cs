using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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

            
            if (x == yon & y == sif)
            {
                Console.Clear();
                string[] dvf = {"(TFG)Tehafütül Felasife–Muhammed Bin Ahmed El Gazzali",
                                    "(TKR)Tefsiri Kebir–Fahruddin Er Razi",
                                    "(AEK)Saf Aklın Eleştirisi–Immanuel Kant",
                                    "(STT)Summa Theologica–Thomas Aquinas"};

                string[] bvt = {"(İAE)İzafiyet Teorisi–Albert Einstein",
                                         "(KCS)Kozmos–Carl Sagan",
                                         "(GFK)Geleceğin Fiziği–Michio Kaku",
                                         "(YZL)Yapay Zeka Devrimi–Kai Fu Lee"};


                string[] tvm = {"(TMD)Tüfek Mikrop Ve Çelik–Jared Diamond",
                                    "(DAİ)Devleti Aliyye–Halil İnalcık",
                                    "(İTC)İslam Uygarlıkları Tarihi–Corci Zeydan",
                                    "(ADB)Geç Antikçağ Dünyası–Peter Brown"};

                Console.WriteLine("Giriş Yapıldı\n-------------------------------------------------------------------------");
                Console.WriteLine("KİTABy Sitesine Hoşgeldiniz \nLütfen Aşağıdaki Ketegorilerden Birininin Parantez İçinde Belirtilen Şekilde Giriniz!");
                Console.WriteLine("(DVF) Din Ve Felsefe |(BVT) Bilim Ve Teknoloji |(TVM) Tarih Ve Mitoloji");


                a = Console.ReadLine();
                Console.WriteLine("----------------------------------------------------------------------------------------------------");
                Console.Clear();
                if (a == "DVF")
                {
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
                    foreach (string eser in bvt)
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
                    // din ve felsefe kategorisi
                    case "TFG":
                        Console.Clear();
                        Console.WriteLine(dvf[0] + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır"); break;

                    case "TKR":                        
                        Console.Clear();
                        Console.WriteLine(dvf[1] + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır"); break;

                    case "AEK":
                        Console.Clear();
                        Console.WriteLine(dvf[2] + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır"); break;

                    case "STT":
                        Console.Clear();
                        Console.WriteLine(dvf[3] + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır"); break;

                    // bilim ve teknoloji kategorisi

                    case "İAE":
                        Console.Clear();
                        Console.WriteLine(bvt[0] + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır"); break;

                    case "KCS":
                        Console.Clear();
                        Console.WriteLine(bvt[1]b + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır"); break;

                    case "GFK":
                        Console.WriteLine(bvt[2] + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır"); break;

                    case "YZL":
                        Console.Clear();
                        Console.WriteLine(bvt[3] + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır"); break;

                    // tarih ve mitoloji kategorisi

                    case "TMD":
                        Console.Clear();
                        Console.WriteLine(tvm[0] + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır"); break;

                    case "DAİ":
                        Console.Clear();
                        Console.WriteLine(tvm[1] + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır"); break;

                    case "İTC":
                        Console.Clear();
                        Console.WriteLine(tvm[2] + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır"); break;

                    case "ADB":
                        Console.Clear();
                        Console.WriteLine(tvm[3] + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır"); break;

                    // uygun değerler girilmediği takdirde
                    default:
                        Console.WriteLine("Lütfen Uygun Değerler Giriniz"); break;
                }
            }

            Console.ReadKey();
        }
    }
}
