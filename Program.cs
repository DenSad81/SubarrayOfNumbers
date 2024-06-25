using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[30];
        Random random = new Random();
        int arrayMinValue = 0;
        int arrayMaxValue = 3;
        int quantityOfVolumeForOneDigit = 2;
        int rowForPrintArray = 0;
        int rowForPrintRezult = 5;
        int countRowForPrintRepit = 0;
        int counter = 0;
        int maxCounter = 0;
        int digitWhouIsMaxRepit = 0;

        for (int i = 0; i < array.Length; i++)
            array[i] = random.Next(arrayMinValue, arrayMaxValue);

        for (int i = 0; i < array.Length; i++)
        {
            Console.SetCursorPosition(i * quantityOfVolumeForOneDigit, rowForPrintArray);
            Console.Write(array[i]);
        }

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] == array[i])
                counter++;

            if (array[i - 1] != array[i])
                counter = 0;

            if (counter > maxCounter)
            {
                maxCounter = counter;
                digitWhouIsMaxRepit = array[i - 1];
            }
        }

        Console.WriteLine();
        Console.SetCursorPosition(0, rowForPrintRezult + countRowForPrintRepit);
        Console.WriteLine("Число " + digitWhouIsMaxRepit + "   Максимально повторяется раз " + maxCounter);
        Console.WriteLine();
    }
}