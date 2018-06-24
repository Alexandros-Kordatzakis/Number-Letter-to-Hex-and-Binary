using System;

namespace testappforuserinput {

    class Program {

        static void Main() {

            while (true) {

                Console.WriteLine("\nEnter a letter or number: ");
                var userInput = Console.ReadLine();
                var letterAsNum = (int)userInput[0];

                System.Threading.Thread.Sleep(1000);

                Console.WriteLine("Decimal: {0:d}", letterAsNum);
                // System.Threading.Thread.Sleep(500);
                Console.WriteLine("Hexadecimal: {0:x2}", letterAsNum);

                Console.WriteLine("\n********************************");

                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
