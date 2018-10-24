using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3Exe1_Arrays_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            //Declare the array and create it
            int[] vect = new int[n];

            //Call methods for every task.
            FillTheVect(vect);
            VectWrite(vect);
            AverageOfVect(vect);
            MaxMinElement(vect);

        }

        private static void FillTheVect(int[] vect)
        {
            Random rand = new Random();
            int m = 100;
            for (int i = 0; i < vect.Length; i++)
            {
                vect[i] = rand.Next(m + 1);
            }
        }

        private static void VectWrite(int[] vect)
        {
            Console.WriteLine("The elements of the integer array");
            foreach (int item in vect)
            {
                Console.WriteLine(item);
            }
        }

        private static void AverageOfVect(int[] vect)
        {
            float sum = 0;
            for (int i = 0; i < vect.Length; i++)
            {
                sum += vect[i];
                //sum = sum + vect[i];
            }
            Console.WriteLine("The sum of the array elements is: {0} ",sum);
            if (vect.Length==0)
            {
                Console.WriteLine("The array is empty.There is np average value");
            }
            else
            {
                Console.WriteLine("The average of the array elements is: " + sum / vect.Length);
            }
        }

        private static void MaxMinElement(int[] vect)
        {
            int max = vect[0];
            int min = vect[0];
            foreach (int element in vect)
            {
                if (element>max)
                {
                    max = element;
                }
                if (element<min)
                {
                    min = element;
                }
            }
            Console.WriteLine("\nThe maximum value if the array is: " + max+"\n The minimum value of the array is: "+min);
        }
    }
}
