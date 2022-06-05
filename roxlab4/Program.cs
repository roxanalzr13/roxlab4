using System;

namespace roxlab4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ex1();
            //Ex2();
            //Ex3();
            //Ex4();

        }
        //Scrieti un program care va citi un vector de intregi de dimensiune n de la tastatura

        static void Ex1()
        {
            Console.WriteLine("Introduceti numarul de elemente");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti " + n + "numere:");


            int[] vector = new int[n];
            for (int i = 0; i < n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());

            }
            int[] inversVector = InversareVector(vector);
            Console.WriteLine("Inversul vectorului este:");
            foreach (var numar in inversVector)
            {
                Console.WriteLine(numar + "");

            }
            static int[] InversareVector(int[] vector)
            {
                int StartIndex = 0;
                for (int i = vector.Length - 1; i >= vector.Length / 2; i--)
                {

                    int aux = vector[i];
                    vector[i] = vector[StartIndex];
                    vector[StartIndex] = aux;
                    StartIndex++;
                }
                return vector;

            }

        }
    }
}

        
    
    

    

