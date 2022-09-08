using System;
using System.Net.Security;
using System.Threading.Channels;

namespace LA_1100
{
    class Zahlenspiel
    {
        static void Main(string[] args)
        {
            // Eingabe

            int zufaelligezahl = new Random().Next(1, 100);
            int i = Convert.ToInt32(zufaelligezahl);
            bool wiederspielen = false;
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
                            Console.WriteLine("Die geratene Zahl ist niedriger als die Geheimzahl.");
                            versuche++;
                        }
                        else if (eingabezahl > i)
                        {
                            Console.WriteLine("Die geratene Zahl ist grösser als die Geheimzahl.");
                            versuche++;
                        }
                        else if (eingabezahl < 0 | eingabezahl > 100)
                        {
                            Console.Write("Fehler! Bitte erneut eingeben. ");                            
                            versuche++;
                        }
                        else if (eingabezahl == i)
                        {
                            Console.WriteLine("Bravo! Du hast im Spiel mit " + versuche + " Versuche geschafft die richtige zufällige Zahl herauszufinden.");
                            win = true;
                        }

                        Console.WriteLine();
                    } while (win == false);

                    //Ausgabe

                    Console.Write("Möchten Sie noch Mals spielen? [y|n]: ");
                    char Antwort = Convert.ToChar(Console.ReadLine());

                    if (Antwort == 'y')
                    {
                        wiederspielen = true;
                    }
                    else
                    {
                        wiederspielen = false;

                    }

                } while (wiederspielen);


                Console.WriteLine("Danke fürs Spielen. Aufwiedersehen :)");

                Console.ReadKey();

            }
            catch
            {
                Console.WriteLine("Ungültige Eingabe. Wähle Sie eine Zahl aus zwischen 1 bis 100: ");
                Environment.Exit(0);
                //Console.WriteLine(wiederspielen);
            } 
                    
            
        }
    }
}           
