using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 2, 2, 2, 4, 4, 4 };
        int quantityOfRepit = 0;
        int quantityOfRepitMax = 0;
        int digitWhouIsMaxRepit = 0;

        for (int i = 0; i < array.Length; i++)
            Console.Write(array[i]);

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] == array[i])
                quantityOfRepit++;
            else
                quantityOfRepit = 0;

            if (quantityOfRepit > quantityOfRepitMax)
            {
                quantityOfRepitMax = quantityOfRepit;
                digitWhouIsMaxRepit = array[i - 1];
            }
        }

        Console.WriteLine();
        Console.WriteLine("Число " + digitWhouIsMaxRepit + "   Максимально повторяется раз " + quantityOfRepitMax);
    }
}