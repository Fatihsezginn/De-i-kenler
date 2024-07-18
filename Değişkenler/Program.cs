using System;
 namespace patika
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen asagıdaki bilşgileri giriniz:");
            Console.WriteLine("T.C. Kimil Numarasi:");
            string tc = Console.ReadLine();
            Console.WriteLine("Adi:");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyadi:");
            string soyad = Console.ReadLine();
            Console.WriteLine("Telefon Numarasi:");
            string telefon = Console.ReadLine();  
            Console.WriteLine("Yas:");
            string yas = Console.ReadLine();
            Console.WriteLine("İlk Aldigi Ürünün Fiyati:");
            int urun1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci Aldigi Ürünün Fiyati:");
            int urun2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{tc} tc numarali {ad} {soyad} için kayıt oluşturulmuştur.");
            Console.WriteLine($"{telefon} telefon numarasına bildirim mesajı gönderilmiştir.");
            Console.WriteLine($"{urun1 + urun2} toplam harcama karşılığı kazanılan %10 patika miktarı -> 55 TL'dir.");

           


                
        }
    }




}