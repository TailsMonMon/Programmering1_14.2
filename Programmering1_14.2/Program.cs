using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_14._2 {
    class Program {
        static void Main(string[] args) {
            int[] someNumbers = new int[] {12,64,84,0,52,32,41,1,5,9,45,50};
            Console.Write("Före:  \n");
            for(int i = 0; i < someNumbers.Length; i++) {
                Console.Write(someNumbers[i] + " ");
            }

            int listLength = someNumbers.Length - 1;
            for(int i = 0; i < listLength; i++) {  // Runs through the whole list.
                int numbersLeft = listLength - i; // Counts how many that already have been sorted.

                for(int j = 0; j < numbersLeft; j++) {

                    if(someNumbers[j] > someNumbers[j + 1]) {   // Lowest to highest
                        int temp = someNumbers[j];
                        someNumbers[j] = someNumbers[j + 1];
                        someNumbers[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\n\nEfter: ");
            for(int i = 0; i <someNumbers.Length; i++) {
                Console.Write(someNumbers[i] + " ");
            }
            

            for(int i = 0; i < listLength; i++) {  // Runs through the whole list.
                int numbersLeft = listLength - i; // Counts how many that already have been sorted.

                for(int j = 0; j < numbersLeft; j++) {

                    if(someNumbers[j] < someNumbers[j + 1]) {   // highest to lowest
                        int temp = someNumbers[j];
                        someNumbers[j] = someNumbers[j + 1];
                        someNumbers[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine();
            for(int i = 0; i < someNumbers.Length; i++) {
                Console.Write(someNumbers[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
