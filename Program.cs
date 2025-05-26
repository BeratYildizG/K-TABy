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
                                                                                     // BU KISIMLAR HESAP GİRİŞ SİTEMİNİ OLUŞTURUYOR
                    Console.WriteLine($"{j} Hakkınız Kaldı");
                    Console.WriteLine("Lütfen İsminizi Doğru Giriniz: ");
                    x = Console.ReadLine();
                    Console.WriteLine("Lütfen Parolanızı Doğru Giriniz: ");
                    y = Console.ReadLine();
                    j--;
                    Console.Clear();

                } while (x != yon & y != sif || x != yon & y == sif || x == yon & y != sif);
            }

            // BUNDAN SONRAKİLER İSE MEVZULARIN DÖNDÜĞÜ YERLERİ OLUŞTURUYOR
            if (x == yon & y == sif)
            {
                Console.WriteLine("Giriş Yapıldı\n-------------------------------------------------------------------------");
                Console.WriteLine("\t\t\t\t\t\tKİTABy Sitesine Hoşgeldiniz");
                do
                {
                    
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

                    Console.WriteLine("\t\t\tDevam Etmek İstiyorsanız(İşleme Devam Edin)/Çıkmak İstiyorsanız(q)");
                    Console.WriteLine("\t\tLütfen Aşağıdaki Ketegorilerden Birininin Parantez İçinde Belirtilen Şekilde Giriniz!");
                    Console.WriteLine("\t\t\t(DVF) Din Ve Felsefe |(BVT) Bilim Ve Teknoloji |(TVM) Tarih Ve Mitoloji");


                    a = Console.ReadLine();
                    Console.WriteLine("----------------------------------------------------------------------------------------------------");
                    // BURAYA KADAR OLAN KSIM İLE BUNDAN SONRAKİ KISMI AYIRMAK MAKSADIYLA....


                    // DİN VE FELSEFE BÖLÜMÜ

                    if (a.ToUpper() == "DVF")
                    {
                        Console.Clear();
                        foreach (string kitap in dvf)
                        {
                            Console.WriteLine(kitap);
                        }

                        for (int i = 0; i < 100; i++)
                        {
                            Console.Write("-");
                        }
                        Console.WriteLine("\nLütfen Yukarıda Yer Alan Almak İstediğiniz Kitabı Parantez İçinde Belirtilen Şekilde Yazınız");
                        b = Console.ReadLine();


                        // SWİTCH BAŞLANGICI
                        switch (b.ToUpper())
                        {
                            // DİN VE FELSEFE KATEGORİSİ
                            case "TFG":
                                Console.Clear();
                                Console.WriteLine(dvf[0] + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır\n-----" +
                                    "--------------------------------------------------------------------------"); continue;

                            case "TKR":
                                Console.Clear();
                                Console.WriteLine(dvf[1] + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır\n-----" +
                                    "--------------------------------------------------------------------------"); continue;

                            case "AEK":
                                Console.Clear();
                                Console.WriteLine(dvf[2] + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır\n-----" + 
                                    "--------------------------------------------------------------------------"); continue;

                            case "STT":
                                Console.Clear();
                                Console.WriteLine(dvf[3] + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır\n-----" + 
                                    "--------------------------------------------------------------------------"); continue;
                            // uygun değerler girilmediği takdirde
                            default:
                                Console.WriteLine("Lütfen Uygun Değerler Giriniz"); break;
                        }
                    }



                    // BİLİM VE TEKNOLOJİ BÖLÜMÜ

                    if (a.ToUpper() == "BVT")
                    {
                        Console.Clear();
                        foreach (string eser in bvt)
                        {
                            Console.WriteLine(eser);
                        }

                        for (int i = 0; i < 100; i++)
                        {
                            Console.Write("-");
                        }
                        Console.WriteLine("\nLütfen Yukarıda Yer Alan Almak İstediğiniz Kitabı Parantez İçinde Belirtilen Şekilde Yazınız");
                        b = Console.ReadLine();


                        // SWİTCH BAŞLANGICI
                        switch (b.ToUpper())
                        {
                            // BİLİM VE TEKNOLOJİ KATEGORİSİ                            

                            case "İAE":
                                Console.Clear();
                                Console.WriteLine(bvt[0] + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır\n-----" +
                                    "--------------------------------------------------------------------------"); continue;

                            case "KCS":
                                Console.Clear();
                                Console.WriteLine(bvt[1] + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır\n-----" +
                                    "--------------------------------------------------------------------------"); continue;

                            case "GFK":
                                Console.WriteLine(bvt[2] + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır\n-----" +
                                    "--------------------------------------------------------------------------"); continue;

                            case "YZL":
                                Console.Clear();
                                Console.WriteLine(bvt[3] + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır\n-----" +
                                    "--------------------------------------------------------------------------"); continue;
                            // uygun değerler girilmediği takdirde
                            default:
                                Console.WriteLine("Lütfen Uygun Değerler Giriniz"); break;
                        }
                    }



                    // TARİH VE MİTOLOJİ BÖLÜMÜ

                    if (a.ToUpper() == "TVM")
                    {
                        Console.Clear();
                        foreach (string kitap in tvm)
                        {
                            Console.WriteLine(kitap);
                        }

                        for (int i = 0; i < 100; i++)
                        {
                            Console.Write("-");
                        }
                        Console.WriteLine("\nLütfen Yukarıda Yer Alan Almak İstediğiniz Kitabı Parantez İçinde Belirtilen Şekilde Yazınız");
                        b = Console.ReadLine();


                        // SWİTCH BAŞLANGICI
                        switch (b.ToUpper())
                        {
                            // TARİH VE MİTOLOJİ KATEGORİSİ

                            case "TMD":
                                Console.Clear();
                                Console.WriteLine(tvm[0] + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır\n-----" +
                                    "--------------------------------------------------------------------------"); continue;

                            case "DAİ":
                                Console.Clear();
                                Console.WriteLine(tvm[1] + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır\n-----" +
                                    "--------------------------------------------------------------------------"); continue;

                            case "İTC":
                                Console.Clear();
                                Console.WriteLine(tvm[2] + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır\n-----" +
                                    "--------------------------------------------------------------------------"); continue;

                            case "ADB":
                                Console.Clear();
                                Console.WriteLine(tvm[3] + " Adlı Kitab Alımınız Başarıyla Tamamlamıştır\n-----" +
                                    "--------------------------------------------------------------------------  "); continue;
                            // uygun değerler girilmediği takdirde
                            default:
                                Console.WriteLine("Lütfen Uygun Değerler Giriniz"); break;
                        }
                    }
                    
                }while (a != "q");
                Console.WriteLine("Bizi Tercih Ettiğiniz İçin Teşekkür Ederiz!!");
            }

            Console.ReadKey();
        }
    }
}
