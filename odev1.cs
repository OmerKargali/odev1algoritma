using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lutfen dizi boyutunu giriniz : ");
        int boyut = Convert.ToInt32(Console.ReadLine());

        int[] dizi = new int[boyut];

        Console.WriteLine("Lutfen dizi elemanlarını giriniz :");

        for (int i = 0; i < boyut; i++)
        {
            Console.Write(" {0}. elemanı giriniz =  ", i);
            dizi[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Lutfen dizi icerisinde aramak istediginiz elamani giriniz : ");
        int arananeleman = Convert.ToInt32(Console.ReadLine());

        bool bulundu = false;

        // Linear Search (Doğrusal Arama) algoritması
        for (int i = 0; i < boyut; i++)
        {
            if (dizi[i] == arananeleman)
            {
                bulundu = true;
                break;
            }
        }

        if (bulundu)
        {
            Console.WriteLine("Aradiginiz eleman dizi içerisinde bulundu.");
        }
        else
        {
            Console.WriteLine("Aradıgınız eleman dizi içerisinde bulunamadı.");
        }

        Console.ReadLine();
    }
}