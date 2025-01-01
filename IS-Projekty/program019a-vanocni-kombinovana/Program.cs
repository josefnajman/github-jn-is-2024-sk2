using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;

string again = "a";
        while(again == "a") {
            Console.Clear();
            Console.WriteLine("*****************************************");
            Console.WriteLine("******* Vánoční kombinovaná úloha *******");
            Console.WriteLine("*****************************************");
            Console.WriteLine("************ Josef Najman ***************");
            Console.WriteLine("*****************************************\n\n");
            Console.WriteLine();

            
            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu (celé číslo): ");
            }

            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez (celé číslo): ");
            }

            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez (celé číslo): ");
            }

            Console.WriteLine("\n\n====================");
            Console.WriteLine("Uživatelský vstup: ");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("====================\n\n");

            // deklarace pole
            int[] myArray = new int[n];

            // příprava pro generování náhodných čísel
            Random randomNumber = new Random();

            Console.WriteLine("Náhodná čísla: ");

            for(int i=0; i<n; i++) {
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0}; ", myArray[i]);
            }

            // Comb sort

            int gap = myArray.Length;
            const double shrink = 1.3;
            bool sorted = false;

            while (!sorted) {
                gap = (int)(gap / shrink);
                if (gap < 1) gap = 1;

                sorted = true;

                for (int x = 0; x + gap < myArray.Length; x++) {
                    if (myArray[x] > myArray[x + gap]) {
                        // Prohození prvků
                        int temp = myArray[x];
                        myArray[x] = myArray[x + gap];
                        myArray[x + gap] = temp;

                        sorted = false;
                    }
                }

            }


            
            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }