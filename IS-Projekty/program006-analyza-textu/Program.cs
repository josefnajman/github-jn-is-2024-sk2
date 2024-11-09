class Program {
    static void Main() {
        
        string again = "a";
        
        while(again == "a") {
            Console.Clear();
            Console.WriteLine("****************************");
            Console.WriteLine("******* Analýza textu ******");
            Console.WriteLine("****************************");
            Console.WriteLine("******* Josef Najman *******");
            Console.WriteLine("****************************");
            Console.WriteLine();
            Console.Write("\nZadejte váš text: ");
            
            string myText = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(myText);
            Console.WriteLine(myText[0]);
            Console.WriteLine(myText.Length-1);
            
            string samohlasky = "aáeéěiíoóuůúyý";
            string souhlasky = "bcčdďfghjklmnňpqrřsštťvwxzž";
            string cislice = "0123456789";

            int pocetSamohlasek = 0;
            int pocetSouhlasek = 0;
            int pocetCislic = 0;
            int pocetOstatnich = 0;

            foreach(char znak in myText) {
                char lowerChar = char.ToLower(znak);

                if(souhlasky.Contains(lowerChar)) {
                    pocetSouhlasek++;
                }
                else if(samohlasky.Contains(lowerChar)) {
                    pocetSamohlasek++;
                }
                else if(cislice.Contains(lowerChar)) {
                    pocetCislic++;
                }
                else
                    pocetOstatnich++;
            }

            Console.WriteLine();
            Console.WriteLine("Počet samohlásek: {0}", pocetSamohlasek);
            Console.WriteLine("Počet souhlásek: {0}", pocetSouhlasek);
            Console.WriteLine("Počet číslic: {0}", pocetCislic);
            Console.WriteLine("Počet ostatních zanků: {0}", pocetOstatnich);
            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();

        }
    }
}
