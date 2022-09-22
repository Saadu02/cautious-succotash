using System;
using System.Net.Security;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace LA_1100
{
    class Zahlenspiel
    {
        static void Main(string[] args)
        {
            // Eingabe
            
            Random zuefaelligeZahl = new Random(); 
            int i = zuefaelligeZahl.Next(1, 100);
            bool wiederspielen = true;
            bool win = false;
            int versuche = 0;
            //Verarbeitung

            try
            {               
                do
                {
                    do
                    {
                        Console.Write("Wähle eine Zahl aus zwischen 1 bis 100: ");
                        int eingabezahl = Convert.ToInt32(Console.ReadLine());

                        if (eingabezahl < i)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Die geratene Zahl ist niedriger als die Geheimzahl.");
                            Console.ResetColor();
                            versuche++;
                        }
                        else if (eingabezahl > i)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Die geratene Zahl ist grösser als die Geheimzahl.");
                            Console.ResetColor();
                            versuche++;
                        }
                        else if (eingabezahl < 0 | eingabezahl > 100)
                        {
                            Console.Write("Fehler! Bitte erneut eingeben. ");
                            versuche++;
                        }
                        else if (eingabezahl == i)
                        {
                            versuche++;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Bravo! Du hast im Spiel mit " + versuche + " Versuche geschafft die richtige zufällige Zahl herauszufinden.");
                            Console.ResetColor();
                            win = true;

                            Console.Write("Möchten Sie noch Mals spielen? [y|n]: ");
                            char Antwort = Convert.ToChar(Console.ReadLine());                            

                            if (Antwort == 'y')
                            {                     
                              wiederspielen = true;
                                i = zuefaelligeZahl.Next(1, 100);
                                versuche = 0;  
                            }
                            else
                            {
                                wiederspielen = false;                                
                            }

                        }   

                        Console.WriteLine();
                    } while (win == false);

                    //Ausgabe      
                } while (wiederspielen);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Danke fürs Spielen. Aufwiedersehen :) ");
                Console.ResetColor();

                Console.ReadKey();
            }
            catch
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ungültige Eingabe. Bitte starten Sie das Programm neu! ");
                Console.ResetColor();
                Environment.Exit(0);
                
            }

        }

    }
}           
