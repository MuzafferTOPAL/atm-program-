﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10k altı bir sayı giriniz");
            long sayi = long.Parse(Console.ReadLine());
            long sonuc;
            long sonuc2;
            long sonuc3;
            long sonuc4;
            long sonuc5;
            if (sayi < 10000)
            {
                sonuc = sayi / 1000;

                switch (Math.Abs(sonuc))
                {
                    case 0:
                        Console.Write("");
                        break;
                    case 1:
                        Console.Write("bin ");
                        break;
                    case 2:
                        Console.Write("ikibin ");
                        break;
                    case 3:
                        Console.Write("üçbin ");
                        break;
                    case 4:
                        Console.Write("dörtbin ");
                        break;
                    case 5:
                        Console.Write("beşbin ");
                        break;
                    case 6:
                        Console.Write("altıbin ");
                        break;
                    case 7:
                        Console.Write("yedibin ");
                        break;
                    case 8:
                        Console.Write("sekizbin ");
                        break;
                    case 9:
                        Console.Write("dokuzbin ");
                        break;
                    default:
                        Console.Write("Dogru deger giriniz");
                        break;
                }
                if (sayi > 100)
                {
                    sonuc2 = sayi % 1000 / 100;

                    switch (Math.Abs(sonuc2))
                    {
                        case 0:
                            Console.Write("");
                            break;
                        case 1:
                            Console.Write("yüz ");
                            break;
                        case 2:
                            Console.Write("ikiyüz ");
                            break;
                        case 3:
                            Console.Write("üçyüz ");
                            break;
                        case 4:
                            Console.Write("dörtyüz ");
                            break;
                        case 5:
                            Console.Write("beşyüz ");
                            break;
                        case 6:
                            Console.Write("altıyüz ");
                            break;
                        case 7:
                            Console.Write("yediyüz ");
                            break;
                        case 8:
                            Console.Write("sekizyüz ");
                            break;
                        case 9:
                            Console.Write("dokuzyüz ");
                            break;
                        default:
                            Console.Write("Dogru deger giriniz");
                            break;
                    }
                }


                if (sayi > 10)
                {
                    sonuc3 = sayi % 100 / 10;
                    switch (sonuc3)
                    {
                        case 0:
                            Console.Write("");
                            break;
                        case 1:
                            Console.Write("on ");
                            break;
                        case 2:
                            Console.Write("yirmi ");
                            break;
                        case 3:
                            Console.Write("otuz ");
                            break;
                        case 4:
                            Console.Write("kırk ");
                            break;
                        case 5:
                            Console.Write("elli ");
                            break;
                        case 6:
                            Console.Write("altmış ");
                            break;
                        case 7:
                            Console.Write("yetmiş ");
                            break;
                        case 8:
                            Console.Write("seksen ");
                            break;
                        case 9:
                            Console.Write("doksan ");
                            break;
                        default:
                            Console.Write("Dogru deger giriniz");
                            break;
                    }
                }


                if (sayi != 0)
                {
                    sonuc4 = sayi % 10 / 1;
                    switch (sonuc4)
                    {
                        case 0:
                            Console.WriteLine("");
                            break;
                        case 1:
                            Console.WriteLine("birTL Paranız bulunmaktadır");
                            break;
                        case 2:
                            Console.WriteLine("ikiTL Paranız bulunmaktadır");
                            break;
                        case 3:
                            Console.WriteLine("üçTL Paranız bulunmaktadır");
                            break;
                        case 4:
                            Console.WriteLine("dörtTL Paranız bulunmaktadır");
                            break;
                        case 5:
                            Console.WriteLine("beşTL Paranız bulunmaktadır");
                            break;
                        case 6:
                            Console.WriteLine("altıTL Paranız bulunmaktadır");
                            break;
                        case 7:
                            Console.WriteLine("yediTL Paranız bulunmaktadır");
                            break;
                        case 8:
                            Console.WriteLine("sekizTL Paranız bulunmaktadır");
                            break;
                        case 9:
                            Console.WriteLine("dokuzTL Paranız bulunmaktadır");
                            break;
                        default:
                            Console.WriteLine("Dogru deger giriniz");
                            break;
                    }
                }




            }












        }
    }
}



