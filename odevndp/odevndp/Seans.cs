using System;

class Seans
{
    public DateTime Tarih { get; set; }
    public Salon Salon { get; set; }
    public Film Film { get; set; }

    public Seans(DateTime tarih, Salon salon, Film film)
    {
        Tarih = tarih;
        Salon = salon;
        Film = film;
    }
}
  //Burada seans sınıfını tanımlıyoruz. İlgili seansın tarihini, salonunu ve oynatılacak filmi içeriyor.