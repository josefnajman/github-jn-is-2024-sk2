﻿string again = "a";
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
            Console.WriteLine("======================================\n\n");

            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }