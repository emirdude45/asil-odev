using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Film koccarter = new Film("Koç Carter", 109);
        Film spiderman = new Film("Spiderman", 132);
        Film johnwick = new Film("John Wick", 201);

        Salon salon1 = new Salon("Salon 1", 75);
        Salon salon2 = new Salon("Salon 2", 75);
        Salon salon3 = new Salon("Salon 3", 50);

        Seans seans1 = new Seans(new DateTime(2023, 4, 10, 12, 30, 0), salon1, koccarter);
        Seans seans2 = new Seans(new DateTime(2023, 4, 10, 13, 20, 0), salon2, johnwick);
        Seans seans3 = new Seans(new DateTime(2023, 4, 10, 15, 10, 0), salon3, spiderman);

        List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();

        Console.WriteLine("==========================================================================:");
        Console.WriteLine("                           SEANSLAR                                       ");
        Console.WriteLine("==========================================================================:");
        Console.WriteLine($"1- {koccarter.Ad} - {seans1.Tarih.ToString("dd.MM.yyyy HH:mm")} - {salon1.Ad}");       // Yukarıda oluşturulan class elemanlarını alıp konsola yazıyoruz.
        Console.WriteLine($"2- {johnwick.Ad} - {seans2.Tarih.ToString("dd.MM.yyyy HH:mm")} - {salon2.Ad}");
        Console.WriteLine($"3- {spiderman.Ad} - {seans3.Tarih.ToString("dd.MM.yyyy HH:mm")} - {salon3.Ad}");
        Console.WriteLine("==========================================================================:");
        Console.Write("Hangi seans için bilet almak istersiniz? 1-2-3: ");
        int seansNo = int.Parse(Console.ReadLine());

        Seans SeansSec;
        if (seansNo == 1)
        {
            SeansSec = seans1;
        }
        else if (seansNo == 2)         //Seçilen seansı kontrol eder ve SeansSec e geri döndürür.
        {
            SeansSec = seans2;
        }
        else {
            SeansSec = seans3;
        }
        Console.WriteLine("==========================================================================:");
        Console.WriteLine($"Film: {SeansSec.Film.Ad}");
        Console.WriteLine($"Salon: {SeansSec.Salon.Ad}");
        Console.WriteLine($"Seans: {SeansSec.Tarih.ToString("dd.MM.yyyy HH:mm")}");
        Console.WriteLine("==========================================================================:");

        Console.Write("Kaç tane bilet almak istersiniz?: ");
        int biletSayisi = int.Parse(Console.ReadLine());

        Console.WriteLine("==========================================================================:");
        for (int i = 1; i <= biletSayisi; i++) //Alınan bilet sayısı kadar aynı işlemi tekrarlar.
        {
            Console.Write($"{i}. Koltuk No: ");
            int koltukNo = int.Parse(Console.ReadLine());

            Console.Write($"{i}. Bilet Sahibi Adı: ");
            string musteriAd = Console.ReadLine();

            Rezervasyon rezervasyon = new Rezervasyon(SeansSec, koltukNo, musteriAd);
            rezervasyonlar.Add(rezervasyon);

            Console.WriteLine($"Biletiniz hazır! Koltuk Numarası: {koltukNo}");
            Console.WriteLine("--------------------------------------------------------------------------");
        }

        Console.WriteLine("                          BİLETLER                                 ");
        Console.WriteLine("==========================================================================:");
        foreach (var rezervasyon in rezervasyonlar)
        {
            Console.WriteLine($"{SeansSec.Film.Ad} Filmi - {rezervasyon.KoltukNo} Nolu koltuk - {rezervasyon.MusteriAd}");  // Oluşturulan rezervasyonu ekranda gösterir.
        }
        Console.WriteLine("==========================================================================:");
    {
        Console.WriteLine("Rezervasyonunuz bitti çıkış yapmak için enter tuşuna basınız.");

        Console.ReadLine(); 

        Console.WriteLine("Program kapatılıyor...");
    }
    
    
    }
}