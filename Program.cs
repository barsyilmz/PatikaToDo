using System;
using System.Collections.Generic;

namespace ToDo
{
    enum KartBuyuklugu
    {
        XS = 1,
        S = 2,
        M = 3,
        L = 4,
        XL = 5
    }

    class Kart
    {
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string AtananKisi { get; set; }
        public KartBuyuklugu Buyukluk { get; set; }
        public string Durum { get; set; }
    }

    class Program
    {
        static List<Kart> kartlar = new List<Kart>();
        static List<string> takimUyeleri = new List<string>() { "Baris", "Mahmut", "Muzaffer", "Mukadder" };

        static void Main(string[] args)
        {
            Console.WriteLine("ToDo Uygulaması");
            Console.WriteLine("----------------");

            kartlar.Add(new Kart { Baslik = "Kart 1", Icerik = "İçerik 1", AtananKisi = takimUyeleri[0], Buyukluk = KartBuyuklugu.M, Durum = "TODO" });
            kartlar.Add(new Kart { Baslik = "Kart 2", Icerik = "İçerik 2", AtananKisi = "Muzaffer", Buyukluk = KartBuyuklugu.S, Durum = "IN PROGRESS" });
            kartlar.Add(new Kart { Baslik = "Kart 3", Icerik = "İçerik 3", AtananKisi = takimUyeleri[3], Buyukluk = KartBuyuklugu.L, Durum = "DONE" });

            int secim;
            do
            {
                Console.WriteLine("\nYapmak istediğiniz işlemi seçin:");
                Console.WriteLine("1. Board Durumunu Listele");
                Console.WriteLine("2. Kart Ekle");
                Console.WriteLine("3. Kart Güncelle");
                Console.WriteLine("4. Kart Taşı");
                Console.WriteLine("5. Kart Sil");
                Console.WriteLine("0. Çıkış");

                secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        BoardListele();
                        break;
                    case 2:
                        KartEkle();
                        break;
                    case 3:
                        KartGuncelle();
                        break;
                    case 4:
                        KartTasi();
                        break;
                    case 5:
                        KartSil();
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim. Tekrar deneyin.");
                        break;
                }
            } while (secim != 0);
        }

        static void BoardListele()
        {
            Console.WriteLine("Board Durumu");
            Console.WriteLine("-------------");

            foreach (Kart kart in kartlar)
            {
                Console.WriteLine($"Başlık: {kart.Baslik}");
                Console.WriteLine($"İçerik: {kart.Icerik}");
                Console.WriteLine($"Atanan Kişi: {kart.AtananKisi}");
                Console.WriteLine($"Büyüklük: {kart.Buyukluk}");
                Console.WriteLine($"Durum: {kart.Durum}");
                Console.WriteLine("------------------");
            }
        }

        static void KartEkle()
        {
            Console.WriteLine("Yeni Kart Ekleme");
            Console.Write("Başlık: ");
            string baslik = Console.ReadLine();
            Console.Write("İçerik: ");
            string icerik = Console.ReadLine();
            Console.Write("Atanan Kişi: ");
            string atananKisi = Console.ReadLine();
            Console.Write("Büyüklük (XS=1, S=2, M=3, L=4, XL=5): ");
            int buyuklukInput = Convert.ToInt32(Console.ReadLine());
            KartBuyuklugu buyukluk = (KartBuyuklugu)buyuklukInput;

            Kart yeniKart = new Kart
            {
                Baslik = baslik,
                Icerik = icerik,
                AtananKisi = atananKisi,
                Buyukluk = buyukluk,
                Durum = "TODO"
            };

            kartlar.Add(yeniKart);
            Console.WriteLine("Yeni kart eklendi!");
        }

        static void KartGuncelle()
        {
            Console.WriteLine("Kart Güncelleme");
            Console.Write("Güncellenecek Kart Başlığı: ");
            string baslik = Console.ReadLine();

            Kart guncellenecekKart = kartlar.Find(k => k.Baslik == baslik);

            if (guncellenecekKart == null)
            {
                Console.WriteLine("Kart bulunamadı!");
                return;
            }

            Console.Write("Yeni Başlık: ");
            guncellenecekKart.Baslik = Console.ReadLine();
            Console.Write("Yeni İçerik: ");
            guncellenecekKart.Icerik = Console.ReadLine();
            Console.Write("Yeni Atanan Kişi: ");
            guncellenecekKart.AtananKisi = Console.ReadLine();
            Console.Write("Yeni Büyüklük (XS=1, S=2, M=3, L=4, XL=5): ");
            int buyuklukInput = Convert.ToInt32(Console.ReadLine());
            guncellenecekKart.Buyukluk = (KartBuyuklugu)buyuklukInput;

            Console.WriteLine("Kart güncellendi!");
        }

        static void KartTasi()
        {
            Console.WriteLine("Kart Taşıma");
            Console.Write("Taşınacak Kart Başlığı: ");
            string baslik = Console.ReadLine();

            Kart tasinanKart = kartlar.Find(k => k.Baslik == baslik);

            if (tasinanKart == null)
            {
                Console.WriteLine("Kart bulunamadı!");
                return;
            }

            Console.Write("Hedef Durum (TODO, IN PROGRESS, DONE): ");
            string hedefDurum = Console.ReadLine();

            tasinanKart.Durum = hedefDurum;
            Console.WriteLine("Kart taşındı!");
        }

        static void KartSil()
        {
            Console.WriteLine("Kart Silme");
            Console.Write("Silinecek Kart Başlığı: ");
            string baslik = Console.ReadLine();

            int silinenKartSayisi = kartlar.RemoveAll(k => k.Baslik == baslik);

            if (silinenKartSayisi == 0)
            {
                Console.WriteLine("Kart bulunamadı!");
            }
            else
            {
                Console.WriteLine($"{silinenKartSayisi} kart silindi!");
            }
        }
    }
}
