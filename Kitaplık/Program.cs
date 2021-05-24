using System;
using System.IO;

namespace Kitaplık
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplamfiyat = 0;
            string secim;
            Console.WriteLine("****************************************************************************");
            Console.WriteLine();
            Console.WriteLine("**  Türkçe Kitaplar Kategorisi     **  Yabancı Kitaplar Kategorisi        **");
            Console.WriteLine();
            Console.WriteLine("**  1-Çalıkuşu: Reşat Nuri         **  7-Tuna Kılavuzu: Jules Verne       **");
            Console.WriteLine();
            Console.WriteLine("**  2-Yaban: Yakup Kadri           **  8-Bir Kuzey Macerası: jack London  **");
            Console.WriteLine();
            Console.WriteLine("**  3-Sinekli Bakkal: Halide Edip  **  9-Altıncı Koğuş: Anton Çehov       **");
            Console.WriteLine();
            Console.WriteLine("**  4-Tehlikeli Oyunlar: O.Atay    **  10-Kumarbaz: Dostoyevski           **");
            Console.WriteLine();
            Console.WriteLine("**  5-Geçtiğim Günlerden           **  11-İki Şehrin Hikayesi: C.Dickens  **");
            Console.WriteLine();
            Console.WriteLine("**  6-Kuyucaklı Yusuf: S.Ali       **  12-Vişne Bahçesi: Anton Çehov      **");
            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine();
            Console.WriteLine("***** İşlemler Menüsü *****");
            Console.WriteLine();
            Console.WriteLine("1-Fiyat Sorgulama");
            Console.WriteLine("2-Yeni Okur Kaydı");
            Console.WriteLine("3-Günün Kitabı");
            Console.WriteLine("4-Kitap Arşivi");
            Console.WriteLine("5-Yeni Kitap Satın Al");
            Console.WriteLine();
            Console.WriteLine("Yapmak istediğiniz işlemin numarası");
            char islem;
            islem = Convert.ToChar(Console.ReadLine());
            if (islem=='1')
            {
                Console.WriteLine();
                Console.Write("Lütfen fiyatını öğrenmek istediğiniz kitabın numarasını giriniz: ");
                string numara;
                numara = Console.ReadLine();
                switch(numara)
                {
                    case "1":
                        Console.WriteLine("Çalı Kuşu: 12 TL");
                        break;
                    case "2":
                        Console.WriteLine("Yaban: 14 TL");
                        break;
                    case "3":
                        Console.WriteLine("Sinekli Bakkal: 16 TL");
                        break;
                    case "4":
                        Console.WriteLine("Tehlikeli Oyunlar: 11 TL");
                        break;
                    case "5":
                        Console.WriteLine("Geçtiğim Günlerden: 8 TL");
                        break;
                    case "6":
                        Console.WriteLine("Kuyucaklı Yusuf: 13 TL");
                        break;
                    case "7":
                        Console.WriteLine("Tuna Kılavuzu: 13 TL"); 
                        break;
                    case "8":
                        Console.WriteLine("Bir Kuzey Macerası: 12 TL");
                        break;
                    case "9":
                        Console.WriteLine("Altıncı Koğuş: 5 TL");
                        break;
                    case "10":
                        Console.WriteLine("Kumarbaz: 10 TL");
                        break;
                    case "11":
                        Console.WriteLine("İki Şehrin Hikayesi: 13 TL");
                        break;
                    case "12":
                        Console.WriteLine("Vişne Bahçesi: 6 TL");
                        break;
                    default:
                        Console.WriteLine("Böyle bir kitap mecvut değildir ,lütfen numarayı kontrol edin");
                        break;
                }
            }
            if (islem=='2')
            {
                Console.WriteLine("***** Yeni Okur Kaydı *****");
                string ad, soyad, universite;
                Console.WriteLine("Adınız: ");
                ad = Console.ReadLine();
                Console.WriteLine("Soyadınız: ");
                soyad = Console.ReadLine(); 
                Console.WriteLine("Üniversiteniz: ");
                universite = Console.ReadLine();
                string dosya = @"C:\Users\mustafa\Desktop\kullanici.txt";
                StreamWriter sw = new StreamWriter(dosya);
                sw.WriteLine("Adınız: " + ad);
                sw.WriteLine("Soyadınız: "+soyad);
                sw.WriteLine("Üniversiteniz: "+universite);
                sw.Close();
            }
            if (islem=='3')
            {
                Console.WriteLine();
                Console.WriteLine("************************************");
                Console.WriteLine();
                Console.WriteLine("***** Bugünün Kitabı: Çalıkuşu *****");
                Console.WriteLine();
                Console.WriteLine("************************************");
            }
            if (islem=='4')
            {
                Console.WriteLine();
                Console.WriteLine("************************************");
                Console.WriteLine();
                FileStream fs = new FileStream(@"C:\Users\mustafa\Desktop\kitaplar.txt", FileMode.Open,FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string metin = sr.ReadLine();
                while(metin!=null)
                {
                    Console.WriteLine(metin);
                    metin = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
                Console.WriteLine();
                Console.WriteLine("************************************");
                Console.WriteLine();
            }
            if (islem=='5')
            {
                for (int i = 1; i < 100 ; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("Alacağınız kitabın numarası: ");
                    secim = Console.ReadLine();
                    if (secim == "1")
                    {
                        toplamfiyat += 12;
                    }
                    else if (secim == "2")
                    {
                        toplamfiyat += 14;
                    }
                    else if (secim == "3")
                    {
                        toplamfiyat += 16;
                    }
                    else if (secim == "4")
                    {
                        toplamfiyat += 11;
                    }
                    else if (secim == "5")
                    {
                        toplamfiyat += 8;
                    }
                    else if (secim == "6")
                    {
                        toplamfiyat += 13;
                    }
                    else if (secim == "7")
                    {
                        toplamfiyat += 13;
                    }
                    else if (secim == "8")
                    {
                        toplamfiyat += 12;
                    }
                    else if (secim == "9")
                    {
                        toplamfiyat += 5;
                    }
                    else if (secim == "10")
                    {
                        toplamfiyat += 10;
                    }
                    else if (secim == "11")
                    {
                        toplamfiyat += 13;
                    }
                    else if (secim == "12")
                    {
                        toplamfiyat += 6;
                    }
                    else
                    
                        Console.WriteLine("Böyle bir numara yoktur");
                        Console.WriteLine();
                        Console.WriteLine("Başka bir kitap almak ister misiniz?");
                        string cevap = Console.ReadLine();
                        if (cevap == "h" || cevap == "H" || cevap == "hayır" || cevap == "HAYIR")
                            break;
                }
                Console.WriteLine("Toplam Tutar: " + toplamfiyat);
            }
            Console.Read();

        }
    }
}
