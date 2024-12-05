// Chci, aby se program opakoval po stisku klávesy "a"
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.White;
    string again = "a";
    while(again == "a") {
    Console.Clear();
    razitko();

    ulong a = ziskatCislo("Zadejte přirozené číslo a: ");
    ulong b = ziskatCislo("Zadejte přirozené číslo b: ");

    ulong nsd = vypocitatNSD(a, b);
    ulong nsn = vypocitatNSN(a, b, nsd);

    zobrazitVysledky(a, b, nsd, nsn);

    // Opakování programu
    Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}

static void razitko() {
    Console.WriteLine("**************************");
    Console.WriteLine("******* NSD a NSN ********");
    Console.WriteLine("**************************");
    Console.WriteLine("****** Josef Najman ******");
    Console.WriteLine("**************************\n\n");
    Console.WriteLine();
}

static ulong ziskatCislo(string zprava) {
     // Vstup od uživatele - lepší varianta
    Console.Write(zprava);
    ulong cislo;
    while(!ulong.TryParse(Console.ReadLine(), out cislo)) {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu: ");
    }
    return cislo;
}

static ulong vypocitatNSD(ulong a, ulong b) {
    while(a != b) {
        if(a > b)
            a = a - b;
        else
            b = b - a;
    }
    return a;
}

static ulong vypocitatNSN(ulong a, ulong b, ulong nsd) {
    return (a*b)/nsd;
}

static void zobrazitVysledky(ulong a, ulong b, ulong nsd, ulong nsn) {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine("\n\nNSD čísel {0} a {1} je {2}", a, b, nsd);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine($"\nNSN čísel {a} a {b} je {nsn}");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.ForegroundColor = ConsoleColor.White;
}
