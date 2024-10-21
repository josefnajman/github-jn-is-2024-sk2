  // chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a") {
            Console.Clear();
            Console.WriteLine("************************");
            Console.WriteLine("****** Trojúhelník *****");
            Console.WriteLine("************************");
            Console.WriteLine("****** Josef Najman ****");
            Console.WriteLine("************************\n\n");
            Console.WriteLine();
            
            Console.Write("Zadejte výšku obrazce (celé číslo): ");
            int height;
            while(!int.TryParse(Console.ReadLine(), out height)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu výšku obrazce (celé číslo): ");
            }

            Console.WriteLine();
            for(int i=1; i<= height ;i++) {
                for(int j=1; j<= i ;j++) {
                    Console.Write("* ");
                    System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
                    
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            
            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }