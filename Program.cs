
using System;

namespace Caesar
{
    class Program
    {
        static void Main(string[] args)

        {
            string repeatProgram;
            string sentence;
            string result;
            char actChar;
            Random random = new Random();
            int caesarValue;
            do
            {
                Console.WriteLine("Caesar Verschlüsselung");
                Console.WriteLine("--------------------------------------");

                Console.WriteLine("Zu verschlüsselnden Satz eingeben:");
                sentence = Console.ReadLine();
                result = "";
                caesarValue = random.Next(1, 26);  //Zufallszahl bestimmen --> um diesen Wert werden die Buchstaben nach hinten verschoben
                for (int i = 0; i < sentence.Length; i++) //Jeden Buchstaben betrachten
                {
                    actChar = sentence[i];
                    if (actChar != ' ')  //Leerzeichen nicht umwandeln
                    {
                        if (actChar >= 'a' && actChar <= 'z')  //Wenn ein Kleinbuchstabe eingegeben wurde, diesen in Großbuchstaben umwandeln
                        {
                            actChar = (char)(actChar - ('a' - 'A'));
                        }
                        actChar = (char)(actChar + caesarValue); //Buchstaben verschieben
                        if (actChar > 'Z')  //Wenn ein Wert größer Z herauskommt --> wird wieder bei A begonnen
                            actChar = (char)('A' + (actChar - 'Z' + 1));

                    }
                    result = result + actChar;  //Neues Buchstaben zum Ergebnis hinzufügen
                }
                Console.WriteLine("\nDer Verschlüsselte Satz lautet:");
                Console.WriteLine(result);
                Console.WriteLine("\nProgramm nochmal ausführen (j/n)?");
                repeatProgram = Console.ReadLine();
            } while (repeatProgram.ToUpper() == "J");
        }
    }
}
