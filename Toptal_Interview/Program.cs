using System;

namespace Toptal_Interview
{
    class Program
    {
        /*
         * Main
         */
        static void Main(string[] args)
        {
            Test();
        }
        /*
         *  Challenge
         *  
         *  "6-3"
            ) // should return 1
            "1-2,1-2"
            ) // should return 1
            "1-1,3-5,5-2,2-3,2-4"
         */
        /*
         * 
         */         
        public static int GetMaxTail(string domino)
        {
            // Split the string and create an Array of dominios pices
            var pices = domino.Split(",");

            // Save this lenght
            int thisLenght = 0;

            // Save this tail
            string thisTail = "";

            // Save max lenght
            int maxLenght = 1;

            // pice we are matching
            string piceMatching;

            // Traverse the array
            for ( int i =0; i<pices.Length; i++)
            {
                piceMatching = pices[i];

                // Resset thisLemg
                thisLenght = 1;

                // For each pice, look for pices that match - right with left
                for ( int j=0; j<pices.Length; j++)
                {
                    // Cannnot use the same pice ( but what if there are duplicates ? )
                    if ( j != i )
                    {
                        // When there is a match - right with left
                        if (piceMatching.Substring(2, 1) == pices[j].Substring(0, 1))
                        {
                            // save this pair and look for the other pairs
                            piceMatching = pices[j];

                            // increment lenght counter
                            thisLenght++;

                            // compare and save with max counter
                            maxLenght = Math.Max(maxLenght, thisLenght);
                        }
                    }

                }

            }


            return maxLenght;
        }
        static void Test()
        {
            Console.WriteLine(GetMaxTail("1-1,3-5,5-2,2-3,2-4"));
            Console.WriteLine("Expected: 4 :   2-3, 3-5, 5-2, 2-4");

            Console.WriteLine(GetMaxTail("1-1"));
            Console.WriteLine("Expected: 1");

            Console.WriteLine(GetMaxTail("1-1,1-2,5-2,2-3,2-4"));
            Console.WriteLine("Expected: 3 :");

        }


    }
}
