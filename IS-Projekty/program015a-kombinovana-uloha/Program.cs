using System.Runtime.CompilerServices;

string again = "a";
        while(again == "a") {
            Console.Clear();
            Console.WriteLine("*********************************");
            Console.WriteLine("******* Kombinovaná úloha *******");
            Console.WriteLine("*********************************");
            Console.WriteLine("********** Josef Najman *********");
            Console.WriteLine("*********************************\n\n");
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

            Console.WriteLine("\n==================================");
            Console.WriteLine("Uživatelský vstup: ");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("==================================\n\n");

            // Deklarace pole
            int[] myArray = new int[n];

            // Příprava pro generování náhodných čísel
            Random randomNumber = new Random();

            Console.WriteLine("\n==================================");
            Console.WriteLine("Náhodná čísla: ");
            for(int i=0; i<n; i++) {
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0}; ", myArray[i]);
            }
            Console.WriteLine("\n==================================\n\n");

            // Minimum a maximum
            int min = myArray[0];
            int max = myArray[0];
            string posMin = "0";
            string posMax = "0";

            for (int i = 1; i < n; i++) {
                if (myArray[i] > max) {
                    max = myArray[i];
                    posMax = i.ToString();
                }
                else if (myArray[i] == max) {
                    posMax += ", " + i;
                }
                if (myArray[i] < min) {
                    min = myArray[i];
                    posMin = i.ToString();
                }
                else if (myArray[i] == min) {
                    posMin += ", " + i;
                }   
            }

            Console.WriteLine("\n\n==================================");
            Console.WriteLine("Maximum: {0}, všechny pozice: {1}", max, posMax);
            Console.WriteLine("Minimum: {0}, všechny pozice: {1}", min, posMin);
            Console.WriteLine("==================================\n\n");

            // Shaker sort
            bool swapped;
            int start = 0;
            int end = n - 1;
            do {
                swapped = false;

                // Procházíme dopředu
                for (int y = start; y < end; y++) {
                    if (myArray[y] > myArray[y + 1]) {
                        int temp = myArray[y];
                        myArray[y] = myArray[y + 1];
                        myArray[y + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped) break;

                // Zmenšíme konec
                end--;

                // Procházíme zpět
                for (int y = end - 1; y >= start; y--) {
                    if (myArray[y] > myArray[y + 1]) {
                        int temp = myArray[y];
                        myArray[y] = myArray[y + 1];
                        myArray[y + 1] = temp;
                        swapped = true;
                    }
                }
                // Zvýšíme začátek
                start++;
            } while (swapped);

            Console.WriteLine("\n==================================");
            Console.WriteLine("Pole po seřazení algoritmem Skaher sort:");
            Console.WriteLine(string.Join("; ", myArray));
            Console.WriteLine("==================================\n\n");

            // Nalezení druhého, třetího a čtvrtého největšího čísla
            List<int> largestUnique = myArray.Distinct().Reverse().Take(4).ToList();
            if (largestUnique.Count >= 4) {
                Console.WriteLine("\n==================================");
                Console.WriteLine("Druhé největší číslo: " + largestUnique[1]);
                Console.WriteLine("Třetí největší číslo: " + largestUnique[2]);
                Console.WriteLine("Čtvrté největší číslo: " + largestUnique[3]);
                Console.WriteLine("==================================\n\n");
            }

            // Medíán
            double median;
            Array.Sort(myArray); // Seřadíme pole
            if (n % 2 == 1) {
                // Pokud je počet čísel lichý, medián je prostřední číslo
                median = myArray[n / 2];
            }
            else {
                // Pokud je počet čísel sudý, medián je průměr dvou prostředních prvků
                median = (myArray[n / 2 - 1] + myArray[n / 2]) / 2.0;
            }

            Console.WriteLine("\n==================================");
            Console.WriteLine("Medián generovaných čísel: " + median);
            Console.WriteLine("==================================\n\n");

            // Převod čtvrtého největšího čísla do binární soustavy
            string binary = Convert.ToString(largestUnique[3], 2);
            Console.WriteLine("\n==================================");
            Console.WriteLine("Čtvrté největší číslo v binární soustavě: " + binary);
            Console.WriteLine("==================================\n\n");

            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }