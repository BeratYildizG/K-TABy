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
            //Console.ForegroundColor = ConsoleColor.Black;
            //Console.BackgroundColor = ConsoleColor.White;
            string kategoriG,kitapG;
            string yon = "admin", y;
            string sif = "3401", s;
            int j = 3;
            Console.WriteLine("Lütfen İsminizi Giriniz: ");
            y = Console.ReadLine();
            Console.WriteLine("Lütfen Parolanızı Giriniz: ");
            s = Console.ReadLine();
            Console.Clear();
            if (y != yon & s != sif || y != yon & s == sif || y == yon & s != sif)
            {
                do
                {
                    if (j == 0)
                    {
                        Console.WriteLine("Hesap Kitlendi Bay Bay");
                        break;
                    }
                                                                                     // BU KISIMLAR HESAP GİRİŞ SİTEMİNİ OLUŞTURUYOR
                    Console.WriteLine($"{j} Hakkınız Kaldı");
                    Console.WriteLine("Lütfen İsminizi Doğru Giriniz: ");
                    y = Console.ReadLine();
                    Console.WriteLine("Lütfen Parolanızı Doğru Giriniz: ");
                    s = Console.ReadLine();
                    j--;
                    Console.Clear();

                } while (y != yon & s != sif || y != yon & s == sif || y == yon & s != sif);
            }



            // BUNDAN SONRAKİLER İSE MEVZULARIN DÖNDÜĞÜ YERLERİ OLUŞTURUYOR
            if (y == yon & s == sif)
            {
                List<string> userBookList = new List<string>();
                string cVe;
                Console.WriteLine("Giriş Yapıldı\n-------------");
                Console.WriteLine("\t\t\t\t\t\t|KİTABy Sitesine Hoşgeldiniz|");
                do
                {
                    string[] dvf = {"TFG-Tehafütül Felasife-Muhammed Gazzali",
                                    "TKR-Tefsiri Kebir-Fahruddin Er Razi",
                                    "AEK-Saf Aklın Eleştirisi-Immanuel Kant",
                                    "STT-Summa Theologica-Thomas Aquinas"};

                    string[] bvt = {"İAE-İzafiyet Teorisi-Albert Einstein",
                                    "KCS-Kozmos-Carl Sagan",
                                    "GFK-Geleceğin Fiziği-Michio Kaku",
                                    "YZL-Yapay Zeka Devrimi-Kai Fu Lee"};


                    string[] tvm = {"TMD-Tüfek Mikrop Ve Çelik-Jared Diamond",
                                    "DAİ-Devleti Aliyye-Halil İnalcık",
                                    "İTC-İslam Uygarlıkları Tarihi-Corci Zeydan",
                                    "ADB-Geç Antikçağ Dünyası-Peter Brown"};

                    string[] kategori = { "DVF", "BVT", "TVM" };

                    

                    Console.WriteLine("\t\t\t\t\t|Sürdürmek İstiyorsan(d)|Çıkmak İstiyorsanız(q)|");
                    cVe = Console.ReadLine();
                    if (cVe != "d" && cVe != "q") { Console.WriteLine("Lütfen Düzgün Parametreler Giriniz"); }

                    if (cVe == "d")
                    {
                        Console.Clear();
                        for (int i = 0; i < 120; i++)
                        {
                            Console.Write("-");
                        }
                        Console.WriteLine();
                        Console.WriteLine("\t\tLütfen Aşağıdaki Ketegorilerden Birininin Parantez İçinde Belirtilen Şekilde Giriniz!");
                        Console.WriteLine("\t\t\t(DVF) Din Ve Felsefe |(BVT) Bilim Ve Teknoloji |(TVM) Tarih Ve Mitoloji");
                        kategoriG = Console.ReadLine().ToUpper();

                        if (!kategori.Contains(kategoriG))
                        { 
                            Console.WriteLine("\t\t\tGeçersiz Kategori Girişi Yaptınız!! Lütfen Geçerli Kategori Girişi Yapınız");
                            continue;
                        }

                        // BURAYA KADAR OLAN KISIM İLE BUNDAN SONRAKİ KISMI AYIRMAK MAKSADIYLA....


                        // DİN VE FELSEFE KATEGORİSİ

                        if (kategoriG == "DVF")
                        {
                            Console.Clear();
                            Console.WriteLine("        Kod          |       Kitap İsmi        |        Yazar İsmi        |");
                            Console.WriteLine($"---------------------+-------------------------+--------------------------+");
                            foreach (string kitap in dvf)
                            {
                                string[] bookİnfo = kitap.Split('-');

                                string cod = bookİnfo[0].PadRight(13).PadLeft(21);
                                string book = bookİnfo[1].PadRight(21).PadLeft(25);
                                string bookAuthor = bookİnfo[2].PadRight(21).PadLeft(26); ;


                                Console.WriteLine($"{cod}|{book}|{bookAuthor}|");
                            }

                            for (int i = 0; i < 75; i++)
                            {
                                Console.Write("-");
                            }
                            Console.WriteLine("\nLütfen Almak İstediğiniz Kitabın Kodunu Giriniz");
                            kitapG = Console.ReadLine();


                            // SWİTCH BAŞLANGICI
                            switch (kitapG.ToUpper())
                            {
                                // DİN VE FELSEFE KİTAPLARI
                                case "TFG":
                                    Console.Clear();
                                    Console.WriteLine("\t\t\t  "+dvf[0] + " Adlı Kitab Listeye Eklenmiştir!!!");
                                    userBookList.Add(dvf[0]);
                                    for (int i = 0; i < 120; i++)
                                    {
                                        Console.Write("-");
                                    }
                                    Console.WriteLine();
                                    continue;

                                case "TKR":
                                    Console.Clear();
                                    Console.WriteLine("\t\t\t\t" + dvf[1] + " Adlı Kitab Listeye Eklenmiştir!!!");
                                    userBookList.Add(dvf[1]);
                                    for (int i = 0; i < 120; i++)
                                    {
                                        Console.Write("-");
                                    }
                                    Console.WriteLine();
                                    continue;

                                case "AEK":
                                    Console.Clear();
                                    Console.WriteLine("\t\t\t\t" + dvf[2] + " Adlı Kitab Listeye Eklenmiştir!!!");
                                    userBookList.Add(dvf[2]);
                                    for (int i = 0; i < 120; i++)
                                    {
                                        Console.Write("-");
                                    }
                                    Console.WriteLine();
                                    continue;

                                case "STT":
                                    Console.Clear();
                                    Console.WriteLine("\t\t\t\t" + dvf[3] + " Adlı Kitab Listeye Eklenmiştir!!!");
                                    userBookList.Add(dvf[3]);
                                    for (int i = 0; i < 120; i++)
                                    {
                                        Console.Write("-");
                                    }
                                    Console.WriteLine();
                                    continue;
                                // uygun değerler girilmediği takdirde
                                default:
                                    Console.Clear();
                                    Console.WriteLine("\t\t\t\t\t\tLütfen Uygun Değerler Giriniz");
                                    for (int i = 0; i < 120; i++)
                                    {
                                        Console.Write("-");
                                    }
                                    Console.WriteLine();
                                    continue;
                            }
                        }



                        // BİLİM VE TEKNOLOJİ KATEGORİSİ

                        if (kategoriG == "BVT")
                        {
                            Console.Clear();
                            Console.WriteLine("        Kod          |       Kitap İsmi        |        Yazar İsmi        |");
                            Console.WriteLine($"---------------------+-------------------------+--------------------------+");
                            foreach (string kitap in bvt)
                            {
                                string[] bookİnfo = kitap.Split('-');

                                string cod = bookİnfo[0].PadRight(13).PadLeft(21);
                                string book = bookİnfo[1].PadRight(21).PadLeft(25);
                                string bookAuthor = bookİnfo[2].PadRight(21).PadLeft(26); ;


                                Console.WriteLine($"{cod}|{book}|{bookAuthor}|");
                            }


                            for (int i = 0; i < 75; i++)
                            {
                                Console.Write("-");
                            }
                            Console.WriteLine("\nLütfen Almak İstediğiniz Kitabın Kodunu Giriniz");
                            kitapG = Console.ReadLine();


                            // SWİTCH BAŞLANGICI
                            switch (kitapG.ToUpper())
                            {
                                // BİLİM VE TEKNOLOJİ KİTAPLARI                            

                                case "İAE":
                                    Console.Clear();
                                    Console.WriteLine("\t\t\t\t" + bvt[0] + " Adlı Kitab Listeye Eklenmiştir!!!");
                                    userBookList.Add(bvt[0]);
                                    for (int i = 0; i < 120; i++)
                                    {
                                        Console.Write("-");
                                    }
                                    Console.WriteLine();
                                    continue;

                                case "KCS":
                                    Console.Clear();
                                    Console.WriteLine("\t\t\t\t  " + bvt[1] + " Adlı Kitab Listeye Eklenmiştir!!!");
                                    userBookList.Add(bvt[1]);
                                    for (int i = 0; i < 120; i++)
                                    {
                                        Console.Write("-");
                                    }
                                    Console.WriteLine();
                                    continue;

                                case "GFK":
                                    Console.Clear();
                                    Console.WriteLine("\t\t\t\t" + bvt[2] + " Adlı Kitab Listeye Eklenmiştir!!!");
                                    userBookList.Add(bvt[2]);
                                    for (int i = 0; i < 120; i++)
                                    {
                                        Console.Write("-");
                                    }
                                    Console.WriteLine();
                                    continue;

                                case "YZL":
                                    Console.Clear();
                                    Console.WriteLine("\t\t\t\t" + bvt[3] + " Adlı Kitab Listeye Eklenmiştir!!!");
                                    userBookList.Add(bvt[3]);
                                    for (int i = 0; i < 120; i++)
                                    {
                                        Console.Write("-");
                                    }
                                    Console.WriteLine();
                                    continue;
                                // uygun değerler girilmediği takdirde
                                default:
                                    Console.Clear();
                                    Console.WriteLine("\t\t\t\t\t\t Lütfen Uygun Değerler Giriniz");
                                    for (int i = 0; i < 120; i++)
                                    {
                                        Console.Write("-");
                                    }
                                    Console.WriteLine();
                                    continue;
                            }
                        }



                        // TARİH VE MİTOLOJİ KATEGORİSİ

                        if (kategoriG == "TVM")
                        {
                            Console.Clear();
                            Console.WriteLine("        Kod          |       Kitap İsmi        |        Yazar İsmi        |");
                            Console.WriteLine($"---------------------+-------------------------+--------------------------+");
                            foreach (string kitap in tvm)
                            {
                                string[] bookİnfo = kitap.Split('-');

                                string cod = bookİnfo[0].PadRight(13).PadLeft(21);
                                string book = bookİnfo[1].PadRight(21).PadLeft(25);
                                string bookAuthor = bookİnfo[2].PadRight(21).PadLeft(26);


                                Console.WriteLine($"{cod}|{book}|{bookAuthor}|");
                            }

                            for (int i = 0; i < 100; i++)
                            {
                                Console.Write("-");
                            }
                            Console.WriteLine("\nLütfen Almak İstediğiniz Kitabın Kodunu Giriniz");
                            kitapG = Console.ReadLine();


                            // SWİTCH BAŞLANGICI
                            switch (kitapG.ToUpper())
                            {
                                // TARİH VE MİTOLOJİ KİTAPLARI

                                case "TMD":
                                    Console.Clear();
                                    Console.WriteLine("\t\t\t " + tvm[0] + " Adlı Kitab Listeye Eklenmiştir!!!");
                                    userBookList.Add(tvm[0]);
                                    for (int i = 0; i < 120; i++)
                                    {
                                        Console.Write("-");
                                    }
                                    Console.WriteLine();
                                    continue;

                                case "DAİ":
                                    Console.Clear();
                                    Console.WriteLine("\t\t\t " + tvm[1] + " Adlı Kitab Listeye Eklenmiştir!!!");
                                    userBookList.Add(tvm[1]);
                                    for (int i = 0; i < 120; i++)
                                    {
                                        Console.Write("-");
                                    }
                                    Console.WriteLine();
                                    continue;

                                case "İTC":
                                    Console.Clear();
                                    Console.WriteLine("\t\t\t " + tvm[2] + " Adlı Kitab Listeye Eklenmiştir!!!");
                                    userBookList.Add(tvm[2]);
                                    for (int i = 0; i < 120; i++)
                                    {
                                        Console.Write("-");
                                    }
                                    Console.WriteLine();
                                    continue;

                                case "ADB":
                                    Console.Clear();
                                    Console.WriteLine("\t\t\t " + tvm[3] + " Adlı Kitab Listeye Eklenmiştir!!!");
                                    userBookList.Add(tvm[3]);
                                    for (int i = 0; i < 120; i++)
                                    {
                                        Console.Write("-");
                                    }
                                    Console.WriteLine();
                                    continue;
                                // uygun değerler girilmediği takdirde
                                default:
                                    Console.Clear();
                                    Console.WriteLine("\t\t\t\t\t\tLütfen Uygun Değerler Giriniz");
                                    for (int i = 0; i < 120; i++)
                                    {
                                        Console.Write("-");
                                    }
                                    Console.WriteLine();
                                    continue;
                            }
                        }


                    }

                } while (cVe != "q");
                Console.Clear();
                Console.WriteLine("Almış Olduğunuz Kitaplar'ın Listesi");
                for (int i = 0; i < 120; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine("        Kod          |       Kitap İsmi        |        Yazar İsmi        |");
                Console.WriteLine($"---------------------+-------------------------+--------------------------+");
                foreach (string ubl in userBookList)
                {
                    string[] bookİnfo = ubl.Split('-');

                    string cod = bookİnfo[0].PadRight(13).PadLeft(21);
                    string book = bookİnfo[1].PadRight(21).PadLeft(25);
                    string bookAuthor = bookİnfo[2].PadRight(21).PadLeft(26);


                    Console.WriteLine($"{cod}|{book}|{bookAuthor}|");
                }
                for (int i = 0; i < 120; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine("\nBizi Tercih Ettiğiniz İçin Teşekkür Ederiz!!");
            }


            Console.ReadKey();
        }
    }
}
