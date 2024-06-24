using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[40];
        Random random = new Random();
        int arrayMinValue = 0;
        int arrayMaxValue = 3;
        int quantityOfVolumeForOneDigit = 2;
        int rowForPrintArray = 0;
        int rowForPrintLokalMax = 1;
        int rowForPrintRepit = 3;
        int rowForPrintRezult = 5;
        int countRowForPrintRepit = 0;
        int quantityOfRepit = 0;
        int quantityOfRepitMax = 0;
        int digitWhouIsMaxRepit = 0;

        for (int i = 0; i < array.Length; i++)
            array[i] = random.Next(arrayMinValue, arrayMaxValue);

        for (int i = 0; i < array.Length; i++)
        {
            Console.SetCursorPosition(i * quantityOfVolumeForOneDigit, rowForPrintArray);
            Console.Write(array[i]);
        }

        int posInArray = 1;

        while (posInArray < array.Length)
        {
            if (array[posInArray - 1] == array[posInArray])
            {
                quantityOfRepit++;
                Console.SetCursorPosition((posInArray) * quantityOfVolumeForOneDigit, rowForPrintLokalMax);
                Console.Write(quantityOfRepit);
            }
            else
            {
                if (quantityOfRepit > 0)
                {
                    Console.SetCursorPosition(0, rowForPrintRepit + countRowForPrintRepit);
                    Console.WriteLine(array[posInArray - 1] + " " + quantityOfRepit);
                    countRowForPrintRepit++;

                    if (quantityOfRepit > quantityOfRepitMax)
                    {
                        quantityOfRepitMax = quantityOfRepit;
                        digitWhouIsMaxRepit = array[posInArray-1];
                    }

                    quantityOfRepit = 0;
                }
            }

            posInArray++;
        }

        if (quantityOfRepit > 0)
        {
            Console.SetCursorPosition(0, rowForPrintRepit + countRowForPrintRepit);
            Console.WriteLine(array[posInArray - 1] + " " + quantityOfRepit);
            countRowForPrintRepit++;

            if (quantityOfRepit > quantityOfRepitMax)
            {
                quantityOfRepitMax = quantityOfRepit;
                digitWhouIsMaxRepit = array[posInArray-1];
            }

            quantityOfRepit = 0;
        }

        Console.WriteLine();
        Console.SetCursorPosition(0, rowForPrintRezult + countRowForPrintRepit);
        Console.WriteLine("Число " + digitWhouIsMaxRepit + "   Максимально повторяется раз " + quantityOfRepitMax);
        Console.WriteLine();
    }
}