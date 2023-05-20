using System;

namespace abc
{
  class Program
  {

    
    static void Main(string [] args)
    {
    Console.WriteLine("Lütfen bir sayi giriniz");
    int sayi=int.Parse(Console.ReadLine());
    int sayac=1;
    int toplam = 0;
    while (sayac<= sayi)
    {
        toplam += sayac;
        sayac++;
    }

   Console.WriteLine(toplam/sayi);
  // a dan z ye kadar tüm harfleri yazdırmak
  char character= 'a';
  while(character < 'z')
  {
   Console.Write(character);
   character ++;

  }

   Console.WriteLine("****FOREACH****");
   
   string[] arabalar = {"BMW" , "Ford" , "Toyota" , "Nissan"};

   foreach (var araba in arabalar)
   {
    Console.WriteLine(araba);
   }
  

    }

    }
}
