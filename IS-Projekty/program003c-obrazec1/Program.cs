// chci, aby se program opakoval po stisku klávesy "a"
using System.Net.Security;
using System.Xml.Schema;

string again = "a";
        while(again == "a") {
            Console.Clear();
            Console.WriteLine("**************************");
            Console.WriteLine("******** Obrazec 1 *******");
            Console.WriteLine("**************************");
            Console.WriteLine("****** Josef Najman ******");
            Console.WriteLine("**************************\n\n");
            Console.WriteLine();

            // Vstup od uživatele - Písmeno Z
            Console.Write("Zadejte písmeno Z pro vykreslení obrazce Z");
    
            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }