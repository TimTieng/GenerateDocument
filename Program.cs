using System;

namespace GenerateDocumentName
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Test 1 - Positive Output
            string test1 = "Bste!hetsi ogEAxpelrt x ";
            string document1 = "AlgoExpert is the Best!";
            GenerateDocumentName(test1, document1);

            // Test 2- Positive Output
            string test2 = "a hsgalhsa sanbjksbdkjba kjx";
            string document2 = "";
            GenerateDocumentName(test2,document2);
            
            // Test 3 - Negative Output
            string test3 = " ";
            string document3 = "Hello";
            GenerateDocumentName(test3, document3);

            
        }
        // Helper Function to count the amount of times a character is present
        public static int FrequencyCounter (char character, string input)
        {
            // Declare and Init. Counter variable
            int frequency = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (c == character)
                {
                    frequency++;
                }
            }
            return frequency;
        }
        // Primary Function that meets problems endstate
        public static void GenerateDocumentName(string characters, string documentName)
        {
            for (int i = 0; i < documentName.Length; i++)
            {
                char character =documentName[i];

                // Determine how many times each character is present in both document and characters array
                int documentCharFrequency = FrequencyCounter(character, documentName);
                int characterFrequency = FrequencyCounter(character, characters);

                // Evaluate
                if (documentCharFrequency > characterFrequency)
                {
                    Console.WriteLine("The document name cannot be generated with the list of characters Provided");
                }
            }
            Console.WriteLine("The Document Name can be generated with the list of characters provided");
        }
    }
}
