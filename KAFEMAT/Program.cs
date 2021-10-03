using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace KAFEMAT
{
    class Program
    {
        
        public static int[] mince = { 1, 2, 5, 10, 20, 50 };
        public static string vyber = "";
        public static int Overpay = 0;
        
        
        public static void Main(string[] args)
        {
           
            string[] nazev = { "káva černá", "káva s mlékem", "káva irská", "čaj černý", "čaj ovocný" };
            int[] ceny = {15, 20, 30, 15, 10 };
            bool defaultswitch = false;
            Console.WriteLine("*****************************");
            Console.WriteLine("** Vyberte nápoj:          **");
            Console.WriteLine("** 1. káva černá    15 Kč  **");
            Console.WriteLine("** 2. káva s mlékem 20 Kč  **");
            Console.WriteLine("** 3. káva irská    30 Kč  **");
            Console.WriteLine("** 4. čaj černý     15 Kč  **");
            Console.WriteLine("** 5. čaj ovocný    10 Kč  **");
            Console.WriteLine("** 0. odejít od automatu   **");
            Console.WriteLine("*****************************");
            Console.WriteLine("\n");
            Console.Write("Vyberte nápoj: ");
            vyber = Console.ReadLine();
            

            while (defaultswitch == false)
            {

                int preplatek;
                int wew;
                switch (vyber)
                {


                    case "0":
                        defaultswitch = true;
                        Console.WriteLine("\n" + "\n" + "Nashledanou...");
                        break;
                    case "1":
                        defaultswitch = true;

                        Console.WriteLine("\n");
                        Console.WriteLine("Koupil/a sis nápoj pod názvem " + nazev[0]);
                        Thread.Sleep(150);
                        Console.WriteLine("Váš nápoj stojí " + ceny[0] + " Kč");
                        Console.WriteLine("Povolené mince : " + mince[0] + " " + mince[1] + " " + mince[2] + " " + mince[3] + " " + mince[4] + " " + mince[5]);

                        Console.Write("Vhoďte minci (zbývá " + ceny[0] + ") Kč : ");

                        Platba();
                        wew = ceny[int.Parse(vyber) - 1];
                        preplatek = Overpay - wew;
                        Console.WriteLine("Tvůj přeplatek je " + preplatek + " Kč");
                        VratPenize();


                        break;
                    case "2":

                        defaultswitch = true;
                        Console.WriteLine("\n");
                        Console.WriteLine("Koupil/a sis nápoj pod názvem " + nazev[1]);
                        Thread.Sleep(150);
                        Console.WriteLine("Váš nápoj stojí " + ceny[1] + " Kč");
                        Console.WriteLine("Povolené mince : " + mince[0] + " " + mince[1] + " " + mince[2] + " " + mince[3] + " " + mince[4] + " " + mince[5]);
                        Console.Write("Vhoďte minci (zbývá " + ceny[1] + ") Kč : ");

                        Platba();
                        wew = ceny[int.Parse(vyber) - 1];
                        preplatek = Overpay - wew;
                        Console.WriteLine("Tvůj přeplatek je " + preplatek + " Kč");
                        VratPenize();
                        break;
                    case "3":

                        defaultswitch = true;
                        Console.WriteLine("\n");
                        Console.WriteLine("Koupil/a sis nápoj pod názvem " + nazev[2]);
                        Thread.Sleep(150);
                        Console.WriteLine("Váš nápoj stojí " + ceny[2] + " Kč");
                        Console.WriteLine("Povolené mince : " + mince[0] + " " + mince[1] + " " + mince[2] + " " + mince[3] + " " + mince[4] + " " + mince[5]);
                        Console.Write("Vhoďte minci (zbývá " + ceny[2] + ") Kč : ");

                        Platba();
                        wew = ceny[int.Parse(vyber) - 1];
                        preplatek = Overpay - wew;
                        Console.WriteLine("Tvůj přeplatek je " + preplatek + " Kč");
                        VratPenize();
                        break;
                    case "4":

                        defaultswitch = true;
                        Console.WriteLine("\n");
                        Console.WriteLine("Koupil/a sis nápoj pod názvem " + nazev[3]);
                        Thread.Sleep(150);
                        Console.WriteLine("Váš nápoj stojí " + ceny[3] + " Kč");
                        Console.WriteLine("Povolené mince : " + mince[0] + " " + mince[1] + " " + mince[2] + " " + mince[3] + " " + mince[4] + " " + mince[5]);
                        Console.Write("Vhoďte minci (zbývá " + ceny[3] + ") Kč : ");

                        Platba();
                        wew = ceny[int.Parse(vyber) - 1];
                        preplatek = Overpay - wew;
                        Console.WriteLine("Tvůj přeplatek je " + preplatek + " Kč");
                        VratPenize();
                        break;
                    case "5":

                        defaultswitch = true;
                        Console.WriteLine("\n");
                        Console.WriteLine("Koupil/a sis nápoj pod názvem " + nazev[4]);
                        Thread.Sleep(150);
                        Console.WriteLine("Váš nápoj stojí " + ceny[4] + " Kč");
                        Console.WriteLine("Povolené mince : " + mince[0] + " " + mince[1] + " " + mince[2] + " " + mince[3] + " " + mince[4] + " " + mince[5]);
                        Console.Write("Vhoďte minci (zbývá " + ceny[4] + ") Kč : ");
                        Platba();
                        wew = ceny[int.Parse(vyber) - 1];
                        preplatek = Overpay - wew;
                        Console.WriteLine("Tvůj přeplatek je " + preplatek + " Kč");
                        VratPenize();

                        break;

                    default:
                        Console.WriteLine("\n" + "Zkuste to znovu.");
                        Console.Write("Vyberte nápoj: ");
                        vyber = Console.ReadLine();
                        
                        break;
                }
            }
            
            Console.ReadKey();
            
        }
        
        
        
       

        static void Platba()
        {
            bool Koupeno = false;
            int[] ceny = { 15, 20, 30, 15, 10 };

            int MANint = int.Parse(vyber);
            int ManINT2 = MANint - 1;
            Overpay = 0;
            while (Koupeno == false)
                
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        ceny[ManINT2] -= 1;

                        if (ceny[ManINT2] > 0)
                        {
                            Console.Write("Vhoďte minci (zbývá " + ceny[ManINT2] + ") Kč : ");
                            Overpay+=1;

                        }
                        else
                        {
                            Koupeno = true;
                            Console.WriteLine("Děkujeme");
                            Overpay +=1;
                        }
                        break;
                    case "2":
                        ceny[ManINT2] -= 2;

                        if (ceny[ManINT2] > 0)
                        {
                            Console.Write("Vhoďte minci (zbývá " + ceny[ManINT2] + ") Kč : ");
                            Overpay += 2;
                        }
                        else
                        {
                            Koupeno = true;
                            Console.WriteLine("Děkujeme");
                            Overpay += 2;
                        }
                        break;
                    case "5":
                        ceny[ManINT2] -= 5;

                        if (ceny[ManINT2] > 0)
                        {
                            Console.Write("Vhoďte minci (zbývá " + ceny[ManINT2] + ") Kč : ");
                            Overpay += 5;
                        }
                        else
                        {
                            Koupeno = true;
                            Console.WriteLine("Děkujeme");
                            Overpay += 5;
                        }
                        break;
                    case "10":
                        ceny[ManINT2] -= 10;

                        if (ceny[ManINT2] > 0)
                        {
                            Console.Write("Vhoďte minci (zbývá " + ceny[ManINT2] + ") Kč : ");
                            Overpay += 10;
                        }
                        else
                        {
                            Koupeno = true;
                            Console.WriteLine("Děkujeme");
                            Overpay += 10;
                        }
                        break;
                    case "20":
                        ceny[ManINT2] -= 20;

                        if (ceny[ManINT2] > 0)
                        {
                            Console.Write("Vhoďte minci (zbývá " + ceny[ManINT2] + ") Kč : ");
                            Overpay += 20;
                        }
                        else
                        {
                            Koupeno = true;
                            Console.WriteLine("Děkujeme");
                            Overpay += 20;
                        }
                        break;
                    case "50":
                        ceny[ManINT2] -= 50;

                        if (ceny[ManINT2] > 0)
                        {
                            Console.Write("Vhoďte minci (zbývá " + ceny[ManINT2] + ") Kč : ");
                            Overpay += 50;
                        }
                        else
                        {
                            Koupeno = true;
                            Console.WriteLine("Děkujeme");
                            Overpay += 50;
                        }
                        break;
                    default:
                        Console.WriteLine("Vhoďte prosím správnou minci.");
                        Console.Write("Vhoďte minci (zbývá " + ceny[ManINT2] + ") Kč : ");
                        break;                       
                }
                

            }
        }
        static void VratPenize()
        {
            int[] ceny = { 15, 20, 30, 15, 10 };
            int wew = ceny[int.Parse(vyber) - 1];
            int OP = Overpay - wew;
            while(OP > 0)
            {
               if(OP >= 20)
               {
                    OP -= 20;
                    Console.WriteLine("Vracim 20 Kč");
               }
               else if(OP >= 10 & OP < 20)
               {
                    OP -= 10;
                    Console.WriteLine("Vracím 10 Kč");
               }
               else if (OP >= 5 & OP < 10)
               {
                    OP -= 5;
                    Console.WriteLine("Vracím 5 Kč");

               }
               else if (OP >= 2 & OP < 5)
               {
                    OP -= 2;
                    Console.WriteLine("Vracím 2 Kč");
               }
               else if(OP == 1)
               {
                    OP -= 1;
                    Console.WriteLine("Vracím 1 Kč");
               }
               







            }
            

            
        }
    }
}
