// chci, aby se program opakoval po stisku klávesy "a"
using System.Data;

string again = "a";
while(again == "a") {
    Console.Clear();
    Console.WriteLine("**************************");
    Console.WriteLine("******* Výpis řady *******");
    Console.WriteLine("**************************");
    Console.WriteLine("****** Josef Najman ******");
    Console.WriteLine("**************************\n\n");
    Console.WriteLine();

    // Vstup od uživatele
    Console.Write("Zadejte počet členů Fibonacciho posloupnosti: ");
    int n = int.Parse(Console.ReadLine());
    
    long a = 0, b = 1;

    Console.WriteLine("Fibonacciho posloupnost:");
    
    for(int i = 0; i < n; i++) {
        Console.Write(a + " ");
        long next = a + b;
        a = b;
        b = next;
    }

    }

    // Opakování programu
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
